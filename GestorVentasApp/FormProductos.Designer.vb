<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductos
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
        Me.ButtonModificarProducto = New System.Windows.Forms.Button()
        Me.TextBoxNuevaCategoria = New System.Windows.Forms.TextBox()
        Me.TextBoxNuevoPrecio = New System.Windows.Forms.TextBox()
        Me.TextBoxNuevoNombre = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnBuscarPorIDModificar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxIDProductoModificar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonEliminarProducto = New System.Windows.Forms.Button()
        Me.TextBoxIDProductoEliminar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewProductos = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonAgregarProducto = New System.Windows.Forms.Button()
        Me.TextBoxCategoriaProducto = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecioProducto = New System.Windows.Forms.TextBox()
        Me.TextBoxNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxBuscarNombre = New System.Windows.Forms.TextBox()
        Me.ComboBoxBuscarCategoria = New System.Windows.Forms.ComboBox()
        Me.ButtonBuscarProductos = New System.Windows.Forms.Button()
        Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonModificarProducto
        '
        Me.ButtonModificarProducto.Location = New System.Drawing.Point(561, 318)
        Me.ButtonModificarProducto.Name = "ButtonModificarProducto"
        Me.ButtonModificarProducto.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModificarProducto.TabIndex = 50
        Me.ButtonModificarProducto.Text = "Modificar"
        Me.ButtonModificarProducto.UseVisualStyleBackColor = True
        '
        'TextBoxNuevaCategoria
        '
        Me.TextBoxNuevaCategoria.Location = New System.Drawing.Point(561, 279)
        Me.TextBoxNuevaCategoria.Name = "TextBoxNuevaCategoria"
        Me.TextBoxNuevaCategoria.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNuevaCategoria.TabIndex = 49
        '
        'TextBoxNuevoPrecio
        '
        Me.TextBoxNuevoPrecio.Location = New System.Drawing.Point(561, 224)
        Me.TextBoxNuevoPrecio.Name = "TextBoxNuevoPrecio"
        Me.TextBoxNuevoPrecio.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNuevoPrecio.TabIndex = 48
        '
        'TextBoxNuevoNombre
        '
        Me.TextBoxNuevoNombre.Location = New System.Drawing.Point(561, 177)
        Me.TextBoxNuevoNombre.Name = "TextBoxNuevoNombre"
        Me.TextBoxNuevoNombre.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNuevoNombre.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(561, 263)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 13)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Nueva categoria:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(558, 208)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Nuevo precio:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(558, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Nuevo nombre:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(558, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Modifique el producto:"
        '
        'btnBuscarPorIDModificar
        '
        Me.btnBuscarPorIDModificar.Location = New System.Drawing.Point(682, 66)
        Me.btnBuscarPorIDModificar.Name = "btnBuscarPorIDModificar"
        Me.btnBuscarPorIDModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarPorIDModificar.TabIndex = 42
        Me.btnBuscarPorIDModificar.Text = "Buscar"
        Me.btnBuscarPorIDModificar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(561, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(182, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Ingrese ID Producto para modificarlo:"
        '
        'TextBoxIDProductoModificar
        '
        Me.TextBoxIDProductoModificar.Location = New System.Drawing.Point(561, 70)
        Me.TextBoxIDProductoModificar.Name = "TextBoxIDProductoModificar"
        Me.TextBoxIDProductoModificar.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxIDProductoModificar.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(558, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "MODIFICAR PRODUCTO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(255, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "BAJA PRODUCTO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "ALTA PRODUCTO:"
        '
        'ButtonEliminarProducto
        '
        Me.ButtonEliminarProducto.Location = New System.Drawing.Point(389, 118)
        Me.ButtonEliminarProducto.Name = "ButtonEliminarProducto"
        Me.ButtonEliminarProducto.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEliminarProducto.TabIndex = 36
        Me.ButtonEliminarProducto.Text = "Eliminar"
        Me.ButtonEliminarProducto.UseVisualStyleBackColor = True
        '
        'TextBoxIDProductoEliminar
        '
        Me.TextBoxIDProductoEliminar.Location = New System.Drawing.Point(258, 118)
        Me.TextBoxIDProductoEliminar.Name = "TextBoxIDProductoEliminar"
        Me.TextBoxIDProductoEliminar.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxIDProductoEliminar.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(255, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Ingrese ID del cliente para darle de baja:"
        '
        'DataGridViewProductos
        '
        Me.DataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnNombre, Me.ColumnPrecio, Me.ColumnCategoria})
        Me.DataGridViewProductos.Location = New System.Drawing.Point(258, 409)
        Me.DataGridViewProductos.Name = "DataGridViewProductos"
        Me.DataGridViewProductos.Size = New System.Drawing.Size(240, 151)
        Me.DataGridViewProductos.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Precio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Categoria:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Nombre del producto:"
        '
        'ButtonAgregarProducto
        '
        Me.ButtonAgregarProducto.Location = New System.Drawing.Point(51, 227)
        Me.ButtonAgregarProducto.Name = "ButtonAgregarProducto"
        Me.ButtonAgregarProducto.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAgregarProducto.TabIndex = 29
        Me.ButtonAgregarProducto.Text = "Guardar"
        Me.ButtonAgregarProducto.UseVisualStyleBackColor = True
        '
        'TextBoxCategoriaProducto
        '
        Me.TextBoxCategoriaProducto.Location = New System.Drawing.Point(51, 177)
        Me.TextBoxCategoriaProducto.Name = "TextBoxCategoriaProducto"
        Me.TextBoxCategoriaProducto.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCategoriaProducto.TabIndex = 28
        '
        'TextBoxPrecioProducto
        '
        Me.TextBoxPrecioProducto.Location = New System.Drawing.Point(51, 121)
        Me.TextBoxPrecioProducto.Name = "TextBoxPrecioProducto"
        Me.TextBoxPrecioProducto.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPrecioProducto.TabIndex = 27
        '
        'TextBoxNombreProducto
        '
        Me.TextBoxNombreProducto.Location = New System.Drawing.Point(51, 63)
        Me.TextBoxNombreProducto.Name = "TextBoxNombreProducto"
        Me.TextBoxNombreProducto.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNombreProducto.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(51, 409)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Buscar nombre:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(51, 462)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 13)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Buscar categoria:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(51, 365)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 13)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "BUSCAR PRODUCTO:"
        '
        'TextBoxBuscarNombre
        '
        Me.TextBoxBuscarNombre.Location = New System.Drawing.Point(54, 425)
        Me.TextBoxBuscarNombre.Name = "TextBoxBuscarNombre"
        Me.TextBoxBuscarNombre.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBuscarNombre.TabIndex = 54
        '
        'ComboBoxBuscarCategoria
        '
        Me.ComboBoxBuscarCategoria.FormattingEnabled = True
        Me.ComboBoxBuscarCategoria.Location = New System.Drawing.Point(51, 478)
        Me.ComboBoxBuscarCategoria.Name = "ComboBoxBuscarCategoria"
        Me.ComboBoxBuscarCategoria.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxBuscarCategoria.TabIndex = 55
        '
        'ButtonBuscarProductos
        '
        Me.ButtonBuscarProductos.Location = New System.Drawing.Point(54, 518)
        Me.ButtonBuscarProductos.Name = "ButtonBuscarProductos"
        Me.ButtonBuscarProductos.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBuscarProductos.TabIndex = 56
        Me.ButtonBuscarProductos.Text = "Buscar"
        Me.ButtonBuscarProductos.UseVisualStyleBackColor = True
        '
        'ColumnID
        '
        Me.ColumnID.HeaderText = "ID"
        Me.ColumnID.Name = "ColumnID"
        '
        'ColumnNombre
        '
        Me.ColumnNombre.HeaderText = "Nombre"
        Me.ColumnNombre.Name = "ColumnNombre"
        '
        'ColumnPrecio
        '
        Me.ColumnPrecio.HeaderText = "Precio"
        Me.ColumnPrecio.Name = "ColumnPrecio"
        '
        'ColumnCategoria
        '
        Me.ColumnCategoria.HeaderText = "Categoría"
        Me.ColumnCategoria.Name = "ColumnCategoria"
        '
        'FormProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 701)
        Me.Controls.Add(Me.ButtonBuscarProductos)
        Me.Controls.Add(Me.ComboBoxBuscarCategoria)
        Me.Controls.Add(Me.TextBoxBuscarNombre)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ButtonModificarProducto)
        Me.Controls.Add(Me.TextBoxNuevaCategoria)
        Me.Controls.Add(Me.TextBoxNuevoPrecio)
        Me.Controls.Add(Me.TextBoxNuevoNombre)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnBuscarPorIDModificar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxIDProductoModificar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonEliminarProducto)
        Me.Controls.Add(Me.TextBoxIDProductoEliminar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridViewProductos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonAgregarProducto)
        Me.Controls.Add(Me.TextBoxCategoriaProducto)
        Me.Controls.Add(Me.TextBoxPrecioProducto)
        Me.Controls.Add(Me.TextBoxNombreProducto)
        Me.Name = "FormProductos"
        Me.Text = "Productos"
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonModificarProducto As Button
    Friend WithEvents TextBoxNuevaCategoria As TextBox
    Friend WithEvents TextBoxNuevoPrecio As TextBox
    Friend WithEvents TextBoxNuevoNombre As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnBuscarPorIDModificar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxIDProductoModificar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonEliminarProducto As Button
    Friend WithEvents TextBoxIDProductoEliminar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewProductos As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonAgregarProducto As Button
    Friend WithEvents TextBoxCategoriaProducto As TextBox
    Friend WithEvents TextBoxPrecioProducto As TextBox
    Friend WithEvents TextBoxNombreProducto As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxBuscarNombre As TextBox
    Friend WithEvents ComboBoxBuscarCategoria As ComboBox
    Friend WithEvents ButtonBuscarProductos As Button
    Friend WithEvents ColumnID As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNombre As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPrecio As DataGridViewTextBoxColumn
    Friend WithEvents ColumnCategoria As DataGridViewTextBoxColumn
End Class
