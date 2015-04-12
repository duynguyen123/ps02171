Imports System.Data.SqlClient

Public Class frmdangnhap

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged, txtpassword.TextChanged

    End Sub

    Private Sub lblusername_Click(sender As Object, e As EventArgs) Handles lblusername.Click

    End Sub

    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click
        Dim chuoiketnoi As String = "workstation id=ps02171.mssql.somee.com;packet size=4096;user id=duync123_SQLLogin_1;pwd=kdkf2fzn46;data source=ps02171.mssql.somee.com;persist security info=False;initial catalog=ps02171"

        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from Khachhang where Makhachhang='" & txtusername.Text & "' and Password='" & txtpassword.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("kết nối thành công")
                frmmain.Show()
            Me.Hide()
        Else
                MessageBox.Show("Sai Tai Khoản hoặc Mật Khẩu")
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub
    Private Sub btnxoahet_Click(sender As Object, e As EventArgs) Handles btnxoahet.Click
        txtusername.Clear()
        txtpassword.Clear()
    End Sub
End Class
