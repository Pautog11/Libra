Imports System.Data.SqlClient

Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet3.transac' table. You can move, or remove it, as needed.
        Me.TransacTableAdapter.Fill(Me.Database1DataSet3.transac)

    End Sub
    Public Sub disp_data()
        If ConnectionState.Open Then
            a.Close()
        End If
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

    Private Sub Form9_Click(sender As Object, e As EventArgs) Handles MyBase.Click

    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim i As Integer
        If ConnectionState.Open Then
            a.Close()
        End If
        Try
            a.Open()

            i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())
            data15 = i
            b = a.CreateCommand()
            b.CommandType = CommandType.Text
            b.CommandText = "select * from transac where tr = " & i & ""
            b.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(b)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = b.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                data16 = dr.GetString(1).ToString()
                data17 = dr.GetString(2).ToString()
                data18 = dr.GetString(3).ToString()
                data19 = dr.GetString(4).ToString()
                data20 = dr.GetString(5).ToString()
                data21 = dr.GetString(6).ToString()
                data22 = dr.GetString(7).ToString()
                data23 = dr.GetString(8).ToString()
            End While

            a.Close()
            Form13.Show()
            Me.Hide()
        Catch ex As Exception

        End Try
    End Sub
End Class