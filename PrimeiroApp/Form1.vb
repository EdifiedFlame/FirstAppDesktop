Public Class frmTelaInicial
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles amarelo.Click
        lbltitle.ForeColor = Color.Yellow
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblverde.Click
        lbltitle.ForeColor = Color.Green
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblvermelho.Click
        lbltitle.ForeColor = Color.Red
    End Sub

    Private Sub lblpreto_Click(sender As Object, e As EventArgs) Handles lblpreto.Click
        lbltitle.ForeColor = Color.Black
    End Sub

    Private Sub lblazul_Click(sender As Object, e As EventArgs) Handles lblazul.Click
        lbltitle.ForeColor = Color.Blue
    End Sub
End Class
