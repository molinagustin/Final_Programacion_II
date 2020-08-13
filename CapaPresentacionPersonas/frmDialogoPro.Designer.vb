<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogoPro
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblListadoProf = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.dgvListadoProfesionales = New System.Windows.Forms.DataGridView()
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
        CType(Me.dgvListadoProfesionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblListadoProf
        '
        Me.lblListadoProf.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblListadoProf.BackColor = System.Drawing.Color.Transparent
        Me.lblListadoProf.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoProf.ForeColor = System.Drawing.Color.Black
        Me.lblListadoProf.Location = New System.Drawing.Point(11, 9)
        Me.lblListadoProf.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblListadoProf.MaximumSize = New System.Drawing.Size(801, 36)
        Me.lblListadoProf.MinimumSize = New System.Drawing.Size(801, 36)
        Me.lblListadoProf.Name = "lblListadoProf"
        Me.lblListadoProf.Size = New System.Drawing.Size(801, 36)
        Me.lblListadoProf.TabIndex = 21
        Me.lblListadoProf.Text = "LISTADO DE PROFESIONALES"
        Me.lblListadoProf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnCancelar.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.stop_error
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(457, 354)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.MaximumSize = New System.Drawing.Size(121, 47)
        Me.btnCancelar.MinimumSize = New System.Drawing.Size(121, 47)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(121, 47)
        Me.btnCancelar.TabIndex = 23
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnAceptar.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.ok
        Me.btnAceptar.Location = New System.Drawing.Point(267, 354)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAceptar.MaximumSize = New System.Drawing.Size(121, 47)
        Me.btnAceptar.MinimumSize = New System.Drawing.Size(121, 47)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(121, 47)
        Me.btnAceptar.TabIndex = 22
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'dgvListadoProfesionales
        '
        Me.dgvListadoProfesionales.AllowUserToAddRows = False
        Me.dgvListadoProfesionales.AllowUserToDeleteRows = False
        Me.dgvListadoProfesionales.AllowUserToResizeColumns = False
        Me.dgvListadoProfesionales.AllowUserToResizeRows = False
        Me.dgvListadoProfesionales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListadoProfesionales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListadoProfesionales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoProfesionales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoProfesionales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProfesional, Me.NombreCompleto, Me.Direccion, Me.TipoDocumento, Me.NumeroDocumento, Me.Genero, Me.Especialidad, Me.Localidad, Me.Activo, Me.IdUsuario, Me.FechaUltimaModificacion})
        Me.dgvListadoProfesionales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvListadoProfesionales.Location = New System.Drawing.Point(10, 117)
        Me.dgvListadoProfesionales.MaximumSize = New System.Drawing.Size(803, 224)
        Me.dgvListadoProfesionales.MinimumSize = New System.Drawing.Size(803, 224)
        Me.dgvListadoProfesionales.MultiSelect = False
        Me.dgvListadoProfesionales.Name = "dgvListadoProfesionales"
        Me.dgvListadoProfesionales.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoProfesionales.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvListadoProfesionales.RowHeadersVisible = False
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.dgvListadoProfesionales.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvListadoProfesionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoProfesionales.Size = New System.Drawing.Size(803, 224)
        Me.dgvListadoProfesionales.TabIndex = 24
        '
        'IdProfesional
        '
        Me.IdProfesional.DataPropertyName = "IdProfesional"
        Me.IdProfesional.HeaderText = "IdProfesional"
        Me.IdProfesional.Name = "IdProfesional"
        Me.IdProfesional.ReadOnly = True
        Me.IdProfesional.Visible = False
        '
        'NombreCompleto
        '
        Me.NombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreCompleto.DataPropertyName = "NombreCompleto"
        Me.NombreCompleto.HeaderText = "NOMBRE COMPLETO"
        Me.NombreCompleto.MinimumWidth = 220
        Me.NombreCompleto.Name = "NombreCompleto"
        Me.NombreCompleto.ReadOnly = True
        '
        'Direccion
        '
        Me.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.HeaderText = "DIRECCION"
        Me.Direccion.MinimumWidth = 200
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Visible = False
        '
        'TipoDocumento
        '
        Me.TipoDocumento.DataPropertyName = "TipoDocumento"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TipoDocumento.DefaultCellStyle = DataGridViewCellStyle2
        Me.TipoDocumento.HeaderText = "TIPO DOCUMENTO"
        Me.TipoDocumento.MinimumWidth = 100
        Me.TipoDocumento.Name = "TipoDocumento"
        Me.TipoDocumento.ReadOnly = True
        Me.TipoDocumento.Visible = False
        '
        'NumeroDocumento
        '
        Me.NumeroDocumento.DataPropertyName = "NumeroDocumento"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NumeroDocumento.DefaultCellStyle = DataGridViewCellStyle3
        Me.NumeroDocumento.HeaderText = "NUMERO DE DOCUMENTO"
        Me.NumeroDocumento.MinimumWidth = 120
        Me.NumeroDocumento.Name = "NumeroDocumento"
        Me.NumeroDocumento.ReadOnly = True
        Me.NumeroDocumento.Visible = False
        Me.NumeroDocumento.Width = 120
        '
        'Genero
        '
        Me.Genero.DataPropertyName = "Genero"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Genero.DefaultCellStyle = DataGridViewCellStyle4
        Me.Genero.HeaderText = "GENERO"
        Me.Genero.MinimumWidth = 120
        Me.Genero.Name = "Genero"
        Me.Genero.ReadOnly = True
        Me.Genero.Visible = False
        Me.Genero.Width = 120
        '
        'Especialidad
        '
        Me.Especialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Especialidad.DataPropertyName = "Especialidad"
        Me.Especialidad.HeaderText = "ESPECIALIDAD"
        Me.Especialidad.MinimumWidth = 150
        Me.Especialidad.Name = "Especialidad"
        Me.Especialidad.ReadOnly = True
        '
        'Localidad
        '
        Me.Localidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Localidad.DataPropertyName = "Localidad"
        Me.Localidad.HeaderText = "LOCALIDAD"
        Me.Localidad.MinimumWidth = 170
        Me.Localidad.Name = "Localidad"
        Me.Localidad.ReadOnly = True
        Me.Localidad.Visible = False
        '
        'Activo
        '
        Me.Activo.DataPropertyName = "Activo"
        Me.Activo.HeaderText = "ACTIVO"
        Me.Activo.Name = "Activo"
        Me.Activo.ReadOnly = True
        Me.Activo.Visible = False
        '
        'IdUsuario
        '
        Me.IdUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdUsuario.DataPropertyName = "IdUsuario"
        Me.IdUsuario.HeaderText = "ID USUARIO"
        Me.IdUsuario.MinimumWidth = 100
        Me.IdUsuario.Name = "IdUsuario"
        Me.IdUsuario.ReadOnly = True
        Me.IdUsuario.Visible = False
        '
        'FechaUltimaModificacion
        '
        Me.FechaUltimaModificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FechaUltimaModificacion.DataPropertyName = "FechaUltimaModificacion"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FechaUltimaModificacion.DefaultCellStyle = DataGridViewCellStyle5
        Me.FechaUltimaModificacion.HeaderText = "FECHA ULTIMA MODIFICACION"
        Me.FechaUltimaModificacion.MinimumWidth = 130
        Me.FechaUltimaModificacion.Name = "FechaUltimaModificacion"
        Me.FechaUltimaModificacion.ReadOnly = True
        Me.FechaUltimaModificacion.Visible = False
        '
        'frmDialogoPro
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(825, 422)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvListadoProfesionales)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblListadoProf)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximumSize = New System.Drawing.Size(841, 461)
        Me.MinimumSize = New System.Drawing.Size(841, 461)
        Me.Name = "frmDialogoPro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROFESIONALES"
        CType(Me.dgvListadoProfesionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblListadoProf As Label
    Friend WithEvents dgvListadoProfesionales As DataGridView
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
