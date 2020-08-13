Imports CapaDatos
Imports CapaNegocio
Imports System.Data.SqlClient
Public Class eTurnos
#Region "Campos"
    Private _IdTurno As Integer
    Private _HoraTurno As String
    Private _Fecha As Date
    Private _Paciente As Integer
    Private _Profesional As Integer
    Private _Activo As Integer
    Private _IdUsuario As Integer
    Private _FechaUltimaModificacion As DateTime
#End Region

#Region "Propiedades"
    Public Property IdTurno As Integer
        Get
            Return _IdTurno
        End Get
        Set(value As Integer)
            _IdTurno = value
        End Set
    End Property

    Public Property HoraTurno As String
        Get
            Return _HoraTurno
        End Get
        Set(value As String)
            _HoraTurno = value
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

    Public Property Paciente As Integer
        Get
            Return _Paciente
        End Get
        Set(value As Integer)
            _Paciente = value
        End Set
    End Property

    Public Property Profesional As Integer
        Get
            Return _Profesional
        End Get
        Set(value As Integer)
            _Profesional = value
        End Set
    End Property

    Public Property Activo As Integer
        Get
            Return _Activo
        End Get
        Set(value As Integer)
            _Activo = value
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
    ''' Metodo que inserta los datos de un turno en la base de datos
    ''' </summary>
    ''' <param name="registro">Objeto con los datos a insertar</param>
    Public Sub insertarRegistro(ByRef registro As eTurnos)
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        Dim registros As Integer

        registros = ejecucion.Actualizar(consulta.insertarNuevoRegistro(registro, "Turnos"))
        If registros > 0 Then
            MsgBox("NUEVO TURNO DADO DE ALTA", MsgBoxStyle.Information, "Turnos")
        Else
            Throw New Exception("El turno no pudo ser guardado")
        End If
    End Sub

    ''' <summary>
    ''' Metodo para obtener los datos de un turno
    ''' </summary>
    ''' <param name="IdReg">Numero de ID del turno a consultar</param>
    Public Sub obtenerRegistro(ByRef IdReg As Integer)
        'Creo un objeto para armar la query
        Dim registro As New clsArmadoQuery
        Dim queryConsulta As String
        'Asigno la query armada a un objeto del tipo string
        queryConsulta = registro.consultaRegistro("Turnos", "IdTurno", IdReg)

        'A la capa de datos le pido que ejecute la query armada
        Dim ejecutarConsulta As New clsEjecucionQuery
        ejecutarConsulta.obtenerRegistro(Me, queryConsulta)
    End Sub

    ''' <summary>
    ''' Metodo que me trae todos los turnos de una fecha
    ''' </summary>
    ''' <param name="tabla">tabla a llenar</param>
    ''' <param name="fecha">fecha consultada</param>
    ''' <param name="IdProf">Id del profesional a consultar</param>
    Public Sub ObtenerTurnos(ByRef tabla As DataTable, fecha As Date, IdProf As Integer)
        Dim ejecucion As New clsEjecucionQuery
        Dim query As String

        'Arma una query especifica para este caso
        query = "SELECT * FROM Turnos WHERE Activo = 1 AND Fecha = '" & fecha & "' AND Profesional = " & IdProf
        'Ejecuto el comando para que me llene la tabla de las horas de los turnos con los datos de la base de datos segun la query armada
        ejecucion.obtenerRegistros(tabla, query)
    End Sub

    ''' <summary>
    ''' Metodo que me trae todos los turnos de una fecha
    ''' </summary>
    ''' <param name="tabla">tabla a llenar</param>
    ''' <param name="fecha">fecha consultada</param>
    Public Sub ObtenerTurnos(ByRef tabla As DataTable, fecha As Date)
        Dim ejecucion As New clsEjecucionQuery
        Dim query As String

        'Arma una query especifica para este caso
        query = "SELECT * FROM Turnos WHERE Activo = 1 AND Fecha = '" & fecha & "'"
        'Ejecuto el comando para que me llene la tabla de las horas de los turnos con los datos de la base de datos segun la query armada
        ejecucion.obtenerRegistros(tabla, query)
    End Sub
#End Region

#Region "Funciones"
    ''' <summary>
    ''' Funcion que permite actualizar los datos de un turno (dar de baja)
    ''' </summary>
    ''' <param name="registroNuevo">Objeto con los datos a ser actualizados</param>
    ''' <returns></returns>
    Public Function actualizarRegistro(ByRef registroNuevo As eTurnos) As Integer
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        Dim registrosActualizados As Integer
        Dim comando As New SqlCommand

        'El comando devuelto por la funcion se guarda en el objeto comando
        comando = consulta.actualizarRegistro(Me, registroNuevo, "Turnos", "IdTurno")
        'Ejecuto la funcion de actualizacion y guardo el resultado de los registros actualizados
        registrosActualizados = ejecucion.Actualizar(comando)

        Return registrosActualizados
    End Function
#End Region
End Class
