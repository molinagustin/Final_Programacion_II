<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDialogoLocalidades
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblListadoLocalidades = New System.Windows.Forms.Label()
        Me.cboProvincias = New System.Windows.Forms.ComboBox()
        Me.lblProvincia = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.FechaUltimaModificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProvincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdLocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvLocalidades = New System.Windows.Forms.DataGridView()
        CType(Me.dgvLocalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblListadoLocalidades
        '
        Me.lblListadoLocalidades.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblListadoLocalidades.BackColor = System.Drawing.Color.Transparent
        Me.lblListadoLocalidades.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoLocalidades.ForeColor = System.Drawing.Color.Black
        Me.lblListadoLocalidades.Location = New System.Drawing.Point(11, 9)
        Me.lblListadoLocalidades.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblListadoLocalidades.MaximumSize = New System.Drawing.Size(801, 36)
        Me.lblListadoLocalidades.MinimumSize = New System.Drawing.Size(801, 36)
        Me.lblListadoLocalidades.Name = "lblListadoLocalidades"
        Me.lblListadoLocalidades.Size = New System.Drawing.Size(801, 36)
        Me.lblListadoLocalidades.TabIndex = 0
        Me.lblListadoLocalidades.Text = "LISTADO DE LOCALIDADES"
        Me.lblListadoLocalidades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboProvincias
        '
        Me.cboProvincias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboProvincias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProvincias.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.cboProvincias.FormattingEnabled = True
        Me.cboProvincias.Location = New System.Drawing.Point(602, 84)
        Me.cboProvincias.Margin = New System.Windows.Forms.Padding(2)
        Me.cboProvincias.Name = "cboProvincias"
        Me.cboProvincias.Size = New System.Drawing.Size(210, 29)
        Me.cboProvincias.TabIndex = 1
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.lblProvincia.Location = New System.Drawing.Point(505, 87)
        Me.lblProvincia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(93, 22)
        Me.lblProvincia.TabIndex = 2
        Me.lblProvincia.Text = "PROVINCIA"
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.btnAceptar.Image = Global.CapaPresentacionLocalidades.My.Resources.Resources.ok
        Me.btnAceptar.Location = New System.Drawing.Point(267, 354)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAceptar.MaximumSize = New System.Drawing.Size(111, 47)
        Me.btnAceptar.MinimumSize = New System.Drawing.Size(111, 47)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(111, 47)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.btnCancelar.Image = Global.CapaPresentacionLocalidades.My.Resources.Resources.stop_error
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(457, 354)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.MaximumSize = New System.Drawing.Size(111, 47)
        Me.btnCancelar.MinimumSize = New System.Drawing.Size(111, 47)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(111, 47)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FechaUltimaModificacion
        '
        Me.FechaUltimaModificacion.DataPropertyName = "FechaUltimaModificacion"
        Me.FechaUltimaModificacion.HeaderText = "FechaUltimaModificacion"
        Me.FechaUltimaModificacion.Name = "FechaUltimaModificacion"
        Me.FechaUltimaModificacion.ReadOnly = True
        Me.FechaUltimaModificacion.Visible = False
        '
        'IdUsuario
        '
        Me.IdUsuario.DataPropertyName = "IdUsuario"
        Me.IdUsuario.HeaderText = "IdUsuario"
        Me.IdUsuario.Name = "IdUsuario"
        Me.IdUsuario.ReadOnly = True
        Me.IdUsuario.Visible = False
        '
        'CP
        '
        Me.CP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CP.DataPropertyName = "CP"
        Me.CP.HeaderText = "CODIGO POSTAL"
        Me.CP.Name = "CP"
        Me.CP.ReadOnly = True
        Me.CP.Width = 150
        '
        'Localidad
        '
        Me.Localidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Localidad.DataPropertyName = "Localidad"
        Me.Localidad.HeaderText = "NOMBRE DE LA LOCALIDAD"
        Me.Localidad.Name = "Localidad"
        Me.Localidad.ReadOnly = True
        '
        'IdProvincia
        '
        Me.IdProvincia.DataPropertyName = "IdProvincia"
        Me.IdProvincia.HeaderText = "IdProvincia"
        Me.IdProvincia.Name = "IdProvincia"
        Me.IdProvincia.ReadOnly = True
        Me.IdProvincia.Visible = False
        '
        'IdLocalidad
        '
        Me.IdLocalidad.DataPropertyName = "IdLocalidad"
        Me.IdLocalidad.HeaderText = "IdLocalidad"
        Me.IdLocalidad.Name = "IdLocalidad"
        Me.IdLocalidad.ReadOnly = True
        Me.IdLocalidad.Visible = False
        '
        'dgvLocalidades
        '
        Me.dgvLocalidades.AllowUserToAddRows = False
        Me.dgvLocalidades.AllowUserToDeleteRows = False
        Me.dgvLocalidades.AllowUserToResizeColumns = False
        Me.dgvLocalidades.AllowUserToResizeRows = False
        Me.dgvLocalidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLocalidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvLocalidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLocalidades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLocalidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdLocalidad, Me.IdProvincia, Me.Localidad, Me.CP, Me.IdUsuario, Me.FechaUltimaModificacion})
        Me.dgvLocalidades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvLocalidades.Location = New System.Drawing.Point(10, 117)
        Me.dgvLocalidades.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvLocalidades.MaximumSize = New System.Drawing.Size(803, 224)
        Me.dgvLocalidades.MinimumSize = New System.Drawing.Size(803, 224)
        Me.dgvLocalidades.MultiSelect = False
        Me.dgvLocalidades.Name = "dgvLocalidades"
        Me.dgvLocalidades.ReadOnly = True
        Me.dgvLocalidades.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.dgvLocalidades.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLocalidades.RowTemplate.Height = 24
        Me.dgvLocalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLocalidades.Size = New System.Drawing.Size(803, 224)
        Me.dgvLocalidades.TabIndex = 3
        '
        'frmDialogoLocalidades
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(825, 422)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgvLocalidades)
        Me.Controls.Add(Me.lblProvincia)
        Me.Controls.Add(Me.cboProvincias)
        Me.Controls.Add(Me.lblListadoLocalidades)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(841, 461)
        Me.MinimumSize = New System.Drawing.Size(841, 461)
        Me.Name = "frmDialogoLocalidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOCALIDADES"
        CType(Me.dgvLocalidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblListadoLocalidades As Label
    Friend WithEvents cboProvincias As ComboBox
    Friend WithEvents lblProvincia As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents FechaUltimaModificacion As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents CP As DataGridViewTextBoxColumn
    Friend WithEvents Localidad As DataGridViewTextBoxColumn
    Friend WithEvents IdProvincia As DataGridViewTextBoxColumn
    Friend WithEvents IdLocalidad As DataGridViewTextBoxColumn
    Friend WithEvents dgvLocalidades As DataGridView
End Class
