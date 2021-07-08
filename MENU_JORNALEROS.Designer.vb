<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_JORNALEROS
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_curp = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido1 = New System.Windows.Forms.TextBox()
        Me.txt_apellido2 = New System.Windows.Forms.TextBox()
        Me.cb_estado_civil = New System.Windows.Forms.ComboBox()
        Me.A = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_porcentaje_menores = New System.Windows.Forms.Label()
        Me.lbl_total_porciento = New System.Windows.Forms.Label()
        Me.lbl_porcentaje_mujeres = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_porcentaje_hombre = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_total_trabajadores = New System.Windows.Forms.Label()
        Me.lbl_menores_edad = New System.Windows.Forms.Label()
        Me.lbl_total_mujeres = New System.Windows.Forms.Label()
        Me.lbl_total_hombres = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_total_otros = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbl_total_viudos = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl_total_divorsiados = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_total_solteros = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbl_total_casados = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgv_barrido_datos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.A.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_barrido_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CURP :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NOMBRE :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "1ER APELLIDO :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "2DO APELLIDO :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ESTADO CIVIL"
        '
        'txt_curp
        '
        Me.txt_curp.Location = New System.Drawing.Point(175, 39)
        Me.txt_curp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_curp.Name = "txt_curp"
        Me.txt_curp.Size = New System.Drawing.Size(178, 22)
        Me.txt_curp.TabIndex = 1
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(175, 88)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(178, 22)
        Me.txt_nombre.TabIndex = 1
        '
        'txt_apellido1
        '
        Me.txt_apellido1.Location = New System.Drawing.Point(175, 133)
        Me.txt_apellido1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_apellido1.Name = "txt_apellido1"
        Me.txt_apellido1.Size = New System.Drawing.Size(178, 22)
        Me.txt_apellido1.TabIndex = 1
        '
        'txt_apellido2
        '
        Me.txt_apellido2.Location = New System.Drawing.Point(175, 179)
        Me.txt_apellido2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_apellido2.Name = "txt_apellido2"
        Me.txt_apellido2.Size = New System.Drawing.Size(178, 22)
        Me.txt_apellido2.TabIndex = 1
        '
        'cb_estado_civil
        '
        Me.cb_estado_civil.FormattingEnabled = True
        Me.cb_estado_civil.Items.AddRange(New Object() {"CASADO", "SOLTERO", "DIVORCIADO", "VIUDO", "OTROS"})
        Me.cb_estado_civil.Location = New System.Drawing.Point(175, 220)
        Me.cb_estado_civil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_estado_civil.Name = "cb_estado_civil"
        Me.cb_estado_civil.Size = New System.Drawing.Size(171, 24)
        Me.cb_estado_civil.TabIndex = 2
        '
        'A
        '
        Me.A.Controls.Add(Me.Label9)
        Me.A.Controls.Add(Me.Label15)
        Me.A.Controls.Add(Me.Label13)
        Me.A.Controls.Add(Me.lbl_porcentaje_menores)
        Me.A.Controls.Add(Me.lbl_total_porciento)
        Me.A.Controls.Add(Me.lbl_porcentaje_mujeres)
        Me.A.Controls.Add(Me.Label12)
        Me.A.Controls.Add(Me.lbl_porcentaje_hombre)
        Me.A.Controls.Add(Me.Label8)
        Me.A.Controls.Add(Me.lbl_total_trabajadores)
        Me.A.Controls.Add(Me.lbl_menores_edad)
        Me.A.Controls.Add(Me.lbl_total_mujeres)
        Me.A.Controls.Add(Me.lbl_total_hombres)
        Me.A.Location = New System.Drawing.Point(50, 277)
        Me.A.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.A.Name = "A"
        Me.A.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.A.Size = New System.Drawing.Size(479, 262)
        Me.A.TabIndex = 3
        Me.A.TabStop = False
        Me.A.Text = "ACUMULADOS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(166, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "%"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(262, 198)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 17)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "MENORES EDAD"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(262, 110)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "MUJERES"
        '
        'lbl_porcentaje_menores
        '
        Me.lbl_porcentaje_menores.AutoSize = True
        Me.lbl_porcentaje_menores.Location = New System.Drawing.Point(144, 198)
        Me.lbl_porcentaje_menores.Name = "lbl_porcentaje_menores"
        Me.lbl_porcentaje_menores.Size = New System.Drawing.Size(88, 17)
        Me.lbl_porcentaje_menores.TabIndex = 0
        Me.lbl_porcentaje_menores.Text = "__________"
        '
        'lbl_total_porciento
        '
        Me.lbl_total_porciento.AutoSize = True
        Me.lbl_total_porciento.Location = New System.Drawing.Point(144, 155)
        Me.lbl_total_porciento.Name = "lbl_total_porciento"
        Me.lbl_total_porciento.Size = New System.Drawing.Size(88, 17)
        Me.lbl_total_porciento.TabIndex = 0
        Me.lbl_total_porciento.Text = "__________"
        '
        'lbl_porcentaje_mujeres
        '
        Me.lbl_porcentaje_mujeres.AutoSize = True
        Me.lbl_porcentaje_mujeres.Location = New System.Drawing.Point(144, 110)
        Me.lbl_porcentaje_mujeres.Name = "lbl_porcentaje_mujeres"
        Me.lbl_porcentaje_mujeres.Size = New System.Drawing.Size(88, 17)
        Me.lbl_porcentaje_mujeres.TabIndex = 0
        Me.lbl_porcentaje_mujeres.Text = "__________"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(262, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "HOMBRES"
        '
        'lbl_porcentaje_hombre
        '
        Me.lbl_porcentaje_hombre.AutoSize = True
        Me.lbl_porcentaje_hombre.Location = New System.Drawing.Point(144, 70)
        Me.lbl_porcentaje_hombre.Name = "lbl_porcentaje_hombre"
        Me.lbl_porcentaje_hombre.Size = New System.Drawing.Size(88, 17)
        Me.lbl_porcentaje_hombre.TabIndex = 0
        Me.lbl_porcentaje_hombre.Text = "__________"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "TRABAJADORES"
        '
        'lbl_total_trabajadores
        '
        Me.lbl_total_trabajadores.AutoSize = True
        Me.lbl_total_trabajadores.Location = New System.Drawing.Point(24, 155)
        Me.lbl_total_trabajadores.Name = "lbl_total_trabajadores"
        Me.lbl_total_trabajadores.Size = New System.Drawing.Size(88, 17)
        Me.lbl_total_trabajadores.TabIndex = 0
        Me.lbl_total_trabajadores.Text = "__________"
        '
        'lbl_menores_edad
        '
        Me.lbl_menores_edad.AutoSize = True
        Me.lbl_menores_edad.Location = New System.Drawing.Point(24, 198)
        Me.lbl_menores_edad.Name = "lbl_menores_edad"
        Me.lbl_menores_edad.Size = New System.Drawing.Size(88, 17)
        Me.lbl_menores_edad.TabIndex = 0
        Me.lbl_menores_edad.Text = "__________"
        '
        'lbl_total_mujeres
        '
        Me.lbl_total_mujeres.AutoSize = True
        Me.lbl_total_mujeres.Location = New System.Drawing.Point(24, 110)
        Me.lbl_total_mujeres.Name = "lbl_total_mujeres"
        Me.lbl_total_mujeres.Size = New System.Drawing.Size(88, 17)
        Me.lbl_total_mujeres.TabIndex = 0
        Me.lbl_total_mujeres.Text = "__________"
        '
        'lbl_total_hombres
        '
        Me.lbl_total_hombres.AutoSize = True
        Me.lbl_total_hombres.Location = New System.Drawing.Point(24, 70)
        Me.lbl_total_hombres.Name = "lbl_total_hombres"
        Me.lbl_total_hombres.Size = New System.Drawing.Size(88, 17)
        Me.lbl_total_hombres.TabIndex = 0
        Me.lbl_total_hombres.Text = "__________"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_total_otros)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.lbl_total_viudos)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.lbl_total_divorsiados)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.lbl_total_solteros)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lbl_total_casados)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(567, 325)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(333, 214)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ACUMULADOS"
        '
        'lbl_total_otros
        '
        Me.lbl_total_otros.AutoSize = True
        Me.lbl_total_otros.Location = New System.Drawing.Point(155, 155)
        Me.lbl_total_otros.Name = "lbl_total_otros"
        Me.lbl_total_otros.Size = New System.Drawing.Size(88, 17)
        Me.lbl_total_otros.TabIndex = 0
        Me.lbl_total_otros.Text = "__________"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(24, 155)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 17)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "OTROS :"
        '
        'lbl_total_viudos
        '
        Me.lbl_total_viudos.AutoSize = True
        Me.lbl_total_viudos.Location = New System.Drawing.Point(155, 130)
        Me.lbl_total_viudos.Name = "lbl_total_viudos"
        Me.lbl_total_viudos.Size = New System.Drawing.Size(88, 17)
        Me.lbl_total_viudos.TabIndex = 0
        Me.lbl_total_viudos.Text = "__________"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(24, 130)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 17)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "VIUDOS :"
        '
        'lbl_total_divorsiados
        '
        Me.lbl_total_divorsiados.AutoSize = True
        Me.lbl_total_divorsiados.Location = New System.Drawing.Point(155, 99)
        Me.lbl_total_divorsiados.Name = "lbl_total_divorsiados"
        Me.lbl_total_divorsiados.Size = New System.Drawing.Size(88, 17)
        Me.lbl_total_divorsiados.TabIndex = 0
        Me.lbl_total_divorsiados.Text = "__________"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(24, 99)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 17)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "DIVORSIADOS :"
        '
        'lbl_total_solteros
        '
        Me.lbl_total_solteros.AutoSize = True
        Me.lbl_total_solteros.Location = New System.Drawing.Point(155, 70)
        Me.lbl_total_solteros.Name = "lbl_total_solteros"
        Me.lbl_total_solteros.Size = New System.Drawing.Size(88, 17)
        Me.lbl_total_solteros.TabIndex = 0
        Me.lbl_total_solteros.Text = "__________"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(24, 70)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 17)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "SOLTEROS :"
        '
        'lbl_total_casados
        '
        Me.lbl_total_casados.AutoSize = True
        Me.lbl_total_casados.Location = New System.Drawing.Point(155, 32)
        Me.lbl_total_casados.Name = "lbl_total_casados"
        Me.lbl_total_casados.Size = New System.Drawing.Size(88, 17)
        Me.lbl_total_casados.TabIndex = 0
        Me.lbl_total_casados.Text = "__________"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(155, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 17)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "__________"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(24, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 17)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "CASADOS :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 17)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Label16"
        '
        'dgv_barrido_datos
        '
        Me.dgv_barrido_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_barrido_datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgv_barrido_datos.Location = New System.Drawing.Point(503, 15)
        Me.dgv_barrido_datos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_barrido_datos.Name = "dgv_barrido_datos"
        Me.dgv_barrido_datos.RowHeadersWidth = 51
        Me.dgv_barrido_datos.RowTemplate.Height = 29
        Me.dgv_barrido_datos.Size = New System.Drawing.Size(655, 250)
        Me.dgv_barrido_datos.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "# ENTIDAD FEDERATIVA"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "# TRABAJADORES"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "%"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 200
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(1151, 550)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(148, 33)
        Me.btn_salir.TabIndex = 6
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(1151, 432)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(148, 33)
        Me.btn_limpiar.TabIndex = 6
        Me.btn_limpiar.Text = "LIMPIAR"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(949, 432)
        Me.btn_calcular.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(148, 33)
        Me.btn_calcular.TabIndex = 6
        Me.btn_calcular.Text = "CALCULAR"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'MENU_JORNALEROS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 634)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.dgv_barrido_datos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.A)
        Me.Controls.Add(Me.cb_estado_civil)
        Me.Controls.Add(Me.txt_apellido2)
        Me.Controls.Add(Me.txt_apellido1)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_curp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MENU_JORNALEROS"
        Me.Text = "Registro de Jornaleros"
        Me.A.ResumeLayout(False)
        Me.A.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_barrido_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_curp As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_apellido1 As TextBox
    Friend WithEvents txt_apellido2 As TextBox
    Friend WithEvents cb_estado_civil As ComboBox
    Friend WithEvents A As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_porcentaje_menores As Label
    Friend WithEvents lbl_total_porciento As Label
    Friend WithEvents lbl_porcentaje_mujeres As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_porcentaje_hombre As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_total_trabajadores As Label
    Friend WithEvents lbl_menores_edad As Label
    Friend WithEvents lbl_total_mujeres As Label
    Friend WithEvents lbl_total_hombres As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_total_otros As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbl_total_viudos As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lbl_total_divorsiados As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lbl_total_solteros As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lbl_total_casados As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents dgv_barrido_datos As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_calcular As Button
End Class
