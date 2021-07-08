<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_TRANSFERENCIAS
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
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_clabe_banco = New System.Windows.Forms.TextBox()
        Me.txt_importe = New System.Windows.Forms.TextBox()
        Me.cb_banco_emisor = New System.Windows.Forms.ComboBox()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_total_transferencias = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_total_transferido = New System.Windows.Forms.Label()
        Me.dgv_barrido_banco = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        CType(Me.dgv_barrido_banco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(27, 42)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(508, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(623, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(366, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CLABE INTERBANCARIA DONDE SE DEPOSITARA EL $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1048, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "IMPORTE"
        '
        'txt_clabe_banco
        '
        Me.txt_clabe_banco.Location = New System.Drawing.Point(697, 42)
        Me.txt_clabe_banco.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_clabe_banco.Name = "txt_clabe_banco"
        Me.txt_clabe_banco.Size = New System.Drawing.Size(208, 22)
        Me.txt_clabe_banco.TabIndex = 2
        '
        'txt_importe
        '
        Me.txt_importe.Location = New System.Drawing.Point(1011, 41)
        Me.txt_importe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_importe.Name = "txt_importe"
        Me.txt_importe.Size = New System.Drawing.Size(139, 22)
        Me.txt_importe.TabIndex = 2
        '
        'cb_banco_emisor
        '
        Me.cb_banco_emisor.FormattingEnabled = True
        Me.cb_banco_emisor.Items.AddRange(New Object() {"BANAMEX", "BANCA SERFIN, S.A.", "BANCOMER, S.A.", "SANTANDER MEXICANO, S.A.", "BANCO NACIONAL DEL EJERCITO Y FUERZA AEREA Y ARMADA, S.N.C.", "BANCO DEL BAJIO, S.A.", "BANCO INBURSA, S.A.", "SCOTIABANK, S.A.", "HSBC", "AZTECA"})
        Me.cb_banco_emisor.Location = New System.Drawing.Point(430, 41)
        Me.cb_banco_emisor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cb_banco_emisor.Name = "cb_banco_emisor"
        Me.cb_banco_emisor.Size = New System.Drawing.Size(151, 24)
        Me.cb_banco_emisor.TabIndex = 3
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(27, 42)
        Me.MonthCalendar2.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(445, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "BANCO EMISOR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "FECHA"
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(1071, 126)
        Me.btn_calcular.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(195, 33)
        Me.btn_calcular.TabIndex = 4
        Me.btn_calcular.Text = "CALCULAR"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(430, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(386, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TOTAL DE TRANSFERENCIAS BANCARIAS REALIZADAS  :"
        '
        'lbl_total_transferencias
        '
        Me.lbl_total_transferencias.AutoSize = True
        Me.lbl_total_transferencias.Location = New System.Drawing.Point(898, 100)
        Me.lbl_total_transferencias.Name = "lbl_total_transferencias"
        Me.lbl_total_transferencias.Size = New System.Drawing.Size(88, 17)
        Me.lbl_total_transferencias.TabIndex = 5
        Me.lbl_total_transferencias.Text = "__________"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(430, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(203, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "TOTAL DE $ TRANSFERIDO  :"
        '
        'lbl_total_transferido
        '
        Me.lbl_total_transferido.AutoSize = True
        Me.lbl_total_transferido.Location = New System.Drawing.Point(898, 143)
        Me.lbl_total_transferido.Name = "lbl_total_transferido"
        Me.lbl_total_transferido.Size = New System.Drawing.Size(88, 17)
        Me.lbl_total_transferido.TabIndex = 5
        Me.lbl_total_transferido.Text = "__________"
        '
        'dgv_barrido_banco
        '
        Me.dgv_barrido_banco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_barrido_banco.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgv_barrido_banco.Location = New System.Drawing.Point(430, 214)
        Me.dgv_barrido_banco.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_barrido_banco.Name = "dgv_barrido_banco"
        Me.dgv_barrido_banco.RowHeadersWidth = 51
        Me.dgv_barrido_banco.RowTemplate.Height = 29
        Me.dgv_barrido_banco.Size = New System.Drawing.Size(750, 258)
        Me.dgv_barrido_banco.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "BANCO AUTORIZADO"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "TOTAL $$ ENVIADO POR C/U BANCOS AUTORIZADOS"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 250
        '
        'Column3
        '
        Me.Column3.HeaderText = "TOTAL $$ RECIBIDO EN C/U BANCOS AUTORIZADOS "
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 250
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(1071, 164)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(195, 33)
        Me.btn_limpiar.TabIndex = 4
        Me.btn_limpiar.Text = "LIMPIAR"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(27, 460)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(195, 33)
        Me.btn_salir.TabIndex = 4
        Me.btn_salir.Text = "S A L I R"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'MENU_TRANSFERENCIAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1308, 514)
        Me.Controls.Add(Me.dgv_barrido_banco)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_total_transferido)
        Me.Controls.Add(Me.lbl_total_transferencias)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.cb_banco_emisor)
        Me.Controls.Add(Me.txt_importe)
        Me.Controls.Add(Me.txt_clabe_banco)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MonthCalendar2)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MENU_TRANSFERENCIAS"
        Me.Text = "Programa Transferencias"
        CType(Me.dgv_barrido_banco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_clabe_banco As TextBox
    Friend WithEvents txt_importe As TextBox
    Friend WithEvents cb_banco_emisor As ComboBox
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_calcular As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_total_transferencias As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_total_transferido As Label
    Friend WithEvents dgv_barrido_banco As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_salir As Button
End Class
