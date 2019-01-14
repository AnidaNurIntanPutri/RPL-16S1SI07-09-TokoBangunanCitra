Imports System.Data.OleDb
Public Class FmPenjualan
    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub kosong()
        txtnonota.Text = ""
        txtkasir.Text = ""
        txtkodebarang.Text = ""
        txtjumlah.Text = ""
        txttotal.Text = ""
        txtbayar.Text = ""
        txtkembalian.Text = ""

    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGPenjualan.Rows(br)
                txtnonota.Text = .Cells(0).Value.ToString
                txtkasir.Text = .Cells(1).Value.ToString
                txtkodebarang.Text = .Cells(2).Value.ToString
                txtjumlah.Text = .Cells(3).Value.ToString
                txttotal.Text = .Cells(4).Value.ToString
                txtbayar.Text = .Cells(5).Value.ToString
                txtkembalian.Text = .Cells(6).Value.ToString
            End With
        End If
    End Sub
    Private Sub RefreshGrid()
        DTGrid = KontrolKredit.tampilData.ToTable
        DGPenjualan.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGPenjualan.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPenjualan.CurrentCell = DGPenjualan.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub
    Private Sub FmPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        With EntitasPenjualan
            .NO_NOTA = txtnonota.Text
            .KASIR_ = txtkasir.Text
            .KD_BARANG = txtkodebarang.Text
            .JUMLAH_ = txtjumlah.Text
            .TOTAL_ = txttotal.Text
            .BAYAR_ = txtbayar.Text
            .KEMBALIAN_ = txtkembalian.Text
        End With
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
    End Sub
    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click

        If MsgBox("Apakah Anda yakin akan menghapus " & txtkodebarang.Text & "-" & txtjumlah.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfrimasi") = MsgBoxResult.Yes Then
            KontrolKredit.deleteData(txtkodebarang.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub ubah_Click(sender As Object, e As EventArgs) Handles ubah.Click
        With EntitasPenjualan
            .NO_NOTA = txtnonota.Text
            .KASIR_ = txtkasir.Text
            .KD_BARANG = txtkodebarang.Text
            .JUMLAH_ = txtjumlah.Text
            .TOTAL_ = txttotal.Text
            .BAYAR_ = txtbayar.Text
            .KEMBALIAN_ = txtkembalian.Text
        End With

        KontrolPenjualan.updateData(EntitasPenjualan)
        RefreshGrid()
        Call kosong()
    End Sub

    Private Sub DGPenjualan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPenjualan.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGPenjualan.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub
End Class
