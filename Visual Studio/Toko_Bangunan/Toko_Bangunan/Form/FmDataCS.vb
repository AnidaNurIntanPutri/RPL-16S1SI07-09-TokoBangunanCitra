Public Class FmDataCS
    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub isiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGDataCs.Rows(br)
                lblkdCustomer.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
                txtAlamat.Text = .Cells(2).Value.ToString
                txtTelepon.Text = .Cells(3).Value.ToString
                txtEmail.Text = .Cells(4).Value.ToString
                txtUsername.Text = .Cells(5).Value.ToString
                txtPassword.Text = .Cells(6).Value.ToString
            End With
        End If
    End Sub
    Private Sub refreshGrid()
        DTGrid = kontrolDataCs.tampilData.ToTable
        DGDataCs.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGDataCs.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGDataCs.CurrentCell = DGDataCs.Item(1, baris)
            isiBox(baris)
        End If

    End Sub
    Private Sub bersihdata()
        lblkdCustomer.Text = ""
        txtNama.Text = ""
        txtTelepon.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtEmail.Text = ""
        txtAlamat.Text = ""
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasDataCS
            .namaCs = txtNama.Text
            .telponCs = txtTelepon.Text
            .usernameCs = txtUsername.Text
            .passwordCs = txtPassword.Text
            .emailCs = txtEmail.Text
            .alamatCs = txtAlamat.Text
        End With

        If modeProses = 1 Then
            kontrolDataCs.InsertData(EntitasDataCS)
        ElseIf modeProses = 2 Then
            kontrolDataCs.updateData(EntitasDataCS)
        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "info")
        refreshGrid()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim status_refrensi As Boolean
        status_refrensi = kontrolDataCs.cekDataCsDireferensi(txtNama.Text)
        If status_refrensi Then
            MsgBox("Data masih digunakan, Tidak boleh dihapus ", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah anda yakin ingin menghapus data ?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            kontrolDataCs.deleteData(txtNama.Text)
        End If
        refreshGrid()
    End Sub

    Private Sub FormDataCS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click

    End Sub
End Class
