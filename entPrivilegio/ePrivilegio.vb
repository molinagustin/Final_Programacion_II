Imports CapaDatos
Imports CapaNegocio
Public Class ePrivilegio
#Region "Campos"
    Private _IdPrivilegio As Integer
    Private _Privilegios As String
    Private _IdUsuario As Integer
    Private _FechaUltimaModificacion As DateTime
#End Region

#Region "Propiedades"
    'No hacen falta comprobaciones porque no podran ser modificados o agregados desde el programa, solo desde la base de datos
    Public Property IdPrivilegio As Integer
        Get
            Return _IdPrivilegio
        End Get
        Set(value As Integer)
            _IdPrivilegio = value
        End Set
    End Property

    Public Property Privilegios As String
        Get
            Return _Privilegios
        End Get
        Set(value As String)
            _Privilegios = value
        End Set
    End Property

    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(value As Integer)
            _IdUsuario = value
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
    ''' Metodo que me llena un tabla con los privilegios guardados en la base de datos
    ''' </summary>
    ''' <param name="tabla">Tabla a llenar</param>
    Public Sub ObtenerPrivilegios(ByRef tabla As DataTable)
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        Dim query As String

        'Guardo la query armada con el nombre de la tabla a consultar
        query = consulta.consultarRegistros("Privilegios")
        'Ejecuto el comando para que me llene la tabla de privilegios con los datos de la base de datos segun la query armada
        ejecucion.obtenerRegistros(tabla, query)
    End Sub
#End Region
End Class
