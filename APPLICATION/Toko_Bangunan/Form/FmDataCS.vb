Public Class FmDataCS
    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub isiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGDataCs.Rows(br)
                lblkdCs.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
                txtTelepon.Text = .Cells(2).Value.ToString
                txtUsername.Text = .Cells(3).Value.ToString
                txtPassword.Text = .Cells(4).Value.ToString
                txtEmail.Text = .Cells(5).Value.ToString
                txtAlamat.Text = .Cells(6).Value.ToString
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
        txtNama.Text = ""
        txtTelepon.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtEmail.Text = ""
        txtAlamat.Text = ""
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasDataCS
            .kdCs = lblkdCs.Text
            .namaCs = txtNama.Text
            .telponCs = txtTelepon.Text
            .usernameCs = txtUsername.Text
            .passwordCs = txtPassword.Text
            .emailCs = txtEmail.Text
            .alamatCs = txtAlamat.Text
        End With
        kontrolDataCs.InsertData(EntitasDataCS)
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "info")
        refreshGrid()
        Call bersihdata()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Apakah anda yakin ingin menghapus data ?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            kontrolDataCs.deleteData(txtNama.Text)
        End If
        refreshGrid()
    End Sub

    Private Sub FormDataCS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshGrid()
        lblkdCs.Text = kontrolDataCs.kodebaru()
        Call bersihdata()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        With EntitasDataCS
            .kdCs = lblkdCs.Text
            .namaCs = txtNama.Text
            .telponCs = txtTelepon.Text
            .usernameCs = txtUsername.Text
            .passwordCs = txtPassword.Text
            .emailCs = txtEmail.Text
            .alamatCs = txtAlamat.Text
        End With
        kontrolDataCs.updateData(EntitasDataCS)
        refreshGrid()
        Call bersihdata()
    End Sub

    Private Sub DGDataCs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDataCs.CellContentClick
        baris = e.RowIndex
        DGDataCs.Rows(baris).Selected = True
        isiBox(baris)
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Me.Hide()
        FmMenuCS.Show()
    End Sub
End Class
