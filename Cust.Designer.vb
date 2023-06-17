<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cust
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dataViewCustomer = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnAdd_Cus = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReset_Cus = New Guna.UI2.WinForms.Guna2Button()
        Me.txtId_Cus = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtName_Cus = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPhone_Cus = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtGender_Cus = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblID_Cus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblName_Cus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblPhone_Cus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblGender_Cus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.dataViewCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataViewCustomer
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dataViewCustomer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataViewCustomer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dataViewCustomer.ColumnHeadersHeight = 4
        Me.dataViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataViewCustomer.DefaultCellStyle = DataGridViewCellStyle6
        Me.dataViewCustomer.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataViewCustomer.Location = New System.Drawing.Point(16, 15)
        Me.dataViewCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.dataViewCustomer.Name = "dataViewCustomer"
        Me.dataViewCustomer.RowHeadersVisible = False
        Me.dataViewCustomer.RowHeadersWidth = 51
        Me.dataViewCustomer.Size = New System.Drawing.Size(405, 606)
        Me.dataViewCustomer.TabIndex = 1
        Me.dataViewCustomer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dataViewCustomer.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dataViewCustomer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dataViewCustomer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dataViewCustomer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dataViewCustomer.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dataViewCustomer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataViewCustomer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataViewCustomer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataViewCustomer.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataViewCustomer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dataViewCustomer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dataViewCustomer.ThemeStyle.HeaderStyle.Height = 4
        Me.dataViewCustomer.ThemeStyle.ReadOnly = False
        Me.dataViewCustomer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dataViewCustomer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataViewCustomer.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataViewCustomer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dataViewCustomer.ThemeStyle.RowsStyle.Height = 22
        Me.dataViewCustomer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataViewCustomer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnAdd_Cus
        '
        Me.btnAdd_Cus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd_Cus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd_Cus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd_Cus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd_Cus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdd_Cus.ForeColor = System.Drawing.Color.White
        Me.btnAdd_Cus.Location = New System.Drawing.Point(521, 486)
        Me.btnAdd_Cus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd_Cus.Name = "btnAdd_Cus"
        Me.btnAdd_Cus.Size = New System.Drawing.Size(151, 55)
        Me.btnAdd_Cus.TabIndex = 12
        Me.btnAdd_Cus.Text = "Thêm"
        '
        'btnReset_Cus
        '
        Me.btnReset_Cus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReset_Cus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReset_Cus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReset_Cus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReset_Cus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReset_Cus.ForeColor = System.Drawing.Color.White
        Me.btnReset_Cus.Location = New System.Drawing.Point(743, 486)
        Me.btnReset_Cus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset_Cus.Name = "btnReset_Cus"
        Me.btnReset_Cus.Size = New System.Drawing.Size(151, 55)
        Me.btnReset_Cus.TabIndex = 13
        Me.btnReset_Cus.Text = "Đặt lại"
        '
        'txtId_Cus
        '
        Me.txtId_Cus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtId_Cus.DefaultText = ""
        Me.txtId_Cus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtId_Cus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtId_Cus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtId_Cus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtId_Cus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtId_Cus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtId_Cus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtId_Cus.Location = New System.Drawing.Point(627, 111)
        Me.txtId_Cus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtId_Cus.Name = "txtId_Cus"
        Me.txtId_Cus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtId_Cus.PlaceholderText = ""
        Me.txtId_Cus.SelectedText = ""
        Me.txtId_Cus.Size = New System.Drawing.Size(267, 31)
        Me.txtId_Cus.TabIndex = 14
        '
        'txtName_Cus
        '
        Me.txtName_Cus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName_Cus.DefaultText = ""
        Me.txtName_Cus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName_Cus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName_Cus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName_Cus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName_Cus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName_Cus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtName_Cus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName_Cus.Location = New System.Drawing.Point(627, 181)
        Me.txtName_Cus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName_Cus.Name = "txtName_Cus"
        Me.txtName_Cus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName_Cus.PlaceholderText = ""
        Me.txtName_Cus.SelectedText = ""
        Me.txtName_Cus.Size = New System.Drawing.Size(267, 31)
        Me.txtName_Cus.TabIndex = 15
        '
        'txtPhone_Cus
        '
        Me.txtPhone_Cus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhone_Cus.DefaultText = ""
        Me.txtPhone_Cus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPhone_Cus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPhone_Cus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhone_Cus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhone_Cus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhone_Cus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPhone_Cus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhone_Cus.Location = New System.Drawing.Point(627, 255)
        Me.txtPhone_Cus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPhone_Cus.Name = "txtPhone_Cus"
        Me.txtPhone_Cus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhone_Cus.PlaceholderText = ""
        Me.txtPhone_Cus.SelectedText = ""
        Me.txtPhone_Cus.Size = New System.Drawing.Size(267, 31)
        Me.txtPhone_Cus.TabIndex = 16
        '
        'txtGender_Cus
        '
        Me.txtGender_Cus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGender_Cus.DefaultText = ""
        Me.txtGender_Cus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGender_Cus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGender_Cus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGender_Cus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGender_Cus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGender_Cus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtGender_Cus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGender_Cus.Location = New System.Drawing.Point(627, 331)
        Me.txtGender_Cus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGender_Cus.Name = "txtGender_Cus"
        Me.txtGender_Cus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGender_Cus.PlaceholderText = ""
        Me.txtGender_Cus.SelectedText = ""
        Me.txtGender_Cus.Size = New System.Drawing.Size(267, 31)
        Me.txtGender_Cus.TabIndex = 17
        '
        'lblID_Cus
        '
        Me.lblID_Cus.BackColor = System.Drawing.Color.Transparent
        Me.lblID_Cus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID_Cus.Location = New System.Drawing.Point(521, 114)
        Me.lblID_Cus.Margin = New System.Windows.Forms.Padding(4)
        Me.lblID_Cus.Name = "lblID_Cus"
        Me.lblID_Cus.Size = New System.Drawing.Size(22, 27)
        Me.lblID_Cus.TabIndex = 18
        Me.lblID_Cus.Text = "ID"
        '
        'lblName_Cus
        '
        Me.lblName_Cus.BackColor = System.Drawing.Color.Transparent
        Me.lblName_Cus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName_Cus.Location = New System.Drawing.Point(521, 185)
        Me.lblName_Cus.Margin = New System.Windows.Forms.Padding(4)
        Me.lblName_Cus.Name = "lblName_Cus"
        Me.lblName_Cus.Size = New System.Drawing.Size(68, 27)
        Me.lblName_Cus.TabIndex = 19
        Me.lblName_Cus.Text = "Họ Tên"
        '
        'lblPhone_Cus
        '
        Me.lblPhone_Cus.BackColor = System.Drawing.Color.Transparent
        Me.lblPhone_Cus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone_Cus.Location = New System.Drawing.Point(521, 258)
        Me.lblPhone_Cus.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPhone_Cus.Name = "lblPhone_Cus"
        Me.lblPhone_Cus.Size = New System.Drawing.Size(60, 27)
        Me.lblPhone_Cus.TabIndex = 20
        Me.lblPhone_Cus.Text = "Số ĐT"
        '
        'lblGender_Cus
        '
        Me.lblGender_Cus.BackColor = System.Drawing.Color.Transparent
        Me.lblGender_Cus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender_Cus.Location = New System.Drawing.Point(521, 335)
        Me.lblGender_Cus.Margin = New System.Windows.Forms.Padding(4)
        Me.lblGender_Cus.Name = "lblGender_Cus"
        Me.lblGender_Cus.Size = New System.Drawing.Size(81, 27)
        Me.lblGender_Cus.TabIndex = 21
        Me.lblGender_Cus.Text = "Giới Tính"
        '
        'Cust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(960, 635)
        Me.Controls.Add(Me.lblGender_Cus)
        Me.Controls.Add(Me.lblPhone_Cus)
        Me.Controls.Add(Me.lblName_Cus)
        Me.Controls.Add(Me.lblID_Cus)
        Me.Controls.Add(Me.txtGender_Cus)
        Me.Controls.Add(Me.txtPhone_Cus)
        Me.Controls.Add(Me.txtName_Cus)
        Me.Controls.Add(Me.txtId_Cus)
        Me.Controls.Add(Me.btnReset_Cus)
        Me.Controls.Add(Me.btnAdd_Cus)
        Me.Controls.Add(Me.dataViewCustomer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Cust"
        Me.Text = "NewCust"
        CType(Me.dataViewCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataViewCustomer As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnAdd_Cus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReset_Cus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtId_Cus As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtName_Cus As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPhone_Cus As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtGender_Cus As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblID_Cus As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblName_Cus As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPhone_Cus As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGender_Cus As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
