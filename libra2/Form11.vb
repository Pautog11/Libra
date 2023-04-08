Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form11
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label15.Text = data7
        Label1.Text = data8
        Label2.Text = data9
        Label3.Text = data10
        Label13.Text = data11
        Label8.Text = data12
        Label9.Text = data13
        Label17.Text = data14
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ret As String = "Returned"
        If ConnectionState.Open Then
            a.Close()
        End If
        a.Open()
        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = $"insert into transac (id,tittle,author,studentid,firstname,lastname,trtype) values ('" + Label1.Text + "','" + Label2.Text + "','" + Label3.Text + "','" + Label13.Text + "','" + Label8.Text + "','" + Label9.Text + "','" + ret + "')"
        b.ExecuteNonQuery()

        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = "update books set Availability = '" + ava + "' where Id = '" + Label1.Text + "'"
        b.ExecuteNonQuery()
        a.Close()

        MessageBox.Show("Returned Successfully!")
        Me.Hide()
        Form6.Show()
    End Sub
End Class