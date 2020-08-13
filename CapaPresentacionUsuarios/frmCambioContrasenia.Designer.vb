<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambioContrasenia
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.txtContraNueva2 = New System.Windows.Forms.TextBox()
        Me.txtContraNueva1 = New System.Windows.Forms.TextBox()
        Me.lblContraNueva2 = New System.Windows.Forms.Label()
        Me.lblContraNueva1 = New System.Windows.Forms.Label()
        Me.txtContraVieja = New System.Windows.Forms.TextBox()
        Me.lblContraVieja = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnAceptar.Image = Global.CapaPresentacionUsuarios.My.Resources.Resources.ok
        Me.btnAceptar.Location = New System.Drawing.Point(21, 204)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(121, 47)
        Me.btnAceptar.TabIndex = 5
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
        Me.btnCancelar.Location = New System.Drawing.Point(194, 204)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(121, 47)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNombreUsuario.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtNombreUsuario.Location = New System.Drawing.Point(165, 16)
        Me.txtNombreUsuario.MaxLength = 15
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(95, 27)
        Me.txtNombreUsuario.TabIndex = 1
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblNombreUsuario.Location = New System.Drawing.Point(7, 19)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(133, 19)
        Me.lblNombreUsuario.TabIndex = 10
        Me.lblNombreUsuario.Text = "NOMBRE USUARIO"
        '
        'txtContraNueva2
        '
        Me.txtContraNueva2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtContraNueva2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtContraNueva2.Location = New System.Drawing.Point(165, 112)
        Me.txtContraNueva2.Name = "txtContraNueva2"
        Me.txtContraNueva2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraNueva2.Size = New System.Drawing.Size(159, 27)
        Me.txtContraNueva2.TabIndex = 3
        Me.txtContraNueva2.UseSystemPasswordChar = True
        '
        'txtContraNueva1
        '
        Me.txtContraNueva1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtContraNueva1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtContraNueva1.Location = New System.Drawing.Point(165, 64)
        Me.txtContraNueva1.Name = "txtContraNueva1"
        Me.txtContraNueva1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraNueva1.Size = New System.Drawing.Size(159, 27)
        Me.txtContraNueva1.TabIndex = 2
        Me.txtContraNueva1.UseSystemPasswordChar = True
        '
        'lblContraNueva2
        '
        Me.lblContraNueva2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblContraNueva2.AutoSize = True
        Me.lblContraNueva2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblContraNueva2.Location = New System.Drawing.Point(7, 115)
        Me.lblContraNueva2.Name = "lblContraNueva2"
        Me.lblContraNueva2.Size = New System.Drawing.Size(157, 19)
        Me.lblContraNueva2.TabIndex = 14
        Me.lblContraNueva2.Text = "REPETIR CONTRASEÑA"
        '
        'lblContraNueva1
        '
        Me.lblContraNueva1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblContraNueva1.AutoSize = True
        Me.lblContraNueva1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblContraNueva1.Location = New System.Drawing.Point(7, 67)
        Me.lblContraNueva1.Name = "lblContraNueva1"
        Me.lblContraNueva1.Size = New System.Drawing.Size(148, 19)
        Me.lblContraNueva1.TabIndex = 13
        Me.lblContraNueva1.Text = "NUEVA CONTRASEÑA"
        '
        'txtContraVieja
        '
        Me.txtContraVieja.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtContraVieja.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtContraVieja.Location = New System.Drawing.Point(165, 160)
        Me.txtContraVieja.Name = "txtContraVieja"
        Me.txtContraVieja.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraVieja.Size = New System.Drawing.Size(159, 27)
        Me.txtContraVieja.TabIndex = 4
        Me.txtContraVieja.UseSystemPasswordChar = True
        '
        'lblContraVieja
        '
        Me.lblContraVieja.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblContraVieja.AutoSize = True
        Me.lblContraVieja.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblContraVieja.Location = New System.Drawing.Point(7, 163)
        Me.lblContraVieja.Name = "lblContraVieja"
        Me.lblContraVieja.Size = New System.Drawing.Size(138, 19)
        Me.lblContraVieja.TabIndex = 16
        Me.lblContraVieja.Text = "CONTRASEÑA VIEJA"
        '
        'frmCambioContrasenia
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(346, 263)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtContraVieja)
        Me.Controls.Add(Me.lblContraVieja)
        Me.Controls.Add(Me.txtContraNueva2)
        Me.Controls.Add(Me.txtContraNueva1)
        Me.Controls.Add(Me.lblContraNueva2)
        Me.Controls.Add(Me.lblContraNueva1)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.lblNombreUsuario)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximumSize = New System.Drawing.Size(362, 302)
        Me.MinimumSize = New System.Drawing.Size(362, 302)
        Me.Name = "frmCambioContrasenia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAMBIO DE CONTRASEÑA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents txtContraNueva2 As TextBox
    Friend WithEvents txtContraNueva1 As TextBox
    Friend WithEvents lblContraNueva2 As Label
    Friend WithEvents lblContraNueva1 As Label
    Friend WithEvents txtContraVieja As TextBox
    Friend WithEvents lblContraVieja As Label
End Class
