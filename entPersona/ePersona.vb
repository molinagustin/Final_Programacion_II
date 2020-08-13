Imports CapaDatos
Imports CapaNegocio
Imports System.Data.SqlClient
Public MustInherit Class ePersona
#Region "Campos"
    'Al declararlos del tipo PROTECTED se van a poder ver los campos desde la clase base (ésta) y desde las clases que hereden
    Protected _NombreCompleto As String
    Protected _Direccion As String
    Protected _TipoDocumento As Integer
    Protected _NumeroDocumento As String
    Protected _Genero As String
    Protected _Localidad As Integer
    Protected _Activo As Integer
    Protected _IdUsuario As Integer
    Protected _FechaUltimaModificacion As DateTime
#End Region

#Region "Propiedades"
    Public Property NombreCompleto As String
        Get
            Return _NombreCompleto
        End Get
        Set(value As String)
            If Not value.Trim().Length > 40 And Not value.Trim() = "" And Not IsNumeric(value.Trim()) Then
                _NombreCompleto = value.Trim()
            Else
                Throw New Exception("Largo y/o contenido de Nombre incorrecto")
            End If
        End Set
    End Property
    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            If Not value.Trim().Length > 35 And Not value.Trim() = "" Then
                _Direccion = value.Trim()
            Else
                Throw New Exception("Largo y/o contenido de Direccion incorrecto")
            End If
        End Set
    End Property
    Public Property TipoDocumento As Integer
        Get
            Return _TipoDocumento
        End Get
        Set(value As Integer)
            _TipoDocumento = value
        End Set
    End Property
    Public Property NumeroDocumento As String
        Get
            Return _NumeroDocumento
        End Get
        Set(value As String)
            'Solo se comprueba la longitud, el tipo de caracter se comprueba en el formulario
            If value.Trim().Length >= 7 And value.Trim().Length <= 8 Then
                _NumeroDocumento = value.Trim()
            Else
                Throw New Exception("Largo de Numero Documento incorrecto")
            End If
        End Set
    End Property
    Public Property Genero As String
        Get
            Return _Genero
        End Get
        Set(value As String)
            _Genero = value
        End Set
    End Property
    Public Property Localidad As Integer
        Get
            Return _Localidad
        End Get
        Set(value As Integer)
            'Compruebo que se seleccione una localidad
            If value > -1 Then
                _Localidad = value
            Else
                Throw New Exception("Debe seleccionar una localidad")
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
    ''' Metodo que permite insertar un registro en la base de datos
    ''' </summary>
    ''' <param name="registro">Objeto con los datos a insertar</param>
    ''' <param name="nombreTabla">Nombre de la tabla en la base de datos</param>
    Public Sub insertarRegistro(ByRef registro As Object, nombreTabla As String)
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        Dim registros As Integer

        registros = ejecucion.Actualizar(consulta.insertarNuevoRegistro(registro, nombreTabla))
        MsgBox("Se inserto " & registros & " registro", MsgBoxStyle.Information, nombreTabla)
    End Sub

    ''' <summary>
    ''' Metodo para obtener los datos de un registro en la base de datos
    ''' </summary>
    ''' <param name="IdReg">Numero de Id del registro</param>
    ''' <param name="nombreTabla">Nombre de la tabla a la cual consultar</param>
    ''' <param name="nombreCampoId">Nombre del campo Id guardado en la tabla</param>
    Public Sub obtenerRegistro(ByRef IdReg As Integer, nombreTabla As String, nombreCampoId As String)
        'Creo un objeto para armar la query
        Dim registro As New clsArmadoQuery
        Dim queryConsulta As String
        'Asigno la query armada a un objeto del tipo string
        queryConsulta = registro.consultaRegistro(nombreTabla, nombreCampoId, IdReg)

        'A la capa de datos le pido que ejecute la query armada
        Dim ejecutarConsulta As New clsEjecucionQuery
        ejecutarConsulta.obtenerRegistro(Me, queryConsulta)
    End Sub

    ''' <summary>
    ''' Metodo para obtener todos los registros de una tabla
    ''' </summary>
    ''' <param name="tablaReg">Tabla a ser llenada con los datos</param>
    ''' <param name="query">Query armada para la consulta</param>
    Public Sub obtenerRegistros(ByRef tablaReg As DataTable, query As String)
        Dim ejecucion As New clsEjecucionQuery

        'Ejecuto el comando para que me llene la tabla de registros con los datos de la base de datos segun la query armada
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
    ''' Funcion que me permite actualizar los datos de un registro
    ''' </summary>
    ''' <param name="registroNuevo">Objeto con los datos a ser actualizados</param>
    ''' <param name="nombreTabla">Nombre de la tabla a consultar</param>
    ''' <param name="nombreCampoId">Nombre del campo Id guardado en la tabla</param>
    ''' <returns></returns>
    Public Function actualizarRegistro(ByRef registroNuevo As Object, nombreTabla As String, nombreCampoId As String) As Integer
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        Dim registrosActualizados As New Integer
        Dim comando As New SqlCommand

        'El comando devuelto por la funcion se guarda en el objeto comando
        comando = consulta.actualizarRegistro(Me, registroNuevo, nombreTabla, nombreCampoId)
        'Ejecuto la funcion de actualizacion y guardo el resultado de los registros actualizados
        registrosActualizados = ejecucion.Actualizar(comando)

        Return registrosActualizados
    End Function
#End Region
End Class
