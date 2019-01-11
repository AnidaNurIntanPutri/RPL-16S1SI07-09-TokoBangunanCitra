Public Class Form3
    Sub bersih()
        textBox1.Text = ""
        textBox2.Text = ""
        Me.Show()
    End Sub

    Private Sub kembali_Click(sender As Object, e As EventArgs) Handles kembali.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Dim sqlquery As New OleDb.OleDbCommand
        sqlquery.Connection = database
        sqlquery.CommandType = CommandType.Text
        sqlquery.CommandText = "INSERT INTO penjualan VALUES ('" & textBox1.Text & "','" & textBox2.Text & "')"
        sqlquery.ExecuteNonQuery()
        MsgBox("Data terimpan")
        Call bersih()

    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenjualanDataSet.Penjualan' table. You can move, or remove it, as needed.
        Me.PenjualanTableAdapter.Fill(Me.PenjualanDataSet.Penjualan)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged

    End Sub
End Class