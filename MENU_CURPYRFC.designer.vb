<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MENU_CURPYRFC
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GB = New System.Windows.Forms.GroupBox()
        Me.rb_mujer = New System.Windows.Forms.RadioButton()
        Me.rb_hombre = New System.Windows.Forms.RadioButton()
        Me.lbl_curp = New System.Windows.Forms.Label()
        Me.lbl_rfc = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.txt_apellido1 = New System.Windows.Forms.TextBox()
        Me.txt_apellido2 = New System.Windows.Forms.TextBox()
        Me.txt_nombres = New System.Windows.Forms.TextBox()
        Me.txt_año = New System.Windows.Forms.TextBox()
        Me.cb_dia = New System.Windows.Forms.ComboBox()
        Me.cb_mes = New System.Windows.Forms.ComboBox()
        Me.btn_curp = New System.Windows.Forms.Button()
        Me.cb_entidad_federativa = New System.Windows.Forms.ComboBox()
        Me.GB.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "APELLIDO 1  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "APELLIDO 2  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NOMBRE(S)  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "FECHA NACIMIENTO  :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(183, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(255, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "MM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(334, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "AAAA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(67, 394)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ENTIDAD FEDERATIVA  :"
        '
        'GB
        '
        Me.GB.Controls.Add(Me.rb_mujer)
        Me.GB.Controls.Add(Me.rb_hombre)
        Me.GB.Location = New System.Drawing.Point(95, 286)
        Me.GB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GB.Name = "GB"
        Me.GB.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GB.Size = New System.Drawing.Size(314, 73)
        Me.GB.TabIndex = 8
        Me.GB.TabStop = False
        Me.GB.Text = "GENERO"
        '
        'rb_mujer
        '
        Me.rb_mujer.AutoSize = True
        Me.rb_mujer.Location = New System.Drawing.Point(160, 34)
        Me.rb_mujer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rb_mujer.Name = "rb_mujer"
        Me.rb_mujer.Size = New System.Drawing.Size(76, 21)
        Me.rb_mujer.TabIndex = 22
        Me.rb_mujer.Text = "MUJER"
        Me.rb_mujer.UseVisualStyleBackColor = True
        '
        'rb_hombre
        '
        Me.rb_hombre.AutoSize = True
        Me.rb_hombre.Checked = True
        Me.rb_hombre.Location = New System.Drawing.Point(9, 34)
        Me.rb_hombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rb_hombre.Name = "rb_hombre"
        Me.rb_hombre.Size = New System.Drawing.Size(89, 21)
        Me.rb_hombre.TabIndex = 21
        Me.rb_hombre.TabStop = True
        Me.rb_hombre.Text = "HOMBRE"
        Me.rb_hombre.UseVisualStyleBackColor = True
        '
        'lbl_curp
        '
        Me.lbl_curp.AutoSize = True
        Me.lbl_curp.Location = New System.Drawing.Point(462, 272)
        Me.lbl_curp.Name = "lbl_curp"
        Me.lbl_curp.Size = New System.Drawing.Size(232, 17)
        Me.lbl_curp.TabIndex = 9
        Me.lbl_curp.Text = "____________________________"
        '
        'lbl_rfc
        '
        Me.lbl_rfc.AutoSize = True
        Me.lbl_rfc.Location = New System.Drawing.Point(797, 272)
        Me.lbl_rfc.Name = "lbl_rfc"
        Me.lbl_rfc.Size = New System.Drawing.Size(232, 17)
        Me.lbl_rfc.TabIndex = 10
        Me.lbl_rfc.Text = "____________________________"
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(611, 394)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(221, 38)
        Me.btn_salir.TabIndex = 11
        Me.btn_salir.Text = "S A L I R"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(611, 321)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(221, 38)
        Me.btn_limpiar.TabIndex = 12
        Me.btn_limpiar.Text = "L I M P I A R"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'txt_apellido1
        '
        Me.txt_apellido1.Location = New System.Drawing.Point(242, 39)
        Me.txt_apellido1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_apellido1.Name = "txt_apellido1"
        Me.txt_apellido1.Size = New System.Drawing.Size(134, 22)
        Me.txt_apellido1.TabIndex = 13
        '
        'txt_apellido2
        '
        Me.txt_apellido2.Location = New System.Drawing.Point(242, 89)
        Me.txt_apellido2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_apellido2.Name = "txt_apellido2"
        Me.txt_apellido2.Size = New System.Drawing.Size(134, 22)
        Me.txt_apellido2.TabIndex = 14
        '
        'txt_nombres
        '
        Me.txt_nombres.Location = New System.Drawing.Point(242, 136)
        Me.txt_nombres.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(134, 22)
        Me.txt_nombres.TabIndex = 15
        '
        'txt_año
        '
        Me.txt_año.Location = New System.Drawing.Point(334, 238)
        Me.txt_año.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_año.Name = "txt_año"
        Me.txt_año.Size = New System.Drawing.Size(75, 22)
        Me.txt_año.TabIndex = 16
        '
        'cb_dia
        '
        Me.cb_dia.FormattingEnabled = True
        Me.cb_dia.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cb_dia.Location = New System.Drawing.Point(177, 238)
        Me.cb_dia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_dia.Name = "cb_dia"
        Me.cb_dia.Size = New System.Drawing.Size(72, 24)
        Me.cb_dia.TabIndex = 17
        '
        'cb_mes
        '
        Me.cb_mes.FormattingEnabled = True
        Me.cb_mes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cb_mes.Location = New System.Drawing.Point(255, 238)
        Me.cb_mes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_mes.Name = "cb_mes"
        Me.cb_mes.Size = New System.Drawing.Size(70, 24)
        Me.cb_mes.TabIndex = 18
        '
        'btn_curp
        '
        Me.btn_curp.Location = New System.Drawing.Point(624, 211)
        Me.btn_curp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_curp.Name = "btn_curp"
        Me.btn_curp.Size = New System.Drawing.Size(181, 36)
        Me.btn_curp.TabIndex = 19
        Me.btn_curp.Text = "C A L C U L A R"
        Me.btn_curp.UseVisualStyleBackColor = True
        '
        'cb_entidad_federativa
        '
        Me.cb_entidad_federativa.FormattingEnabled = True
        Me.cb_entidad_federativa.Items.AddRange(New Object() {"AGUASCALIENTES", "BAJA CALIFORNIA", "BAJA CALIF. SUR", "CAMPECHE", "CHIAPAS", "CHIHUAHUA", "COAHUILA", "COLIMA", "DISTRITO FEDERAL", "DURANGO", "GUANAJUATO", "GUERRERO", "HILDALGO", "JALISCO", "MEXICO", "MICHOACAN", "MORELOS", "NAYARIT", "NUEVO LEON", "OAXACA", "PUEBLA", "QUERETARO", "QUINTANA ROO", "SAN LUIS POTOSI", "SINALOA", "SONORA", "TABASCO", "TAMAULIPAS", "TLAXCALA", "VERACRUZ", "YUCATAN", "ZACATECAS"})
        Me.cb_entidad_federativa.Location = New System.Drawing.Point(265, 391)
        Me.cb_entidad_federativa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_entidad_federativa.Name = "cb_entidad_federativa"
        Me.cb_entidad_federativa.Size = New System.Drawing.Size(144, 24)
        Me.cb_entidad_federativa.TabIndex = 21
        '
        'MENU_CURPYRFC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(1136, 497)
        Me.Controls.Add(Me.cb_entidad_federativa)
        Me.Controls.Add(Me.btn_curp)
        Me.Controls.Add(Me.cb_mes)
        Me.Controls.Add(Me.cb_dia)
        Me.Controls.Add(Me.txt_año)
        Me.Controls.Add(Me.txt_nombres)
        Me.Controls.Add(Me.txt_apellido2)
        Me.Controls.Add(Me.txt_apellido1)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.lbl_rfc)
        Me.Controls.Add(Me.lbl_curp)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MENU_CURPYRFC"
        Me.Text = "Curp y RFC de un Mexicano"
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GB As GroupBox
    Friend WithEvents rb_mujer As RadioButton
    Friend WithEvents rb_hombre As RadioButton
    Friend WithEvents lbl_curp As Label
    Friend WithEvents lbl_rfc As Label
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents txt_apellido1 As TextBox
    Friend WithEvents txt_apellido2 As TextBox
    Friend WithEvents txt_nombres As TextBox
    Friend WithEvents txt_año As TextBox
    Friend WithEvents cb_dia As ComboBox
    Friend WithEvents cb_mes As ComboBox
    Friend WithEvents btn_curp As Button
    Friend WithEvents cb_entidad_federativa As ComboBox
End Class
