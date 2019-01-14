Public Class FmMenuPemilik
    Private Sub pembelian_Click(sender As Object, e As EventArgs) Handles pembelian.Click
        Me.Hide()
        FmPembelian.Show()
    End Sub

    Private Sub kasir_Click(sender As Object, e As EventArgs) Handles kasir.Click
        Me.Hide()
        FmPenjualan.Show()
    End Sub

    Private Sub customer_Click(sender As Object, e As EventArgs) Handles customer.Click
        Me.Hide()
        FmMenuCS.Show()
    End Sub

    Private Sub laporan_Click(sender As Object, e As EventArgs) Handles laporan.Click
        Me.Hide()
        FmLaporan.Show()
    End Sub

    Private Sub FmMenuPemilik_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
