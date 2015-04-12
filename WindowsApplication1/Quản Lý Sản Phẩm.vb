Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmquanlysanpham
    Dim chuoiketnoi As String = "workstation id=ps02171.mssql.somee.com;packet size=4096;user id=duync123_SQLLogin_1;pwd=kdkf2fzn46;data source=ps02171.mssql.somee.com;persist security info=False;initial catalog=ps02171"
    Dim tb As New DataTable
    Public Sub Data()
        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim SqlAdapter As New SqlDataAdapter("Select * From SanPham", KetNoi)
        Try
            SqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        KetNoi.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblma1.Click, lblma5.Click, lblma4.Click, lblma3.Click, lblten.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Khi click vào 1 cell bất kì, lấy giá trị tại dòng đó đưa lên các textbox tương ứng'
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtmasp.Text = DataGridView1.Item(0, index).Value
        txttensp.Text = DataGridView1.Item(1, index).Value
        txtdongia.Text = DataGridView1.Item(2, index).Value
        txtsoluong.Text = DataGridView1.Item(3, index).Value
        txtchitietsanpham.Text = DataGridView1.Item(4, index).Value

    End Sub

    Private Sub frmquanlysanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim SqlAdapter As New SqlDataAdapter("Select * From SanPham", KetNoi)
        Try
            KetNoi.Open()
            SqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        KetNoi.Close()
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        ' Khi click vào 1 cell bất kì, lấy giá trị tại dòng đó đưa lên các textbox tương ứng'
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtmasp.Text = DataGridView1.Item(0, index).Value
        txttensp.Text = DataGridView1.Item(1, index).Value
        txtdongia.Text = DataGridView1.Item(2, index).Value
        txtsoluong.Text = DataGridView1.Item(3, index).Value
        txtchitietsanpham.Text = DataGridView1.Item(4, index).Value

    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        'Kết nối với database online thông qua chuỗi kết nối Converter'
        Dim ketnoi As New SqlConnection
        'Mở kết nối'
        ketnoi.Open()
        'Câu truy vấn để sửa dữ liệu theo mã'
        Dim Stradd As String = "Update SanPham Set TenSP=@TenSP, Dongia=@Dongia,Soluong=@Soluong,ChiTietSP=@ChiTietSP Where MaSP=@MaSP "
        Dim com As New SqlCommand(Stradd, ketnoi)
        Try
            'Thêm dữ liệu vào câu truy vấn'
            com.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            com.Parameters.AddWithValue("@TenSP", txttensp.Text)
            com.Parameters.AddWithValue("@Dongia", txtdongia.Text)
            com.Parameters.AddWithValue("@Soluong", txtsoluong.Text)
            com.Parameters.AddWithValue("@ChiTietSP", txtchitietsanpham.Text)
            'Thực thi câu truy vấn và sửa dữ liệu trong Database'
            com.ExecuteNonQuery()
            'Đóng kết nối'
            ketnoi.Close()

        Catch ex As Exception
            MessageBox.Show("Kết nối thành công")
        End Try

        'Load lại sản phẩm'
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        Data()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim ketnoi As New SqlConnection
        ketnoi.Open()
        Dim Stradd As String = "Delete from SanPham Where MaSP=@MaSP"
        Dim com As New SqlCommand(Stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaSP", txtmasp.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()

        Catch ex As Exception
            MessageBox.Show("Kết nối không thành công")

        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        Data()

    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub
End Class
