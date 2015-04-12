Public Class frmmain

    Private Sub QuảnTrịSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnTrịSảnPhẩmToolStripMenuItem.Click

    End Sub


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub QuảnLýSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSảnPhẩmToolStripMenuItem.Click
        frmquanlysanpham.Show()
    End Sub
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub QuảnLýKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýKháchHàngToolStripMenuItem.Click
        frmquanlykhachhang.Show()

    End Sub
End Class