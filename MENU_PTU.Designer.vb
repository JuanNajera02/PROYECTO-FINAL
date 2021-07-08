<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_PTU
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_resultados = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_cuenta_email = New System.Windows.Forms.TextBox()
        Me.txt_cuenta_bancaria = New System.Windows.Forms.TextBox()
        Me.txt_sueldo_diario = New System.Windows.Forms.TextBox()
        Me.txt_dias_trabajados = New System.Windows.Forms.TextBox()
        Me.txt_nombre_completo = New System.Windows.Forms.TextBox()
        Me.txt_importe_utilidades = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_barrido_datos = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_barrido_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_resultados
        '
        Me.btn_resultados.Location = New System.Drawing.Point(499, 405)
        Me.btn_resultados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_resultados.Name = "btn_resultados"
        Me.btn_resultados.Size = New System.Drawing.Size(184, 40)
        Me.btn_resultados.TabIndex = 17
        Me.btn_resultados.Text = "MOSTRAR RESULTADOS"
        Me.btn_resultados.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(514, 470)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(169, 34)
        Me.btn_salir.TabIndex = 16
        Me.btn_salir.Text = "S A L I R"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_registrar
        '
        Me.btn_registrar.Location = New System.Drawing.Point(23, 450)
        Me.btn_registrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(169, 34)
        Me.btn_registrar.TabIndex = 15
        Me.btn_registrar.Text = "R E G I S T R A R"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(23, 405)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(169, 34)
        Me.btn_limpiar.TabIndex = 14
        Me.btn_limpiar.Text = "L I M P I A R"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Controls.Add(Me.txt_cuenta_email)
        Me.GroupBox1.Controls.Add(Me.txt_cuenta_bancaria)
        Me.GroupBox1.Controls.Add(Me.txt_sueldo_diario)
        Me.GroupBox1.Controls.Add(Me.txt_dias_trabajados)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_completo)
        Me.GroupBox1.Controls.Add(Me.txt_importe_utilidades)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 22)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(660, 363)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS ENTRADA"
        '
        'txt_cuenta_email
        '
        Me.txt_cuenta_email.Location = New System.Drawing.Point(326, 299)
        Me.txt_cuenta_email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cuenta_email.Name = "txt_cuenta_email"
        Me.txt_cuenta_email.Size = New System.Drawing.Size(293, 31)
        Me.txt_cuenta_email.TabIndex = 11
        '
        'txt_cuenta_bancaria
        '
        Me.txt_cuenta_bancaria.Location = New System.Drawing.Point(326, 240)
        Me.txt_cuenta_bancaria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_cuenta_bancaria.Name = "txt_cuenta_bancaria"
        Me.txt_cuenta_bancaria.Size = New System.Drawing.Size(146, 31)
        Me.txt_cuenta_bancaria.TabIndex = 10
        '
        'txt_sueldo_diario
        '
        Me.txt_sueldo_diario.Location = New System.Drawing.Point(326, 186)
        Me.txt_sueldo_diario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_sueldo_diario.Name = "txt_sueldo_diario"
        Me.txt_sueldo_diario.Size = New System.Drawing.Size(125, 31)
        Me.txt_sueldo_diario.TabIndex = 9
        '
        'txt_dias_trabajados
        '
        Me.txt_dias_trabajados.Location = New System.Drawing.Point(326, 129)
        Me.txt_dias_trabajados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_dias_trabajados.Name = "txt_dias_trabajados"
        Me.txt_dias_trabajados.Size = New System.Drawing.Size(125, 31)
        Me.txt_dias_trabajados.TabIndex = 8
        '
        'txt_nombre_completo
        '
        Me.txt_nombre_completo.Location = New System.Drawing.Point(326, 79)
        Me.txt_nombre_completo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nombre_completo.Name = "txt_nombre_completo"
        Me.txt_nombre_completo.Size = New System.Drawing.Size(293, 31)
        Me.txt_nombre_completo.TabIndex = 7
        '
        'txt_importe_utilidades
        '
        Me.txt_importe_utilidades.Location = New System.Drawing.Point(326, 26)
        Me.txt_importe_utilidades.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_importe_utilidades.Name = "txt_importe_utilidades"
        Me.txt_importe_utilidades.Size = New System.Drawing.Size(140, 31)
        Me.txt_importe_utilidades.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "CUENTA DE EMAIL  :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(202, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CUENTA BANCARIA  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "SUELDO DIARIO  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DIAS TRABAJADOS  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IMPORTE TOTAL UTILIDADES  :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE COMPLETO  :"
        '
        'dgv_barrido_datos
        '
        Me.dgv_barrido_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_barrido_datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4})
        Me.dgv_barrido_datos.Location = New System.Drawing.Point(711, 22)
        Me.dgv_barrido_datos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_barrido_datos.Name = "dgv_barrido_datos"
        Me.dgv_barrido_datos.RowHeadersWidth = 51
        Me.dgv_barrido_datos.RowTemplate.Height = 29
        Me.dgv_barrido_datos.Size = New System.Drawing.Size(700, 278)
        Me.dgv_barrido_datos.TabIndex = 13
        '
        'Column2
        '
        Me.Column2.HeaderText = "CUENTA BANCARIA"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 145
        '
        'Column3
        '
        Me.Column3.HeaderText = "$ A PAGAR DE UTILIDADES"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 250
        '
        'Column4
        '
        Me.Column4.HeaderText = "EMAIL"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 250
        '
        'MENU_PTU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1731, 651)
        Me.Controls.Add(Me.btn_resultados)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.dgv_barrido_datos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MENU_PTU"
        Me.Text = "Programa PTU"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_barrido_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_resultados As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_registrar As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_cuenta_email As TextBox
    Friend WithEvents txt_cuenta_bancaria As TextBox
    Friend WithEvents txt_sueldo_diario As TextBox
    Friend WithEvents txt_dias_trabajados As TextBox
    Friend WithEvents txt_nombre_completo As TextBox
    Friend WithEvents txt_importe_utilidades As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_barrido_datos As DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
