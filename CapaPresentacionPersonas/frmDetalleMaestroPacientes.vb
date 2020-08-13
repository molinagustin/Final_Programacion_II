Imports entHistoriaClinica
Imports entPaciente
Public Class frmDetalleMaestroPacientes
#Region "Campos"
    'Creo un binding source para cada DGV y asi guardar los datos de cada tabla
    Dim binPac, binHist As New BindingSource

    'Guardo el Id del paciente (con su nombre) y la historia clinica seleccionada
    Dim _IdPacien As Integer = -1
    Dim _IdHist As Integer = -1

    'Usuario actual
    Private _IdUsuAct As Integer
#End Region

#Region "Propiedades"
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
    Private Sub frmDetalleMaestroPacientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Cargo el contenido de los 2 DGV
        ActualizarDGVPac()
        ActualizarDGVHC()

        'Cambio el tamaño de la fuente del encabezado de las columnas
        dgvListadoPacientes.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 15, FontStyle.Bold)
        dgvHCPaciente.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 15, FontStyle.Bold)
    End Sub

    Private Sub dgvListadoPacientes_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListadoPacientes.CellMouseClick
        'Si el DGV tiene mas de una celda, entra al comparador
        If e.RowIndex > -1 Then
            'Guardo el Id del paciente seleccionado
            _IdPacien = dgvListadoPacientes.Rows(e.RowIndex).Cells(0).Value

            'Filtro el contenido del binding source de las historias clinicas por el ID del paciente seleccionado
            binHist.Filter = "Paciente = " & _IdPacien
        End If
    End Sub

    Private Sub txtBuscador_TextChanged(sender As Object, e As EventArgs) Handles txtBuscador.TextChanged
        'Realizo un filtro en el contenido del dataBin y es lo que mostrara en pantalla sobre el DGV
        binPac.Filter = "NombreCompleto LIKE '%" & txtBuscador.Text & "%' OR NumeroDocumento LIKE '" & txtBuscador.Text & "%'"
    End Sub

    'Evento que se lanza al realizar doble click sobre un registro
    Private Sub dgvListadoPacientes_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListadoPacientes.CellMouseDoubleClick
        'Si el DGV tiene mas de una celda, entra al comparador
        If e.RowIndex > -1 Then
            'Guardo el Id del paciente seleccionado
            _IdPacien = dgvListadoPacientes.Rows(e.RowIndex).Cells(0).Value

            'Creo un nuevo objeto del tipo historias clinicas
            Dim nuevaHC As New frmHistoriasClinicas
            'Configuro sus propiedades y lo muestro
            With nuevaHC
                .Text = "NUEVA VISITA"
                .TipoFormulario = frmHistoriasClinicas.TipoFormu.Nuevo
                .IdUsuAct = IdUsuAct
                .IdPacHC = _IdPacien
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    'Actualizo las HC
                    ActualizarDGVHC()
                End If
            End With
        End If
    End Sub

    'Evento que se lanza al realizar doble click sobre un registro
    Private Sub dgvHCPaciente_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvHCPaciente.CellMouseDoubleClick
        'Si el DGV tiene mas de una celda, entra al comparador
        If e.RowIndex > -1 Then
            'Guardo el Id de la HC y el paciente
            _IdHist = dgvHCPaciente.Rows(e.RowIndex).Cells(0).Value
            _IdPacien = dgvHCPaciente.Rows(e.RowIndex).Cells(2).Value

            'Creo un nuevo objeto del tipo historias clinicas
            Dim consultaHC As New frmHistoriasClinicas
            'Configuro sus propiedades y lo muestro
            With consultaHC
                .Text = "CONSULTA DE VISITA"
                .TipoFormulario = frmHistoriasClinicas.TipoFormu.Consulta
                .IdUsuAct = IdUsuAct
                .IdHC = _IdHist
                .IdPacHC = _IdPacien
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    'Actualizo las HC
                    ActualizarDGVHC()
                End If
            End With
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Cierro el formulario
        Close()
    End Sub

    'Evento que se lanza al terminarse el enlace de datos
    Private Sub dgvListadoPacientes_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvListadoPacientes.DataBindingComplete
        'Limpio la seleccion actual
        dgvListadoPacientes.ClearSelection()
    End Sub

    'Evento que se lanza al terminarse el enlace de datos
    Private Sub dgvHCPaciente_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvHCPaciente.DataBindingComplete
        'Limpio la seleccion actual
        dgvHCPaciente.ClearSelection()
    End Sub

    'Evento que se lanza la entrar en una celda
    Private Sub dgvListadoPacientes_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoPacientes.CellMouseEnter
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Cambio el back color de la fila
            dgvListadoPacientes.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aqua
        End If
    End Sub

    'Evento que se lanza al salir de una celda
    Private Sub dgvListadoPacientes_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoPacientes.CellMouseLeave
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Cambio el back color de la fila
            dgvListadoPacientes.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        End If
    End Sub

    'Evento que se lanza la entrar en una celda
    Private Sub dgvHCPaciente_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHCPaciente.CellMouseEnter
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Cambio el back color de la fila
            dgvHCPaciente.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aqua
        End If
    End Sub

    'Evento que se lanza al salir de una celda
    Private Sub dgvHCPaciente_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHCPaciente.CellMouseLeave
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Cambio el back color de la fila
            dgvHCPaciente.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        End If
    End Sub
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Metodo que sirve para actualizar el DGV de HC
    ''' </summary>
    Public Sub ActualizarDGVHC()
        'Creo objetos de las historias clinicas y una tabla para guardar datos
        Dim hist As New eHistoriaClinica
        Dim tablaHist As New DataTable

        'Obtengo los datos de todas las historias clinicas y se las asigno al binding source
        hist.obtenerTodosRegistros(tablaHist)
        binHist.DataSource = tablaHist

        'Le paso como fuente de datos al DGV el binding source
        dgvHCPaciente.DataSource = binHist

        'Ordeno el DGV por fecha
        dgvHCPaciente.Sort(dgvHCPaciente.Columns(1), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    ''' <summary>
    '''Metodo que sirve para actualizar el DGV de pacientes
    ''' </summary>
    Public Sub ActualizarDGVPac()
        'Creo objetos del paciente y una tabla para guardar datos
        Dim pac As New ePaciente
        Dim tablaPac As New DataTable

        'Obtengo los datos de todos los pacientes y se los asigno al binding source
        pac.obtenerRegistros(tablaPac, "SELECT * FROM Pacientes INNER JOIN ObrasSociales ON Pacientes.ObraSocial = ObrasSociales.IdObraSocial  WHERE Pacientes.Activo = 1")
        binPac.DataSource = tablaPac

        'Le paso como fuente de datos al DGV el binding source
        dgvListadoPacientes.DataSource = binPac

        'Ordeno el DGV por nombre
        dgvListadoPacientes.Sort(dgvListadoPacientes.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
#End Region
End Class