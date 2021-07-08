<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_CASE
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_sabor_pastel = New System.Windows.Forms.ComboBox()
        Me.txt_precio_por_pastel = New System.Windows.Forms.TextBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_dinero_chocolate = New System.Windows.Forms.Label()
        Me.lbl_cantidad_chocolate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_dinero_vainilla = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_cantidad_vainilla = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GRP = New System.Windows.Forms.GroupBox()
        Me.lbl_dinero_fresa = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_cantidad_fresa = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_dinero_total = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_cantidad_total = New System.Windows.Forms.Label()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GRP.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRECIO POR PASTEL :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SABOR DEL PASTEL :"
        '
        'cb_sabor_pastel
        '
        Me.cb_sabor_pastel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_sabor_pastel.FormattingEnabled = True
        Me.cb_sabor_pastel.Items.AddRange(New Object() {"CHOCOLATE", "VAINILLA", "FRESA"})
        Me.cb_sabor_pastel.Location = New System.Drawing.Point(249, 91)
        Me.cb_sabor_pastel.Name = "cb_sabor_pastel"
        Me.cb_sabor_pastel.Size = New System.Drawing.Size(121, 24)
        Me.cb_sabor_pastel.TabIndex = 2
        '
        'txt_precio_por_pastel
        '
        Me.txt_precio_por_pastel.Location = New System.Drawing.Point(249, 34)
        Me.txt_precio_por_pastel.Name = "txt_precio_por_pastel"
        Me.txt_precio_por_pastel.Size = New System.Drawing.Size(121, 22)
        Me.txt_precio_por_pastel.TabIndex = 1
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(381, 131)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(139, 31)
        Me.btn_limpiar.TabIndex = 4
        Me.btn_limpiar.Text = "LIMPIAR"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lbl_dinero_chocolate)
        Me.GroupBox1.Controls.Add(Me.lbl_cantidad_chocolate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 181)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 184)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CHOCOLATE"
        '
        'lbl_dinero_chocolate
        '
        Me.lbl_dinero_chocolate.AutoSize = True
        Me.lbl_dinero_chocolate.Location = New System.Drawing.Point(188, 100)
        Me.lbl_dinero_chocolate.Name = "lbl_dinero_chocolate"
        Me.lbl_dinero_chocolate.Size = New System.Drawing.Size(16, 17)
        Me.lbl_dinero_chocolate.TabIndex = 1
        Me.lbl_dinero_chocolate.Text = "0"
        '
        'lbl_cantidad_chocolate
        '
        Me.lbl_cantidad_chocolate.AutoSize = True
        Me.lbl_cantidad_chocolate.Location = New System.Drawing.Point(188, 42)
        Me.lbl_cantidad_chocolate.Name = "lbl_cantidad_chocolate"
        Me.lbl_cantidad_chocolate.Size = New System.Drawing.Size(16, 17)
        Me.lbl_cantidad_chocolate.TabIndex = 1
        Me.lbl_cantidad_chocolate.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "DINERO GEN."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "CANTIDAD"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.lbl_dinero_vainilla)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lbl_cantidad_vainilla)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(348, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(304, 184)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "VAINILLA"
        '
        'lbl_dinero_vainilla
        '
        Me.lbl_dinero_vainilla.AutoSize = True
        Me.lbl_dinero_vainilla.Location = New System.Drawing.Point(215, 101)
        Me.lbl_dinero_vainilla.Name = "lbl_dinero_vainilla"
        Me.lbl_dinero_vainilla.Size = New System.Drawing.Size(16, 17)
        Me.lbl_dinero_vainilla.TabIndex = 1
        Me.lbl_dinero_vainilla.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "DINERO GEN."
        '
        'lbl_cantidad_vainilla
        '
        Me.lbl_cantidad_vainilla.AutoSize = True
        Me.lbl_cantidad_vainilla.Location = New System.Drawing.Point(215, 43)
        Me.lbl_cantidad_vainilla.Name = "lbl_cantidad_vainilla"
        Me.lbl_cantidad_vainilla.Size = New System.Drawing.Size(16, 17)
        Me.lbl_cantidad_vainilla.TabIndex = 1
        Me.lbl_cantidad_vainilla.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "CANTIDAD"
        '
        'GRP
        '
        Me.GRP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GRP.Controls.Add(Me.lbl_dinero_fresa)
        Me.GRP.Controls.Add(Me.Label10)
        Me.GRP.Controls.Add(Me.Label9)
        Me.GRP.Controls.Add(Me.lbl_cantidad_fresa)
        Me.GRP.Location = New System.Drawing.Point(26, 426)
        Me.GRP.Name = "GRP"
        Me.GRP.Size = New System.Drawing.Size(281, 184)
        Me.GRP.TabIndex = 4
        Me.GRP.TabStop = False
        Me.GRP.Text = "FRESA"
        '
        'lbl_dinero_fresa
        '
        Me.lbl_dinero_fresa.AutoSize = True
        Me.lbl_dinero_fresa.Location = New System.Drawing.Point(188, 114)
        Me.lbl_dinero_fresa.Name = "lbl_dinero_fresa"
        Me.lbl_dinero_fresa.Size = New System.Drawing.Size(16, 17)
        Me.lbl_dinero_fresa.TabIndex = 1
        Me.lbl_dinero_fresa.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "DINERO GEN."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "CANTIDAD"
        '
        'lbl_cantidad_fresa
        '
        Me.lbl_cantidad_fresa.AutoSize = True
        Me.lbl_cantidad_fresa.Location = New System.Drawing.Point(188, 56)
        Me.lbl_cantidad_fresa.Name = "lbl_cantidad_fresa"
        Me.lbl_cantidad_fresa.Size = New System.Drawing.Size(16, 17)
        Me.lbl_cantidad_fresa.TabIndex = 1
        Me.lbl_cantidad_fresa.Text = "0"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.lbl_dinero_total)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lbl_cantidad_total)
        Me.GroupBox3.Location = New System.Drawing.Point(348, 436)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(304, 184)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TOTALES"
        '
        'lbl_dinero_total
        '
        Me.lbl_dinero_total.AutoSize = True
        Me.lbl_dinero_total.Location = New System.Drawing.Point(203, 105)
        Me.lbl_dinero_total.Name = "lbl_dinero_total"
        Me.lbl_dinero_total.Size = New System.Drawing.Size(16, 17)
        Me.lbl_dinero_total.TabIndex = 1
        Me.lbl_dinero_total.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "DINERO GEN."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "CANTIDAD"
        '
        'lbl_cantidad_total
        '
        Me.lbl_cantidad_total.AutoSize = True
        Me.lbl_cantidad_total.Location = New System.Drawing.Point(203, 47)
        Me.lbl_cantidad_total.Name = "lbl_cantidad_total"
        Me.lbl_cantidad_total.Size = New System.Drawing.Size(16, 17)
        Me.lbl_cantidad_total.TabIndex = 1
        Me.lbl_cantidad_total.Text = "0"
        '
        'btn_registrar
        '
        Me.btn_registrar.Location = New System.Drawing.Point(458, 56)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(139, 31)
        Me.btn_registrar.TabIndex = 3
        Me.btn_registrar.Text = "REGISTRAR"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(542, 131)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(139, 31)
        Me.btn_salir.TabIndex = 5
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'MENU_CASE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(703, 649)
        Me.Controls.Add(Me.GRP)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.txt_precio_por_pastel)
        Me.Controls.Add(Me.cb_sabor_pastel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MENU_CASE"
        Me.Text = "Case de Pasteles"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GRP.ResumeLayout(False)
        Me.GRP.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_sabor_pastel As ComboBox
    Friend WithEvents txt_precio_por_pastel As TextBox
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GRP As GroupBox
    Friend WithEvents lbl_dinero_chocolate As Label
    Friend WithEvents lbl_cantidad_chocolate As Label
    Friend WithEvents lbl_dinero_vainilla As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_cantidad_vainilla As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_dinero_fresa As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_cantidad_fresa As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_dinero_total As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_cantidad_total As Label
    Friend WithEvents btn_registrar As Button
    Friend WithEvents btn_salir As Button
End Class
