Imports System.Data.OleDb
Public Class FmSupplier
    Dim modeProses As Integer
    Dim baris As Integer
    Private Sub isiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGSupplier.Rows(br)
                txtkdSupplier.Text = .Cells(0).Value.ToString
                txtkdBeli.Text = .Cells(1).Value.ToString
                txtNama.Text = .Cells(2).Value.ToString
                txtAlamat.Text = .Cells(3).Value.ToString
                txtTelpon.Text = .Cells(4).Value.ToInteger
                txtEmail.Text = .Cells(5).Value.ToString
            End With
        End If
    End Sub
    Private Sub refreshGrid()
        DTGrid = kontrolSupplier.tampilData.ToTable
        DGSupplier.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGSupplier.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGSupplier.CurrentCell = DGSupplier.Item(1, baris)
            isiBox(baris)
        End If
    End Sub
    Private Sub bersihdata()
        txtkdSupplier.Text = ""
        txtkdBeli.Text = ""
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtTelpon.Text = ""
        txtEmail.Text = ""
    End Sub
    Private Sub FmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call refreshGrid()
        Call bersihdata()
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasSupplier
            .kd_Supplier = txtkdSupplier.Text
            .kdb_eli = txtkdBeli.Text
            .nama_Supplier = txtNama.Text
            .alamat_Supplier = txtAlamat.Text
            .no_telp = txtTelpon.Text
            .email_Supplier = txtEmail.Text

        End With

        kontrolSupplier.InsertData(EntitasSupplier)
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "info")

        refreshGrid()
    End Sub
    Private Sub DGDelivery_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSupplier.CellContentClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGSupplier.Rows(baris).Selected = True
            isiBox(baris)
        End If
    End Sub
    'Sub panggildata()
    'DTA = New OleDbDataAdapter("Select * from SUPPLIER", BUKAKONEKSI)
    'DTS = New DataSet
    'DTS.Clear()
    'DTA.Fill(DTS, "supplier")
    'DGSupplier.DataSource = (DTS.Tables("supplier"))

    'CMD = New OleDbCommand("select * FROM SUPPLIER", BUKAKONEKSI)
    'DTR = CMD.ExecuteReader
    'Do While DTR.Read
    'CmbKode.Items.Add(DTR.Item(0))
    'Loop
    'End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Hide()
        FmMenuCS.Show()
    End Sub
End Class