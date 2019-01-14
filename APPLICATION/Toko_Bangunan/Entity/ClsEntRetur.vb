Public Class ClsEntRetur

    Private Nomer As String
    Private nota As String
    Private Kode As String
    Private tgl As Date
    Private keterangan As String
    Private jumlah As Integer

    Public Property NoRtr() As String
        Get
            Return Nomer
        End Get
        Set(ByVal value As String)
            Nomer = value
        End Set
    End Property

    Public Property NotaRtr() As String
        Get
            Return nota
        End Get
        Set(ByVal value As String)
            nota = value
        End Set
    End Property

    Public Property KdMbr() As String
        Get
            Return Kode
        End Get
        Set(ByVal value As String)
            Kode = value
        End Set
    End Property


    Public Property TglRtr() As Date
        Get
            Return tgl
        End Get
        Set(ByVal value As Date)
            tgl = value
        End Set
    End Property


    Public Property KtrgnRtr() As String
        Get
            Return keterangan
        End Get
        Set(ByVal value As String)
            keterangan = value
        End Set
    End Property


    Public Property JmlRtr() As Integer
        Get
            Return jumlah
        End Get
        Set(ByVal value As Integer)
            jumlah = value
        End Set
    End Property


End Class
