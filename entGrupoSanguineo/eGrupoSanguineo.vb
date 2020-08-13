Imports CapaDatos
Imports CapaNegocio
Imports System.Data.SqlClient
Public Class eGrupoSanguineo
#Region "Campos"
    Private _IdGrupo As Integer
    Private _Grupo As String
#End Region

#Region "Propiedades"
    Public Property IdGrupo As Integer
        Get
            Return _IdGrupo
        End Get
        Set(value As Integer)
            _IdGrupo = value
        End Set
    End Property

    Public Property Grupo As String
        Get
            Return _Grupo
        End Get
        Set(value As String)
            _Grupo = value
        End Set
    End Property
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Metodo que me llena un tabla con los grupos sanguineos guardados en la base de datos
    ''' </summary>
    ''' <param name="tabla">Tabla a llenar</param>
    Public Sub obtenerRegistros(ByRef tabla As DataTable)
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        Dim query As String

        'Guardo la query armada con el nombre de la tabla a consultar
        query = consulta.consultarRegistros("GruposSanguineos")
        'Ejecuto el comando para que me llene la tabla de grupos sanguineos con los datos de la base de datos segun la query armada
        ejecucion.obtenerRegistros(tabla, query)
    End Sub
#End Region
End Class
