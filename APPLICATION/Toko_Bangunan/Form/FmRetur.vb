Public Class FmRetur


    Dim modeProses As Integer
    Dim baris As Integer
    Private Sub isiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGTRetur.Rows(br)
                LblNoRetur.Text = .Cells(0).Value.ToString
                TxtNotaRetur.Text = .Cells(1).Value.ToString
                TxtKdMember.Text = .Cells(2).Value.ToString
                TxtJmlRetur.Text = .Cells(3).Value.ToString
                DTTanggal.Text = .Cells(4).Value.ToString
                TxtKtrngnRetur.Text = .Cells(5).Value.ToString
            End With
        End If
    End Sub

    Private Sub refreshGrid()
        DTGrid = KontrolRetur.tampilData.ToTable
        DGTRetur.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGTRetur.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGTRetur.CurrentCell = DGTRetur.Item(1, baris)
            isiBox(baris)
        End If
    End Sub



    Private Sub bersihdata()
        TxtNotaRetur.Text = ""
        TxtKdMember.Text = ""
        TxtJmlRetur.Text = ""
        DTTanggal.Text = ""
        TxtKtrngnRetur.Text = ""
    End Sub

    Private Sub FmRetur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call refreshGrid()
        Call bersihdata()
        LblNoRetur.Text = KontrolRetur.kodeBaru()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        With EntitasRetur
            .NoRtr = LblNoRetur.Text
            .KdMbr = TxtKdMember.Text
            .JmlRtr = TxtJmlRetur.Text
            .TglRtr = DTTanggal.Text
            .KtrgnRtr = TxtKtrngnRetur.Text
        End With
        KontrolRetur.InsertData(EntitasRetur)
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "info")
        TxtKdMember.Focus()
        refreshGrid()
        Call bersihdata()
        LblNoRetur.Text = KontrolRetur.kodebaru()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        With EntitasRetur
            .NoRtr = LblNoRetur.Text
            .NotaRtr = TxtNotaRetur.Text
            .KdMbr = TxtKdMember.Text
            .JmlRtr = TxtJmlRetur.Text
            .TglRtr = DTTanggal.Text
            .KtrgnRtr = TxtKtrngnRetur.Text

        End With

        KontrolRetur.updateData(EntitasRetur)
        refreshGrid()
        Call bersihdata()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If MsgBox("Apakah anda yakin ingin menghapus data ?",
              MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolRetur.deleteData(LblNoRetur.Text)
        End If
        refreshGrid()
        Call bersihdata()
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Hide()
        FmMenuCS.Show()
    End Sub

    Private Sub DGTRetur_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTRetur.CellContentClick
        baris = e.RowIndex
        DGTRetur.Rows(baris).Selected = True
        isiBox(baris)
    End Sub
End Class