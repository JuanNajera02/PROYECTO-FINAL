<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_ALUMNOS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_apellido2 = New System.Windows.Forms.TextBox()
        Me.txt_apellido1 = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_procesos = New System.Windows.Forms.RadioButton()
        Me.rb_software = New System.Windows.Forms.RadioButton()
        Me.rb_geodesia = New System.Windows.Forms.RadioButton()
        Me.rb_civil = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cb_grado = New System.Windows.Forms.ComboBox()
        Me.txt_grupo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb_mes = New System.Windows.Forms.ComboBox()
        Me.cb_dia = New System.Windows.Forms.ComboBox()
        Me.txt_año = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chb_voleibol = New System.Windows.Forms.CheckBox()
        Me.chb_tenis = New System.Windows.Forms.CheckBox()
        Me.chb_ciclismo = New System.Windows.Forms.CheckBox()
        Me.chb_beis = New System.Windows.Forms.CheckBox()
        Me.chb_basket = New System.Windows.Forms.CheckBox()
        Me.chb_box = New System.Windows.Forms.CheckBox()
        Me.chb_otros = New System.Windows.Forms.CheckBox()
        Me.chb_natacion = New System.Windows.Forms.CheckBox()
        Me.chb_soccer = New System.Windows.Forms.CheckBox()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lb_alumnos = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRE  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "APELLIDO 1  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "APELLIDO 2  :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_apellido2)
        Me.GroupBox1.Controls.Add(Me.txt_apellido1)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(492, 184)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS"
        '
        'txt_apellido2
        '
        Me.txt_apellido2.Location = New System.Drawing.Point(210, 149)
        Me.txt_apellido2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_apellido2.Name = "txt_apellido2"
        Me.txt_apellido2.Size = New System.Drawing.Size(168, 22)
        Me.txt_apellido2.TabIndex = 3
        '
        'txt_apellido1
        '
        Me.txt_apellido1.Location = New System.Drawing.Point(210, 91)
        Me.txt_apellido1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_apellido1.Name = "txt_apellido1"
        Me.txt_apellido1.Size = New System.Drawing.Size(168, 22)
        Me.txt_apellido1.TabIndex = 2
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(210, 34)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(168, 22)
        Me.txt_nombre.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_procesos)
        Me.GroupBox2.Controls.Add(Me.rb_software)
        Me.GroupBox2.Controls.Add(Me.rb_geodesia)
        Me.GroupBox2.Controls.Add(Me.rb_civil)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 214)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(503, 122)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CARRERA CURSADA"
        '
        'rb_procesos
        '
        Me.rb_procesos.AutoSize = True
        Me.rb_procesos.Location = New System.Drawing.Point(109, 86)
        Me.rb_procesos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rb_procesos.Name = "rb_procesos"
        Me.rb_procesos.Size = New System.Drawing.Size(106, 21)
        Me.rb_procesos.TabIndex = 1
        Me.rb_procesos.Text = "PROCESOS"
        Me.rb_procesos.UseVisualStyleBackColor = True
        '
        'rb_software
        '
        Me.rb_software.AutoSize = True
        Me.rb_software.Checked = True
        Me.rb_software.Location = New System.Drawing.Point(244, 46)
        Me.rb_software.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rb_software.Name = "rb_software"
        Me.rb_software.Size = New System.Drawing.Size(260, 21)
        Me.rb_software.TabIndex = 0
        Me.rb_software.TabStop = True
        Me.rb_software.Text = "SOFTWARE (LA MEJOR CARRERA)"
        Me.rb_software.UseVisualStyleBackColor = True
        '
        'rb_geodesia
        '
        Me.rb_geodesia.AutoSize = True
        Me.rb_geodesia.Location = New System.Drawing.Point(109, 46)
        Me.rb_geodesia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rb_geodesia.Name = "rb_geodesia"
        Me.rb_geodesia.Size = New System.Drawing.Size(100, 21)
        Me.rb_geodesia.TabIndex = 0
        Me.rb_geodesia.Text = "GEODESIA"
        Me.rb_geodesia.UseVisualStyleBackColor = True
        '
        'rb_civil
        '
        Me.rb_civil.AutoSize = True
        Me.rb_civil.Location = New System.Drawing.Point(26, 46)
        Me.rb_civil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rb_civil.Name = "rb_civil"
        Me.rb_civil.Size = New System.Drawing.Size(61, 21)
        Me.rb_civil.TabIndex = 0
        Me.rb_civil.Text = "CIVIL"
        Me.rb_civil.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "GRADO  :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cb_grado)
        Me.GroupBox3.Controls.Add(Me.txt_grupo)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(530, 11)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(401, 120)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GRADO Y GRUPO"
        '
        'cb_grado
        '
        Me.cb_grado.FormattingEnabled = True
        Me.cb_grado.Items.AddRange(New Object() {"1ERO", "2DO", "3ERO", "4TO", "5TO"})
        Me.cb_grado.Location = New System.Drawing.Point(123, 30)
        Me.cb_grado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_grado.Name = "cb_grado"
        Me.cb_grado.Size = New System.Drawing.Size(151, 24)
        Me.cb_grado.TabIndex = 4
        '
        'txt_grupo
        '
        Me.txt_grupo.Location = New System.Drawing.Point(123, 89)
        Me.txt_grupo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_grupo.Name = "txt_grupo"
        Me.txt_grupo.Size = New System.Drawing.Size(144, 22)
        Me.txt_grupo.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "GRUPO  :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.cb_mes)
        Me.GroupBox4.Controls.Add(Me.cb_dia)
        Me.GroupBox4.Controls.Add(Me.txt_año)
        Me.GroupBox4.Location = New System.Drawing.Point(530, 150)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(401, 127)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "FECHA DE NACIMIENTO  :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(239, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "AÑO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(123, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "MES"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "DIA"
        '
        'cb_mes
        '
        Me.cb_mes.FormattingEnabled = True
        Me.cb_mes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cb_mes.Location = New System.Drawing.Point(123, 64)
        Me.cb_mes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_mes.Name = "cb_mes"
        Me.cb_mes.Size = New System.Drawing.Size(86, 24)
        Me.cb_mes.TabIndex = 7
        '
        'cb_dia
        '
        Me.cb_dia.FormattingEnabled = True
        Me.cb_dia.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cb_dia.Location = New System.Drawing.Point(23, 64)
        Me.cb_dia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_dia.Name = "cb_dia"
        Me.cb_dia.Size = New System.Drawing.Size(86, 24)
        Me.cb_dia.TabIndex = 6
        '
        'txt_año
        '
        Me.txt_año.Location = New System.Drawing.Point(239, 64)
        Me.txt_año.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_año.Name = "txt_año"
        Me.txt_año.Size = New System.Drawing.Size(140, 22)
        Me.txt_año.TabIndex = 8
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chb_voleibol)
        Me.GroupBox5.Controls.Add(Me.chb_tenis)
        Me.GroupBox5.Controls.Add(Me.chb_ciclismo)
        Me.GroupBox5.Controls.Add(Me.chb_beis)
        Me.GroupBox5.Controls.Add(Me.chb_basket)
        Me.GroupBox5.Controls.Add(Me.chb_box)
        Me.GroupBox5.Controls.Add(Me.chb_otros)
        Me.GroupBox5.Controls.Add(Me.chb_natacion)
        Me.GroupBox5.Controls.Add(Me.chb_soccer)
        Me.GroupBox5.Location = New System.Drawing.Point(11, 350)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(565, 148)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "DEPORTES PRACTICADOS  :"
        '
        'chb_voleibol
        '
        Me.chb_voleibol.AutoSize = True
        Me.chb_voleibol.Location = New System.Drawing.Point(407, 34)
        Me.chb_voleibol.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_voleibol.Name = "chb_voleibol"
        Me.chb_voleibol.Size = New System.Drawing.Size(98, 21)
        Me.chb_voleibol.TabIndex = 0
        Me.chb_voleibol.Text = "VOLEIBOL"
        Me.chb_voleibol.UseVisualStyleBackColor = True
        '
        'chb_tenis
        '
        Me.chb_tenis.AutoSize = True
        Me.chb_tenis.Location = New System.Drawing.Point(407, 65)
        Me.chb_tenis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_tenis.Name = "chb_tenis"
        Me.chb_tenis.Size = New System.Drawing.Size(70, 21)
        Me.chb_tenis.TabIndex = 0
        Me.chb_tenis.Text = "TENIS"
        Me.chb_tenis.UseVisualStyleBackColor = True
        '
        'chb_ciclismo
        '
        Me.chb_ciclismo.AutoSize = True
        Me.chb_ciclismo.Location = New System.Drawing.Point(146, 65)
        Me.chb_ciclismo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_ciclismo.Name = "chb_ciclismo"
        Me.chb_ciclismo.Size = New System.Drawing.Size(93, 21)
        Me.chb_ciclismo.TabIndex = 0
        Me.chb_ciclismo.Text = "CICLISMO"
        Me.chb_ciclismo.UseVisualStyleBackColor = True
        '
        'chb_beis
        '
        Me.chb_beis.AutoSize = True
        Me.chb_beis.Location = New System.Drawing.Point(146, 34)
        Me.chb_beis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_beis.Name = "chb_beis"
        Me.chb_beis.Size = New System.Drawing.Size(60, 21)
        Me.chb_beis.TabIndex = 0
        Me.chb_beis.Text = "BEIS"
        Me.chb_beis.UseVisualStyleBackColor = True
        '
        'chb_basket
        '
        Me.chb_basket.AutoSize = True
        Me.chb_basket.Location = New System.Drawing.Point(271, 34)
        Me.chb_basket.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_basket.Name = "chb_basket"
        Me.chb_basket.Size = New System.Drawing.Size(84, 21)
        Me.chb_basket.TabIndex = 0
        Me.chb_basket.Text = "BASKET"
        Me.chb_basket.UseVisualStyleBackColor = True
        '
        'chb_box
        '
        Me.chb_box.AutoSize = True
        Me.chb_box.Location = New System.Drawing.Point(271, 65)
        Me.chb_box.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_box.Name = "chb_box"
        Me.chb_box.Size = New System.Drawing.Size(59, 21)
        Me.chb_box.TabIndex = 0
        Me.chb_box.Text = "BOX"
        Me.chb_box.UseVisualStyleBackColor = True
        '
        'chb_otros
        '
        Me.chb_otros.AutoSize = True
        Me.chb_otros.Location = New System.Drawing.Point(11, 96)
        Me.chb_otros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_otros.Name = "chb_otros"
        Me.chb_otros.Size = New System.Drawing.Size(80, 21)
        Me.chb_otros.TabIndex = 0
        Me.chb_otros.Text = "OTROS"
        Me.chb_otros.UseVisualStyleBackColor = True
        '
        'chb_natacion
        '
        Me.chb_natacion.AutoSize = True
        Me.chb_natacion.Location = New System.Drawing.Point(10, 65)
        Me.chb_natacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_natacion.Name = "chb_natacion"
        Me.chb_natacion.Size = New System.Drawing.Size(100, 21)
        Me.chb_natacion.TabIndex = 0
        Me.chb_natacion.Text = "NATACION"
        Me.chb_natacion.UseVisualStyleBackColor = True
        '
        'chb_soccer
        '
        Me.chb_soccer.AutoSize = True
        Me.chb_soccer.Location = New System.Drawing.Point(10, 34)
        Me.chb_soccer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chb_soccer.Name = "chb_soccer"
        Me.chb_soccer.Size = New System.Drawing.Size(87, 21)
        Me.chb_soccer.TabIndex = 0
        Me.chb_soccer.Text = "SOCCER"
        Me.chb_soccer.UseVisualStyleBackColor = True
        '
        'btn_registrar
        '
        Me.btn_registrar.Location = New System.Drawing.Point(653, 370)
        Me.btn_registrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(188, 49)
        Me.btn_registrar.TabIndex = 7
        Me.btn_registrar.Text = "REGISTRAR"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(653, 446)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(188, 51)
        Me.btn_limpiar.TabIndex = 7
        Me.btn_limpiar.Text = "LIMPIAR"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btn_salir.Location = New System.Drawing.Point(1161, 491)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(238, 50)
        Me.btn_salir.TabIndex = 7
        Me.btn_salir.Text = "S A L I R"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(550, 300)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 17)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "FECHA Y HORA"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(662, 300)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(88, 17)
        Me.lbl_fecha.TabIndex = 9
        Me.lbl_fecha.Text = "__________"
        '
        'lb_alumnos
        '
        Me.lb_alumnos.FormattingEnabled = True
        Me.lb_alumnos.ItemHeight = 16
        Me.lb_alumnos.Location = New System.Drawing.Point(966, 41)
        Me.lb_alumnos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lb_alumnos.Name = "lb_alumnos"
        Me.lb_alumnos.Size = New System.Drawing.Size(433, 372)
        Me.lb_alumnos.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(1034, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(314, 25)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "LISTADO DE DATOS DE ALUMNOS"
        '
        'MENU_ALUMNOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1626, 578)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lb_alumnos)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MENU_ALUMNOS"
        Me.Text = "Inscripción Alumnos UAS(Deportes)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_apellido2 As TextBox
    Friend WithEvents txt_apellido1 As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rb_software As RadioButton
    Friend WithEvents rb_geodesia As RadioButton
    Friend WithEvents rb_civil As RadioButton
    Friend WithEvents rb_procesos As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cb_grado As ComboBox
    Friend WithEvents txt_grupo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cb_mes As ComboBox
    Friend WithEvents cb_dia As ComboBox
    Friend WithEvents txt_año As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btn_registrar As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents chb_voleibol As CheckBox
    Friend WithEvents chb_tenis As CheckBox
    Friend WithEvents chb_ciclismo As CheckBox
    Friend WithEvents chb_beis As CheckBox
    Friend WithEvents chb_basket As CheckBox
    Friend WithEvents chb_box As CheckBox
    Friend WithEvents chb_otros As CheckBox
    Friend WithEvents chb_natacion As CheckBox
    Friend WithEvents chb_soccer As CheckBox
    Friend WithEvents lb_alumnos As ListBox
    Friend WithEvents Label9 As Label
End Class
