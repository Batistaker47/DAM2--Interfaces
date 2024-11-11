<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.labelBodas = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LabelBautizos = New System.Windows.Forms.Label()
        Me.LabelComuniones = New System.Windows.Forms.Label()
        Me.PictureBoxBannerBoda = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxBannerBoda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelBodas
        '
        Me.labelBodas.AutoSize = True
        Me.labelBodas.Font = New System.Drawing.Font("Perpetua Titling MT", 15.0!, System.Drawing.FontStyle.Bold)
        Me.labelBodas.Location = New System.Drawing.Point(822, 273)
        Me.labelBodas.Name = "labelBodas"
        Me.labelBodas.Size = New System.Drawing.Size(83, 24)
        Me.labelBodas.TabIndex = 0
        Me.labelBodas.Text = "BODAS"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'LabelBautizos
        '
        Me.LabelBautizos.AutoSize = True
        Me.LabelBautizos.Font = New System.Drawing.Font("Perpetua Titling MT", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LabelBautizos.Location = New System.Drawing.Point(806, 56)
        Me.LabelBautizos.Name = "LabelBautizos"
        Me.LabelBautizos.Size = New System.Drawing.Size(119, 24)
        Me.LabelBautizos.TabIndex = 3
        Me.LabelBautizos.Text = "BAUTIZOS"
        '
        'LabelComuniones
        '
        Me.LabelComuniones.AutoSize = True
        Me.LabelComuniones.Font = New System.Drawing.Font("Perpetua Titling MT", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LabelComuniones.Location = New System.Drawing.Point(259, 56)
        Me.LabelComuniones.Name = "LabelComuniones"
        Me.LabelComuniones.Size = New System.Drawing.Size(156, 24)
        Me.LabelComuniones.TabIndex = 4
        Me.LabelComuniones.Text = "COMUNIONES"
        '
        'PictureBoxBannerBoda
        '
        Me.PictureBoxBannerBoda.Image = CType(resources.GetObject("PictureBoxBannerBoda.Image"), System.Drawing.Image)
        Me.PictureBoxBannerBoda.Location = New System.Drawing.Point(720, 300)
        Me.PictureBoxBannerBoda.Name = "PictureBoxBannerBoda"
        Me.PictureBoxBannerBoda.Size = New System.Drawing.Size(279, 178)
        Me.PictureBoxBannerBoda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxBannerBoda.TabIndex = 7
        Me.PictureBoxBannerBoda.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(720, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(279, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(22, 83)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(611, 395)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 586)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBoxBannerBoda)
        Me.Controls.Add(Me.LabelComuniones)
        Me.Controls.Add(Me.LabelBautizos)
        Me.Controls.Add(Me.labelBodas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPrincipal"
        Me.Text = "Form1"
        CType(Me.PictureBoxBannerBoda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelBodas As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents LabelBautizos As Label
    Friend WithEvents LabelComuniones As Label
    Friend WithEvents PictureBoxBannerBoda As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
