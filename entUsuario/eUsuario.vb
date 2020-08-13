Imports CapaDatos
Imports CapaNegocio
Imports System.Data.SqlClient
Public Class eUsuario
#Region "Campos"
    Private _IdUsuario As Integer
    Private _Nombre As String
    Private _Usuario As String
    Private _HashContrasenia As String
    Private _SaltContrasenia As String
    Private _IdPrivilegio As Integer
    Private _Activo As Integer
    Private _FechaUltimaModificacion As DateTime
#End Region

#Region "Propiedades"
    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(value As Integer)
            _IdUsuario = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            If Not value.Trim().Length > 40 And Not value.Trim() = "" And Not IsNumeric(value.Trim()) Then
                _Nombre = value.Trim()
            Else
                Throw New Exception("Largo y/o contenido de Nombre incorrecto")
            End If
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _Usuario
        End Get
        Set(value As String)
            If Not value.Trim().Length > 15 And Not value.Trim() = "" And Not IsNumeric(value.Trim()) Then
                _Usuario = value.Trim()
            Else
                Throw New Exception("Largo y/o contenido de Usuario incorrecto")
            End If
        End Set
    End Property

    Public Property HashContrasenia As String
        Get
            Return _HashContrasenia
        End Get
        Set(value As String)
            If Not value.Trim() = "" Then
                _HashContrasenia = value
            Else
                Throw New Exception("La contraseña no puede estar vacia")
            End If
        End Set
    End Property

    Public Property SaltContrasenia As String
        Get
            Return _SaltContrasenia
        End Get
        Set(value As String)
            If Not value.Trim() = "" Then
                _SaltContrasenia = value
            Else
                Throw New Exception("La contraseña no puede estar vacia")
            End If
        End Set
    End Property

    Public Property IdPrivilegio As Integer
        Get
            Return _IdPrivilegio
        End Get
        Set(value As Integer)
            _IdPrivilegio = value
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
    ''' Metodo que inserta un nuevo usuario en la base de datos
    ''' </summary>
    ''' <param name="usuario">Un objeto con datos del tipo eUsuario</param>
    Public Sub insertarUsuario(ByRef usuario As eUsuario)
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        Dim registros As Integer

        registros = ejecucion.Actualizar(consulta.insertarNuevoRegistro(usuario, "Usuarios"))
        MsgBox("Se inserto " & registros & " registro", MsgBoxStyle.Information, "Usuarios")
    End Sub

    ''' <summary>
    ''' Metodo que permite obtener los datos de un usuario de la base de datos (USO SOLO PARA LOGIN)
    ''' </summary>
    ''' <param name="objetoUsuario">Objeto donde se guardaran los datos obtenidos</param>
    ''' <param name="usuario">Nombre de usuario utilizado</param>
    Public Sub obtenerUsuario(ByRef objetoUsuario As eUsuario, usuario As String)
        'La query para seleccionar realizar la consulta con el usuario pasado por parametro (La clausula COLLATE (comparar) es la que me permite determinar si hay mayusculas usadas o no en el usuario. El termino CS = Case Sensitive, AS = Accent Sensitive)
        Dim query As String = "SELECT * FROM Usuarios WHERE Usuario = '" & usuario & "' COLLATE Traditional_Spanish_CS_AS;"
        Dim ejecucion As New clsEjecucionQuery

        'El metodo que me permite obtener un usuario y todos sus datos guardados
        ejecucion.obtenerRegistro(objetoUsuario, query)
    End Sub

    ''' <summary>
    ''' Metodo para obtener los datos de un usuario (Por ID)
    ''' </summary>
    ''' <param name="IdReg">Numero de ID del usuario a consultar</param>
    Public Sub obtenerRegistro(ByRef IdReg As Integer)
        'Creo un objeto para armar la query
        Dim registro As New clsArmadoQuery
        Dim queryConsulta As String
        'Asigno la query armada a un objeto del tipo string
        queryConsulta = registro.consultaRegistro("Usuarios", "IdUsuario", IdReg)

        'A la capa de datos le pido que ejecute la query armada
        Dim ejecutarConsulta As New clsEjecucionQuery
        ejecutarConsulta.obtenerRegistro(Me, queryConsulta)
    End Sub

    ''' <summary>
    ''' Metodo que permite consultar todos los datos de los registros de los usuarios (Activos y No Activos)
    ''' </summary>
    ''' <param name="tablaReg">Tabla a ser llenada con datos</param>
    ''' <param name="query">Query de la consulta</param>
    Public Sub obtenerRegistros(ByRef tablaReg As DataTable, query As String)
        Dim ejecucion As New clsEjecucionQuery

        'Ejecuto el comando para que me llene la tabla de usuarios con los datos de la base de datos segun la query armada
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
    ''' Funcion que permite actualizar los datos de un usuario
    ''' </summary>
    ''' <param name="registroNuevo">Objeto con los datos a ser actualizados</param>
    ''' <returns></returns>
    Public Function actualizarRegistro(ByRef registroNuevo As eUsuario) As Integer
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        Dim registrosActualizados As Integer
        Dim comando As New SqlCommand

        'El comando devuelto por la funcion se guarda en el objeto comando
        comando = consulta.actualizarRegistro(Me, registroNuevo, "Usuarios", "IdUsuario")
        'Ejecuto la funcion de actualizacion y guardo el resultado de los registros actualizados
        registrosActualizados = ejecucion.Actualizar(comando)

        Return registrosActualizados
    End Function
#End Region
End Class