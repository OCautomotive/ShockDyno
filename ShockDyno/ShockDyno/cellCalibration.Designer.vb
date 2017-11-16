<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cellCalibration
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
        Me.btnZeroCell = New System.Windows.Forms.Button()
        Me.tbCellZero = New System.Windows.Forms.TextBox()
        Me.tbCalibrateMass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalibrateCell = New System.Windows.Forms.Button()
        Me.tbCalVoltage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCalInstructions = New System.Windows.Forms.Label()
        Me.tbCalDistance = New System.Windows.Forms.TextBox()
        Me.lbCalEnding = New System.Windows.Forms.Label()
        Me.lbCalStart = New System.Windows.Forms.Label()
        Me.btnCalEnd = New System.Windows.Forms.Button()
        Me.btnCalStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnZeroCell
        '
        Me.btnZeroCell.Location = New System.Drawing.Point(12, 47)
        Me.btnZeroCell.Name = "btnZeroCell"
        Me.btnZeroCell.Size = New System.Drawing.Size(126, 23)
        Me.btnZeroCell.TabIndex = 21
        Me.btnZeroCell.Text = "Zero Load Cell"
        Me.btnZeroCell.UseVisualStyleBackColor = True
        '
        'tbCellZero
        '
        Me.tbCellZero.Location = New System.Drawing.Point(12, 21)
        Me.tbCellZero.Name = "tbCellZero"
        Me.tbCellZero.ReadOnly = True
        Me.tbCellZero.Size = New System.Drawing.Size(126, 20)
        Me.tbCellZero.TabIndex = 22
        '
        'tbCalibrateMass
        '
        Me.tbCalibrateMass.Location = New System.Drawing.Point(12, 100)
        Me.tbCalibrateMass.Name = "tbCalibrateMass"
        Me.tbCalibrateMass.Size = New System.Drawing.Size(126, 20)
        Me.tbCalibrateMass.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Enter a known weight in lbs"
        '
        'btnCalibrateCell
        '
        Me.btnCalibrateCell.Location = New System.Drawing.Point(12, 126)
        Me.btnCalibrateCell.Name = "btnCalibrateCell"
        Me.btnCalibrateCell.Size = New System.Drawing.Size(126, 23)
        Me.btnCalibrateCell.TabIndex = 25
        Me.btnCalibrateCell.Text = "Calibration Weight"
        Me.btnCalibrateCell.UseVisualStyleBackColor = True
        '
        'tbCalVoltage
        '
        Me.tbCalVoltage.Location = New System.Drawing.Point(12, 178)
        Me.tbCalVoltage.Name = "tbCalVoltage"
        Me.tbCalVoltage.ReadOnly = True
        Me.tbCalVoltage.Size = New System.Drawing.Size(126, 20)
        Me.tbCalVoltage.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Voltage @ zero"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Voltage @ weight"
        '
        'lblCalInstructions
        '
        Me.lblCalInstructions.AutoSize = True
        Me.lblCalInstructions.Location = New System.Drawing.Point(12, 216)
        Me.lblCalInstructions.Name = "lblCalInstructions"
        Me.lblCalInstructions.Size = New System.Drawing.Size(191, 13)
        Me.lblCalInstructions.TabIndex = 34
        Me.lblCalInstructions.Text = "Calibrate LDS Stroke Distance (inches)"
        '
        'tbCalDistance
        '
        Me.tbCalDistance.Location = New System.Drawing.Point(12, 233)
        Me.tbCalDistance.MaxLength = 4
        Me.tbCalDistance.Name = "tbCalDistance"
        Me.tbCalDistance.Size = New System.Drawing.Size(100, 20)
        Me.tbCalDistance.TabIndex = 33
        '
        'lbCalEnding
        '
        Me.lbCalEnding.AutoSize = True
        Me.lbCalEnding.Location = New System.Drawing.Point(10, 327)
        Me.lbCalEnding.Name = "lbCalEnding"
        Me.lbCalEnding.Size = New System.Drawing.Size(16, 13)
        Me.lbCalEnding.TabIndex = 32
        Me.lbCalEnding.Text = "..."
        '
        'lbCalStart
        '
        Me.lbCalStart.AutoSize = True
        Me.lbCalStart.Location = New System.Drawing.Point(12, 284)
        Me.lbCalStart.Name = "lbCalStart"
        Me.lbCalStart.Size = New System.Drawing.Size(16, 13)
        Me.lbCalStart.TabIndex = 31
        Me.lbCalStart.Text = "..."
        '
        'btnCalEnd
        '
        Me.btnCalEnd.Location = New System.Drawing.Point(11, 301)
        Me.btnCalEnd.Name = "btnCalEnd"
        Me.btnCalEnd.Size = New System.Drawing.Size(153, 23)
        Me.btnCalEnd.TabIndex = 30
        Me.btnCalEnd.Text = "Calibrate Ending Pos"
        Me.btnCalEnd.UseVisualStyleBackColor = True
        '
        'btnCalStart
        '
        Me.btnCalStart.Location = New System.Drawing.Point(12, 258)
        Me.btnCalStart.Name = "btnCalStart"
        Me.btnCalStart.Size = New System.Drawing.Size(153, 23)
        Me.btnCalStart.TabIndex = 29
        Me.btnCalStart.Text = "Calibrate Starting Pos"
        Me.btnCalStart.UseVisualStyleBackColor = True
        '
        'cellCalibration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 422)
        Me.Controls.Add(Me.lblCalInstructions)
        Me.Controls.Add(Me.tbCalDistance)
        Me.Controls.Add(Me.lbCalEnding)
        Me.Controls.Add(Me.lbCalStart)
        Me.Controls.Add(Me.btnCalEnd)
        Me.Controls.Add(Me.btnCalStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbCalVoltage)
        Me.Controls.Add(Me.btnCalibrateCell)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbCalibrateMass)
        Me.Controls.Add(Me.tbCellZero)
        Me.Controls.Add(Me.btnZeroCell)
        Me.Name = "cellCalibration"
        Me.Text = "Load Cell Calibration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnZeroCell As System.Windows.Forms.Button
    Friend WithEvents tbCellZero As System.Windows.Forms.TextBox
    Friend WithEvents tbCalibrateMass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCalibrateCell As System.Windows.Forms.Button
    Friend WithEvents tbCalVoltage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCalInstructions As System.Windows.Forms.Label
    Friend WithEvents tbCalDistance As System.Windows.Forms.TextBox
    Friend WithEvents lbCalEnding As System.Windows.Forms.Label
    Friend WithEvents lbCalStart As System.Windows.Forms.Label
    Friend WithEvents btnCalEnd As System.Windows.Forms.Button
    Friend WithEvents btnCalStart As System.Windows.Forms.Button
End Class
