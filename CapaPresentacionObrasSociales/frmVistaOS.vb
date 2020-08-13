Imports entObraSocial
Public Class frmVistaOS
#Region "Campos"
    'Obra Social seleccionada
    Private _IdOS As Integer

    'Usuario actual
    Private _IdUsuAct As Integer
#End Region

#Region "Propiedades"
    Public Property IdOS As Integer
        Get
            Return _IdOS
        End Get
        Set(value As Integer)
            _IdOS = value
        End Set
    End Property

    Public Property IdUsuAct As Integer
        Get
            Return _IdUsuAct
        End Get
        Set(value As Integer)
            _IdUsuAct = value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmVistaOS_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Cambio el tamaño de la fuente del encabezado de las columnas
            dgvListadoOS.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 15, FontStyle.Bold)

            'Muestro los registros actuales en el DGV
            ActualizarDGV()

            'Cambio el titulo
            lblVistaOS.Text = Text

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
        Dim nuevaOS As New frmGestionOS

        'Le asigno las propiedades y lo muestro como objeto de dialogo
        With nuevaOS
            .Text = "ALTA DE OBRA SOCIAL"
            .TipoFormulario = frmGestionOS.TipoFormu.Nueva
            .IdUsuAct = IdUsuAct
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                'Actualizo el DGV
                ActualizarDGV()
            End If
        End With
    End Sub

    'Evento que se lanzara cuando se haga doble click en una celda del DGV
    Private Sub dgvListadoOS_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListadoOS.CellMouseDoubleClick
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Asigno el Id de la obra social seleccionada (el cual se encuentra en la primer columna)
            IdOS = dgvListadoOS.Rows(e.RowIndex).Cells(0).Value

            'Creo un objeto nuevo
            Dim nuevaOS As New frmGestionOS

            'Le asigno las propiedades y lo muestro como dialogo
            With nuevaOS
                .Text = "CONSULTA DE OBRA SOCIAL"
                .TipoFormulario = frmGestionOS.TipoFormu.Consulta
                .IdObraSoc = IdOS
                .IdUsuAct = IdUsuAct
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    'Actualizo el DGV
                    ActualizarDGV()
                End If
            End With
        End If
    End Sub

    'Evento que se lanza al completarse el enlazado de datos con el DGV
    Private Sub dgvListadoOS_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvListadoOS.DataBindingComplete
        'Limpio la primer fila seleccionada
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

#Region "Metodos"
    ''' <summary>
    ''' Metodo que sirve para consultar la base de datos y llenar el DGV con los registros encontrados
    ''' </summary>
    Public Sub ActualizarDGV()
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
    End Sub
#End Region
End Class