<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_devolver
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_soli = New System.Windows.Forms.DataGridView()
        Me.id_jogo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genero_soli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ean = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_cliente = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_soli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Cliente:"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(450, 415)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(126, 23)
        Me.Button9.TabIndex = 29
        Me.Button9.Text = "Realizar Devolução"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_soli)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(582, 362)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Itens"
        '
        'dgv_soli
        '
        Me.dgv_soli.AllowUserToAddRows = False
        Me.dgv_soli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_soli.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_jogo, Me.nome, Me.genero_soli, Me.ean, Me.quantidade})
        Me.dgv_soli.Location = New System.Drawing.Point(0, 71)
        Me.dgv_soli.Name = "dgv_soli"
        Me.dgv_soli.ReadOnly = True
        Me.dgv_soli.Size = New System.Drawing.Size(574, 234)
        Me.dgv_soli.TabIndex = 19
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
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(123, 336)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(93, 20)
        Me.TextBox4.TabIndex = 17
        Me.TextBox4.TabStop = False
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(3, 336)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(97, 20)
        Me.TextBox8.TabIndex = 16
        Me.TextBox8.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(0, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Qtde de Itens:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(120, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Valor Total:"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(479, 21)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(97, 20)
        Me.TextBox7.TabIndex = 12
        Me.TextBox7.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(476, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Data de Devolução:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(377, 21)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(96, 20)
        Me.TextBox3.TabIndex = 26
        Me.TextBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(374, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Data da Locação:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(332, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 22
        '
        'cb_cliente
        '
        Me.cb_cliente.FormattingEnabled = True
        Me.cb_cliente.Location = New System.Drawing.Point(17, 20)
        Me.cb_cliente.Name = "cb_cliente"
        Me.cb_cliente.Size = New System.Drawing.Size(211, 21)
        Me.cb_cliente.TabIndex = 31
        '
        'frm_devolver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 450)
        Me.Controls.Add(Me.cb_cliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frm_devolver"
        Me.Text = "Devolução"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_soli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents cb_cliente As ComboBox
    Friend WithEvents dgv_soli As DataGridView
    Friend WithEvents id_jogo As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents genero_soli As DataGridViewTextBoxColumn
    Friend WithEvents ean As DataGridViewTextBoxColumn
    Friend WithEvents quantidade As DataGridViewTextBoxColumn
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label9 As Label
End Class
