Imports System.Data.OleDb
Imports Toko_Bangunan
Public Class ClsCtlDataCs : Implements InfProses
    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim Data As New ClsEntDataCS
        Data = Ob
        CMD = New OleDbCommand("Insert into DataCS values ('" & Data.kdCs & "','" & Data.namaCs & "','" _
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
        CMD = New OleDbCommand("update customer Set KD_CUSTOMER = '" _
            & Data.kdCs & "','" & Data.namaCs & "','" & Data.telponCs & "' ,'" & Data.usernameCs & "','" & Data.passwordCs & "','" _
            & Data.emailCs & "','" & Data.alamatCs & "', '" _
            & "' where KD_CUSTOMER ='" & Data.kdCs & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from CUSTOMER " _
                                      & "where kd_Customer ='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from Customer", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Customer")
            Dim grid As New DataView(DTS.Tables("Tabel_Customer"))

            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Function cekDataCsDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("Select count(KD_PEGAWAI) From Merchandise " _
                & "where KD_PEGAWAI=" & kunci & "'", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek
    End Function
End Class
