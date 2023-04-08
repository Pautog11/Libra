Imports System.Data.SqlClient

Module Module1
    Public a As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Christian\OneDrive\Desktop\libra2\libra2\Database1.mdf;Integrated Security=True")
    Public b As New SqlCommand
    Public c As SqlDataReader
    Public ava As String = "Available"
    Public nava As String = "Not Available"
    Public data1, data2, data3, data4, data5, data6, data7, data8, data9, data10, data11, data12, data13, data14 As String
End Module
