Imports System.Data.OleDb
Imports Toko_Bangunan

Public Class ClsCtlSupplier : Implements InfProses
    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim Data As New ClsEntSupplier
        Data = Ob
        CMD = New OleDbCommand("insert into SUPPLIER values ('" & Data.kd_Supplier & "','" & Data.kdb_eli & "','" & Data.nama_Supplier & "','" _
                                   & Data.alamat_Supplier & "','" & Data.no_telp & "','" & Data.email_Supplier & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function
    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function
    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim Data As New ClsEntSupplier
        Data = Ob
        CMD = New OleDbCommand("update pajak set KD_SUPPLIER = '" _
            & Data.kd_Supplier & "','" & Data.kdb_eli & "','" & Data.nama_Supplier & "','" & Data.alamat_Supplier & "','" _
           & Data.no_telp & "','" & Data.email_Supplier & "' where KD_SUPPLIER ='" & Data.kd_Supplier & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function
    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from SUPLLIER " _
                                      & "where KD_SUPPLIER ='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function
    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from SUPPLIER", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Supplier")
            Dim grid As New DataView(DTS.Tables("Tabel_Supplier"))

            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
