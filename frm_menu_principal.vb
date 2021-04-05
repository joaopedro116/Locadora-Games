Public Class frm_menu_principal
    Private Sub EncerrarSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSistemaToolStripMenuItem.Click
        resp = MsgBox("Deseja encerrar o sistema ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
        If resp = MsgBoxResult.Yes Then
            desconectar_banco()
            End
        End If
    End Sub

    Private Sub CadastroDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeClientesToolStripMenuItem.Click
        frm_cadastro_clientes.ShowDialog()
    End Sub

    Private Sub CadastroDeJogosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeJogosToolStripMenuItem.Click
        frm_cadastro_jogos.ShowDialog()
    End Sub

    Private Sub CadastroDeFuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeFuncionáriosToolStripMenuItem.Click
        frm_cadastro_funcionario.ShowDialog()
    End Sub

    Private Sub SolicitaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitaçãoToolStripMenuItem.Click
        frm_solicitar.ShowDialog()
    End Sub

    Private Sub DevoluçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevoluçãoToolStripMenuItem.Click
        frm_devolver.ShowDialog()
    End Sub
End Class