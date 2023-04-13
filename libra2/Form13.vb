Public Class Form13
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disp_data()
    End Sub

    Public Sub disp_data()
        Label1.Text = data15
        Label2.Text = data16
        Label3.Text = data17
        Label4.Text = data18
        Label5.Text = data19
        Label6.Text = data20
        Label7.Text = data21
        Label8.Text = data22
        Label9.Text = data23
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form9.Show()
        disp_data()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        disp_data()
    End Sub
End Class