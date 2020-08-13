<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVistaPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVistaPrincipal))
        Me.mstOpcionesVistaPrincipal = New System.Windows.Forms.MenuStrip()
        Me.pbxImagenConsultorio = New System.Windows.Forms.PictureBox()
        Me.PACIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROFESIONALESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTAToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TURNOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTAToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HISTORIASCLINICASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTAToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NUEVAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OBRASSOCIALESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTAToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOCALIDADESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTAToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.USUARIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTAToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.REACTIVACIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PACIENTESToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROFESIONALESToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OBRASSOCIALESToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.USUARIOSToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VENTANASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstOpcionesVistaPrincipal.SuspendLayout()
        CType(Me.pbxImagenConsultorio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mstOpcionesVistaPrincipal
        '
        Me.mstOpcionesVistaPrincipal.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.mstOpcionesVistaPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PACIENTESToolStripMenuItem, Me.PROFESIONALESToolStripMenuItem, Me.TURNOSToolStripMenuItem, Me.HISTORIASCLINICASToolStripMenuItem, Me.OBRASSOCIALESToolStripMenuItem, Me.LOCALIDADESToolStripMenuItem, Me.USUARIOSToolStripMenuItem, Me.VENTANASToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.mstOpcionesVistaPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mstOpcionesVistaPrincipal.MdiWindowListItem = Me.VENTANASToolStripMenuItem
        Me.mstOpcionesVistaPrincipal.Name = "mstOpcionesVistaPrincipal"
        Me.mstOpcionesVistaPrincipal.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mstOpcionesVistaPrincipal.Size = New System.Drawing.Size(1399, 35)
        Me.mstOpcionesVistaPrincipal.TabIndex = 1
        Me.mstOpcionesVistaPrincipal.Text = "MenuStrip1"
        '
        'pbxImagenConsultorio
        '
        Me.pbxImagenConsultorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbxImagenConsultorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxImagenConsultorio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxImagenConsultorio.Image = Global.CapaPresentacionGenerica.My.Resources.Resources.LogoConsultorio1_Modificado
        Me.pbxImagenConsultorio.Location = New System.Drawing.Point(0, 35)
        Me.pbxImagenConsultorio.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxImagenConsultorio.Name = "pbxImagenConsultorio"
        Me.pbxImagenConsultorio.Size = New System.Drawing.Size(1399, 716)
        Me.pbxImagenConsultorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxImagenConsultorio.TabIndex = 3
        Me.pbxImagenConsultorio.TabStop = False
        '
        'PACIENTESToolStripMenuItem
        '
        Me.PACIENTESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaToolStripMenuItem})
        Me.PACIENTESToolStripMenuItem.Image = Global.CapaPresentacionGenerica.My.Resources.Resources.folders16
        Me.PACIENTESToolStripMenuItem.Name = "PACIENTESToolStripMenuItem"
        Me.PACIENTESToolStripMenuItem.Size = New System.Drawing.Size(223, 31)
        Me.PACIENTESToolStripMenuItem.Text = "HISTORIAS CLINICAS"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(178, 32)
        Me.ConsultaToolStripMenuItem.Text = "CONSULTA"
        '
        'PROFESIONALESToolStripMenuItem
        '
        Me.PROFESIONALESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONSULTAToolStripMenuItem1})
        Me.PROFESIONALESToolStripMenuItem.Image = Global.CapaPresentacionGenerica.My.Resources.Resources.group_user16_h1
        Me.PROFESIONALESToolStripMenuItem.Name = "PROFESIONALESToolStripMenuItem"
        Me.PROFESIONALESToolStripMenuItem.Size = New System.Drawing.Size(187, 31)
        Me.PROFESIONALESToolStripMenuItem.Text = "PROFESIONALES"
        '
        'CONSULTAToolStripMenuItem1
        '
        Me.CONSULTAToolStripMenuItem1.Name = "CONSULTAToolStripMenuItem1"
        Me.CONSULTAToolStripMenuItem1.Size = New System.Drawing.Size(178, 32)
        Me.CONSULTAToolStripMenuItem1.Text = "CONSULTA"
        '
        'TURNOSToolStripMenuItem
        '
        Me.TURNOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONSULTAToolStripMenuItem4})
        Me.TURNOSToolStripMenuItem.Image = Global.CapaPresentacionGenerica.My.Resources.Resources.phones
        Me.TURNOSToolStripMenuItem.Name = "TURNOSToolStripMenuItem"
        Me.TURNOSToolStripMenuItem.Size = New System.Drawing.Size(116, 31)
        Me.TURNOSToolStripMenuItem.Text = "TURNOS"
        '
        'CONSULTAToolStripMenuItem4
        '
        Me.CONSULTAToolStripMenuItem4.Name = "CONSULTAToolStripMenuItem4"
        Me.CONSULTAToolStripMenuItem4.Size = New System.Drawing.Size(178, 32)
        Me.CONSULTAToolStripMenuItem4.Text = "CONSULTA"
        '
        'HISTORIASCLINICASToolStripMenuItem
        '
        Me.HISTORIASCLINICASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONSULTAToolStripMenuItem7, Me.NUEVAToolStripMenuItem})
        Me.HISTORIASCLINICASToolStripMenuItem.Image = Global.CapaPresentacionGenerica.My.Resources.Resources.cal
        Me.HISTORIASCLINICASToolStripMenuItem.Name = "HISTORIASCLINICASToolStripMenuItem"
        Me.HISTORIASCLINICASToolStripMenuItem.Size = New System.Drawing.Size(106, 31)
        Me.HISTORIASCLINICASToolStripMenuItem.Text = "VISITAS"
        '
        'CONSULTAToolStripMenuItem7
        '
        Me.CONSULTAToolStripMenuItem7.Name = "CONSULTAToolStripMenuItem7"
        Me.CONSULTAToolStripMenuItem7.Size = New System.Drawing.Size(178, 32)
        Me.CONSULTAToolStripMenuItem7.Text = "CONSULTA"
        '
        'NUEVAToolStripMenuItem
        '
        Me.NUEVAToolStripMenuItem.Name = "NUEVAToolStripMenuItem"
        Me.NUEVAToolStripMenuItem.Size = New System.Drawing.Size(178, 32)
        Me.NUEVAToolStripMenuItem.Text = "NUEVA"
        '
        'OBRASSOCIALESToolStripMenuItem
        '
        Me.OBRASSOCIALESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONSULTAToolStripMenuItem8})
        Me.OBRASSOCIALESToolStripMenuItem.Image = Global.CapaPresentacionGenerica.My.Resources.Resources.favorites16
        Me.OBRASSOCIALESToolStripMenuItem.Name = "OBRASSOCIALESToolStripMenuItem"
        Me.OBRASSOCIALESToolStripMenuItem.Size = New System.Drawing.Size(193, 31)
        Me.OBRASSOCIALESToolStripMenuItem.Text = "OBRAS SOCIALES"
        '
        'CONSULTAToolStripMenuItem8
        '
        Me.CONSULTAToolStripMenuItem8.Name = "CONSULTAToolStripMenuItem8"
        Me.CONSULTAToolStripMenuItem8.Size = New System.Drawing.Size(178, 32)
        Me.CONSULTAToolStripMenuItem8.Text = "CONSULTA"
        '
        'LOCALIDADESToolStripMenuItem
        '
        Me.LOCALIDADESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONSULTAToolStripMenuItem3})
        Me.LOCALIDADESToolStripMenuItem.Image = Global.CapaPresentacionGenerica.My.Resources.Resources.web
        Me.LOCALIDADESToolStripMenuItem.Name = "LOCALIDADESToolStripMenuItem"
        Me.LOCALIDADESToolStripMenuItem.Size = New System.Drawing.Size(166, 31)
        Me.LOCALIDADESToolStripMenuItem.Text = "LOCALIDADES"
        '
        'CONSULTAToolStripMenuItem3
        '
        Me.CONSULTAToolStripMenuItem3.Name = "CONSULTAToolStripMenuItem3"
        Me.CONSULTAToolStripMenuItem3.Size = New System.Drawing.Size(178, 32)
        Me.CONSULTAToolStripMenuItem3.Text = "CONSULTA"
        '
        'USUARIOSToolStripMenuItem
        '
        Me.USUARIOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONSULTAToolStripMenuItem2, Me.REACTIVACIONToolStripMenuItem})
        Me.USUARIOSToolStripMenuItem.Image = Global.CapaPresentacionGenerica.My.Resources.Resources.db_sql_procedure16
        Me.USUARIOSToolStripMenuItem.Name = "USUARIOSToolStripMenuItem"
        Me.USUARIOSToolStripMenuItem.Size = New System.Drawing.Size(134, 31)
        Me.USUARIOSToolStripMenuItem.Text = "USUARIOS"
        '
        'CONSULTAToolStripMenuItem2
        '
        Me.CONSULTAToolStripMenuItem2.Name = "CONSULTAToolStripMenuItem2"
        Me.CONSULTAToolStripMenuItem2.Size = New System.Drawing.Size(220, 32)
        Me.CONSULTAToolStripMenuItem2.Text = "CONSULTA"
        '
        'REACTIVACIONToolStripMenuItem
        '
        Me.REACTIVACIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PACIENTESToolStripMenuItem1, Me.PROFESIONALESToolStripMenuItem1, Me.OBRASSOCIALESToolStripMenuItem1, Me.USUARIOSToolStripMenuItem1})
        Me.REACTIVACIONToolStripMenuItem.Name = "REACTIVACIONToolStripMenuItem"
        Me.REACTIVACIONToolStripMenuItem.Size = New System.Drawing.Size(220, 32)
        Me.REACTIVACIONToolStripMenuItem.Text = "REACTIVACION"
        '
        'PACIENTESToolStripMenuItem1
        '
        Me.PACIENTESToolStripMenuItem1.Name = "PACIENTESToolStripMenuItem1"
        Me.PACIENTESToolStripMenuItem1.Size = New System.Drawing.Size(237, 32)
        Me.PACIENTESToolStripMenuItem1.Text = "PACIENTES"
        '
        'PROFESIONALESToolStripMenuItem1
        '
        Me.PROFESIONALESToolStripMenuItem1.Name = "PROFESIONALESToolStripMenuItem1"
        Me.PROFESIONALESToolStripMenuItem1.Size = New System.Drawing.Size(237, 32)
        Me.PROFESIONALESToolStripMenuItem1.Text = "PROFESIONALES"
        '
        'OBRASSOCIALESToolStripMenuItem1
        '
        Me.OBRASSOCIALESToolStripMenuItem1.Name = "OBRASSOCIALESToolStripMenuItem1"
        Me.OBRASSOCIALESToolStripMenuItem1.Size = New System.Drawing.Size(237, 32)
        Me.OBRASSOCIALESToolStripMenuItem1.Text = "OBRAS SOCIALES"
        '
        'USUARIOSToolStripMenuItem1
        '
        Me.USUARIOSToolStripMenuItem1.Name = "USUARIOSToolStripMenuItem1"
        Me.USUARIOSToolStripMenuItem1.Size = New System.Drawing.Size(237, 32)
        Me.USUARIOSToolStripMenuItem1.Text = "USUARIOS"
        '
        'VENTANASToolStripMenuItem
        '
        Me.VENTANASToolStripMenuItem.Image = Global.CapaPresentacionGenerica.My.Resources.Resources.windows
        Me.VENTANASToolStripMenuItem.Name = "VENTANASToolStripMenuItem"
        Me.VENTANASToolStripMenuItem.Size = New System.Drawing.Size(136, 31)
        Me.VENTANASToolStripMenuItem.Text = "VENTANAS"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Image = Global.CapaPresentacionGenerica.My.Resources.Resources.delete_x16
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(79, 31)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'frmVistaPrincipal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1399, 751)
        Me.Controls.Add(Me.pbxImagenConsultorio)
        Me.Controls.Add(Me.mstOpcionesVistaPrincipal)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mstOpcionesVistaPrincipal
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MinimumSize = New System.Drawing.Size(1360, 790)
        Me.Name = "frmVistaPrincipal"
        Me.Text = "GESTION CONSULTORIO MEDICO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mstOpcionesVistaPrincipal.ResumeLayout(False)
        Me.mstOpcionesVistaPrincipal.PerformLayout()
        CType(Me.pbxImagenConsultorio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mstOpcionesVistaPrincipal As MenuStrip
    Friend WithEvents PACIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VENTANASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROFESIONALESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTAToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents USUARIOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTAToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents REACTIVACIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PACIENTESToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PROFESIONALESToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents USUARIOSToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TURNOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HISTORIASCLINICASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTAToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents NUEVAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OBRASSOCIALESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTAToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents LOCALIDADESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTAToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents OBRASSOCIALESToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CONSULTAToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents pbxImagenConsultorio As PictureBox
End Class
