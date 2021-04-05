Public Class frm_cadastro_clientes
    Private Sub frm_cadastro_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados()
        conectar_banco()
    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With abrir_foto
                .Title = "Selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        Try
            sql = "select * from tb_cep where cep='" & txt_cep.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_endereco.Text = rs.Fields(1).Value
                txt_cidade.Text = rs.Fields(2).Value
                txt_bairro.Text = rs.Fields(3).Value
                txt_uf.Text = rs.Fields(4).Value
                txt_complemento.Focus()
            Else
                MsgBox("CEP não Localizado !" + vbExclamation, MsgBoxStyle.OkOnly, "Atenção!")
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar a consulta !", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub

    Private Sub txt_cep_GotFocus(sender As Object, e As EventArgs) Handles txt_cep.GotFocus
        txt_cep.Clear()
        txt_endereco.Clear()
        txt_cidade.Clear()
        txt_bairro.Clear()
        txt_uf.Clear()
        txt_complemento.Clear()

    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            sql = "select * from  CLIENTES where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update CLIENTES set data_nasc='" & cmb_calendario.Text & "', " &
                                                   "nome='" & txt_nome.Text & "'," &
                                                   "cep='" & txt_cep.Text & "'," &
                                                   "endereco='" & txt_endereco.Text & "'," &
                                                   "comp='" & txt_complemento.Text & "'," &
                                                   "bairro='" & txt_bairro.Text & "'," &
                                                   "cidade='" & txt_cidade.Text & "'," &
                                                   "uf='" & txt_uf.Text & "'," &
                                                   "fone_res='" & txt_fone.Text & "'," &
                                                   "celular='" & txt_cel.Text & "'," &
                                                   "email='" & txt_email.Text & "'," &
                                                   "foto='" & diretorio & "' where cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados Alterados com Sucesso !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
            Else
                sql = "insert into CLIENTES values ('" & txt_cpf.Text & "', " &
                                                   "'" & cmb_calendario.Text & "', " &
                                                   "'" & txt_nome.Text & "'," &
                                                   "'" & txt_cep.Text & "'," &
                                                   "'" & txt_endereco.Text & "'," &
                                                   "'" & txt_complemento.Text & "'," &
                                                   "'" & txt_bairro.Text & "'," &
                                                   "'" & txt_cidade.Text & "'," &
                                                   "'" & txt_uf.Text & "'," &
                                                   "'" & txt_fone.Text & "'," &
                                                   "'" & txt_cel.Text & "'," &
                                                   "'" & txt_email.Text & "'," &
                                                   "'" & diretorio & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information + vbOKOnly, "Aviso")
            End If
            limpar_dados()
                carregar_dados()
        Catch ex As Exception
            'MsgBox("Erro ao gravar dados !", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção!")
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_cpf_GotFocus(sender As Object, e As EventArgs) Handles txt_cpf.GotFocus
        limpar_dados()

    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try

            sql = "select * from CLIENTES where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                txt_nome.Focus()
            Else
                cmb_calendario.Text = rs.Fields(1).Value
                txt_nome.Text = rs.Fields(2).Value
                txt_cep.Text = rs.Fields(3).Value
                txt_endereco.Text = rs.Fields(4).Value
                txt_complemento.Text = rs.Fields(5).Value
                txt_bairro.Text = rs.Fields(6).Value
                txt_cidade.Text = rs.Fields(7).Value
                txt_uf.Text = rs.Fields(8).Value
                txt_fone.Text = rs.Fields(9).Value
                txt_cel.Text = rs.Fields(10).Value
                txt_email.Text = rs.Fields(11).Value
                img_foto.Load(rs.Fields(12).Value)
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar a consulta por CPF!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub


    Private Sub txt_buscar_nome_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar_nome.TextChanged
        With dgv_dados
            cont = 1
            sql = "select * from CLIENTES where nome like '" & txt_buscar_nome.Text & "%'"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(10).Value, Nothing, Nothing)
                cont = cont + 1
                rs.MoveNext()

            Loop
        End With
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(4).Selected = True Then
                    aux = .CurrentRow.Cells(1).Value
                    sql = "select * from CLIENTES where cpf='" & aux & "' "
                    rs = db.Execute(sql)
                    diretorio = rs.Fields(12).Value
                    If rs.EOF = False Then

                        tab_cadastro.SelectTab(0)

                        txt_cpf.Text = rs.Fields(0).Value
                        cmb_calendario.Text = rs.Fields(1).Value
                        txt_nome.Text = rs.Fields(2).Value
                        txt_cep.Text = rs.Fields(3).Value
                        txt_endereco.Text = rs.Fields(4).Value
                        txt_complemento.Text = rs.Fields(5).Value
                        txt_bairro.Text = rs.Fields(6).Value
                        txt_cidade.Text = rs.Fields(7).Value
                        txt_uf.Text = rs.Fields(8).Value
                        txt_fone.Text = rs.Fields(9).Value
                        txt_cel.Text = rs.Fields(10).Value
                        txt_email.Text = rs.Fields(11).Value
                        img_foto.Load(rs.Fields(12).Value)

                    End If

                ElseIf .CurrentRow.Cells(5).Selected = True Then
                    aux = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir ?" + vbNewLine &
                                "O CPF: " & aux & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção!")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete from CLIENTES where cpf ='" & aux & "'"
                        rs = db.Execute(sql)
                        carregar_dados()
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

    Private Sub txt_buscar_nome_Click(sender As Object, e As EventArgs) Handles txt_buscar_nome.Click

    End Sub

    Private Sub txt_cpf_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_cpf.MaskInputRejected

    End Sub
End Class