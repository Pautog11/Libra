Imports System.Data.SqlClient
Imports System.Windows

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If ConnectionState.Open Then
        '    a.Close()
        'End If
        'Try
        '    a.Open()
        '    b = New SqlCommand("select * from account where useracc = '" & TextBox1.Text & "'and pass = '" & TextBox2.Text & "'")
        '    b.Connection = a
        '    c = b.ExecuteReader()
        '    If (c.Read()) Then
        '        Me.Hide()
        '        Form3.Show()
        '        TextBox1.Text = ""
        '        TextBox2.Text = ""
        '    Else
        '        MsgBox("Invalid Credential!")
        '        TextBox1.Text = ""
        '        TextBox2.Text = ""
        '    End If
        'Catch ex As Exception

        'End Try
        Form3.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class