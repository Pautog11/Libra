Imports System.Data.SqlClient

Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet4.studentinfo' table. You can move, or remove it, as needed.
        Me.StudentinfoTableAdapter.Fill(Me.Database1DataSet4.studentinfo)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        Try
            a.Open()

            i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())
            data4 = i
            b = a.CreateCommand()
            b.CommandType = CommandType.Text
            b.CommandText = "select * from studentinfo where studentid=" & i & ""
            b.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(b)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = b.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read

                data5 = dr.GetString(1).ToString()
                data6 = dr.GetString(2).ToString()

            End While

            a.Close()
            Form8.Show()
            Me.Hide()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub disp_data()
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        disp_data()
    End Sub
End Class