<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_GASOLINA
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
        Me.gb_precios_litro = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.presio_diesel = New System.Windows.Forms.TextBox()
        Me.presio_premium = New System.Windows.Forms.TextBox()
        Me.presio_magna = New System.Windows.Forms.TextBox()
        Me.gb_elegir_combustible = New System.Windows.Forms.GroupBox()
        Me.rb_diesel = New System.Windows.Forms.RadioButton()
        Me.rb_premium = New System.Windows.Forms.RadioButton()
        Me.rb_magna = New System.Windows.Forms.RadioButton()
        Me.gb_tipo_de_pago = New System.Windows.Forms.GroupBox()
        Me.rb_efectivo = New System.Windows.Forms.RadioButton()
        Me.rb_tarjeta_de_credito = New System.Windows.Forms.RadioButton()
        Me.rb_cheque = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.litros_vendidos = New System.Windows.Forms.TextBox()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_importe = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.gb_totales_pago = New System.Windows.Forms.GroupBox()
        Me.lbl_total_ventas = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_total_cheque = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_total_efectivo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gb_totales_combustible = New System.Windows.Forms.GroupBox()
        Me.lbl_total_importe = New System.Windows.Forms.Label()
        Me.lbl_total_litros = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_importe_diesel = New System.Windows.Forms.Label()
        Me.lbl_importe_premium = New System.Windows.Forms.Label()
        Me.lbl_importe_magna = New System.Windows.Forms.Label()
        Me.lbl_litros_diesel = New System.Windows.Forms.Label()
        Me.lbl_litros_premium = New System.Windows.Forms.Label()
        Me.lbl_litros_magna = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_total_tarjeta = New System.Windows.Forms.Label()
        Me.gb_precios_litro.SuspendLayout()
        Me.gb_elegir_combustible.SuspendLayout()
        Me.gb_tipo_de_pago.SuspendLayout()
        Me.gb_totales_pago.SuspendLayout()
        Me.gb_totales_combustible.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_precios_litro
        '
        Me.gb_precios_litro.Controls.Add(Me.Label3)
        Me.gb_precios_litro.Controls.Add(Me.Label2)
        Me.gb_precios_litro.Controls.Add(Me.Label1)
        Me.gb_precios_litro.Controls.Add(Me.presio_diesel)
        Me.gb_precios_litro.Controls.Add(Me.presio_premium)
        Me.gb_precios_litro.Controls.Add(Me.presio_magna)
        Me.gb_precios_litro.Location = New System.Drawing.Point(12, 23)
        Me.gb_precios_litro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_precios_litro.Name = "gb_precios_litro"
        Me.gb_precios_litro.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_precios_litro.Size = New System.Drawing.Size(694, 114)
        Me.gb_precios_litro.TabIndex = 0
        Me.gb_precios_litro.TabStop = False
        Me.gb_precios_litro.Text = "PRECIOS POR LITRO"
        Me.gb_precios_litro.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "MAGNA"
        Me.Label3.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(316, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PREMIUM"
        Me.Label2.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(542, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DIESEL"
        Me.Label1.UseWaitCursor = True
        '
        'presio_diesel
        '
        Me.presio_diesel.Location = New System.Drawing.Point(492, 70)
        Me.presio_diesel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.presio_diesel.Name = "presio_diesel"
        Me.presio_diesel.Size = New System.Drawing.Size(167, 22)
        Me.presio_diesel.TabIndex = 2
        Me.presio_diesel.UseWaitCursor = True
        '
        'presio_premium
        '
        Me.presio_premium.Location = New System.Drawing.Point(255, 70)
        Me.presio_premium.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.presio_premium.Name = "presio_premium"
        Me.presio_premium.Size = New System.Drawing.Size(167, 22)
        Me.presio_premium.TabIndex = 1
        Me.presio_premium.UseWaitCursor = True
        '
        'presio_magna
        '
        Me.presio_magna.Location = New System.Drawing.Point(25, 70)
        Me.presio_magna.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.presio_magna.Name = "presio_magna"
        Me.presio_magna.Size = New System.Drawing.Size(157, 22)
        Me.presio_magna.TabIndex = 0
        Me.presio_magna.UseWaitCursor = True
        '
        'gb_elegir_combustible
        '
        Me.gb_elegir_combustible.Controls.Add(Me.rb_diesel)
        Me.gb_elegir_combustible.Controls.Add(Me.rb_premium)
        Me.gb_elegir_combustible.Controls.Add(Me.rb_magna)
        Me.gb_elegir_combustible.Location = New System.Drawing.Point(12, 142)
        Me.gb_elegir_combustible.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_elegir_combustible.Name = "gb_elegir_combustible"
        Me.gb_elegir_combustible.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_elegir_combustible.Size = New System.Drawing.Size(570, 62)
        Me.gb_elegir_combustible.TabIndex = 1
        Me.gb_elegir_combustible.TabStop = False
        Me.gb_elegir_combustible.Text = "ELEGIR COMBUSTIBLE:"
        '
        'rb_diesel
        '
        Me.rb_diesel.AutoSize = True
        Me.rb_diesel.Location = New System.Drawing.Point(390, 29)
        Me.rb_diesel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rb_diesel.Name = "rb_diesel"
        Me.rb_diesel.Size = New System.Drawing.Size(77, 21)
        Me.rb_diesel.TabIndex = 1
        Me.rb_diesel.TabStop = True
        Me.rb_diesel.Text = "DIESEL"
        Me.rb_diesel.UseVisualStyleBackColor = True
        '
        'rb_premium
        '
        Me.rb_premium.AutoSize = True
        Me.rb_premium.Location = New System.Drawing.Point(213, 29)
        Me.rb_premium.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rb_premium.Name = "rb_premium"
        Me.rb_premium.Size = New System.Drawing.Size(92, 21)
        Me.rb_premium.TabIndex = 0
        Me.rb_premium.TabStop = True
        Me.rb_premium.Text = "PREMIUM"
        Me.rb_premium.UseVisualStyleBackColor = True
        '
        'rb_magna
        '
        Me.rb_magna.AutoSize = True
        Me.rb_magna.Location = New System.Drawing.Point(56, 29)
        Me.rb_magna.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rb_magna.Name = "rb_magna"
        Me.rb_magna.Size = New System.Drawing.Size(79, 21)
        Me.rb_magna.TabIndex = 0
        Me.rb_magna.TabStop = True
        Me.rb_magna.Text = "MAGNA"
        Me.rb_magna.UseVisualStyleBackColor = True
        '
        'gb_tipo_de_pago
        '
        Me.gb_tipo_de_pago.Controls.Add(Me.rb_efectivo)
        Me.gb_tipo_de_pago.Controls.Add(Me.rb_tarjeta_de_credito)
        Me.gb_tipo_de_pago.Controls.Add(Me.rb_cheque)
        Me.gb_tipo_de_pago.Location = New System.Drawing.Point(12, 208)
        Me.gb_tipo_de_pago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_tipo_de_pago.Name = "gb_tipo_de_pago"
        Me.gb_tipo_de_pago.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_tipo_de_pago.Size = New System.Drawing.Size(694, 65)
        Me.gb_tipo_de_pago.TabIndex = 2
        Me.gb_tipo_de_pago.TabStop = False
        Me.gb_tipo_de_pago.Text = "TIPO DE PAGO REALIZADO:"
        '
        'rb_efectivo
        '
        Me.rb_efectivo.AutoSize = True
        Me.rb_efectivo.Location = New System.Drawing.Point(39, 27)
        Me.rb_efectivo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rb_efectivo.Name = "rb_efectivo"
        Me.rb_efectivo.Size = New System.Drawing.Size(96, 21)
        Me.rb_efectivo.TabIndex = 2
        Me.rb_efectivo.TabStop = True
        Me.rb_efectivo.Text = "EFECTIVO"
        Me.rb_efectivo.UseVisualStyleBackColor = True
        '
        'rb_tarjeta_de_credito
        '
        Me.rb_tarjeta_de_credito.AutoSize = True
        Me.rb_tarjeta_de_credito.Location = New System.Drawing.Point(228, 27)
        Me.rb_tarjeta_de_credito.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rb_tarjeta_de_credito.Name = "rb_tarjeta_de_credito"
        Me.rb_tarjeta_de_credito.Size = New System.Drawing.Size(179, 21)
        Me.rb_tarjeta_de_credito.TabIndex = 1
        Me.rb_tarjeta_de_credito.TabStop = True
        Me.rb_tarjeta_de_credito.Text = "TARJETA DE CREDITO"
        Me.rb_tarjeta_de_credito.UseVisualStyleBackColor = True
        '
        'rb_cheque
        '
        Me.rb_cheque.AutoSize = True
        Me.rb_cheque.Location = New System.Drawing.Point(476, 27)
        Me.rb_cheque.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rb_cheque.Name = "rb_cheque"
        Me.rb_cheque.Size = New System.Drawing.Size(87, 21)
        Me.rb_cheque.TabIndex = 0
        Me.rb_cheque.TabStop = True
        Me.rb_cheque.Text = "CHEQUE"
        Me.rb_cheque.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(51, 332)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "LITROS VENDIDOS:"
        '
        'litros_vendidos
        '
        Me.litros_vendidos.Location = New System.Drawing.Point(261, 335)
        Me.litros_vendidos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.litros_vendidos.Name = "litros_vendidos"
        Me.litros_vendidos.Size = New System.Drawing.Size(138, 22)
        Me.litros_vendidos.TabIndex = 4
        '
        'btn_calcular
        '
        Me.btn_calcular.Font = New System.Drawing.Font("Segoe UI Black", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btn_calcular.Location = New System.Drawing.Point(488, 325)
        Me.btn_calcular.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(240, 35)
        Me.btn_calcular.TabIndex = 5
        Me.btn_calcular.Text = "CALCULAR"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(51, 429)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 32)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "$ DE LA VENTA"
        '
        'lbl_importe
        '
        Me.lbl_importe.AutoSize = True
        Me.lbl_importe.Location = New System.Drawing.Point(240, 438)
        Me.lbl_importe.Name = "lbl_importe"
        Me.lbl_importe.Size = New System.Drawing.Size(120, 17)
        Me.lbl_importe.TabIndex = 7
        Me.lbl_importe.Text = "______________"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(12, 525)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(222, 34)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "S A L I R"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_limpiar.Location = New System.Drawing.Point(479, 525)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(227, 34)
        Me.btn_limpiar.TabIndex = 9
        Me.btn_limpiar.Text = "L I M P I A R"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'gb_totales_pago
        '
        Me.gb_totales_pago.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.gb_totales_pago.Controls.Add(Me.lbl_total_ventas)
        Me.gb_totales_pago.Controls.Add(Me.Label7)
        Me.gb_totales_pago.Controls.Add(Me.lbl_total_cheque)
        Me.gb_totales_pago.Controls.Add(Me.Label10)
        Me.gb_totales_pago.Controls.Add(Me.Label8)
        Me.gb_totales_pago.Controls.Add(Me.lbl_total_efectivo)
        Me.gb_totales_pago.Controls.Add(Me.Label6)
        Me.gb_totales_pago.Location = New System.Drawing.Point(922, 29)
        Me.gb_totales_pago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_totales_pago.Name = "gb_totales_pago"
        Me.gb_totales_pago.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_totales_pago.Size = New System.Drawing.Size(426, 217)
        Me.gb_totales_pago.TabIndex = 10
        Me.gb_totales_pago.TabStop = False
        Me.gb_totales_pago.Text = "TOTALES POR TIPO DE PAGO"
        '
        'lbl_total_ventas
        '
        Me.lbl_total_ventas.AutoSize = True
        Me.lbl_total_ventas.Location = New System.Drawing.Point(277, 187)
        Me.lbl_total_ventas.Name = "lbl_total_ventas"
        Me.lbl_total_ventas.Size = New System.Drawing.Size(128, 17)
        Me.lbl_total_ventas.TabIndex = 6
        Me.lbl_total_ventas.Text = "_______________"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "TOTALES VTAS"
        '
        'lbl_total_cheque
        '
        Me.lbl_total_cheque.AutoSize = True
        Me.lbl_total_cheque.Location = New System.Drawing.Point(277, 143)
        Me.lbl_total_cheque.Name = "lbl_total_cheque"
        Me.lbl_total_cheque.Size = New System.Drawing.Size(128, 17)
        Me.lbl_total_cheque.TabIndex = 4
        Me.lbl_total_cheque.Text = "_______________"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(45, 145)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 17)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "VTAS CHEQUE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "VTAS TARJ CREDITO"
        '
        'lbl_total_efectivo
        '
        Me.lbl_total_efectivo.AutoSize = True
        Me.lbl_total_efectivo.Location = New System.Drawing.Point(277, 41)
        Me.lbl_total_efectivo.Name = "lbl_total_efectivo"
        Me.lbl_total_efectivo.Size = New System.Drawing.Size(128, 17)
        Me.lbl_total_efectivo.TabIndex = 1
        Me.lbl_total_efectivo.Text = "_______________"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "VTAS EN EFECTIVO"
        '
        'gb_totales_combustible
        '
        Me.gb_totales_combustible.BackColor = System.Drawing.SystemColors.Highlight
        Me.gb_totales_combustible.Controls.Add(Me.lbl_total_importe)
        Me.gb_totales_combustible.Controls.Add(Me.lbl_total_litros)
        Me.gb_totales_combustible.Controls.Add(Me.Label18)
        Me.gb_totales_combustible.Controls.Add(Me.lbl_importe_diesel)
        Me.gb_totales_combustible.Controls.Add(Me.lbl_importe_premium)
        Me.gb_totales_combustible.Controls.Add(Me.lbl_importe_magna)
        Me.gb_totales_combustible.Controls.Add(Me.lbl_litros_diesel)
        Me.gb_totales_combustible.Controls.Add(Me.lbl_litros_premium)
        Me.gb_totales_combustible.Controls.Add(Me.lbl_litros_magna)
        Me.gb_totales_combustible.Controls.Add(Me.Label17)
        Me.gb_totales_combustible.Controls.Add(Me.Label16)
        Me.gb_totales_combustible.Controls.Add(Me.Label15)
        Me.gb_totales_combustible.Controls.Add(Me.Label14)
        Me.gb_totales_combustible.Controls.Add(Me.Label13)
        Me.gb_totales_combustible.Controls.Add(Me.Label12)
        Me.gb_totales_combustible.ForeColor = System.Drawing.SystemColors.Desktop
        Me.gb_totales_combustible.Location = New System.Drawing.Point(924, 269)
        Me.gb_totales_combustible.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_totales_combustible.Name = "gb_totales_combustible"
        Me.gb_totales_combustible.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_totales_combustible.Size = New System.Drawing.Size(477, 299)
        Me.gb_totales_combustible.TabIndex = 11
        Me.gb_totales_combustible.TabStop = False
        Me.gb_totales_combustible.Text = "TOTALES POR TIPO DE COMBUSTIBLE"
        '
        'lbl_total_importe
        '
        Me.lbl_total_importe.AutoSize = True
        Me.lbl_total_importe.Location = New System.Drawing.Point(325, 276)
        Me.lbl_total_importe.Name = "lbl_total_importe"
        Me.lbl_total_importe.Size = New System.Drawing.Size(128, 17)
        Me.lbl_total_importe.TabIndex = 14
        Me.lbl_total_importe.Text = "_______________"
        '
        'lbl_total_litros
        '
        Me.lbl_total_litros.AutoSize = True
        Me.lbl_total_litros.Location = New System.Drawing.Point(157, 274)
        Me.lbl_total_litros.Name = "lbl_total_litros"
        Me.lbl_total_litros.Size = New System.Drawing.Size(128, 17)
        Me.lbl_total_litros.TabIndex = 13
        Me.lbl_total_litros.Text = "_______________"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(19, 268)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 17)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "TOTALES"
        '
        'lbl_importe_diesel
        '
        Me.lbl_importe_diesel.AutoSize = True
        Me.lbl_importe_diesel.Location = New System.Drawing.Point(325, 223)
        Me.lbl_importe_diesel.Name = "lbl_importe_diesel"
        Me.lbl_importe_diesel.Size = New System.Drawing.Size(128, 17)
        Me.lbl_importe_diesel.TabIndex = 11
        Me.lbl_importe_diesel.Text = "_______________"
        '
        'lbl_importe_premium
        '
        Me.lbl_importe_premium.AutoSize = True
        Me.lbl_importe_premium.Location = New System.Drawing.Point(325, 160)
        Me.lbl_importe_premium.Name = "lbl_importe_premium"
        Me.lbl_importe_premium.Size = New System.Drawing.Size(128, 17)
        Me.lbl_importe_premium.TabIndex = 10
        Me.lbl_importe_premium.Text = "_______________"
        '
        'lbl_importe_magna
        '
        Me.lbl_importe_magna.AutoSize = True
        Me.lbl_importe_magna.Location = New System.Drawing.Point(325, 100)
        Me.lbl_importe_magna.Name = "lbl_importe_magna"
        Me.lbl_importe_magna.Size = New System.Drawing.Size(128, 17)
        Me.lbl_importe_magna.TabIndex = 9
        Me.lbl_importe_magna.Text = "_______________"
        '
        'lbl_litros_diesel
        '
        Me.lbl_litros_diesel.AutoSize = True
        Me.lbl_litros_diesel.Location = New System.Drawing.Point(157, 223)
        Me.lbl_litros_diesel.Name = "lbl_litros_diesel"
        Me.lbl_litros_diesel.Size = New System.Drawing.Size(128, 17)
        Me.lbl_litros_diesel.TabIndex = 8
        Me.lbl_litros_diesel.Text = "_______________"
        '
        'lbl_litros_premium
        '
        Me.lbl_litros_premium.AutoSize = True
        Me.lbl_litros_premium.Location = New System.Drawing.Point(157, 160)
        Me.lbl_litros_premium.Name = "lbl_litros_premium"
        Me.lbl_litros_premium.Size = New System.Drawing.Size(128, 17)
        Me.lbl_litros_premium.TabIndex = 7
        Me.lbl_litros_premium.Text = "_______________"
        '
        'lbl_litros_magna
        '
        Me.lbl_litros_magna.AutoSize = True
        Me.lbl_litros_magna.Location = New System.Drawing.Point(157, 100)
        Me.lbl_litros_magna.Name = "lbl_litros_magna"
        Me.lbl_litros_magna.Size = New System.Drawing.Size(128, 17)
        Me.lbl_litros_magna.TabIndex = 6
        Me.lbl_litros_magna.Text = "_______________"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(19, 223)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 17)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "DIESEL"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(19, 160)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 17)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "PREMIUM"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(19, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 17)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "MAGNA"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(325, 39)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 23)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "IMPORTE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(173, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 23)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "LITROS"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(19, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 23)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "COMBUSTIBLE"
        '
        'lbl_total_tarjeta
        '
        Me.lbl_total_tarjeta.AutoSize = True
        Me.lbl_total_tarjeta.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lbl_total_tarjeta.Location = New System.Drawing.Point(1199, 121)
        Me.lbl_total_tarjeta.Name = "lbl_total_tarjeta"
        Me.lbl_total_tarjeta.Size = New System.Drawing.Size(128, 17)
        Me.lbl_total_tarjeta.TabIndex = 12
        Me.lbl_total_tarjeta.Text = "_______________"
        '
        'MENU_GASOLINA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1413, 587)
        Me.Controls.Add(Me.lbl_total_tarjeta)
        Me.Controls.Add(Me.gb_totales_combustible)
        Me.Controls.Add(Me.gb_totales_pago)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lbl_importe)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.litros_vendidos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gb_tipo_de_pago)
        Me.Controls.Add(Me.gb_elegir_combustible)
        Me.Controls.Add(Me.gb_precios_litro)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MENU_GASOLINA"
        Me.Text = "Programa de una Gasolineria"
        Me.gb_precios_litro.ResumeLayout(False)
        Me.gb_precios_litro.PerformLayout()
        Me.gb_elegir_combustible.ResumeLayout(False)
        Me.gb_elegir_combustible.PerformLayout()
        Me.gb_tipo_de_pago.ResumeLayout(False)
        Me.gb_tipo_de_pago.PerformLayout()
        Me.gb_totales_pago.ResumeLayout(False)
        Me.gb_totales_pago.PerformLayout()
        Me.gb_totales_combustible.ResumeLayout(False)
        Me.gb_totales_combustible.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gb_precios_litro As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents presio_diesel As TextBox
    Friend WithEvents presio_premium As TextBox
    Friend WithEvents presio_magna As TextBox
    Friend WithEvents gb_elegir_combustible As GroupBox
    Friend WithEvents rd_diesel As RadioButton
    Friend WithEvents rb_premium As RadioButton
    Friend WithEvents rb_magna As RadioButton
    Friend WithEvents gb_tipo_de_pago As GroupBox
    Friend WithEvents rb_efectivo As RadioButton
    Friend WithEvents rb_tarjeta_de_credito As RadioButton
    Friend WithEvents rb_cheque As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents litros_vendidos As TextBox
    Friend WithEvents btn_calcular As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_importe As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents gb_totales_pago As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_total_efectivo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents gb_totales_combustible As GroupBox
    Friend WithEvents lbl_litros_magna As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_total_tarjeta As Label
    Friend WithEvents lbl_importe_diesel As Label
    Friend WithEvents lbl_importe_premium As Label
    Friend WithEvents lbl_importe_magna As Label
    Friend WithEvents lbl_litros_diesel As Label
    Friend WithEvents lbl_litros_premium As Label
    Friend WithEvents rb_diesel As RadioButton

    Friend WithEvents lbl_total_cheque As Label
    Friend WithEvents lbl_total_ventas As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_total_importe As Label
    Friend WithEvents lbl_total_litros As Label
    Friend WithEvents Label18 As Label
End Class
