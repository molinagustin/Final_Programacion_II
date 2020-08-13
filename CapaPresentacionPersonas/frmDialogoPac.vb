Imports entPaciente
Public Class frmDialogoPac
#Region "Campos"
    'Creo campos para guardar el nombre e Id del Paciente seleccionado y poder trasladarlos a otros formularios
    Private _IdPaci As Integer = -1
    Private _NombrePaci As String

    'Query para la consulta a la BD
    Dim query As String = "SELECT * FROM Pacientes INNER JOIN ObrasSociales ON Pacientes.ObraSocial = ObrasSociales.IdObraSocial  WHERE Pacientes.Activo = 1"

    'Creo un binding source para guardar datos de la tabla
    Dim dataBin As New BindingSource
#End Region

#Region "Propiedades"
    Public Property IdPaci As Integer
        Get
            Return _IdPaci
        End Get
        Set(value As Integer)
            _IdPaci = value
        End Set
    End Property

    Public Property NombrePaci As String
        Get
            Return _NombrePaci
        End Get
        Set(value As String)
            _NombrePaci = value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmDialogoPac_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Cambio el tamaño de la fuente del encabezado de las columnas
            dgvListadoPacientes.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 15, FontStyle.Bold)

            'Muestro los registros actuales en el DGV
            ActualizarDGV()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If IdPaci > -1 Then
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
    Private Sub dgvListadoPacientes_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListadoPacientes.CellMouseClick
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Asigno el Id del paciente seleccionado (el cual se encuentra en la primer columna)
            IdPaci = dgvListadoPacientes.Rows(e.RowIndex).Cells(0).Value
            NombrePaci = dgvListadoPacientes.Rows(e.RowIndex).Cells(1).Value
        End If
    End Sub

    'Evento que se lanza al terminarse el enlace de datos
    Private Sub dgvListadoPacientes_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvListadoPacientes.DataBindingComplete
        'Limpio la seleccion actual
        dgvListadoPacientes.ClearSelection()
    End Sub

    'Evento que se lanza al entrar el mouse a una celda
    Private Sub dgvListadoPacientes_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoPacientes.CellMouseEnter
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Cambio el back color de la fila
            dgvListadoPacientes.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aqua
        End If
    End Sub

    'Evento que se lanza al salir el mouse de una celda
    Private Sub dgvListadoPacientes_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoPacientes.CellMouseLeave
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Cambio el back color de la fila
            dgvListadoPacientes.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        End If
    End Sub

    'Evento que se lanza al cambiar el contenido del TXT
    Private Sub txtBuscador_TextChanged(sender As Object, e As EventArgs) Handles txtBuscador.TextChanged
        'Realizo un filtro en el contenido del dataBin y es lo que mostrara en pantalla sobre el DGV
        dataBin.Filter = "NombreCompleto LIKE '%" & txtBuscador.Text & "%' OR NumeroDocumento LIKE '" & txtBuscador.Text & "%'"
    End Sub
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Metodo que sirve para consultar la base de datos y llenar el DGV con los registros encontrados
    ''' </summary>
    Public Sub ActualizarDGV()
        'Creo nuevos objetos y vuelvo a llenar una tabla para mostrar el registro que fue agregado
        Dim pacientes As New ePaciente
        Dim tablaPac As New DataTable
        'Lleno la tabla
        pacientes.obtenerRegistros(tablaPac, query)

        'Guardo la tabla en el binding source
        dataBin.DataSource = tablaPac

        'Se la asigno al DGV asi lo actualizo
        dgvListadoPacientes.DataSource = dataBin
        'Ordeno el DGV por nombre
        dgvListadoPacientes.Sort(dgvListadoPacientes.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        'Limpio la seleccion actual
        dgvListadoPacientes.ClearSelection()
    End Sub
#End Region
End Class