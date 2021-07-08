<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_INSCRIPCION
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
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.txt_pago_oficial = New System.Windows.Forms.TextBox()
        Me.cb_carrera = New System.Windows.Forms.ComboBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.cb_grado_escolar = New System.Windows.Forms.ComboBox()
        Me.txt_promedio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_alumnos_civil = New System.Windows.Forms.Label()
        Me.lbl_suma_antes_descuento_civil = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_descuento_civil = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_suma_despues_civil = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_alumnos_geodesia = New System.Windows.Forms.Label()
        Me.lbl_suma_antes_descuento_geodesia = New System.Windows.Forms.Label()
        Me.lbl_descuento_geodesia = New System.Windows.Forms.Label()
        Me.lbl_suma_despues_geodesia = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbl_alumnos_software = New System.Windows.Forms.Label()
        Me.lbl_suma_antes_descuento_software = New System.Windows.Forms.Label()
        Me.lbl_descuento_software = New System.Windows.Forms.Label()
        Me.lbl_suma_despues_software = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_descuento = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.GR = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_alumnos_sumas = New System.Windows.Forms.Label()
        Me.lbl_suma_despues_sumas = New System.Windows.Forms.Label()
        Me.lbl_suma_antes_descuento_sumas = New System.Windows.Forms.Label()
        Me.lbl_descuento_sumas = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GR.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(826, 620)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(188, 40)
        Me.btn_salir.TabIndex = 8
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(434, 620)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(188, 40)
        Me.btn_calcular.TabIndex = 6
        Me.btn_calcular.Text = "CALCULAR"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(79, 620)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(188, 40)
        Me.btn_limpiar.TabIndex = 7
        Me.btn_limpiar.Text = "LIMPIAR"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'txt_pago_oficial
        '
        Me.txt_pago_oficial.Location = New System.Drawing.Point(210, 50)
        Me.txt_pago_oficial.Name = "txt_pago_oficial"
        Me.txt_pago_oficial.Size = New System.Drawing.Size(100, 22)
        Me.txt_pago_oficial.TabIndex = 1
        '
        'cb_carrera
        '
        Me.cb_carrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_carrera.FormattingEnabled = True
        Me.cb_carrera.Items.AddRange(New Object() {"CIVIL", "GEODESIA", "SOFTWARE"})
        Me.cb_carrera.Location = New System.Drawing.Point(210, 118)
        Me.cb_carrera.Name = "cb_carrera"
        Me.cb_carrera.Size = New System.Drawing.Size(121, 24)
        Me.cb_carrera.TabIndex = 2
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(210, 195)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(170, 22)
        Me.txt_nombre.TabIndex = 3
        '
        'cb_grado_escolar
        '
        Me.cb_grado_escolar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_grado_escolar.FormattingEnabled = True
        Me.cb_grado_escolar.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cb_grado_escolar.Location = New System.Drawing.Point(210, 249)
        Me.cb_grado_escolar.Name = "cb_grado_escolar"
        Me.cb_grado_escolar.Size = New System.Drawing.Size(121, 24)
        Me.cb_grado_escolar.TabIndex = 4
        '
        'txt_promedio
        '
        Me.txt_promedio.Location = New System.Drawing.Point(210, 318)
        Me.txt_promedio.Name = "txt_promedio"
        Me.txt_promedio.Size = New System.Drawing.Size(100, 22)
        Me.txt_promedio.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PAGO OFICIAL :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CARRERA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NOMBRE ALUMNO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "GRADO ESCOLAR:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "PROMEDIO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "ALUM. INSCRITOS:"
        '
        'lbl_alumnos_civil
        '
        Me.lbl_alumnos_civil.AutoSize = True
        Me.lbl_alumnos_civil.Location = New System.Drawing.Point(251, 43)
        Me.lbl_alumnos_civil.Name = "lbl_alumnos_civil"
        Me.lbl_alumnos_civil.Size = New System.Drawing.Size(16, 17)
        Me.lbl_alumnos_civil.TabIndex = 3
        Me.lbl_alumnos_civil.Text = "0"
        '
        'lbl_suma_antes_descuento_civil
        '
        Me.lbl_suma_antes_descuento_civil.AutoSize = True
        Me.lbl_suma_antes_descuento_civil.Location = New System.Drawing.Point(251, 96)
        Me.lbl_suma_antes_descuento_civil.Name = "lbl_suma_antes_descuento_civil"
        Me.lbl_suma_antes_descuento_civil.Size = New System.Drawing.Size(16, 17)
        Me.lbl_suma_antes_descuento_civil.TabIndex = 3
        Me.lbl_suma_antes_descuento_civil.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "SUMA $ ANTES DESC.:"
        '
        'lbl_descuento_civil
        '
        Me.lbl_descuento_civil.AutoSize = True
        Me.lbl_descuento_civil.Location = New System.Drawing.Point(251, 147)
        Me.lbl_descuento_civil.Name = "lbl_descuento_civil"
        Me.lbl_descuento_civil.Size = New System.Drawing.Size(16, 17)
        Me.lbl_descuento_civil.TabIndex = 3
        Me.lbl_descuento_civil.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 17)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "DESC. $ APLICADO:"
        '
        'lbl_suma_despues_civil
        '
        Me.lbl_suma_despues_civil.AutoSize = True
        Me.lbl_suma_despues_civil.Location = New System.Drawing.Point(251, 203)
        Me.lbl_suma_despues_civil.Name = "lbl_suma_despues_civil"
        Me.lbl_suma_despues_civil.Size = New System.Drawing.Size(16, 17)
        Me.lbl_suma_despues_civil.TabIndex = 3
        Me.lbl_suma_despues_civil.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 203)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(177, 17)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "SUMA $ DESPUES DESC.:"
        '
        'lbl_alumnos_geodesia
        '
        Me.lbl_alumnos_geodesia.AutoSize = True
        Me.lbl_alumnos_geodesia.Location = New System.Drawing.Point(251, 38)
        Me.lbl_alumnos_geodesia.Name = "lbl_alumnos_geodesia"
        Me.lbl_alumnos_geodesia.Size = New System.Drawing.Size(16, 17)
        Me.lbl_alumnos_geodesia.TabIndex = 3
        Me.lbl_alumnos_geodesia.Text = "0"
        '
        'lbl_suma_antes_descuento_geodesia
        '
        Me.lbl_suma_antes_descuento_geodesia.AutoSize = True
        Me.lbl_suma_antes_descuento_geodesia.Location = New System.Drawing.Point(251, 92)
        Me.lbl_suma_antes_descuento_geodesia.Name = "lbl_suma_antes_descuento_geodesia"
        Me.lbl_suma_antes_descuento_geodesia.Size = New System.Drawing.Size(16, 17)
        Me.lbl_suma_antes_descuento_geodesia.TabIndex = 3
        Me.lbl_suma_antes_descuento_geodesia.Text = "0"
        '
        'lbl_descuento_geodesia
        '
        Me.lbl_descuento_geodesia.AutoSize = True
        Me.lbl_descuento_geodesia.Location = New System.Drawing.Point(251, 143)
        Me.lbl_descuento_geodesia.Name = "lbl_descuento_geodesia"
        Me.lbl_descuento_geodesia.Size = New System.Drawing.Size(16, 17)
        Me.lbl_descuento_geodesia.TabIndex = 3
        Me.lbl_descuento_geodesia.Text = "0"
        '
        'lbl_suma_despues_geodesia
        '
        Me.lbl_suma_despues_geodesia.AutoSize = True
        Me.lbl_suma_despues_geodesia.Location = New System.Drawing.Point(251, 198)
        Me.lbl_suma_despues_geodesia.Name = "lbl_suma_despues_geodesia"
        Me.lbl_suma_despues_geodesia.Size = New System.Drawing.Size(16, 17)
        Me.lbl_suma_despues_geodesia.TabIndex = 3
        Me.lbl_suma_despues_geodesia.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 36)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(131, 17)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "ALUM. INSCRITOS:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 92)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(158, 17)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "SUMA $ ANTES DESC.:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 143)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(137, 17)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "DESC. $ APLICADO:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 196)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(177, 17)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "SUMA $ DESPUES DESC.:"
        '
        'lbl_alumnos_software
        '
        Me.lbl_alumnos_software.AutoSize = True
        Me.lbl_alumnos_software.Location = New System.Drawing.Point(251, 36)
        Me.lbl_alumnos_software.Name = "lbl_alumnos_software"
        Me.lbl_alumnos_software.Size = New System.Drawing.Size(16, 17)
        Me.lbl_alumnos_software.TabIndex = 3
        Me.lbl_alumnos_software.Text = "0"
        '
        'lbl_suma_antes_descuento_software
        '
        Me.lbl_suma_antes_descuento_software.AutoSize = True
        Me.lbl_suma_antes_descuento_software.Location = New System.Drawing.Point(251, 92)
        Me.lbl_suma_antes_descuento_software.Name = "lbl_suma_antes_descuento_software"
        Me.lbl_suma_antes_descuento_software.Size = New System.Drawing.Size(16, 17)
        Me.lbl_suma_antes_descuento_software.TabIndex = 3
        Me.lbl_suma_antes_descuento_software.Text = "0"
        '
        'lbl_descuento_software
        '
        Me.lbl_descuento_software.AutoSize = True
        Me.lbl_descuento_software.Location = New System.Drawing.Point(251, 141)
        Me.lbl_descuento_software.Name = "lbl_descuento_software"
        Me.lbl_descuento_software.Size = New System.Drawing.Size(16, 17)
        Me.lbl_descuento_software.TabIndex = 3
        Me.lbl_descuento_software.Text = "0"
        '
        'lbl_suma_despues_software
        '
        Me.lbl_suma_despues_software.AutoSize = True
        Me.lbl_suma_despues_software.Location = New System.Drawing.Point(251, 196)
        Me.lbl_suma_despues_software.Name = "lbl_suma_despues_software"
        Me.lbl_suma_despues_software.Size = New System.Drawing.Size(16, 17)
        Me.lbl_suma_despues_software.TabIndex = 3
        Me.lbl_suma_despues_software.Text = "0"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 38)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(131, 17)
        Me.Label26.TabIndex = 3
        Me.Label26.Text = "ALUM. INSCRITOS:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 92)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(158, 17)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "SUMA $ ANTES DESC.:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 141)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(137, 17)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "DESC. $ APLICADO:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 196)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(177, 17)
        Me.Label29.TabIndex = 3
        Me.Label29.Text = "SUMA $ DESPUES DESC.:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lbl_alumnos_civil)
        Me.GroupBox1.Controls.Add(Me.lbl_suma_antes_descuento_civil)
        Me.GroupBox1.Controls.Add(Me.lbl_descuento_civil)
        Me.GroupBox1.Controls.Add(Me.lbl_suma_despues_civil)
        Me.GroupBox1.Location = New System.Drawing.Point(401, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 256)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CIVIL"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(229, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 17)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "#"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.lbl_alumnos_geodesia)
        Me.GroupBox2.Controls.Add(Me.lbl_suma_antes_descuento_geodesia)
        Me.GroupBox2.Controls.Add(Me.lbl_suma_despues_geodesia)
        Me.GroupBox2.Controls.Add(Me.lbl_descuento_geodesia)
        Me.GroupBox2.Location = New System.Drawing.Point(778, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 256)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GEODESIA"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(229, 38)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(16, 17)
        Me.Label32.TabIndex = 10
        Me.Label32.Text = "#"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.lbl_alumnos_software)
        Me.GroupBox3.Controls.Add(Me.lbl_suma_despues_software)
        Me.GroupBox3.Controls.Add(Me.lbl_suma_antes_descuento_software)
        Me.GroupBox3.Controls.Add(Me.lbl_descuento_software)
        Me.GroupBox3.Location = New System.Drawing.Point(401, 296)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(344, 256)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SOFTWARE"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(229, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 17)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "#"
        '
        'txt_descuento
        '
        Me.txt_descuento.Location = New System.Drawing.Point(205, 458)
        Me.txt_descuento.Name = "txt_descuento"
        Me.txt_descuento.Size = New System.Drawing.Size(100, 22)
        Me.txt_descuento.TabIndex = 9
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(60, 463)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(98, 17)
        Me.Label30.TabIndex = 3
        Me.Label30.Text = "DESCUENTO:"
        '
        'GR
        '
        Me.GR.Controls.Add(Me.Label7)
        Me.GR.Controls.Add(Me.Label8)
        Me.GR.Controls.Add(Me.Label16)
        Me.GR.Controls.Add(Me.Label10)
        Me.GR.Controls.Add(Me.Label12)
        Me.GR.Controls.Add(Me.lbl_alumnos_sumas)
        Me.GR.Controls.Add(Me.lbl_suma_despues_sumas)
        Me.GR.Controls.Add(Me.lbl_suma_antes_descuento_sumas)
        Me.GR.Controls.Add(Me.lbl_descuento_sumas)
        Me.GR.Location = New System.Drawing.Point(778, 296)
        Me.GR.Name = "GR"
        Me.GR.Size = New System.Drawing.Size(335, 256)
        Me.GR.TabIndex = 4
        Me.GR.TabStop = False
        Me.GR.Text = "SUMAS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "SUMA $ ANTES DESC.:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "ALUM. INSCRITOS:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(226, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(16, 17)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "#"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 17)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "DESC. $ APLICADO:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 196)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(177, 17)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "SUMA $ DESPUES DESC.:"
        '
        'lbl_alumnos_sumas
        '
        Me.lbl_alumnos_sumas.AutoSize = True
        Me.lbl_alumnos_sumas.Location = New System.Drawing.Point(248, 36)
        Me.lbl_alumnos_sumas.Name = "lbl_alumnos_sumas"
        Me.lbl_alumnos_sumas.Size = New System.Drawing.Size(16, 17)
        Me.lbl_alumnos_sumas.TabIndex = 3
        Me.lbl_alumnos_sumas.Text = "0"
        '
        'lbl_suma_despues_sumas
        '
        Me.lbl_suma_despues_sumas.AutoSize = True
        Me.lbl_suma_despues_sumas.Location = New System.Drawing.Point(248, 196)
        Me.lbl_suma_despues_sumas.Name = "lbl_suma_despues_sumas"
        Me.lbl_suma_despues_sumas.Size = New System.Drawing.Size(16, 17)
        Me.lbl_suma_despues_sumas.TabIndex = 3
        Me.lbl_suma_despues_sumas.Text = "0"
        '
        'lbl_suma_antes_descuento_sumas
        '
        Me.lbl_suma_antes_descuento_sumas.AutoSize = True
        Me.lbl_suma_antes_descuento_sumas.Location = New System.Drawing.Point(248, 92)
        Me.lbl_suma_antes_descuento_sumas.Name = "lbl_suma_antes_descuento_sumas"
        Me.lbl_suma_antes_descuento_sumas.Size = New System.Drawing.Size(16, 17)
        Me.lbl_suma_antes_descuento_sumas.TabIndex = 3
        Me.lbl_suma_antes_descuento_sumas.Text = "0"
        '
        'lbl_descuento_sumas
        '
        Me.lbl_descuento_sumas.AutoSize = True
        Me.lbl_descuento_sumas.Location = New System.Drawing.Point(248, 141)
        Me.lbl_descuento_sumas.Name = "lbl_descuento_sumas"
        Me.lbl_descuento_sumas.Size = New System.Drawing.Size(16, 17)
        Me.lbl_descuento_sumas.TabIndex = 3
        Me.lbl_descuento_sumas.Text = "0"
        '
        'MENU_INSCRIPCION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1258, 707)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_grado_escolar)
        Me.Controls.Add(Me.txt_descuento)
        Me.Controls.Add(Me.cb_carrera)
        Me.Controls.Add(Me.txt_promedio)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_pago_oficial)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GR)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "MENU_INSCRIPCION"
        Me.Text = "Inscripcion Alumnos UAS(Por Carrera)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GR.ResumeLayout(False)
        Me.GR.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_calcular As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents txt_pago_oficial As TextBox
    Friend WithEvents cb_carrera As ComboBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents cb_grado_escolar As ComboBox
    Friend WithEvents txt_promedio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_alumnos_civil As Label
    Friend WithEvents lbl_suma_antes_descuento_civil As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_descuento_civil As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_suma_despues_civil As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_alumnos_geodesia As Label
    Friend WithEvents lbl_suma_antes_descuento_geodesia As Label
    Friend WithEvents lbl_descuento_geodesia As Label
    Friend WithEvents lbl_suma_despues_geodesia As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lbl_alumnos_software As Label
    Friend WithEvents lbl_suma_antes_descuento_software As Label
    Friend WithEvents lbl_descuento_software As Label
    Friend WithEvents lbl_suma_despues_software As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_descuento As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents GR As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_alumnos_sumas As Label
    Friend WithEvents lbl_suma_despues_sumas As Label
    Friend WithEvents lbl_suma_antes_descuento_sumas As Label
    Friend WithEvents lbl_descuento_sumas As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
End Class
