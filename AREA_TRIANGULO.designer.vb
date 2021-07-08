<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AREA_TRIANGULO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AREA_TRIANGULO))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_base = New System.Windows.Forms.TextBox()
        Me.txt_altura = New System.Windows.Forms.TextBox()
        Me.lbl_area = New System.Windows.Forms.Label()
        Me.boton_calcular = New System.Windows.Forms.Button()
        Me.boton_salir = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(207, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CAPTURA BASE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(170, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CAPTURA ALTURA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(126, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(343, 38)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "AREA DEL TRIANGULO ="
        '
        'txt_base
        '
        Me.txt_base.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.txt_base.Location = New System.Drawing.Point(521, 50)
        Me.txt_base.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_base.Name = "txt_base"
        Me.txt_base.Size = New System.Drawing.Size(125, 38)
        Me.txt_base.TabIndex = 3
        '
        'txt_altura
        '
        Me.txt_altura.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.txt_altura.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_altura.Location = New System.Drawing.Point(521, 113)
        Me.txt_altura.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_altura.Name = "txt_altura"
        Me.txt_altura.Size = New System.Drawing.Size(125, 38)
        Me.txt_altura.TabIndex = 4
        '
        'lbl_area
        '
        Me.lbl_area.AutoSize = True
        Me.lbl_area.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.lbl_area.Location = New System.Drawing.Point(528, 318)
        Me.lbl_area.Name = "lbl_area"
        Me.lbl_area.Size = New System.Drawing.Size(135, 32)
        Me.lbl_area.TabIndex = 5
        Me.lbl_area.Text = "____________"
        '
        'boton_calcular
        '
        Me.boton_calcular.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.boton_calcular.Location = New System.Drawing.Point(485, 210)
        Me.boton_calcular.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.boton_calcular.Name = "boton_calcular"
        Me.boton_calcular.Size = New System.Drawing.Size(207, 36)
        Me.boton_calcular.TabIndex = 6
        Me.boton_calcular.Text = "CALCULAR AREA"
        Me.boton_calcular.UseVisualStyleBackColor = False
        '
        'boton_salir
        '
        Me.boton_salir.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.boton_salir.Location = New System.Drawing.Point(954, 381)
        Me.boton_salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(116, 40)
        Me.boton_salir.TabIndex = 7
        Me.boton_salir.Text = "S A L I R"
        Me.boton_salir.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button2.Location = New System.Drawing.Point(260, 204)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 42)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(789, 50)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(308, 268)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'AREA_TRIANGULO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 500)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.boton_salir)
        Me.Controls.Add(Me.boton_calcular)
        Me.Controls.Add(Me.lbl_area)
        Me.Controls.Add(Me.txt_altura)
        Me.Controls.Add(Me.txt_base)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AREA_TRIANGULO"
        Me.Text = "Calculo Area de Triangulo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_base As TextBox
    Friend WithEvents txt_altura As TextBox
    Friend WithEvents lbl_area As Label
    Friend WithEvents boton_calcular As Button
    Friend WithEvents boton_salir As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
