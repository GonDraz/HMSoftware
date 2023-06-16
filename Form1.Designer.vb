<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlTop = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbNameProgram = New System.Windows.Forms.Label()
        Me.pnlLeft = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnCust = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRoom = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEmployee = New Guna.UI2.WinForms.Guna2Button()
        Me.lbQuit = New System.Windows.Forms.Label()
        Me.btnCheckIn = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlMain = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.lbNameUser = New System.Windows.Forms.Label()
        Me.pnlTop.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 24
        Me.Guna2Elipse1.TargetControl = Me
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lbNameProgram)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(960, 24)
        Me.pnlTop.TabIndex = 0
        '
        'lbNameProgram
        '
        Me.lbNameProgram.AutoSize = True
        Me.lbNameProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNameProgram.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.lbNameProgram.Location = New System.Drawing.Point(12, 4)
        Me.lbNameProgram.Name = "lbNameProgram"
        Me.lbNameProgram.Size = New System.Drawing.Size(108, 20)
        Me.lbNameProgram.TabIndex = 0
        Me.lbNameProgram.Text = "HMSoftware"
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.pnlLeft.Controls.Add(Me.lbNameUser)
        Me.pnlLeft.Controls.Add(Me.btnCust)
        Me.pnlLeft.Controls.Add(Me.btnRoom)
        Me.pnlLeft.Controls.Add(Me.btnEmployee)
        Me.pnlLeft.Controls.Add(Me.lbQuit)
        Me.pnlLeft.Controls.Add(Me.btnCheckIn)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 24)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(240, 516)
        Me.pnlLeft.TabIndex = 1
        '
        'btnCust
        '
        Me.btnCust.BorderRadius = 12
        Me.btnCust.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnCust.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnCust.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCust.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCust.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCust.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCust.FillColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnCust.Font = New System.Drawing.Font("Quicksand", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnCust.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnCust.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnCust.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnCust.Location = New System.Drawing.Point(25, 201)
        Me.btnCust.Name = "btnCust"
        Me.btnCust.Size = New System.Drawing.Size(180, 45)
        Me.btnCust.TabIndex = 4
        Me.btnCust.Text = "Khách Hàng"
        '
        'btnRoom
        '
        Me.btnRoom.BorderRadius = 12
        Me.btnRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnRoom.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRoom.FillColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnRoom.Font = New System.Drawing.Font("Quicksand", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnRoom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnRoom.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnRoom.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnRoom.Location = New System.Drawing.Point(25, 269)
        Me.btnRoom.Name = "btnRoom"
        Me.btnRoom.Size = New System.Drawing.Size(180, 45)
        Me.btnRoom.TabIndex = 3
        Me.btnRoom.Text = "Phòng"
        '
        'btnEmployee
        '
        Me.btnEmployee.BorderRadius = 12
        Me.btnEmployee.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnEmployee.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEmployee.FillColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnEmployee.Font = New System.Drawing.Font("Quicksand", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnEmployee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnEmployee.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnEmployee.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnEmployee.Location = New System.Drawing.Point(25, 329)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(180, 45)
        Me.btnEmployee.TabIndex = 2
        Me.btnEmployee.Text = "Nhân Sự"
        '
        'lbQuit
        '
        Me.lbQuit.AutoSize = True
        Me.lbQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQuit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.lbQuit.Location = New System.Drawing.Point(60, 459)
        Me.lbQuit.Name = "lbQuit"
        Me.lbQuit.Size = New System.Drawing.Size(105, 37)
        Me.lbQuit.TabIndex = 1
        Me.lbQuit.Text = "Thoát"
        '
        'btnCheckIn
        '
        Me.btnCheckIn.BorderRadius = 12
        Me.btnCheckIn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnCheckIn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnCheckIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCheckIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCheckIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCheckIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCheckIn.FillColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnCheckIn.Font = New System.Drawing.Font("Quicksand", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnCheckIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnCheckIn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnCheckIn.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnCheckIn.Location = New System.Drawing.Point(25, 137)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(180, 45)
        Me.btnCheckIn.TabIndex = 0
        Me.btnCheckIn.Text = "Đăng Ký"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(240, 24)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(720, 516)
        Me.pnlMain.TabIndex = 2
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.pnlTop
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'lbNameUser
        '
        Me.lbNameUser.AutoSize = True
        Me.lbNameUser.Font = New System.Drawing.Font("Quicksand", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNameUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.lbNameUser.Location = New System.Drawing.Point(19, 48)
        Me.lbNameUser.Name = "lbNameUser"
        Me.lbNameUser.Size = New System.Drawing.Size(83, 33)
        Me.lbNameUser.TabIndex = 5
        Me.lbNameUser.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(960, 540)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "HMSoftware"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlLeft As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents lbNameProgram As Label
    Friend WithEvents lbQuit As Label
    Friend WithEvents btnCheckIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCust As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRoom As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEmployee As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbNameUser As Label
End Class
