Imports System.Data.OleDb
Public Class FmKredit
    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGKredit.Rows(br)
                txtKredit.Text = .Cells(0).Value.ToString
                txtNota.Text = .Cells(1).Value.ToString
                txtNamaPel.Text = .Cells(2).Value.ToString
                txtAlamat.Text = .Cells(3).Value.ToString
                txtKTP.Text = .Cells(4).Value.ToString
                lblTglNow.Text = .Cells(5).Value.ToString
                DTTglLunas.Text = .Cells(6).Value.ToString
            End With
        End If
    End Sub

    Sub kosong()
        txtKredit.Text = ""
        txtNota.Text = ""
        txtNamaPel.Text = ""
        txtAlamat.Text = ""
        txtKTP.Text = ""
        lblTglNow.Text = ""
        DTTglLunas.Text = ""
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolKredit.tampilData.ToTable
        DGKredit.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGKredit.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGKredit.CurrentCell = DGKredit.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click

    End Sub

    Private Sub DGKredit_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGKredit.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGKredit.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasKredit
            .NO_KREDIT = txtKredit.Text
            .NO_NOTA = txtNota.Text
            .NAMA_KREDIT = txtNamaPel.Text
            .ALAMAT_KREDIT = txtAlamat.Text
            .NO_KTP = txtKTP.Text
            .TGL_KREDIT = lblTglNow.Text
            .TGL_LUNAS = DTTglLunas.Text
        End With
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If MsgBox("Apakah Anda yakin akan menghapus " & txtKredit.Text & "-" & txtNota.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfrimasi") = MsgBoxResult.Yes Then
            KontrolKredit.deleteData(txtKredit.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub FmKredit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kosong()
        Call RefreshGrid()
        txtKredit.Text = KontrolKredit.kodeBaru()

    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Hide()
        FmPenjualan.Show()
    End Sub
End Class