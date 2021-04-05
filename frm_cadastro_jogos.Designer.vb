<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro_jogos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro_jogos))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.tab_jogo = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ean = New System.Windows.Forms.TextBox()
        Me.labe_ean = New System.Windows.Forms.Label()
        Me.txt_qtde = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_genero = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_nome_jogo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_jogo = New System.Windows.Forms.DataGridView()
        Me.contador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome_jogo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editar_jogo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.excluir_jogo = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.tab_jogo.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_jogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(389, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Salvar"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripLabel1.Text = "Digite um parametro para Busca:"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        Me.ToolStripButton4.ToolTipText = "Buscar"
        '
        'tab_jogo
        '
        Me.tab_jogo.Controls.Add(Me.TabPage1)
        Me.tab_jogo.Controls.Add(Me.TabPage2)
        Me.tab_jogo.Location = New System.Drawing.Point(0, 28)
        Me.tab_jogo.Name = "tab_jogo"
        Me.tab_jogo.SelectedIndex = 0
        Me.tab_jogo.Size = New System.Drawing.Size(386, 198)
        Me.tab_jogo.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_id)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txt_ean)
        Me.TabPage1.Controls.Add(Me.labe_ean)
        Me.TabPage1.Controls.Add(Me.txt_qtde)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txt_genero)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txt_nome_jogo)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(378, 172)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados do Jogo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(293, 110)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(62, 20)
        Me.txt_id.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(290, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "ID:"
        '
        'txt_ean
        '
        Me.txt_ean.Location = New System.Drawing.Point(243, 61)
        Me.txt_ean.Name = "txt_ean"
        Me.txt_ean.Size = New System.Drawing.Size(112, 20)
        Me.txt_ean.TabIndex = 44
        '
        'labe_ean
        '
        Me.labe_ean.AutoSize = True
        Me.labe_ean.Location = New System.Drawing.Point(240, 44)
        Me.labe_ean.Name = "labe_ean"
        Me.labe_ean.Size = New System.Drawing.Size(29, 13)
        Me.labe_ean.TabIndex = 43
        Me.labe_ean.Text = "Ean:"
        '
        'txt_qtde
        '
        Me.txt_qtde.Location = New System.Drawing.Point(6, 110)
        Me.txt_qtde.Name = "txt_qtde"
        Me.txt_qtde.Size = New System.Drawing.Size(40, 20)
        Me.txt_qtde.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Quantidade:"
        '
        'txt_genero
        '
        Me.txt_genero.Location = New System.Drawing.Point(6, 61)
        Me.txt_genero.Name = "txt_genero"
        Me.txt_genero.Size = New System.Drawing.Size(112, 20)
        Me.txt_genero.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Genero:"
        '
        'txt_nome_jogo
        '
        Me.txt_nome_jogo.Location = New System.Drawing.Point(6, 20)
        Me.txt_nome_jogo.Name = "txt_nome_jogo"
        Me.txt_nome_jogo.Size = New System.Drawing.Size(360, 20)
        Me.txt_nome_jogo.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Nome do Jogo:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgv_jogo)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(378, 172)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lista de Jogos "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgv_jogo
        '
        Me.dgv_jogo.AllowUserToAddRows = False
        Me.dgv_jogo.AllowUserToDeleteRows = False
        Me.dgv_jogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_jogo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.contador, Me.nome_jogo, Me.genero, Me.qtd, Me.editar_jogo, Me.excluir_jogo})
        Me.dgv_jogo.Location = New System.Drawing.Point(0, 0)
        Me.dgv_jogo.Name = "dgv_jogo"
        Me.dgv_jogo.ReadOnly = True
        Me.dgv_jogo.Size = New System.Drawing.Size(378, 166)
        Me.dgv_jogo.TabIndex = 0
        '
        'contador
        '
        Me.contador.HeaderText = "N°"
        Me.contador.Name = "contador"
        Me.contador.ReadOnly = True
        Me.contador.Width = 30
        '
        'nome_jogo
        '
        Me.nome_jogo.HeaderText = "Nome "
        Me.nome_jogo.Name = "nome_jogo"
        Me.nome_jogo.ReadOnly = True
        '
        'genero
        '
        Me.genero.HeaderText = "Genero"
        Me.genero.Name = "genero"
        Me.genero.ReadOnly = True
        '
        'qtd
        '
        Me.qtd.HeaderText = "Qtd"
        Me.qtd.Name = "qtd"
        Me.qtd.ReadOnly = True
        Me.qtd.Width = 50
        '
        'editar_jogo
        '
        Me.editar_jogo.HeaderText = "Editar"
        Me.editar_jogo.Image = CType(resources.GetObject("editar_jogo.Image"), System.Drawing.Image)
        Me.editar_jogo.Name = "editar_jogo"
        Me.editar_jogo.ReadOnly = True
        Me.editar_jogo.Width = 45
        '
        'excluir_jogo
        '
        Me.excluir_jogo.HeaderText = "Excluir"
        Me.excluir_jogo.Image = CType(resources.GetObject("excluir_jogo.Image"), System.Drawing.Image)
        Me.excluir_jogo.Name = "excluir_jogo"
        Me.excluir_jogo.ReadOnly = True
        Me.excluir_jogo.Width = 45
        '
        'frm_cadastro_jogos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 234)
        Me.Controls.Add(Me.tab_jogo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frm_cadastro_jogos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Jogos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tab_jogo.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_jogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents tab_jogo As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_qtde As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_genero As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_nome_jogo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_ean As TextBox
    Friend WithEvents labe_ean As Label
    Friend WithEvents dgv_jogo As DataGridView
    Friend WithEvents contador As DataGridViewTextBoxColumn
    Friend WithEvents nome_jogo As DataGridViewTextBoxColumn
    Friend WithEvents genero As DataGridViewTextBoxColumn
    Friend WithEvents qtd As DataGridViewTextBoxColumn
    Friend WithEvents editar_jogo As DataGridViewImageColumn
    Friend WithEvents excluir_jogo As DataGridViewImageColumn
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label1 As Label
End Class
