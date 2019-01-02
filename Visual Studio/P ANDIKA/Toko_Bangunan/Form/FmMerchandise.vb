Imports System.Data.OleDb

Public Class FmMerchandise
    Dim modeProses As Integer
    Dim baris As Integer
    Private Sub isiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGMerchandise.Rows(br)
                txtkdHadiah.Text = .Cells(0).Value.ToString
                txtKategori.Text = .Cells(1).Value.ToString
                txtKdMember.Text = .Cells(2).Value.ToString
                cmbJenis.Text = .Cells(3).Value.ToString
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
        txtkdHadiah.Text = ""
        txtKategori.Text = ""
        txtKdMember.Text = ""
        cmbJenis.Text = ""
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasMerchandise
            .kd_Hadiah = txtkdHadiah.Text
            .kategori_Hadiah = txtKategori.Text
            .kode_member = txtKdMember.Text
            .jenis_hadiah = cmbJenis.Text
        End With

        If modeProses = 1 Then
            kontrolMerchandise.InsertData(EntitasMerchandise)
        ElseIf modeProses = 2 Then
            kontrolMerchandise.updateData(EntitasMerchandise)
        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "info")
        refreshGrid()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim status_refrensi As Boolean
        status_refrensi = kontrolMerchandise.cekMerchandiseDireferensi(txtKategori.Text)
        If status_refrensi Then
            MsgBox("Data masih digunakan, Tidak boleh dihapus ", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah anda yakin ingin menghapus data ?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            kontrolMerchandise.deleteData(txtKategori.Text)
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
    'Sub panggildata()
    'DTA = New OleDbDataAdapter("Select * from MERCHANDISE", BUKAKONEKSI)
    'DTS = New DataSet
    'DTS.Clear()
    'DTA.Fill(DTS, "merchandise")
    'DGMerchandise.DataSource = (DTS.Tables("MERCHANDISE"))

    'CMD = New OleDbCommand("select * FROM MERCHANDISE", BUKAKONEKSI)
    'DTR = CMD.ExecuteReader
    'Do While DTR.Read
    'CmbKode.Items.Add(DTR.Item(0))
    'Loop
    'End Sub

    Private Sub FormMerchandise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call refreshGrid()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJenis.SelectedIndexChanged

    End Sub


End Class