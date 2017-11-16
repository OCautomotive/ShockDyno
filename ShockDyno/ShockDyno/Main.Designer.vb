<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DynoReading
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.tbOutPut = New System.Windows.Forms.TextBox()
        Me.btStart = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDirection = New System.Windows.Forms.Label()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lbVoltage = New System.Windows.Forms.Label()
        Me.tbDistance = New System.Windows.Forms.TextBox()
        Me.lbDistance = New System.Windows.Forms.Label()
        Me.lbCalStart = New System.Windows.Forms.Label()
        Me.lbCalEnding = New System.Windows.Forms.Label()
        Me.tbCalDistance = New System.Windows.Forms.TextBox()
        Me.lblCalInstructions = New System.Windows.Forms.Label()
        Me.chtOutput1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCalibrateMass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCellZero = New System.Windows.Forms.Label()
        Me.lblCellCalibarated = New System.Windows.Forms.Label()
        Me.tbCellVoltage = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbForce = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadCellCalibrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ChartTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.chtOutput1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbOutPut
        '
        Me.tbOutPut.Location = New System.Drawing.Point(11, 47)
        Me.tbOutPut.Name = "tbOutPut"
        Me.tbOutPut.ReadOnly = True
        Me.tbOutPut.Size = New System.Drawing.Size(100, 20)
        Me.tbOutPut.TabIndex = 0
        '
        'btStart
        '
        Me.btStart.Location = New System.Drawing.Point(9, 500)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(75, 23)
        Me.btStart.TabIndex = 1
        Me.btStart.Text = "Start"
        Me.btStart.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'lblDirection
        '
        Me.lblDirection.AutoSize = True
        Me.lblDirection.Location = New System.Drawing.Point(60, 144)
        Me.lblDirection.Name = "lblDirection"
        Me.lblDirection.Size = New System.Drawing.Size(16, 13)
        Me.lblDirection.TabIndex = 4
        Me.lblDirection.Text = "..."
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Location = New System.Drawing.Point(60, 158)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(16, 13)
        Me.lblSpeed.TabIndex = 5
        Me.lblSpeed.Text = "..."
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(90, 500)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 6
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lbVoltage
        '
        Me.lbVoltage.AutoSize = True
        Me.lbVoltage.Location = New System.Drawing.Point(10, 30)
        Me.lbVoltage.Name = "lbVoltage"
        Me.lbVoltage.Size = New System.Drawing.Size(67, 13)
        Me.lbVoltage.TabIndex = 9
        Me.lbVoltage.Text = "LDS Voltage"
        '
        'tbDistance
        '
        Me.tbDistance.Location = New System.Drawing.Point(12, 123)
        Me.tbDistance.Name = "tbDistance"
        Me.tbDistance.ReadOnly = True
        Me.tbDistance.Size = New System.Drawing.Size(100, 20)
        Me.tbDistance.TabIndex = 10
        '
        'lbDistance
        '
        Me.lbDistance.AutoSize = True
        Me.lbDistance.Location = New System.Drawing.Point(10, 106)
        Me.lbDistance.Name = "lbDistance"
        Me.lbDistance.Size = New System.Drawing.Size(95, 13)
        Me.lbDistance.TabIndex = 11
        Me.lbDistance.Text = "Distance in Inches"
        '
        'lbCalStart
        '
        Me.lbCalStart.AutoSize = True
        Me.lbCalStart.Location = New System.Drawing.Point(127, 241)
        Me.lbCalStart.Name = "lbCalStart"
        Me.lbCalStart.Size = New System.Drawing.Size(16, 13)
        Me.lbCalStart.TabIndex = 12
        Me.lbCalStart.Text = "..."
        '
        'lbCalEnding
        '
        Me.lbCalEnding.AutoSize = True
        Me.lbCalEnding.Location = New System.Drawing.Point(127, 271)
        Me.lbCalEnding.Name = "lbCalEnding"
        Me.lbCalEnding.Size = New System.Drawing.Size(16, 13)
        Me.lbCalEnding.TabIndex = 13
        Me.lbCalEnding.Text = "..."
        '
        'tbCalDistance
        '
        Me.tbCalDistance.Location = New System.Drawing.Point(10, 206)
        Me.tbCalDistance.MaxLength = 4
        Me.tbCalDistance.Name = "tbCalDistance"
        Me.tbCalDistance.ReadOnly = True
        Me.tbCalDistance.Size = New System.Drawing.Size(100, 20)
        Me.tbCalDistance.TabIndex = 14
        '
        'lblCalInstructions
        '
        Me.lblCalInstructions.AutoSize = True
        Me.lblCalInstructions.Location = New System.Drawing.Point(10, 189)
        Me.lblCalInstructions.Name = "lblCalInstructions"
        Me.lblCalInstructions.Size = New System.Drawing.Size(123, 13)
        Me.lblCalInstructions.TabIndex = 15
        Me.lblCalInstructions.Text = "Stroke Distance (inches)"
        '
        'chtOutput1
        '
        ChartArea3.AxisX.Title = "Velocity (in/s)"
        ChartArea3.AxisY.Title = "Force (lbs)"
        ChartArea3.Name = "ChartArea1"
        Me.chtOutput1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chtOutput1.Legends.Add(Legend3)
        Me.chtOutput1.Location = New System.Drawing.Point(195, 31)
        Me.chtOutput1.MaximumSize = New System.Drawing.Size(1500, 1625)
        Me.chtOutput1.MinimumSize = New System.Drawing.Size(225, 244)
        Me.chtOutput1.Name = "chtOutput1"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series5.Color = System.Drawing.Color.Red
        Series5.Legend = "Legend1"
        Series5.Name = "Rebound"
        Series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Single]
        Series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Single]
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series6.Legend = "Legend1"
        Series6.Name = "Bump"
        Me.chtOutput1.Series.Add(Series5)
        Me.chtOutput1.Series.Add(Series6)
        Me.chtOutput1.Size = New System.Drawing.Size(808, 591)
        Me.chtOutput1.TabIndex = 16
        Me.chtOutput1.Text = "Output 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Speed:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Direction:"
        '
        'tbCalibrateMass
        '
        Me.tbCalibrateMass.Location = New System.Drawing.Point(9, 343)
        Me.tbCalibrateMass.MaxLength = 4
        Me.tbCalibrateMass.Name = "tbCalibrateMass"
        Me.tbCalibrateMass.ReadOnly = True
        Me.tbCalibrateMass.Size = New System.Drawing.Size(100, 20)
        Me.tbCalibrateMass.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Calibration Mass (Lbs)"
        '
        'lblCellZero
        '
        Me.lblCellZero.AutoSize = True
        Me.lblCellZero.Location = New System.Drawing.Point(114, 299)
        Me.lblCellZero.Name = "lblCellZero"
        Me.lblCellZero.Size = New System.Drawing.Size(16, 13)
        Me.lblCellZero.TabIndex = 24
        Me.lblCellZero.Text = "..."
        '
        'lblCellCalibarated
        '
        Me.lblCellCalibarated.AutoSize = True
        Me.lblCellCalibarated.Location = New System.Drawing.Point(128, 380)
        Me.lblCellCalibarated.Name = "lblCellCalibarated"
        Me.lblCellCalibarated.Size = New System.Drawing.Size(16, 13)
        Me.lblCellCalibarated.TabIndex = 25
        Me.lblCellCalibarated.Text = "..."
        '
        'tbCellVoltage
        '
        Me.tbCellVoltage.Location = New System.Drawing.Point(11, 85)
        Me.tbCellVoltage.Name = "tbCellVoltage"
        Me.tbCellVoltage.ReadOnly = True
        Me.tbCellVoltage.Size = New System.Drawing.Size(100, 20)
        Me.tbCellVoltage.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Load Cell Voltage"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 483)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Start/Stop Charting"
        '
        'tbForce
        '
        Me.tbForce.Location = New System.Drawing.Point(10, 422)
        Me.tbForce.Name = "tbForce"
        Me.tbForce.ReadOnly = True
        Me.tbForce.Size = New System.Drawing.Size(30, 20)
        Me.tbForce.TabIndex = 30
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferencesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1013, 24)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PreferencesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadCellCalibrationToolStripMenuItem, Me.ChartTestToolStripMenuItem})
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.PreferencesToolStripMenuItem.Text = "Preferences"
        '
        'LoadCellCalibrationToolStripMenuItem
        '
        Me.LoadCellCalibrationToolStripMenuItem.Name = "LoadCellCalibrationToolStripMenuItem"
        Me.LoadCellCalibrationToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoadCellCalibrationToolStripMenuItem.Text = "Calibration"
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(6, 578)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(99, 19)
        Me.btnExcel.TabIndex = 32
        Me.btnExcel.Text = "Send To Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(5, 602)
        Me.txtPath.MaxLength = 4
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(160, 20)
        Me.txtPath.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 380)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Calibrated Cell Voltage:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Voltage at Cell Zero:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Voltage at end of stroke:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Voltage at start of stroke:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 403)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Force (lbs)"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(6, 528)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(99, 19)
        Me.btnClear.TabIndex = 29
        Me.btnClear.Text = "Clear Chart"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'ChartTestToolStripMenuItem
        '
        Me.ChartTestToolStripMenuItem.Name = "ChartTestToolStripMenuItem"
        Me.ChartTestToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ChartTestToolStripMenuItem.Text = "Chart Test"
        '
        'DynoReading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 632)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.tbForce)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbCellVoltage)
        Me.Controls.Add(Me.lblCellCalibarated)
        Me.Controls.Add(Me.lblCellZero)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbCalibrateMass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chtOutput1)
        Me.Controls.Add(Me.lblCalInstructions)
        Me.Controls.Add(Me.tbCalDistance)
        Me.Controls.Add(Me.lbCalEnding)
        Me.Controls.Add(Me.lbCalStart)
        Me.Controls.Add(Me.lbDistance)
        Me.Controls.Add(Me.tbDistance)
        Me.Controls.Add(Me.lbVoltage)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.lblDirection)
        Me.Controls.Add(Me.btStart)
        Me.Controls.Add(Me.tbOutPut)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DynoReading"
        Me.Text = "Dyno Readout"
        CType(Me.chtOutput1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbOutPut As System.Windows.Forms.TextBox
    Friend WithEvents btStart As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblDirection As System.Windows.Forms.Label
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents lbVoltage As System.Windows.Forms.Label
    Friend WithEvents tbDistance As System.Windows.Forms.TextBox
    Friend WithEvents lbDistance As System.Windows.Forms.Label
    Friend WithEvents lbCalStart As System.Windows.Forms.Label
    Friend WithEvents lbCalEnding As System.Windows.Forms.Label
    Friend WithEvents tbCalDistance As System.Windows.Forms.TextBox
    Friend WithEvents lblCalInstructions As System.Windows.Forms.Label
    Friend WithEvents chtOutput1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbCalibrateMass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCellZero As System.Windows.Forms.Label
    Friend WithEvents lblCellCalibarated As System.Windows.Forms.Label
    Friend WithEvents tbCellVoltage As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbForce As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadCellCalibrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents ChartTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
