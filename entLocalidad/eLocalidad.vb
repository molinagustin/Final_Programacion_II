Imports CapaNegocio
Imports CapaDatos
Imports System.Data.SqlClient
Public Class eLocalidad
#Region "Campos"
    Private _IdLocalidad As Integer
    Private _IdProvincia As Integer
    Private _Localidad As String
    Private _CP As String
    Private _IdUsuario As Integer
    Private _FechaUltimaModificacion As DateTime
#End Region

#Region "Propiedades"
    Public Property IdLocalidad As Integer
        Get
            Return _IdLocalidad
        End Get
        Set(value As Integer)
            _IdLocalidad = value
        End Set
    End Property

    Public Property IdProvincia As Integer
        Get
            Return _IdProvincia
        End Get
        Set(value As Integer)
            _IdProvincia = value
        End Set
    End Property

    Public Property Localidad As String
        Get
            Return _Localidad
        End Get
        Set(value As String)
            If Not value.Trim().Length > 30 And Not value.Trim() = "" And Not IsNumeric(value.Trim()) Then
                _Localidad = value.Trim()
            Else
                Throw New Exception("Largo y/o contenido de Nombre Localidad incorrecto")
            End If
        End Set
    End Property

    Public Property CP As String
        Get
            Return _CP
        End Get
        Set(value As String)
            'Solo se comprueba la longitud, el tipo de caracter se comprueba en el formulario
            If value.Trim().Length <= 4 And IsNumeric(value.Trim()) Then
                _CP = value.Trim()
            Else
                Throw New Exception("Largo de contenido en Codigo Postal incorrecto")
            End If
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
    ''' Metodo que inserta los datos de una localidad en la base de datos
    ''' </summary>
    ''' <param name="registro">Objeto con los datos a insertar</param>
    Public Sub insertarRegistro(ByRef registro As eLocalidad)
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        Dim registros As Integer

        registros = ejecucion.Actualizar(consulta.insertarNuevoRegistro(registro, "Localidades"))
        MsgBox("Se inserto " & registros & " registro", MsgBoxStyle.Information, "Localidades")
    End Sub

    ''' <summary>
    ''' Metodo para obtener los datos de una una localidad
    ''' </summary>
    ''' <param name="IdReg">Numero de ID de la localidad a consultar</param>
    Public Sub obtenerRegistro(ByRef IdReg As Integer)
        'Creo un objeto para armar la query
        Dim registro As New clsArmadoQuery
        Dim queryConsulta As String
        'Asigno la query armada a un objeto del tipo string
        queryConsulta = registro.consultaRegistro("Localidades", "IdLocalidad", IdReg)

        'A la capa de datos le pido que ejecute la query armada
        Dim ejecutarConsulta As New clsEjecucionQuery
        ejecutarConsulta.obtenerRegistro(Me, queryConsulta)
    End Sub

    ''' <summary>
    ''' Metodo que me permite obtener todas las localidades de una provincia
    ''' </summary>
    ''' <param name="tablaLocalidad">La tabla a ser llenada con los datos obtenidos por el metodo</param>
    ''' <param name="IdProvincia">El Id de la provincia a la cual se hace referencia</param>
    ''' <remarks></remarks>
    Public Sub obtenerLocalidadesProvincia(ByRef tablaLocalidad As DataTable, IdProvincia As Integer)
        'Creo objetos para armar la query y ejecutarla
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        'Creo un objeto para almacenar la query
        Dim query As String = consulta.consultarRegistrosCompleto("Localidades", "IdProvincia", IdProvincia)
        'Ejecuto la query
        ejecucion.obtenerRegistros(tablaLocalidad, query)
    End Sub

    ''' <summary>
    ''' Metodo que me permite obtener todas las localidades de una provincia y con sus tablas relacionadas
    ''' </summary>
    ''' <param name="tablaLocalidad">La tabla a ser llenada con los datos obtenidos por el metodo</param>
    ''' <param name="IdProvincia">El Id de la provincia a la cual se hace referencia</param>
    Public Sub obtenerLocalidadesProvinciaJoin(ByRef tablaLocalidad As DataTable, IdProvincia As Integer)
        Dim ejecucion As New clsEjecucionQuery
        'Armo la query especifica para Localidades
        Dim query As String = "SELECT * FROM Localidades WHERE Localidades.IdProvincia = " & IdProvincia

        ejecucion.obtenerRegistros(tablaLocalidad, query)
    End Sub
#End Region

#Region "Funciones"
    ''' <summary>
    ''' Funcion que permite actualizar los datos de una localidad
    ''' </summary>
    ''' <param name="registroNuevo">Objeto con los datos a ser actualizados</param>
    ''' <returns></returns>
    Public Function actualizarRegistro(ByRef registroNuevo As eLocalidad) As Integer
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        Dim registrosActualizados As Integer
        Dim comando As New SqlCommand

        'El comando devuelto por la funcion se guarda en el objeto comando
        comando = consulta.actualizarRegistro(Me, registroNuevo, "Localidades", "IdLocalidad")
        'Ejecuto la funcion de actualizacion y guardo el resultado de los registros actualizados
        registrosActualizados = ejecucion.Actualizar(comando)

        Return registrosActualizados
    End Function
#End Region
End Class
