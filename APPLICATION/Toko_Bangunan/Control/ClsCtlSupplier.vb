Imports System.Data.OleDb
Imports Toko_Bangunan

Public Class ClsCtlSupplier : Implements InfProses
    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim Data As New ClsEntSupplier
        Data = Ob
        CMD = New OleDbCommand("Insert into SUPPLIER values ('" & Data.kd_Supplier & "','" & Data.nama_Supplier & "','" _
                                   & Data.no_telp & "','" & Data.email_Supplier & "','" & Data.alamat_Supplier & "')", BUKAKONEKSI)
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
        CMD = New OleDbCommand("update SUPPLIER set Kd_Supplier ='" & Data.kd_Supplier & "',nama_supplier = '" & Data.nama_Supplier & "',telp = '" _
                                   & Data.no_telp & "',Email = '" & Data.email_Supplier & "',Alamat = '" & Data.alamat_Supplier & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function
    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from SUPPLIER" _
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

    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select Max(right(KD_SUPPLIER,3)) from SUPPLIER", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))

            baru = "S0" & Strings.Right("000" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
