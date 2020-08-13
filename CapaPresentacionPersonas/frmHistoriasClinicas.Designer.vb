<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistoriasClinicas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistoriasClinicas))
        Me.lblHClinicas = New System.Windows.Forms.Label()
        Me.lblPaciente = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblMotivoC = New System.Windows.Forms.Label()
        Me.lblDiagnostico = New System.Windows.Forms.Label()
        Me.lblTratamiento = New System.Windows.Forms.Label()
        Me.dtpFechaHC = New System.Windows.Forms.DateTimePicker()
        Me.txtPacienteHC = New System.Windows.Forms.TextBox()
        Me.btnBuscarPac = New System.Windows.Forms.Button()
        Me.rtbMotivoC = New System.Windows.Forms.RichTextBox()
        Me.rtbDiagnostico = New System.Windows.Forms.RichTextBox()
        Me.rtbTratamiento = New System.Windows.Forms.RichTextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevaHC = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.lblKg = New System.Windows.Forms.Label()
        Me.lblCm = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.lblAltura = New System.Windows.Forms.Label()
        Me.lblmmHg = New System.Windows.Forms.Label()
        Me.txtPresionArterial = New System.Windows.Forms.TextBox()
        Me.lblPresionArterial = New System.Windows.Forms.Label()
        Me.lblLatXMin = New System.Windows.Forms.Label()
        Me.txtFrecuenciaCardiaca = New System.Windows.Forms.TextBox()
        Me.lblFrecuenciaCardiaca = New System.Windows.Forms.Label()
        Me.lblRespXMin = New System.Windows.Forms.Label()
        Me.txtFrecuenciaRespiratoria = New System.Windows.Forms.TextBox()
        Me.lblFrecuenciaRespi = New System.Windows.Forms.Label()
        Me.lblAnalitica = New System.Windows.Forms.Label()
        Me.rtbAnalitica = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'lblHClinicas
        '
        Me.lblHClinicas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHClinicas.BackColor = System.Drawing.Color.Transparent
        Me.lblHClinicas.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHClinicas.Location = New System.Drawing.Point(12, 9)
        Me.lblHClinicas.MinimumSize = New System.Drawing.Size(450, 33)
        Me.lblHClinicas.Name = "lblHClinicas"
        Me.lblHClinicas.Size = New System.Drawing.Size(1320, 33)
        Me.lblHClinicas.TabIndex = 0
        Me.lblHClinicas.Text = "VISITAS"
        Me.lblHClinicas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPaciente
        '
        Me.lblPaciente.AutoSize = True
        Me.lblPaciente.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaciente.Location = New System.Drawing.Point(55, 175)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(72, 19)
        Me.lblPaciente.TabIndex = 1
        Me.lblPaciente.Text = "PACIENTE"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(55, 122)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(52, 19)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "FECHA"
        '
        'lblMotivoC
        '
        Me.lblMotivoC.AutoSize = True
        Me.lblMotivoC.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotivoC.Location = New System.Drawing.Point(55, 242)
        Me.lblMotivoC.Name = "lblMotivoC"
        Me.lblMotivoC.Size = New System.Drawing.Size(138, 19)
        Me.lblMotivoC.TabIndex = 3
        Me.lblMotivoC.Text = "MOTIVO CONSULTA"
        '
        'lblDiagnostico
        '
        Me.lblDiagnostico.AutoSize = True
        Me.lblDiagnostico.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiagnostico.Location = New System.Drawing.Point(55, 355)
        Me.lblDiagnostico.Name = "lblDiagnostico"
        Me.lblDiagnostico.Size = New System.Drawing.Size(102, 19)
        Me.lblDiagnostico.TabIndex = 4
        Me.lblDiagnostico.Text = "DIAGNOSTICO"
        '
        'lblTratamiento
        '
        Me.lblTratamiento.AutoSize = True
        Me.lblTratamiento.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTratamiento.Location = New System.Drawing.Point(53, 468)
        Me.lblTratamiento.Name = "lblTratamiento"
        Me.lblTratamiento.Size = New System.Drawing.Size(104, 19)
        Me.lblTratamiento.TabIndex = 5
        Me.lblTratamiento.Text = "TRATAMIENTO"
        '
        'dtpFechaHC
        '
        Me.dtpFechaHC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFechaHC.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaHC.Location = New System.Drawing.Point(237, 116)
        Me.dtpFechaHC.Name = "dtpFechaHC"
        Me.dtpFechaHC.Size = New System.Drawing.Size(282, 27)
        Me.dtpFechaHC.TabIndex = 1
        '
        'txtPacienteHC
        '
        Me.txtPacienteHC.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtPacienteHC.Location = New System.Drawing.Point(237, 172)
        Me.txtPacienteHC.Name = "txtPacienteHC"
        Me.txtPacienteHC.ReadOnly = True
        Me.txtPacienteHC.Size = New System.Drawing.Size(319, 27)
        Me.txtPacienteHC.TabIndex = 99
        Me.txtPacienteHC.Text = "BUSCAR UNO"
        Me.txtPacienteHC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscarPac
        '
        Me.btnBuscarPac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarPac.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.search
        Me.btnBuscarPac.Location = New System.Drawing.Point(562, 167)
        Me.btnBuscarPac.Name = "btnBuscarPac"
        Me.btnBuscarPac.Size = New System.Drawing.Size(40, 37)
        Me.btnBuscarPac.TabIndex = 2
        Me.btnBuscarPac.UseVisualStyleBackColor = True
        '
        'rtbMotivoC
        '
        Me.rtbMotivoC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbMotivoC.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.rtbMotivoC.Location = New System.Drawing.Point(237, 239)
        Me.rtbMotivoC.Name = "rtbMotivoC"
        Me.rtbMotivoC.Size = New System.Drawing.Size(585, 96)
        Me.rtbMotivoC.TabIndex = 3
        Me.rtbMotivoC.Text = ""
        '
        'rtbDiagnostico
        '
        Me.rtbDiagnostico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbDiagnostico.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.rtbDiagnostico.Location = New System.Drawing.Point(237, 352)
        Me.rtbDiagnostico.Name = "rtbDiagnostico"
        Me.rtbDiagnostico.Size = New System.Drawing.Size(585, 96)
        Me.rtbDiagnostico.TabIndex = 4
        Me.rtbDiagnostico.Text = ""
        '
        'rtbTratamiento
        '
        Me.rtbTratamiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbTratamiento.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.rtbTratamiento.Location = New System.Drawing.Point(237, 465)
        Me.rtbTratamiento.Name = "rtbTratamiento"
        Me.rtbTratamiento.Size = New System.Drawing.Size(585, 96)
        Me.rtbTratamiento.TabIndex = 5
        Me.rtbTratamiento.Text = ""
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnSalir.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.back
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(1084, 641)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(116, 39)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "    SALIR"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnNuevaHC
        '
        Me.btnNuevaHC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevaHC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevaHC.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnNuevaHC.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.edit2
        Me.btnNuevaHC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevaHC.Location = New System.Drawing.Point(879, 637)
        Me.btnNuevaHC.Name = "btnNuevaHC"
        Me.btnNuevaHC.Size = New System.Drawing.Size(139, 47)
        Me.btnNuevaHC.TabIndex = 13
        Me.btnNuevaHC.Text = "  NUEVA H.C."
        Me.btnNuevaHC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevaHC.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnGuardar.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.ok
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(879, 637)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(139, 47)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "   GUARDAR"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblPeso
        '
        Me.lblPeso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeso.Location = New System.Drawing.Point(914, 191)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(43, 19)
        Me.lblPeso.TabIndex = 18
        Me.lblPeso.Text = "PESO"
        '
        'txtPeso
        '
        Me.txtPeso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPeso.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtPeso.Location = New System.Drawing.Point(1023, 188)
        Me.txtPeso.MaxLength = 7
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(67, 27)
        Me.txtPeso.TabIndex = 6
        '
        'lblKg
        '
        Me.lblKg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKg.AutoSize = True
        Me.lblKg.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKg.Location = New System.Drawing.Point(1096, 191)
        Me.lblKg.Name = "lblKg"
        Me.lblKg.Size = New System.Drawing.Size(25, 19)
        Me.lblKg.TabIndex = 20
        Me.lblKg.Text = "Kg"
        '
        'lblCm
        '
        Me.lblCm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCm.AutoSize = True
        Me.lblCm.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCm.Location = New System.Drawing.Point(1096, 235)
        Me.lblCm.Name = "lblCm"
        Me.lblCm.Size = New System.Drawing.Size(28, 19)
        Me.lblCm.TabIndex = 23
        Me.lblCm.Text = "cm"
        '
        'txtAltura
        '
        Me.txtAltura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAltura.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtAltura.Location = New System.Drawing.Point(1023, 232)
        Me.txtAltura.MaxLength = 7
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(67, 27)
        Me.txtAltura.TabIndex = 7
        '
        'lblAltura
        '
        Me.lblAltura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAltura.AutoSize = True
        Me.lblAltura.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltura.Location = New System.Drawing.Point(914, 235)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(60, 19)
        Me.lblAltura.TabIndex = 21
        Me.lblAltura.Text = "ALTURA"
        '
        'lblmmHg
        '
        Me.lblmmHg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblmmHg.AutoSize = True
        Me.lblmmHg.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmmHg.Location = New System.Drawing.Point(1096, 285)
        Me.lblmmHg.Name = "lblmmHg"
        Me.lblmmHg.Size = New System.Drawing.Size(51, 19)
        Me.lblmmHg.TabIndex = 26
        Me.lblmmHg.Text = "mmHg"
        '
        'txtPresionArterial
        '
        Me.txtPresionArterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPresionArterial.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtPresionArterial.Location = New System.Drawing.Point(1023, 282)
        Me.txtPresionArterial.MaxLength = 7
        Me.txtPresionArterial.Name = "txtPresionArterial"
        Me.txtPresionArterial.Size = New System.Drawing.Size(67, 27)
        Me.txtPresionArterial.TabIndex = 8
        '
        'lblPresionArterial
        '
        Me.lblPresionArterial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPresionArterial.AutoSize = True
        Me.lblPresionArterial.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresionArterial.Location = New System.Drawing.Point(914, 279)
        Me.lblPresionArterial.Name = "lblPresionArterial"
        Me.lblPresionArterial.Size = New System.Drawing.Size(72, 38)
        Me.lblPresionArterial.TabIndex = 24
        Me.lblPresionArterial.Text = "PRESION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ARTERIAL"
        '
        'lblLatXMin
        '
        Me.lblLatXMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLatXMin.AutoSize = True
        Me.lblLatXMin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLatXMin.Location = New System.Drawing.Point(1096, 350)
        Me.lblLatXMin.Name = "lblLatXMin"
        Me.lblLatXMin.Size = New System.Drawing.Size(56, 19)
        Me.lblLatXMin.TabIndex = 29
        Me.lblLatXMin.Text = "lat/min"
        '
        'txtFrecuenciaCardiaca
        '
        Me.txtFrecuenciaCardiaca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFrecuenciaCardiaca.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtFrecuenciaCardiaca.Location = New System.Drawing.Point(1023, 347)
        Me.txtFrecuenciaCardiaca.MaxLength = 7
        Me.txtFrecuenciaCardiaca.Name = "txtFrecuenciaCardiaca"
        Me.txtFrecuenciaCardiaca.Size = New System.Drawing.Size(67, 27)
        Me.txtFrecuenciaCardiaca.TabIndex = 9
        '
        'lblFrecuenciaCardiaca
        '
        Me.lblFrecuenciaCardiaca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFrecuenciaCardiaca.AutoSize = True
        Me.lblFrecuenciaCardiaca.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrecuenciaCardiaca.Location = New System.Drawing.Point(914, 342)
        Me.lblFrecuenciaCardiaca.Name = "lblFrecuenciaCardiaca"
        Me.lblFrecuenciaCardiaca.Size = New System.Drawing.Size(92, 38)
        Me.lblFrecuenciaCardiaca.TabIndex = 27
        Me.lblFrecuenciaCardiaca.Text = "FRECUENCIA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CARDIACA"
        '
        'lblRespXMin
        '
        Me.lblRespXMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRespXMin.AutoSize = True
        Me.lblRespXMin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespXMin.Location = New System.Drawing.Point(1096, 413)
        Me.lblRespXMin.Name = "lblRespXMin"
        Me.lblRespXMin.Size = New System.Drawing.Size(67, 19)
        Me.lblRespXMin.TabIndex = 32
        Me.lblRespXMin.Text = "resp/min"
        '
        'txtFrecuenciaRespiratoria
        '
        Me.txtFrecuenciaRespiratoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFrecuenciaRespiratoria.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtFrecuenciaRespiratoria.Location = New System.Drawing.Point(1023, 410)
        Me.txtFrecuenciaRespiratoria.MaxLength = 7
        Me.txtFrecuenciaRespiratoria.Name = "txtFrecuenciaRespiratoria"
        Me.txtFrecuenciaRespiratoria.Size = New System.Drawing.Size(67, 27)
        Me.txtFrecuenciaRespiratoria.TabIndex = 10
        '
        'lblFrecuenciaRespi
        '
        Me.lblFrecuenciaRespi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFrecuenciaRespi.AutoSize = True
        Me.lblFrecuenciaRespi.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrecuenciaRespi.Location = New System.Drawing.Point(914, 405)
        Me.lblFrecuenciaRespi.Name = "lblFrecuenciaRespi"
        Me.lblFrecuenciaRespi.Size = New System.Drawing.Size(103, 38)
        Me.lblFrecuenciaRespi.TabIndex = 30
        Me.lblFrecuenciaRespi.Text = "FRECUENCIA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RESPIRATORIA"
        '
        'lblAnalitica
        '
        Me.lblAnalitica.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAnalitica.AutoSize = True
        Me.lblAnalitica.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnalitica.Location = New System.Drawing.Point(914, 468)
        Me.lblAnalitica.Name = "lblAnalitica"
        Me.lblAnalitica.Size = New System.Drawing.Size(78, 19)
        Me.lblAnalitica.TabIndex = 33
        Me.lblAnalitica.Text = "ANALITICA"
        '
        'rtbAnalitica
        '
        Me.rtbAnalitica.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbAnalitica.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.rtbAnalitica.Location = New System.Drawing.Point(1023, 465)
        Me.rtbAnalitica.Name = "rtbAnalitica"
        Me.rtbAnalitica.Size = New System.Drawing.Size(306, 96)
        Me.rtbAnalitica.TabIndex = 11
        Me.rtbAnalitica.Text = ""
        '
        'frmHistoriasClinicas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1344, 731)
        Me.ControlBox = False
        Me.Controls.Add(Me.rtbAnalitica)
        Me.Controls.Add(Me.lblAnalitica)
        Me.Controls.Add(Me.lblRespXMin)
        Me.Controls.Add(Me.txtFrecuenciaRespiratoria)
        Me.Controls.Add(Me.lblFrecuenciaRespi)
        Me.Controls.Add(Me.lblLatXMin)
        Me.Controls.Add(Me.txtFrecuenciaCardiaca)
        Me.Controls.Add(Me.lblFrecuenciaCardiaca)
        Me.Controls.Add(Me.lblmmHg)
        Me.Controls.Add(Me.txtPresionArterial)
        Me.Controls.Add(Me.lblPresionArterial)
        Me.Controls.Add(Me.lblCm)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.lblAltura)
        Me.Controls.Add(Me.lblKg)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevaHC)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.rtbTratamiento)
        Me.Controls.Add(Me.rtbDiagnostico)
        Me.Controls.Add(Me.rtbMotivoC)
        Me.Controls.Add(Me.btnBuscarPac)
        Me.Controls.Add(Me.txtPacienteHC)
        Me.Controls.Add(Me.dtpFechaHC)
        Me.Controls.Add(Me.lblTratamiento)
        Me.Controls.Add(Me.lblDiagnostico)
        Me.Controls.Add(Me.lblMotivoC)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblPaciente)
        Me.Controls.Add(Me.lblHClinicas)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1360, 747)
        Me.Name = "frmHistoriasClinicas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VISITAS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHClinicas As Label
    Friend WithEvents lblPaciente As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblMotivoC As Label
    Friend WithEvents lblDiagnostico As Label
    Friend WithEvents lblTratamiento As Label
    Friend WithEvents dtpFechaHC As DateTimePicker
    Friend WithEvents txtPacienteHC As TextBox
    Friend WithEvents btnBuscarPac As Button
    Friend WithEvents rtbMotivoC As RichTextBox
    Friend WithEvents rtbDiagnostico As RichTextBox
    Friend WithEvents rtbTratamiento As RichTextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevaHC As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblPeso As Label
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents lblKg As Label
    Friend WithEvents lblCm As Label
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents lblAltura As Label
    Friend WithEvents lblmmHg As Label
    Friend WithEvents txtPresionArterial As TextBox
    Friend WithEvents lblPresionArterial As Label
    Friend WithEvents lblLatXMin As Label
    Friend WithEvents txtFrecuenciaCardiaca As TextBox
    Friend WithEvents lblFrecuenciaCardiaca As Label
    Friend WithEvents lblRespXMin As Label
    Friend WithEvents txtFrecuenciaRespiratoria As TextBox
    Friend WithEvents lblFrecuenciaRespi As Label
    Friend WithEvents lblAnalitica As Label
    Friend WithEvents rtbAnalitica As RichTextBox
End Class
