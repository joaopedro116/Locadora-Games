Public Class frm_solicitar
    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cb_cliente_DropDown(sender As Object, e As EventArgs) Handles cb_cliente.DropDown
        Dim ctx As New HumbertoLocadora()
        Dim cli = ctx.CLIENTES.ToList()
        cb_cliente.DataSource = cli
        cb_cliente.DisplayMember = "NOME"

    End Sub

    Private Sub cb_jogo_DropDown(sender As Object, e As EventArgs) Handles cb_jogo.DropDown
        Dim ctx As New HumbertoLocadora()
        Dim cli = ctx.CATALOGOes.ToList()
        cb_jogo.DataSource = cli
        cb_jogo.DisplayMember = "NOME"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'dgv_soli
        Dim jogosel = cb_jogo.SelectedItem
        dgv_soli.Rows.Add(jogosel.ID_CATALOGO, jogosel.NOME, jogosel.GENERO, jogosel.EAN, jogosel.QUANTIDADE)

    End Sub

    Private Sub dgv_soli_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgv_soli.RowsAdded
        Dim cnt_jogos = dgv_soli.Rows.Count
        TextBox9.Text = cnt_jogos * 1.5
        TextBox8.Text = cnt_jogos
    End Sub

    Private Sub dgv_soli_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgv_soli.RowsRemoved
        Dim cnt_jogos = dgv_soli.Rows.Count
        TextBox9.Text = cnt_jogos * 1.5
        TextBox8.Text = cnt_jogos
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim cpf = cb_cliente.SelectedItem.cpf
        Dim ctx As New HumbertoLocadora()
        For Each jogo In dgv_soli.Rows
            Dim alu As New ALUGUEL()
            alu.cpf = cpf
            alu.ID_CATALOGO = jogo.Cells(0).Value
            ctx.ALUGUELs.Add(alu)
        Next
        ctx.SaveChanges()
        MsgBox("Pedido finalizado com sucesso!")

    End Sub
End Class