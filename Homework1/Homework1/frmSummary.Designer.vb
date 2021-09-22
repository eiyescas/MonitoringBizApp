<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummary
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
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.picDeviceResult = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDeviceResult = New System.Windows.Forms.Label()
        Me.lblPlanResult = New System.Windows.Forms.Label()
        Me.lblFeeResult = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        CType(Me.picDeviceResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSummary
        '
        Me.lblSummary.BackColor = System.Drawing.Color.White
        Me.lblSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummary.Location = New System.Drawing.Point(59, 9)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(335, 34)
        Me.lblSummary.TabIndex = 0
        Me.lblSummary.Text = "Summary of Purchase"
        Me.lblSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(334, 264)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(109, 27)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Confrim and Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'picDeviceResult
        '
        Me.picDeviceResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.picDeviceResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDeviceResult.Location = New System.Drawing.Point(314, 70)
        Me.picDeviceResult.Name = "picDeviceResult"
        Me.picDeviceResult.Size = New System.Drawing.Size(129, 111)
        Me.picDeviceResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDeviceResult.TabIndex = 2
        Me.picDeviceResult.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Device: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Plan: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Installation: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 28)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total Cost: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDeviceResult
        '
        Me.lblDeviceResult.BackColor = System.Drawing.Color.White
        Me.lblDeviceResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDeviceResult.Location = New System.Drawing.Point(79, 70)
        Me.lblDeviceResult.Name = "lblDeviceResult"
        Me.lblDeviceResult.Size = New System.Drawing.Size(216, 29)
        Me.lblDeviceResult.TabIndex = 7
        Me.lblDeviceResult.Text = "Label5"
        Me.lblDeviceResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPlanResult
        '
        Me.lblPlanResult.BackColor = System.Drawing.Color.White
        Me.lblPlanResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlanResult.Location = New System.Drawing.Point(79, 131)
        Me.lblPlanResult.Name = "lblPlanResult"
        Me.lblPlanResult.Size = New System.Drawing.Size(216, 29)
        Me.lblPlanResult.TabIndex = 8
        Me.lblPlanResult.Text = "Label6"
        Me.lblPlanResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFeeResult
        '
        Me.lblFeeResult.BackColor = System.Drawing.Color.White
        Me.lblFeeResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFeeResult.Location = New System.Drawing.Point(79, 192)
        Me.lblFeeResult.Name = "lblFeeResult"
        Me.lblFeeResult.Size = New System.Drawing.Size(216, 29)
        Me.lblFeeResult.TabIndex = 9
        Me.lblFeeResult.Text = "Label7"
        Me.lblFeeResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalCost
        '
        Me.lblTotalCost.BackColor = System.Drawing.Color.White
        Me.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCost.Location = New System.Drawing.Point(79, 262)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(216, 29)
        Me.lblTotalCost.TabIndex = 10
        Me.lblTotalCost.Text = "Label8"
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(455, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblFeeResult)
        Me.Controls.Add(Me.lblPlanResult)
        Me.Controls.Add(Me.lblDeviceResult)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picDeviceResult)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblSummary)
        Me.Name = "frmSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Summary of Total Costs"
        CType(Me.picDeviceResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblSummary As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents picDeviceResult As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDeviceResult As Label
    Friend WithEvents lblPlanResult As Label
    Friend WithEvents lblFeeResult As Label
    Friend WithEvents lblTotalCost As Label
End Class
