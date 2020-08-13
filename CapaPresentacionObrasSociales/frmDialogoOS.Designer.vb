<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogoOS
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblListadoOS = New System.Windows.Forms.Label()
        Me.dgvListadoOS = New System.Windows.Forms.DataGridView()
        Me.IdObraSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sigla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltimaModificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvListadoOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnCancelar.Image = Global.CapaPresentacionObrasSociales.My.Resources.Resources.stop_error
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(457, 354)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.MaximumSize = New System.Drawing.Size(121, 47)
        Me.btnCancelar.MinimumSize = New System.Drawing.Size(121, 47)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(121, 47)
        Me.btnCancelar.TabIndex = 11
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
        Me.btnAceptar.Image = Global.CapaPresentacionObrasSociales.My.Resources.Resources.ok
        Me.btnAceptar.Location = New System.Drawing.Point(267, 354)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAceptar.MaximumSize = New System.Drawing.Size(121, 47)
        Me.btnAceptar.MinimumSize = New System.Drawing.Size(121, 47)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(121, 47)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblListadoOS
        '
        Me.lblListadoOS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblListadoOS.BackColor = System.Drawing.Color.Transparent
        Me.lblListadoOS.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoOS.ForeColor = System.Drawing.Color.Black
        Me.lblListadoOS.Location = New System.Drawing.Point(11, 9)
        Me.lblListadoOS.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblListadoOS.MaximumSize = New System.Drawing.Size(801, 36)
        Me.lblListadoOS.MinimumSize = New System.Drawing.Size(801, 36)
        Me.lblListadoOS.Name = "lblListadoOS"
        Me.lblListadoOS.Size = New System.Drawing.Size(801, 36)
        Me.lblListadoOS.TabIndex = 6
        Me.lblListadoOS.Text = "LISTADO DE OBRAS SOCIALES"
        Me.lblListadoOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvListadoOS
        '
        Me.dgvListadoOS.AllowUserToAddRows = False
        Me.dgvListadoOS.AllowUserToDeleteRows = False
        Me.dgvListadoOS.AllowUserToResizeColumns = False
        Me.dgvListadoOS.AllowUserToResizeRows = False
        Me.dgvListadoOS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListadoOS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListadoOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdObraSocial, Me.Sigla, Me.NombreOS, Me.Activo, Me.IdUsuario, Me.FechaUltimaModificacion})
        Me.dgvListadoOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvListadoOS.Location = New System.Drawing.Point(10, 117)
        Me.dgvListadoOS.MaximumSize = New System.Drawing.Size(803, 224)
        Me.dgvListadoOS.MinimumSize = New System.Drawing.Size(803, 224)
        Me.dgvListadoOS.MultiSelect = False
        Me.dgvListadoOS.Name = "dgvListadoOS"
        Me.dgvListadoOS.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoOS.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListadoOS.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.dgvListadoOS.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListadoOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoOS.Size = New System.Drawing.Size(803, 224)
        Me.dgvListadoOS.TabIndex = 12
        '
        'IdObraSocial
        '
        Me.IdObraSocial.DataPropertyName = "IdObraSocial"
        Me.IdObraSocial.HeaderText = "IdObraSocial"
        Me.IdObraSocial.Name = "IdObraSocial"
        Me.IdObraSocial.ReadOnly = True
        Me.IdObraSocial.Visible = False
        '
        'Sigla
        '
        Me.Sigla.DataPropertyName = "Sigla"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Sigla.DefaultCellStyle = DataGridViewCellStyle2
        Me.Sigla.HeaderText = "SIGLA"
        Me.Sigla.MinimumWidth = 250
        Me.Sigla.Name = "Sigla"
        Me.Sigla.ReadOnly = True
        Me.Sigla.Width = 250
        '
        'NombreOS
        '
        Me.NombreOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreOS.DataPropertyName = "NombreOS"
        Me.NombreOS.HeaderText = "NOMBRE COMPLETO"
        Me.NombreOS.MinimumWidth = 200
        Me.NombreOS.Name = "NombreOS"
        Me.NombreOS.ReadOnly = True
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
        Me.IdUsuario.DataPropertyName = "IdUsuario"
        Me.IdUsuario.HeaderText = "ID USUARIO"
        Me.IdUsuario.MinimumWidth = 100
        Me.IdUsuario.Name = "IdUsuario"
        Me.IdUsuario.ReadOnly = True
        Me.IdUsuario.Visible = False
        Me.IdUsuario.Width = 250
        '
        'FechaUltimaModificacion
        '
        Me.FechaUltimaModificacion.DataPropertyName = "FechaUltimaModificacion"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FechaUltimaModificacion.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaUltimaModificacion.HeaderText = "FECHA ULTIMA MODIFICACION"
        Me.FechaUltimaModificacion.MinimumWidth = 250
        Me.FechaUltimaModificacion.Name = "FechaUltimaModificacion"
        Me.FechaUltimaModificacion.ReadOnly = True
        Me.FechaUltimaModificacion.Visible = False
        Me.FechaUltimaModificacion.Width = 250
        '
        'frmDialogoOS
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(825, 422)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvListadoOS)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblListadoOS)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximumSize = New System.Drawing.Size(841, 461)
        Me.MinimumSize = New System.Drawing.Size(841, 461)
        Me.Name = "frmDialogoOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OBRAS SOCIALES"
        CType(Me.dgvListadoOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblListadoOS As Label
    Friend WithEvents dgvListadoOS As DataGridView
    Friend WithEvents IdObraSocial As DataGridViewTextBoxColumn
    Friend WithEvents Sigla As DataGridViewTextBoxColumn
    Friend WithEvents NombreOS As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents FechaUltimaModificacion As DataGridViewTextBoxColumn
End Class
