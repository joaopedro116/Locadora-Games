<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu_principal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu_principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeFuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeJogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevoluçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.LocaçãoToolStripMenuItem, Me.EncerrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeFuncionáriosToolStripMenuItem, Me.CadastroDeJogosToolStripMenuItem, Me.CadastroDeClientesToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'CadastroDeFuncionáriosToolStripMenuItem
        '
        Me.CadastroDeFuncionáriosToolStripMenuItem.Image = CType(resources.GetObject("CadastroDeFuncionáriosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastroDeFuncionáriosToolStripMenuItem.Name = "CadastroDeFuncionáriosToolStripMenuItem"
        Me.CadastroDeFuncionáriosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.CadastroDeFuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.CadastroDeFuncionáriosToolStripMenuItem.Text = "Cadastro de Funcionários"
        '
        'CadastroDeJogosToolStripMenuItem
        '
        Me.CadastroDeJogosToolStripMenuItem.Image = CType(resources.GetObject("CadastroDeJogosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastroDeJogosToolStripMenuItem.Name = "CadastroDeJogosToolStripMenuItem"
        Me.CadastroDeJogosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.CadastroDeJogosToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.CadastroDeJogosToolStripMenuItem.Text = "Cadastro de Jogos"
        '
        'CadastroDeClientesToolStripMenuItem
        '
        Me.CadastroDeClientesToolStripMenuItem.Image = CType(resources.GetObject("CadastroDeClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastroDeClientesToolStripMenuItem.Name = "CadastroDeClientesToolStripMenuItem"
        Me.CadastroDeClientesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CadastroDeClientesToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.CadastroDeClientesToolStripMenuItem.Text = "Cadastro de Clientes"
        '
        'LocaçãoToolStripMenuItem
        '
        Me.LocaçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SolicitaçãoToolStripMenuItem, Me.DevoluçãoToolStripMenuItem})
        Me.LocaçãoToolStripMenuItem.Name = "LocaçãoToolStripMenuItem"
        Me.LocaçãoToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.LocaçãoToolStripMenuItem.Text = "Locação"
        '
        'SolicitaçãoToolStripMenuItem
        '
        Me.SolicitaçãoToolStripMenuItem.Name = "SolicitaçãoToolStripMenuItem"
        Me.SolicitaçãoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SolicitaçãoToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SolicitaçãoToolStripMenuItem.Text = "Solicitação"
        '
        'DevoluçãoToolStripMenuItem
        '
        Me.DevoluçãoToolStripMenuItem.Name = "DevoluçãoToolStripMenuItem"
        Me.DevoluçãoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DevoluçãoToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.DevoluçãoToolStripMenuItem.Text = "Devolução"
        '
        'EncerrarToolStripMenuItem
        '
        Me.EncerrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncerrarSistemaToolStripMenuItem})
        Me.EncerrarToolStripMenuItem.Name = "EncerrarToolStripMenuItem"
        Me.EncerrarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.EncerrarToolStripMenuItem.Text = "Encerrar"
        '
        'EncerrarSistemaToolStripMenuItem
        '
        Me.EncerrarSistemaToolStripMenuItem.Image = CType(resources.GetObject("EncerrarSistemaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EncerrarSistemaToolStripMenuItem.Name = "EncerrarSistemaToolStripMenuItem"
        Me.EncerrarSistemaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.EncerrarSistemaToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.EncerrarSistemaToolStripMenuItem.Text = "Encerrar Sistema"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(788, 411)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frm_menu_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frm_menu_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeFuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeJogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolicitaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevoluçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
