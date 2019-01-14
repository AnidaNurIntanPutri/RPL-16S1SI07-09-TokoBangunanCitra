Imports System.Data.OleDb
Imports Toko_Bangunan
Public Class ClsCtlDataCs : Implements InfProses
    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim Data As New ClsEntDataCS
        Data = Ob
        CMD = New OleDbCommand("Insert into CUSTOMER values ('" & Data.kdCs & "','" & Data.namaCs & "','" _
                                   & Data.telponCs & "','" & Data.usernameCs & "','" & Data.passwordCs & "','" _
                                   & Data.emailCs & "','" & Data.alamatCs & "' )", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function
    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function
    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim Data As New ClsEntDataCS
        Data = Ob
        CMD = New OleDbCommand("update customer Set Kode_CS = '" _
            & Data.kdCs & "',NAMA_cs='" & Data.namaCs & "',telepon='" & Data.telponCs & "' ,USERNAME='" & Data.usernameCs & "',PASWORD='" & Data.passwordCs & "',EMAIL='" _
            & Data.emailCs & "',ALAMAT='" & Data.alamatCs & "''" _
            & "' where Kode_CS ='" & Data.kdCs & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from CUSTOMERSERVICE " _
                                      & "where KD_CS ='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from CUSTOMER", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_CUSTOMER")
            Dim grid As New DataView(DTS.Tables("Tabel_CUSTOMER"))

            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select Max(right(Kode_cs,3)) from CUSTOMER", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))

            baru = "CS" & Strings.Right("000" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
