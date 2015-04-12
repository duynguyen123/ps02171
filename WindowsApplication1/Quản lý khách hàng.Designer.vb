<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquanlykhachhang
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblmakhachhang = New System.Windows.Forms.Label()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.lblsodt = New System.Windows.Forms.Label()
        Me.lbldiachi = New System.Windows.Forms.Label()
        Me.lbltenkhachhang = New System.Windows.Forms.Label()
        Me.txtmakhachhang = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtsodt = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txttenkhachhang = New System.Windows.Forms.TextBox()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 181)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(576, 197)
        Me.DataGridView1.TabIndex = 0
        '
        'lblmakhachhang
        '
        Me.lblmakhachhang.AutoSize = True
        Me.lblmakhachhang.Location = New System.Drawing.Point(38, 13)
        Me.lblmakhachhang.Name = "lblmakhachhang"
        Me.lblmakhachhang.Size = New System.Drawing.Size(85, 13)
        Me.lblmakhachhang.TabIndex = 1
        Me.lblmakhachhang.Text = "Mã khách hàng:"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Location = New System.Drawing.Point(38, 39)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(56, 13)
        Me.lblpassword.TabIndex = 1
        Me.lblpassword.Text = "Password:"
        '
        'lblsodt
        '
        Me.lblsodt.AutoSize = True
        Me.lblsodt.Location = New System.Drawing.Point(38, 67)
        Me.lblsodt.Name = "lblsodt"
        Me.lblsodt.Size = New System.Drawing.Size(73, 13)
        Me.lblsodt.TabIndex = 1
        Me.lblsodt.Text = "Số điện thoại:"
        '
        'lbldiachi
        '
        Me.lbldiachi.AutoSize = True
        Me.lbldiachi.Location = New System.Drawing.Point(38, 95)
        Me.lbldiachi.Name = "lbldiachi"
        Me.lbldiachi.Size = New System.Drawing.Size(40, 13)
        Me.lbldiachi.TabIndex = 1
        Me.lbldiachi.Text = "Địa chỉ"
        '
        'lbltenkhachhang
        '
        Me.lbltenkhachhang.AutoSize = True
        Me.lbltenkhachhang.Location = New System.Drawing.Point(38, 124)
        Me.lbltenkhachhang.Name = "lbltenkhachhang"
        Me.lbltenkhachhang.Size = New System.Drawing.Size(89, 13)
        Me.lbltenkhachhang.TabIndex = 1
        Me.lbltenkhachhang.Text = "Tên khách hàng:"
        '
        'txtmakhachhang
        '
        Me.txtmakhachhang.Location = New System.Drawing.Point(137, 10)
        Me.txtmakhachhang.Name = "txtmakhachhang"
        Me.txtmakhachhang.Size = New System.Drawing.Size(100, 20)
        Me.txtmakhachhang.TabIndex = 2
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(137, 36)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(100, 20)
        Me.txtpassword.TabIndex = 2
        '
        'txtsodt
        '
        Me.txtsodt.Location = New System.Drawing.Point(137, 64)
        Me.txtsodt.Name = "txtsodt"
        Me.txtsodt.Size = New System.Drawing.Size(100, 20)
        Me.txtsodt.TabIndex = 2
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(137, 92)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(100, 20)
        Me.txtdiachi.TabIndex = 2
        '
        'txttenkhachhang
        '
        Me.txttenkhachhang.Location = New System.Drawing.Point(137, 121)
        Me.txttenkhachhang.Name = "txttenkhachhang"
        Me.txttenkhachhang.Size = New System.Drawing.Size(100, 20)
        Me.txttenkhachhang.TabIndex = 2
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(36, 152)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 3
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(162, 152)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 4
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(275, 152)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 5
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(393, 152)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.btnthoat.TabIndex = 6
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'frmquanlykhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 387)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.txttenkhachhang)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txtsodt)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtmakhachhang)
        Me.Controls.Add(Me.lbltenkhachhang)
        Me.Controls.Add(Me.lbldiachi)
        Me.Controls.Add(Me.lblsodt)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lblmakhachhang)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmquanlykhachhang"
        Me.Text = "Quản Lý Khách Hàng"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblmakhachhang As System.Windows.Forms.Label
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents lblsodt As System.Windows.Forms.Label
    Friend WithEvents lbldiachi As System.Windows.Forms.Label
    Friend WithEvents lbltenkhachhang As System.Windows.Forms.Label
    Friend WithEvents txtmakhachhang As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtsodt As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txttenkhachhang As System.Windows.Forms.TextBox
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
End Class
