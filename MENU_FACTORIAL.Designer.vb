<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_FACTORIAL
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
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.txt_factorial = New System.Windows.Forms.TextBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.cmd_calcular = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(251, 54)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(100, 22)
        Me.txt_numero.TabIndex = 1
        '
        'txt_factorial
        '
        Me.txt_factorial.Location = New System.Drawing.Point(251, 223)
        Me.txt_factorial.Name = "txt_factorial"
        Me.txt_factorial.Size = New System.Drawing.Size(223, 22)
        Me.txt_factorial.TabIndex = 5
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(395, 303)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(126, 36)
        Me.btn_salir.TabIndex = 4
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'cmd_calcular
        '
        Me.cmd_calcular.Location = New System.Drawing.Point(322, 143)
        Me.cmd_calcular.Name = "cmd_calcular"
        Me.cmd_calcular.Size = New System.Drawing.Size(118, 26)
        Me.cmd_calcular.TabIndex = 2
        Me.cmd_calcular.Text = "CALCULAR"
        Me.cmd_calcular.UseVisualStyleBackColor = True
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Location = New System.Drawing.Point(117, 143)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(120, 26)
        Me.cmd_limpiar.TabIndex = 3
        Me.cmd_limpiar.Text = "LIMPIAR"
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "INGRESE UN NUMERO :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "EL FACTORIAL ES :"
        '
        'MENU_FACTORIAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 376)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_limpiar)
        Me.Controls.Add(Me.cmd_calcular)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.txt_factorial)
        Me.Controls.Add(Me.txt_numero)
        Me.Name = "MENU_FACTORIAL"
        Me.Text = "Factorial de un Número"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_numero As TextBox
    Friend WithEvents txt_factorial As TextBox
    Friend WithEvents btn_salir As Button
    Friend WithEvents cmd_calcular As Button
    Friend WithEvents cmd_limpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
