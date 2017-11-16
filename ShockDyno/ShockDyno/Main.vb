Imports System
Imports System.IO
Imports System.Configuration

Public Class DynoReading
    Dim myDaqBoard As New MccDaq.MccBoard(0)
    Dim dataVal As System.Int16
    Dim dataVal2 As System.Int16
    Dim engUnit As Single
    Dim engUnit2 As Single
    Dim previousReading As Single
    Dim counter As Int16 = 0
    Dim counter2 As Int16 = 0
    Dim previousReadingHigh As Single
    Dim previousReadingLow As Single
    Dim startingPos As Single
    Dim endingPos As Single
    Dim calStart As Single
    Dim calEnd As Single
    Dim m As Single
    Dim y As Single
    Dim v As Single = 0 'velocity
    Dim f As Single = 0 'force
    Dim chartTest As Integer = 0
    Dim cellZero As Single
    Dim cellCalibrated As Single
    Dim mC As Single 'Load Cell Slope
    Dim yC As Single 'y intercept for load cell
    Dim startTime As System.DateTime
    Dim endTime As System.DateTime
    Dim elapsedTime As Integer
    Dim forceReading As New List(Of Single)
    Dim p As Int16 = ConfigurationManager.AppSettings("LDSPERCISION")

    Private Sub btStart_Click(sender As System.Object, e As System.EventArgs) Handles btStart.Click

        chtOutput1.ChartAreas(0).AxisX.Minimum = 0
        chtOutput1.ChartAreas(0).AxisX.Maximum = 12
        chtOutput1.ChartAreas(0).AxisX.Interval = 1
        chtOutput1.ChartAreas(0).AxisY.Interval = 1

        Timer1.Start()


    End Sub


    Private Sub Timer1_Tick(sender As Object, e As System.EventArgs) Handles Timer1.Tick
        myDaqBoard.AIn(0, MccDaq.Range.Bip10Volts, dataVal)
        myDaqBoard.ToEngUnits(MccDaq.Range.Bip10Volts, dataVal, engUnit)

        myDaqBoard.AIn(1, MccDaq.Range.Bip10Volts, dataVal2)
        myDaqBoard.ToEngUnits(MccDaq.Range.Bip10Volts, dataVal2, engUnit2)

        tbOutPut.Text = Math.Round(engUnit, 2)
        tbCellVoltage.Text = Math.Round(engUnit2, 5)

        'need to compare position to where it was before to determine direction. What it does is compare the readings every X loops (counter). Setting a lower counter number makes the speed reading
        'more responsive, but also more susceptible to noise.
        counter = counter + 1
        If counter = ConfigurationManager.AppSettings("DIRECTIONSAMPLEWINDOW") Then
            myDaqBoard.ToEngUnits(MccDaq.Range.Bip10Volts, dataVal, previousReading)
            counter = 0
        End If


        'give a range to avoid noise ( like +- .01)
        previousReadingHigh = Math.Round(previousReading, p) + ConfigurationManager.AppSettings("LDSHIGH")
        previousReadingLow = Math.Round(previousReading, p) - ConfigurationManager.AppSettings("LDSLOW")

        'direction 
        If previousReadingHigh < Math.Round(engUnit, p) Then
            lblDirection.Text = "Rebound"
        ElseIf previousReadingLow > Math.Round(engUnit, p) Then
            lblDirection.Text = "Bump"
        End If

        'voltage to inches y=mx+b
        y = Math.Round(m * engUnit, 2)
        tbDistance.Text = y

        'speed calculation
        counter2 = counter2 + 1

        'voltage to mass y=mx+b
        'cell zero is added to the x vales so that no-load is equal to zero. voltage is negative) 
        yC = Math.Round(mC * (engUnit2 - cellZero), 2)
        f = yC

        If ConfigurationManager.AppSettings("FORCEAVERAGE") = True Then
            forceReading.Add(f)
            If counter2 = ConfigurationManager.AppSettings("SPEEDSAMPLEWINDOW") Then
                forceReading.Remove(forceReading.Max())
                forceReading.Remove(forceReading.Min())
                f = forceReading.Average()
                forceReading.Clear()
            End If
        End If

        If counter2 = 1 Then
            startingPos = y
            startTime = System.DateTime.Now


        ElseIf counter2 = ConfigurationManager.AppSettings("SPEEDSAMPLEWINDOW") Then
            endingPos = y
            endTime = System.DateTime.Now

            elapsedTime = endTime.Millisecond - startTime.Millisecond

            'time is in milliseconds, divide by 1000 to get seconds.
            v = Math.Round(Math.Abs(((endingPos - startingPos) / elapsedTime) * 1000), 2)
            lblSpeed.Text = v

            tbForce.Text = f

            'If lblDirection.Text = "Rebound" Then
            '    f = Math.Abs(f)
            'End If
            'this is in this if statement so that both variables are reported at the same time.
            charting1(v, f, lblDirection.Text)
            counter2 = 0
        End If




    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        Timer1.Stop()
    End Sub

    Private Sub btnCalStart_Click(sender As System.Object, e As System.EventArgs)
        myDaqBoard.AIn(0, MccDaq.Range.Bip10Volts, dataVal)
        myDaqBoard.ToEngUnits(MccDaq.Range.Bip10Volts, dataVal, calStart)

        lbCalStart.Text = calStart
    End Sub

    Private Sub btnCalEnd_Click(sender As System.Object, e As System.EventArgs)
        myDaqBoard.AIn(0, MccDaq.Range.Bip10Volts, dataVal)
        myDaqBoard.ToEngUnits(MccDaq.Range.Bip10Volts, dataVal, calEnd)


        m = Convert.ToSingle(tbCalDistance.Text) / (calStart - calEnd)

        lbCalEnding.Text = calEnd

    End Sub

    Private Sub charting1(v As Single, f As Single, direction As String)
        If v > ConfigurationManager.AppSettings("MINVELOCITY") Then
            If direction = "Rebound" Then
                chtOutput1.Series(0).Points.AddXY(v, f)

            ElseIf direction = "Bump" Then
                chtOutput1.Series(1).Points.AddXY(v, f)

            End If
        End If


        'chtOutput1.Series(0).Points.AddXY(0, 0)
        'chtOutput1.Series(0).Points.AddXY(1.5, 5)
        'chtOutput1.Series(0).Points.AddXY(2, 6)
        'chtOutput1.Series(0).Points.AddXY(2.2, 7)
        'chtOutput1.Series(0).Points.AddXY(2.3, 0)
        'chtOutput1.Series(0).Points.AddXY(2.42, 5)
        'chtOutput1.Series(0).Points.AddXY(3, 6)
        'chtOutput1.Series(0).Points.AddXY(4, 7)

        'chtOutput1.Series(1).Points.AddXY(0, 0)
        'chtOutput1.Series(1).Points.AddXY(1.5, -5)
        'chtOutput1.Series(1).Points.AddXY(2, -6)
        'chtOutput1.Series(1).Points.AddXY(2.2, -7)

        'removes the oldest data to prevent buffer overrun.
        If chtOutput1.Series(0).Points.Count = 2000 Then
            chtOutput1.Series(0).Points.Remove(chtOutput1.Series(0).Points.Item(0))

        End If

        If chtOutput1.Series(1).Points.Count = 2000 Then
            chtOutput1.Series(1).Points.Remove(chtOutput1.Series(1).Points.Item(0))

        End If
    End Sub

    Private Sub btnChart_Click(sender As System.Object, e As System.EventArgs)



    End Sub

    Private Sub DynoReading_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        chtOutput1.Width = Me.Width - 225
        chtOutput1.Height = Me.Height - 71
    End Sub

    Private Sub btnZeroCell_Click(sender As System.Object, e As System.EventArgs)
        myDaqBoard.AIn(1, MccDaq.Range.Bip10Volts, dataVal2)
        myDaqBoard.ToEngUnits(MccDaq.Range.Bip10Volts, dataVal2, cellZero)

        lblCellZero.Text = cellZero
    End Sub

    Private Sub btnCalibrateCell_Click(sender As System.Object, e As System.EventArgs)
        myDaqBoard.AIn(1, MccDaq.Range.Bip10Volts, dataVal2)
        myDaqBoard.ToEngUnits(MccDaq.Range.Bip10Volts, dataVal2, cellCalibrated)

        Try
            If tbCalibrateMass.Text <> "" Then
                mC = Convert.ToSingle(tbCalibrateMass.Text) / (cellCalibrated - cellZero)
                lblCellCalibarated.Text = cellCalibrated
            End If
        Catch ex As Exception
            lblCellCalibarated.Text = ex.ToString
        End Try

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        chtOutput1.Series(0).Points.Clear()
        chtOutput1.Series(1).Points.Clear()

    End Sub

    Private Sub LoadCellCalibrationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoadCellCalibrationToolStripMenuItem.Click
        cellCalibration.Show()
    End Sub

    Private Sub DynoReading_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        calStart = My.Settings.LDSSTART
        lbCalStart.Text = My.Settings.LDSSTART.ToString()
        calEnd = My.Settings.LDSEND
        lbCalEnding.Text = My.Settings.LDSEND.ToString()
        cellCalibrated = My.Settings.LCCAL
        tbCalDistance.Text = My.Settings.STROKEDISTANCE
        cellZero = My.Settings.LCZERO
        lblCellZero.Text = My.Settings.LCZERO.ToString()
        tbCalDistance.Text = My.Settings.STROKEDISTANCE
        lblCellCalibarated.Text = My.Settings.LCCAL.ToString()
        tbCalibrateMass.Text = My.Settings.LCMASS.ToString()



        m = My.Settings.STROKEDISTANCE / (calStart - calEnd)



        lblCellZero.Text = cellZero

        Try
            If tbCalibrateMass.Text <> "" Then
                mC = Convert.ToSingle(tbCalibrateMass.Text) / (cellCalibrated - cellZero)
                lblCellCalibarated.Text = cellCalibrated
            End If
        Catch ex As Exception
            lblCellCalibarated.Text = ex.ToString
        End Try

    End Sub

    Private Sub btnExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExcel.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            Dim oExcel As Microsoft.Office.Interop.Excel.Application
            Dim oBook As Microsoft.Office.Interop.Excel.Workbook
            Dim oSheet As Microsoft.Office.Interop.Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim rowIndex As Integer = 0


            Dim p As Integer = 1

            'Export the rows to excel file

            While p <= chtOutput1.Series(0).Points.Count
                oSheet.Cells(rowIndex + 1, 1) = chtOutput1.Series(0).Points(rowIndex).XValue
                oSheet.Cells(rowIndex + 1, 2) = chtOutput1.Series(0).Points(rowIndex).YValues
                rowIndex = rowIndex + 1
                p = p + 1
            End While
            p = 1
            rowIndex = 0
            While p <= chtOutput1.Series(1).Points.Count
                oSheet.Cells(rowIndex + 1, 3) = chtOutput1.Series(1).Points(rowIndex).XValue
                oSheet.Cells(rowIndex + 1, 4) = chtOutput1.Series(1).Points(rowIndex).YValues
                rowIndex = rowIndex + 1
                p = p + 1
            End While



            'Set final path
            Dim fileName As String = "\DynoResults" + ".xls"
            Dim finalPath = f.SelectedPath + fileName
            Dim path As String = Directory.GetCurrentDirectory()
            txtPath.Text = path + finalPath
            oSheet.Columns.AutoFit()
            'Save file in final path
            oBook.SaveAs(txtPath.Text, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, _
            Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, _
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            'Release the objects
            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            'Some time Office application does not quit after automation: 
            'so i am calling GC.Collect method.
            GC.Collect()

            MessageBox.Show("Export done successfully!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub ReleaseObject(ByVal o As Object)
        Try
            While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
            End While
        Catch
        Finally
            o = Nothing
        End Try
    End Sub

    Private Sub ChartTestToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChartTestToolStripMenuItem.Click
        While chartTest < 10
            charting1(chartTest, chartTest, "Rebound")
            charting1(chartTest, -chartTest, "Bump")
            chartTest = chartTest + 1
        End While
    End Sub
End Class

