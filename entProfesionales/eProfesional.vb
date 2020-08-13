Imports entPersona
Public Class eProfesional
#Region "Herencia"
    Inherits ePersona
#End Region

#Region "Campos"
    'Creo el campo IdProfesional y su propiedad porque si uso el IdPersona heredado, luego al momento de hacer consultas a la base de datos voy a tener que especificar a que tabla hago referencia porque se usara en varias clases que hereden desde ePersona
    Private _IdProfesional As Integer
    Private _Especialidad As String
#End Region

#Region "Propiedades"
    Public Property IdProfesional As Integer
        Get
            Return _IdProfesional
        End Get
        Set(value As Integer)
            _IdProfesional = value
        End Set
    End Property

    Public Property Especialidad As String
        Get
            Return _Especialidad
        End Get
        Set(value As String)
            _Especialidad = value
        End Set
    End Property
#End Region
End Class
