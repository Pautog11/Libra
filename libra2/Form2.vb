Imports Guna.UI2.WinForms
Imports libra2.UsersDataSet
Imports libra2.UsersDataSetTableAdapters

Public Class Form2
    ' Di ko na pinalitan name ng textbox baka kase nagamit sa ibang form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dataAdapter As New accountTableAdapter
        Dim resultUser As accountDataTable = dataAdapter.GetDataByUserAcc(TextBox1.Text)
        Dim dialog As New Guna2MessageDialog ' idk nice message box hahaah
        dialog.Icon = MessageDialogIcon.Information ' Type ng mesasge box info, warning, and etc yung iba

        ' Check kung may user na existing sa database
        If resultUser.Count <> 0 Then
            ' Kung may existing na account alamin kung tama ang password
            With resultUser.Item(0)
                ' Check kung tama password
                If .pass = TextBox2.Text Then
                    Form3.Show()
                    Me.Close()
                Else
                    dialog.Text = "Invalid username or password."
                    dialog.Show()
                End If
            End With
        Else
                ' Kung wala then print ng error
                dialog.Text = "Account doesn't exist."
                dialog.Show()
        End If
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
        'Form3.Show()
        'Me.Close()  ' Close muna
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close() ' Close muna
    End Sub
End Class