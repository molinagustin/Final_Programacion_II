<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVistaLocalidades
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVistaLocalidades))
        Me.dgvListadoLocalidades = New System.Windows.Forms.DataGridView()
        Me.IdLocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProvincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltimaModificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblVistaLocal = New System.Windows.Forms.Label()
        Me.lblProvincia = New System.Windows.Forms.Label()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.dgvListadoLocalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListadoLocalidades
        '
        Me.dgvListadoLocalidades.AllowUserToAddRows = False
        Me.dgvListadoLocalidades.AllowUserToDeleteRows = False
        Me.dgvListadoLocalidades.AllowUserToResizeColumns = False
        Me.dgvListadoLocalidades.AllowUserToResizeRows = False
        Me.dgvListadoLocalidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListadoLocalidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListadoLocalidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoLocalidades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoLocalidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdLocalidad, Me.IdProvincia, Me.Localidad, Me.CP, Me.IdUsuario, Me.FechaUltimaModificacion})
        Me.dgvListadoLocalidades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvListadoLocalidades.Location = New System.Drawing.Point(12, 211)
        Me.dgvListadoLocalidades.MultiSelect = False
        Me.dgvListadoLocalidades.Name = "dgvListadoLocalidades"
        Me.dgvListadoLocalidades.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListadoLocalidades.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListadoLocalidades.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.dgvListadoLocalidades.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListadoLocalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoLocalidades.Size = New System.Drawing.Size(961, 450)
        Me.dgvListadoLocalidades.TabIndex = 0
        '
        'IdLocalidad
        '
        Me.IdLocalidad.DataPropertyName = "IdLocalidad"
        Me.IdLocalidad.HeaderText = "IdLocalidad"
        Me.IdLocalidad.Name = "IdLocalidad"
        Me.IdLocalidad.ReadOnly = True
        Me.IdLocalidad.Visible = False
        '
        'IdProvincia
        '
        Me.IdProvincia.DataPropertyName = "IdProvincia"
        Me.IdProvincia.HeaderText = "IdProvincia"
        Me.IdProvincia.MinimumWidth = 220
        Me.IdProvincia.Name = "IdProvincia"
        Me.IdProvincia.ReadOnly = True
        Me.IdProvincia.Visible = False
        Me.IdProvincia.Width = 263
        '
        'Localidad
        '
        Me.Localidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Localidad.DataPropertyName = "Localidad"
        Me.Localidad.HeaderText = "NOMBRE LOCALIDAD"
        Me.Localidad.MinimumWidth = 170
        Me.Localidad.Name = "Localidad"
        Me.Localidad.ReadOnly = True
        '
        'CP
        '
        Me.CP.DataPropertyName = "CP"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CP.DefaultCellStyle = DataGridViewCellStyle2
        Me.CP.HeaderText = "CODIGO POSTAL"
        Me.CP.MinimumWidth = 200
        Me.CP.Name = "CP"
        Me.CP.ReadOnly = True
        Me.CP.Width = 200
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FechaUltimaModificacion.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaUltimaModificacion.HeaderText = "FECHA ULTIMA MODIFICACION"
        Me.FechaUltimaModificacion.MinimumWidth = 130
        Me.FechaUltimaModificacion.Name = "FechaUltimaModificacion"
        Me.FechaUltimaModificacion.ReadOnly = True
        Me.FechaUltimaModificacion.Visible = False
        '
        'lblVistaLocal
        '
        Me.lblVistaLocal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVistaLocal.BackColor = System.Drawing.Color.Transparent
        Me.lblVistaLocal.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVistaLocal.Location = New System.Drawing.Point(12, 9)
        Me.lblVistaLocal.Name = "lblVistaLocal"
        Me.lblVistaLocal.Size = New System.Drawing.Size(1121, 33)
        Me.lblVistaLocal.TabIndex = 1
        Me.lblVistaLocal.Text = "VISTA DE LOCALIDADES"
        Me.lblVistaLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProvincia
        '
        Me.lblProvincia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblProvincia.Location = New System.Drawing.Point(656, 171)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(100, 23)
        Me.lblProvincia.TabIndex = 7
        Me.lblProvincia.Text = "PROVINCIA"
        '
        'cboProvincia
        '
        Me.cboProvincia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProvincia.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(762, 168)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(211, 31)
        Me.cboProvincia.TabIndex = 8
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnSalir.Image = Global.CapaPresentacionLocalidades.My.Resources.Resources.back
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(1004, 622)
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
        Me.btnAgregar.Image = Global.CapaPresentacionLocalidades.My.Resources.Resources.insert
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(994, 539)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(139, 47)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "     AGREGAR NUEVA"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'frmVistaLocalidades
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1145, 719)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboProvincia)
        Me.Controls.Add(Me.lblProvincia)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblVistaLocal)
        Me.Controls.Add(Me.dgvListadoLocalidades)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1161, 735)
        Me.Name = "frmVistaLocalidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA LOCALIDADES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvListadoLocalidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvListadoLocalidades As DataGridView
    Friend WithEvents lblVistaLocal As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblProvincia As Label
    Friend WithEvents cboProvincia As ComboBox
    Friend WithEvents IdLocalidad As DataGridViewTextBoxColumn
    Friend WithEvents IdProvincia As DataGridViewTextBoxColumn
    Friend WithEvents Localidad As DataGridViewTextBoxColumn
    Friend WithEvents CP As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents FechaUltimaModificacion As DataGridViewTextBoxColumn
End Class
