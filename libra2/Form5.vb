Imports System.Data.SqlClient

Public Class Form5
    'Dim ava As String = "Available"
    'Dim nava As String = "Not Available"
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.Database1DataSet1.books)
        disp_data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a.Open()
        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = $"insert into books values ('" + TextBox2.Text + "','" + TextBox3.Text + "','" + ava + "')"
        b.ExecuteNonQuery()
        disp_data()
        MessageBox.Show("Recorded Successfully!")
        a.Close()
        'TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Public Sub disp_data()
        If ConnectionState.Open Then
            a.Close()
        End If
        a.Open()
        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = "select * from books"
        b.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(b)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        a.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a.Open()
        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = "delete from books where Id = '" + TextBox1.Text + "'"
        b.ExecuteNonQuery()
        disp_data()
        a.Close()
        MsgBox("Deleted Successfully!")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a.Open()
        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = "update books set Tittle = '" + TextBox2.Text + "', Author = '" + TextBox3.Text + "' where Id = '" + TextBox1.Text + "'"
        b.ExecuteNonQuery()
        disp_data()
        a.Close()
        MsgBox("Updated Successfully!")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        a.Open()
        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = "select * from books where Id = '" + TextBox1.Text + "'"
        b.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(b)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        a.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        Try
            a.Open()
            i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())
            TextBox1.Text = i
            b = a.CreateCommand()
            b.CommandType = CommandType.Text
            b.CommandText = "select * from books where id=" & i & ""
            b.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(b)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = b.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                TextBox2.Text = dr.GetString(1).ToString()
                TextBox3.Text = dr.GetString(2).ToString()
            End While
            a.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        disp_data()
    End Sub
End Class