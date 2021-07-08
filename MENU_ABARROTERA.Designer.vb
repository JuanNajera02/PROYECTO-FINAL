<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_ABARROTERA
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
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.lbl_ventas_credito = New System.Windows.Forms.Label()
        Me.lbl_ventas_contado = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_total_comision = New System.Windows.Forms.Label()
        Me.lbl_total_credito = New System.Windows.Forms.Label()
        Me.lbl_totral_contado = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgv_abarrotera_trabajadores = New System.Windows.Forms.DataGridView()
        Me.A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_importe_venta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_tipo_de_pago = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_clave_vendedor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nota_de_venta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        CType(Me.dgv_abarrotera_trabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(1341, 527)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(124, 31)
        Me.btn_salir.TabIndex = 47
        Me.btn_salir.Text = "S A L I R"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(634, 524)
        Me.btn_calcular.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(142, 31)
        Me.btn_calcular.TabIndex = 46
        Me.btn_calcular.Text = "C A L C U L A R"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(348, 524)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(124, 31)
        Me.btn_limpiar.TabIndex = 45
        Me.btn_limpiar.Text = "L I M P I A R"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'lbl_ventas_credito
        '
        Me.lbl_ventas_credito.AutoSize = True
        Me.lbl_ventas_credito.Location = New System.Drawing.Point(219, 476)
        Me.lbl_ventas_credito.Name = "lbl_ventas_credito"
        Me.lbl_ventas_credito.Size = New System.Drawing.Size(88, 17)
        Me.lbl_ventas_credito.TabIndex = 44
        Me.lbl_ventas_credito.Text = "__________"
        '
        'lbl_ventas_contado
        '
        Me.lbl_ventas_contado.AutoSize = True
        Me.lbl_ventas_contado.Location = New System.Drawing.Point(219, 420)
        Me.lbl_ventas_contado.Name = "lbl_ventas_contado"
        Me.lbl_ventas_contado.Size = New System.Drawing.Size(88, 17)
        Me.lbl_ventas_contado.TabIndex = 43
        Me.lbl_ventas_contado.Text = "__________"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(-5, 414)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(203, 28)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "VENTAS CONTADO :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(10, 470)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 28)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "VENTAS CREDITO :"
        '
        'lbl_total_comision
        '
        Me.lbl_total_comision.AutoSize = True
        Me.lbl_total_comision.Location = New System.Drawing.Point(1380, 486)
        Me.lbl_total_comision.Name = "lbl_total_comision"
        Me.lbl_total_comision.Size = New System.Drawing.Size(88, 17)
        Me.lbl_total_comision.TabIndex = 40
        Me.lbl_total_comision.Text = "__________"
        '
        'lbl_total_credito
        '
        Me.lbl_total_credito.AutoSize = True
        Me.lbl_total_credito.Location = New System.Drawing.Point(1238, 486)
        Me.lbl_total_credito.Name = "lbl_total_credito"
        Me.lbl_total_credito.Size = New System.Drawing.Size(88, 17)
        Me.lbl_total_credito.TabIndex = 39
        Me.lbl_total_credito.Text = "__________"
        '
        'lbl_totral_contado
        '
        Me.lbl_totral_contado.AutoSize = True
        Me.lbl_totral_contado.Location = New System.Drawing.Point(1087, 486)
        Me.lbl_totral_contado.Name = "lbl_totral_contado"
        Me.lbl_totral_contado.Size = New System.Drawing.Size(88, 17)
        Me.lbl_totral_contado.TabIndex = 38
        Me.lbl_totral_contado.Text = "__________"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(899, 476)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 28)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "SUMAS :"
        '
        'dgv_abarrotera_trabajadores
        '
        Me.dgv_abarrotera_trabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_abarrotera_trabajadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.A, Me.Column1, Me.Column2, Me.Column3})
        Me.dgv_abarrotera_trabajadores.Location = New System.Drawing.Point(820, 196)
        Me.dgv_abarrotera_trabajadores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_abarrotera_trabajadores.Name = "dgv_abarrotera_trabajadores"
        Me.dgv_abarrotera_trabajadores.RowHeadersWidth = 51
        Me.dgv_abarrotera_trabajadores.RowTemplate.Height = 29
        Me.dgv_abarrotera_trabajadores.Size = New System.Drawing.Size(645, 264)
        Me.dgv_abarrotera_trabajadores.TabIndex = 36
        '
        'A
        '
        Me.A.HeaderText = "CLAVE VENDEDOR"
        Me.A.MinimumWidth = 6
        Me.A.Name = "A"
        Me.A.Width = 150
        '
        'Column1
        '
        Me.Column1.HeaderText = "$ VENTAS DE CONTADO"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "$ VENTAS DE CREDITO"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "COMISION A PAGAR $"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gray
        Me.GroupBox1.Controls.Add(Me.txt_importe_venta)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cb_tipo_de_pago)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cb_clave_vendedor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_nota_de_venta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 45)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(778, 322)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS"
        '
        'txt_importe_venta
        '
        Me.txt_importe_venta.Location = New System.Drawing.Point(598, 253)
        Me.txt_importe_venta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_importe_venta.Name = "txt_importe_venta"
        Me.txt_importe_venta.Size = New System.Drawing.Size(131, 34)
        Me.txt_importe_venta.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(558, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 28)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "IMPORTE DE VENTA :"
        '
        'cb_tipo_de_pago
        '
        Me.cb_tipo_de_pago.FormattingEnabled = True
        Me.cb_tipo_de_pago.Items.AddRange(New Object() {"CONTADO", "CREDITO"})
        Me.cb_tipo_de_pago.Location = New System.Drawing.Point(383, 253)
        Me.cb_tipo_de_pago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_tipo_de_pago.Name = "cb_tipo_de_pago"
        Me.cb_tipo_de_pago.Size = New System.Drawing.Size(140, 36)
        Me.cb_tipo_de_pago.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(372, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 28)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "TIPO DE PAGO :"
        '
        'cb_clave_vendedor
        '
        Me.cb_clave_vendedor.FormattingEnabled = True
        Me.cb_clave_vendedor.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.cb_clave_vendedor.Location = New System.Drawing.Point(456, 168)
        Me.cb_clave_vendedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_clave_vendedor.Name = "cb_clave_vendedor"
        Me.cb_clave_vendedor.Size = New System.Drawing.Size(151, 36)
        Me.cb_clave_vendedor.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(418, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 28)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CLAVE DE VENDEDOR :"
        '
        'txt_nota_de_venta
        '
        Me.txt_nota_de_venta.Location = New System.Drawing.Point(465, 75)
        Me.txt_nota_de_venta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nota_de_venta.Name = "txt_nota_de_venta"
        Me.txt_nota_de_venta.Size = New System.Drawing.Size(125, 34)
        Me.txt_nota_de_venta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(442, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NOTA DE VENTA :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INSERTE FECHA :"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(12, 63)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'MENU_ABARROTERA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1497, 603)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.lbl_ventas_credito)
        Me.Controls.Add(Me.lbl_ventas_contado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_total_comision)
        Me.Controls.Add(Me.lbl_total_credito)
        Me.Controls.Add(Me.lbl_totral_contado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgv_abarrotera_trabajadores)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MENU_ABARROTERA"
        Me.Text = "Registro Datos Abarrotera"
        CType(Me.dgv_abarrotera_trabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_calcular As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents lbl_ventas_credito As Label
    Friend WithEvents lbl_ventas_contado As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_total_comision As Label
    Friend WithEvents lbl_total_credito As Label
    Friend WithEvents lbl_totral_contado As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgv_abarrotera_trabajadores As DataGridView
    Friend WithEvents A As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_importe_venta As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_tipo_de_pago As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_clave_vendedor As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nota_de_venta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
