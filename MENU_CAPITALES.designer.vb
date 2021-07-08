<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_CAPITALES
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
        Me.txt_numero_entidades = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_siguiente = New System.Windows.Forms.Button()
        Me.btn_empezar = New System.Windows.Forms.Button()
        Me.btn_reiniciar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_estados_adivinar = New System.Windows.Forms.Label()
        Me.lbl_capitales_acertadas = New System.Windows.Forms.Label()
        Me.lbl_capitales_erroneas = New System.Windows.Forms.Label()
        Me.lbl_calificacion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CANTIDAD DE ESTADOS A PREGUNTAR CAPITAL :"
        '
        'txt_numero_entidades
        '
        Me.txt_numero_entidades.Location = New System.Drawing.Point(415, 35)
        Me.txt_numero_entidades.Name = "txt_numero_entidades"
        Me.txt_numero_entidades.Size = New System.Drawing.Size(125, 22)
        Me.txt_numero_entidades.TabIndex = 1
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(27, 215)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(93, 21)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "________"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(184, 215)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(93, 21)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "________"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(346, 215)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(93, 21)
        Me.RadioButton3.TabIndex = 4
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "________"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(515, 215)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(93, 21)
        Me.RadioButton4.TabIndex = 5
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "________"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_estado.Location = New System.Drawing.Point(252, 146)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(110, 24)
        Me.lbl_estado.TabIndex = 3
        Me.lbl_estado.Text = "*ESTADO*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(491, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SELECCIONE LA CAPITAL CORRESPONDIENTE AL ESTADO MOSTRADO :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 182)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 98)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "POSIBLE CAPITAL :"
        '
        'btn_siguiente
        '
        Me.btn_siguiente.Location = New System.Drawing.Point(449, 311)
        Me.btn_siguiente.Name = "btn_siguiente"
        Me.btn_siguiente.Size = New System.Drawing.Size(181, 33)
        Me.btn_siguiente.TabIndex = 6
        Me.btn_siguiente.Text = "SIGUIENTE"
        Me.btn_siguiente.UseVisualStyleBackColor = True
        '
        'btn_empezar
        '
        Me.btn_empezar.Location = New System.Drawing.Point(234, 311)
        Me.btn_empezar.Name = "btn_empezar"
        Me.btn_empezar.Size = New System.Drawing.Size(181, 33)
        Me.btn_empezar.TabIndex = 6
        Me.btn_empezar.Text = "EMEPZAR"
        Me.btn_empezar.UseVisualStyleBackColor = True
        '
        'btn_reiniciar
        '
        Me.btn_reiniciar.Location = New System.Drawing.Point(27, 311)
        Me.btn_reiniciar.Name = "btn_reiniciar"
        Me.btn_reiniciar.Size = New System.Drawing.Size(181, 33)
        Me.btn_reiniciar.TabIndex = 6
        Me.btn_reiniciar.Text = "REINICIAR"
        Me.btn_reiniciar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(234, 372)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(181, 33)
        Me.btn_salir.TabIndex = 6
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(847, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ESTADOS POR ADIVINAR :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(847, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CAPITALES ACERTADAS :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(847, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "CAPITALES ERRONEAS :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(847, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "CALIFICACION :"
        '
        'lbl_estados_adivinar
        '
        Me.lbl_estados_adivinar.AutoSize = True
        Me.lbl_estados_adivinar.Location = New System.Drawing.Point(1085, 60)
        Me.lbl_estados_adivinar.Name = "lbl_estados_adivinar"
        Me.lbl_estados_adivinar.Size = New System.Drawing.Size(72, 17)
        Me.lbl_estados_adivinar.TabIndex = 7
        Me.lbl_estados_adivinar.Text = "________"
        '
        'lbl_capitales_acertadas
        '
        Me.lbl_capitales_acertadas.AutoSize = True
        Me.lbl_capitales_acertadas.Location = New System.Drawing.Point(1085, 110)
        Me.lbl_capitales_acertadas.Name = "lbl_capitales_acertadas"
        Me.lbl_capitales_acertadas.Size = New System.Drawing.Size(72, 17)
        Me.lbl_capitales_acertadas.TabIndex = 7
        Me.lbl_capitales_acertadas.Text = "________"
        '
        'lbl_capitales_erroneas
        '
        Me.lbl_capitales_erroneas.AutoSize = True
        Me.lbl_capitales_erroneas.Location = New System.Drawing.Point(1085, 165)
        Me.lbl_capitales_erroneas.Name = "lbl_capitales_erroneas"
        Me.lbl_capitales_erroneas.Size = New System.Drawing.Size(72, 17)
        Me.lbl_capitales_erroneas.TabIndex = 7
        Me.lbl_capitales_erroneas.Text = "________"
        '
        'lbl_calificacion
        '
        Me.lbl_calificacion.AutoSize = True
        Me.lbl_calificacion.Location = New System.Drawing.Point(1085, 219)
        Me.lbl_calificacion.Name = "lbl_calificacion"
        Me.lbl_calificacion.Size = New System.Drawing.Size(72, 17)
        Me.lbl_calificacion.TabIndex = 7
        Me.lbl_calificacion.Text = "________"
        '
        'MENU_CAPITALES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1211, 440)
        Me.Controls.Add(Me.lbl_calificacion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_capitales_erroneas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_capitales_acertadas)
        Me.Controls.Add(Me.lbl_estados_adivinar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_reiniciar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_empezar)
        Me.Controls.Add(Me.btn_siguiente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_estado)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.txt_numero_entidades)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MENU_CAPITALES"
        Me.Text = "Programa Capitales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_numero_entidades As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents lbl_estado As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_siguiente As Button
    Friend WithEvents btn_empezar As Button
    Friend WithEvents btn_reiniciar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_estados_adivinar As Label
    Friend WithEvents lbl_capitales_acertadas As Label
    Friend WithEvents lbl_capitales_erroneas As Label
    Friend WithEvents lbl_calificacion As Label
End Class
