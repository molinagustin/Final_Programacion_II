<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVistaPacientes
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVistaPacientes))
        Me.dgvListadoPacientes = New System.Windows.Forms.DataGridView()
        Me.IdPaciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sigla1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObraSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumObraSoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoElectronico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltimaModificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdObraSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuario2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltimaModificacion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblVistaPacientes = New System.Windows.Forms.Label()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.dgvListadoPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListadoPacientes
        '
        Me.dgvListadoPacientes.AllowUserToAddRows = False
        Me.dgvListadoPacientes.AllowUserToDeleteRows = False
        Me.dgvListadoPacientes.AllowUserToResizeColumns = False
        Me.dgvListadoPacientes.AllowUserToResizeRows = False
        Me.dgvListadoPacientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListadoPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListadoPacientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoPacientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPaciente, Me.NombreCompleto, Me.Direccion, Me.TipoDocumento, Me.NumeroDocumento, Me.Genero, Me.Sigla1, Me.ObraSocial, Me.NumObraSoc, Me.Localidad, Me.FechaNacimiento, Me.NumTelefono, Me.CorreoElectronico, Me.Activo, Me.IdUsuario, Me.FechaUltimaModificacion, Me.IdObraSocial, Me.NombreOS, Me.Activo1, Me.IdUsuario2, Me.FechaUltimaModificacion2})
        Me.dgvListadoPacientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvListadoPacientes.Location = New System.Drawing.Point(12, 211)
        Me.dgvListadoPacientes.MultiSelect = False
        Me.dgvListadoPacientes.Name = "dgvListadoPacientes"
        Me.dgvListadoPacientes.ReadOnly = True
        Me.dgvListadoPacientes.RowHeadersVisible = False
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvListadoPacientes.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvListadoPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoPacientes.Size = New System.Drawing.Size(961, 473)
        Me.dgvListadoPacientes.TabIndex = 0
        '
        'IdPaciente
        '
        Me.IdPaciente.DataPropertyName = "IdPaciente"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.IdPaciente.DefaultCellStyle = DataGridViewCellStyle2
        Me.IdPaciente.HeaderText = "N° HISTORIA CLINICA"
        Me.IdPaciente.MinimumWidth = 130
        Me.IdPaciente.Name = "IdPaciente"
        Me.IdPaciente.ReadOnly = True
        Me.IdPaciente.Width = 130
        '
        'NombreCompleto
        '
        Me.NombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreCompleto.DataPropertyName = "NombreCompleto"
        Me.NombreCompleto.HeaderText = "NOMBRE COMPLETO"
        Me.NombreCompleto.MinimumWidth = 235
        Me.NombreCompleto.Name = "NombreCompleto"
        Me.NombreCompleto.ReadOnly = True
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.HeaderText = "DIRECCION"
        Me.Direccion.MinimumWidth = 235
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Visible = False
        Me.Direccion.Width = 235
        '
        'TipoDocumento
        '
        Me.TipoDocumento.DataPropertyName = "TipoDocumento"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TipoDocumento.DefaultCellStyle = DataGridViewCellStyle3
        Me.TipoDocumento.HeaderText = "TIPO DE DOCUMENTO"
        Me.TipoDocumento.MinimumWidth = 100
        Me.TipoDocumento.Name = "TipoDocumento"
        Me.TipoDocumento.ReadOnly = True
        Me.TipoDocumento.Visible = False
        '
        'NumeroDocumento
        '
        Me.NumeroDocumento.DataPropertyName = "NumeroDocumento"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NumeroDocumento.DefaultCellStyle = DataGridViewCellStyle4
        Me.NumeroDocumento.HeaderText = "NUMERO DE DOCUMENTO"
        Me.NumeroDocumento.MinimumWidth = 130
        Me.NumeroDocumento.Name = "NumeroDocumento"
        Me.NumeroDocumento.ReadOnly = True
        Me.NumeroDocumento.Width = 130
        '
        'Genero
        '
        Me.Genero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Genero.DataPropertyName = "Genero"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Genero.DefaultCellStyle = DataGridViewCellStyle5
        Me.Genero.HeaderText = "GENERO"
        Me.Genero.MinimumWidth = 75
        Me.Genero.Name = "Genero"
        Me.Genero.ReadOnly = True
        Me.Genero.Visible = False
        '
        'Sigla1
        '
        Me.Sigla1.DataPropertyName = "Sigla"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Sigla1.DefaultCellStyle = DataGridViewCellStyle6
        Me.Sigla1.HeaderText = "OBRA SOCIAL"
        Me.Sigla1.MinimumWidth = 150
        Me.Sigla1.Name = "Sigla1"
        Me.Sigla1.ReadOnly = True
        Me.Sigla1.Width = 150
        '
        'ObraSocial
        '
        Me.ObraSocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ObraSocial.DataPropertyName = "ObraSocial"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ObraSocial.DefaultCellStyle = DataGridViewCellStyle7
        Me.ObraSocial.HeaderText = "ObraSocialPac"
        Me.ObraSocial.MinimumWidth = 60
        Me.ObraSocial.Name = "ObraSocial"
        Me.ObraSocial.ReadOnly = True
        Me.ObraSocial.Visible = False
        '
        'NumObraSoc
        '
        Me.NumObraSoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NumObraSoc.DataPropertyName = "NumObraSoc"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NumObraSoc.DefaultCellStyle = DataGridViewCellStyle8
        Me.NumObraSoc.HeaderText = "N° OBRA SOCIAL"
        Me.NumObraSoc.MinimumWidth = 120
        Me.NumObraSoc.Name = "NumObraSoc"
        Me.NumObraSoc.ReadOnly = True
        Me.NumObraSoc.Visible = False
        '
        'Localidad
        '
        Me.Localidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Localidad.DataPropertyName = "Localidad"
        Me.Localidad.HeaderText = "LOCALIDAD"
        Me.Localidad.MinimumWidth = 200
        Me.Localidad.Name = "Localidad"
        Me.Localidad.ReadOnly = True
        Me.Localidad.Visible = False
        '
        'FechaNacimiento
        '
        Me.FechaNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FechaNacimiento.DataPropertyName = "FechaNacimiento"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FechaNacimiento.DefaultCellStyle = DataGridViewCellStyle9
        Me.FechaNacimiento.HeaderText = "FECHA DE NACIMIENTO"
        Me.FechaNacimiento.MinimumWidth = 100
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.ReadOnly = True
        Me.FechaNacimiento.Visible = False
        '
        'NumTelefono
        '
        Me.NumTelefono.DataPropertyName = "NumTelefono"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NumTelefono.DefaultCellStyle = DataGridViewCellStyle10
        Me.NumTelefono.HeaderText = "N° TELEFONO"
        Me.NumTelefono.MinimumWidth = 130
        Me.NumTelefono.Name = "NumTelefono"
        Me.NumTelefono.ReadOnly = True
        Me.NumTelefono.Width = 130
        '
        'CorreoElectronico
        '
        Me.CorreoElectronico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CorreoElectronico.DataPropertyName = "CorreoElectronico"
        Me.CorreoElectronico.HeaderText = "CORREO ELECTRONICO"
        Me.CorreoElectronico.MinimumWidth = 180
        Me.CorreoElectronico.Name = "CorreoElectronico"
        Me.CorreoElectronico.ReadOnly = True
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
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FechaUltimaModificacion.DefaultCellStyle = DataGridViewCellStyle11
        Me.FechaUltimaModificacion.HeaderText = "FECHA ULTIMA MODIFICACION"
        Me.FechaUltimaModificacion.MinimumWidth = 143
        Me.FechaUltimaModificacion.Name = "FechaUltimaModificacion"
        Me.FechaUltimaModificacion.ReadOnly = True
        Me.FechaUltimaModificacion.Visible = False
        '
        'IdObraSocial
        '
        Me.IdObraSocial.DataPropertyName = "IdObraSocial"
        Me.IdObraSocial.HeaderText = "IdObraSocial"
        Me.IdObraSocial.Name = "IdObraSocial"
        Me.IdObraSocial.ReadOnly = True
        Me.IdObraSocial.Visible = False
        '
        'NombreOS
        '
        Me.NombreOS.DataPropertyName = "NombreOS"
        Me.NombreOS.HeaderText = "NombreOS"
        Me.NombreOS.Name = "NombreOS"
        Me.NombreOS.ReadOnly = True
        Me.NombreOS.Visible = False
        '
        'Activo1
        '
        Me.Activo1.DataPropertyName = "Activo1"
        Me.Activo1.HeaderText = "ActivoObraSoc"
        Me.Activo1.Name = "Activo1"
        Me.Activo1.ReadOnly = True
        Me.Activo1.Visible = False
        '
        'IdUsuario2
        '
        Me.IdUsuario2.DataPropertyName = "IdUsuario1"
        Me.IdUsuario2.HeaderText = "IdUsuarioOS"
        Me.IdUsuario2.Name = "IdUsuario2"
        Me.IdUsuario2.ReadOnly = True
        Me.IdUsuario2.Visible = False
        '
        'FechaUltimaModificacion2
        '
        Me.FechaUltimaModificacion2.DataPropertyName = "FechaUltimaModificacion1"
        Me.FechaUltimaModificacion2.HeaderText = "FechaUltimaModificacionOS"
        Me.FechaUltimaModificacion2.Name = "FechaUltimaModificacion2"
        Me.FechaUltimaModificacion2.ReadOnly = True
        Me.FechaUltimaModificacion2.Visible = False
        '
        'lblVistaPacientes
        '
        Me.lblVistaPacientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVistaPacientes.BackColor = System.Drawing.Color.Transparent
        Me.lblVistaPacientes.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVistaPacientes.Location = New System.Drawing.Point(12, 9)
        Me.lblVistaPacientes.Name = "lblVistaPacientes"
        Me.lblVistaPacientes.Size = New System.Drawing.Size(1121, 33)
        Me.lblVistaPacientes.TabIndex = 1
        Me.lblVistaPacientes.Text = "HISTORIAS CLINICAS"
        Me.lblVistaPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBuscar
        '
        Me.lblBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblBuscar.Location = New System.Drawing.Point(689, 179)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(77, 22)
        Me.lblBuscar.TabIndex = 7
        Me.lblBuscar.Text = "BUSCAR:"
        '
        'txtBuscador
        '
        Me.txtBuscador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscador.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.txtBuscador.Location = New System.Drawing.Point(772, 176)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(201, 29)
        Me.txtBuscador.TabIndex = 1
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
        Me.btnSalir.Text = "     SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnAgregar.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.insert
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(994, 562)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(139, 47)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "   AGREGAR NUEVA"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'frmVistaPacientes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1145, 719)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtBuscador)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblVistaPacientes)
        Me.Controls.Add(Me.dgvListadoPacientes)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1161, 735)
        Me.Name = "frmVistaPacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA DE HISTORIAS CLINICAS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvListadoPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvListadoPacientes As DataGridView
    Friend WithEvents lblVistaPacientes As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscador As TextBox
    Friend WithEvents IdPaciente As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompleto As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents TipoDocumento As DataGridViewTextBoxColumn
    Friend WithEvents NumeroDocumento As DataGridViewTextBoxColumn
    Friend WithEvents Genero As DataGridViewTextBoxColumn
    Friend WithEvents Sigla1 As DataGridViewTextBoxColumn
    Friend WithEvents ObraSocial As DataGridViewTextBoxColumn
    Friend WithEvents NumObraSoc As DataGridViewTextBoxColumn
    Friend WithEvents Localidad As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents NumTelefono As DataGridViewTextBoxColumn
    Friend WithEvents CorreoElectronico As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents FechaUltimaModificacion As DataGridViewTextBoxColumn
    Friend WithEvents IdObraSocial As DataGridViewTextBoxColumn
    Friend WithEvents NombreOS As DataGridViewTextBoxColumn
    Friend WithEvents Activo1 As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuario2 As DataGridViewTextBoxColumn
    Friend WithEvents FechaUltimaModificacion2 As DataGridViewTextBoxColumn
End Class
