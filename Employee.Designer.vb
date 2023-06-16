<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dataViewEmployee = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.lblID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblPhone = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblGender = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.tbUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblUser = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblPassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.textReset = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.checkAD = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.cbGender = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(Me.dataViewEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataViewEmployee
        '
        Me.dataViewEmployee.AllowUserToAddRows = False
        Me.dataViewEmployee.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dataViewEmployee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataViewEmployee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataViewEmployee.ColumnHeadersHeight = 4
        Me.dataViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataViewEmployee.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataViewEmployee.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataViewEmployee.Location = New System.Drawing.Point(3, 12)
        Me.dataViewEmployee.Name = "dataViewEmployee"
        Me.dataViewEmployee.ReadOnly = True
        Me.dataViewEmployee.RowHeadersVisible = False
        Me.dataViewEmployee.Size = New System.Drawing.Size(416, 492)
        Me.dataViewEmployee.TabIndex = 0
        Me.dataViewEmployee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dataViewEmployee.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dataViewEmployee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dataViewEmployee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dataViewEmployee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dataViewEmployee.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dataViewEmployee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataViewEmployee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataViewEmployee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataViewEmployee.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataViewEmployee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dataViewEmployee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dataViewEmployee.ThemeStyle.HeaderStyle.Height = 4
        Me.dataViewEmployee.ThemeStyle.ReadOnly = True
        Me.dataViewEmployee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dataViewEmployee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataViewEmployee.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataViewEmployee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dataViewEmployee.ThemeStyle.RowsStyle.Height = 22
        Me.dataViewEmployee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataViewEmployee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(425, 42)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(20, 22)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "ID"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(400, 105)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(3, 2)
        Me.Guna2HtmlLabel2.TabIndex = 2
        Me.Guna2HtmlLabel2.Text = Nothing
        '
        'lblPhone
        '
        Me.lblPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(425, 187)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(48, 22)
        Me.lblPhone.TabIndex = 3
        Me.lblPhone.Text = "Số ĐT"
        '
        'lblGender
        '
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(425, 235)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(65, 22)
        Me.lblGender.TabIndex = 4
        Me.lblGender.Text = "Giới Tính"
        '
        'tbId
        '
        Me.tbId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbId.DefaultText = ""
        Me.tbId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbId.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbId.Enabled = False
        Me.tbId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbId.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbId.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbId.Location = New System.Drawing.Point(508, 39)
        Me.tbId.Name = "tbId"
        Me.tbId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbId.PlaceholderText = ""
        Me.tbId.SelectedText = ""
        Me.tbId.Size = New System.Drawing.Size(200, 25)
        Me.tbId.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(425, 459)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(65, 45)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Thêm"
        '
        'tbUser
        '
        Me.tbUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbUser.DefaultText = ""
        Me.tbUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUser.Location = New System.Drawing.Point(508, 85)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUser.PlaceholderText = ""
        Me.tbUser.SelectedText = ""
        Me.tbUser.Size = New System.Drawing.Size(200, 25)
        Me.tbUser.TabIndex = 12
        '
        'tbPassword
        '
        Me.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPassword.DefaultText = ""
        Me.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPassword.Location = New System.Drawing.Point(508, 134)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPassword.PlaceholderText = ""
        Me.tbPassword.SelectedText = ""
        Me.tbPassword.Size = New System.Drawing.Size(200, 25)
        Me.tbPassword.TabIndex = 13
        '
        'tbPhone
        '
        Me.tbPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPhone.DefaultText = ""
        Me.tbPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPhone.Location = New System.Drawing.Point(508, 184)
        Me.tbPhone.Name = "tbPhone"
        Me.tbPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPhone.PlaceholderText = ""
        Me.tbPhone.SelectedText = ""
        Me.tbPhone.Size = New System.Drawing.Size(200, 25)
        Me.tbPhone.TabIndex = 14
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(425, 88)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(37, 22)
        Me.lblUser.TabIndex = 15
        Me.lblUser.Text = "User"
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(425, 137)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(71, 22)
        Me.lblPassword.TabIndex = 20
        Me.lblPassword.Text = "Mật Khẩu"
        '
        'btnEdit
        '
        Me.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(544, 459)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(65, 45)
        Me.btnEdit.TabIndex = 21
        Me.btnEdit.Text = "Sửa"
        '
        'btnDelete
        '
        Me.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(643, 459)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(65, 45)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "Xóa"
        '
        'textReset
        '
        Me.textReset.BackColor = System.Drawing.Color.Transparent
        Me.textReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textReset.Location = New System.Drawing.Point(643, 284)
        Me.textReset.Name = "textReset"
        Me.textReset.Size = New System.Drawing.Size(48, 22)
        Me.textReset.TabIndex = 23
        Me.textReset.Text = "Đặt lại"
        '
        'checkAD
        '
        Me.checkAD.AutoSize = True
        Me.checkAD.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.checkAD.CheckedState.BorderRadius = 0
        Me.checkAD.CheckedState.BorderThickness = 0
        Me.checkAD.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.checkAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.checkAD.Location = New System.Drawing.Point(425, 278)
        Me.checkAD.Name = "checkAD"
        Me.checkAD.Size = New System.Drawing.Size(124, 20)
        Me.checkAD.TabIndex = 24
        Me.checkAD.Text = "Quyền quản lý"
        Me.checkAD.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.checkAD.UncheckedState.BorderRadius = 0
        Me.checkAD.UncheckedState.BorderThickness = 0
        Me.checkAD.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(237, Byte), Integer))
        '
        'cbGender
        '
        Me.cbGender.BackColor = System.Drawing.Color.Transparent
        Me.cbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbGender.Font = New System.Drawing.Font("Quicksand Medium", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cbGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbGender.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.cbGender.ItemHeight = 30
        Me.cbGender.Items.AddRange(New Object() {"Nam", "Nu", "Khac"})
        Me.cbGender.Location = New System.Drawing.Point(508, 235)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(200, 36)
        Me.cbGender.StartIndex = 2
        Me.cbGender.TabIndex = 25
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(720, 516)
        Me.Controls.Add(Me.cbGender)
        Me.Controls.Add(Me.checkAD)
        Me.Controls.Add(Me.textReset)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.tbPhone)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUser)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.tbId)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.dataViewEmployee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Employee"
        Me.Text = "Employee"
        CType(Me.dataViewEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataViewEmployee As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPhone As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGender As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblUser As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents textReset As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents checkAD As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents cbGender As Guna.UI2.WinForms.Guna2ComboBox
End Class
