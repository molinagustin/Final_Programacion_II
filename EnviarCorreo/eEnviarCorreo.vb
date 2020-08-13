Imports CapaNegocio
Imports CapaDatos
Public Class eEnviarCorreo
#Region "Campos"
    Private _IdCorreo As Integer
    Private _Cantidad As Integer
    Private _Fecha As Date
    Private _FechaUltimaModificacion As DateTime
#End Region

#Region "Propiedades"
    Public Property IdCorreo As Integer
        Get
            Return _IdCorreo
        End Get
        Set(value As Integer)
            _IdCorreo = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(value As Integer)
            _Cantidad = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property FechaUltimaModificacion As Date
        Get
            Return _FechaUltimaModificacion
        End Get
        Set(value As Date)
            _FechaUltimaModificacion = value
        End Set
    End Property
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Metodo que inserta los datos del envio de correo en la base de datos
    ''' </summary>
    ''' <param name="registro">Objeto con los datos a insertar</param>
    Public Sub insertarRegistro(ByRef registro As eEnviarCorreo)
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        Dim registros As Integer

        registros = ejecucion.Actualizar(consulta.insertarNuevoRegistro(registro, "CorreosEnviados"))
    End Sub

    ''' <summary>
    ''' Metodo para obtener los datos de un envio
    ''' </summary>
    ''' <param name="Fecha">Fecha a consultar el envio</param>
    Public Sub obtenerRegistro(ByRef Fecha As Date)
        'Creo un objeto para armar la query
        Dim queryConsulta As String = "SELECT * FROM CorreosEnviados WHERE Fecha = '" & Fecha & "'"

        'A la capa de datos le pido que ejecute la query armada
        Dim ejecutarConsulta As New clsEjecucionQuery
        ejecutarConsulta.obtenerRegistro(Me, queryConsulta)
    End Sub
#End Region
End Class
