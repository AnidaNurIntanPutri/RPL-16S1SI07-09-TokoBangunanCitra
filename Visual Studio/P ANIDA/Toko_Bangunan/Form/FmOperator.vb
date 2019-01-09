Imports System.Data.OleDb
Public Class FmOperator
    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub AturButton(st As Boolean)
        btnTambah.Enabled = st
        btnUbah.Enabled = st
        btnHapus.Enabled = st
        btnSimpan.Enabled = Not st
        btnBatal.Enabled = Not st
    End Sub
    Private Sub FormOperator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RefreshGrid()
        txtKodeOperator.Enabled = False
        ' MdiParent = FmMenuCS
        Call TampilOperator()
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGOperator.Rows(br)
                txtKodeOperator.Text = .Cells(0).Value.ToString
                txtNamaOperator.Text = .Cells(1).Value.ToString
                txtUsername.Text = .Cells(2).Value.ToString
                txtPassword.Text = .Cells(3).Value.ToString
                cbLevel.Text = .Cells(4).Value.ToString
            End With
            ' LblBaris.Text = "Data ke-" & br + 1 & " dari " & DGMenu.RowCount - 1 & " data "
        End If
    End Sub

    Private Sub RefreshGrid()
        DTGrid = kontrolOperator.tampilData.ToTable
        DGOperator.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGOperator.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGOperator.CurrentCell = DGOperator.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = kontrolOperator.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGOperator.DataSource = DTGrid
            DGOperator.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGOperator.CurrentCell = DGOperator.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        AturButton(False)
        modeProses = 1

        txtKodeOperator.Text = ""
        txtNamaOperator.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        cbLevel.Text = ""
        txtKodeOperator.Text = kontrolOperator.kodeBaru()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        AturButton(False)
        txtNamaOperator.Focus()
        modeProses = 2
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasOperator
            .kode_operator = txtKodeOperator.Text
            .nama_operator = txtNamaOperator.Text
            .userid = txtUsername.Text
            .pass = txtPassword.Text
            .level_operator = cbLevel.Text
        End With

        If modeProses = 1 Then
            KontrolOperator.InsertData(EntitasOperator)
        ElseIf modeProses = 2 Then
            KontrolOperator.updateData(EntitasOperator)
        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolOperator.cekOperatorDireferensi(txtKodeOperator.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus " & txtKodeOperator.Text & "-" & txtNamaOperator.Text & "?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfrimasi") = MsgBoxResult.Yes Then
            KontrolOperator.deleteData(txtKodeOperator.Text)
        End If
        RefreshGrid()
    End Sub
    Private Sub DGOperator_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGOperator.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGOperator.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(txtCari.Text)
            txtCari.Focus()
        End If
    End Sub

    Private Sub cbLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLevel.SelectedIndexChanged
        CMD = New OleDbCommand("select * from Operator where level_Operator ='" & cbLevel.Text & "'", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        DTR.Read()

    End Sub

    Sub TampilOperator()
        CMD = New OleDbCommand("select level_Operator from Operator", BUKAKONEKSI)
        DTR = CMD.ExecuteReader
        cbLevel.Items.Clear()
        Do While DTR.Read
            cbLevel.Items.Add(DTR.Item("Level_Operator"))
        Loop
        BUKAKONEKSI.Close()
    End Sub

End Class