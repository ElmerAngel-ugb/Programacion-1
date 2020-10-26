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
        Parametrizacion()
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
    Public Function Obtenerdato()
        ds.Clear()
        miCommand.Connection = miConexion

        miCommand.CommandText = "select * from categorias"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "categorias")

        miCommand.CommandText = "
            select productos.IdProductos, productos.idCategoria, productos.codigo, productos.nombre,productos.descripcion,productos.laboratorio,
                productos.cantidad, categorias.categoria 
            from productos
                inner join categorias on(categorias.idCategoria=productos.idCategoria)
        "
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "productos")

        Return ds

    End Function

    Public Function Btenerdatospaciente(ByVal tuidepaciente As String)
        ds.Clear()
        miCommand.Connection = miConexion

        miCommand.CommandText = "select * from paciente where IdPaciente = " + tuidepaciente
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "idpaciente")


        Return ds
    End Function

    Public Function Datos()
        ds.Clear()

        miCommand.Connection = miConexion

        miCommand.CommandText = "select * from receta"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "receta")

        Return ds
    End Function
    Public Function mantenimientoDatosreceta(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO receta (medico,paciente,descripcion,dosis,fecha_emision) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "') "
            Case "modificar"
                sql = "UPDATE receta SET medico='" + datos(1) + "',paciente='" + datos(2) + "',descripion='" + datos(3) + "',dosis='" + datos(4) + "',fecha_emision='" + datos(5) + "' WHERE Idreceta='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM receta WHERE Idreceta='" + datos(0) + "'"
        End Select

        If (executeSql(sql) > 0) Then

            msg = "Accion realizada con exito"
        Else
            msg = "Fallo el proceso, Porfavor Intentelo de nuevo"
        End If

        Return msg
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

#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
        If executeSql(sql) > 0 Then
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
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
#Disable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
        If (executeSql(sql) > 0) Then
#Enable Warning BC42104 ' Se usa la variable antes de que se le haya asignado un valor
            msg = "Accion realizada con exito"
        Else
            msg = "Fallo el proceso, Porfavor Intentelo de nuevo"
        End If

        Return msg
    End Function
    Private Sub Parametrizacion()
        miCommand.Parameters.Add("@id", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@idCategoria", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@ide", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@cat", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@cod", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@nom", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@des", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@lab", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@can", SqlDbType.Char).Value = ""

    End Sub
    Public Function mantenimientoDatosProductos(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO productos (idCategoria,codigo,nombre,descripcion,laboratorio,cantidad) VALUES(@idCategoria,@cod,@nom,@des,@lab,@can)"
            Case "modificar"
                sql = "UPDATE productos SET idCategoria=@idCategoria,codigo=@cod,nombre=@nom,descripcion=@des,laboratorio=@lab,cantidad=@can WHERE Idproductos=@ide"
            Case "eliminar"
                sql = "DELETE FROM productos WHERE Idproductos=@ide"
        End Select

        miCommand.Parameters("@ide").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@idCategoria").Value = datos(1)
            miCommand.Parameters("@cod").Value = datos(2)
            miCommand.Parameters("@nom").Value = datos(3)
            miCommand.Parameters("@des").Value = datos(4)
            miCommand.Parameters("@lab").Value = datos(5)
            miCommand.Parameters("@can").Value = datos(6)
        End If
        If executeSql(sql) > 0 Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoDatosCategoria(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO categorias (categoria) VALUES(@cat)"
            Case "modificar"
                sql = "UPDATE categorias SET categoria=@cat WHERE idCategoria=@ide"
            Case "eliminar"
                sql = "DELETE FROM categorias WHERE idCategoria=@ide"
        End Select
        miCommand.Parameters("@ide").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@cat").Value = datos(1)
        End If
        If executeSql(sql) > 0 Then
            msg = "exito"
        Else
            msg = "error"
        End If
        Return msg
    End Function
    Private Function executeSql(ByVal sql As String)
        Try
            miCommand.Connection = miConexion
            miCommand.CommandText = sql
            Return miCommand.ExecuteNonQuery()
        Catch ex As Exception
            Return 0
        End Try
    End Function

End Class