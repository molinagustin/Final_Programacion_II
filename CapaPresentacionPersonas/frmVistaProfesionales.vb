Imports entProfesionales
Public Class frmVistaProfesionales
#Region "Campos"
    'Query para la consulta a la BD
    Dim query As String = "SELECT * FROM Profesionales WHERE Profesionales.Activo = 1"

    Private _IdProf As Integer
    Private _IdLocalidadProf As Integer
    Private _NombreProf As String 'Para las Historias Clinicas y Turnos

    'Usuario actual
    Private _IdUsuAct As Integer
#End Region

#Region "Propiedades"
    Public Property IdProf As Integer
        Get
            Return _IdProf
        End Get
        Set(value As Integer)
            _IdProf = value
        End Set
    End Property

    Public Property IdLocalidadProf As Integer
        Get
            Return _IdLocalidadProf
        End Get
        Set(value As Integer)
            _IdLocalidadProf = value
        End Set
    End Property

    Public Property NombreProf As String
        Get
            Return _NombreProf
        End Get
        Set(value As String)
            _NombreProf = value
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
    Private Sub frmVistaProfesionales_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Cambio el titulo segun el formulario
            lblVistaProfes.Text = Text

            'Cambio el tamaño de la fuente del encabezado de las columnas
            dgvListadoProfesionales.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 15, FontStyle.Bold)

            'Muestro los registros actuales en el DGV
            ActualizarDGV()

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
        Dim nuevoProf As New frmPersona

        'Le asigno las propiedades y lo muestro como dialogo
        With nuevoProf
            .Text = "ALTA DE PROFESIONAL"
            .TipoFormulario = frmPersona.TipoFormu.NProfesional
            .IdUsuAct = IdUsuAct
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                'Actualizo el DGV
                ActualizarDGV()
            End If
        End With
    End Sub

    'Evento que se lanzara cuando se haga doble click en una celda del DGV
    Private Sub dgvListadoProfesionales_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListadoProfesionales.CellMouseDoubleClick
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Asigno el Id del profesional seleccionado (el cual se encuentra en la primer columna)
            IdProf = dgvListadoProfesionales.Rows(e.RowIndex).Cells(0).Value
            'Asigno el id de la localidad del profesional para mostrarla en modificaciones
            IdLocalidadProf = dgvListadoProfesionales.Rows(e.RowIndex).Cells(7).Value

            'Creo un objeto nuevo
            Dim nuevoProf As New frmPersona

            'Le asigno las propiedades y lo muestro como dialogo
            With nuevoProf
                .Text = "CONSULTA DE PROFESIONAL"
                .TipoFormulario = frmPersona.TipoFormu.CProfesional
                .IdUsuAct = IdUsuAct
                .IdProfesional = IdProf
                .IdLoca = IdLocalidadProf
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    'Actualizo el DGV
                    ActualizarDGV()
                End If
            End With
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