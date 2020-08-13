<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReactivacionProf
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.dgvListadoProf = New System.Windows.Forms.DataGridView()
        Me.IdProfesional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Especialidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltimaModificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblReactivar = New System.Windows.Forms.Label()
        CType(Me.dgvListadoProf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = Global.CapaPresentacionUsuarios.My.Resources.Resources.back
        Me.btnSalir.Location = New System.Drawing.Point(435, 351)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(114, 47)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "    SALIR"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirmar.Image = Global.CapaPresentacionUsuarios.My.Resources.Resources.ok
        Me.btnConfirmar.Location = New System.Drawing.Point(242, 351)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(114, 47)
        Me.btnConfirmar.TabIndex = 3
        Me.btnConfirmar.Text = "CONFIRMAR"
        Me.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'dgvListadoProf
        '
        Me.dgvListadoProf.AllowUserToAddRows = False
        Me.dgvListadoProf.AllowUserToDeleteRows = False
        Me.dgvListadoProf.AllowUserToResizeColumns = False
        Me.dgvListadoProf.AllowUserToResizeRows = False
        Me.dgvListadoProf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListadoProf.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListadoProf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoProf.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoProf.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProfesional, Me.NombreCompleto, Me.Direccion, Me.TipoDocumento, Me.NumeroDocumento, Me.Genero, Me.Especialidad, Me.Localidad, Me.Activo, Me.IdUsuario, Me.FechaUltimaModificacion})
        Me.dgvListadoProf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvListadoProf.Location = New System.Drawing.Point(12, 88)
        Me.dgvListadoProf.MaximumSize = New System.Drawing.Size(801, 237)
        Me.dgvListadoProf.MinimumSize = New System.Drawing.Size(801, 237)
        Me.dgvListadoProf.MultiSelect = False
        Me.dgvListadoProf.Name = "dgvListadoProf"
        Me.dgvListadoProf.ReadOnly = True
        Me.dgvListadoProf.RowHeadersVisible = False
        Me.dgvListadoProf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoProf.Size = New System.Drawing.Size(801, 237)
        Me.dgvListadoProf.TabIndex = 5
        '
        'IdProfesional
        '
        Me.IdProfesional.DataPropertyName = "IdProfesional"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IdProfesional.DefaultCellStyle = DataGridViewCellStyle2
        Me.IdProfesional.HeaderText = "IdProfesional"
        Me.IdProfesional.MinimumWidth = 100
        Me.IdProfesional.Name = "IdProfesional"
        Me.IdProfesional.ReadOnly = True
        '
        'NombreCompleto
        '
        Me.NombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreCompleto.DataPropertyName = "NombreCompleto"
        Me.NombreCompleto.HeaderText = "NombreCompleto"
        Me.NombreCompleto.Name = "NombreCompleto"
        Me.NombreCompleto.ReadOnly = True
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Visible = False
        '
        'TipoDocumento
        '
        Me.TipoDocumento.DataPropertyName = "TipoDocumento"
        Me.TipoDocumento.HeaderText = "TipoDocumento"
        Me.TipoDocumento.Name = "TipoDocumento"
        Me.TipoDocumento.ReadOnly = True
        Me.TipoDocumento.Visible = False
        '
        'NumeroDocumento
        '
        Me.NumeroDocumento.DataPropertyName = "NumeroDocumento"
        Me.NumeroDocumento.HeaderText = "NumeroDocumento"
        Me.NumeroDocumento.Name = "NumeroDocumento"
        Me.NumeroDocumento.ReadOnly = True
        Me.NumeroDocumento.Visible = False
        '
        'Genero
        '
        Me.Genero.DataPropertyName = "Genero"
        Me.Genero.HeaderText = "Genero"
        Me.Genero.Name = "Genero"
        Me.Genero.ReadOnly = True
        Me.Genero.Visible = False
        '
        'Especialidad
        '
        Me.Especialidad.DataPropertyName = "Especialidad"
        Me.Especialidad.HeaderText = "Especialidad"
        Me.Especialidad.Name = "Especialidad"
        Me.Especialidad.ReadOnly = True
        Me.Especialidad.Visible = False
        '
        'Localidad
        '
        Me.Localidad.DataPropertyName = "Localidad"
        Me.Localidad.HeaderText = "Localidad"
        Me.Localidad.Name = "Localidad"
        Me.Localidad.ReadOnly = True
        Me.Localidad.Visible = False
        '
        'Activo
        '
        Me.Activo.DataPropertyName = "Activo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Activo.DefaultCellStyle = DataGridViewCellStyle3
        Me.Activo.HeaderText = "Activo"
        Me.Activo.MinimumWidth = 100
        Me.Activo.Name = "Activo"
        Me.Activo.ReadOnly = True
        '
        'IdUsuario
        '
        Me.IdUsuario.DataPropertyName = "IdUsuario"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IdUsuario.DefaultCellStyle = DataGridViewCellStyle4
        Me.IdUsuario.HeaderText = "IdUsuario"
        Me.IdUsuario.MinimumWidth = 100
        Me.IdUsuario.Name = "IdUsuario"
        Me.IdUsuario.ReadOnly = True
        '
        'FechaUltimaModificacion
        '
        Me.FechaUltimaModificacion.DataPropertyName = "FechaUltimaModificacion"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FechaUltimaModificacion.DefaultCellStyle = DataGridViewCellStyle5
        Me.FechaUltimaModificacion.HeaderText = "FechaUltimaModificacion"
        Me.FechaUltimaModificacion.MinimumWidth = 150
        Me.FechaUltimaModificacion.Name = "FechaUltimaModificacion"
        Me.FechaUltimaModificacion.ReadOnly = True
        Me.FechaUltimaModificacion.Width = 150
        '
        'lblReactivar
        '
        Me.lblReactivar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReactivar.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReactivar.Location = New System.Drawing.Point(12, 8)
        Me.lblReactivar.MaximumSize = New System.Drawing.Size(801, 29)
        Me.lblReactivar.MinimumSize = New System.Drawing.Size(801, 29)
        Me.lblReactivar.Name = "lblReactivar"
        Me.lblReactivar.Size = New System.Drawing.Size(801, 29)
        Me.lblReactivar.TabIndex = 6
        Me.lblReactivar.Text = "REACTIVAR PROFESIONALES"
        Me.lblReactivar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmReactivacionProf
        '
        Me.AcceptButton = Me.btnConfirmar
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(825, 422)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblReactivar)
        Me.Controls.Add(Me.dgvListadoProf)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(841, 461)
        Me.MinimumSize = New System.Drawing.Size(841, 461)
        Me.Name = "frmReactivacionProf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REACTIVACIONES"
        CType(Me.dgvListadoProf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents dgvListadoProf As DataGridView
    Friend WithEvents lblReactivar As Label
    Friend WithEvents IdProfesional As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompleto As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents TipoDocumento As DataGridViewTextBoxColumn
    Friend WithEvents NumeroDocumento As DataGridViewTextBoxColumn
    Friend WithEvents Genero As DataGridViewTextBoxColumn
    Friend WithEvents Especialidad As DataGridViewTextBoxColumn
    Friend WithEvents Localidad As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents FechaUltimaModificacion As DataGridViewTextBoxColumn
End Class
