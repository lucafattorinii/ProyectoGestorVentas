<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.TextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.AgregarCliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBuscarPorID = New System.Windows.Forms.TextBox()
        Me.btnEliminarPorID = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxIDClienteModificar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBuscarPorIDModificarCliente = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxNuevoNombreCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxNuevoTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxNuevoCorreoCliente = New System.Windows.Forms.TextBox()
        Me.ButtonModificarCliente = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxBuscarNombreCliente = New System.Windows.Forms.TextBox()
        Me.ButtonBuscarCliente = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboBoxBuscarTelefonoCliente = New System.Windows.Forms.ComboBox()
        Me.ColumnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnCorreo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(37, 56)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNombre.TabIndex = 0
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Location = New System.Drawing.Point(34, 114)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTelefono.TabIndex = 1
        '
        'TextBoxCorreo
        '
        Me.TextBoxCorreo.Location = New System.Drawing.Point(34, 170)
        Me.TextBoxCorreo.Name = "TextBoxCorreo"
        Me.TextBoxCorreo.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCorreo.TabIndex = 2
        '
        'AgregarCliente
        '
        Me.AgregarCliente.Location = New System.Drawing.Point(34, 220)
        Me.AgregarCliente.Name = "AgregarCliente"
        Me.AgregarCliente.Size = New System.Drawing.Size(75, 23)
        Me.AgregarCliente.TabIndex = 3
        Me.AgregarCliente.Text = "Guardar"
        Me.AgregarCliente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre del cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Correo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Telefono:"
        '
        'dgvClientes
        '
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnID, Me.ColumnNombre, Me.ColumnTelefono, Me.ColumnCorreo})
        Me.dgvClientes.Location = New System.Drawing.Point(256, 372)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(459, 151)
        Me.dgvClientes.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Ingrese ID del cliente para darle de baja:"
        '
        'txtBuscarPorID
        '
        Me.txtBuscarPorID.Location = New System.Drawing.Point(241, 111)
        Me.txtBuscarPorID.Name = "txtBuscarPorID"
        Me.txtBuscarPorID.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscarPorID.TabIndex = 10
        '
        'btnEliminarPorID
        '
        Me.btnEliminarPorID.Location = New System.Drawing.Point(372, 111)
        Me.btnEliminarPorID.Name = "btnEliminarPorID"
        Me.btnEliminarPorID.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminarPorID.TabIndex = 11
        Me.btnEliminarPorID.Text = "Eliminar"
        Me.btnEliminarPorID.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ALTA CLIENTE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(238, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "BAJA CLIENTE:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(541, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "MODIFICAR CLIENTE:"
        '
        'TextBoxIDClienteModificar
        '
        Me.TextBoxIDClienteModificar.Location = New System.Drawing.Point(544, 63)
        Me.TextBoxIDClienteModificar.Name = "TextBoxIDClienteModificar"
        Me.TextBoxIDClienteModificar.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxIDClienteModificar.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(544, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Ingrese ID Cliente para modificarlo:"
        '
        'btnBuscarPorIDModificarCliente
        '
        Me.btnBuscarPorIDModificarCliente.Location = New System.Drawing.Point(665, 59)
        Me.btnBuscarPorIDModificarCliente.Name = "btnBuscarPorIDModificarCliente"
        Me.btnBuscarPorIDModificarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarPorIDModificarCliente.TabIndex = 17
        Me.btnBuscarPorIDModificarCliente.Text = "Buscar"
        Me.btnBuscarPorIDModificarCliente.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(547, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Modifique el cliente:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(541, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Nuevo nombre:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(541, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Nuevo telefono:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(541, 255)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Nuevo correo:"
        '
        'TextBoxNuevoNombreCliente
        '
        Me.TextBoxNuevoNombreCliente.Location = New System.Drawing.Point(544, 170)
        Me.TextBoxNuevoNombreCliente.Name = "TextBoxNuevoNombreCliente"
        Me.TextBoxNuevoNombreCliente.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNuevoNombreCliente.TabIndex = 22
        '
        'TextBoxNuevoTelefonoCliente
        '
        Me.TextBoxNuevoTelefonoCliente.Location = New System.Drawing.Point(544, 217)
        Me.TextBoxNuevoTelefonoCliente.Name = "TextBoxNuevoTelefonoCliente"
        Me.TextBoxNuevoTelefonoCliente.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNuevoTelefonoCliente.TabIndex = 23
        '
        'TextBoxNuevoCorreoCliente
        '
        Me.TextBoxNuevoCorreoCliente.Location = New System.Drawing.Point(544, 272)
        Me.TextBoxNuevoCorreoCliente.Name = "TextBoxNuevoCorreoCliente"
        Me.TextBoxNuevoCorreoCliente.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNuevoCorreoCliente.TabIndex = 24
        '
        'ButtonModificarCliente
        '
        Me.ButtonModificarCliente.Location = New System.Drawing.Point(544, 311)
        Me.ButtonModificarCliente.Name = "ButtonModificarCliente"
        Me.ButtonModificarCliente.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModificarCliente.TabIndex = 25
        Me.ButtonModificarCliente.Text = "Modificar"
        Me.ButtonModificarCliente.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(34, 347)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "BUSCAR CLIENTE:"
        '
        'TextBoxBuscarNombreCliente
        '
        Me.TextBoxBuscarNombreCliente.Location = New System.Drawing.Point(34, 388)
        Me.TextBoxBuscarNombreCliente.Name = "TextBoxBuscarNombreCliente"
        Me.TextBoxBuscarNombreCliente.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBuscarNombreCliente.TabIndex = 29
        '
        'ButtonBuscarCliente
        '
        Me.ButtonBuscarCliente.Location = New System.Drawing.Point(34, 523)
        Me.ButtonBuscarCliente.Name = "ButtonBuscarCliente"
        Me.ButtonBuscarCliente.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBuscarCliente.TabIndex = 30
        Me.ButtonBuscarCliente.Text = "Buscar"
        Me.ButtonBuscarCliente.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(34, 372)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Nombre:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(34, 416)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Telefono:"
        '
        'ComboBoxBuscarTelefonoCliente
        '
        Me.ComboBoxBuscarTelefonoCliente.FormattingEnabled = True
        Me.ComboBoxBuscarTelefonoCliente.Location = New System.Drawing.Point(34, 432)
        Me.ComboBoxBuscarTelefonoCliente.Name = "ComboBoxBuscarTelefonoCliente"
        Me.ComboBoxBuscarTelefonoCliente.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxBuscarTelefonoCliente.TabIndex = 33
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
        'ColumnTelefono
        '
        Me.ColumnTelefono.HeaderText = "Telefono"
        Me.ColumnTelefono.Name = "ColumnTelefono"
        '
        'ColumnCorreo
        '
        Me.ColumnCorreo.HeaderText = "Correo"
        Me.ColumnCorreo.Name = "ColumnCorreo"
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 639)
        Me.Controls.Add(Me.ComboBoxBuscarTelefonoCliente)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ButtonBuscarCliente)
        Me.Controls.Add(Me.TextBoxBuscarNombreCliente)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ButtonModificarCliente)
        Me.Controls.Add(Me.TextBoxNuevoCorreoCliente)
        Me.Controls.Add(Me.TextBoxNuevoTelefonoCliente)
        Me.Controls.Add(Me.TextBoxNuevoNombreCliente)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnBuscarPorIDModificarCliente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxIDClienteModificar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnEliminarPorID)
        Me.Controls.Add(Me.txtBuscarPorID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AgregarCliente)
        Me.Controls.Add(Me.TextBoxCorreo)
        Me.Controls.Add(Me.TextBoxTelefono)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Name = "FormClientes"
        Me.Text = "Clientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents TextBoxCorreo As TextBox
    Friend WithEvents AgregarCliente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBuscarPorID As TextBox
    Friend WithEvents btnEliminarPorID As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxIDClienteModificar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBuscarPorIDModificarCliente As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxNuevoNombreCliente As TextBox
    Friend WithEvents TextBoxNuevoTelefonoCliente As TextBox
    Friend WithEvents TextBoxNuevoCorreoCliente As TextBox
    Friend WithEvents ButtonModificarCliente As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBoxBuscarNombreCliente As TextBox
    Friend WithEvents ButtonBuscarCliente As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents ComboBoxBuscarTelefonoCliente As ComboBox
    Friend WithEvents ColumnID As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNombre As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTelefono As DataGridViewTextBoxColumn
    Friend WithEvents ColumnCorreo As DataGridViewTextBoxColumn
End Class