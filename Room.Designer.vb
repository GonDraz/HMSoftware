<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Room
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.btnAdd_room = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete_room = New Guna.UI2.WinForms.Guna2Button()
        Me.lblID_room = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblType = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblEmty = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblRate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbId_room = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbType = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbRate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dataViewRoom = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.nmrEmpty = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.btnEdit_room = New Guna.UI2.WinForms.Guna2Button()
        Me.textReset_room = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.dataViewRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrEmpty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'btnAdd_room
        '
        Me.btnAdd_room.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd_room.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd_room.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd_room.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd_room.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdd_room.ForeColor = System.Drawing.Color.White
        Me.btnAdd_room.Location = New System.Drawing.Point(437, 459)
        Me.btnAdd_room.Name = "btnAdd_room"
        Me.btnAdd_room.Size = New System.Drawing.Size(65, 45)
        Me.btnAdd_room.TabIndex = 12
        Me.btnAdd_room.Text = "Thêm"
        '
        'btnDelete_room
        '
        Me.btnDelete_room.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete_room.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete_room.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDelete_room.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDelete_room.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDelete_room.ForeColor = System.Drawing.Color.White
        Me.btnDelete_room.Location = New System.Drawing.Point(643, 459)
        Me.btnDelete_room.Name = "btnDelete_room"
        Me.btnDelete_room.Size = New System.Drawing.Size(65, 45)
        Me.btnDelete_room.TabIndex = 13
        Me.btnDelete_room.Text = "Xóa"
        '
        'lblID_room
        '
        Me.lblID_room.BackColor = System.Drawing.Color.Transparent
        Me.lblID_room.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID_room.Location = New System.Drawing.Point(469, 48)
        Me.lblID_room.Name = "lblID_room"
        Me.lblID_room.Size = New System.Drawing.Size(20, 22)
        Me.lblID_room.TabIndex = 14
        Me.lblID_room.Text = "ID"
        '
        'lblType
        '
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(434, 107)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(68, 22)
        Me.lblType.TabIndex = 15
        Me.lblType.Text = "Kiểu Loại"
        '
        'lblEmty
        '
        Me.lblEmty.BackColor = System.Drawing.Color.Transparent
        Me.lblEmty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmty.Location = New System.Drawing.Point(466, 160)
        Me.lblEmty.Name = "lblEmty"
        Me.lblEmty.Size = New System.Drawing.Size(23, 22)
        Me.lblEmty.TabIndex = 16
        Me.lblEmty.Text = "Số"
        '
        'lblRate
        '
        Me.lblRate.BackColor = System.Drawing.Color.Transparent
        Me.lblRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.Location = New System.Drawing.Point(431, 223)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(71, 22)
        Me.lblRate.TabIndex = 17
        Me.lblRate.Text = "Đánh Giá"
        '
        'tbId_room
        '
        Me.tbId_room.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbId_room.DefaultText = ""
        Me.tbId_room.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbId_room.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbId_room.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbId_room.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbId_room.Enabled = False
        Me.tbId_room.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbId_room.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbId_room.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbId_room.Location = New System.Drawing.Point(508, 45)
        Me.tbId_room.Name = "tbId_room"
        Me.tbId_room.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbId_room.PlaceholderText = ""
        Me.tbId_room.SelectedText = ""
        Me.tbId_room.Size = New System.Drawing.Size(200, 25)
        Me.tbId_room.TabIndex = 18
        '
        'tbType
        '
        Me.tbType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbType.DefaultText = ""
        Me.tbType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbType.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbType.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbType.Location = New System.Drawing.Point(508, 104)
        Me.tbType.Name = "tbType"
        Me.tbType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbType.PlaceholderText = ""
        Me.tbType.SelectedText = ""
        Me.tbType.Size = New System.Drawing.Size(200, 25)
        Me.tbType.TabIndex = 19
        '
        'tbRate
        '
        Me.tbRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbRate.DefaultText = ""
        Me.tbRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbRate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbRate.Location = New System.Drawing.Point(508, 223)
        Me.tbRate.Name = "tbRate"
        Me.tbRate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbRate.PlaceholderText = ""
        Me.tbRate.SelectedText = ""
        Me.tbRate.Size = New System.Drawing.Size(200, 25)
        Me.tbRate.TabIndex = 21
        '
        'dataViewRoom
        '
        Me.dataViewRoom.AllowUserToAddRows = False
        Me.dataViewRoom.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dataViewRoom.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataViewRoom.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataViewRoom.ColumnHeadersHeight = 4
        Me.dataViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataViewRoom.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataViewRoom.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataViewRoom.Location = New System.Drawing.Point(-1, 12)
        Me.dataViewRoom.Name = "dataViewRoom"
        Me.dataViewRoom.ReadOnly = True
        Me.dataViewRoom.RowHeadersVisible = False
        Me.dataViewRoom.Size = New System.Drawing.Size(416, 492)
        Me.dataViewRoom.TabIndex = 22
        Me.dataViewRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dataViewRoom.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dataViewRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dataViewRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dataViewRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dataViewRoom.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dataViewRoom.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataViewRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataViewRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataViewRoom.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataViewRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dataViewRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dataViewRoom.ThemeStyle.HeaderStyle.Height = 4
        Me.dataViewRoom.ThemeStyle.ReadOnly = True
        Me.dataViewRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dataViewRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataViewRoom.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataViewRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dataViewRoom.ThemeStyle.RowsStyle.Height = 22
        Me.dataViewRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataViewRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'nmrEmpty
        '
        Me.nmrEmpty.BackColor = System.Drawing.Color.Transparent
        Me.nmrEmpty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nmrEmpty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nmrEmpty.Location = New System.Drawing.Point(508, 160)
        Me.nmrEmpty.Name = "nmrEmpty"
        Me.nmrEmpty.Size = New System.Drawing.Size(104, 30)
        Me.nmrEmpty.TabIndex = 23
        Me.nmrEmpty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnEdit_room
        '
        Me.btnEdit_room.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit_room.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit_room.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit_room.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEdit_room.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEdit_room.ForeColor = System.Drawing.Color.White
        Me.btnEdit_room.Location = New System.Drawing.Point(537, 459)
        Me.btnEdit_room.Name = "btnEdit_room"
        Me.btnEdit_room.Size = New System.Drawing.Size(65, 45)
        Me.btnEdit_room.TabIndex = 25
        Me.btnEdit_room.Text = "Sửa"
        '
        'textReset_room
        '
        Me.textReset_room.BackColor = System.Drawing.Color.Transparent
        Me.textReset_room.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textReset_room.Location = New System.Drawing.Point(660, 270)
        Me.textReset_room.Name = "textReset_room"
        Me.textReset_room.Size = New System.Drawing.Size(48, 22)
        Me.textReset_room.TabIndex = 26
        Me.textReset_room.Text = "Đặt lại"
        '
        'Room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(720, 516)
        Me.Controls.Add(Me.textReset_room)
        Me.Controls.Add(Me.btnEdit_room)
        Me.Controls.Add(Me.nmrEmpty)
        Me.Controls.Add(Me.dataViewRoom)
        Me.Controls.Add(Me.tbRate)
        Me.Controls.Add(Me.tbType)
        Me.Controls.Add(Me.tbId_room)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblEmty)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblID_room)
        Me.Controls.Add(Me.btnDelete_room)
        Me.Controls.Add(Me.btnAdd_room)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Room"
        Me.Text = "NewRoom"
        CType(Me.dataViewRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrEmpty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents btnDelete_room As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdd_room As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblRate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblEmty As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblType As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblID_room As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbRate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbType As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbId_room As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dataViewRoom As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents nmrEmpty As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents btnEdit_room As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents textReset_room As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
