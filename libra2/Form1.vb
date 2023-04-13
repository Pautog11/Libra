Imports System.Windows

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form2.Show()
        Me.Close()              ' Wag ka gumamit ng hide kase di nawawala yung form sa screen. pinalitan ko lang yung settings mo
        ' Project>libra properties>Application>Shutdown Mode = set mo siya sa when last form closes
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form12.Show()
        Me.Close()
    End Sub
End Class
