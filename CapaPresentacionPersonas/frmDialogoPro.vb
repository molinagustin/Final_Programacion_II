Imports entProfesionales
Public Class frmDialogoPro
#Region "Campos"
    'Creo campos para guardar el nombre e Id del Profesional seleccionado y poder trasladarlos a otros formularios
    Private _IdProfe As Integer = -1
    Private _NombreProfe As String

    'Query para la consulta a la BD
    Dim query As String = "SELECT * FROM Profesionales WHERE Profesionales.Activo = 1"
#End Region

#Region "Propiedades"
    Public Property IdProfe As Integer
        Get
            Return _IdProfe
        End Get
        Set(value As Integer)
            _IdProfe = value
        End Set
    End Property

    Public Property NombreProfe As String
        Get
            Return _NombreProfe
        End Get
        Set(value As String)
            _NombreProfe = value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmDialogoPro_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Cambio el tamaño de la fuente del encabezado de las columnas
            dgvListadoProfesionales.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 15, FontStyle.Bold)

            'Muestro los registros actuales en el DGV
            ActualizarDGV()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Text)
        End Try
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If IdProfe > -1 Then
                'Confirmo la accion
                DialogResult = DialogResult.OK
            Else
                Throw New Exception("Debe seleccionar un registro")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Text)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Cierro el formulario
        Close()
    End Sub

    'Evento que se lanza al hacer click sobre una celda
    Private Sub dgvListadoProfesionales_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListadoProfesionales.CellMouseClick
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Asigno el Id del profesional seleccionado (el cual se encuentra en la primer columna)
            IdProfe = dgvListadoProfesionales.Rows(e.RowIndex).Cells(0).Value
            NombreProfe = dgvListadoProfesionales.Rows(e.RowIndex).Cells(1).Value
        End If
    End Sub

    'Evento que se lanza al terminarse el enlace de datos
    Private Sub dgvListadoProfesionales_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvListadoProfesionales.DataBindingComplete
        'Limpio la seleccion actual
        dgvListadoProfesionales.ClearSelection()
    End Sub

    'Evento que se lanza al entrar el mouse a una celda
    Private Sub dgvListadoProfesionales_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoProfesionales.CellMouseEnter
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Cambio el back color de la fila
            dgvListadoProfesionales.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aqua
        End If
    End Sub

    'Evento que se lanza al salir el mouse de una celda
    Private Sub dgvListadoProfesionales_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoProfesionales.CellMouseLeave
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Cambio el back color de la fila
            dgvListadoProfesionales.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        End If
    End Sub
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Metodo que sirve para consultar la base de datos y llenar el DGV con los registros encontrados
    ''' </summary>
    Public Sub ActualizarDGV()
        'Creo nuevos objetos y vuelvo a llenar una tabla para mostrar el registro que fue agregado
        Dim profesionales As New eProfesional
        Dim tablaProf As New DataTable
        'Lleno la tabla
        profesionales.obtenerRegistros(tablaProf, query)

        'Se la asigno al DGV asi lo actualizo
        dgvListadoProfesionales.DataSource = tablaProf
        'Ordeno el DGV por nombre
        dgvListadoProfesionales.Sort(dgvListadoProfesionales.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        'Limpio la seleccion actual
        dgvListadoProfesionales.ClearSelection()
    End Sub
#End Region
End Class