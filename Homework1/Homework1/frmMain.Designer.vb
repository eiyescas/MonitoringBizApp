<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCostPlan = New System.Windows.Forms.Label()
        Me.lblCostDevice = New System.Windows.Forms.Label()
        Me.chkFee = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picDevice = New System.Windows.Forms.PictureBox()
        Me.radLevel4 = New System.Windows.Forms.RadioButton()
        Me.radLevel3 = New System.Windows.Forms.RadioButton()
        Me.radLevel2 = New System.Windows.Forms.RadioButton()
        Me.radLevel1 = New System.Windows.Forms.RadioButton()
        Me.grpPlan = New System.Windows.Forms.GroupBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.radModel3 = New System.Windows.Forms.RadioButton()
        Me.radModel2 = New System.Windows.Forms.RadioButton()
        Me.radModel1 = New System.Windows.Forms.RadioButton()
        Me.lblCostFee = New System.Windows.Forms.Label()
        Me.grpDevice = New System.Windows.Forms.GroupBox()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.picDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPlan.SuspendLayout()
        Me.grpDevice.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(476, 374)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 17)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Cost"
        '
        'lblCostPlan
        '
        Me.lblCostPlan.BackColor = System.Drawing.Color.White
        Me.lblCostPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCostPlan.Location = New System.Drawing.Point(476, 218)
        Me.lblCostPlan.Name = "lblCostPlan"
        Me.lblCostPlan.Size = New System.Drawing.Size(70, 31)
        Me.lblCostPlan.TabIndex = 29
        '
        'lblCostDevice
        '
        Me.lblCostDevice.BackColor = System.Drawing.Color.White
        Me.lblCostDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCostDevice.Location = New System.Drawing.Point(476, 29)
        Me.lblCostDevice.Name = "lblCostDevice"
        Me.lblCostDevice.Size = New System.Drawing.Size(70, 31)
        Me.lblCostDevice.TabIndex = 28
        '
        'chkFee
        '
        Me.chkFee.AutoSize = True
        Me.chkFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFee.Location = New System.Drawing.Point(12, 423)
        Me.chkFee.Name = "chkFee"
        Me.chkFee.Size = New System.Drawing.Size(161, 19)
        Me.chkFee.TabIndex = 27
        Me.chkFee.Text = "Optional: Installation Fee"
        Me.chkFee.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(476, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Cost"
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.White
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescription.Location = New System.Drawing.Point(174, 239)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(245, 65)
        Me.lblDescription.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(174, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(476, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Cost"
        '
        'picDevice
        '
        Me.picDevice.BackColor = System.Drawing.Color.Silver
        Me.picDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDevice.Location = New System.Drawing.Point(172, 5)
        Me.picDevice.Name = "picDevice"
        Me.picDevice.Size = New System.Drawing.Size(247, 178)
        Me.picDevice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDevice.TabIndex = 22
        Me.picDevice.TabStop = False
        '
        'radLevel4
        '
        Me.radLevel4.AutoSize = True
        Me.radLevel4.Location = New System.Drawing.Point(0, 141)
        Me.radLevel4.Name = "radLevel4"
        Me.radLevel4.Size = New System.Drawing.Size(65, 19)
        Me.radLevel4.TabIndex = 3
        Me.radLevel4.TabStop = True
        Me.radLevel4.Text = "Level-4"
        Me.radLevel4.UseVisualStyleBackColor = True
        '
        'radLevel3
        '
        Me.radLevel3.AutoSize = True
        Me.radLevel3.Location = New System.Drawing.Point(0, 109)
        Me.radLevel3.Name = "radLevel3"
        Me.radLevel3.Size = New System.Drawing.Size(65, 19)
        Me.radLevel3.TabIndex = 2
        Me.radLevel3.TabStop = True
        Me.radLevel3.Text = "Level-3"
        Me.radLevel3.UseVisualStyleBackColor = True
        '
        'radLevel2
        '
        Me.radLevel2.AutoSize = True
        Me.radLevel2.Location = New System.Drawing.Point(0, 77)
        Me.radLevel2.Name = "radLevel2"
        Me.radLevel2.Size = New System.Drawing.Size(65, 19)
        Me.radLevel2.TabIndex = 1
        Me.radLevel2.TabStop = True
        Me.radLevel2.Text = "Level-2"
        Me.radLevel2.UseVisualStyleBackColor = True
        '
        'radLevel1
        '
        Me.radLevel1.AutoSize = True
        Me.radLevel1.Location = New System.Drawing.Point(0, 45)
        Me.radLevel1.Name = "radLevel1"
        Me.radLevel1.Size = New System.Drawing.Size(65, 19)
        Me.radLevel1.TabIndex = 0
        Me.radLevel1.TabStop = True
        Me.radLevel1.Text = "Level-1"
        Me.radLevel1.UseVisualStyleBackColor = True
        '
        'grpPlan
        '
        Me.grpPlan.Controls.Add(Me.radLevel4)
        Me.grpPlan.Controls.Add(Me.radLevel3)
        Me.grpPlan.Controls.Add(Me.radLevel2)
        Me.grpPlan.Controls.Add(Me.radLevel1)
        Me.grpPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPlan.Location = New System.Drawing.Point(12, 208)
        Me.grpPlan.Name = "grpPlan"
        Me.grpPlan.Size = New System.Drawing.Size(128, 166)
        Me.grpPlan.TabIndex = 18
        Me.grpPlan.TabStop = False
        Me.grpPlan.Text = "Monitoring Monthly Plans"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(434, 474)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(112, 31)
        Me.btnQuit.TabIndex = 21
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(222, 474)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 31)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(8, 474)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(112, 31)
        Me.btnTotal.TabIndex = 19
        Me.btnTotal.Text = "Check total costs"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'radModel3
        '
        Me.radModel3.AutoSize = True
        Me.radModel3.Location = New System.Drawing.Point(3, 102)
        Me.radModel3.Name = "radModel3"
        Me.radModel3.Size = New System.Drawing.Size(71, 19)
        Me.radModel3.TabIndex = 2
        Me.radModel3.TabStop = True
        Me.radModel3.Text = "Model-3"
        Me.radModel3.UseVisualStyleBackColor = True
        '
        'radModel2
        '
        Me.radModel2.AutoSize = True
        Me.radModel2.Location = New System.Drawing.Point(3, 61)
        Me.radModel2.Name = "radModel2"
        Me.radModel2.Size = New System.Drawing.Size(71, 19)
        Me.radModel2.TabIndex = 1
        Me.radModel2.TabStop = True
        Me.radModel2.Text = "Model-2"
        Me.radModel2.UseVisualStyleBackColor = True
        '
        'radModel1
        '
        Me.radModel1.AutoSize = True
        Me.radModel1.Location = New System.Drawing.Point(3, 20)
        Me.radModel1.Name = "radModel1"
        Me.radModel1.Size = New System.Drawing.Size(71, 19)
        Me.radModel1.TabIndex = 0
        Me.radModel1.Text = "Model-1"
        Me.radModel1.UseVisualStyleBackColor = True
        '
        'lblCostFee
        '
        Me.lblCostFee.BackColor = System.Drawing.Color.White
        Me.lblCostFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCostFee.Location = New System.Drawing.Point(476, 391)
        Me.lblCostFee.Name = "lblCostFee"
        Me.lblCostFee.Size = New System.Drawing.Size(70, 31)
        Me.lblCostFee.TabIndex = 31
        '
        'grpDevice
        '
        Me.grpDevice.Controls.Add(Me.radModel3)
        Me.grpDevice.Controls.Add(Me.radModel2)
        Me.grpDevice.Controls.Add(Me.radModel1)
        Me.grpDevice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDevice.Location = New System.Drawing.Point(12, 5)
        Me.grpDevice.Name = "grpDevice"
        Me.grpDevice.Size = New System.Drawing.Size(128, 127)
        Me.grpDevice.TabIndex = 17
        Me.grpDevice.TabStop = False
        Me.grpDevice.Text = "Monitoring Devices"
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(174, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(245, 34)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Note: An inital 3 months of monitoring plan cost "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(582, 517)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblCostPlan)
        Me.Controls.Add(Me.lblCostDevice)
        Me.Controls.Add(Me.chkFee)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picDevice)
        Me.Controls.Add(Me.grpPlan)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.lblCostFee)
        Me.Controls.Add(Me.grpDevice)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Esm's Secuirty Co. "
        CType(Me.picDevice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPlan.ResumeLayout(False)
        Me.grpPlan.PerformLayout()
        Me.grpDevice.ResumeLayout(False)
        Me.grpDevice.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents lblCostPlan As Label
    Friend WithEvents lblCostDevice As Label
    Friend WithEvents chkFee As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents picDevice As PictureBox
    Friend WithEvents radLevel4 As RadioButton
    Friend WithEvents radLevel3 As RadioButton
    Friend WithEvents radLevel2 As RadioButton
    Friend WithEvents radLevel1 As RadioButton
    Friend WithEvents grpPlan As GroupBox
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents radModel3 As RadioButton
    Friend WithEvents radModel2 As RadioButton
    Friend WithEvents radModel1 As RadioButton
    Friend WithEvents lblCostFee As Label
    Friend WithEvents grpDevice As GroupBox
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents Label4 As Label
End Class
