Imports entUsuario
Public Class frmVistaUsuarios
#Region "Campos"
    'Query para la consulta
    Dim query As String = "SELECT * FROM Usuarios INNER JOIN Privilegios ON Usuarios.IdPrivilegio = Privilegios.IdPrivilegio"

    'Usuario seleccionado
    Private _IdUsua As Integer = -1

    'Usuario actual
    Private _IdUsuAct As Integer
#End Region

#Region "Propiedades"
    Public Property IdUsua As Integer
        Get
            Return _IdUsua
        End Get
        Set(value As Integer)
            _IdUsua = value
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
    Private Sub frmVistaUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Cambio el tamaño de la fuente del encabezado de las columnas
            dgvListadoUsuarios.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 15, FontStyle.Bold)

            'Muestro los registros actuales en el DGV
            ActualizarDGV()

            'Cambio el titulo segun el formulario
            lblVistaUsuarios.Text = Text

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
        Dim nuevoUsu As New frmGestionUsuarios

        'Le asigno las propiedades y lo muestro como objeto de dialogo
        With nuevoUsu
            .Text = "ALTA DE USUARIO"
            .TipoFormulario = frmGestionUsuarios.TipoFormu.Nuevo
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                'Actualizo el DGV
                ActualizarDGV()
            End If
        End With
    End Sub

    'Evento que se lanzara cuando se haga doble click en una celda del DGV
    Private Sub dgvListadoUsuarios_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListadoUsuarios.CellMouseDoubleClick
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Asigno el Id del usuario seleccionado (el cual se encuentra en la primer columna)
            IdUsua = dgvListadoUsuarios.Rows(e.RowIndex).Cells(0).Value

            'Creo un objeto nuevo
            Dim nuevoUsu As New frmGestionUsuarios

            'Le asigno las propiedades y lo muestro como dialogo
            With nuevoUsu
                .Text = "CONSULTA DE USUARIO"
                .TipoFormulario = frmGestionUsuarios.TipoFormu.Consulta
                .IdUs = IdUsua
                .IdUsuAct = IdUsuAct 'Usuario actual
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    'Actualizo el DGV
                    ActualizarDGV()
                End If
            End With
        End If
    End Sub

    'Evento que se lanza al completarse el enlazado de datos
    Private Sub dgvListadoUsuarios_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvListadoUsuarios.DataBindingComplete
        'Limpio la seleccion actual
        dgvListadoUsuarios.ClearSelection()
    End Sub

    'Evento que se lanza al entrar el mouse a una celda
    Private Sub dgvListadoUsuarios_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoUsuarios.CellMouseEnter
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Cambio el back color de la fila
            dgvListadoUsuarios.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aqua
        End If
    End Sub

    'Evento que se lanza al salir el mouse de una celda
    Private Sub dgvListadoUsuarios_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoUsuarios.CellMouseLeave
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Cambio el back color de la fila
            dgvListadoUsuarios.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        End If
    End Sub
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Metodo que sirve para consultar la base de datos y llenar el DGV con los registros encontrados
    ''' </summary>
    Public Sub ActualizarDGV()
        'Creo nuevos objetos y vuelvo a llenar una tabla para mostrar el registro que fue agregado
        Dim usuarios As New eUsuario
        Dim tablaUsu As New DataTable
        'Lleno la tabla
        usuarios.obtenerRegistros(tablaUsu, query)

        'Se la asigno al DGV asi lo actualizo
        dgvListadoUsuarios.DataSource = tablaUsu
        'Ordeno el DGV por nombre
        dgvListadoUsuarios.Sort(dgvListadoUsuarios.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        'Limpio la seleccion actual
        dgvListadoUsuarios.ClearSelection()
    End Sub
#End Region
End Class
