<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_REGISTRO_SERVICIO
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
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.sad = New System.Windows.Forms.Label()
        Me.txt_matricula = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rb_otros3 = New System.Windows.Forms.RadioButton()
        Me.rb_otros2 = New System.Windows.Forms.RadioButton()
        Me.rb_otros1 = New System.Windows.Forms.RadioButton()
        Me.rb_compacto1 = New System.Windows.Forms.RadioButton()
        Me.rb_pickup3 = New System.Windows.Forms.RadioButton()
        Me.rb_suv3 = New System.Windows.Forms.RadioButton()
        Me.rb_compacto3 = New System.Windows.Forms.RadioButton()
        Me.rb_pickup1 = New System.Windows.Forms.RadioButton()
        Me.rb_pickup2 = New System.Windows.Forms.RadioButton()
        Me.rb_suv1 = New System.Windows.Forms.RadioButton()
        Me.rb_suv2 = New System.Windows.Forms.RadioButton()
        Me.rb_compacto2 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_tipopago = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_registrar
        '
        Me.btn_registrar.Location = New System.Drawing.Point(344, 592)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(168, 46)
        Me.btn_registrar.TabIndex = 15
        Me.btn_registrar.Text = "REGISTRAR"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(58, 592)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(168, 46)
        Me.btn_limpiar.TabIndex = 16
        Me.btn_limpiar.Text = "LIMPIAR"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(682, 592)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(168, 46)
        Me.btn_salir.TabIndex = 17
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'sad
        '
        Me.sad.AutoSize = True
        Me.sad.Location = New System.Drawing.Point(33, 36)
        Me.sad.Name = "sad"
        Me.sad.Size = New System.Drawing.Size(94, 17)
        Me.sad.TabIndex = 1
        Me.sad.Text = "MATRICULA :"
        '
        'txt_matricula
        '
        Me.txt_matricula.Location = New System.Drawing.Point(162, 30)
        Me.txt_matricula.Name = "txt_matricula"
        Me.txt_matricula.Size = New System.Drawing.Size(125, 22)
        Me.txt_matricula.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rb_otros3)
        Me.GroupBox1.Controls.Add(Me.rb_otros2)
        Me.GroupBox1.Controls.Add(Me.rb_otros1)
        Me.GroupBox1.Controls.Add(Me.rb_compacto1)
        Me.GroupBox1.Controls.Add(Me.rb_pickup3)
        Me.GroupBox1.Controls.Add(Me.rb_suv3)
        Me.GroupBox1.Controls.Add(Me.rb_compacto3)
        Me.GroupBox1.Controls.Add(Me.rb_pickup1)
        Me.GroupBox1.Controls.Add(Me.rb_pickup2)
        Me.GroupBox1.Controls.Add(Me.rb_suv1)
        Me.GroupBox1.Controls.Add(Me.rb_suv2)
        Me.GroupBox1.Controls.Add(Me.rb_compacto2)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(903, 460)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TIPO DE CARRO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(318, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "--------------------------------------------------------------"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(318, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "--------------------------------------------------------------"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(318, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "--------------------------------------------------------------"
        '
        'rb_otros3
        '
        Me.rb_otros3.AutoSize = True
        Me.rb_otros3.Location = New System.Drawing.Point(502, 130)
        Me.rb_otros3.Name = "rb_otros3"
        Me.rb_otros3.Size = New System.Drawing.Size(392, 21)
        Me.rb_otros3.TabIndex = 13
        Me.rb_otros3.TabStop = True
        Me.rb_otros3.Text = "OTROS LAVADO EXTERIOR + ASPIRADO + ENCERADO"
        Me.rb_otros3.UseVisualStyleBackColor = True
        '
        'rb_otros2
        '
        Me.rb_otros2.AutoSize = True
        Me.rb_otros2.Location = New System.Drawing.Point(502, 87)
        Me.rb_otros2.Name = "rb_otros2"
        Me.rb_otros2.Size = New System.Drawing.Size(299, 21)
        Me.rb_otros2.TabIndex = 12
        Me.rb_otros2.TabStop = True
        Me.rb_otros2.Text = "OTROS LAVADO EXTERIOR + ASPIRADO"
        Me.rb_otros2.UseVisualStyleBackColor = True
        '
        'rb_otros1
        '
        Me.rb_otros1.AutoSize = True
        Me.rb_otros1.Location = New System.Drawing.Point(502, 48)
        Me.rb_otros1.Name = "rb_otros1"
        Me.rb_otros1.Size = New System.Drawing.Size(256, 21)
        Me.rb_otros1.TabIndex = 11
        Me.rb_otros1.TabStop = True
        Me.rb_otros1.Text = "OTROS LAVADO SOLO EXTERIOR"
        Me.rb_otros1.UseVisualStyleBackColor = True
        '
        'rb_compacto1
        '
        Me.rb_compacto1.AutoSize = True
        Me.rb_compacto1.Checked = True
        Me.rb_compacto1.Location = New System.Drawing.Point(9, 48)
        Me.rb_compacto1.Name = "rb_compacto1"
        Me.rb_compacto1.Size = New System.Drawing.Size(284, 21)
        Me.rb_compacto1.TabIndex = 2
        Me.rb_compacto1.TabStop = True
        Me.rb_compacto1.Text = "COMPACTO LAVADO SOLO EXTERIOR"
        Me.rb_compacto1.UseVisualStyleBackColor = True
        '
        'rb_pickup3
        '
        Me.rb_pickup3.AutoSize = True
        Me.rb_pickup3.Location = New System.Drawing.Point(9, 404)
        Me.rb_pickup3.Name = "rb_pickup3"
        Me.rb_pickup3.Size = New System.Drawing.Size(396, 21)
        Me.rb_pickup3.TabIndex = 10
        Me.rb_pickup3.Text = "PICK-UP LAVADO EXTERIOR + ASPIRADO + ENCERADO"
        Me.rb_pickup3.UseVisualStyleBackColor = True
        '
        'rb_suv3
        '
        Me.rb_suv3.AutoSize = True
        Me.rb_suv3.Location = New System.Drawing.Point(9, 268)
        Me.rb_suv3.Name = "rb_suv3"
        Me.rb_suv3.Size = New System.Drawing.Size(370, 21)
        Me.rb_suv3.TabIndex = 7
        Me.rb_suv3.Text = "SUV LAVADO EXTERIOR + ASPIRADO + ENCERADO"
        Me.rb_suv3.UseVisualStyleBackColor = True
        '
        'rb_compacto3
        '
        Me.rb_compacto3.AutoSize = True
        Me.rb_compacto3.Location = New System.Drawing.Point(6, 130)
        Me.rb_compacto3.Name = "rb_compacto3"
        Me.rb_compacto3.Size = New System.Drawing.Size(420, 21)
        Me.rb_compacto3.TabIndex = 4
        Me.rb_compacto3.Text = "COMPACTO LAVADO EXTERIOR + ASPIRADO + ENCERADO"
        Me.rb_compacto3.UseVisualStyleBackColor = True
        '
        'rb_pickup1
        '
        Me.rb_pickup1.AutoSize = True
        Me.rb_pickup1.Location = New System.Drawing.Point(9, 324)
        Me.rb_pickup1.Name = "rb_pickup1"
        Me.rb_pickup1.Size = New System.Drawing.Size(260, 21)
        Me.rb_pickup1.TabIndex = 8
        Me.rb_pickup1.Text = "PICK-UP LAVADO SOLO EXTERIOR"
        Me.rb_pickup1.UseVisualStyleBackColor = True
        '
        'rb_pickup2
        '
        Me.rb_pickup2.AutoSize = True
        Me.rb_pickup2.Location = New System.Drawing.Point(9, 361)
        Me.rb_pickup2.Name = "rb_pickup2"
        Me.rb_pickup2.Size = New System.Drawing.Size(303, 21)
        Me.rb_pickup2.TabIndex = 9
        Me.rb_pickup2.Text = "PICK-UP LAVADO EXTERIOR + ASPIRADO"
        Me.rb_pickup2.UseVisualStyleBackColor = True
        '
        'rb_suv1
        '
        Me.rb_suv1.AutoSize = True
        Me.rb_suv1.Location = New System.Drawing.Point(9, 188)
        Me.rb_suv1.Name = "rb_suv1"
        Me.rb_suv1.Size = New System.Drawing.Size(234, 21)
        Me.rb_suv1.TabIndex = 5
        Me.rb_suv1.Text = "SUV LAVADO SOLO EXTERIOR"
        Me.rb_suv1.UseVisualStyleBackColor = True
        '
        'rb_suv2
        '
        Me.rb_suv2.AutoSize = True
        Me.rb_suv2.Location = New System.Drawing.Point(9, 225)
        Me.rb_suv2.Name = "rb_suv2"
        Me.rb_suv2.Size = New System.Drawing.Size(277, 21)
        Me.rb_suv2.TabIndex = 6
        Me.rb_suv2.Text = "SUV LAVADO EXTERIOR + ASPIRADO"
        Me.rb_suv2.UseVisualStyleBackColor = True
        '
        'rb_compacto2
        '
        Me.rb_compacto2.AutoSize = True
        Me.rb_compacto2.Location = New System.Drawing.Point(6, 87)
        Me.rb_compacto2.Name = "rb_compacto2"
        Me.rb_compacto2.Size = New System.Drawing.Size(327, 21)
        Me.rb_compacto2.TabIndex = 3
        Me.rb_compacto2.Text = "COMPACTO LAVADO EXTERIOR + ASPIRADO"
        Me.rb_compacto2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(380, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "TIPO DE PAGO :"
        '
        'cb_tipopago
        '
        Me.cb_tipopago.FormattingEnabled = True
        Me.cb_tipopago.Items.AddRange(New Object() {"EFECTIVO", "TARJETA DE CREDITO", "TARJETA DE DEBITO", "TRANSFERENCIA BANCARIA"})
        Me.cb_tipopago.Location = New System.Drawing.Point(529, 28)
        Me.cb_tipopago.Name = "cb_tipopago"
        Me.cb_tipopago.Size = New System.Drawing.Size(121, 24)
        Me.cb_tipopago.TabIndex = 14
        '
        'FORM_REGISTRO_SERVICIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1032, 739)
        Me.Controls.Add(Me.cb_tipopago)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_matricula)
        Me.Controls.Add(Me.sad)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FORM_REGISTRO_SERVICIO"
        Me.Text = "Registro de Servicio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_registrar As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents sad As Label
    Friend WithEvents txt_matricula As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rb_otros3 As RadioButton
    Friend WithEvents rb_otros2 As RadioButton
    Friend WithEvents rb_otros1 As RadioButton
    Friend WithEvents rb_compacto1 As RadioButton
    Friend WithEvents rb_pickup3 As RadioButton
    Friend WithEvents rb_suv3 As RadioButton
    Friend WithEvents rb_compacto3 As RadioButton
    Friend WithEvents rb_pickup1 As RadioButton
    Friend WithEvents rb_pickup2 As RadioButton
    Friend WithEvents rb_suv1 As RadioButton
    Friend WithEvents rb_suv2 As RadioButton
    Friend WithEvents rb_compacto2 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_tipopago As ComboBox
End Class
