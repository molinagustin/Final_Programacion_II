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
        Me.btnBuscarHC = New System.Windows.Forms.Button()
        Me.btnNuevaHC = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHClinicas
        '
        Me.lblHClinicas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHClinicas.AutoSize = True
        Me.lblHClinicas.BackColor = System.Drawing.Color.Transparent
        Me.lblHClinicas.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.lblHClinicas.Location = New System.Drawing.Point(487, 44)
        Me.lblHClinicas.Name = "lblHClinicas"
        Me.lblHClinicas.Size = New System.Drawing.Size(235, 33)
        Me.lblHClinicas.TabIndex = 0
        Me.lblHClinicas.Text = "HISTORIAS CLINICAS"
        Me.lblHClinicas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPaciente
        '
        Me.lblPaciente.AutoSize = True
        Me.lblPaciente.Location = New System.Drawing.Point(55, 178)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(63, 17)
        Me.lblPaciente.TabIndex = 1
        Me.lblPaciente.Text = "PACIENTE"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(55, 123)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(45, 17)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "FECHA"
        '
        'lblMotivoC
        '
        Me.lblMotivoC.AutoSize = True
        Me.lblMotivoC.Location = New System.Drawing.Point(55, 242)
        Me.lblMotivoC.Name = "lblMotivoC"
        Me.lblMotivoC.Size = New System.Drawing.Size(119, 17)
        Me.lblMotivoC.TabIndex = 3
        Me.lblMotivoC.Text = "MOTIVO CONSULTA"
        '
        'lblDiagnostico
        '
        Me.lblDiagnostico.AutoSize = True
        Me.lblDiagnostico.Location = New System.Drawing.Point(55, 355)
        Me.lblDiagnostico.Name = "lblDiagnostico"
        Me.lblDiagnostico.Size = New System.Drawing.Size(89, 17)
        Me.lblDiagnostico.TabIndex = 4
        Me.lblDiagnostico.Text = "DIAGNOSTICO"
        '
        'lblTratamiento
        '
        Me.lblTratamiento.AutoSize = True
        Me.lblTratamiento.Location = New System.Drawing.Point(55, 468)
        Me.lblTratamiento.Name = "lblTratamiento"
        Me.lblTratamiento.Size = New System.Drawing.Size(92, 17)
        Me.lblTratamiento.TabIndex = 5
        Me.lblTratamiento.Text = "TRATAMIENTO"
        '
        'dtpFechaHC
        '
        Me.dtpFechaHC.Location = New System.Drawing.Point(237, 116)
        Me.dtpFechaHC.Name = "dtpFechaHC"
        Me.dtpFechaHC.Size = New System.Drawing.Size(232, 24)
        Me.dtpFechaHC.TabIndex = 6
        '
        'txtPacienteHC
        '
        Me.txtPacienteHC.Location = New System.Drawing.Point(237, 176)
        Me.txtPacienteHC.Name = "txtPacienteHC"
        Me.txtPacienteHC.ReadOnly = True
        Me.txtPacienteHC.Size = New System.Drawing.Size(232, 24)
        Me.txtPacienteHC.TabIndex = 7
        Me.txtPacienteHC.Text = "BUSCAR UNO"
        Me.txtPacienteHC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscarPac
        '
        Me.btnBuscarPac.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.search
        Me.btnBuscarPac.Location = New System.Drawing.Point(479, 167)
        Me.btnBuscarPac.Name = "btnBuscarPac"
        Me.btnBuscarPac.Size = New System.Drawing.Size(40, 37)
        Me.btnBuscarPac.TabIndex = 8
        Me.btnBuscarPac.UseVisualStyleBackColor = True
        '
        'rtbMotivoC
        '
        Me.rtbMotivoC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbMotivoC.Location = New System.Drawing.Point(237, 239)
        Me.rtbMotivoC.Name = "rtbMotivoC"
        Me.rtbMotivoC.Size = New System.Drawing.Size(753, 96)
        Me.rtbMotivoC.TabIndex = 9
        Me.rtbMotivoC.Text = ""
        '
        'rtbDiagnostico
        '
        Me.rtbDiagnostico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbDiagnostico.Location = New System.Drawing.Point(237, 352)
        Me.rtbDiagnostico.Name = "rtbDiagnostico"
        Me.rtbDiagnostico.Size = New System.Drawing.Size(753, 96)
        Me.rtbDiagnostico.TabIndex = 10
        Me.rtbDiagnostico.Text = ""
        '
        'rtbTratamiento
        '
        Me.rtbTratamiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbTratamiento.Location = New System.Drawing.Point(237, 465)
        Me.rtbTratamiento.Name = "rtbTratamiento"
        Me.rtbTratamiento.Size = New System.Drawing.Size(753, 96)
        Me.rtbTratamiento.TabIndex = 11
        Me.rtbTratamiento.Text = ""
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.back
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(874, 641)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(116, 39)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "    SALIR"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscarHC
        '
        Me.btnBuscarHC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarHC.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.search
        Me.btnBuscarHC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarHC.Location = New System.Drawing.Point(704, 598)
        Me.btnBuscarHC.Name = "btnBuscarHC"
        Me.btnBuscarHC.Size = New System.Drawing.Size(139, 47)
        Me.btnBuscarHC.TabIndex = 15
        Me.btnBuscarHC.Text = "  BUSCAR H.C."
        Me.btnBuscarHC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscarHC.UseVisualStyleBackColor = True
        '
        'btnNuevaHC
        '
        Me.btnNuevaHC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevaHC.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.edit2
        Me.btnNuevaHC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevaHC.Location = New System.Drawing.Point(538, 598)
        Me.btnNuevaHC.Name = "btnNuevaHC"
        Me.btnNuevaHC.Size = New System.Drawing.Size(139, 47)
        Me.btnNuevaHC.TabIndex = 16
        Me.btnNuevaHC.Text = "  NUEVA H.C."
        Me.btnNuevaHC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevaHC.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirmar.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.ok
        Me.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmar.Location = New System.Drawing.Point(370, 598)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(139, 47)
        Me.btnConfirmar.TabIndex = 17
        Me.btnConfirmar.Text = "  CONFIRMAR"
        Me.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'frmHistoriasClinicas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1134, 708)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnNuevaHC)
        Me.Controls.Add(Me.btnBuscarHC)
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
        Me.Name = "frmHistoriasClinicas"
        Me.Text = "HISTORIAS CLINICAS"
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
    Friend WithEvents btnBuscarHC As Button
    Friend WithEvents btnNuevaHC As Button
    Friend WithEvents btnConfirmar As Button
End Class
