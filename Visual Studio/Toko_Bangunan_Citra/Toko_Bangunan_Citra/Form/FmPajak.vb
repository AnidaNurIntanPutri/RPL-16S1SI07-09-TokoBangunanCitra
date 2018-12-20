Imports System.Data.OleDb
Public Class FmPajak
    Private Sub FmPajak_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim modeProses As Integer
    Dim baris As Integer
    Private Sub isiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGPajak.Rows(br)
                TxtNoPajak.Text = .Cells(0).Value.ToString
                TxtJumlahPajak.Text = .Cells(1).Value.ToString
                DTPajak.Text = .Cells(2).Value.ToString
            End With
        End If
    End Sub

    Private Sub refreshGrid()
        DTGrid = kontrolPajak.tampilData.ToTable
        DGPajak.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGDelivery.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGDelivery.CurrentCell = DGDelivery.Item(1, baris)
            isiBox(baris)
        End If
    End Sub

    Private Sub bersihdata()
        cbIdKurir.Text = ""
        txtAlamat.Text = ""
        txtJam.Text = ""
        txtTanggal.Text = ""
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = kontrolDelivery.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGDelivery.DataSource = DTGrid
            DGDelivery.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGDelivery.CurrentCell = DGDelivery.Item(1, baris)
            isiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            refreshGrid()
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Hide()
        FmMenu.Show()
    End Sub

    Private Sub FmDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call panggilkode()
        Call refreshGrid()
        Call bersihdata()
        lblTgl.Text = Today
        lblNoDelivery.Text = kodetanggal() & kontrolDelivery.kodebaru()
    End Sub


    Function kodetanggal() As String
        Dim tanggal As String
        tanggal = "D" & Strings.Left(lblTgl.Text, 6)
        Return tanggal
    End Function

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        With entitaslDelivery
            .no_delivery = lblNoDelivery.Text
            .id_kurir = cbIdKurir.Text
            .alamat_kirim = txtAlamat.Text
            .tanggal_kirim = txtTanggal.Text
            .jam_kirim = txtJam.Text
        End With

        kontrolDelivery.InsertData(entitaslDelivery)
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "info")

        refreshGrid()
    End Sub

    Private Sub btnHapus_Click_1(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim status_refrensi As Boolean
        status_refrensi = kontrolDelivery.cekDeliveryDireferensi(lblNoDelivery.Text)
        If status_refrensi Then
            MsgBox("Data masih digunakan, Tidak boleh dihapus ", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah anda yakin ingin menghapus data ?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            kontrolDelivery.deleteData(lblNoDelivery.Text)
        End If
        refreshGrid()
    End Sub

    Private Sub DGDelivery_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDelivery.CellContentClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGDelivery.Rows(baris).Selected = True
            isiBox(baris)
        End If
    End Sub

    Sub panggildata()
        DTA = New OleDbDataAdapter("Select * from delivery", BUKAKONEKSI)
        DTS = New DataSet
        DTS.Clear()
        DTA.Fill(DTS, "delivery")
        DGDelivery.DataSource = (DTS.Tables("delivery"))

        'CMD = New OleDbCommand("select * FROM KARYAWAN", BUKAKONEKSI)
        'DTR = CMD.ExecuteReader
        Do While DTR.Read
            'CmbKode.Items.Add(DTR.Item(0))
        Loop
    End Sub

    Sub panggilkode()
        CMD = New OleDbCommand("select * FROM KURIR", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        cbIdKurir.Text = ""
        Do While DTR.Read
            cbIdKurir.Items.Add(DTR.Item(0))
        Loop
    End Sub
End Class