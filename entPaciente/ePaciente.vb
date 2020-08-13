Imports entPersona
Public Class ePaciente
#Region "Herencia"
    Inherits ePersona
#End Region

#Region "Campos"
    'Creo el campo IdPaciente y su propiedad porque si uso el IdPersona heredado, luego al momento de hacer consultas a la base de datos voy a tener que especificar a que tabla hago referencia porque se usara en varias clases que hereden desde ePersona
    Private _IdPaciente As Integer
    Private _ObraSocial As Integer
    Private _NumObraSoc As String
    Private _FechaNacimiento As Date
    Private _NumTelefono As String
    Private _CorreoElectronico As String
#End Region

#Region "Propiedades"
    Public Property IdPaciente As Integer
        Get
            Return _IdPaciente
        End Get
        Set(value As Integer)
            _IdPaciente = value
        End Set
    End Property

    Public Property ObraSocial As Integer
        Get
            Return _ObraSocial
        End Get
        Set(value As Integer)
            'Compruebo que se seleccione una obra social
            If value > -1 Then
                _ObraSocial = value
            Else
                Throw New Exception("Debe seleccionar una Obra Social")
            End If
        End Set
    End Property

    Public Property NumObraSoc As String
        Get
            Return _NumObraSoc
        End Get
        Set(value As String)
            If Not value.Trim().Length > 16 And Not value.Trim() = "" Then
                _NumObraSoc = value
            Else
                Throw New Exception("Largo y/o contenido de Numero Obra Social incorrecto")
            End If
        End Set
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return _FechaNacimiento
        End Get
        Set(value As Date)
            'Si la fecha de nacimiento es mayor a la fecha actual es un error
            If value.Date > Today.Date Then
                Throw New Exception("Error de fecha de nacimiento")
            Else
                _FechaNacimiento = value
            End If
        End Set
    End Property

    Public Property CorreoElectronico As String
        Get
            Return _CorreoElectronico
        End Get
        Set(value As String)
            If value.Trim() = "" Then
                'Al momento de querer guardar el correo, se lanza el evento que estara declarado en el formulario para validar el correo
                _CorreoElectronico = value.Trim()
            Else
                RaiseEvent ValidarCorreo(value.Trim())
                _CorreoElectronico = value.Trim()
            End If
        End Set
    End Property

    Public Property NumTelefono As String
        Get
            Return _NumTelefono
        End Get
        Set(value As String)
            If Not value.Trim() = "" Then
                If IsNumeric(value) Then
                    _NumTelefono = value
                Else
                    Throw New Exception("Solo se admiten numeros en el telefono")
                End If
            Else
                Throw New Exception("El numero de telefono no puede quedar vacio")
            End If
        End Set
    End Property
#End Region

#Region "Eventos"
    'Declaro el nuevo evento
    Public Event ValidarCorreo(correo As String)
#End Region
End Class
