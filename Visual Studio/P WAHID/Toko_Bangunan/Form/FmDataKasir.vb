Imports System.Data.OleDb
Public Class FmDataKasir

    Dim modeProses As Integer
    Dim baris As Integer



    Private Sub isiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGKasir.Rows(br)
                lblKode.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
                txtUser.Text = .Cells(2).Value.ToString
                txtPass.Text = .Cells(3).Value.ToString
                txtTelp.Text = .Cells(4).Value.ToString
                txtEmail.Text = .Cells(5).Value.ToString
                txtAlamat.Text = .Cells(6).Value.ToString
            End With
        End If
    End Sub

    Private Sub kosong()
        txtNama.Text = ""
        txtUser.Text = ""
        txtPass.Text = ""
        txtTelp.Text = ""
        txtEmail.Text = ""
        txtAlamat.Text = ""

    End Sub

    Private Sub refreshGrid()
        DTGrid = KontrolKasir.tampilData.ToTable
        DGKasir.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGKasir.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGKasir.CurrentCell = DGKasir.Item(1, baris)
            isiBox(baris)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasKasir
            .kode = lblKode.Text
            .nama = txtNama.Text
            .user = txtUser.Text
            .pass = txtPass.Text
            .telp = txtTelp.Text
            .email = txtEmail.Text
            .alamat = txtAlamat.Text

        End With

        KontrolKasir.InsertData(EntitasKasir)
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "info")

        lblKode.Text = KontrolKasir.kodebaru()
        refreshGrid()
    End Sub

    Private Sub FmDataKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshGrid()
        Call kosong()
        lblKode.Text = KontrolKasir.kodebaru()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Apakah anda yakin ingin menghapus data ?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolKasir.deleteData(lblKode.Text)
        End If
        refreshGrid()
    End Sub

    Private Sub DGKasir_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGKasir.CellContentClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGKasir.Rows(baris).Selected = True
            isiBox(baris)
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        With EntitasKasir
            .kode = lblKode.Text
            .nama = txtNama.Text
            .user = txtUser.Text
            .pass = txtPass.Text
            .telp = txtTelp.Text
            .email = txtEmail.Text
            .alamat = txtAlamat.Text

        End With

        KontrolKasir.updateData(EntitasKasir)
        refreshGrid()
    End Sub

End Class
