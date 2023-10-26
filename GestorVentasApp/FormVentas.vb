Imports System.Data.SqlClient

Public Class DataGridViewItemsVenta

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar la lista de clientes desde la base de datos al ComboBox de clientes
        CargarClientes()
    End Sub

    Private Sub CargarClientes()
        ' Establecer la cadena de conexión a la base de datos
        Dim connectionString As String = "Server=.\SQLEXPRESS;Database=GestorVentasDB;Integrated Security=True;"

        ' Crear una conexión a SQL Server
        Using connection As New SqlConnection(connectionString)
            Try
                ' Abrir la conexión
                connection.Open()

                ' Crear un comando SQL para seleccionar todos los clientes
                Dim query As String = "SELECT ID, Nombre FROM Clientes"
                Using command As New SqlCommand(query, connection)
                    ' Crear un adaptador de datos y un DataTable para los clientes
                    Dim adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()

                    ' Llenar el DataTable con los clientes
                    adapter.Fill(dataTable)

                    ' Enlazar el DataTable con el ComboBox de clientes
                    ComboBoxClientes.DataSource = dataTable
                    ComboBoxClientes.DisplayMember = "Nombre"
                    ComboBoxClientes.ValueMember = "ID"
                End Using
            Catch ex As Exception
                ' Capturar y manejar cualquier error
                MessageBox.Show("Error al cargar la lista de clientes: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ButtonAgregarItemVenta_Click(sender As Object, e As EventArgs) Handles ButtonAgregarItemVenta.Click
        ' Obtener los datos del producto y cantidad desde los controles de entrada
        Dim idProducto As Integer ' Debes obtener el ID del producto seleccionado
        Dim cantidad As Integer
        Dim precioUnitario As Decimal

        If Integer.TryParse(TextBoxCantidad.Text, cantidad) AndAlso Decimal.TryParse(TextBoxPrecioUnitario.Text, precioUnitario) Then
            ' Calcular el precio total del ítem
            Dim precioTotal As Decimal = cantidad * precioUnitario

            ' Agregar el ítem al DataGridView de ítems de venta
            DGVItemsVenta.Rows.Add(idProducto, cantidad, precioUnitario, precioTotal)

            ' Calcular y mostrar el Total General
            CalcularTotalGeneral()
        Else
            ' Mostrar un mensaje de error si los valores ingresados no son válidos
            MessageBox.Show("Por favor, ingresa una cantidad y precio unitario válidos.")
        End If
    End Sub

    Private Sub CalcularTotalGeneral()
        ' Calcular el Total General sumando los precios totales de los ítems de venta en el DataGridView
        Dim totalGeneral As Decimal = 0

        For Each row As DataGridViewRow In DGVItemsVenta.Rows
            Dim precioTotal As Decimal = Convert.ToDecimal(row.Cells("ColumnPrecioTotal").Value)
            totalGeneral += precioTotal
        Next

        ' Mostrar el Total General en un TextBox o etiqueta
        TextBoxTotalGeneral.Text = totalGeneral.ToString("C")
    End Sub

    Private Sub ButtonEliminarItemVenta_Click(sender As Object, e As EventArgs) Handles ButtonEliminarItemVenta.Click
        ' Eliminar el ítem seleccionado del DataGridView de ítems de venta
        If DGVItemsVenta.SelectedRows.Count > 0 Then
            DGVItemsVenta.Rows.Remove(DGVItemsVenta.SelectedRows(0))

            ' Recalcular el Total General después de eliminar un ítem
            CalcularTotalGeneral()
        Else
            ' Mostrar un mensaje si no se ha seleccionado ningún ítem para eliminar
            MessageBox.Show("Por favor, selecciona un ítem de venta para eliminar.")
        End If
    End Sub

    Private Sub ButtonModificarItemVenta_Click(sender As Object, e As EventArgs) Handles ButtonModificarItemVenta.Click
        ' Modificar el ítem seleccionado del DataGridView de ítems de venta
        If DGVItemsVenta.SelectedRows.Count > 0 Then
            ' Obtener los nuevos valores de cantidad y precio unitario desde los controles de entrada
            Dim nuevaCantidad As Integer
            Dim nuevoPrecioUnitario As Decimal

            If Integer.TryParse(TextBoxNuevaCantidad.Text, nuevaCantidad) AndAlso Decimal.TryParse(TextBoxNuevoPrecioUnitario.Text, nuevoPrecioUnitario) Then
                ' Obtener el índice de la fila seleccionada
                Dim rowIndex As Integer = DGVItemsVenta.SelectedRows(0).Index

                ' Actualizar los valores en el DataGridView
                DGVItemsVenta.Rows(rowIndex).Cells("ColumnCantidad").Value = nuevaCantidad
                DGVItemsVenta.Rows(rowIndex).Cells("ColumnPrecioUnitario").Value = nuevoPrecioUnitario

                ' Recalcular el precio total del ítem modificado
                Dim precioTotal As Decimal = nuevaCantidad * nuevoPrecioUnitario
                DGVItemsVenta.Rows(rowIndex).Cells("ColumnPrecioTotal").Value = precioTotal

                ' Recalcular el Total General después de modificar un ítem
                CalcularTotalGeneral()
            Else
                ' Mostrar un mensaje de error si los nuevos valores no son válidos
                MessageBox.Show("Por favor, ingresa una cantidad y precio unitario válidos para modificar el ítem.")
            End If
        Else
            ' Mostrar un mensaje si no se ha seleccionado ningún ítem para modificar
            MessageBox.Show("Por favor, selecciona un ítem de venta para modificar.")
        End If
    End Sub

    Private Sub ButtonGuardarVenta_Click(sender As Object, e As EventArgs) Handles ButtonGuardarVenta.Click
        ' Obtener el ID del cliente seleccionado desde el ComboBox
        Dim idCliente As Integer = Convert.ToInt32(ComboBoxClientes.SelectedValue)

        ' Obtener la fecha actual
        Dim fechaVenta As Date = DateTime.Now

        ' Obtener el Total General desde el TextBox
        Dim totalGeneral As Decimal

        If Decimal.TryParse(TextBoxTotalGeneral.Text, totalGeneral) Then
            ' Establecer la cadena de conexión a la base de datos
            Dim connectionString As String = "Server=.\SQLEXPRESS;Database=GestorVentasDB;Integrated Security=True;"

            ' Crear una conexión a SQL Server
            Using connection As New SqlConnection(connectionString)
                Try
                    ' Abrir la conexión
                    connection.Open()

                    ' Crear un comando SQL para insertar la nueva venta
                    Dim query As String = "INSERT INTO Ventas (IDCliente, Fecha, Total) VALUES (@IDCliente, @Fecha, @Total)"
                    Using command As New SqlCommand(query, connection)
                        ' Agregar los parámetros
                        command.Parameters.AddWithValue("@IDCliente", idCliente)
                        command.Parameters.AddWithValue("@Fecha", fechaVenta)
                        command.Parameters.AddWithValue("@Total", totalGeneral)

                        ' Ejecutar el comando
                        command.ExecuteNonQuery()

                        ' Mostrar un mensaje de éxito
                        MessageBox.Show("Venta guardada exitosamente.")

                        ' Limpiar los controles del formulario después de guardar
                        LimpiarFormularioVenta()
                    End Using
                Catch ex As Exception
                    ' Capturar y manejar cualquier error
                    MessageBox.Show("Error al guardar la venta: " & ex.Message)
                End Try
            End Using
        Else
            ' Mostrar un mensaje de error si el Total General no es un número válido
            MessageBox.Show("Por favor, ingresa un Total General válido.")
        End If
    End Sub

    Private Sub LimpiarFormularioVenta()
        ' Limpiar los controles del formulario de ventas
        ComboBoxClientes.SelectedIndex = -1
        TextBoxCantidad.Clear()
        TextBoxPrecioUnitario.Clear()
        DGVItemsVenta.Rows.Clear()
        TextBoxTotalGeneral.Clear()
    End Sub

    Private Sub ButtonBuscarVentas_Click(sender As Object, e As EventArgs) Handles ButtonBuscarVentas.Click
        ' Obtener el rango de fechas ingresado por el usuario
        Dim fechaInicio As Date = DateTimePickerFechaInicio.Value
        Dim fechaFin As Date = DateTimePickerFechaFin.Value

        ' Realizar la consulta SQL para buscar ventas dentro del rango de fechas
        Dim query As String = "SELECT ID, IDCliente, Fecha, Total FROM Ventas WHERE Fecha BETWEEN @FechaInicio AND @FechaFin"

        ' Establecer la cadena de conexión (ajusta esto según tu configuración)
        Dim connectionString As String = "Server=.\SQLEXPRESS;Database=GestorVentasDB;Integrated Security=True;"

        ' Crear una conexión a SQL Server
        Using connection As New SqlConnection(connectionString)
            Try
                ' Abrir la conexión
                connection.Open()

                ' Crear un comando SQL
                Using command As New SqlCommand(query, connection)
                    ' Agregar parámetros
                    command.Parameters.AddWithValue("@FechaInicio", fechaInicio)
                    command.Parameters.AddWithValue("@FechaFin", fechaFin)

                    ' Crear un adaptador de datos y un DataTable
                    Dim adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()

                    ' Llenar el DataTable con los resultados de la consulta
                    adapter.Fill(dataTable)

                    ' Enlazar el DataTable al DataGridView para mostrar los resultados
                    DGVItemsVenta.DataSource = dataTable
                End Using
            Catch ex As Exception
                ' Manejar errores si ocurren
                MessageBox.Show("Error al buscar ventas: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub DGVItemsVenta_SelectionChanged(sender As Object, e As EventArgs) Handles DGVItemsVenta.SelectionChanged
        ' Verificar si hay una fila seleccionada
        If DGVItemsVenta.SelectedRows.Count > 0 Then
            ' Obtener los datos de la venta seleccionada
            Dim idVenta As Integer = Convert.ToInt32(DGVItemsVenta.SelectedRows(0).Cells("ID").Value)
            Dim idCliente As Integer = Convert.ToInt32(DGVItemsVenta.SelectedRows(0).Cells("IDCliente").Value)
            Dim fechaVenta As Date = Convert.ToDateTime(DGVItemsVenta.SelectedRows(0).Cells("Fecha").Value)
            Dim totalVenta As Decimal = Convert.ToDecimal(DGVItemsVenta.SelectedRows(0).Cells("Total").Value)

            ' Mostrar los detalles de la venta seleccionada
            TextBoxIDVenta.Text = idVenta.ToString()
            ComboBoxClientes.SelectedValue = idCliente
            TextBoxFechaVenta.Text = fechaVenta.ToString("dd/MM/yyyy")
            TextBoxTotalVenta.Text = totalVenta.ToString("C")
        End If
    End Sub

End Class
