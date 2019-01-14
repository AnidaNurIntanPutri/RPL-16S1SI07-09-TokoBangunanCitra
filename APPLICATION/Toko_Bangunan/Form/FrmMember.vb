Public Class FrmMember

    Dim modeProses As Integer
    Dim baris As Integer
    Private Sub isiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DTGMember.Rows(br)
                lblKdMember.Text = .Cells(0).Value.ToString
                TxtNmMember.Text = .Cells(1).Value.ToString
                TxtAlmMember.Text = .Cells(2).Value.ToString
                TxtTlpMember.Text = .Cells(3).Value.ToString
                TxtNoKTP.Text = .Cells(4).Value.ToString
                TxtEmail.Text = .Cells(5).Value.ToString
            End With
        End If
    End Sub


    Private Sub refreshGrid()
        DTGrid = KontrolMember.tampilData.ToTable
        DTGMember.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DTGMember.Rows(DTGrid.Rows.Count - 1).Selected = True
            DTGMember.CurrentCell = DTGMember.Item(1, baris)
            isiBox(baris)
        End If
    End Sub


    Private Sub bersihdata()
        lblKdMember.Text = ""
        TxtNmMember.Text = ""
        TxtAlmMember.Text = ""
        TxtTlpMember.Text = ""
        TxtNoKTP.Text = ""
        TxtNoKTP.Text = ""
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Hide()
        FmMenuCS.Show()
    End Sub


    Private Sub FrmMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call refreshGrid()
        Call bersihdata()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        With EntitasMember
            .KodeMbr = lblKdMember.Text
            .NamaMbr = TxtNmMember.Text
            .AlamatMbr = TxtAlmMember.Text
            .TeleponMbr = TxtTlpMember.Text
            .KTPMbr = TxtNoKTP.Text
            .EmailMbr = TxtNoKTP.Text
        End With
        KontrolMember.InsertData(EntitasMember)
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "info")
        TxtNmMember.Focus()
        refreshGrid()
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        With EntitasMember
            .KodeMbr = lblKdMember.Text
            .NamaMbr = TxtNmMember.Text
            .AlamatMbr = TxtAlmMember.Text
            .TeleponMbr = TxtTlpMember.Text
            .KTPMbr = TxtNoKTP.Text
            .EmailMbr = TxtNoKTP.Text
        End With
        KontrolMember.updateData(EntitasMember)
        Call bersihdata()
        refreshGrid()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If MsgBox("Apakah anda yakin ingin menghapus data ?",
               MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolMember.deleteData(lblKdMember.Text)
        End If
        refreshGrid()
    End Sub

    Private Sub DTGMember_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGMember.CellContentClick
        baris = e.RowIndex
        DTGMember.Rows(baris).Selected = True
        isiBox(baris)
    End Sub

End Class