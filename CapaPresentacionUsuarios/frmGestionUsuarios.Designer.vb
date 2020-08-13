<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionUsuarios
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
        Me.lblGestionUsuario = New System.Windows.Forms.Label()
        Me.lblNombreCompleto = New System.Windows.Forms.Label()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lblContra1 = New System.Windows.Forms.Label()
        Me.lblContra2 = New System.Windows.Forms.Label()
        Me.lblTipoUsuario = New System.Windows.Forms.Label()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtContra1 = New System.Windows.Forms.TextBox()
        Me.txtContra2 = New System.Windows.Forms.TextBox()
        Me.cboTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCambiarContra = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGestionUsuario
        '
        Me.lblGestionUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGestionUsuario.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestionUsuario.Location = New System.Drawing.Point(12, 9)
        Me.lblGestionUsuario.Name = "lblGestionUsuario"
        Me.lblGestionUsuario.Size = New System.Drawing.Size(692, 33)
        Me.lblGestionUsuario.TabIndex = 2
        Me.lblGestionUsuario.Text = "USUARIO"
        Me.lblGestionUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombreCompleto
        '
        Me.lblNombreCompleto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNombreCompleto.AutoSize = True
        Me.lblNombreCompleto.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblNombreCompleto.Location = New System.Drawing.Point(136, 118)
        Me.lblNombreCompleto.Name = "lblNombreCompleto"
        Me.lblNombreCompleto.Size = New System.Drawing.Size(214, 19)
        Me.lblNombreCompleto.TabIndex = 3
        Me.lblNombreCompleto.Text = "NOMBRE COMPLETO PERSONA"
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblNombreUsuario.Location = New System.Drawing.Point(136, 172)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(133, 19)
        Me.lblNombreUsuario.TabIndex = 4
        Me.lblNombreUsuario.Text = "NOMBRE USUARIO"
        '
        'lblContra1
        '
        Me.lblContra1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblContra1.AutoSize = True
        Me.lblContra1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblContra1.Location = New System.Drawing.Point(136, 226)
        Me.lblContra1.Name = "lblContra1"
        Me.lblContra1.Size = New System.Drawing.Size(99, 19)
        Me.lblContra1.TabIndex = 5
        Me.lblContra1.Text = "CONTRASEÑA"
        '
        'lblContra2
        '
        Me.lblContra2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblContra2.AutoSize = True
        Me.lblContra2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblContra2.Location = New System.Drawing.Point(136, 280)
        Me.lblContra2.Name = "lblContra2"
        Me.lblContra2.Size = New System.Drawing.Size(157, 19)
        Me.lblContra2.TabIndex = 6
        Me.lblContra2.Text = "REPETIR CONTRASEÑA"
        '
        'lblTipoUsuario
        '
        Me.lblTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTipoUsuario.AutoSize = True
        Me.lblTipoUsuario.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblTipoUsuario.Location = New System.Drawing.Point(136, 334)
        Me.lblTipoUsuario.Name = "lblTipoUsuario"
        Me.lblTipoUsuario.Size = New System.Drawing.Size(104, 19)
        Me.lblTipoUsuario.TabIndex = 7
        Me.lblTipoUsuario.Text = "TIPO USUARIO"
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtNombreCompleto.Location = New System.Drawing.Point(356, 115)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(256, 27)
        Me.txtNombreCompleto.TabIndex = 1
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNombreUsuario.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtNombreUsuario.Location = New System.Drawing.Point(356, 169)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(159, 27)
        Me.txtNombreUsuario.TabIndex = 2
        '
        'txtContra1
        '
        Me.txtContra1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtContra1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtContra1.Location = New System.Drawing.Point(356, 223)
        Me.txtContra1.Name = "txtContra1"
        Me.txtContra1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContra1.Size = New System.Drawing.Size(159, 27)
        Me.txtContra1.TabIndex = 3
        Me.txtContra1.UseSystemPasswordChar = True
        '
        'txtContra2
        '
        Me.txtContra2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtContra2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtContra2.Location = New System.Drawing.Point(356, 277)
        Me.txtContra2.Name = "txtContra2"
        Me.txtContra2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContra2.Size = New System.Drawing.Size(159, 27)
        Me.txtContra2.TabIndex = 4
        Me.txtContra2.UseSystemPasswordChar = True
        '
        'cboTipoUsuario
        '
        Me.cboTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboTipoUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboTipoUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoUsuario.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cboTipoUsuario.FormattingEnabled = True
        Me.cboTipoUsuario.Location = New System.Drawing.Point(356, 331)
        Me.cboTipoUsuario.Name = "cboTipoUsuario"
        Me.cboTipoUsuario.Size = New System.Drawing.Size(139, 27)
        Me.cboTipoUsuario.TabIndex = 5
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnAceptar.Image = Global.CapaPresentacionUsuarios.My.Resources.Resources.ok
        Me.btnAceptar.Location = New System.Drawing.Point(204, 434)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(121, 47)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnCancelar.Image = Global.CapaPresentacionUsuarios.My.Resources.Resources.stop_error
        Me.btnCancelar.Location = New System.Drawing.Point(393, 434)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(121, 47)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnCambiarContra
        '
        Me.btnCambiarContra.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCambiarContra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCambiarContra.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnCambiarContra.Image = Global.CapaPresentacionUsuarios.My.Resources.Resources.dbedit
        Me.btnCambiarContra.Location = New System.Drawing.Point(521, 226)
        Me.btnCambiarContra.Name = "btnCambiarContra"
        Me.btnCambiarContra.Size = New System.Drawing.Size(140, 71)
        Me.btnCambiarContra.TabIndex = 8
        Me.btnCambiarContra.Text = "CAMBIAR CONTRASEÑA"
        Me.btnCambiarContra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCambiarContra.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnModificar.Image = Global.CapaPresentacionUsuarios.My.Resources.Resources.dbedit
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(575, 381)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(139, 47)
        Me.btnModificar.TabIndex = 6
        Me.btnModificar.Text = "MODIFICAR REGISTRO"
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBaja.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnBaja.Image = Global.CapaPresentacionUsuarios.My.Resources.Resources.user_remove
        Me.btnBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBaja.Location = New System.Drawing.Point(575, 434)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(139, 47)
        Me.btnBaja.TabIndex = 7
        Me.btnBaja.Text = "BAJA REGISTRO"
        Me.btnBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'frmGestionUsuarios
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(726, 546)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnCambiarContra)
        Me.Controls.Add(Me.cboTipoUsuario)
        Me.Controls.Add(Me.txtContra2)
        Me.Controls.Add(Me.txtContra1)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.txtNombreCompleto)
        Me.Controls.Add(Me.lblTipoUsuario)
        Me.Controls.Add(Me.lblContra2)
        Me.Controls.Add(Me.lblContra1)
        Me.Controls.Add(Me.lblNombreUsuario)
        Me.Controls.Add(Me.lblNombreCompleto)
        Me.Controls.Add(Me.lblGestionUsuario)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximumSize = New System.Drawing.Size(742, 585)
        Me.MinimumSize = New System.Drawing.Size(742, 585)
        Me.Name = "frmGestionUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USUARIOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblGestionUsuario As Label
    Friend WithEvents lblNombreCompleto As Label
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents lblContra1 As Label
    Friend WithEvents lblContra2 As Label
    Friend WithEvents lblTipoUsuario As Label
    Friend WithEvents txtNombreCompleto As TextBox
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents txtContra1 As TextBox
    Friend WithEvents txtContra2 As TextBox
    Friend WithEvents cboTipoUsuario As ComboBox
    Friend WithEvents btnCambiarContra As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBaja As Button
End Class
