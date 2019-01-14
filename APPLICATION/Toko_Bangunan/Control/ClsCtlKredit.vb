Imports System.Data.OleDb 'diimport agar oledb terbaca'
Public Class ClsCtlKredit : Implements InfProses

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from kredit where no_kredit " & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "Cari_Kredit")
            Dim grid As New DataView(DTS.Tables("Cari_Kredit"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        CMD = New OleDbCommand("delete from kredit " & "where no_kredit='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    'function untuk insert data'
    'insert into tabelnya apa values sesuaikan dg atribut yang ada didatabase kredit'
    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Dim data As New ClsEntKredit 'mengacu pada kelas entitas kredit'
        data = Ob
        CMD = New OleDbCommand("insert into barang values( no_Kredit='" _
                               & data.NO_KREDIT & "',No_Nota='" & data.NO_NOTA _
                               & "',nama_Pelanggan =" & data.NAMA_KREDIT _
                               & ", Alamat= " & data.ALAMAT_KREDIT _
                               & ", no_Ktp = " & data.NO_KTP _
                               & ", tgl_Kredit = " & data.TGL_KREDIT _
                               & ", Tgl_Lunas = " & data.TGL_LUNAS _
                               & ") where no_kredit='" & data.NO_KREDIT & "'", BUKAKONEKSI)

        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(NO_KREDIT,4)) from kredit", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "KR" & Strings.Right("000" & kodeakhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from kredit", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Kredit")
            Dim grid As New DataView(DTS.Tables("Tabel_Kredit"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function




    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Dim data As New ClsEntKredit
        data = Ob
        CMD = New OleDbCommand("update barang set no_Kredit='" _
                               & data.NO_KREDIT & "',No_Nota='" & data.NO_NOTA _
                               & "',nama_Pelanggan =" & data.NAMA_KREDIT _
                               & ", Alamat= " & data.ALAMAT_KREDIT _
                               & ", no_Ktp = " & data.NO_KTP _
                               & ", tgl_Kredit = " & data.TGL_KREDIT _
                               & ", Tgl_Lunas = " & data.TGL_LUNAS _
                               & " where no_kredit='" & data.NO_KREDIT & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function
End Class
