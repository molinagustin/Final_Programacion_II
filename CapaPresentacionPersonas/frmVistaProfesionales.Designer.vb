<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVistaProfesionales
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVistaProfesionales))
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
        Me.lblVistaProfes = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.dgvListadoProfesionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoProfesionales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoProfesionales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProfesional, Me.NombreCompleto, Me.Direccion, Me.TipoDocumento, Me.NumeroDocumento, Me.Genero, Me.Especialidad, Me.Localidad, Me.Activo, Me.IdUsuario, Me.FechaUltimaModificacion})
        Me.dgvListadoProfesionales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvListadoProfesionales.Location = New System.Drawing.Point(12, 211)
        Me.dgvListadoProfesionales.MultiSelect = False
        Me.dgvListadoProfesionales.Name = "dgvListadoProfesionales"
        Me.dgvListadoProfesionales.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoProfesionales.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvListadoProfesionales.RowHeadersVisible = False
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.dgvListadoProfesionales.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvListadoProfesionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoProfesionales.Size = New System.Drawing.Size(961, 473)
        Me.dgvListadoProfesionales.TabIndex = 0
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
        Me.NumeroDocumento.MinimumWidth = 130
        Me.NumeroDocumento.Name = "NumeroDocumento"
        Me.NumeroDocumento.ReadOnly = True
        Me.NumeroDocumento.Width = 130
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
        'lblVistaProfes
        '
        Me.lblVistaProfes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVistaProfes.BackColor = System.Drawing.Color.Transparent
        Me.lblVistaProfes.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVistaProfes.Location = New System.Drawing.Point(12, 9)
        Me.lblVistaProfes.Name = "lblVistaProfes"
        Me.lblVistaProfes.Size = New System.Drawing.Size(1121, 33)
        Me.lblVistaProfes.TabIndex = 1
        Me.lblVistaProfes.Text = "VISTA DE PROFESIONALES"
        Me.lblVistaProfes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnSalir.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.back
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(1004, 645)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(116, 39)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "    SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnAgregar.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.user_add
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(994, 562)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(139, 47)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "   AGREGAR NUEVO"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'frmVistaProfesionales
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1145, 719)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblVistaProfes)
        Me.Controls.Add(Me.dgvListadoProfesionales)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1161, 735)
        Me.Name = "frmVistaProfesionales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA PROFESIONALES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvListadoProfesionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvListadoProfesionales As DataGridView
    Friend WithEvents lblVistaProfes As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnSalir As Button
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
