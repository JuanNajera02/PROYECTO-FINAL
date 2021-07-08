<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_HORAS_EXTRAS
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
        Me.txt_horas_laboradas = New System.Windows.Forms.TextBox()
        Me.txt_pago_por_hora = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.lbl_sueldo_bruto = New System.Windows.Forms.Label()
        Me.lbl_impuestos = New System.Windows.Forms.Label()
        Me.lbl_sueldo_neto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_horas_laboradas
        '
        Me.txt_horas_laboradas.Location = New System.Drawing.Point(427, 37)
        Me.txt_horas_laboradas.Name = "txt_horas_laboradas"
        Me.txt_horas_laboradas.Size = New System.Drawing.Size(100, 22)
        Me.txt_horas_laboradas.TabIndex = 1
        '
        'txt_pago_por_hora
        '
        Me.txt_pago_por_hora.Location = New System.Drawing.Point(427, 91)
        Me.txt_pago_por_hora.Name = "txt_pago_por_hora"
        Me.txt_pago_por_hora.Size = New System.Drawing.Size(100, 22)
        Me.txt_pago_por_hora.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NUMERO DE HORAS LABORADAS EN LA SEMANA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IMPORTE DEL PAGO POR HORA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(256, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "SUELDO BRUTO SEMANAL A PAGAR:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "RETENCION DE IMPUESTOS:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 384)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(246, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "SUELDO NETO SEMANAL A PAGAR:"
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(311, 485)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(143, 38)
        Me.btn_salir.TabIndex = 5
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(58, 485)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(143, 38)
        Me.btn_limpiar.TabIndex = 4
        Me.btn_limpiar.Text = "LIMPIAR"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(198, 177)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(143, 38)
        Me.btn_calcular.TabIndex = 3
        Me.btn_calcular.Text = "CALCULAR"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'lbl_sueldo_bruto
        '
        Me.lbl_sueldo_bruto.AutoSize = True
        Me.lbl_sueldo_bruto.Location = New System.Drawing.Point(374, 269)
        Me.lbl_sueldo_bruto.Name = "lbl_sueldo_bruto"
        Me.lbl_sueldo_bruto.Size = New System.Drawing.Size(80, 17)
        Me.lbl_sueldo_bruto.TabIndex = 1
        Me.lbl_sueldo_bruto.Text = "_________"
        '
        'lbl_impuestos
        '
        Me.lbl_impuestos.AutoSize = True
        Me.lbl_impuestos.Location = New System.Drawing.Point(374, 327)
        Me.lbl_impuestos.Name = "lbl_impuestos"
        Me.lbl_impuestos.Size = New System.Drawing.Size(80, 17)
        Me.lbl_impuestos.TabIndex = 1
        Me.lbl_impuestos.Text = "_________"
        '
        'lbl_sueldo_neto
        '
        Me.lbl_sueldo_neto.AutoSize = True
        Me.lbl_sueldo_neto.Location = New System.Drawing.Point(374, 384)
        Me.lbl_sueldo_neto.Name = "lbl_sueldo_neto"
        Me.lbl_sueldo_neto.Size = New System.Drawing.Size(80, 17)
        Me.lbl_sueldo_neto.TabIndex = 1
        Me.lbl_sueldo_neto.Text = "_________"
        '
        'MENU_HORAS_EXTRAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(573, 568)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.lbl_sueldo_neto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_impuestos)
        Me.Controls.Add(Me.lbl_sueldo_bruto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_pago_por_hora)
        Me.Controls.Add(Me.txt_horas_laboradas)
        Me.Name = "MENU_HORAS_EXTRAS"
        Me.Text = "Registro de Horas Trabajadas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_horas_laboradas As TextBox
    Friend WithEvents txt_pago_por_hora As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_calcular As Button
    Friend WithEvents lbl_sueldo_bruto As Label
    Friend WithEvents lbl_impuestos As Label
    Friend WithEvents lbl_sueldo_neto As Label
End Class
