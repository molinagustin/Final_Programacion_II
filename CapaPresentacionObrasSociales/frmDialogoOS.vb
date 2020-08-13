Imports entObraSocial
Public Class frmDialogoOS
#Region "Campos"
    'Creo campos para guardar el nombre e Id de la OS seleccionada y poder trasladarlos a otros formularios
    Private _IdObra As Integer = -1
    Private _NombreObraS As String
#End Region

#Region "Propiedades"
    Public Property IdObra As Integer
        Get
            Return _IdObra
        End Get
        Set(value As Integer)
            _IdObra = value
        End Set
    End Property

    Public Property NombreObraS As String
        Get
            Return _NombreObraS
        End Get
        Set(value As String)
            _NombreObraS = value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmDialogoOS_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Creo nuevos objetos y vuelvo a llenar una tabla para mostrar el registro que fue agregado
            Dim obraSocial As New eObraSocial
            Dim tablaOS As New DataTable
            'Lleno la tabla
            obraSocial.obtenerRegistros(tablaOS)

            'Se la asigno al DGV asi lo actualizo
            dgvListadoOS.DataSource = tablaOS
            'Ordeno el DGV por nombre
            dgvListadoOS.Sort(dgvListadoOS.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            'Limpio la primer fila seleccionada
            dgvListadoOS.ClearSelection()

            'Cambio el tamaño de la fuente del encabezado de las columnas
            dgvListadoOS.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 15, FontStyle.Bold)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If IdObra > -1 Then
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

    'Evento que se lanza al hacer click en una celda
    Private Sub dgvListadoOS_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListadoOS.CellMouseClick
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Asigno el Id de la OS seleccionada (el cual se encuentra en la primer columna)
            IdObra = dgvListadoOS.Rows(e.RowIndex).Cells(0).Value
            NombreObraS = dgvListadoOS.Rows(e.RowIndex).Cells(1).Value
        End If
    End Sub

    'Evento que se lanza al terminar de enlazarse los datos
    Private Sub dgvListadoOS_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvListadoOS.DataBindingComplete
        'Limpio la seleccion actual
        dgvListadoOS.ClearSelection()
    End Sub

    'Evento que se lanza al entrar el mouse a una celda
    Private Sub dgvListadoOS_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoOS.CellMouseEnter
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Cambio el back color de la fila
            dgvListadoOS.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aqua
        End If
    End Sub

    'Evento que se lanza al salir el mouse de una celda
    Private Sub dgvListadoOS_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoOS.CellMouseLeave
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Cambio el back color de la fila
            dgvListadoOS.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        End If
    End Sub
#End Region
End Class