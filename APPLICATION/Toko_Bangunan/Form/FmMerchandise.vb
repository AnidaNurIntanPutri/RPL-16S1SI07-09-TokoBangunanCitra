Imports System.Data.OleDb

Public Class FmMerchandise
    Dim modeProses As Integer
    Dim baris As Integer
    Private Sub isiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGMerchandise.Rows(br)
                lblKode.Text = .Cells(0).Value.ToString
                txtKdMember.Text = .Cells(1).Value.ToString
                txtJenis.Text = .Cells(2).Value.ToString
                txtKeterangan.Text = .Cells(3).Value.ToString
            End With
        End If
    End Sub
    Private Sub refreshGrid()
        DTGrid = kontrolMerchandise.tampilData.ToTable
        DGMerchandise.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGMerchandise.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGMerchandise.CurrentCell = DGMerchandise.Item(1, baris)
            isiBox(baris)
        End If

    End Sub
    Private Sub bersihdata()
        lblKode.Text = ""
        txtKdMember.Text = ""
        txtJenis.Text = ""
        txtKeterangan.Text = ""
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasMerchandise
            .kd_merchandise = lblKode.Text
            .kd_Member = txtKdMember.Text
            .jenis_merchandise = txtJenis.Text
            .keterangan = txtKeterangan.Text
        End With
        kontrolMerchandise.InsertData(EntitasMerchandise)
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "info")
        refreshGrid()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Apakah anda yakin ingin menghapus data ?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            kontrolMerchandise.deleteData(lblKode.Text)
        End If
        refreshGrid()
    End Sub

    Private Sub DGMerchandise_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGMerchandise.CellContentClick
        Dim baris As Integer
        If modeProses = 0 Then
            baris = e.RowIndex
            DGMerchandise.Rows(baris).Selected = True
            isiBox(baris)
        End If
    End Sub

    Private Sub FormMerchandise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshGrid()
        lblKode.Text = kontrolMerchandise.kodeBaru()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        With EntitasMerchandise
            .kd_merchandise = lblKode.Text
            .kd_Member = txtKdMember.Text
            .jenis_merchandise = txtJenis.Text
            .keterangan = txtKeterangan.Text
        End With
        kontrolMerchandise.updateData(EntitasMerchandise)

        refreshGrid()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Hide()
        FmMenuCS.Show()
    End Sub
End Class