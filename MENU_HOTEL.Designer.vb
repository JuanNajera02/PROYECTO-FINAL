<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_HOTEL
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_resultados = New System.Windows.Forms.Button()
        Me.txt_importe = New System.Windows.Forms.TextBox()
        Me.cb_piso = New System.Windows.Forms.ComboBox()
        Me.cb_habitacion = New System.Windows.Forms.ComboBox()
        Me.dgv_1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_2 = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_suma_total = New System.Windows.Forms.Label()
        Me.lbl_promedioxhora = New System.Windows.Forms.Label()
        Me.lbl_hab_mas_cara = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_hab_mas_barata = New System.Windows.Forms.Label()
        Me.lbl_piso_mas_caro = New System.Windows.Forms.Label()
        Me.lbl_nota = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.dgv_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOTA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "# PISO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "# HABITACION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "IMPORTE"
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(28, 343)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(122, 36)
        Me.btn_limpiar.TabIndex = 1
        Me.btn_limpiar.Text = "LIMPIAR"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_registrar
        '
        Me.btn_registrar.Location = New System.Drawing.Point(235, 343)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(122, 36)
        Me.btn_registrar.TabIndex = 1
        Me.btn_registrar.Text = "REGISTRAR"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(1102, 475)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(122, 36)
        Me.btn_salir.TabIndex = 1
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_resultados
        '
        Me.btn_resultados.Location = New System.Drawing.Point(784, 12)
        Me.btn_resultados.Name = "btn_resultados"
        Me.btn_resultados.Size = New System.Drawing.Size(122, 36)
        Me.btn_resultados.TabIndex = 1
        Me.btn_resultados.Text = "RESULTADOS"
        Me.btn_resultados.UseVisualStyleBackColor = True
        '
        'txt_importe
        '
        Me.txt_importe.Location = New System.Drawing.Point(186, 242)
        Me.txt_importe.Name = "txt_importe"
        Me.txt_importe.Size = New System.Drawing.Size(100, 22)
        Me.txt_importe.TabIndex = 2
        '
        'cb_piso
        '
        Me.cb_piso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_piso.FormattingEnabled = True
        Me.cb_piso.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.cb_piso.Location = New System.Drawing.Point(186, 113)
        Me.cb_piso.Name = "cb_piso"
        Me.cb_piso.Size = New System.Drawing.Size(100, 24)
        Me.cb_piso.TabIndex = 3
        '
        'cb_habitacion
        '
        Me.cb_habitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_habitacion.FormattingEnabled = True
        Me.cb_habitacion.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cb_habitacion.Location = New System.Drawing.Point(186, 180)
        Me.cb_habitacion.Name = "cb_habitacion"
        Me.cb_habitacion.Size = New System.Drawing.Size(100, 24)
        Me.cb_habitacion.TabIndex = 3
        '
        'dgv_1
        '
        Me.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgv_1.Location = New System.Drawing.Point(450, 75)
        Me.dgv_1.Name = "dgv_1"
        Me.dgv_1.RowHeadersWidth = 51
        Me.dgv_1.RowTemplate.Height = 24
        Me.dgv_1.Size = New System.Drawing.Size(344, 228)
        Me.dgv_1.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "PISO"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "HABITACION"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 50
        '
        'Column3
        '
        Me.Column3.HeaderText = "IMPORTE"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'dgv_2
        '
        Me.dgv_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5})
        Me.dgv_2.Location = New System.Drawing.Point(907, 75)
        Me.dgv_2.Name = "dgv_2"
        Me.dgv_2.RowHeadersWidth = 51
        Me.dgv_2.RowTemplate.Height = 24
        Me.dgv_2.Size = New System.Drawing.Size(285, 228)
        Me.dgv_2.TabIndex = 4
        '
        'Column4
        '
        Me.Column4.HeaderText = "PISO"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 50
        '
        'Column5
        '
        Me.Column5.HeaderText = "IMPORTE"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(493, 353)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "SUMA TOTAL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(496, 394)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "PROMEDIO X PISO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(496, 442)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "COSTO HAB. MAS CARA"
        '
        'lbl_suma_total
        '
        Me.lbl_suma_total.AutoSize = True
        Me.lbl_suma_total.Location = New System.Drawing.Point(714, 353)
        Me.lbl_suma_total.Name = "lbl_suma_total"
        Me.lbl_suma_total.Size = New System.Drawing.Size(80, 17)
        Me.lbl_suma_total.TabIndex = 5
        Me.lbl_suma_total.Text = "_________"
        '
        'lbl_promedioxhora
        '
        Me.lbl_promedioxhora.AutoSize = True
        Me.lbl_promedioxhora.Location = New System.Drawing.Point(714, 394)
        Me.lbl_promedioxhora.Name = "lbl_promedioxhora"
        Me.lbl_promedioxhora.Size = New System.Drawing.Size(80, 17)
        Me.lbl_promedioxhora.TabIndex = 5
        Me.lbl_promedioxhora.Text = "_________"
        '
        'lbl_hab_mas_cara
        '
        Me.lbl_hab_mas_cara.AutoSize = True
        Me.lbl_hab_mas_cara.Location = New System.Drawing.Point(714, 442)
        Me.lbl_hab_mas_cara.Name = "lbl_hab_mas_cara"
        Me.lbl_hab_mas_cara.Size = New System.Drawing.Size(80, 17)
        Me.lbl_hab_mas_cara.TabIndex = 5
        Me.lbl_hab_mas_cara.Text = "_________"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(884, 353)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(185, 17)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "COSTO HAB. MAS BARATA"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(884, 394)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(200, 17)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "COSTO DEL PISO MAS CARO"
        '
        'lbl_hab_mas_barata
        '
        Me.lbl_hab_mas_barata.AutoSize = True
        Me.lbl_hab_mas_barata.Location = New System.Drawing.Point(1112, 353)
        Me.lbl_hab_mas_barata.Name = "lbl_hab_mas_barata"
        Me.lbl_hab_mas_barata.Size = New System.Drawing.Size(80, 17)
        Me.lbl_hab_mas_barata.TabIndex = 5
        Me.lbl_hab_mas_barata.Text = "_________"
        '
        'lbl_piso_mas_caro
        '
        Me.lbl_piso_mas_caro.AutoSize = True
        Me.lbl_piso_mas_caro.Location = New System.Drawing.Point(1112, 394)
        Me.lbl_piso_mas_caro.Name = "lbl_piso_mas_caro"
        Me.lbl_piso_mas_caro.Size = New System.Drawing.Size(80, 17)
        Me.lbl_piso_mas_caro.TabIndex = 5
        Me.lbl_piso_mas_caro.Text = "_________"
        '
        'lbl_nota
        '
        Me.lbl_nota.AutoSize = True
        Me.lbl_nota.Location = New System.Drawing.Point(232, 52)
        Me.lbl_nota.Name = "lbl_nota"
        Me.lbl_nota.Size = New System.Drawing.Size(16, 17)
        Me.lbl_nota.TabIndex = 5
        Me.lbl_nota.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(199, 52)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(16, 17)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "#"
        '
        'MENU_HOTEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1275, 548)
        Me.Controls.Add(Me.lbl_hab_mas_cara)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_piso_mas_caro)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbl_hab_mas_barata)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbl_promedioxhora)
        Me.Controls.Add(Me.lbl_suma_total)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lbl_nota)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgv_2)
        Me.Controls.Add(Me.dgv_1)
        Me.Controls.Add(Me.cb_habitacion)
        Me.Controls.Add(Me.cb_piso)
        Me.Controls.Add(Me.txt_importe)
        Me.Controls.Add(Me.btn_resultados)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MENU_HOTEL"
        Me.Text = "Pisos y Habitaciones de Hotel"
        CType(Me.dgv_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_registrar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_resultados As Button
    Friend WithEvents txt_importe As TextBox
    Friend WithEvents cb_piso As ComboBox
    Friend WithEvents cb_habitacion As ComboBox
    Friend WithEvents dgv_1 As DataGridView
    Friend WithEvents dgv_2 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_suma_total As Label
    Friend WithEvents lbl_promedioxhora As Label
    Friend WithEvents lbl_hab_mas_cara As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_hab_mas_barata As Label
    Friend WithEvents lbl_piso_mas_caro As Label
    Friend WithEvents lbl_nota As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
