<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleMaestroPacientes
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblRegistroVisitas = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgvHCPaciente = New System.Windows.Forms.DataGridView()
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
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdObraSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuario2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltimaModificacion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.IdHClinica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotivoConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diagnostico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tratamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Altura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresionArterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FrecuenciaCard = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FrecuenciaResp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Analitica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltimaModificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvHCPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListadoPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRegistroVisitas
        '
        Me.lblRegistroVisitas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRegistroVisitas.BackColor = System.Drawing.Color.Transparent
        Me.lblRegistroVisitas.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistroVisitas.Location = New System.Drawing.Point(12, 9)
        Me.lblRegistroVisitas.MinimumSize = New System.Drawing.Size(450, 33)
        Me.lblRegistroVisitas.Name = "lblRegistroVisitas"
        Me.lblRegistroVisitas.Size = New System.Drawing.Size(1320, 33)
        Me.lblRegistroVisitas.TabIndex = 1
        Me.lblRegistroVisitas.Text = "REGISTRO DE VISITAS"
        Me.lblRegistroVisitas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnSalir.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.back
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(1216, 657)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(116, 39)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "    SALIR"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'dgvHCPaciente
        '
        Me.dgvHCPaciente.AllowUserToAddRows = False
        Me.dgvHCPaciente.AllowUserToDeleteRows = False
        Me.dgvHCPaciente.AllowUserToResizeColumns = False
        Me.dgvHCPaciente.AllowUserToResizeRows = False
        Me.dgvHCPaciente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvHCPaciente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvHCPaciente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHCPaciente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHCPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHCPaciente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdHClinica, Me.Fecha, Me.Paciente, Me.MotivoConsulta, Me.Diagnostico, Me.Tratamiento, Me.Peso, Me.Altura, Me.PresionArterial, Me.FrecuenciaCard, Me.FrecuenciaResp, Me.Analitica, Me.IdUsuario, Me.FechaUltimaModificacion})
        Me.dgvHCPaciente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvHCPaciente.Location = New System.Drawing.Point(181, 440)
        Me.dgvHCPaciente.MinimumSize = New System.Drawing.Size(801, 256)
        Me.dgvHCPaciente.MultiSelect = False
        Me.dgvHCPaciente.Name = "dgvHCPaciente"
        Me.dgvHCPaciente.ReadOnly = True
        Me.dgvHCPaciente.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.dgvHCPaciente.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvHCPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHCPaciente.Size = New System.Drawing.Size(1006, 256)
        Me.dgvHCPaciente.TabIndex = 16
        '
        'dgvListadoPacientes
        '
        Me.dgvListadoPacientes.AllowUserToAddRows = False
        Me.dgvListadoPacientes.AllowUserToDeleteRows = False
        Me.dgvListadoPacientes.AllowUserToResizeColumns = False
        Me.dgvListadoPacientes.AllowUserToResizeRows = False
        Me.dgvListadoPacientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListadoPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListadoPacientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoPacientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListadoPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPaciente, Me.NombreCompleto, Me.Direccion, Me.TipoDocumento, Me.NumeroDocumento, Me.Genero, Me.Sigla1, Me.ObraSocial, Me.NumObraSoc, Me.Localidad, Me.FechaNacimiento, Me.NumTelefono, Me.CorreoElectronico, Me.Activo, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.IdObraSocial, Me.NombreOS, Me.Activo1, Me.IdUsuario2, Me.FechaUltimaModificacion2})
        Me.dgvListadoPacientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvListadoPacientes.Location = New System.Drawing.Point(181, 100)
        Me.dgvListadoPacientes.MultiSelect = False
        Me.dgvListadoPacientes.Name = "dgvListadoPacientes"
        Me.dgvListadoPacientes.ReadOnly = True
        Me.dgvListadoPacientes.RowHeadersVisible = False
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvListadoPacientes.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvListadoPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoPacientes.Size = New System.Drawing.Size(1006, 322)
        Me.dgvListadoPacientes.TabIndex = 17
        '
        'IdPaciente
        '
        Me.IdPaciente.DataPropertyName = "IdPaciente"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.IdPaciente.DefaultCellStyle = DataGridViewCellStyle5
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TipoDocumento.DefaultCellStyle = DataGridViewCellStyle6
        Me.TipoDocumento.HeaderText = "TIPO DE DOCUMENTO"
        Me.TipoDocumento.MinimumWidth = 100
        Me.TipoDocumento.Name = "TipoDocumento"
        Me.TipoDocumento.ReadOnly = True
        Me.TipoDocumento.Visible = False
        '
        'NumeroDocumento
        '
        Me.NumeroDocumento.DataPropertyName = "NumeroDocumento"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NumeroDocumento.DefaultCellStyle = DataGridViewCellStyle7
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
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Genero.DefaultCellStyle = DataGridViewCellStyle8
        Me.Genero.HeaderText = "GENERO"
        Me.Genero.MinimumWidth = 75
        Me.Genero.Name = "Genero"
        Me.Genero.ReadOnly = True
        Me.Genero.Visible = False
        '
        'Sigla1
        '
        Me.Sigla1.DataPropertyName = "Sigla"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Sigla1.DefaultCellStyle = DataGridViewCellStyle9
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
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ObraSocial.DefaultCellStyle = DataGridViewCellStyle10
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
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NumObraSoc.DefaultCellStyle = DataGridViewCellStyle11
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
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FechaNacimiento.DefaultCellStyle = DataGridViewCellStyle12
        Me.FechaNacimiento.HeaderText = "FECHA DE NACIMIENTO"
        Me.FechaNacimiento.MinimumWidth = 100
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.ReadOnly = True
        Me.FechaNacimiento.Visible = False
        '
        'NumTelefono
        '
        Me.NumTelefono.DataPropertyName = "NumTelefono"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NumTelefono.DefaultCellStyle = DataGridViewCellStyle13
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdUsuario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID USUARIO"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FechaUltimaModificacion"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn2.HeaderText = "FECHA ULTIMA MODIFICACION"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 143
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
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
        Me.txtBuscador.Location = New System.Drawing.Point(986, 64)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(201, 29)
        Me.txtBuscador.TabIndex = 1
        '
        'lblBuscar
        '
        Me.lblBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Calibri", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblBuscar.Location = New System.Drawing.Point(903, 67)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(77, 22)
        Me.lblBuscar.TabIndex = 19
        Me.lblBuscar.Text = "BUSCAR:"
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
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Fecha.DataPropertyName = "Fecha"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "D"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.Fecha.HeaderText = "FECHA"
        Me.Fecha.MinimumWidth = 140
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 140
        '
        'Paciente
        '
        Me.Paciente.DataPropertyName = "Paciente"
        Me.Paciente.HeaderText = "Paciente"
        Me.Paciente.Name = "Paciente"
        Me.Paciente.ReadOnly = True
        Me.Paciente.Visible = False
        '
        'MotivoConsulta
        '
        Me.MotivoConsulta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MotivoConsulta.DataPropertyName = "MotivoConsulta"
        Me.MotivoConsulta.HeaderText = "MOTIVO DE CONSULTA"
        Me.MotivoConsulta.Name = "MotivoConsulta"
        Me.MotivoConsulta.ReadOnly = True
        '
        'Diagnostico
        '
        Me.Diagnostico.DataPropertyName = "Diagnostico"
        Me.Diagnostico.HeaderText = "Diagnostico"
        Me.Diagnostico.Name = "Diagnostico"
        Me.Diagnostico.ReadOnly = True
        Me.Diagnostico.Visible = False
        '
        'Tratamiento
        '
        Me.Tratamiento.DataPropertyName = "Tratamiento"
        Me.Tratamiento.HeaderText = "Tratamiento"
        Me.Tratamiento.Name = "Tratamiento"
        Me.Tratamiento.ReadOnly = True
        Me.Tratamiento.Visible = False
        '
        'Peso
        '
        Me.Peso.DataPropertyName = "Peso"
        Me.Peso.HeaderText = "Peso"
        Me.Peso.Name = "Peso"
        Me.Peso.ReadOnly = True
        Me.Peso.Visible = False
        '
        'Altura
        '
        Me.Altura.DataPropertyName = "Altura"
        Me.Altura.HeaderText = "Altura"
        Me.Altura.Name = "Altura"
        Me.Altura.ReadOnly = True
        Me.Altura.Visible = False
        '
        'PresionArterial
        '
        Me.PresionArterial.DataPropertyName = "PresionArterial"
        Me.PresionArterial.HeaderText = "PresionArterial"
        Me.PresionArterial.Name = "PresionArterial"
        Me.PresionArterial.ReadOnly = True
        Me.PresionArterial.Visible = False
        '
        'FrecuenciaCard
        '
        Me.FrecuenciaCard.DataPropertyName = "FrecuenciaCard"
        Me.FrecuenciaCard.HeaderText = "FrecuenciaCard"
        Me.FrecuenciaCard.Name = "FrecuenciaCard"
        Me.FrecuenciaCard.ReadOnly = True
        Me.FrecuenciaCard.Visible = False
        '
        'FrecuenciaResp
        '
        Me.FrecuenciaResp.DataPropertyName = "FrecuenciaResp"
        Me.FrecuenciaResp.HeaderText = "FrecuenciaResp"
        Me.FrecuenciaResp.Name = "FrecuenciaResp"
        Me.FrecuenciaResp.ReadOnly = True
        Me.FrecuenciaResp.Visible = False
        '
        'Analitica
        '
        Me.Analitica.DataPropertyName = "Analitica"
        Me.Analitica.HeaderText = "Analitica"
        Me.Analitica.Name = "Analitica"
        Me.Analitica.ReadOnly = True
        Me.Analitica.Visible = False
        '
        'IdUsuario
        '
        Me.IdUsuario.DataPropertyName = "IdUsuario"
        Me.IdUsuario.HeaderText = "IdUsuario"
        Me.IdUsuario.Name = "IdUsuario"
        Me.IdUsuario.ReadOnly = True
        Me.IdUsuario.Visible = False
        '
        'FechaUltimaModificacion
        '
        Me.FechaUltimaModificacion.DataPropertyName = "FechaUltimaModificacion"
        Me.FechaUltimaModificacion.HeaderText = "FechaUltimaModificacion"
        Me.FechaUltimaModificacion.Name = "FechaUltimaModificacion"
        Me.FechaUltimaModificacion.ReadOnly = True
        Me.FechaUltimaModificacion.Visible = False
        '
        'frmDetalleMaestroPacientes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1344, 731)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtBuscador)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.dgvListadoPacientes)
        Me.Controls.Add(Me.dgvHCPaciente)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblRegistroVisitas)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1360, 747)
        Me.Name = "frmDetalleMaestroPacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA DE VISITAS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvHCPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListadoPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRegistroVisitas As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents dgvHCPaciente As DataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IdObraSocial As DataGridViewTextBoxColumn
    Friend WithEvents NombreOS As DataGridViewTextBoxColumn
    Friend WithEvents Activo1 As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuario2 As DataGridViewTextBoxColumn
    Friend WithEvents FechaUltimaModificacion2 As DataGridViewTextBoxColumn
    Friend WithEvents IdHClinica As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Paciente As DataGridViewTextBoxColumn
    Friend WithEvents MotivoConsulta As DataGridViewTextBoxColumn
    Friend WithEvents Diagnostico As DataGridViewTextBoxColumn
    Friend WithEvents Tratamiento As DataGridViewTextBoxColumn
    Friend WithEvents Peso As DataGridViewTextBoxColumn
    Friend WithEvents Altura As DataGridViewTextBoxColumn
    Friend WithEvents PresionArterial As DataGridViewTextBoxColumn
    Friend WithEvents FrecuenciaCard As DataGridViewTextBoxColumn
    Friend WithEvents FrecuenciaResp As DataGridViewTextBoxColumn
    Friend WithEvents Analitica As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents FechaUltimaModificacion As DataGridViewTextBoxColumn
End Class
