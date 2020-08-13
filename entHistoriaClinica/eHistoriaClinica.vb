Imports CapaDatos
Imports CapaNegocio
Public Class eHistoriaClinica
#Region "Campos"
    'Declaro campos a utilizar
    Private _IdHClinica As Integer
    Private _Fecha As Date
    Private _Paciente As Integer
    Private _MotivoConsulta As String
    Private _Diagnostico As String
    Private _Tratamiento As String
    Private _Peso As String
    Private _Altura As String
    Private _PresionArterial As String
    Private _FrecuenciaCard As String
    Private _FrecuenciaResp As String
    Private _Analitica As String
    Private _IdUsuario As Integer
    Private _FechaUltimaModificacion As DateTime
#End Region

#Region "Propiedades"
    Public Property IdHClinica As Integer
        Get
            Return _IdHClinica
        End Get
        Set(value As Integer)
            _IdHClinica = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            If value > Today.Date Then
                Throw New Exception("La Fecha no puede ser mayor a la actual")
            Else
                'No hago comprobacion de fechas anteriores a la actual porque si la persona quiere cargar registros viejos tendria problemas, o si necesita cargar registros de dias pasados tampoco se lo permitiria
                _Fecha = value
            End If
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

    Public Property MotivoConsulta As String
        Get
            Return _MotivoConsulta
        End Get
        Set(value As String)
            _MotivoConsulta = value.Trim()
        End Set
    End Property

    Public Property Diagnostico As String
        Get
            Return _Diagnostico
        End Get
        Set(value As String)
            _Diagnostico = value.Trim()
        End Set
    End Property

    Public Property Tratamiento As String
        Get
            Return _Tratamiento
        End Get
        Set(value As String)
            _Tratamiento = value.Trim()
        End Set
    End Property

    Public Property Peso As String
        Get
            Return _Peso
        End Get
        Set(value As String)
            _Peso = value.Trim()
        End Set
    End Property

    Public Property Altura As String
        Get
            Return _Altura
        End Get
        Set(value As String)
            _Altura = value.Trim()
        End Set
    End Property

    Public Property PresionArterial As String
        Get
            Return _PresionArterial
        End Get
        Set(value As String)
            _PresionArterial = value.Trim()
        End Set
    End Property

    Public Property FrecuenciaCard As String
        Get
            Return _FrecuenciaCard
        End Get
        Set(value As String)
            _FrecuenciaCard = value.Trim()
        End Set
    End Property

    Public Property FrecuenciaResp As String
        Get
            Return _FrecuenciaResp
        End Get
        Set(value As String)
            _FrecuenciaResp = value.Trim()
        End Set
    End Property

    Public Property Analitica As String
        Get
            Return _Analitica
        End Get
        Set(value As String)
            _Analitica = value.Trim()
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
    ''' Metodo que inserta los datos de una historia clinica en la base de datos
    ''' </summary>
    ''' <param name="registro">Objeto con los datos a insertar</param>
    Public Sub insertarRegistro(ByRef registro As eHistoriaClinica)
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        Dim registros As Integer

        registros = ejecucion.Actualizar(consulta.insertarNuevoRegistro(registro, "HistoriasClinicas"))
        MsgBox("Se inserto " & registros & " registro", MsgBoxStyle.Information, "Historias Clinicas")
    End Sub
    ''' <summary>
    ''' Metodo para obtener los datos de una historia clinica
    ''' </summary>
    ''' <param name="IdReg">Numero de ID de la historia clinica a consultar</param>
    Public Sub obtenerRegistro(ByRef IdReg As Integer)
        'Creo un objeto para armar la query
        Dim registro As New clsArmadoQuery
        Dim queryConsulta As String
        'Asigno la query armada a un objeto del tipo string.
        queryConsulta = registro.consultaRegistro("HistoriasClinicas", "IdHClinica", IdReg)

        'A la capa de datos le pido que ejecute la query armada
        Dim ejecutarConsulta As New clsEjecucionQuery
        ejecutarConsulta.obtenerRegistro(Me, queryConsulta)
    End Sub
    ''' <summary>
    ''' Metodo que permite consultar todos los datos de los registros de las Historias Clinicas de un paciente
    ''' </summary>
    ''' <param name="tablaReg">Tabla a ser llenada con los datos</param>
    ''' <param name="IdPaciente">Numero de Id del paciente a consultar</param>
    Public Sub obtenerRegistros(ByRef tablaReg As DataTable, IdPaciente As Integer)
        Dim ejecucion As New clsEjecucionQuery
        Dim query As String

        'Armo la query especifica para este caso
        query = "SELECT * FROM HistoriasClinicas WHERE Paciente = " & IdPaciente & ";"
        'Ejecuto el comando para que me llene la tabla de historias clinicas con los datos de la base de datos segun la query armada
        ejecucion.obtenerRegistros(tablaReg, query)
    End Sub

    ''' <summary>
    ''' Metodo que permite obtener todas las historias clinicas de la base de datos, indistintamente del paciente que se trate
    ''' </summary>
    ''' <param name="tablaReg">Tabla a llenar con datos</param>
    Public Sub obtenerTodosRegistros(ByRef tablaReg As DataTable)
        'La query de seleccion
        Dim query As String = "SELECT * FROM HistoriasClinicas"
        'La clase que permite realizar la consulta a la BD
        Dim ejecucion As New clsEjecucionQuery
        'Lleno la tabla pasada por referencia
        ejecucion.obtenerRegistros(tablaReg, query)
    End Sub
#End Region
End Class
