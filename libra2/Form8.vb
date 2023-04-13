Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = data1
        Label2.Text = data2
        Label3.Text = data3
        TextBox1.Text = data4
        Label8.Text = data5
        Label9.Text = data6
    End Sub
    Public Sub disp_data()
        TextBox1.Text = data4
        Label8.Text = data5
        Label9.Text = data6
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a.Open()
        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = "select * from studentinfo where studentid = '" + TextBox1.Text + "'"
        'If TextBox11.Text = s Then
        b.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(b)
        da.Fill(dt)
        Dim dr As SqlClient.SqlDataReader
        dr = b.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read
            Label8.Text = dr.GetString(1).ToString()
            Label9.Text = dr.GetString(2).ToString()
        End While
        a.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rent As String = "Rented"
        If ConnectionState.Open Then
            a.Close()
        End If
        a.Open()
        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = $"insert into transac (id,tittle,author,studentid,firstname,lastname,trtype) values ('" + Label1.Text + "','" + Label2.Text + "','" + Label3.Text + "','" + TextBox1.Text + "','" + Label8.Text + "','" + Label9.Text + "','" + rent + "')"
        b.ExecuteNonQuery()
        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = "update books set Availability = '" + nava + "' where Id = '" + Label1.Text + "'"
        b.ExecuteNonQuery()
        a.Close()
        MessageBox.Show("Rented Successfully!")
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form10.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        disp_data()
    End Sub
End Class