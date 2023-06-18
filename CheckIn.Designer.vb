<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CheckIn
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
        Me.tbId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dataviewCheckIn = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.lblUser = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.textReset = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.nmrRoom = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.nmrCust = New Guna.UI2.WinForms.Guna2NumericUpDown()
        CType(Me.dataviewCheckIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrCust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.tbId.Location = New System.Drawing.Point(548, 12)
        Me.tbId.Name = "tbId"
        Me.tbId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbId.PlaceholderText = ""
        Me.tbId.SelectedText = ""
        Me.tbId.Size = New System.Drawing.Size(139, 25)
        Me.tbId.TabIndex = 7
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(450, 15)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(20, 22)
        Me.lblID.TabIndex = 6
        Me.lblID.Text = "ID"
        '
        'dataviewCheckIn
        '
        Me.dataviewCheckIn.AllowUserToAddRows = False
        Me.dataviewCheckIn.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dataviewCheckIn.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataviewCheckIn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataviewCheckIn.ColumnHeadersHeight = 100
        Me.dataviewCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataviewCheckIn.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataviewCheckIn.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataviewCheckIn.Location = New System.Drawing.Point(12, 12)
        Me.dataviewCheckIn.Name = "dataviewCheckIn"
        Me.dataviewCheckIn.ReadOnly = True
        Me.dataviewCheckIn.RowHeadersVisible = False
        Me.dataviewCheckIn.Size = New System.Drawing.Size(416, 492)
        Me.dataviewCheckIn.TabIndex = 8
        Me.dataviewCheckIn.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dataviewCheckIn.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dataviewCheckIn.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dataviewCheckIn.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dataviewCheckIn.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dataviewCheckIn.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dataviewCheckIn.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataviewCheckIn.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataviewCheckIn.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataviewCheckIn.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataviewCheckIn.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dataviewCheckIn.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dataviewCheckIn.ThemeStyle.HeaderStyle.Height = 100
        Me.dataviewCheckIn.ThemeStyle.ReadOnly = True
        Me.dataviewCheckIn.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dataviewCheckIn.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataviewCheckIn.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataviewCheckIn.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dataviewCheckIn.ThemeStyle.RowsStyle.Height = 22
        Me.dataviewCheckIn.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataviewCheckIn.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(450, 46)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(88, 22)
        Me.lblUser.TabIndex = 17
        Me.lblUser.Text = "Khách hàng"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(450, 113)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(49, 22)
        Me.Guna2HtmlLabel1.TabIndex = 19
        Me.Guna2HtmlLabel1.Text = "Phòng"
        '
        'btnEdit
        '
        Me.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(537, 459)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(65, 45)
        Me.btnEdit.TabIndex = 28
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
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "Xóa"
        '
        'btnAdd
        '
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(437, 459)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(65, 45)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "Thêm"
        '
        'textReset
        '
        Me.textReset.BackColor = System.Drawing.Color.Transparent
        Me.textReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textReset.Location = New System.Drawing.Point(643, 343)
        Me.textReset.Name = "textReset"
        Me.textReset.Size = New System.Drawing.Size(48, 22)
        Me.textReset.TabIndex = 29
        Me.textReset.Text = "Đặt lại"
        '
        'nmrRoom
        '
        Me.nmrRoom.BackColor = System.Drawing.Color.Transparent
        Me.nmrRoom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nmrRoom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nmrRoom.Location = New System.Drawing.Point(544, 105)
        Me.nmrRoom.Name = "nmrRoom"
        Me.nmrRoom.Size = New System.Drawing.Size(104, 30)
        Me.nmrRoom.TabIndex = 30
        Me.nmrRoom.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nmrCust
        '
        Me.nmrCust.BackColor = System.Drawing.Color.Transparent
        Me.nmrCust.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nmrCust.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nmrCust.Location = New System.Drawing.Point(544, 46)
        Me.nmrCust.Name = "nmrCust"
        Me.nmrCust.Size = New System.Drawing.Size(104, 30)
        Me.nmrCust.TabIndex = 31
        Me.nmrCust.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CheckIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(720, 516)
        Me.Controls.Add(Me.nmrCust)
        Me.Controls.Add(Me.nmrRoom)
        Me.Controls.Add(Me.textReset)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.dataviewCheckIn)
        Me.Controls.Add(Me.tbId)
        Me.Controls.Add(Me.lblID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CheckIn"
        Me.Text = "CheckIn"
        CType(Me.dataviewCheckIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrCust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dataviewCheckIn As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblUser As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents textReset As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents nmrRoom As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents nmrCust As Guna.UI2.WinForms.Guna2NumericUpDown
End Class
