<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MASTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterTokoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdmastToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABSENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BARANGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTBARANGAKTIVAAUPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTBARANGDCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTBARANGNONAKTIVAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USULANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RENCAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PBATKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProsesPBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanBrokolyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CetakQtyPeritemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CetakQtyPeritemDCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LISTINGSURATJALANSJToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.MASTERToolStripMenuItem, Me.ABSENToolStripMenuItem, Me.BARANGToolStripMenuItem, Me.USULANToolStripMenuItem, Me.PBATKToolStripMenuItem, Me.LAPORANToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(875, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MASTERToolStripMenuItem
        '
        Me.MASTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterTokoToolStripMenuItem, Me.ProdmastToolStripMenuItem})
        Me.MASTERToolStripMenuItem.Name = "MASTERToolStripMenuItem"
        Me.MASTERToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.MASTERToolStripMenuItem.Text = "MASTER"
        '
        'MasterTokoToolStripMenuItem
        '
        Me.MasterTokoToolStripMenuItem.Name = "MasterTokoToolStripMenuItem"
        Me.MasterTokoToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.MasterTokoToolStripMenuItem.Text = "Master Toko"
        '
        'ProdmastToolStripMenuItem
        '
        Me.ProdmastToolStripMenuItem.Name = "ProdmastToolStripMenuItem"
        Me.ProdmastToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ProdmastToolStripMenuItem.Text = "Prodmast"
        '
        'ABSENToolStripMenuItem
        '
        Me.ABSENToolStripMenuItem.Name = "ABSENToolStripMenuItem"
        Me.ABSENToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.ABSENToolStripMenuItem.Text = "ABSEN"
        '
        'BARANGToolStripMenuItem
        '
        Me.BARANGToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REPORTBARANGAKTIVAAUPToolStripMenuItem, Me.REPORTBARANGDCToolStripMenuItem, Me.REPORTBARANGNONAKTIVAToolStripMenuItem, Me.LISTINGSURATJALANSJToolStripMenuItem})
        Me.BARANGToolStripMenuItem.Name = "BARANGToolStripMenuItem"
        Me.BARANGToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.BARANGToolStripMenuItem.Text = "BARANG"
        '
        'REPORTBARANGAKTIVAAUPToolStripMenuItem
        '
        Me.REPORTBARANGAKTIVAAUPToolStripMenuItem.Name = "REPORTBARANGAKTIVAAUPToolStripMenuItem"
        Me.REPORTBARANGAKTIVAAUPToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.REPORTBARANGAKTIVAAUPToolStripMenuItem.Text = "REPORT BARANG AKTIVA AUP"
        '
        'REPORTBARANGDCToolStripMenuItem
        '
        Me.REPORTBARANGDCToolStripMenuItem.Name = "REPORTBARANGDCToolStripMenuItem"
        Me.REPORTBARANGDCToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.REPORTBARANGDCToolStripMenuItem.Text = "REPORT BARANG AKTIVA DC"
        '
        'REPORTBARANGNONAKTIVAToolStripMenuItem
        '
        Me.REPORTBARANGNONAKTIVAToolStripMenuItem.Name = "REPORTBARANGNONAKTIVAToolStripMenuItem"
        Me.REPORTBARANGNONAKTIVAToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.REPORTBARANGNONAKTIVAToolStripMenuItem.Text = "REPORT BARANG NON AKTIVA"
        '
        'USULANToolStripMenuItem
        '
        Me.USULANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RENCAToolStripMenuItem})
        Me.USULANToolStripMenuItem.Name = "USULANToolStripMenuItem"
        Me.USULANToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.USULANToolStripMenuItem.Text = "USULAN "
        '
        'RENCAToolStripMenuItem
        '
        Me.RENCAToolStripMenuItem.Name = "RENCAToolStripMenuItem"
        Me.RENCAToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.RENCAToolStripMenuItem.Text = "LISTING USULAN"
        '
        'PBATKToolStripMenuItem
        '
        Me.PBATKToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProsesPBToolStripMenuItem})
        Me.PBATKToolStripMenuItem.Name = "PBATKToolStripMenuItem"
        Me.PBATKToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.PBATKToolStripMenuItem.Text = "PBATK"
        '
        'ProsesPBToolStripMenuItem
        '
        Me.ProsesPBToolStripMenuItem.Name = "ProsesPBToolStripMenuItem"
        Me.ProsesPBToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ProsesPBToolStripMenuItem.Text = "Proses PB ATK"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanBrokolyToolStripMenuItem, Me.CetakQtyPeritemToolStripMenuItem, Me.CetakQtyPeritemDCToolStripMenuItem})
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.LAPORANToolStripMenuItem.Text = "LAPORAN"
        '
        'LaporanBrokolyToolStripMenuItem
        '
        Me.LaporanBrokolyToolStripMenuItem.Name = "LaporanBrokolyToolStripMenuItem"
        Me.LaporanBrokolyToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.LaporanBrokolyToolStripMenuItem.Text = "Laporan Brokoli"
        '
        'CetakQtyPeritemToolStripMenuItem
        '
        Me.CetakQtyPeritemToolStripMenuItem.Name = "CetakQtyPeritemToolStripMenuItem"
        Me.CetakQtyPeritemToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.CetakQtyPeritemToolStripMenuItem.Text = "Cetak Qty Peritem (AUP)"
        '
        'CetakQtyPeritemDCToolStripMenuItem
        '
        Me.CetakQtyPeritemDCToolStripMenuItem.Name = "CetakQtyPeritemDCToolStripMenuItem"
        Me.CetakQtyPeritemDCToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.CetakQtyPeritemDCToolStripMenuItem.Text = "Cetak Qty Peritem (DC)"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AboutToolStripMenuItem.Text = "ABOUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(875, 407)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Brown
        Me.Label1.Location = New System.Drawing.Point(10, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'LISTINGSURATJALANSJToolStripMenuItem
        '
        Me.LISTINGSURATJALANSJToolStripMenuItem.Name = "LISTINGSURATJALANSJToolStripMenuItem"
        Me.LISTINGSURATJALANSJToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.LISTINGSURATJALANSJToolStripMenuItem.Text = "LISTING SURAT JALAN (SJ)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 431)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABSENToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PBATKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanBrokolyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProsesPBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MASTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterTokoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdmastToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BARANGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTBARANGDCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTBARANGNONAKTIVAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents REPORTBARANGAKTIVAAUPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakQtyPeritemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakQtyPeritemDCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents USULANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RENCAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LISTINGSURATJALANSJToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
