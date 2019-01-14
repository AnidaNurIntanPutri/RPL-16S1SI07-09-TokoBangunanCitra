Imports System.Data.OleDb
Imports Toko_Bangunan

Public Class ClsCtlMember : Implements InfProses



    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim Data As New ClsEntMember
        Data = Ob
        CMD = New OleDbCommand("Insert into MEMBER values ('" & Data.KodeMbr & "','" & Data.NamaMbr & "','" _
                                   & Data.AlamatMbr & "','" & Data.TeleponMbr & "','" & Data.KTPMbr & "','" & Data.EmailMbr & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim Data As New ClsEntMember
        Data = Ob
        CMD = New OleDbCommand("update MEMBER set KD_MEMBER = '" _
            & Data.KodeMbr & "',NAMA_MEMBER='" & Data.NamaMbr & "',ALAMAT='" & Data.AlamatMbr & "',NO_TELP='" & Data.TeleponMbr & "',NO_KTP='" _
             & Data.KTPMbr & "',EMAIL='" & Data.EmailMbr & "' where KD_MEMBER ='" & Data.KodeMbr & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from MEMBER " _
                                          & "where KD_MEMBER ='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function
    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("select * from MEMBER", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_MEMBER")
            Dim grid As New DataView(DTS.Tables("Tabel_MEMBER"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Function kodeBaru() As String
        Dim baru As String
        Dim kdakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(KD_MEMBER,3)) from MEMBER", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kdakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "KM" & Strings.Right("00" & kdakhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class


