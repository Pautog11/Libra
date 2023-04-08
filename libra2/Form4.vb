Imports System.Data.SqlClient

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.studentinfo' table. You can move, or remove it, as needed.
        Me.StudentinfoTableAdapter.Fill(Me.Database1DataSet.studentinfo)
        disp_data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ConnectionState.Open Then
            a.Close()
        End If
        a.Open()
        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = $"insert into studentinfo values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + ComboBox1.Text + "','" + ComboBox2.Text + "','" + ComboBox3.Text + "','" + TextBox5.Text + "','" + DateTimePicker1.Text + "','" + RichTextBox1.Text + "')"
        b.ExecuteNonQuery()
        MessageBox.Show("Recorded Succesfully!")
        disp_data()
        a.Close()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox5.Text = ""
        DateTimePicker1.Text = ""
        RichTextBox1.Text = ""
    End Sub

    Public Sub disp_data()
        If ConnectionState.Open Then
            a.Close()
        End If
        a.Open()
        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = "select * from studentinfo"
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
        b.CommandText = "delete from studentinfo where firstname = '" + TextBox2.Text + "'"
        b.ExecuteNonQuery()
        disp_data()
        a.Close()
        MsgBox("Deleted Successfully!")

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox5.Text = ""
        DateTimePicker1.Text = ""
        RichTextBox1.Text = ""
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As New Integer
        Try
            a.Open()

            i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())
            TextBox1.Text = i
            b = a.CreateCommand()
            b.CommandType = CommandType.Text
            b.CommandText = "select * from studentinfo where studentid =" & i & ""
            b.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(b)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = b.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read

                'TextBox1.Text = dr.GetString(0).ToString()
                TextBox2.Text = dr.GetString(1).ToString()
                TextBox3.Text = dr.GetString(2).ToString()
                TextBox4.Text = dr.GetString(3).ToString()
                ComboBox1.Text = dr.GetString(4).ToString()
                ComboBox2.Text = dr.GetString(5).ToString()
                ComboBox3.Text = dr.GetString(6).ToString()
                TextBox5.Text = dr.GetString(7).ToString()
                DateTimePicker1.Text = dr.GetString(8).ToString()
                RichTextBox1.Text = dr.GetString(9).ToString()

            End While

            a.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a.Open()

        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = "update studentinfo set firstname = '" + TextBox2.Text + "',lastname = '" + TextBox3.Text + "', mi = '" + TextBox4.Text + "' , gender = '" + ComboBox1.Text + "', year = '" + ComboBox2.Text + "', course = '" + ComboBox3.Text + "', contact = '" + TextBox5.Text + "', birthday = '" + DateTimePicker1.Text + "', address = '" + RichTextBox1.Text + "' where studentid = '" + TextBox1.Text + "'"
        b.ExecuteNonQuery()
        disp_data()
        a.Close()
        MsgBox("Updated Successfully!")

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox5.Text = ""
        DateTimePicker1.Text = ""
        RichTextBox1.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter Student ID!")
        End If

        a.Open()
        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = "select * from studentinfo where studentid = '" + TextBox1.Text + "'"
        b.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(b)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        a.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form3.Show()
        Me.Hide()

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox5.Text = ""
        DateTimePicker1.Text = ""
        RichTextBox1.Text = ""
    End Sub
End Class