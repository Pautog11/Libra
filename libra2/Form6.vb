Imports System.Data.SqlClient
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml

Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet6.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.Database1DataSet6.books)
        'TODO: This line of code loads data into the 'Database1DataSet5.transac' table. You can move, or remove it, as needed.
        Me.TransacTableAdapter.Fill(Me.Database1DataSet5.transac)
        disp_data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        If ConnectionState.Open Then
            a.Close()
        End If
        Try
            a.Open()

            i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())
            data7 = i
            b = a.CreateCommand()
            b.CommandType = CommandType.Text
            b.CommandText = "select * from transac where id = " & i & ""
            b.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(b)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = b.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                data8 = dr.GetString(1).ToString()
                data9 = dr.GetString(2).ToString()
                data10 = dr.GetString(3).ToString()
                data11 = dr.GetString(4).ToString()
                data12 = dr.GetString(5).ToString()
                data13 = dr.GetString(6).ToString()
                data14 = dr.GetString(7).ToString()
            End While

            a.Close()
            Form11.Show()
            Me.Hide()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub disp_data()
        If ConnectionState.Open Then
            a.Close()
        End If
        a.Open()
        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = "select * from books where Availability = 'Not Available'"
        b.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(b)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        a.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        disp_data()
    End Sub
End Class