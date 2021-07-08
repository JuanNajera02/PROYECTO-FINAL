<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_MENU_CARWASH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FORM_MENU_CARWASH))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatalogoDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogosDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalagosDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaDeServicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogoDeClientesToolStripMenuItem, Me.ServiciosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(725, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatalogoDeClientesToolStripMenuItem
        '
        Me.CatalogoDeClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogosDeClientesToolStripMenuItem, Me.CatalagosDeEmpleadosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.CatalogoDeClientesToolStripMenuItem.Name = "CatalogoDeClientesToolStripMenuItem"
        Me.CatalogoDeClientesToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.CatalogoDeClientesToolStripMenuItem.Text = "Catalogos"
        '
        'CatalogosDeClientesToolStripMenuItem
        '
        Me.CatalogosDeClientesToolStripMenuItem.Name = "CatalogosDeClientesToolStripMenuItem"
        Me.CatalogosDeClientesToolStripMenuItem.Size = New System.Drawing.Size(257, 26)
        Me.CatalogosDeClientesToolStripMenuItem.Text = "Catalogos de Clientes"
        '
        'CatalagosDeEmpleadosToolStripMenuItem
        '
        Me.CatalagosDeEmpleadosToolStripMenuItem.Name = "CatalagosDeEmpleadosToolStripMenuItem"
        Me.CatalagosDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(257, 26)
        Me.CatalagosDeEmpleadosToolStripMenuItem.Text = "Catalagos de Empleados"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(257, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentaDeServicioToolStripMenuItem})
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.ServiciosToolStripMenuItem.Text = "Servicios"
        '
        'VentaDeServicioToolStripMenuItem
        '
        Me.VentaDeServicioToolStripMenuItem.Name = "VentaDeServicioToolStripMenuItem"
        Me.VentaDeServicioToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.VentaDeServicioToolStripMenuItem.Text = "Registro de Servicio"
        '
        'FORM_MENU_CARWASH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(725, 566)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FORM_MENU_CARWASH"
        Me.Text = "Menu Car Wash"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatalogoDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalogosDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalagosDeEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaDeServicioToolStripMenuItem As ToolStripMenuItem
End Class
