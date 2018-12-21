Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        DTGrid = KontrolOperator.loginOperator(txtUsername.Text).ToTable

        If DTGrid.Rows.Count > 0 Then
            EntitasOperator.id_operator = DTGrid.Rows(0).Item(0)
            EntitasOperator.nama_operator = DTGrid.Rows(0).Item(1)
            EntitasOperator.userid = DTGrid.Rows(0).Item(2)
            EntitasOperator.password = DTGrid.Rows(0).Item(3)
            EntitasOperator.level_operator = DTGrid.Rows(0).Item(4)

            'KODELOG = EntitasOperator.id_operator
            'NAMALOG = EntitasOperator.nama_operator


            If txtPassword.Text = EntitasOperator.pass And EntitasOperator.level_operator = "customerservice" Then
                HalamanCustomerService.Show()
                txtPassword.Text = ""
                txtUsername.Text = ""
                Me.Hide()

            ElseIf txtPassword.Text = EntitasOperator.pass And EntitasOperator.level_operator = "kasir" Then
                HalamanKasir.Show()
                txtPassword.Text = ""
                txtUsername.Text = ""
                Me.Hide()

            ElseIf txtPassword.Text = EntitasOperator.pass And EntitasOperator.level_operator = "pemilik" Then
                HalamanPemilik.Show()
                txtPassword.Text = ""
                txtUsername.Text = ""
                Me.Hide()

            Else
                MessageBox.Show("PASSWORD SALAH!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Text = ""
                txtUsername.Focus()

            End If

        Else
            MessageBox.Show("ID tidak dikenal!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Text = ""
            txtUsername.Text = ""
            txtUsername.Focus()
        End If
    End Sub
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class
