Imports System.Data.SqlClient
Imports CapaDatos
Imports CapaNegocio
Public Class eObraSocial
#Region "Campos"
    Private _IdObraSocial As Integer
    Private _Sigla As String
    Private _NombreOS As String
    Private _Activo As Integer
    Private _IdUsuario As Integer
    Private _FechaUltimaModificacion As DateTime
#End Region

#Region "Propiedades"
    Public Property IdObraSocial As Integer
        Get
            Return _IdObraSocial
        End Get
        Set(value As Integer)
            _IdObraSocial = value
        End Set
    End Property

    Public Property Sigla As String
        Get
            Return _Sigla
        End Get
        Set(value As String)
            If Not value.Trim().Length > 20 And Not value.Trim() = "" And Not IsNumeric(value.Trim()) Then
                _Sigla = value.Trim()
            Else
                Throw New Exception("Largo y/o contenido de Sigla incorrecto")
            End If
        End Set
    End Property

    Public Property NombreOS As String
        Get
            Return _NombreOS
        End Get
        Set(value As String)
            If Not value.Trim().Length > 60 And Not value.Trim() = "" And Not IsNumeric(value.Trim()) Then
                _NombreOS = value.Trim()
            Else
                Throw New Exception("Largo y/o contenido de Nombre Obra Social incorrecto")
            End If
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
    ''' Metodo que inserta los datos de una obra social en la base de datos
    ''' </summary>
    ''' <param name="registro">Objeto con los datos a insertar</param>
    Public Sub insertarRegistro(ByRef registro As eObraSocial)
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        Dim registros As Integer

        registros = ejecucion.Actualizar(consulta.insertarNuevoRegistro(registro, "ObrasSociales"))
        MsgBox("Se inserto " & registros & " registro", MsgBoxStyle.Information, "Obras Sociales")
    End Sub

    ''' <summary>
    ''' Metodo para obtener los datos de una obra social
    ''' </summary>
    ''' <param name="IdReg">Numero de ID de la obra social a consultar</param>
    Public Sub obtenerRegistro(ByRef IdReg As Integer)
        'Creo un objeto para armar la query
        Dim registro As New clsArmadoQuery
        Dim queryConsulta As String
        'Asigno la query armada a un objeto del tipo string
        queryConsulta = registro.consultaRegistro("ObrasSociales", "IdObraSocial", IdReg)

        'A la capa de datos le pido que ejecute la query armada
        Dim ejecutarConsulta As New clsEjecucionQuery
        ejecutarConsulta.obtenerRegistro(Me, queryConsulta)
    End Sub

    ''' <summary>
    ''' Metodo que permite consultar todos los datos de los registros de las Obras Sociales activas
    ''' </summary>
    ''' <param name="tablaReg">Tabla a ser llenada con datos</param>
    Public Sub obtenerRegistros(ByRef tablaReg As DataTable)
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        Dim query As String

        'Guardo la query armada con el nombre de la tabla a consultar
        query = consulta.consultarRegistrosActivos("ObrasSociales")
        'Ejecuto el comando para que me llene la tabla de obras sociales con los datos de la base de datos segun la query armada
        ejecucion.obtenerRegistros(tablaReg, query)
    End Sub

    ''' <summary>
    ''' Metodo que sirve para consultar la base de datos y las tablas relacionadas
    ''' </summary>
    ''' <param name="tablaReg">Tabla a llenar con datos</param>
    ''' <param name="query">Query para la consulta con relacion</param>
    Public Sub obtenerRegistrosJoin(ByRef tablaReg As DataTable, query As String)
        Dim ejecucion As New clsEjecucionQuery
        'Ejecuto el comando para que me llene la tabla de obras sociales con los datos de la base de datos segun la query armada
        ejecucion.obtenerRegistros(tablaReg, query)
    End Sub

    ''' <summary>
    ''' Metodo que sirve para obtener todos los registros dados de baja
    ''' </summary>
    ''' <param name="tablaReg">Tabla a ser llenada con los datos</param>
    ''' <param name="nombreTabla">Nombre de la tabla a consultar</param>
    Public Sub obtenerRegistrosBaja(ByRef tablaReg As DataTable, nombreTabla As String)
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        Dim query As String

        'Guardo la query armada con el nombre de la tabla a consultar
        query = consulta.consultarRegistrosBaja(nombreTabla)

        'Ejecuto el comando para que me llene la tabla de registros con los datos de la base de datos segun la query armada
        ejecucion.obtenerRegistros(tablaReg, query)
    End Sub
#End Region

#Region "Funciones"
    ''' <summary>
    ''' Funcion que permite actualizar los datos de una obra social
    ''' </summary>
    ''' <param name="registroNuevo">Objeto con los datos a ser actualizados</param>
    ''' <returns></returns>
    Public Function actualizarRegistro(ByRef registroNuevo As eObraSocial) As Integer
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        Dim registrosActualizados As Integer
        Dim comando As New SqlCommand

        'El comando devuelto por la funcion se guarda en el objeto comando
        comando = consulta.actualizarRegistro(Me, registroNuevo, "ObrasSociales", "IdObraSocial")
        'Ejecuto la funcion de actualizacion y guardo el resultado de los registros actualizados
        registrosActualizados = ejecucion.Actualizar(comando)

        Return registrosActualizados
    End Function
#End Region
End Class
