Public Class frm_devolver
    Private Sub cb_cliente_DropDown(sender As Object, e As EventArgs) Handles cb_cliente.DropDown
        Dim ctx As New HumbertoLocadora()
        Dim cli = ctx.CLIENTES.ToList()
        cb_cliente.DataSource = cli
        cb_cliente.DisplayMember = "NOME"
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub frm_devolver_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cb_cliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_cliente.SelectedIndexChanged

    End Sub

    Private Sub cb_cliente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_cliente.SelectedValueChanged
        Dim ctx As New HumbertoLocadora()
        Dim cpf = cb_cliente.SelectedItem.cpf
        Dim alu = ctx.ALUGUELs.Where(Function(p) p.cpf = cpf)
        For Each jogo_id In alu
            'Dim jogosel = ctx.CATALOGOes.Single(Function(p) p. )
            'dgv_soli.Rows.Add(jogosel.ID_CATALOGO, jogosel.NOME, jogosel.GENERO, jogosel.EAN)
        Next
    End Sub
End Class