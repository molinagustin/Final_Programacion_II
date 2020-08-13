<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDialogoPac
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblListadoPac = New System.Windows.Forms.Label()
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
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        CType(Me.dgvListadoPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnCancelar.TabIndex = 15
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
        Me.btnAceptar.TabIndex = 14
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblListadoPac
        '
        Me.lblListadoPac.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblListadoPac.BackColor = System.Drawing.Color.Transparent
        Me.lblListadoPac.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoPac.ForeColor = System.Drawing.Color.Black
        Me.lblListadoPac.Location = New System.Drawing.Point(11, 9)
        Me.lblListadoPac.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblListadoPac.MaximumSize = New System.Drawing.Size(801, 36)
        Me.lblListadoPac.MinimumSize = New System.Drawing.Size(801, 36)
        Me.lblListadoPac.Name = "lblListadoPac"
        Me.lblListadoPac.Size = New System.Drawing.Size(801, 36)
        Me.lblListadoPac.TabIndex = 13
        Me.lblListadoPac.Text = "LISTADO DE PACIENTES"
        Me.lblListadoPac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoPacientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPaciente, Me.NombreCompleto, Me.Direccion, Me.TipoDocumento, Me.NumeroDocumento, Me.Genero, Me.Sigla1, Me.ObraSocial, Me.NumObraSoc, Me.Localidad, Me.FechaNacimiento, Me.NumTelefono, Me.CorreoElectronico, Me.Activo, Me.IdUsuario, Me.FechaUltimaModificacion, Me.IdObraSocial, Me.NombreOS, Me.Activo1, Me.IdUsuario2, Me.FechaUltimaModificacion2})
        Me.dgvListadoPacientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvListadoPacientes.Location = New System.Drawing.Point(10, 117)
        Me.dgvListadoPacientes.MaximumSize = New System.Drawing.Size(803, 224)
        Me.dgvListadoPacientes.MinimumSize = New System.Drawing.Size(803, 224)
        Me.dgvListadoPacientes.MultiSelect = False
        Me.dgvListadoPacientes.Name = "dgvListadoPacientes"
        Me.dgvListadoPacientes.ReadOnly = True
        Me.dgvListadoPacientes.RowHeadersVisible = False
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.dgvListadoPacientes.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvListadoPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoPacientes.Size = New System.Drawing.Size(803, 224)
        Me.dgvListadoPacientes.TabIndex = 16
        '
        'IdPaciente
        '
        Me.IdPaciente.DataPropertyName = "IdPaciente"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
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
        Me.NumeroDocumento.Visible = False
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
        Me.NumTelefono.Visible = False
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
        Me.CorreoElectronico.Visible = False
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
        'txtBuscador
        '
        Me.txtBuscador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscador.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.txtBuscador.Location = New System.Drawing.Point(612, 82)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(201, 29)
        Me.txtBuscador.TabIndex = 1
        '
        'lblBuscar
        '
        Me.lblBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblBuscar.Location = New System.Drawing.Point(529, 85)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(77, 22)
        Me.lblBuscar.TabIndex = 18
        Me.lblBuscar.Text = "BUSCAR:"
        '
        'frmDialogoPac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(825, 422)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtBuscador)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.dgvListadoPacientes)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblListadoPac)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximumSize = New System.Drawing.Size(841, 461)
        Me.MinimumSize = New System.Drawing.Size(841, 461)
        Me.Name = "frmDialogoPac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTADO DE PACIENTES"
        CType(Me.dgvListadoPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblListadoPac As Label
    Friend WithEvents dgvListadoPacientes As DataGridView
    Friend WithEvents txtBuscador As TextBox
    Friend WithEvents lblBuscar As Label
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
