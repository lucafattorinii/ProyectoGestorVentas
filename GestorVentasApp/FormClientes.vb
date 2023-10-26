Imports System.Data.SqlClient


Public Class FormClientes

    Public Class Cliente
        Public Property ID As Integer
        Public Property Nombre As String
        Public Property Telefono As String
        Public Property Correo As String
    End Class

    ' Lista de clientes
    Private listaClientes As New List(Of Cliente)


    Private Sub AgregarCliente_Click(sender As Object, e As EventArgs) Handles AgregarCliente.Click


        ' Obtener los datos del cliente desde los controles de entrada
        Dim nombreCliente As String = TextBoxNombre.Text
        Dim telefonoCliente As String = TextBoxTelefono.Text
        Dim correoCliente As String = TextBoxCorreo.Text

        ' Establecer la cadena de conexión a la base de datos
        Dim connectionString As String = "Server=.\SQLEXPRESS;Database=GestorVentasDB;Integrated Security=True;"



        ' Crear una conexión a SQL Server
        Using connection As New SqlConnection(connectionString)
            Try
                ' Abrir la conexión
                connection.Open()

                ' Crear un comando SQL para insertar el nuevo cliente
                Dim query As String = "INSERT INTO Clientes (Nombre, Telefono, Correo) VALUES (@Nombre, @Telefono, @Correo)"
                Using command As New SqlCommand(query, connection)
                    ' Agregar los parámetros
                    command.Parameters.AddWithValue("@Nombre", nombreCliente)
                    command.Parameters.AddWithValue("@Telefono", telefonoCliente)
                    command.Parameters.AddWithValue("@Correo", correoCliente)

                    ' Ejecutar el comando
                    command.ExecuteNonQuery()

                    ' Mostrar un mensaje de éxito
                    MessageBox.Show("Cliente guardado exitosamente.")

                    ' Limpiar los controles de entrada después de guardar
                    TextBoxNombre.Clear()
                    TextBoxTelefono.Clear()
                    TextBoxCorreo.Clear()
                End Using
            Catch ex As Exception
                ' Capturar y manejar cualquier error
                MessageBox.Show("Error al guardar el cliente: " & ex.Message)
            End Try
        End Using
    End Sub




    Private Sub ActualizarDataGridViewClientes()
        ' Esta función actualiza el DataGridView dgvClientes con la lista actualizada de clientes.
        ' Puedes implementarla según tu estructura de datos y la forma en que llenas el DataGridView.
    End Sub

    Private Sub btnEliminarPorID_Click(sender As Object, e As EventArgs) Handles btnEliminarPorID.Click
        ' Obtener el ID del cliente a eliminar desde el TextBox
        Dim clienteID As Integer

        If Integer.TryParse(txtBuscarPorID.Text, clienteID) Then
            ' Establecer la cadena de conexión a la base de datos
            Dim connectionString As String = "Server=.\SQLEXPRESS;Database=GestorVentasDB;Integrated Security=True;"

            ' Crear una conexión a SQL Server
            Using connection As New SqlConnection(connectionString)
                Try
                    ' Abrir la conexión
                    connection.Open()

                    ' Crear un comando SQL para eliminar el cliente por su ID
                    Dim query As String = "DELETE FROM Clientes WHERE ID = @ClienteID"
                    Using command As New SqlCommand(query, connection)
                        ' Agregar el parámetro para el ID del cliente
                        command.Parameters.AddWithValue("@ClienteID", clienteID)

                        ' Ejecutar el comando
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            ' Actualizar el DataGridView para reflejar los cambios
                            ActualizarDataGridViewClientes()

                            ' Mostrar un mensaje de éxito
                            MessageBox.Show("Cliente con ID " & clienteID & " dado de baja exitosamente.")
                        Else
                            ' Mostrar un mensaje si no se encontró ningún cliente con ese ID
                            MessageBox.Show("No se encontró ningún cliente con el ID " & clienteID & ".")
                        End If
                    End Using
                Catch ex As Exception
                    ' Capturar y manejar cualquier error
                    MessageBox.Show("Error al dar de baja al cliente: " & ex.Message)
                End Try
            End Using
        Else
            ' Mostrar un mensaje de error si el valor ingresado en el TextBox no es un número válido
            MessageBox.Show("Por favor, ingresa un ID de cliente válido.")
        End If
    End Sub





    Private clienteID As Integer

    Private Sub btnBuscarPorIDModificarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarPorIDModificarCliente.Click
        ' Obtener el ID del cliente a buscar desde el TextBox
        Dim clienteID As Integer

        If Integer.TryParse(TextBoxIDClienteModificar.Text, clienteID) Then
            ' Establecer la cadena de conexión a la base de datos
            Dim connectionString As String = "Server=.\SQLEXPRESS;Database=GestorVentasDB;Integrated Security=True;"

            ' Crear una conexión a SQL Server
            Using connection As New SqlConnection(connectionString)
                Try
                    ' Abrir la conexión
                    connection.Open()

                    ' Crear un comando SQL para buscar el cliente por su ID
                    Dim query As String = "SELECT Nombre, Telefono, Correo FROM Clientes WHERE ID = @ClienteID"
                    Using command As New SqlCommand(query, connection)
                        ' Agregar el parámetro para el ID del cliente
                        command.Parameters.AddWithValue("@ClienteID", clienteID)

                        ' Ejecutar la consulta y obtener los resultados
                        Using reader As SqlDataReader = command.ExecuteReader()
                            If reader.Read() Then
                                ' Mostrar los detalles del cliente encontrado
                                TextBoxNuevoNombreCliente.Text = reader.GetString(0)
                                TextBoxNuevoTelefonoCliente.Text = reader.GetString(1)
                                TextBoxNuevoCorreoCliente.Text = reader.GetString(2)
                            Else
                                ' Limpiar los TextBox si no se encontró ningún cliente con ese ID
                                TextBoxNuevoNombreCliente.Clear()
                                TextBoxNuevoTelefonoCliente.Clear()
                                TextBoxNuevoCorreoCliente.Clear()
                                MessageBox.Show("No se encontró ningún cliente con el ID " & clienteID & ".")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    ' Capturar y manejar cualquier error
                    MessageBox.Show("Error al buscar el cliente: " & ex.Message)
                End Try
            End Using
        Else
            ' Mostrar un mensaje de error si el valor ingresado en el TextBox no es un número válido
            MessageBox.Show("Por favor, ingresa un ID de cliente válido.")
        End If
    End Sub

    Private Sub ButtonModificarCliente_Click(sender As Object, e As EventArgs) Handles ButtonModificarCliente.Click
        ' Obtener el ID del cliente a modificar desde el TextBox
        Dim clienteID As Integer

        If Integer.TryParse(TextBoxIDClienteModificar.Text, clienteID) Then
            ' Obtener los nuevos datos del cliente desde los controles de entrada
            Dim nuevoNombreCliente As String = TextBoxNuevoNombreCliente.Text
            Dim nuevoTelefonoCliente As String = TextBoxNuevoTelefonoCliente.Text
            Dim nuevoCorreoCliente As String = TextBoxNuevoCorreoCliente.Text

            ' Establecer la cadena de conexión a la base de datos
            Dim connectionString As String = "Server=.\SQLEXPRESS;Database=GestorVentasDB;Integrated Security=True;"

            ' Crear una conexión a SQL Server
            Using connection As New SqlConnection(connectionString)
                Try
                    ' Abrir la conexión
                    connection.Open()

                    ' Crear un comando SQL para actualizar los datos del cliente
                    Dim query As String = "UPDATE Clientes SET Nombre = @NuevoNombre, Telefono = @NuevoTelefono, Correo = @NuevoCorreo WHERE ID = @ClienteID"
                    Using command As New SqlCommand(query, connection)
                        ' Agregar los parámetros
                        command.Parameters.AddWithValue("@NuevoNombre", nuevoNombreCliente)
                        command.Parameters.AddWithValue("@NuevoTelefono", nuevoTelefonoCliente)
                        command.Parameters.AddWithValue("@NuevoCorreo", nuevoCorreoCliente)
                        command.Parameters.AddWithValue("@ClienteID", clienteID)

                        ' Ejecutar el comando
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            ' Actualizar el DataGridView (si lo tienes) para reflejar los cambios
                            ' Puedes implementar una función similar a la de productos para actualizar clientes en el DataGridView
                            ' ActualizarDataGridViewClientes()

                            ' Mostrar un mensaje de éxito
                            MessageBox.Show("Cliente con ID " & clienteID & " modificado exitosamente.")
                        Else
                            ' Mostrar un mensaje si no se encontró ningún cliente con ese ID
                            MessageBox.Show("No se encontró ningún cliente con el ID " & clienteID & ".")
                        End If
                    End Using
                Catch ex As Exception
                    ' Capturar y manejar cualquier error
                    MessageBox.Show("Error al modificar el cliente: " & ex.Message)
                End Try
            End Using
        Else
            ' Mostrar un mensaje de error si el valor ingresado en el TextBox no es un número válido
            MessageBox.Show("Por favor, ingresa un ID de cliente válido.")
        End If
    End Sub

    ' ... (otras funciones del formulario)



    ' Agregar un botón de búsqueda
    Private Sub ButtonBuscarCliente_Click(sender As Object, e As EventArgs) Handles ButtonBuscarCliente.Click
        ' Obtener los criterios de búsqueda ingresados por el usuario
        Dim nombreCliente As String = TextBoxBuscarNombreCliente.Text
        Dim telefonoCliente As String = If(ComboBoxBuscarTelefonoCliente.SelectedItem IsNot Nothing, ComboBoxBuscarTelefonoCliente.SelectedItem.ToString(), "")

        ' Establecer la cadena de conexión a la base de datos
        Dim connectionString As String = "Server=.\SQLEXPRESS;Database=GestorVentasDB;Integrated Security=True;"

        ' Construir la consulta SQL dinámica con los criterios de búsqueda
        Dim query As String = "SELECT ID, Nombre, Telefono, Correo FROM Clientes WHERE 1=1"

        If Not String.IsNullOrWhiteSpace(nombreCliente) Then
            query &= " AND Nombre LIKE @Nombre"
        End If

        If Not String.IsNullOrWhiteSpace(telefonoCliente) Then
            query &= " AND Telefono = @Telefono"
        End If

        ' Crear una conexión a SQL Server
        Using connection As New SqlConnection(connectionString)
            Try
                ' Abrir la conexión
                connection.Open()

                ' Crear un comando SQL con la consulta y parámetros
                Using command As New SqlCommand(query, connection)
                    If Not String.IsNullOrWhiteSpace(nombreCliente) Then
                        command.Parameters.AddWithValue("@Nombre", "%" & nombreCliente & "%")
                    End If

                    If Not String.IsNullOrWhiteSpace(telefonoCliente) Then
                        command.Parameters.AddWithValue("@Telefono", telefonoCliente)
                    End If

                    ' Crear un adaptador de datos para obtener los resultados
                    Dim adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()

                    ' Llenar el DataTable con los resultados de la consulta
                    adapter.Fill(dataTable)

                    ' Limpiar las columnas predeterminadas del DataGridView
                    dgvClientes.Columns.Clear()

                    ' Enlazar el DataGridView con el DataTable para mostrar los resultados
                    dgvClientes.DataSource = dataTable
                End Using
            Catch ex As Exception
                ' Capturar y manejar cualquier error
                MessageBox.Show("Error al buscar clientes: " & ex.Message)
            End Try
        End Using
    End Sub




    ' Agregar un evento de selección en el DataGridView (dgvClientes)
    Private Sub dgvClientes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvClientes.SelectionChanged
        ' Obtener el cliente seleccionado
        If dgvClientes.SelectedRows.Count > 0 Then
            ' Acceder a los datos del cliente seleccionado
            Dim clienteID As Integer = Convert.ToInt32(dgvClientes.SelectedRows(0).Cells("ID").Value)
            Dim nombreCliente As String = dgvClientes.SelectedRows(0).Cells("Nombre").Value.ToString()
            Dim telefonoCliente As String = dgvClientes.SelectedRows(0).Cells("Telefono").Value.ToString()
            Dim correoCliente As String = dgvClientes.SelectedRows(0).Cells("Correo").Value.ToString()


        End If
    End Sub


End Class


