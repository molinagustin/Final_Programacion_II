Imports entHistoriaClinica
Imports entPaciente
Public Class frmHistoriasClinicas
#Region "Campos"
    'Tipos de formularios
    Public Enum TipoFormu
        Consulta
        Nuevo
    End Enum

    Private _TipoFormulario As TipoFormu
    'Guardo los datos del paciente
    Private _IdPacHC As Integer = -1
    Private _NombrePacHC As String
    'Guardo el Id de la historia clinicas para las consultas
    Private _IdHC As Integer

    'Usuario actual
    Private _IdUsuAct As Integer
#End Region

#Region "Propiedades"
    Public Property TipoFormulario As TipoFormu
        Get
            Return _TipoFormulario
        End Get
        Set(value As TipoFormu)
            _TipoFormulario = value
        End Set
    End Property

    Public Property IdPacHC As Integer
        Get
            Return _IdPacHC
        End Get
        Set(value As Integer)
            _IdPacHC = value
        End Set
    End Property

    Public Property NombrePacHC As String
        Get
            Return _NombrePacHC
        End Get
        Set(value As String)
            _NombrePacHC = value
        End Set
    End Property

    Public Property IdHC As Integer
        Get
            Return _IdHC
        End Get
        Set(value As Integer)
            _IdHC = value
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
    Private Sub frmHistoriasClinicas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Cambio el titulo segun el formulario
            lblHClinicas.Text = Text

            'Segun el tipo de formulario seran los controles a cargar
            If TipoFormulario = TipoFormu.Consulta Then
                btnGuardar.Visible = False
                dtpFechaHC.Enabled = False
                btnBuscarPac.Enabled = False
                rtbMotivoC.ReadOnly = True
                rtbDiagnostico.ReadOnly = True
                rtbTratamiento.ReadOnly = True
                'Los constroles de los datos adicionales
                txtPeso.ReadOnly = True
                txtAltura.ReadOnly = True
                txtPresionArterial.ReadOnly = True
                txtFrecuenciaCardiaca.ReadOnly = True
                txtFrecuenciaRespiratoria.ReadOnly = True
                rtbAnalitica.ReadOnly = True

                'Muestro el nombre del paciente de la HC
                Dim pacHC As New ePaciente
                pacHC.obtenerRegistro(IdPacHC, "Pacientes", "IdPaciente")
                txtPacienteHC.Text = pacHC.NombreCompleto

                'Traigo los datos de la HC consultada desde la BD
                Dim consultaHC As New eHistoriaClinica
                consultaHC.obtenerRegistro(IdHC)

                'Se lo asigno a los controles
                dtpFechaHC.Value = consultaHC.Fecha
                rtbMotivoC.Text = consultaHC.MotivoConsulta
                rtbDiagnostico.Text = consultaHC.Diagnostico
                rtbTratamiento.Text = consultaHC.Tratamiento
                txtPeso.Text = consultaHC.Peso
                txtAltura.Text = consultaHC.Altura
                txtPresionArterial.Text = consultaHC.PresionArterial
                txtFrecuenciaCardiaca.Text = consultaHC.FrecuenciaCard
                txtFrecuenciaRespiratoria.Text = consultaHC.FrecuenciaResp
                rtbAnalitica.Text = consultaHC.Analitica

            ElseIf TipoFormulario = TipoFormu.Nuevo Then
                'Deshabilito el boton
                btnNuevaHC.Visible = False

                'Muestro la necesidad de buscar un paciente
                txtPacienteHC.Text = "BUSCAR UNO"

                If IdPacHC > -1 Then
                    'Muestro el nombre del paciente de la HC
                    Dim pacHC As New ePaciente
                    pacHC.obtenerRegistro(IdPacHC, "Pacientes", "IdPaciente")
                    txtPacienteHC.Text = pacHC.NombreCompleto
                End If
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Cierro el formulario
        Close()
    End Sub

    Private Sub btnNuevaHC_Click(sender As Object, e As EventArgs) Handles btnNuevaHC.Click
        'Deshabilito y habilito los controles necesarios
        btnGuardar.Visible = True
        dtpFechaHC.Enabled = True
        btnBuscarPac.Enabled = True
        rtbMotivoC.ReadOnly = False
        rtbDiagnostico.ReadOnly = False
        rtbTratamiento.ReadOnly = False
        btnNuevaHC.Visible = False
        'Habilito los controles adicionales
        txtPeso.ReadOnly = False
        txtAltura.ReadOnly = False
        txtPresionArterial.ReadOnly = False
        txtFrecuenciaCardiaca.ReadOnly = False
        txtFrecuenciaRespiratoria.ReadOnly = False
        rtbAnalitica.ReadOnly = False

        Text = "NUEVA VISITA"
        lblHClinicas.Text = "NUEVA VISITA"

        'Utilizo el metodo para limpiar el contenido de los controles usados
        LimpiarControles()
    End Sub

    Private Sub btnBuscarPac_Click(sender As Object, e As EventArgs) Handles btnBuscarPac.Click
        'Creo un nuevo objeto y lo muestro como dialogo para buscar al paciente
        Dim paciente As New frmDialogoPac

        With paciente
            .Text = "LISTADO DE PACIENTES"
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                'Guardo el nombre e Id del paciente seleccionado
                IdPacHC = .IdPaci
                NombrePacHC = .NombrePaci
                'Lo muestro en el textbox
                txtPacienteHC.Text = NombrePacHC
            End If
        End With
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            'Hago comprobaciones
            If Not dtpFechaHC.Value.Date > Today.Date Then
                If Not txtPacienteHC.Text = "BUSCAR UNO" Then
                    'Creo un nuevo objeto y le asigno el resultado del MessageBox creado
                    Dim resultado As DialogResult = MessageBox.Show("¿DAR DE ALTA LA HISTORIA CLINICA CREADA? - NO SE PODRAN REALIZAR FUTURAS MODIFICACIONES", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                    'Si se confirma la accion, se da de alta el registro
                    If resultado = DialogResult.Yes Then
                        'Creo un nuevo objeto
                        Dim nuevaHC As New eHistoriaClinica

                        'Le asigno el contenido de los controles
                        With nuevaHC
                            .Fecha = dtpFechaHC.Value.Date
                            .Paciente = IdPacHC
                            .MotivoConsulta = rtbMotivoC.Text
                            .Diagnostico = rtbDiagnostico.Text
                            .Tratamiento = rtbTratamiento.Text
                            .Peso = txtPeso.Text
                            .Altura = txtAltura.Text
                            .PresionArterial = txtPresionArterial.Text
                            .FrecuenciaCard = txtFrecuenciaCardiaca.Text
                            .FrecuenciaResp = txtFrecuenciaRespiratoria.Text
                            .Analitica = rtbAnalitica.Text
                            .IdUsuario = IdUsuAct
                        End With

                        'Llamo al metodo para agregar el registro y le paso el objeto con los datos
                        nuevaHC.insertarRegistro(nuevaHC)

                        'Deshabilito y habilito los controles necesarios
                        btnGuardar.Visible = False
                        dtpFechaHC.Enabled = False
                        btnBuscarPac.Enabled = False
                        rtbMotivoC.ReadOnly = True
                        rtbDiagnostico.ReadOnly = True
                        rtbTratamiento.ReadOnly = True
                        btnNuevaHC.Visible = True
                        'Habilito los controles adicionales
                        txtPeso.ReadOnly = True
                        txtAltura.ReadOnly = True
                        txtPresionArterial.ReadOnly = True
                        txtFrecuenciaCardiaca.ReadOnly = True
                        txtFrecuenciaRespiratoria.ReadOnly = True
                        rtbAnalitica.ReadOnly = True

                        'Utilizo el metodo para limpiar el contenido de los controles usados
                        LimpiarControles()

                        'Confirmo el formulario
                        DialogResult = DialogResult.OK

                    End If
                Else
                    Throw New Exception("Debe buscar un paciente al cual asignarle la historia clinica")
                End If
            Else
                Throw New Exception("La Fecha no puede ser mayor a la actual")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Historias Clinicas")
        End Try
    End Sub

    Private Sub txtPeso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeso.KeyPress
        CaracterNoNumerico(e)
    End Sub

    Private Sub txtAltura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAltura.KeyPress
        CaracterNoNumerico(e)
    End Sub

    Private Sub txtPresionArterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPresionArterial.KeyPress
        CaracterNoNumerico(e)
    End Sub

    Private Sub txtFrecuenciaCardiaca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFrecuenciaCardiaca.KeyPress
        CaracterNoNumerico(e)
    End Sub

    Private Sub txtFrecuenciaRespiratoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFrecuenciaRespiratoria.KeyPress
        CaracterNoNumerico(e)
    End Sub
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Metodo que permite borrar el contenido de los controles usados
    ''' </summary>
    Public Sub LimpiarControles()
        dtpFechaHC.Value = Now
        rtbMotivoC.Text = ""
        rtbDiagnostico.Text = ""
        rtbTratamiento.Text = ""
        txtPeso.Text = ""
        txtAltura.Text = ""
        txtPresionArterial.Text = ""
        txtFrecuenciaCardiaca.Text = ""
        txtFrecuenciaRespiratoria.Text = ""
        rtbAnalitica.Text = ""
    End Sub

    ''' <summary>
    ''' Metodo que captura un caracter no numerico ingresado y no deja mostrarlo
    ''' </summary>
    ''' <param name="e"></param>
    Public Sub CaracterNoNumerico(e As KeyPressEventArgs)
        'Pregunto si es numerico el valor de la tecla presionada o si corresponde al Codigo ASCII 8 "retroceso ", de ser asi muestro el valor en el control. Caso contrario no dejo que el valor tecleado se muestre
        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = Chr(44) Or e.KeyChar = Chr(46) Then
            'El handled me indica que tomara lo que tecleamos y si es false lo dejara pasar, pero si es True lo toma y no me lo muestra
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
#End Region
End Class