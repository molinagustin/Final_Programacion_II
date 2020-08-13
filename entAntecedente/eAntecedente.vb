Imports CapaDatos
Imports CapaNegocio
Imports System.Data.SqlClient
Public Class eAntecedente
#Region "Campos"
    Private _IdAntecedente As Integer
    Private _IdPaciente As Integer
    Private _Patologicos As String
    Private _NoPatologicos As String
    Private _Hereditarios As String
    Private _GrupoSanguineo As Integer
    Private _FechaUltimaModificacion As DateTime
#End Region

#Region "Propiedades"
    Public Property IdAntecedente As Integer
        Get
            Return _IdAntecedente
        End Get
        Set(value As Integer)
            _IdAntecedente = value
        End Set
    End Property

    Public Property IdPaciente As Integer
        Get
            Return _IdPaciente
        End Get
        Set(value As Integer)
            _IdPaciente = value
        End Set
    End Property

    Public Property Patologicos As String
        Get
            Return _Patologicos
        End Get
        Set(value As String)
            _Patologicos = value.Trim()
        End Set
    End Property

    Public Property NoPatologicos As String
        Get
            Return _NoPatologicos
        End Get
        Set(value As String)
            _NoPatologicos = value.Trim()
        End Set
    End Property

    Public Property Hereditarios As String
        Get
            Return _Hereditarios
        End Get
        Set(value As String)
            _Hereditarios = value.Trim()
        End Set
    End Property

    Public Property GrupoSanguineo As Integer
        Get
            Return _GrupoSanguineo
        End Get
        Set(value As Integer)
            _GrupoSanguineo = value
        End Set
    End Property

    Public Property FechaUltimaModificacion As DateTime
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
    ''' Metodo que inserta los datos de un antecedente en la base de datos
    ''' </summary>
    ''' <param name="registro">Objeto con los datos a insertar</param>
    Public Sub insertarRegistro(ByRef registro As eAntecedente)
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        Dim registros As Integer

        registros = ejecucion.Actualizar(consulta.insertarNuevoRegistro(registro, "Antecedentes"))
    End Sub

    ''' <summary>
    ''' Metodo que me permite obtener los registros de antecedentes de un paciente
    ''' </summary>
    ''' <param name="IdPaciente">Id del paciente cuyos antecedenes buscamos</param>
    Public Sub obtenerRegistro(IdPaciente As Integer)
        'Creo un objeto para armar la query
        Dim queryConsulta As String = "SELECT * FROM Antecedentes WHERE IdPaciente = " & IdPaciente

        'A la capa de datos le pido que ejecute la query armada
        Dim ejecutarConsulta As New clsEjecucionQuery
        ejecutarConsulta.obtenerRegistro(Me, queryConsulta)
    End Sub
#End Region

#Region "Funciones"
    ''' <summary>
    ''' Funcion que permite actualizar los datos de un antecedente
    ''' </summary>
    ''' <param name="registroNuevo">Objeto con los datos a ser actualizados</param>
    ''' <returns></returns>
    Public Function actualizarRegistro(ByRef registroNuevo As eAntecedente) As Integer
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        Dim registrosActualizados As Integer
        Dim comando As New SqlCommand

        'El comando devuelto por la funcion se guarda en el objeto comando
        comando = consulta.actualizarRegistro(Me, registroNuevo, "Antecedentes", "IdAntecedente")
        'Ejecuto la funcion de actualizacion y guardo el resultado de los registros actualizados
        registrosActualizados = ejecucion.Actualizar(comando)

        Return registrosActualizados
    End Function
#End Region
End Class
