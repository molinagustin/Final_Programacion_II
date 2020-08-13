<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVistaOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVistaOS))
        Me.dgvListadoOS = New System.Windows.Forms.DataGridView()
        Me.IdObraSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sigla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltimaModificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblVistaOS = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.dgvListadoOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdObraSocial, Me.Sigla, Me.NombreOS, Me.Activo, Me.IdUsuario, Me.FechaUltimaModificacion})
        Me.dgvListadoOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvListadoOS.Location = New System.Drawing.Point(12, 211)
        Me.dgvListadoOS.MultiSelect = False
        Me.dgvListadoOS.Name = "dgvListadoOS"
        Me.dgvListadoOS.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoOS.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListadoOS.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.dgvListadoOS.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListadoOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoOS.Size = New System.Drawing.Size(961, 450)
        Me.dgvListadoOS.TabIndex = 0
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
        'lblVistaOS
        '
        Me.lblVistaOS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVistaOS.BackColor = System.Drawing.Color.Transparent
        Me.lblVistaOS.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVistaOS.Location = New System.Drawing.Point(12, 9)
        Me.lblVistaOS.Name = "lblVistaOS"
        Me.lblVistaOS.Size = New System.Drawing.Size(1121, 33)
        Me.lblVistaOS.TabIndex = 1
        Me.lblVistaOS.Text = "VISTA DE OBRAS SOCIALES"
        Me.lblVistaOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnSalir.Image = Global.CapaPresentacionObrasSociales.My.Resources.Resources.back
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
        Me.btnAgregar.Image = Global.CapaPresentacionObrasSociales.My.Resources.Resources.insert
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(994, 539)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(139, 47)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "     AGREGAR NUEVA"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'frmVistaOS
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1145, 719)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblVistaOS)
        Me.Controls.Add(Me.dgvListadoOS)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1161, 735)
        Me.Name = "frmVistaOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA OBRAS SOCIALES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvListadoOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvListadoOS As DataGridView
    Friend WithEvents lblVistaOS As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents IdObraSocial As DataGridViewTextBoxColumn
    Friend WithEvents Sigla As DataGridViewTextBoxColumn
    Friend WithEvents NombreOS As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents FechaUltimaModificacion As DataGridViewTextBoxColumn
End Class
