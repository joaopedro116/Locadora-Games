Public Class frm_cadastro_jogos
    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            sql = "select * from CATALOGO where ID_CATALOGO='" & txt_id.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update CATALOGO set NOME='" & txt_nome_jogo.Text & "', " &
                                                   "GENERO='" & txt_genero.Text & "'," &
                                                   "EAN='" & txt_ean.Text & "'," &
                                                   "QUANTIDADE='" & txt_qtde.Text & "' where ID_CATALOGO='" & txt_id.Text & "'"
                '"QUANTIDADE='" & txt_qtde.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados Alterados com Sucesso !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
            Else
                sql = "insert into CATALOGO values ('" & txt_id.Text & "', " &
                                                   "'" & txt_nome_jogo.Text & "', " &
                                                   "'" & txt_genero.Text & "', " &
                                                   "'" & txt_ean.Text & "'," &
                                                   "'" & txt_qtde.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information + vbOKOnly, "Aviso")
            End If
            limpar_dados_jogo()
            carregar_dados_jogos()
        Catch ex As Exception
            'MsgBox("Erro ao gravar dados !", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção!")
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgv_jogo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_jogo.CellContentClick
        Try
            With dgv_jogo
                If .CurrentRow.Cells(4).Selected = True Then
                    aux = .CurrentRow.Cells(0).Value
                    sql = "select * from CATALOGO where ID_CATALOGO='" & aux & "' "
                    rs = db.Execute(sql)
                    'diretorio = rs.Fields(12).Value
                    If rs.EOF = False Then

                        tab_jogo.SelectTab(0)

                        txt_id.Text = rs.Fields(0).Value
                        txt_nome_jogo.Text = rs.Fields(1).Value
                        txt_genero.Text = rs.Fields(2).Value
                        txt_ean.Text = rs.Fields(3).Value
                        txt_qtde.Text = rs.Fields(4).Value
                    End If

                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir ?" + vbNewLine &
                                "O JOGO: " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete from CATALOGO where NOME ='" & aux & "'"
                        rs = db.Execute(sql)
                        carregar_dados_jogos()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'MsgBox("Erro ao processar !", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção !")
        End Try
    End Sub

    Private Sub frm_cadastro_jogos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados_jogos()
    End Sub
End Class