Public Class Form2
    Private Sub laporan_Click(sender As Object, e As EventArgs) Handles laporan.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub penjualan_Click(sender As Object, e As EventArgs) Handles penjualan.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class