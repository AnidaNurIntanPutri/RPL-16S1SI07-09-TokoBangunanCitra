Public Class FrmBarang

    Dim modeProses As Integer
    Dim baris As Integer
    Private Sub isiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DTGBarang.Rows(br)
                LblKdBarang.Text = .Cells(0).Value.ToString
                TxtNmBarang.Text = .Cells(1).Value.ToString
                TxtHgBarang.Text = .Cells(2).Value.ToString
                TxtJmlBarang.Text = .Cells(3).Value.ToString

            End With
        End If
    End Sub

    Private Sub refreshGrid()
        DTGrid = kontrolBarang.tampilData.ToTable
        DTGBarang.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DTGBarang.CurrentCell = DTGBarang.Item(1, baris)
            isiBox(baris)
        End If
    End Sub

    Private Sub bersihdata()
        TxtNmBarang.Text = ""
        TxtJmlBarang.Text = ""
        TxtHgBarang.Text = ""
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        With EntitasBarang
            .KodeBrg = LblKdBarang.Text
            .NamaBrg = TxtNmBarang.Text
            .JumlahBrg = TxtJmlBarang.Text
            .HargaBrg = TxtHgBarang.Text
        End With
        kontrolBarang.InsertData(EntitasBarang)
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "info")
        TxtNmBarang.Focus()
        Call refreshGrid()
        Call bersihdata()
    End Sub
    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click

        With EntitasBarang
            .KodeBrg = LblKdBarang.Text
            .NamaBrg = TxtNmBarang.Text
            .HargaBrg = TxtHgBarang.Text
            .JumlahBrg = TxtJmlBarang.Text

        End With
        KontrolBarang.updateData(EntitasBarang)
        refreshGrid()
        Call bersihdata()

    End Sub

    Private Sub FrmBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Call refreshGrid()
        LblKdBarang.Text = KontrolBarang.kodebaru()
        Call bersihdata()

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click

        If MsgBox("Apakah anda yakin ingin menghapus data ?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolBarang.deleteData(LblKdBarang.Text)
        End If
        refreshGrid()
        Call bersihdata()
    End Sub

    Private Sub DTGBarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGBarang.CellContentClick
        baris = e.RowIndex
        DTGBarang.Rows(baris).Selected = True
        isiBox(baris)
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Hide()
        FmMenuCS.Show()
    End Sub

End Class