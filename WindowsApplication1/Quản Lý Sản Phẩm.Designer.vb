<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquanlysanpham
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
        Me.lblma1 = New System.Windows.Forms.Label()
        Me.lblten = New System.Windows.Forms.Label()
        Me.lblma3 = New System.Windows.Forms.Label()
        Me.lblma4 = New System.Windows.Forms.Label()
        Me.lblma5 = New System.Windows.Forms.Label()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.txtsoluong = New System.Windows.Forms.TextBox()
        Me.txtchitietsanpham = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblma1
        '
        Me.lblma1.AutoSize = True
        Me.lblma1.Location = New System.Drawing.Point(12, 27)
        Me.lblma1.Name = "lblma1"
        Me.lblma1.Size = New System.Drawing.Size(39, 13)
        Me.lblma1.TabIndex = 0
        Me.lblma1.Text = "MãSP:"
        '
        'lblten
        '
        Me.lblten.AutoSize = True
        Me.lblten.Location = New System.Drawing.Point(12, 57)
        Me.lblten.Name = "lblten"
        Me.lblten.Size = New System.Drawing.Size(43, 13)
        Me.lblten.TabIndex = 0
        Me.lblten.Text = "TênSP:"
        '
        'lblma3
        '
        Me.lblma3.AutoSize = True
        Me.lblma3.Location = New System.Drawing.Point(12, 88)
        Me.lblma3.Name = "lblma3"
        Me.lblma3.Size = New System.Drawing.Size(47, 13)
        Me.lblma3.TabIndex = 0
        Me.lblma3.Text = "Đơn giá:"
        '
        'lblma4
        '
        Me.lblma4.AutoSize = True
        Me.lblma4.Location = New System.Drawing.Point(12, 119)
        Me.lblma4.Name = "lblma4"
        Me.lblma4.Size = New System.Drawing.Size(52, 13)
        Me.lblma4.TabIndex = 0
        Me.lblma4.Text = "Số lượng:"
        '
        'lblma5
        '
        Me.lblma5.AutoSize = True
        Me.lblma5.Location = New System.Drawing.Point(12, 149)
        Me.lblma5.Name = "lblma5"
        Me.lblma5.Size = New System.Drawing.Size(91, 13)
        Me.lblma5.TabIndex = 0
        Me.lblma5.Text = "Chi tiết sản phẩm:"
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(109, 24)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(181, 20)
        Me.txtmasp.TabIndex = 1
        '
        'txttensp
        '
        Me.txttensp.Location = New System.Drawing.Point(109, 54)
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(181, 20)
        Me.txttensp.TabIndex = 1
        '
        'txtdongia
        '
        Me.txtdongia.Location = New System.Drawing.Point(109, 85)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(100, 20)
        Me.txtdongia.TabIndex = 1
        '
        'txtsoluong
        '
        Me.txtsoluong.Location = New System.Drawing.Point(109, 116)
        Me.txtsoluong.Name = "txtsoluong"
        Me.txtsoluong.Size = New System.Drawing.Size(100, 20)
        Me.txtsoluong.TabIndex = 1
        '
        'txtchitietsanpham
        '
        Me.txtchitietsanpham.Location = New System.Drawing.Point(109, 146)
        Me.txtchitietsanpham.Name = "txtchitietsanpham"
        Me.txtchitietsanpham.Size = New System.Drawing.Size(100, 20)
        Me.txtchitietsanpham.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 214)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(465, 159)
        Me.DataGridView1.TabIndex = 2
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(15, 178)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 3
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(119, 178)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 4
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(215, 178)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 5
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(322, 178)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.btnthoat.TabIndex = 6
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'frmquanlysanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 385)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtchitietsanpham)
        Me.Controls.Add(Me.txtsoluong)
        Me.Controls.Add(Me.txtdongia)
        Me.Controls.Add(Me.txttensp)
        Me.Controls.Add(Me.txtmasp)
        Me.Controls.Add(Me.lblma5)
        Me.Controls.Add(Me.lblma4)
        Me.Controls.Add(Me.lblma3)
        Me.Controls.Add(Me.lblten)
        Me.Controls.Add(Me.lblma1)
        Me.Name = "frmquanlysanpham"
        Me.Text = "Quản_Lý_Sản_Phẩm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblma1 As System.Windows.Forms.Label
    Friend WithEvents lblten As System.Windows.Forms.Label
    Friend WithEvents lblma3 As System.Windows.Forms.Label
    Friend WithEvents lblma4 As System.Windows.Forms.Label
    Friend WithEvents lblma5 As System.Windows.Forms.Label
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents txttensp As System.Windows.Forms.TextBox
    Friend WithEvents txtdongia As System.Windows.Forms.TextBox
    Friend WithEvents txtsoluong As System.Windows.Forms.TextBox
    Friend WithEvents txtchitietsanpham As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
End Class
