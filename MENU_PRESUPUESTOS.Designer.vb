<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MENU_PRESUPUESTOS
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_municipio = New System.Windows.Forms.ComboBox()
        Me.cb_mes = New System.Windows.Forms.ComboBox()
        Me.cb_rubro = New System.Windows.Forms.ComboBox()
        Me.txt_importe = New System.Windows.Forms.TextBox()
        Me.lb_datos = New System.Windows.Forms.ListBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "# DE MUNICIPIO  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "# DE MES  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "# DE RUBRO  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "IMPORTE  :"
        '
        'cb_municipio
        '
        Me.cb_municipio.FormattingEnabled = True
        Me.cb_municipio.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.cb_municipio.Location = New System.Drawing.Point(198, 30)
        Me.cb_municipio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_municipio.Name = "cb_municipio"
        Me.cb_municipio.Size = New System.Drawing.Size(151, 24)
        Me.cb_municipio.TabIndex = 1
        '
        'cb_mes
        '
        Me.cb_mes.FormattingEnabled = True
        Me.cb_mes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cb_mes.Location = New System.Drawing.Point(198, 84)
        Me.cb_mes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_mes.Name = "cb_mes"
        Me.cb_mes.Size = New System.Drawing.Size(151, 24)
        Me.cb_mes.TabIndex = 2
        '
        'cb_rubro
        '
        Me.cb_rubro.FormattingEnabled = True
        Me.cb_rubro.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06"})
        Me.cb_rubro.Location = New System.Drawing.Point(198, 138)
        Me.cb_rubro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_rubro.Name = "cb_rubro"
        Me.cb_rubro.Size = New System.Drawing.Size(151, 24)
        Me.cb_rubro.TabIndex = 3
        '
        'txt_importe
        '
        Me.txt_importe.Location = New System.Drawing.Point(198, 194)
        Me.txt_importe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_importe.Name = "txt_importe"
        Me.txt_importe.Size = New System.Drawing.Size(151, 22)
        Me.txt_importe.TabIndex = 4
        '
        'lb_datos
        '
        Me.lb_datos.FormattingEnabled = True
        Me.lb_datos.ItemHeight = 16
        Me.lb_datos.Location = New System.Drawing.Point(563, 23)
        Me.lb_datos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lb_datos.Name = "lb_datos"
        Me.lb_datos.Size = New System.Drawing.Size(297, 196)
        Me.lb_datos.TabIndex = 8
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(461, 265)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(144, 30)
        Me.btn_limpiar.TabIndex = 6
        Me.btn_limpiar.Text = "LIMPIAR"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(256, 265)
        Me.btn_calcular.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(140, 30)
        Me.btn_calcular.TabIndex = 5
        Me.btn_calcular.Text = "AÑADIR A BDD"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(683, 260)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(151, 34)
        Me.btn_salir.TabIndex = 7
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'MENU_PRESUPUESTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 325)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.lb_datos)
        Me.Controls.Add(Me.txt_importe)
        Me.Controls.Add(Me.cb_rubro)
        Me.Controls.Add(Me.cb_mes)
        Me.Controls.Add(Me.cb_municipio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MENU_PRESUPUESTOS"
        Me.Text = "Programa Presupuestos Sinaloa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_municipio As ComboBox
    Friend WithEvents cb_mes As ComboBox
    Friend WithEvents cb_rubro As ComboBox
    Friend WithEvents txt_importe As TextBox
    Friend WithEvents lb_datos As ListBox
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_calcular As Button
    Friend WithEvents btn_salir As Button
End Class