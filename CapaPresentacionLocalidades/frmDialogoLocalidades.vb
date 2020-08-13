Imports entProvincia
Imports entLocalidad
Public Class frmDialogoLocalidades
#Region "Campos"
    'Creo campos para guardar el nombre e Id de la localidad seleccionada y podes trasladarlos a otros formularios
    Private _IdLocal As Integer = -1
    Private _NombreLoca As String
#End Region

#Region "Propiedades"
    Public Property IdLocal As Integer
        Get
            Return _IdLocal
        End Get
        Set(value As Integer)
            _IdLocal = value
        End Set
    End Property

    Public Property NombreLoca As String
        Get
            Return _NombreLoca
        End Get
        Set(value As String)
            _NombreLoca = value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmDialogoLocalidades_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Creo un objeto de la entidad provincia
            Dim provincias As New eProvincia
            Dim tablaProvincia As New DataTable

            'Lleno la tabla de provincias
            provincias.ObtenerProvincias(tablaProvincia)

            'Al combo box le asigno la fuente de datos y cuales datos mostrara (DisplayMember) y cuales tomara como referencia ante consultas (ValueMember)
            With cboProvincias
                .DataSource = tablaProvincia
                .DisplayMember = "Nombre"
                .ValueMember = "IdProvincia"
            End With

            'Coloco el cbo en Mendoza
            cboProvincias.SelectedValue = 12

            'Cambio el tamaño de la fuente del encabezado de las columnas
            dgvLocalidades.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 14, FontStyle.Bold)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Localidades")
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If IdLocal > -1 Then
                'Confirmo la accion
                DialogResult = DialogResult.OK
            Else
                Throw New Exception("Debe seleccionar un registro")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Localidades")
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Cierro el formulario
        Close()
    End Sub

    'Este evento se ejecuta cada vez que se presiona una tecla en el control
    Private Sub cboProvincias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboProvincias.KeyPress
        'Pregunto si es numerico el valor de la tecla presionada , de ser asi muestro no muestro el valor
        'El handled me indica que tomara lo que tecleamos y si es false lo dejara pasar, pero si es True lo toma y no me lo muestra
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub cboProvincias_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboProvincias.SelectedValueChanged
        Try
            Dim lo As New eLocalidad
            Dim tablaLocalidad As New DataTable

            'Llamo al metodo para obtener todas las localidades y mostrarla en el formulario. Pasar en segundo parametro el id de la provincia seleccionada en el cbo
            lo.obtenerLocalidadesProvincia(tablaLocalidad, cboProvincias.SelectedValue)

            'Asignarle de fuente de datos al DataGridView la tabla de localidad
            dgvLocalidades.DataSource = tablaLocalidad
            'Ordeno el DGV por nombre
            dgvLocalidades.Sort(dgvLocalidades.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
            'Limpio la seleccion actual
            dgvLocalidades.ClearSelection()
        Catch ex As Exception
            'No colocamos ningun mensaje puesto que en un principio el DGV estara vacio y largara error
        End Try
    End Sub

    'Evento que se lanzara cuando se haga click en una celda del DGV
    Private Sub dgvListadoLocalidades_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvLocalidades.CellMouseClick
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Asigno el Id de la localidad seleccionada (el cual se encuentra en la primer columna)
            IdLocal = dgvLocalidades.Rows(e.RowIndex).Cells(0).Value
            NombreLoca = dgvLocalidades.Rows(e.RowIndex).Cells(2).Value
        End If
    End Sub

    'Evento que se lanza al terminar de enlazarse los datos
    Private Sub dgvLocalidades_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvLocalidades.DataBindingComplete
        'Limpio la seleccion actual
        dgvLocalidades.ClearSelection()
    End Sub

    'Evento que se lanza al entrar el mouse a una celda
    Private Sub dgvLocalidades_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLocalidades.CellMouseEnter
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Cambio el back color de la fila
            dgvLocalidades.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aqua
        End If
    End Sub

    'Evento que se lanza al salir el mouse de una celda
    Private Sub dgvLocalidades_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLocalidades.CellMouseLeave
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Cambio el back color de la fila
            dgvLocalidades.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        End If
    End Sub
#End Region
End Class
