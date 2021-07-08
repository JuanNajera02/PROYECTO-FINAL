<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_COSECHAS
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_total_general_neto = New System.Windows.Forms.Label()
        Me.lbl_total_impuestos = New System.Windows.Forms.Label()
        Me.lbl_total_subtotal = New System.Windows.Forms.Label()
        Me.lbl_total_kilos_pagados = New System.Windows.Forms.Label()
        Me.lbl_total_kilos_descontados = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_total_neto = New System.Windows.Forms.Label()
        Me.lbl_importe_impuestos = New System.Windows.Forms.Label()
        Me.lbl_sub_total = New System.Windows.Forms.Label()
        Me.lbl_kilos_pagados = New System.Windows.Forms.Label()
        Me.lbl_kilos_descontados = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.txt_precio_tonelada = New System.Windows.Forms.TextBox()
        Me.txt_porcentaje_humedad = New System.Windows.Forms.TextBox()
        Me.txt_maiz_recibido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_clave_productor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_datos = New System.Windows.Forms.ListBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(1150, 389)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(206, 34)
        Me.btn_salir.TabIndex = 51
        Me.btn_salir.Text = "S A L I R"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Controls.Add(Me.lbl_total_general_neto)
        Me.GroupBox1.Controls.Add(Me.lbl_total_impuestos)
        Me.GroupBox1.Controls.Add(Me.lbl_total_subtotal)
        Me.GroupBox1.Controls.Add(Me.lbl_total_kilos_pagados)
        Me.GroupBox1.Controls.Add(Me.lbl_total_kilos_descontados)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 428)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1328, 141)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ACUMULADOS"
        '
        'lbl_total_general_neto
        '
        Me.lbl_total_general_neto.AutoSize = True
        Me.lbl_total_general_neto.Location = New System.Drawing.Point(1105, 94)
        Me.lbl_total_general_neto.Name = "lbl_total_general_neto"
        Me.lbl_total_general_neto.Size = New System.Drawing.Size(108, 28)
        Me.lbl_total_general_neto.TabIndex = 9
        Me.lbl_total_general_neto.Text = "____________"
        '
        'lbl_total_impuestos
        '
        Me.lbl_total_impuestos.AutoSize = True
        Me.lbl_total_impuestos.Location = New System.Drawing.Point(847, 94)
        Me.lbl_total_impuestos.Name = "lbl_total_impuestos"
        Me.lbl_total_impuestos.Size = New System.Drawing.Size(108, 28)
        Me.lbl_total_impuestos.TabIndex = 8
        Me.lbl_total_impuestos.Text = "____________"
        '
        'lbl_total_subtotal
        '
        Me.lbl_total_subtotal.AutoSize = True
        Me.lbl_total_subtotal.Location = New System.Drawing.Point(644, 94)
        Me.lbl_total_subtotal.Name = "lbl_total_subtotal"
        Me.lbl_total_subtotal.Size = New System.Drawing.Size(108, 28)
        Me.lbl_total_subtotal.TabIndex = 7
        Me.lbl_total_subtotal.Text = "____________"
        '
        'lbl_total_kilos_pagados
        '
        Me.lbl_total_kilos_pagados.AutoSize = True
        Me.lbl_total_kilos_pagados.Location = New System.Drawing.Point(401, 94)
        Me.lbl_total_kilos_pagados.Name = "lbl_total_kilos_pagados"
        Me.lbl_total_kilos_pagados.Size = New System.Drawing.Size(108, 28)
        Me.lbl_total_kilos_pagados.TabIndex = 6
        Me.lbl_total_kilos_pagados.Text = "____________"
        '
        'lbl_total_kilos_descontados
        '
        Me.lbl_total_kilos_descontados.AutoSize = True
        Me.lbl_total_kilos_descontados.Location = New System.Drawing.Point(127, 94)
        Me.lbl_total_kilos_descontados.Name = "lbl_total_kilos_descontados"
        Me.lbl_total_kilos_descontados.Size = New System.Drawing.Size(108, 28)
        Me.lbl_total_kilos_descontados.TabIndex = 5
        Me.lbl_total_kilos_descontados.Text = "____________"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(1035, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(276, 28)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "TOTAL IMPORTE CAMIONES"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(813, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(188, 28)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "TOTAL IMPUESTOS"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(610, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(184, 28)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "TOTAL SUB-TOTAL"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(343, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(233, 28)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "TOTAL KILOS PAGADOS"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(39, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(285, 28)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "TOTAL KILOS DESCONTADOS"
        '
        'lbl_total_neto
        '
        Me.lbl_total_neto.AutoSize = True
        Me.lbl_total_neto.Location = New System.Drawing.Point(979, 376)
        Me.lbl_total_neto.Name = "lbl_total_neto"
        Me.lbl_total_neto.Size = New System.Drawing.Size(104, 17)
        Me.lbl_total_neto.TabIndex = 49
        Me.lbl_total_neto.Text = "____________"
        '
        'lbl_importe_impuestos
        '
        Me.lbl_importe_impuestos.AutoSize = True
        Me.lbl_importe_impuestos.Location = New System.Drawing.Point(979, 314)
        Me.lbl_importe_impuestos.Name = "lbl_importe_impuestos"
        Me.lbl_importe_impuestos.Size = New System.Drawing.Size(104, 17)
        Me.lbl_importe_impuestos.TabIndex = 48
        Me.lbl_importe_impuestos.Text = "____________"
        '
        'lbl_sub_total
        '
        Me.lbl_sub_total.AutoSize = True
        Me.lbl_sub_total.Location = New System.Drawing.Point(979, 248)
        Me.lbl_sub_total.Name = "lbl_sub_total"
        Me.lbl_sub_total.Size = New System.Drawing.Size(104, 17)
        Me.lbl_sub_total.TabIndex = 47
        Me.lbl_sub_total.Text = "____________"
        '
        'lbl_kilos_pagados
        '
        Me.lbl_kilos_pagados.AutoSize = True
        Me.lbl_kilos_pagados.Location = New System.Drawing.Point(979, 188)
        Me.lbl_kilos_pagados.Name = "lbl_kilos_pagados"
        Me.lbl_kilos_pagados.Size = New System.Drawing.Size(104, 17)
        Me.lbl_kilos_pagados.TabIndex = 46
        Me.lbl_kilos_pagados.Text = "____________"
        '
        'lbl_kilos_descontados
        '
        Me.lbl_kilos_descontados.AutoSize = True
        Me.lbl_kilos_descontados.Location = New System.Drawing.Point(979, 128)
        Me.lbl_kilos_descontados.Name = "lbl_kilos_descontados"
        Me.lbl_kilos_descontados.Size = New System.Drawing.Size(104, 17)
        Me.lbl_kilos_descontados.TabIndex = 45
        Me.lbl_kilos_descontados.Text = "____________"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(655, 376)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 17)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "TOTAL NETO  :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(655, 314)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 17)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "IMPORTE IMPUESTOS  :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(655, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 17)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "SUB-TOTAL A PAGAR  :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(655, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(249, 17)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "KILOS EFECTIVAMENTE PAGADOS  :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(655, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 17)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "KILOS DESCONTADOS  :"
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(127, 314)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(165, 41)
        Me.btn_limpiar.TabIndex = 39
        Me.btn_limpiar.Text = "L I M P I A R"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(375, 314)
        Me.btn_calcular.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(155, 41)
        Me.btn_calcular.TabIndex = 38
        Me.btn_calcular.Text = "C A L C U L A R"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'txt_precio_tonelada
        '
        Me.txt_precio_tonelada.Location = New System.Drawing.Point(1015, 55)
        Me.txt_precio_tonelada.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_precio_tonelada.Name = "txt_precio_tonelada"
        Me.txt_precio_tonelada.Size = New System.Drawing.Size(133, 22)
        Me.txt_precio_tonelada.TabIndex = 37
        '
        'txt_porcentaje_humedad
        '
        Me.txt_porcentaje_humedad.Location = New System.Drawing.Point(388, 243)
        Me.txt_porcentaje_humedad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_porcentaje_humedad.Name = "txt_porcentaje_humedad"
        Me.txt_porcentaje_humedad.Size = New System.Drawing.Size(127, 22)
        Me.txt_porcentaje_humedad.TabIndex = 5
        '
        'txt_maiz_recibido
        '
        Me.txt_maiz_recibido.Location = New System.Drawing.Point(388, 188)
        Me.txt_maiz_recibido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_maiz_recibido.Name = "txt_maiz_recibido"
        Me.txt_maiz_recibido.Size = New System.Drawing.Size(127, 22)
        Me.txt_maiz_recibido.TabIndex = 4
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(388, 128)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(127, 22)
        Me.txt_nombre.TabIndex = 3
        '
        'txt_clave_productor
        '
        Me.txt_clave_productor.Location = New System.Drawing.Point(388, 73)
        Me.txt_clave_productor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_clave_productor.Name = "txt_clave_productor"
        Me.txt_clave_productor.Size = New System.Drawing.Size(127, 22)
        Me.txt_clave_productor.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(946, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(263, 28)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "PRECIO $ POR TONELADA "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(84, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 17)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "PORCENTAJE DE HUMEDAD  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 17)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "KILOS DE MAIZ RECIBIDOS  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(285, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "NOMBRE COMPLETO DEL PRODUCTOR  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "RFC DEL PRODUCTOR"
        '
        'lb_datos
        '
        Me.lb_datos.Font = New System.Drawing.Font("Segoe UI", 6.0!)
        Me.lb_datos.FormattingEnabled = True
        Me.lb_datos.ItemHeight = 12
        Me.lb_datos.Location = New System.Drawing.Point(1215, 12)
        Me.lb_datos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lb_datos.Name = "lb_datos"
        Me.lb_datos.Size = New System.Drawing.Size(412, 340)
        Me.lb_datos.TabIndex = 52
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(655, 79)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 17)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "FECHA  :"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(837, 79)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(104, 17)
        Me.lbl_fecha.TabIndex = 54
        Me.lbl_fecha.Text = "____________"
        '
        'MENU_COSECHAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1629, 589)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lb_datos)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_total_neto)
        Me.Controls.Add(Me.lbl_importe_impuestos)
        Me.Controls.Add(Me.lbl_sub_total)
        Me.Controls.Add(Me.lbl_kilos_pagados)
        Me.Controls.Add(Me.lbl_kilos_descontados)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.txt_precio_tonelada)
        Me.Controls.Add(Me.txt_porcentaje_humedad)
        Me.Controls.Add(Me.txt_maiz_recibido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_clave_productor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MENU_COSECHAS"
        Me.Text = "Registro de Cosechas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_salir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_total_general_neto As Label
    Friend WithEvents lbl_total_impuestos As Label
    Friend WithEvents lbl_total_subtotal As Label
    Friend WithEvents lbl_total_kilos_pagados As Label
    Friend WithEvents lbl_total_kilos_descontados As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_total_neto As Label
    Friend WithEvents lbl_importe_impuestos As Label
    Friend WithEvents lbl_sub_total As Label
    Friend WithEvents lbl_kilos_pagados As Label
    Friend WithEvents lbl_kilos_descontados As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_calcular As Button
    Friend WithEvents txt_precio_tonelada As TextBox
    Friend WithEvents txt_porcentaje_humedad As TextBox
    Friend WithEvents txt_maiz_recibido As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_clave_productor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lb_datos As ListBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lbl_fecha As Label
End Class
