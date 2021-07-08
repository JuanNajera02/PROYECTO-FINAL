<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_CHEQUE
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
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.dgv_barrido_datos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_rfc = New System.Windows.Forms.TextBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_cheque = New System.Windows.Forms.Button()
        Me.CHEQUE = New System.Windows.Forms.GroupBox()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_cantidad_total = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_cantidad_letra = New System.Windows.Forms.Label()
        Me.lbl_nombre_cheque = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgv_barrido_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CHEQUE.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(1116, 510)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(176, 38)
        Me.btn_salir.TabIndex = 16
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'dgv_barrido_datos
        '
        Me.dgv_barrido_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_barrido_datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column8, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgv_barrido_datos.Location = New System.Drawing.Point(55, 82)
        Me.dgv_barrido_datos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_barrido_datos.Name = "dgv_barrido_datos"
        Me.dgv_barrido_datos.RowHeadersWidth = 51
        Me.dgv_barrido_datos.RowTemplate.Height = 29
        Me.dgv_barrido_datos.Size = New System.Drawing.Size(1055, 230)
        Me.dgv_barrido_datos.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "FECHA"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "NOMBRE"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "KILOS ENTREGADOS"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "KILOS DESCONTADOS"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "KILOS PAGADOS"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "IMPORTE SUB TOTAL"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "IMPORTE IMPUESTOS"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "IMPORTE NETO A PAGAR"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(1116, 82)
        Me.btn_calcular.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(159, 36)
        Me.btn_calcular.TabIndex = 14
        Me.btn_calcular.Text = "CALCULAR"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "RFC A GENERAR CHEQUE  :"
        '
        'txt_rfc
        '
        Me.txt_rfc.Location = New System.Drawing.Point(271, 34)
        Me.txt_rfc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_rfc.Name = "txt_rfc"
        Me.txt_rfc.Size = New System.Drawing.Size(307, 22)
        Me.txt_rfc.TabIndex = 12
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(1116, 278)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(159, 34)
        Me.btn_limpiar.TabIndex = 17
        Me.btn_limpiar.Text = "LIMPIAR"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_cheque
        '
        Me.btn_cheque.Location = New System.Drawing.Point(318, 335)
        Me.btn_cheque.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_cheque.Name = "btn_cheque"
        Me.btn_cheque.Size = New System.Drawing.Size(504, 33)
        Me.btn_cheque.TabIndex = 18
        Me.btn_cheque.Text = "GENERAR CHEQUE"
        Me.btn_cheque.UseVisualStyleBackColor = True
        '
        'CHEQUE
        '
        Me.CHEQUE.BackColor = System.Drawing.Color.Olive
        Me.CHEQUE.Controls.Add(Me.lbl_fecha)
        Me.CHEQUE.Controls.Add(Me.Label4)
        Me.CHEQUE.Controls.Add(Me.lbl_cantidad_total)
        Me.CHEQUE.Controls.Add(Me.Label6)
        Me.CHEQUE.Controls.Add(Me.lbl_cantidad_letra)
        Me.CHEQUE.Controls.Add(Me.lbl_nombre_cheque)
        Me.CHEQUE.Controls.Add(Me.Label8)
        Me.CHEQUE.Controls.Add(Me.Label2)
        Me.CHEQUE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CHEQUE.Location = New System.Drawing.Point(188, 382)
        Me.CHEQUE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CHEQUE.Name = "CHEQUE"
        Me.CHEQUE.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CHEQUE.Size = New System.Drawing.Size(790, 181)
        Me.CHEQUE.TabIndex = 19
        Me.CHEQUE.TabStop = False
        Me.CHEQUE.Text = "CHEQUE"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(653, 18)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(80, 17)
        Me.lbl_fecha.TabIndex = 0
        Me.lbl_fecha.Text = "_________"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(515, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "FECHA  :"
        '
        'lbl_cantidad_total
        '
        Me.lbl_cantidad_total.AutoSize = True
        Me.lbl_cantidad_total.Location = New System.Drawing.Point(602, 56)
        Me.lbl_cantidad_total.Name = "lbl_cantidad_total"
        Me.lbl_cantidad_total.Size = New System.Drawing.Size(80, 17)
        Me.lbl_cantidad_total.TabIndex = 0
        Me.lbl_cantidad_total.Text = "_________"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(477, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "CANTIDAD  :"
        '
        'lbl_cantidad_letra
        '
        Me.lbl_cantidad_letra.AutoSize = True
        Me.lbl_cantidad_letra.Location = New System.Drawing.Point(209, 105)
        Me.lbl_cantidad_letra.Name = "lbl_cantidad_letra"
        Me.lbl_cantidad_letra.Size = New System.Drawing.Size(376, 17)
        Me.lbl_cantidad_letra.TabIndex = 0
        Me.lbl_cantidad_letra.Text = "______________________________________________"
        '
        'lbl_nombre_cheque
        '
        Me.lbl_nombre_cheque.AutoSize = True
        Me.lbl_nombre_cheque.Location = New System.Drawing.Point(164, 56)
        Me.lbl_nombre_cheque.Name = "lbl_nombre_cheque"
        Me.lbl_nombre_cheque.Size = New System.Drawing.Size(376, 17)
        Me.lbl_nombre_cheque.TabIndex = 0
        Me.lbl_nombre_cheque.Text = "______________________________________________"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "CANTIDAD EN LETRA  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "BENEFECIARIO  :"
        '
        'MENU_CHEQUE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1397, 572)
        Me.Controls.Add(Me.CHEQUE)
        Me.Controls.Add(Me.btn_cheque)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.dgv_barrido_datos)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_rfc)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MENU_CHEQUE"
        Me.Text = "Generar Cheque"
        CType(Me.dgv_barrido_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CHEQUE.ResumeLayout(False)
        Me.CHEQUE.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_salir As Button
    Friend WithEvents dgv_barrido_datos As DataGridView
    Friend WithEvents btn_calcular As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_rfc As TextBox
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents btn_cheque As Button
    Friend WithEvents CHEQUE As GroupBox
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_cantidad_total As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_cantidad_letra As Label
    Friend WithEvents lbl_nombre_cheque As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
End Class
