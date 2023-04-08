Imports System.Data.SqlClient

Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet3.transac' table. You can move, or remove it, as needed.
        Me.TransacTableAdapter.Fill(Me.Database1DataSet3.transac)

    End Sub
    Public Sub disp_data()
        a.Open()
        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = "select * from transac"
        b.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(b)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        a.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        disp_data()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a.Open()
        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = "select * from transac where id = '" + TextBox1.Text + "'"
        b.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(b)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        a.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        a.Open()
        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = "select * from transac where studentid = '" + TextBox2.Text + "'"
        b.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(b)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        a.Close()
    End Sub
End Class