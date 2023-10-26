Imports System.Data.SqlClient


Public Class FormProductos

    Public Class Producto
        Public Property ID As Integer
        Public Property Nombre As String
        Public Property Precio As Decimal
        Public Property Categoria As String
    End Class

    ' Lista de productos
    Private listaProductos As New List(Of Producto)

    Private Sub ButtonAgregarProducto_Click(sender As Object, e As EventArgs) Handles ButtonAgregarProducto.Click
        ' Obtener los datos del producto desde los controles de entrada
        Dim nombreProducto As String = TextBoxNombreProducto.Text
        Dim precioProducto As Decimal
        Dim categoriaProducto As String = TextBoxCategoriaProducto.Text

        If Decimal.TryParse(TextBoxPrecioProducto.Text, precioProducto) Then
            ' Establecer la cadena de conexión a la base de datos
            Dim connectionString As String = "Server=.\SQLEXPRESS;Database=GestorVentasDB;Integrated Security=True;"

            ' Crear una conexión a SQL Server
            Using connection As New SqlConnection(connectionString)
                Try
                    ' Abrir la conexión
                    connection.Open()

                    ' Crear un comando SQL para insertar el nuevo producto
                    Dim query As String = "INSERT INTO Productos (Nombre, Precio, Categoria) VALUES (@Nombre, @Precio, @Categoria)"
                    Using command As New SqlCommand(query, connection)
                        ' Agregar los parámetros
                        command.Parameters.AddWithValue("@Nombre", nombreProducto)
                        command.Parameters.AddWithValue("@Precio", precioProducto)
                        command.Parameters.AddWithValue("@Categoria", categoriaProducto)

                        ' Ejecutar el comando
                        command.ExecuteNonQuery()

                        ' Mostrar un mensaje de éxito
                        MessageBox.Show("Producto guardado exitosamente.")

                        ' Limpiar los controles de entrada después de guardar
                        TextBoxNombreProducto.Clear()
                        TextBoxPrecioProducto.Clear()
                        TextBoxCategoriaProducto.Clear()
                    End Using
                Catch ex As Exception
                    ' Capturar y manejar cualquier error
                    MessageBox.Show("Error al guardar el producto: " & ex.Message)
                End Try
            End Using
        Else
            ' Mostrar un mensaje de error si el precio no es un número válido
            MessageBox.Show("Por favor, ingresa un precio válido.")
        End If
    End Sub




    ' ...

    Private Sub ButtonEliminarProducto_Click(sender As Object, e As EventArgs) Handles ButtonEliminarProducto.Click
        ' Obtener el ID del producto a eliminar desde el TextBox
        Dim productoID As Integer

        If Integer.TryParse(TextBoxIDProductoEliminar.Text, productoID) Then
            ' Establecer la cadena de conexión a la base de datos
            Dim connectionString As String = "Server=.\SQLEXPRESS;Database=GestorVentasDB;Integrated Security=True;"

            ' Crear una conexión a SQL Server
            Using connection As New SqlConnection(connectionString)
                Try
                    ' Abrir la conexión
                    connection.Open()

                    ' Crear un comando SQL para eliminar el producto por su ID
                    Dim query As String = "DELETE FROM Productos WHERE ID = @ProductoID"
                    Using command As New SqlCommand(query, connection)
                        ' Agregar el parámetro para el ID del producto
                        command.Parameters.AddWithValue("@ProductoID", productoID)

                        ' Ejecutar el comando
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            ' Actualizar el DataGridView para reflejar los cambios
                            ActualizarDataGridViewProductos()

                            ' Mostrar un mensaje de éxito
                            MessageBox.Show("Producto con ID " & productoID & " eliminado exitosamente.")
                        Else
                            ' Mostrar un mensaje si no se encontró ningún producto con ese ID
                            MessageBox.Show("No se encontró ningún producto con el ID " & productoID & ".")
                        End If
                    End Using
                Catch ex As Exception
                    ' Capturar y manejar cualquier error
                    MessageBox.Show("Error al eliminar el producto: " & ex.Message)
                End Try
            End Using
        Else
            ' Mostrar un mensaje de error si el valor ingresado en el TextBox no es un número válido
            MessageBox.Show("Por favor, ingresa un ID de producto válido.")
        End If
    End Sub

    Private Sub btnBuscarPorIDModificar_Click(sender As Object, e As EventArgs) Handles btnBuscarPorIDModificar.Click
        ' Obtener el ID del producto a buscar desde el TextBox
        Dim productoID As Integer

        If Integer.TryParse(TextBoxIDProductoModificar.Text, productoID) Then
            ' Establecer la cadena de conexión a la base de datos
            Dim connectionString As String = "Server=.\SQLEXPRESS;Database=GestorVentasDB;Integrated Security=True;"

            ' Crear una conexión a SQL Server
            Using connection As New SqlConnection(connectionString)
                Try
                    ' Abrir la conexión
                    connection.Open()

                    ' Crear un comando SQL para buscar el producto por su ID
                    Dim query As String = "SELECT Nombre, Precio, Categoria FROM Productos WHERE ID = @ProductoID"
                    Using command As New SqlCommand(query, connection)
                        ' Agregar el parámetro para el ID del producto
                        command.Parameters.AddWithValue("@ProductoID", productoID)

                        ' Ejecutar la consulta y obtener los resultados
                        Using reader As SqlDataReader = command.ExecuteReader()
                            If reader.Read() Then
                                ' Mostrar los detalles del producto encontrado
                                TextBoxNuevoNombre.Text = reader.GetString(0)
                                TextBoxNuevoPrecio.Text = reader.GetDecimal(1).ToString()
                                TextBoxNuevaCategoria.Text = reader.GetString(2)
                            Else
                                ' Limpiar los TextBox si no se encontró ningún producto con ese ID
                                TextBoxNuevoNombre.Clear()
                                TextBoxNuevoPrecio.Clear()
                                TextBoxNuevaCategoria.Clear()
                                MessageBox.Show("No se encontró ningún producto con el ID " & productoID & ".")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    ' Capturar y manejar cualquier error
                    MessageBox.Show("Error al buscar el producto: " & ex.Message)
                End Try
            End Using
        Else
            ' Mostrar un mensaje de error si el valor ingresado en el TextBox no es un número válido
            MessageBox.Show("Por favor, ingresa un ID de producto válido.")
        End If
    End Sub

    Private Sub ButtonModificarProducto_Click(sender As Object, e As EventArgs) Handles ButtonModificarProducto.Click
        ' Obtener el ID del producto a modificar desde el TextBox
        Dim productoID As Integer

        If Integer.TryParse(TextBoxIDProductoModificar.Text, productoID) Then
            ' Obtener los nuevos datos del producto desde los controles de entrada
            Dim nuevoNombre As String = TextBoxNuevoNombre.Text
            Dim nuevoPrecio As Decimal
            Dim nuevaCategoria As String = TextBoxNuevaCategoria.Text

            If Decimal.TryParse(TextBoxNuevoPrecio.Text, nuevoPrecio) Then
                ' Establecer la cadena de conexión a la base de datos
                Dim connectionString As String = "Server=.\SQLEXPRESS;Database=GestorVentasDB;Integrated Security=True;"

                ' Crear una conexión a SQL Server
                Using connection As New SqlConnection(connectionString)
                    Try
                        ' Abrir la conexión
                        connection.Open()

                        ' Crear un comando SQL para actualizar los datos del producto
                        Dim query As String = "UPDATE Productos SET Nombre = @NuevoNombre, Precio = @NuevoPrecio, Categoria = @NuevaCategoria WHERE ID = @ProductoID"
                        Using command As New SqlCommand(query, connection)
                            ' Agregar los parámetros
                            command.Parameters.AddWithValue("@NuevoNombre", nuevoNombre)
                            command.Parameters.AddWithValue("@NuevoPrecio", nuevoPrecio)
                            command.Parameters.AddWithValue("@NuevaCategoria", nuevaCategoria)
                            command.Parameters.AddWithValue("@ProductoID", productoID)

                            ' Ejecutar el comando
                            Dim rowsAffected As Integer = command.ExecuteNonQuery()

                            If rowsAffected > 0 Then
                                ' Actualizar el DataGridView para reflejar los cambios
                                ActualizarDataGridViewProductos()

                                ' Mostrar un mensaje de éxito
                                MessageBox.Show("Producto con ID " & productoID & " modificado exitosamente.")
                            Else
                                ' Mostrar un mensaje si no se encontró ningún producto con ese ID
                                MessageBox.Show("No se encontró ningún producto con el ID " & productoID & ".")
                            End If
                        End Using
                    Catch ex As Exception
                        ' Capturar y manejar cualquier error
                        MessageBox.Show("Error al modificar el producto: " & ex.Message)
                    End Try
                End Using
            Else
                ' Mostrar un mensaje de error si el precio no es un número válido
                MessageBox.Show("Por favor, ingresa un precio válido.")
            End If
        Else
            ' Mostrar un mensaje de error si el valor ingresado en el TextBox no es un número válido
            MessageBox.Show("Por favor, ingresa un ID de producto válido.")
        End If
    End Sub


    ' ...

    ' La función ActualizarDataGridViewProductos para reflejar los cambios en el DataGridView
    Private Sub ActualizarDataGridViewProductos()
        ' Limpia los datos actuales en el DataGridView
        DataGridViewProductos.Rows.Clear()

        ' Recorre la lista de productos y agrega cada producto al DataGridView
        For Each producto As Producto In listaProductos
            Dim rowIndex As Integer = DataGridViewProductos.Rows.Add()
            DataGridViewProductos.Rows(rowIndex).Cells("ColumnID").Value = producto.ID
            DataGridViewProductos.Rows(rowIndex).Cells("ColumnNombre").Value = producto.Nombre
            DataGridViewProductos.Rows(rowIndex).Cells("ColumnPrecio").Value = producto.Precio
            DataGridViewProductos.Rows(rowIndex).Cells("ColumnCategoria").Value = producto.Categoria
        Next
    End Sub


    Private Sub ButtonBuscarProductos_Click(sender As Object, e As EventArgs) Handles ButtonBuscarProductos.Click
        ' Obtener los criterios de búsqueda y filtros ingresados por el usuario
        Dim nombreProducto As String = TextBoxBuscarNombre.Text
        Dim categoriaProducto As String = ComboBoxBuscarCategoria.Text

        ' Establecer la cadena de conexión a la base de datos
        Dim connectionString As String = "Server=.\SQLEXPRESS;Database=GestorVentasDB;Integrated Security=True;"

        ' Construir la consulta SQL dinámica con los criterios de búsqueda y filtros
        Dim query As String = "SELECT ID, Nombre, Precio, Categoria FROM Productos WHERE 1=1"

        If Not String.IsNullOrWhiteSpace(nombreProducto) Then
            query &= " AND Nombre LIKE @Nombre"
        End If

        If Not String.IsNullOrWhiteSpace(categoriaProducto) Then
            query &= " AND Categoria = @Categoria"
        End If

        ' Crear una conexión a SQL Server
        Using connection As New SqlConnection(connectionString)
            Try
                ' Abrir la conexión
                connection.Open()

                ' Crear un comando SQL con la consulta y parámetros
                Using command As New SqlCommand(query, connection)
                    If Not String.IsNullOrWhiteSpace(nombreProducto) Then
                        command.Parameters.AddWithValue("@Nombre", "%" & nombreProducto & "%")
                    End If

                    If Not String.IsNullOrWhiteSpace(categoriaProducto) Then
                        command.Parameters.AddWithValue("@Categoria", categoriaProducto)
                    End If

                    ' Ejecutar la consulta y obtener los resultados
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Limpiar el DataGridView antes de agregar los resultados
                        DataGridViewProductos.Rows.Clear()

                        ' Leer los resultados y agregarlos al DataGridView
                        While reader.Read()
                            Dim producto As New Producto()
                            producto.ID = reader.GetInt32(0)
                            producto.Nombre = reader.GetString(1)
                            producto.Precio = reader.GetDecimal(2)
                            producto.Categoria = reader.GetString(3)

                            ' Agregar el producto al DataGridView
                            Dim rowIndex As Integer = DataGridViewProductos.Rows.Add()
                            DataGridViewProductos.Rows(rowIndex).Cells("ColumnID").Value = producto.ID
                            DataGridViewProductos.Rows(rowIndex).Cells("ColumnNombre").Value = producto.Nombre
                            DataGridViewProductos.Rows(rowIndex).Cells("ColumnPrecio").Value = producto.Precio
                            DataGridViewProductos.Rows(rowIndex).Cells("ColumnCategoria").Value = producto.Categoria
                        End While
                    End Using
                End Using
            Catch ex As Exception
                ' Capturar y manejar cualquier error
                MessageBox.Show("Error al buscar productos: " & ex.Message)
            End Try
        End Using
    End Sub


End Class
