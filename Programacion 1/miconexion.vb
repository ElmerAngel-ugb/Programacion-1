Imports System.Data 'Importar las bibliotecas y clases necesarias para trabajar con ado.net
Imports System.Data.SqlClient 'Biblioteca de clases para SQl server y ado.net


Public Class db_conexion
    Dim miConexion As New SqlConnection 'Conectarse a la BD
    Dim miCommand As New SqlCommand 'Ejecutar consultas o sentencias SQL.
    Dim miAdapter As New SqlDataAdapter 'Es un intermediario entre la fuente de datos y la aplicacion... como un puente 
    Dim ds As New DataSet 'Representa una copia de la arquitectura (tablas, campos, indices, llaves, relaciones, datos, etc) de la BD en memoria

    Public Sub New()
        Dim cadenaConexion As String
        cadenaConexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sistemaclinicodb.mdf;Integrated Security=True"
        miConexion.ConnectionString = cadenaConexion

        miConexion.Open()
    End Sub

    Public Function obtenerDatos()
        ds.Clear()

        miCommand.Connection = miConexion

        miCommand.CommandText = "select * from Paciente"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Paciente")
        Return ds
    End Function
    Public Function Btenerdatos()
        ds.Clear()
        miCommand.Connection = miConexion 

        miCommand.CommandText = "select * from registrodepersonal"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "RegistrodePersonal")
        Return ds
    End Function

    Public Function mantenimientoDatosPaciente(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO Paciente (Codigo,Nombre,Apellido,Fecha_Nacimiento,Edad,Sexo,DUI_NIT,Tipo_Sangre,Email,Direccion,Alergico,Examenes_Realizados) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "','" + datos(6) + "','" + datos(7) + "','" + datos(8) + "','" + datos(9) + "','" + datos(10) + "','" + datos(11) + "','" + datos(12) + "') "
            Case "modificar"
                sql = "UPDATE Paciente SET Codigo ='" + datos(1) + "',Nombre='" + datos(2) + "',Apellido='" + datos(3) + "',Fecha_Nacimiento='" + datos(4) + "',Edad='" + datos(5) + "',Sexo='" + datos(6) + "',DUI_NIT='" + datos(7) + "',Tipo_Sangre='" + datos(8) + "',Email='" + datos(9) + "',Direccion='" + datos(10) + "',Alergico='" + datos(11) + "',Examenes_Realizados='" + datos(12) + "'  WHERE idPaciente='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM Paciente WHERE idPaciente='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "Accion realizada con exito"
        Else
            msg = "Fallo el proceso, Porfavor Intentelo de nuevo"
        End If

        Return msg
    End Function


    Public Function mantenimientoDatosRegistrodePersonal(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO registrodepersonal (codigo,nombre,direccion,telefono,email,cargo,horario) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "','" + datos(6) + "','" + datos(7) + "') "
            Case "modificar"
                sql = "UPDATE registrodepersonal SET Codigo ='" + datos(1) + "',nombre='" + datos(2) + "',direccion='" + datos(3) + "',telefono='" + datos(4) + "',email='" + datos(5) + "',cargo='" + datos(6) + "',horario='" + datos(7) + "' WHERE idregistrodepersonal='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM registrodepersonal WHERE idregistrodepersonal='" + datos(0) + "'"
        End Select
        If (executeSql(Sql) > 0) Then
            msg = "Accion realizada con exito"
        Else
            msg = "Fallo el proceso, Porfavor Intentelo de nuevo"
        End If

        Return msg
    End Function

    Private Function executeSql(ByVal sql As String)
        miCommand.Connection = miConexion
        miCommand.CommandText = sql
        Return miCommand.ExecuteNonQuery()
    End Function
End Class