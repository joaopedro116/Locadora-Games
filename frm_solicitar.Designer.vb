<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_solicitar
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_jogo = New System.Windows.Forms.ComboBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv_soli = New System.Windows.Forms.DataGridView()
        Me.id_jogo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genero_soli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ean = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.cb_cliente = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_soli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(335, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cliente:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_jogo)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dgv_soli)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 276)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Itens"
        '
        'cb_jogo
        '
        Me.cb_jogo.FormattingEnabled = True
        Me.cb_jogo.Location = New System.Drawing.Point(10, 44)
        Me.cb_jogo.Name = "cb_jogo"
        Me.cb_jogo.Size = New System.Drawing.Size(211, 21)
        Me.cb_jogo.TabIndex = 23
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(125, 248)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(97, 20)
        Me.TextBox8.TabIndex = 16
        Me.TextBox8.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(138, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Qtde de Itens:"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(16, 248)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(93, 20)
        Me.TextBox9.TabIndex = 14
        Me.TextBox9.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Valor Total :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(237, 42)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Adicionar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Jogos:"
        '
        'dgv_soli
        '
        Me.dgv_soli.AllowUserToAddRows = False
        Me.dgv_soli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_soli.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_jogo, Me.nome, Me.genero_soli, Me.ean, Me.quantidade})
        Me.dgv_soli.Location = New System.Drawing.Point(7, 70)
        Me.dgv_soli.Name = "dgv_soli"
        Me.dgv_soli.ReadOnly = True
        Me.dgv_soli.Size = New System.Drawing.Size(737, 159)
        Me.dgv_soli.TabIndex = 0
        '
        'id_jogo
        '
        Me.id_jogo.HeaderText = "ID Jogo"
        Me.id_jogo.Name = "id_jogo"
        Me.id_jogo.ReadOnly = True
        '
        'nome
        '
        Me.nome.HeaderText = "Nome"
        Me.nome.Name = "nome"
        Me.nome.ReadOnly = True
        '
        'genero_soli
        '
        Me.genero_soli.HeaderText = "Genero"
        Me.genero_soli.Name = "genero_soli"
        Me.genero_soli.ReadOnly = True
        '
        'ean
        '
        Me.ean.HeaderText = "EAN"
        Me.ean.Name = "ean"
        Me.ean.ReadOnly = True
        '
        'quantidade
        '
        Me.quantidade.HeaderText = "QTD"
        Me.quantidade.Name = "quantidade"
        Me.quantidade.ReadOnly = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(684, 346)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(101, 23)
        Me.Button9.TabIndex = 19
        Me.Button9.Text = "Finalizar Pedido"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'cb_cliente
        '
        Me.cb_cliente.FormattingEnabled = True
        Me.cb_cliente.Location = New System.Drawing.Point(13, 20)
        Me.cb_cliente.Name = "cb_cliente"
        Me.cb_cliente.Size = New System.Drawing.Size(211, 21)
        Me.cb_cliente.TabIndex = 22
        '
        'frm_solicitar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 381)
        Me.Controls.Add(Me.cb_cliente)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frm_solicitar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solictação de Locação"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_soli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_soli As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents cb_jogo As ComboBox
    Friend WithEvents cb_cliente As ComboBox
    Friend WithEvents id_jogo As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents genero_soli As DataGridViewTextBoxColumn
    Friend WithEvents ean As DataGridViewTextBoxColumn
    Friend WithEvents quantidade As DataGridViewTextBoxColumn
End Class
