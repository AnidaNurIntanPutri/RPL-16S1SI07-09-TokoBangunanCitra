Imports System.Data.OleDb
Public Class FmPajak

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
            DGPajak.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGPajak.CurrentCell = DGPajak.Item(1, baris)
            isiBox(baris)
        End If
    End Sub

    Private Sub bersihdata()
        TxtJumlahPajak.Text = ""
        TxtNoPajak.Text = ""
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Hide()
        FmMenuCS.Show()
    End Sub

    Private Sub FmPajak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call refreshGrid()
        Call bersihdata()
    End Sub


    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        With EntitasPajak
            .noP = TxtNoPajak.Text
            .jml = TxtJumlahPajak.Text
            .tgl = DTPajak.Text

        End With

        kontrolPajak.InsertData(EntitasPajak)
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "info")

        refreshGrid()
    End Sub

    Private Sub btnHapus_Click_1(sender As Object, e As EventArgs) Handles BtnHapus.Click

        If MsgBox("Apakah anda yakin ingin menghapus data ?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            kontrolPajak.deleteData(TxtNoPajak.Text)
        End If
        refreshGrid()
    End Sub

    Private Sub DGDelivery_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPajak.CellContentClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGPajak.Rows(baris).Selected = True
            isiBox(baris)
        End If
    End Sub

    Sub panggildata()
        DTA = New OleDbDataAdapter("Select * from delivery", BUKAKONEKSI)
        DTS = New DataSet
        DTS.Clear()
        DTA.Fill(DTS, "delivery")
        DGPajak.DataSource = (DTS.Tables("delivery"))

        'CMD = New OleDbCommand("select * FROM KARYAWAN", BUKAKONEKSI)
        'DTR = CMD.ExecuteReader
        Do While DTR.Read
            'CmbKode.Items.Add(DTR.Item(0))
        Loop
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        kontrolPajak.updateData(EntitasPajak)
    End Sub
End Class