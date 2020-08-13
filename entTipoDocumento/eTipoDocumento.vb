Imports CapaDatos
Imports CapaNegocio
Public Class eTipoDocumento
#Region "Campos"
    Private _IdTiposDocumentos As Integer
    Private _Sigla As String
    Private _NombreCompleto As String
    Private _IdUsuario As Integer
    Private _FechaUltimaModificacion As DateTime
#End Region

#Region "Propiedades"
    Public Property IdTiposDocumentos As Integer
        Get
            Return _IdTiposDocumentos
        End Get
        Set(value As Integer)
            _IdTiposDocumentos = value
        End Set
    End Property

    Public Property Sigla As String
        Get
            Return _Sigla
        End Get
        Set(value As String)
            If Not value.Trim().Length > 6 And Not value.Trim() = "" And Not IsNumeric(value.Trim()) Then
                _Sigla = value.Trim()
            Else
                Throw New Exception("Largo y/o contenido de Sigla incorrecto")
            End If
        End Set
    End Property

    Public Property NombreCompleto As String
        Get
            Return _NombreCompleto
        End Get
        Set(value As String)
            If Not value.Trim().Length > 35 And Not value.Trim() = "" And Not IsNumeric(value.Trim()) Then
                _NombreCompleto = value.Trim()
            Else
                Throw New Exception("Largo y/o contenido de Nombre Documento incorrecto")
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
    ''' Metodo que me llena un tabla con los tipos de documentos guardados en la base de datos
    ''' </summary>
    ''' <param name="tablaTiposDoc">La tabla a llenar con el nombre de los tipos de documentos</param>
    Public Sub ObtenerTiposDocumentos(ByRef tablaTiposDoc As DataTable)
        Dim consulta As New clsArmadoQuery
        Dim ejecucion As New clsEjecucionQuery
        Dim query As String

        'Guardo la query armada con el nombre de la tabla a consultar
        query = consulta.consultarRegistros("TiposDocumentos")
        'Ejecuto el comando para que me llene la tabla de tipos de documentos con los datos de la base de datos segun la query armada
        ejecucion.obtenerRegistros(tablaTiposDoc, query)
    End Sub
#End Region
End Class
