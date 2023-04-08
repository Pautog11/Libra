Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet2.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.Database1DataSet2.books)
        disp_data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Public Sub disp_data()
        If ConnectionState.Open Then
            a.Close()
        End If
        a.Open()
        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = "select * from books where availability = 'Available'"
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
            data1 = i
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

                data2 = dr.GetString(1).ToString()
                data3 = dr.GetString(2).ToString()

            End While

            a.Close()
            Form8.Show()
            Me.Hide()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        disp_data()
    End Sub
End Class