Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmquanlykhachhang

    Dim tb As New DataTable
    'Tạo biến bảng'
    Dim ChuoiKetNoi As String = "workstation id=ps02171.mssql.somee.com;packet size=4096;user id=duync123_SQLLogin_1;pwd=kdkf2fzn46;data source=ps02171.mssql.somee.com;persist security info=False;initial catalog=ps02171"
    'Tạo liên kết đến database'
    Public Sub LoadData()
        Dim KetNoi As New SqlConnection(ChuoiKetNoi)
        'Khai báo kết nối'
        Dim SqlAdapter As New SqlDataAdapter("SELECT * FROM Khachang", KetNoi)
        'Khai báo đối tượng truy vấn'
        Try
            SqlAdapter.Fill(tb)
            'Tải dữ liệu lên table'
        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        'Hiển thị dữ liệu lên DataGridView'
        KetNoi.Close()
        'Đóng kết nối'
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Tạo sự kiện click lấy dữ liệu khi click vào một cell bất kỳ' 
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtmakhachhang.Text = DataGridView1.Item(0, index).Value
        txtpassword.Text = DataGridView1.Item(1, index).Value
        txtsodt.Text = DataGridView1.Item(2, index).Value
        txtdiachi.Text = DataGridView1.Item(3, index).Value
        txttenkhachhang.Text = DataGridView1.Item(4, index).Value
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim KetNoi As New SqlConnection(ChuoiKetNoi)
        'Khai báo kết nối'
        Dim SqlAdapter As New SqlDataAdapter("SELECT * FROM Khachhang", KetNoi)
        'Khai báo đối tượng truy vấn'
        Try
            KetNoi.Open()
            'Mở kết nối'
            SqlAdapter.Fill(tb)
            'Tải dữ liệu lên table'
        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        'Hiển thị dữ liệu lên DataGridView'
        KetNoi.Close()
        'Đóng kết nối'
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim KetNoi As New SqlConnection(ChuoiKetNoi)
        'Khai báo kết nối'
        KetNoi.Open()
        'Mở kết nối'
        Dim stadd As String = "INSERT INTO Khachhang VALUES (@Makhachhang, @Password, @SoDT, @Diachi,@Tenkhachhang)"
        'Khai báo đối tượng truy vấn'
        Dim com As New SqlCommand(stadd, KetNoi)
        Try
            'Thêm dữ liệu vào câu truy vấn'
            com.Parameters.AddWithValue("@MaKhachHang", txtmakhachhang.Text)
            com.Parameters.AddWithValue("@Password", txtpassword.Text)
            com.Parameters.AddWithValue("@Diachi", txtdiachi.Text)
            com.Parameters.AddWithValue("@Dienthoai", txtsodt.Text)
            com.Parameters.AddWithValue("@Tenkhachhang", txttenkhachhang.Text)
            com.ExecuteNonQuery()
            'Thực thi và sửa dữ liệu trong database'
            KetNoi.Close()
            'Đóng kết nối
        Catch ex As Exception
            MessageBox.Show("Kết nối không thành công")
        End Try
        'Xóa và load lại bảng'
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim KetNoi As New SqlConnection(ChuoiKetNoi)
        KetNoi.Open()
        Dim stadd As String = "DELETE FROM Khachhang WHERE Makhachhang = @Makhachhang"
        Dim com As New SqlCommand(stadd, KetNoi)
        Try
            com.Parameters.AddWithValue("@Makhachhang", txtmakhachhang.Text)
            com.ExecuteNonQuery()
            KetNoi.Close()
        Catch ex As Exception
            MessageBox.Show("Kết nối không thành công")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub
End Class