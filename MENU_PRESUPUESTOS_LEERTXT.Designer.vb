<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_presupuestos_leertxt
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
        Me.dgv_datos_1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_mostrar_resultados = New System.Windows.Forms.Button()
        Me.dgv_datos_2 = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_datos_3 = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_datos_4 = New System.Windows.Forms.DataGridView()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_total1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_total3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_total4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_total2 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        CType(Me.dgv_datos_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_datos_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_datos_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_datos_4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_datos_1
        '
        Me.dgv_datos_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datos_1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgv_datos_1.Location = New System.Drawing.Point(26, 52)
        Me.dgv_datos_1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_datos_1.Name = "dgv_datos_1"
        Me.dgv_datos_1.RowHeadersWidth = 51
        Me.dgv_datos_1.RowTemplate.Height = 29
        Me.dgv_datos_1.Size = New System.Drawing.Size(421, 201)
        Me.dgv_datos_1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "MUNICIPIO"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "RUBRO"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "IMPORTE"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'btn_mostrar_resultados
        '
        Me.btn_mostrar_resultados.Location = New System.Drawing.Point(473, 305)
        Me.btn_mostrar_resultados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_mostrar_resultados.Name = "btn_mostrar_resultados"
        Me.btn_mostrar_resultados.Size = New System.Drawing.Size(309, 34)
        Me.btn_mostrar_resultados.TabIndex = 2
        Me.btn_mostrar_resultados.Text = "MOSTRAR RESULTADOS"
        Me.btn_mostrar_resultados.UseVisualStyleBackColor = True
        '
        'dgv_datos_2
        '
        Me.dgv_datos_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datos_2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6})
        Me.dgv_datos_2.Location = New System.Drawing.Point(23, 305)
        Me.dgv_datos_2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_datos_2.Name = "dgv_datos_2"
        Me.dgv_datos_2.RowHeadersWidth = 51
        Me.dgv_datos_2.RowTemplate.Height = 29
        Me.dgv_datos_2.Size = New System.Drawing.Size(424, 180)
        Me.dgv_datos_2.TabIndex = 3
        '
        'Column4
        '
        Me.Column4.HeaderText = "MUNICIPIO"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "PORCENTAJE"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "IMPORTE"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'dgv_datos_3
        '
        Me.dgv_datos_3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datos_3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.Column9})
        Me.dgv_datos_3.Location = New System.Drawing.Point(850, 52)
        Me.dgv_datos_3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_datos_3.Name = "dgv_datos_3"
        Me.dgv_datos_3.RowHeadersWidth = 51
        Me.dgv_datos_3.RowTemplate.Height = 29
        Me.dgv_datos_3.Size = New System.Drawing.Size(428, 210)
        Me.dgv_datos_3.TabIndex = 4
        '
        'Column7
        '
        Me.Column7.HeaderText = "MES"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "PORCENTAJE"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Column9
        '
        Me.Column9.HeaderText = "IMPORTE"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 125
        '
        'dgv_datos_4
        '
        Me.dgv_datos_4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datos_4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column11, Me.Column12, Me.Column13})
        Me.dgv_datos_4.Location = New System.Drawing.Point(792, 305)
        Me.dgv_datos_4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_datos_4.Name = "dgv_datos_4"
        Me.dgv_datos_4.RowHeadersWidth = 51
        Me.dgv_datos_4.RowTemplate.Height = 29
        Me.dgv_datos_4.Size = New System.Drawing.Size(551, 247)
        Me.dgv_datos_4.TabIndex = 5
        '
        'Column10
        '
        Me.Column10.HeaderText = "MUNICIPIO"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 125
        '
        'Column11
        '
        Me.Column11.HeaderText = "RUBRO"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 125
        '
        'Column12
        '
        Me.Column12.HeaderText = "MES"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 125
        '
        'Column13
        '
        Me.Column13.HeaderText = "IMPORTE"
        Me.Column13.MinimumWidth = 6
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(517, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CONCENTRADO #1 ""ANUAL DE PRESUPUESTO SINALOA MUNICIPIO-RUBRO"""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(511, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "CONCENTRADO #2 ""ANUAL DE PRESUPUESTO SINALOA 2021 X MUNICIPIO"""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(822, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(490, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CONCENTRADO #4 ""PRESUPUESTO SINALOA MUNICIPIO-RUBRO X MES"""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(850, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(410, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CONCENTRADO # 3 "" PRESUPUESTO SINALOA 2020 X MES """
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(490, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "TOTAL"
        '
        'lbl_total1
        '
        Me.lbl_total1.AutoSize = True
        Me.lbl_total1.Location = New System.Drawing.Point(487, 126)
        Me.lbl_total1.Name = "lbl_total1"
        Me.lbl_total1.Size = New System.Drawing.Size(88, 17)
        Me.lbl_total1.TabIndex = 7
        Me.lbl_total1.Text = "__________"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(716, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "TOTAL"
        '
        'lbl_total3
        '
        Me.lbl_total3.AutoSize = True
        Me.lbl_total3.Location = New System.Drawing.Point(713, 126)
        Me.lbl_total3.Name = "lbl_total3"
        Me.lbl_total3.Size = New System.Drawing.Size(88, 17)
        Me.lbl_total3.TabIndex = 7
        Me.lbl_total3.Text = "__________"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(689, 425)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "TOTAL"
        '
        'lbl_total4
        '
        Me.lbl_total4.AutoSize = True
        Me.lbl_total4.Location = New System.Drawing.Point(680, 462)
        Me.lbl_total4.Name = "lbl_total4"
        Me.lbl_total4.Size = New System.Drawing.Size(88, 17)
        Me.lbl_total4.TabIndex = 7
        Me.lbl_total4.Text = "__________"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(180, 499)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "TOTAL"
        '
        'lbl_total2
        '
        Me.lbl_total2.AutoSize = True
        Me.lbl_total2.Location = New System.Drawing.Point(177, 536)
        Me.lbl_total2.Name = "lbl_total2"
        Me.lbl_total2.Size = New System.Drawing.Size(88, 17)
        Me.lbl_total2.TabIndex = 7
        Me.lbl_total2.Text = "__________"
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(494, 351)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(272, 31)
        Me.btn_salir.TabIndex = 8
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'menu_presupuestos_leertxt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1396, 573)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.lbl_total2)
        Me.Controls.Add(Me.lbl_total4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_total3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_total1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_datos_4)
        Me.Controls.Add(Me.dgv_datos_3)
        Me.Controls.Add(Me.dgv_datos_2)
        Me.Controls.Add(Me.btn_mostrar_resultados)
        Me.Controls.Add(Me.dgv_datos_1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "menu_presupuestos_leertxt"
        Me.Text = "Programa Leer Presupuestos Sinaloa"
        CType(Me.dgv_datos_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_datos_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_datos_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_datos_4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_datos_1 As DataGridView
    Friend WithEvents btn_consulta1 As Button
    Friend WithEvents dgv_datos_2 As DataGridView
    Friend WithEvents dgv_datos_3 As DataGridView
    Friend WithEvents dgv_datos_4 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_total1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_total3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_total4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_total2 As Label
    Friend WithEvents btn_mostrar_resultados As Button
    Friend WithEvents btn_salir As Button
End Class
