Public Class FmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        DTGrid = KontrolOperator.loginOperator(txtID.Text).ToTable

        If DTGrid.Rows.Count > 0 Then
            EntitasOperator.kode_operator = DTGrid.Rows(0).Item(0)
            EntitasOperator.nama_operator = DTGrid.Rows(0).Item(1)
            EntitasOperator.userid = DTGrid.Rows(0).Item(2)
            EntitasOperator.pass = DTGrid.Rows(0).Item(3)
            EntitasOperator.level_operator = DTGrid.Rows(0).Item(4)

            KODELOG = EntitasOperator.kode_operator
            NAMALOG = EntitasOperator.nama_operator


            If txtPassword.Text = EntitasOperator.pass And EntitasOperator.level_operator = "customerservice" Then
                FmMenuCS.Show()
                txtPassword.Text = ""
                txtID.Text = ""
                Me.Hide()

            ElseIf txtPassword.Text = EntitasOperator.pass And EntitasOperator.level_operator = "kasir" Then
                FmPenjualan.Show()
                txtPassword.Text = ""
                txtID.Text = ""
                Me.Hide()

            ElseIf txtPassword.Text = EntitasOperator.pass And EntitasOperator.level_operator = "pemilik" Then
                FmMenuPemilik.Show()
                txtPassword.Text = ""
                txtID.Text = ""
                Me.Hide()

            Else
                MessageBox.Show("PASSWORD SALAH!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Text = ""
                txtID.Focus()

            End If

        Else
            MessageBox.Show("ID tidak dikenal!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Text = ""
            txtID.Text = ""
            txtID.Focus()
        End If
    End Sub

    Private Sub FmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ellipsradius As New Drawing2D.GraphicsPath
        ellipsradius.StartFigure()
        ellipsradius.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        ellipsradius.AddLine(10, 0, btnLogin.Width - 20, 0)
        ellipsradius.AddArc(New Rectangle(btnLogin.Width - 10, 0, 10, 10), -90, 90)
        ellipsradius.AddLine(btnLogin.Width, 20, btnLogin.Width, btnLogin.Height - 10)
        ellipsradius.AddArc(New Rectangle(btnLogin.Width - 10, btnLogin.Height - 10, 10, 10), 0, 90)
        ellipsradius.AddLine(btnLogin.Width - 10, btnLogin.Height, 20, btnLogin.Height)
        ellipsradius.AddArc(New Rectangle(0, btnLogin.Height - 10, 10, 10), 90, 90)

        ellipsradius.CloseFigure()
        btnLogin.Region = New Region(ellipsradius)

        Dim ellipsradius2 As New Drawing2D.GraphicsPath
        ellipsradius2.StartFigure()
        ellipsradius2.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        ellipsradius2.AddLine(10, 0, btnBatal.Width - 20, 0)
        ellipsradius2.AddArc(New Rectangle(btnBatal.Width - 10, 0, 10, 10), -90, 90)
        ellipsradius2.AddLine(btnBatal.Width, 20, btnBatal.Width, btnBatal.Height - 10)
        ellipsradius2.AddArc(New Rectangle(btnBatal.Width - 10, btnBatal.Height - 10, 10, 10), 0, 90)
        ellipsradius2.AddLine(btnBatal.Width - 10, btnBatal.Height, 20, btnBatal.Height)
        ellipsradius2.AddArc(New Rectangle(0, btnBatal.Height - 10, 10, 10), 90, 90)

        ellipsradius2.CloseFigure()
        btnBatal.Region = New Region(ellipsradius2)
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class
