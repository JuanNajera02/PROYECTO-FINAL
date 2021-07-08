<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MENU_MNM2NUMEROS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.txt_numero1 = New System.Windows.Forms.TextBox()
        Me.txt_numero2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_calcular_mcd = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.txt_mnm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_mcd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_numero1
        '
        Me.txt_numero1.Location = New System.Drawing.Point(199, 34)
        Me.txt_numero1.Name = "txt_numero1"
        Me.txt_numero1.Size = New System.Drawing.Size(100, 22)
        Me.txt_numero1.TabIndex = 1
        '
        'txt_numero2
        '
        Me.txt_numero2.Location = New System.Drawing.Point(199, 80)
        Me.txt_numero2.Name = "txt_numero2"
        Me.txt_numero2.Size = New System.Drawing.Size(100, 22)
        Me.txt_numero2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NUMERO 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NUMERO 2"
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(31, 154)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(99, 30)
        Me.btn_limpiar.TabIndex = 5
        Me.btn_limpiar.Text = "LIMPIAR"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_calcular_mcd
        '
        Me.btn_calcular_mcd.Location = New System.Drawing.Point(182, 154)
        Me.btn_calcular_mcd.Name = "btn_calcular_mcd"
        Me.btn_calcular_mcd.Size = New System.Drawing.Size(216, 30)
        Me.btn_calcular_mcd.TabIndex = 3
        Me.btn_calcular_mcd.Text = "CALCULAR MCD y MCM"
        Me.btn_calcular_mcd.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(364, 304)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(113, 33)
        Me.btn_salir.TabIndex = 6
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'txt_mnm
        '
        Me.txt_mnm.Location = New System.Drawing.Point(214, 231)
        Me.txt_mnm.Name = "txt_mnm"
        Me.txt_mnm.Size = New System.Drawing.Size(157, 22)
        Me.txt_mnm.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "MCM NUMERO 1 Y 2"
        '
        'txt_mcd
        '
        Me.txt_mcd.Location = New System.Drawing.Point(214, 273)
        Me.txt_mcd.Name = "txt_mcd"
        Me.txt_mcd.Size = New System.Drawing.Size(157, 22)
        Me.txt_mcd.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "MCD NUMERO 1 Y 2"
        '
        'MENU_MNM2NUMEROS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(497, 359)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_calcular_mcd)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_mcd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_mnm)
        Me.Controls.Add(Me.txt_numero2)
        Me.Controls.Add(Me.txt_numero1)
        Me.Name = "MENU_MNM2NUMEROS"
        Me.Text = "Programa MCM y MCD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_numero1 As TextBox
    Friend WithEvents txt_numero2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_calcular_mcd As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents txt_mnm As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_mcd As TextBox
    Friend WithEvents Label4 As Label
End Class
