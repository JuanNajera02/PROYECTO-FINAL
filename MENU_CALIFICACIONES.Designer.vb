<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_CALIFICACIONES
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
        Me.txt_calificacion1 = New System.Windows.Forms.TextBox()
        Me.txt_calificacion2 = New System.Windows.Forms.TextBox()
        Me.txt_calificacion3 = New System.Windows.Forms.TextBox()
        Me.txt_promedio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_calificacion1
        '
        Me.txt_calificacion1.Location = New System.Drawing.Point(246, 32)
        Me.txt_calificacion1.Name = "txt_calificacion1"
        Me.txt_calificacion1.Size = New System.Drawing.Size(100, 22)
        Me.txt_calificacion1.TabIndex = 1
        '
        'txt_calificacion2
        '
        Me.txt_calificacion2.Location = New System.Drawing.Point(246, 92)
        Me.txt_calificacion2.Name = "txt_calificacion2"
        Me.txt_calificacion2.Size = New System.Drawing.Size(100, 22)
        Me.txt_calificacion2.TabIndex = 2
        '
        'txt_calificacion3
        '
        Me.txt_calificacion3.Location = New System.Drawing.Point(246, 152)
        Me.txt_calificacion3.Name = "txt_calificacion3"
        Me.txt_calificacion3.Size = New System.Drawing.Size(100, 22)
        Me.txt_calificacion3.TabIndex = 3
        '
        'txt_promedio
        '
        Me.txt_promedio.Location = New System.Drawing.Point(246, 233)
        Me.txt_promedio.Name = "txt_promedio"
        Me.txt_promedio.Size = New System.Drawing.Size(100, 22)
        Me.txt_promedio.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CALIFICACION 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CALIFICACION 2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "CALIFICACION 3:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(102, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "PROMEDIO:"
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(268, 408)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(159, 39)
        Me.btn_salir.TabIndex = 6
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(268, 335)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(159, 39)
        Me.btn_calcular.TabIndex = 4
        Me.btn_calcular.Text = "CALCULAR"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(29, 335)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(159, 39)
        Me.btn_limpiar.TabIndex = 5
        Me.btn_limpiar.Text = "LIMPIAR"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'MENU_CALIFICACIONES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(483, 489)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_promedio)
        Me.Controls.Add(Me.txt_calificacion3)
        Me.Controls.Add(Me.txt_calificacion2)
        Me.Controls.Add(Me.txt_calificacion1)
        Me.Name = "MENU_CALIFICACIONES"
        Me.Text = "Promedio 3 Calificaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_calificacion1 As TextBox
    Friend WithEvents txt_calificacion2 As TextBox
    Friend WithEvents txt_calificacion3 As TextBox
    Friend WithEvents txt_promedio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_calcular As Button
    Friend WithEvents btn_limpiar As Button
End Class
