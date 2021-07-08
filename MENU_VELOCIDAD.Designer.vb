<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_VELOCIDAD
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
        Me.txt_distancia = New System.Windows.Forms.TextBox()
        Me.txt_tiempo = New System.Windows.Forms.TextBox()
        Me.txt_velocidad_promedio = New System.Windows.Forms.TextBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_distancia
        '
        Me.txt_distancia.Location = New System.Drawing.Point(374, 40)
        Me.txt_distancia.Name = "txt_distancia"
        Me.txt_distancia.Size = New System.Drawing.Size(100, 22)
        Me.txt_distancia.TabIndex = 1
        '
        'txt_tiempo
        '
        Me.txt_tiempo.Location = New System.Drawing.Point(374, 104)
        Me.txt_tiempo.Name = "txt_tiempo"
        Me.txt_tiempo.Size = New System.Drawing.Size(100, 22)
        Me.txt_tiempo.TabIndex = 2
        '
        'txt_velocidad_promedio
        '
        Me.txt_velocidad_promedio.Location = New System.Drawing.Point(374, 250)
        Me.txt_velocidad_promedio.Name = "txt_velocidad_promedio"
        Me.txt_velocidad_promedio.Size = New System.Drawing.Size(100, 22)
        Me.txt_velocidad_promedio.TabIndex = 6
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(533, 336)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(129, 35)
        Me.btn_salir.TabIndex = 5
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(299, 336)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(129, 35)
        Me.btn_calcular.TabIndex = 3
        Me.btn_calcular.Text = "CALCULAR"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(51, 336)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(129, 35)
        Me.btn_limpiar.TabIndex = 4
        Me.btn_limpiar.Text = "LIMPIAR"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DISTANCIA RECORRIDA EN METROS:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(333, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "INTERVALO DE TIEMPO MEDIDO EN SEGUNDOS:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "VELOCIDAD PROMEDIO:"
        '
        'MENU_VELOCIDAD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(693, 426)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.txt_velocidad_promedio)
        Me.Controls.Add(Me.txt_tiempo)
        Me.Controls.Add(Me.txt_distancia)
        Me.Name = "MENU_VELOCIDAD"
        Me.Text = "Velociad Promedio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_distancia As TextBox
    Friend WithEvents txt_tiempo As TextBox
    Friend WithEvents txt_velocidad_promedio As TextBox
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_calcular As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
