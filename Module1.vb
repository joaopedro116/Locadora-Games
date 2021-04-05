Module Module1
    Public resp, diretorio As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String
    Public cont As Integer
    Public aux, auxt As String

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=DESKTOP-Q2QOV87;Initial Catalog=HUMBERTO_LOCADORA;trusted_connection=yes;")
            MsgBox("Conexão bem sucedida!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao conectar com o Banco de Dados !", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub

    Sub limpar_dados()
        Try
            With frm_cadastro_clientes
                .txt_cpf.Clear()
                .txt_nome.Clear()
                .txt_cep.Clear()
                .txt_endereco.Clear()
                .txt_complemento.Clear()
                .txt_bairro.Clear()
                .txt_cidade.Clear()
                .txt_uf.Clear()
                .txt_fone.Clear()
                .txt_cel.Clear()
                .txt_email.Clear()
                .img_foto.Load(Application.StartupPath & "\icon\foto_branco.png")
                .txt_cpf.Focus()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Sub carregar_dados()
        With frm_cadastro_clientes.dgv_dados
            cont = 1
            sql = "select*from CLIENTES order by nome asc"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(10).Value, Nothing, Nothing)
                cont = cont + 1
                rs.MoveNext()

            Loop
        End With
    End Sub
    Sub desconectar_banco()
        'String de Desconexão com SQL-Server
        Try
            db.Close()
            MsgBox("Desconexão bem sucedida!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            'MsgBox("Erro ao desconectar com o banco!!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub carregar_dados_funcionario()
        With frm_cadastro_funcionario.dgv_dados
            cont = 1
            sql = "select*from USUARIO order by nome asc"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(10).Value, Nothing, Nothing)
                cont = cont + 1
                rs.MoveNext()

            Loop
        End With
    End Sub
    Sub limpar_dados_funcionario()
        Try
            With frm_cadastro_funcionario
                .txt_cpf.Clear()
                .txt_nome.Clear()
                .txt_cep.Clear()
                .txt_endereco.Clear()
                .txt_complemento.Clear()
                .txt_bairro.Clear()
                .txt_cidade.Clear()
                .txt_uf.Clear()
                .txt_fone.Clear()
                .txt_cel.Clear()
                .txt_email.Clear()
                .img_foto.Load(Application.StartupPath & "\icon\foto_branco.png")
                .txt_senha.Clear()
                .txt_cpf.Focus()
            End With
        Catch ex As Exception

        End Try
    End Sub
    Sub limpar_dados_jogo()
        Try
            With frm_cadastro_jogos
                .txt_nome_jogo.Clear()
                .txt_genero.Clear()
                .txt_qtde.Clear()
                .txt_ean.Clear()
                .txt_id.Clear()
                .txt_nome_jogo.Focus()
            End With
        Catch ex As Exception

        End Try
    End Sub
    Sub carregar_dados_jogos()
        With frm_cadastro_jogos.dgv_jogo
            cont = 1
            sql = "select * from CATALOGO order by nome asc"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(4).Value, Nothing, Nothing)
                cont = cont + 1
                rs.MoveNext()

            Loop
        End With
    End Sub
End Module
