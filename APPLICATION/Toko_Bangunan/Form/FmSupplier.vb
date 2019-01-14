Imports System.Data.OleDb
Public Class FmSupplier
    Dim modeProses As Integer
    Dim baris As Integer
    Private Sub isiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGSupplier.Rows(br)
                lblkdsupplier.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
                txtAlamat.Text = .Cells(2).Value.ToString
                txtTelp.Text = .Cells(3).Value.ToString
                txtEmail.Text = .Cells(4).Value.ToString
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
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtTelp.Text = ""
        txtEmail.Text = ""
    End Sub
    Private Sub FmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call refreshGrid()
        Call bersihdata()
        lblkdsupplier.Text = kontrolSupplier.kodebaru()
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






    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub BtnSimpan_Click_1(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        With EntitasSupplier
            .kd_Supplier = lblKdSupplier.Text
            .nama_Supplier = txtNama.Text
            .alamat_Supplier = txtAlamat.Text
            .no_telp = txtTelp.Text
            .email_Supplier = txtEmail.Text

        End With

        KontrolSupplier.InsertData(EntitasSupplier)
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "info")

        refreshGrid()
        Call bersihdata()
    End Sub

    Private Sub BtnUbah_Click_1(sender As Object, e As EventArgs) Handles BtnUbah.Click
        With EntitasSupplier
            .kd_Supplier = lblKdSupplier.Text
            .nama_Supplier = txtNama.Text
            .alamat_Supplier = txtAlamat.Text
            .no_telp = txtTelp.Text
            .email_Supplier = txtEmail.Text

        End With

        KontrolSupplier.updateData(EntitasSupplier)
        Call bersihdata()
        refreshGrid()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If MsgBox("Apakah anda yakin ingin menghapus data ?",
                 MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolSupplier.deleteData(lblKdSupplier.Text)
        End If
        refreshGrid()
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Hide()
        FmMenuCS.Show()
    End Sub

    'Sub panggilkode()
    'CMD = New OleDbCommand("Select * From supplier", BUKAKONEKSI)
    'DTR = CMD.ExecuteReader
    'cmbkdSupplier.Text = ""
    'Do While DTR.Read
    'cmbkdSupplier.Items.Add(DTR.Item(0))
    'Loop

    'End Sub


End Class