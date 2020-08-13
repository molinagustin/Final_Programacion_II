<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistoriasClinicasPaciente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistoriasClinicasPaciente))
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblHCPaciente = New System.Windows.Forms.Label()
        Me.dgvHCPaciente = New System.Windows.Forms.DataGridView()
        Me.IdHClinica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotivoConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvHCPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.ok
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(260, 348)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(110, 47)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.stop_error
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(452, 348)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(110, 47)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblHCPaciente
        '
        Me.lblHCPaciente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHCPaciente.AutoSize = True
        Me.lblHCPaciente.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lblHCPaciente.Location = New System.Drawing.Point(223, 36)
        Me.lblHCPaciente.Name = "lblHCPaciente"
        Me.lblHCPaciente.Size = New System.Drawing.Size(378, 24)
        Me.lblHCPaciente.TabIndex = 2
        Me.lblHCPaciente.Text = "HISTORIAS CLINICAS DE (NOMBRE PACIENTE)"
        Me.lblHCPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvHCPaciente
        '
        Me.dgvHCPaciente.AllowUserToAddRows = False
        Me.dgvHCPaciente.AllowUserToDeleteRows = False
        Me.dgvHCPaciente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvHCPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHCPaciente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHCPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHCPaciente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdHClinica, Me.Fecha, Me.MotivoConsulta})
        Me.dgvHCPaciente.Location = New System.Drawing.Point(80, 91)
        Me.dgvHCPaciente.MultiSelect = False
        Me.dgvHCPaciente.Name = "dgvHCPaciente"
        Me.dgvHCPaciente.ReadOnly = True
        Me.dgvHCPaciente.RowHeadersVisible = False
        Me.dgvHCPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHCPaciente.Size = New System.Drawing.Size(652, 224)
        Me.dgvHCPaciente.TabIndex = 3
        '
        'IdHClinica
        '
        Me.IdHClinica.DataPropertyName = "IdHClinica"
        Me.IdHClinica.HeaderText = "IdHClinica"
        Me.IdHClinica.Name = "IdHClinica"
        Me.IdHClinica.ReadOnly = True
        Me.IdHClinica.Visible = False
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "FECHA"
        Me.Fecha.MinimumWidth = 140
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 140
        '
        'MotivoConsulta
        '
        Me.MotivoConsulta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MotivoConsulta.DataPropertyName = "MotivoConsulta"
        Me.MotivoConsulta.HeaderText = "MOTIVO DE CONSULTA"
        Me.MotivoConsulta.Name = "MotivoConsulta"
        Me.MotivoConsulta.ReadOnly = True
        '
        'frmHistoriasClinicasPaciente
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(825, 422)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvHCPaciente)
        Me.Controls.Add(Me.lblHCPaciente)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHistoriasClinicasPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HISTORIAS CLINICAS"
        CType(Me.dgvHCPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblHCPaciente As Label
    Friend WithEvents dgvHCPaciente As DataGridView
    Friend WithEvents IdHClinica As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents MotivoConsulta As DataGridViewTextBoxColumn
End Class
