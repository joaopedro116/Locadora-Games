Imports System.Data.SqlClient
Public Class frm_login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Dim connection As New SqlConnection("Server= DESKTOP-Q2QOV87; Database = HUMBERTO_LOCADORA; integrated security=true")

        Dim command As New SqlCommand("select * from USUARIO where nome = @nome and senha = @senha ", connection)


        command.Parameters.Add("@nome", SqlDbType.VarChar).Value = txt_usuario.Text
        command.Parameters.Add("@senha", SqlDbType.VarChar).Value = txt_senha.Text


        Dim adapter As New SqlDataAdapter(Command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then

            MessageBox.Show("Usuario ou senha incorretas ! ")

        Else
            MessageBox.Show("Logado !")
        frm_menu_principal.ShowDialog()
        End If


    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub
End Class
