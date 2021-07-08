<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISR
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
        Me.cb_entidad_federativa = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_importe_anual = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_rfc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_base_gravable = New System.Windows.Forms.Label()
        Me.lbl_isr = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_salario_minimo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.c_porcentaje_nacional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_isr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_entidad_federativa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_barrido_datos = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_suma_total_isr = New System.Windows.Forms.Label()
        Me.lbl_porciento = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_barrido_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb_entidad_federativa
        '
        Me.cb_entidad_federativa.FormattingEnabled = True
        Me.cb_entidad_federativa.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32"})
        Me.cb_entidad_federativa.Location = New System.Drawing.Point(859, 59)
        Me.cb_entidad_federativa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_entidad_federativa.Name = "cb_entidad_federativa"
        Me.cb_entidad_federativa.Size = New System.Drawing.Size(158, 31)
        Me.cb_entidad_federativa.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(282, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOMBRE CONTRIBUYENTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(842, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ENTIDAD FEDERATIVA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(531, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "IMPORTE INGRESOS ANUALES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "RFC CONTRIBUYENTE"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txt_importe_anual)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_rfc)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cb_entidad_federativa)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1088, 116)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS ENTRADA"
        '
        'txt_importe_anual
        '
        Me.txt_importe_anual.Location = New System.Drawing.Point(597, 65)
        Me.txt_importe_anual.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_importe_anual.Name = "txt_importe_anual"
        Me.txt_importe_anual.Size = New System.Drawing.Size(125, 30)
        Me.txt_importe_anual.TabIndex = 7
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(338, 62)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(125, 30)
        Me.txt_nombre.TabIndex = 7
        '
        'txt_rfc
        '
        Me.txt_rfc.Location = New System.Drawing.Point(90, 62)
        Me.txt_rfc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_rfc.Name = "txt_rfc"
        Me.txt_rfc.Size = New System.Drawing.Size(125, 30)
        Me.txt_rfc.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "BASE GRAVABLE :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 23)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "ISR A PAGAR :"
        '
        'lbl_base_gravable
        '
        Me.lbl_base_gravable.AutoSize = True
        Me.lbl_base_gravable.Location = New System.Drawing.Point(180, 34)
        Me.lbl_base_gravable.Name = "lbl_base_gravable"
        Me.lbl_base_gravable.Size = New System.Drawing.Size(80, 23)
        Me.lbl_base_gravable.TabIndex = 9
        Me.lbl_base_gravable.Text = "__________"
        '
        'lbl_isr
        '
        Me.lbl_isr.AutoSize = True
        Me.lbl_isr.Location = New System.Drawing.Point(180, 134)
        Me.lbl_isr.Name = "lbl_isr"
        Me.lbl_isr.Size = New System.Drawing.Size(80, 23)
        Me.lbl_isr.TabIndex = 10
        Me.lbl_isr.Text = "__________"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Blue
        Me.GroupBox2.Controls.Add(Me.lbl_isr)
        Me.GroupBox2.Controls.Add(Me.lbl_base_gravable)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 128)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(310, 177)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RESULTADO"
        '
        'txt_salario_minimo
        '
        Me.txt_salario_minimo.Location = New System.Drawing.Point(1190, 74)
        Me.txt_salario_minimo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_salario_minimo.Name = "txt_salario_minimo"
        Me.txt_salario_minimo.Size = New System.Drawing.Size(135, 22)
        Me.txt_salario_minimo.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Felix Titling", 18.0!)
        Me.Label6.Location = New System.Drawing.Point(1125, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(270, 35)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "SALARIO MINIMO"
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(2, 409)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(133, 30)
        Me.btn_limpiar.TabIndex = 15
        Me.btn_limpiar.Text = "L I M P I A R"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(204, 409)
        Me.btn_calcular.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(133, 30)
        Me.btn_calcular.TabIndex = 16
        Me.btn_calcular.Text = "C A L C U L A R"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(1262, 409)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(133, 30)
        Me.btn_salir.TabIndex = 17
        Me.btn_salir.Text = "S A L I R"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'c_porcentaje_nacional
        '
        Me.c_porcentaje_nacional.HeaderText = "% NACIONAL"
        Me.c_porcentaje_nacional.MinimumWidth = 6
        Me.c_porcentaje_nacional.Name = "c_porcentaje_nacional"
        Me.c_porcentaje_nacional.ReadOnly = True
        Me.c_porcentaje_nacional.Width = 250
        '
        'c_isr
        '
        Me.c_isr.HeaderText = "ISR COBRADO"
        Me.c_isr.MinimumWidth = 6
        Me.c_isr.Name = "c_isr"
        Me.c_isr.ReadOnly = True
        Me.c_isr.Width = 250
        '
        'c_entidad_federativa
        '
        Me.c_entidad_federativa.HeaderText = "ENTIDAD FEDERATIVA"
        Me.c_entidad_federativa.MinimumWidth = 6
        Me.c_entidad_federativa.Name = "c_entidad_federativa"
        Me.c_entidad_federativa.ReadOnly = True
        Me.c_entidad_federativa.Width = 250
        '
        'dgv_barrido_datos
        '
        Me.dgv_barrido_datos.AllowUserToAddRows = False
        Me.dgv_barrido_datos.AllowUserToDeleteRows = False
        Me.dgv_barrido_datos.AllowUserToOrderColumns = True
        Me.dgv_barrido_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_barrido_datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_entidad_federativa, Me.c_isr, Me.c_porcentaje_nacional})
        Me.dgv_barrido_datos.Location = New System.Drawing.Point(340, 128)
        Me.dgv_barrido_datos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_barrido_datos.Name = "dgv_barrido_datos"
        Me.dgv_barrido_datos.ReadOnly = True
        Me.dgv_barrido_datos.RowHeadersWidth = 51
        Me.dgv_barrido_datos.RowTemplate.Height = 29
        Me.dgv_barrido_datos.Size = New System.Drawing.Size(750, 236)
        Me.dgv_barrido_datos.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(519, 377)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 25)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "SUMAS  :"
        '
        'lbl_suma_total_isr
        '
        Me.lbl_suma_total_isr.AutoSize = True
        Me.lbl_suma_total_isr.Location = New System.Drawing.Point(698, 380)
        Me.lbl_suma_total_isr.Name = "lbl_suma_total_isr"
        Me.lbl_suma_total_isr.Size = New System.Drawing.Size(96, 17)
        Me.lbl_suma_total_isr.TabIndex = 21
        Me.lbl_suma_total_isr.Text = "___________"
        '
        'lbl_porciento
        '
        Me.lbl_porciento.AutoSize = True
        Me.lbl_porciento.Location = New System.Drawing.Point(991, 381)
        Me.lbl_porciento.Name = "lbl_porciento"
        Me.lbl_porciento.Size = New System.Drawing.Size(96, 17)
        Me.lbl_porciento.TabIndex = 22
        Me.lbl_porciento.Text = "___________"
        '
        'ISR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1407, 454)
        Me.Controls.Add(Me.lbl_porciento)
        Me.Controls.Add(Me.lbl_suma_total_isr)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgv_barrido_datos)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_salario_minimo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ISR"
        Me.Text = "Programa ISR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_barrido_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_entidad_federativa As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_importe_anual As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_rfc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_base_gravable As Label
    Friend WithEvents lbl_isr As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_salario_minimo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_calcular As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents c_porcentaje_nacional As DataGridViewTextBoxColumn
    Friend WithEvents c_isr As DataGridViewTextBoxColumn
    Friend WithEvents c_entidad_federativa As DataGridViewTextBoxColumn
    Friend WithEvents dgv_barrido_datos As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_suma_total_isr As Label
    Friend WithEvents lbl_porciento As Label
End Class

