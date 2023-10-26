<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataGridViewItemsVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBoxClientes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonAgregarItemVenta = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.DGVItemsVenta = New System.Windows.Forms.DataGridView()
        Me.TextBoxTotalGeneral = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonModificarItemVenta = New System.Windows.Forms.Button()
        Me.ButtonEliminarItemVenta = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxNuevaCantidad = New System.Windows.Forms.TextBox()
        Me.TextBoxNuevoPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonGuardarVenta = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ButtonBuscarVentas = New System.Windows.Forms.Button()
        Me.DateTimePickerFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateTimePickerFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxIDVenta = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBoxTotalVenta = New System.Windows.Forms.TextBox()
        Me.TextBoxFechaVenta = New System.Windows.Forms.TextBox()
        Me.ColumnidProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Columncantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnprecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnprecioTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnIDVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVItemsVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxClientes
        '
        Me.ComboBoxClientes.FormattingEnabled = True
        Me.ComboBoxClientes.Location = New System.Drawing.Point(52, 64)
        Me.ComboBoxClientes.Name = "ComboBoxClientes"
        Me.ComboBoxClientes.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxClientes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cliente nombre y ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Crear Venta:"
        '
        'ButtonAgregarItemVenta
        '
        Me.ButtonAgregarItemVenta.Location = New System.Drawing.Point(58, 223)
        Me.ButtonAgregarItemVenta.Name = "ButtonAgregarItemVenta"
        Me.ButtonAgregarItemVenta.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAgregarItemVenta.TabIndex = 3
        Me.ButtonAgregarItemVenta.Text = "Agregar"
        Me.ButtonAgregarItemVenta.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad del producto:"
        '
        'TextBoxCantidad
        '
        Me.TextBoxCantidad.Location = New System.Drawing.Point(52, 120)
        Me.TextBoxCantidad.Name = "TextBoxCantidad"
        Me.TextBoxCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCantidad.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Precio unitario:"
        '
        'TextBoxPrecioUnitario
        '
        Me.TextBoxPrecioUnitario.Location = New System.Drawing.Point(55, 178)
        Me.TextBoxPrecioUnitario.Name = "TextBoxPrecioUnitario"
        Me.TextBoxPrecioUnitario.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPrecioUnitario.TabIndex = 7
        '
        'DGVItemsVenta
        '
        Me.DGVItemsVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVItemsVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnidProducto, Me.Columncantidad, Me.ColumnprecioUnitario, Me.ColumnprecioTotal, Me.ColumnIDVenta, Me.ColumnFecha, Me.ColumnTotal})
        Me.DGVItemsVenta.Location = New System.Drawing.Point(52, 270)
        Me.DGVItemsVenta.Name = "DGVItemsVenta"
        Me.DGVItemsVenta.Size = New System.Drawing.Size(447, 150)
        Me.DGVItemsVenta.TabIndex = 8
        '
        'TextBoxTotalGeneral
        '
        Me.TextBoxTotalGeneral.Location = New System.Drawing.Point(399, 178)
        Me.TextBoxTotalGeneral.Name = "TextBoxTotalGeneral"
        Me.TextBoxTotalGeneral.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTotalGeneral.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(396, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total general:"
        '
        'ButtonModificarItemVenta
        '
        Me.ButtonModificarItemVenta.Location = New System.Drawing.Point(631, 156)
        Me.ButtonModificarItemVenta.Name = "ButtonModificarItemVenta"
        Me.ButtonModificarItemVenta.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModificarItemVenta.TabIndex = 11
        Me.ButtonModificarItemVenta.Text = "Modificar"
        Me.ButtonModificarItemVenta.UseVisualStyleBackColor = True
        '
        'ButtonEliminarItemVenta
        '
        Me.ButtonEliminarItemVenta.Location = New System.Drawing.Point(631, 76)
        Me.ButtonEliminarItemVenta.Name = "ButtonEliminarItemVenta"
        Me.ButtonEliminarItemVenta.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEliminarItemVenta.TabIndex = 12
        Me.ButtonEliminarItemVenta.Text = "Eliminar"
        Me.ButtonEliminarItemVenta.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(396, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Nueva cantidad:"
        '
        'TextBoxNuevaCantidad
        '
        Me.TextBoxNuevaCantidad.Location = New System.Drawing.Point(399, 64)
        Me.TextBoxNuevaCantidad.Name = "TextBoxNuevaCantidad"
        Me.TextBoxNuevaCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNuevaCantidad.TabIndex = 14
        '
        'TextBoxNuevoPrecioUnitario
        '
        Me.TextBoxNuevoPrecioUnitario.Location = New System.Drawing.Point(399, 120)
        Me.TextBoxNuevoPrecioUnitario.Name = "TextBoxNuevoPrecioUnitario"
        Me.TextBoxNuevoPrecioUnitario.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNuevoPrecioUnitario.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(396, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Nuevo precio unitario:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(396, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Agreagar Venta:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(628, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Eliminar Venta:"
        '
        'ButtonGuardarVenta
        '
        Me.ButtonGuardarVenta.Location = New System.Drawing.Point(407, 223)
        Me.ButtonGuardarVenta.Name = "ButtonGuardarVenta"
        Me.ButtonGuardarVenta.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGuardarVenta.TabIndex = 19
        Me.ButtonGuardarVenta.Text = "Guardar"
        Me.ButtonGuardarVenta.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(621, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(208, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Seleccionar un item ventas para eliminarlo:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(621, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(215, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Seleccionar un item ventas para modificarlo:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(49, 460)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Buscar Ventas:"
        '
        'ButtonBuscarVentas
        '
        Me.ButtonBuscarVentas.Location = New System.Drawing.Point(52, 591)
        Me.ButtonBuscarVentas.Name = "ButtonBuscarVentas"
        Me.ButtonBuscarVentas.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBuscarVentas.TabIndex = 23
        Me.ButtonBuscarVentas.Text = "Buscar"
        Me.ButtonBuscarVentas.UseVisualStyleBackColor = True
        '
        'DateTimePickerFechaInicio
        '
        Me.DateTimePickerFechaInicio.Location = New System.Drawing.Point(52, 498)
        Me.DateTimePickerFechaInicio.Name = "DateTimePickerFechaInicio"
        Me.DateTimePickerFechaInicio.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerFechaInicio.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(49, 482)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Fecha de inicio:"
        '
        'DateTimePickerFechaFin
        '
        Me.DateTimePickerFechaFin.Location = New System.Drawing.Point(52, 548)
        Me.DateTimePickerFechaFin.Name = "DateTimePickerFechaFin"
        Me.DateTimePickerFechaFin.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerFechaFin.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(49, 532)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Fecha final:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(367, 482)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "ID Ventas:"
        '
        'TextBoxIDVenta
        '
        Me.TextBoxIDVenta.Location = New System.Drawing.Point(368, 498)
        Me.TextBoxIDVenta.Name = "TextBoxIDVenta"
        Me.TextBoxIDVenta.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxIDVenta.TabIndex = 29
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(367, 577)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 13)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Total de una Ventas:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(367, 532)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Fecha:"
        '
        'TextBoxTotalVenta
        '
        Me.TextBoxTotalVenta.Location = New System.Drawing.Point(368, 593)
        Me.TextBoxTotalVenta.Name = "TextBoxTotalVenta"
        Me.TextBoxTotalVenta.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTotalVenta.TabIndex = 32
        '
        'TextBoxFechaVenta
        '
        Me.TextBoxFechaVenta.Location = New System.Drawing.Point(368, 548)
        Me.TextBoxFechaVenta.Name = "TextBoxFechaVenta"
        Me.TextBoxFechaVenta.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxFechaVenta.TabIndex = 33
        '
        'ColumnidProducto
        '
        Me.ColumnidProducto.HeaderText = "idProducto"
        Me.ColumnidProducto.Name = "ColumnidProducto"
        '
        'Columncantidad
        '
        Me.Columncantidad.HeaderText = "cantidad"
        Me.Columncantidad.Name = "Columncantidad"
        '
        'ColumnprecioUnitario
        '
        Me.ColumnprecioUnitario.HeaderText = "precioUnitario"
        Me.ColumnprecioUnitario.Name = "ColumnprecioUnitario"
        '
        'ColumnprecioTotal
        '
        Me.ColumnprecioTotal.HeaderText = "precioTotal"
        Me.ColumnprecioTotal.Name = "ColumnprecioTotal"
        '
        'ColumnIDVenta
        '
        Me.ColumnIDVenta.HeaderText = "ID Venta"
        Me.ColumnIDVenta.Name = "ColumnIDVenta"
        '
        'ColumnFecha
        '
        Me.ColumnFecha.HeaderText = "Fecha"
        Me.ColumnFecha.Name = "ColumnFecha"
        '
        'ColumnTotal
        '
        Me.ColumnTotal.HeaderText = "Total de una venta"
        Me.ColumnTotal.Name = "ColumnTotal"
        '
        'DataGridViewItemsVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 637)
        Me.Controls.Add(Me.TextBoxFechaVenta)
        Me.Controls.Add(Me.TextBoxTotalVenta)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TextBoxIDVenta)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DateTimePickerFechaFin)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DateTimePickerFechaInicio)
        Me.Controls.Add(Me.ButtonBuscarVentas)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ButtonGuardarVenta)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxNuevoPrecioUnitario)
        Me.Controls.Add(Me.TextBoxNuevaCantidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonEliminarItemVenta)
        Me.Controls.Add(Me.ButtonModificarItemVenta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxTotalGeneral)
        Me.Controls.Add(Me.DGVItemsVenta)
        Me.Controls.Add(Me.TextBoxPrecioUnitario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxCantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonAgregarItemVenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxClientes)
        Me.Name = "DataGridViewItemsVenta"
        Me.Text = "Ventas"
        CType(Me.DGVItemsVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxClientes As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonAgregarItemVenta As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCantidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxPrecioUnitario As TextBox
    Friend WithEvents DGVItemsVenta As DataGridView
    Friend WithEvents TextBoxTotalGeneral As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonModificarItemVenta As Button
    Friend WithEvents ButtonEliminarItemVenta As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxNuevaCantidad As TextBox
    Friend WithEvents TextBoxNuevoPrecioUnitario As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ButtonGuardarVenta As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ButtonBuscarVentas As Button
    Friend WithEvents DateTimePickerFechaInicio As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents DateTimePickerFechaFin As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxIDVenta As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBoxTotalVenta As TextBox
    Friend WithEvents TextBoxFechaVenta As TextBox
    Friend WithEvents ColumnidProducto As DataGridViewTextBoxColumn
    Friend WithEvents Columncantidad As DataGridViewTextBoxColumn
    Friend WithEvents ColumnprecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents ColumnprecioTotal As DataGridViewTextBoxColumn
    Friend WithEvents ColumnIDVenta As DataGridViewTextBoxColumn
    Friend WithEvents ColumnFecha As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTotal As DataGridViewTextBoxColumn
End Class
