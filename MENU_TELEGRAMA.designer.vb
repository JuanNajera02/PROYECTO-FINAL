<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_TELEGRAMA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rtb_telegrama = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_palabras_escritas = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_pagar = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_total_pagar = New System.Windows.Forms.Label()
        Me.lbl_total_palabras = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtb_telegrama
        '
        Me.rtb_telegrama.Location = New System.Drawing.Point(297, 42)
        Me.rtb_telegrama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtb_telegrama.Name = "rtb_telegrama"
        Me.rtb_telegrama.Size = New System.Drawing.Size(617, 270)
        Me.rtb_telegrama.TabIndex = 1
        Me.rtb_telegrama.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(524, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TELEGRAMA :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(37, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PALABRAS ESCRITAS  :"
        '
        'lbl_palabras_escritas
        '
        Me.lbl_palabras_escritas.AutoSize = True
        Me.lbl_palabras_escritas.Location = New System.Drawing.Point(329, 354)
        Me.lbl_palabras_escritas.Name = "lbl_palabras_escritas"
        Me.lbl_palabras_escritas.Size = New System.Drawing.Size(104, 17)
        Me.lbl_palabras_escritas.TabIndex = 4
        Me.lbl_palabras_escritas.Text = "____________"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(37, 416)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 28)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TOTAL A PAGAR  :"
        '
        'lbl_pagar
        '
        Me.lbl_pagar.AutoSize = True
        Me.lbl_pagar.Location = New System.Drawing.Point(329, 422)
        Me.lbl_pagar.Name = "lbl_pagar"
        Me.lbl_pagar.Size = New System.Drawing.Size(104, 17)
        Me.lbl_pagar.TabIndex = 6
        Me.lbl_pagar.Text = "____________"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lbl_total_pagar)
        Me.GroupBox1.Controls.Add(Me.lbl_total_palabras)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(556, 330)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(615, 132)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ACUMULADOS"
        '
        'lbl_total_pagar
        '
        Me.lbl_total_pagar.AutoSize = True
        Me.lbl_total_pagar.Location = New System.Drawing.Point(409, 85)
        Me.lbl_total_pagar.Name = "lbl_total_pagar"
        Me.lbl_total_pagar.Size = New System.Drawing.Size(108, 28)
        Me.lbl_total_pagar.TabIndex = 8
        Me.lbl_total_pagar.Text = "____________"
        '
        'lbl_total_palabras
        '
        Me.lbl_total_palabras.AutoSize = True
        Me.lbl_total_palabras.Location = New System.Drawing.Point(409, 34)
        Me.lbl_total_palabras.Name = "lbl_total_palabras"
        Me.lbl_total_palabras.Size = New System.Drawing.Size(108, 28)
        Me.lbl_total_palabras.TabIndex = 7
        Me.lbl_total_palabras.Text = "____________"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(6, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 28)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "TOTAL A PAGAR  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(6, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(322, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "TOTAL DE PALABRAS ESCRITAS  :"
        '
        'btn_calcular
        '
        Me.btn_calcular.Location = New System.Drawing.Point(935, 278)
        Me.btn_calcular.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(157, 32)
        Me.btn_calcular.TabIndex = 8
        Me.btn_calcular.Text = "C A L C U L A R"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(1175, 479)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(157, 32)
        Me.btn_salir.TabIndex = 9
        Me.btn_salir.Text = "S A L I R"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(1176, 278)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(156, 34)
        Me.btn_limpiar.TabIndex = 10
        Me.btn_limpiar.Text = "L I M P I A R"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'MENU_TELEGRAMA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 521)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_pagar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_palabras_escritas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtb_telegrama)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MENU_TELEGRAMA"
        Me.Text = "Programa Telegrama"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtb_telegrama As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_palabras_escritas As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_pagar As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_total_pagar As Label
    Friend WithEvents lbl_total_palabras As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_calcular As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_limpiar As Button
End Class
