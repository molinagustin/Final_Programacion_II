Imports CapaDatos
Imports CapaNegocio
Public Class eProvincia
#Region "Campos"
    Private _IdProvincia As Integer
    Private _Nombre As String
    Private _IdUsuario As Integer
    Private _FechaUltimaModificacion As DateTime
#End Region

#Region "Propiedades"
    Public Property IdProvincia As Integer
        Get
            Return _IdProvincia
        End Get
        Set(value As Integer)
            _IdProvincia = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
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

    Public Property FechaUltimaModificacion As DateTime
        Get
            Return _FechaUltimaModificacion
        End Get
        Set(value As DateTime)
            _FechaUltimaModificacion = value
        End Set
    End Property
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Metodo que me llena un tabla con las provincias guardadas en la base de datos
    ''' </summary>
    ''' <param name="tablaProvincias">Tabla a llenar</param>
    Public Sub ObtenerProvincias(ByRef tablaProvincias As DataTable)
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        Dim query As String

        'Guardo la query armada con el nombre de la tabla a consultar
        query = consulta.consultarRegistros("Provincias")
        'Ejecuto el comando para que me llene la tabla de provincias con los datos de la base de datos segun la query armada
        ejecucion.obtenerRegistros(tablaProvincias, query)
    End Sub
#End Region
End Class
