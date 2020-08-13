Imports entLocalidad
Imports entProvincia

Public Class frmVistaLocalidades
#Region "Campos"
    'Localidad seleccionada
    Private _IdLocal As Integer
    Private _IdProv As Integer

    'Usuario actual
    Private _IdUsuAct As Integer
#End Region

#Region "Propiedades"
    'Hago de solo lectura la propiedad porque no sera necesario modificar el valor desde afuera
    Public ReadOnly Property IdLocal As Integer
        Get
            Return _IdLocal
        End Get
    End Property

    Public Property IdUsuAct As Integer
        Get
            Return _IdUsuAct
        End Get
        Set(value As Integer)
            _IdUsuAct = value
        End Set
    End Property

    Public Property IdProv As Integer
        Get
            Return _IdProv
        End Get
        Set(value As Integer)
            _IdProv = value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmVistaLocalidades_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Creo un objeto de la entidad provincia
            Dim provincias As New eProvincia
            Dim tablaProvincia As New DataTable

            'Lleno la tabla de provincias
            provincias.ObtenerProvincias(tablaProvincia)

            'Al combo box le asigno la fuente de datos y cuales datos mostrara (DisplayMember) y cuales tomara como referencia ante consultas (ValueMember)
            With cboProvincia
                .DataSource = tablaProvincia
                .DisplayMember = "Nombre"
                .ValueMember = "IdProvincia"
            End With

            'Coloco el cbo por defecto en Mendoza
            cboProvincia.SelectedValue = 12

            'Cambio el tamaño de la fuente del encabezado de las columnas
            dgvListadoLocalidades.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 15, FontStyle.Bold)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Cierro el formulario
        Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'Creo un objeto nuevo
        Dim nuevaLoc As New frmGestionLocalidades

        'Guardo el valor de la provincia
        IdProv = cboProvincia.SelectedValue

        'Le asigno las propiedades y lo muestro como objeto de dialogo
        With nuevaLoc
            .Text = "ALTA DE LOCALIDAD"
            .TipoFormulario = frmGestionLocalidades.TipoFormu.Nueva
            .IdUsuAct = IdUsuAct
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                'Actualizo el DGV
                cboProvincia.SelectedValue = 0
                cboProvincia.SelectedValue = .IdProvi
            End If
        End With
    End Sub

    Private Sub cboProvincia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboProvincia.KeyPress
        'Pregunto si es numerico el valor de la tecla presionada , de ser asi muestro no muestro el valor
        'El handled me indica que tomara lo que tecleamos y si es false lo dejara pasar, pero si es True lo toma y no me lo muestra
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub cboProvincia_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboProvincia.SelectedValueChanged
        Try
            Dim lo As New eLocalidad
            Dim tablaLocalidad As New DataTable

            'Llamo al metodo para obtener todas las localidades y mostrarla en el formulario. Pasar en segundo parametro el id de la provincia seleccionada en el cbo
            lo.obtenerLocalidadesProvinciaJoin(tablaLocalidad, cboProvincia.SelectedValue)

            'Asignarle de fuente de datos al DataGridView la tabla de localidad
            dgvListadoLocalidades.DataSource = tablaLocalidad
            'Ordeno el DGV por nombre
            dgvListadoLocalidades.Sort(dgvListadoLocalidades.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
            'Limpio la seleccion actual
            dgvListadoLocalidades.ClearSelection()
        Catch ex As Exception
            'No colocamos ningun mensaje puesto que en un principio el DGV estara vacio y largara error
        End Try
    End Sub

    'Evento que ocurre al hacer doble click sobre una celda del DGV
    Private Sub dgvListadoLocalidades_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListadoLocalidades.CellMouseDoubleClick
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Asigno el Id de la localidad seleccionada (el cual se encuentra en la primer columna)
            _IdLocal = dgvListadoLocalidades.Rows(e.RowIndex).Cells(0).Value

            'Creo un objeto nuevo
            Dim nuevaLoc As New frmGestionLocalidades

            'Le asigno las propiedades y lo muestro como dialogo
            With nuevaLoc
                .Text = "MODIFICACION DE LOCALIDAD"
                .TipoFormulario = frmGestionLocalidades.TipoFormu.Modificar
                .IdLocali = IdLocal
                .IdUsuAct = IdUsuAct
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    'Actualizo el DGV
                    cboProvincia.SelectedValue = 0
                    cboProvincia.SelectedValue = .IdProvi
                End If
            End With
        End If
    End Sub

    'Evento que se lanza al terminarse el enlace de datos
    Private Sub dgvListadoLocalidades_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvListadoLocalidades.DataBindingComplete
        'Limpio la seleccion actual
        dgvListadoLocalidades.ClearSelection()
    End Sub

    'Evento que se lanza al entrar el mouse a una celda
    Private Sub dgvListadoLocalidades_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoLocalidades.CellMouseEnter
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Cambio el back color de la fila
            dgvListadoLocalidades.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aqua
        End If
    End Sub

    'Evento que se lanza al salir el mouse de una celda
    Private Sub dgvListadoLocalidades_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoLocalidades.CellMouseLeave
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Cambio el back color de la fila
            dgvListadoLocalidades.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        End If
    End Sub
#End Region
End Class