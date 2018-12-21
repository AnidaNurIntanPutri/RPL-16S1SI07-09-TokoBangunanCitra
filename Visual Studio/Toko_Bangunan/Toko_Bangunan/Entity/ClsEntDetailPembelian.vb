Public Class ClsEntDetailPembelian
    Public Class ClsEntDetailPembelian
        Private kodebeli As String
        Private kodebrg As String
        Private hrg As Integer
        Private quanty As Integer
        Private subtot As Integer

        Public Property kd_beli() As String
            Get
                Return kodebeli
            End Get
            Set(value As String)
                kodebeli = value
            End Set
        End Property


        Public Property kd_barang() As String
            Get
                Return kodebrg
            End Get
            Set(value As String)
                kodebrg = value
            End Set
        End Property
        Public Property harga_beli() As Integer
            Get
                Return hrg
            End Get
            Set(value As Integer)
                hrg = value
            End Set
        End Property

        Public Property qty() As Integer
            Get
                Return quanty
            End Get
            Set(value As Integer)
                quanty = value
            End Set
        End Property

        Public Property sub_total() As Integer
            Get
                Return subtot
            End Get
            Set(value As Integer)
                subtot = value
            End Set
        End Property
    End Class
