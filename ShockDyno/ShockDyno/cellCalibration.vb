Public Class cellCalibration
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

    Private Sub btnZeroCell_Click(sender As System.Object, e As System.EventArgs) Handles btnZeroCell.Click
        
        myDaqBoard.AIn(1, MccDaq.Range.Bip10Volts, dataVal2)
        myDaqBoard.ToEngUnits(MccDaq.Range.Bip10Volts, dataVal2, cellZero)

        tbCellZero.Text = cellZero

        My.Settings.LCZERO = cellZero
        My.Settings.Save()

    End Sub

    Private Sub btnCalibrateCell_Click(sender As System.Object, e As System.EventArgs) Handles btnCalibrateCell.Click
        myDaqBoard.AIn(1, MccDaq.Range.Bip10Volts, dataVal2)
        myDaqBoard.ToEngUnits(MccDaq.Range.Bip10Volts, dataVal2, cellCalibrated)

        Try
            If tbCalibrateMass.Text <> "" Then
                mC = Convert.ToSingle(tbCalibrateMass.Text) / (cellCalibrated - cellZero)
                tbCalVoltage.Text = cellCalibrated
                My.Settings.LCCAL = cellCalibrated
                My.Settings.LCMASS = tbCalibrateMass.Text
                My.Settings.Save()
            End If
        Catch ex As Exception
            tbCalVoltage.Text = ex.ToString
        End Try
    End Sub


    Private Sub btnCalStart_Click(sender As System.Object, e As System.EventArgs) Handles btnCalStart.Click
        myDaqBoard.AIn(0, MccDaq.Range.Bip10Volts, dataVal)
        myDaqBoard.ToEngUnits(MccDaq.Range.Bip10Volts, dataVal, calStart)

        lbCalStart.Text = calStart
        My.Settings.LDSSTART = calStart

        My.Settings.STROKEDISTANCE = tbCalDistance.Text
        My.Settings.Save()

    End Sub

    Private Sub btnCalEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnCalEnd.Click
        myDaqBoard.AIn(0, MccDaq.Range.Bip10Volts, dataVal)
        myDaqBoard.ToEngUnits(MccDaq.Range.Bip10Volts, dataVal, calEnd)


        m = Convert.ToSingle(tbCalDistance.Text) / (calStart - calEnd)

        lbCalEnding.Text = calEnd
        My.Settings.LDSEND = calEnd
        My.Settings.Save()
    End Sub

    Private Sub cellCalibration_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        cellCalibrated = My.Settings.LCCAL
        tbCalibrateMass.Text = My.Settings.LCMASS.ToString()
        tbCalVoltage.Text = My.Settings.LCCAL.ToString()
        calStart = My.Settings.LDSSTART
        lbCalStart.Text = My.Settings.LDSSTART.ToString()
        calEnd = My.Settings.LDSEND
        lbCalEnding.Text = My.Settings.LDSEND.ToString()
        cellCalibrated = My.Settings.LCCAL
        tbCalDistance.Text = My.Settings.STROKEDISTANCE
        cellZero = My.Settings.LCZERO
        tbCellZero.Text = My.Settings.LCZERO.ToString()
        My.Settings.Save()

    End Sub
End Class