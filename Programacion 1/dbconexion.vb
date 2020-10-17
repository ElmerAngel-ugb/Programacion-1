Imports System.Data
Imports System.Data.SqlClient

Public Class dbconexion
    Dim miConexion As New SqlConnection
    Dim miCommand As New SqlCommand
    Dim miAdapter As New SqlDataAdapter
    Dim ds As DataSet
    Public Sub db_conexion()
        Dim cadenaConeccion As String
        cadenaConeccion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sistemaclinicodb.mdf;Integrated Security=True"
        miConexion.ConnectionString = cadenaConeccion

        miConexion.Open()

    End Sub
    Public Function o()

End Class
