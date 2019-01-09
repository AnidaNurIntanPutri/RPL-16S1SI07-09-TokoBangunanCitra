Imports System.Data.OleDb
Imports Toko_Bangunan

Public Class ClsCtlKasir : Implements InfProses

    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select Max(right(kd_kasir,3)) from kasir", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))

            baru = "KA" & Strings.Right("000" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim Data As New ClsEntKasir
        Data = Ob
        CMD = New OleDbCommand("Insert into kasir values ('" & Data.kode & "','" & Data.nama & "','" _
                                   & Data.user & "','" & Data.pass & "','" & Data.telp & "','" _
                                & Data.email & "','" & Data.alamat & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim Data As New ClsEntKasir
        Data = Ob
        CMD = New OleDbCommand("update kasir set kd_kasir ='" & Data.kode & "',NAMA='" & Data.nama & "',USER_KASIR='" _
                                   & Data.user & "',PASS_KASIR='" & Data.pass & "',TELEPON ='" & Data.telp & "',email='" _
                                & Data.email & "',alamat='" & Data.alamat & "'where kd_kasir='" & Data.kode & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from kasir " _
                                      & "where kd_kasir ='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from kasir", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_kasir")
            Dim grid As New DataView(DTS.Tables("Tabel_kasir"))

            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function



End Class
