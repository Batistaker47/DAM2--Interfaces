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
        Me.BtnToCV = New System.Windows.Forms.Button()
        Me.BtnToWeb = New System.Windows.Forms.Button()
        Me.BtnToImage = New System.Windows.Forms.Button()
        Me.BtnToInternFile = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnToCV
        '
        Me.BtnToCV.Location = New System.Drawing.Point(132, 54)
        Me.BtnToCV.Name = "BtnToCV"
        Me.BtnToCV.Size = New System.Drawing.Size(103, 73)
        Me.BtnToCV.TabIndex = 0
        Me.BtnToCV.Text = "CV"
        Me.BtnToCV.UseVisualStyleBackColor = True
        '
        'BtnToWeb
        '
        Me.BtnToWeb.Location = New System.Drawing.Point(279, 54)
        Me.BtnToWeb.Name = "BtnToWeb"
        Me.BtnToWeb.Size = New System.Drawing.Size(103, 73)
        Me.BtnToWeb.TabIndex = 1
        Me.BtnToWeb.Text = "Web"
        Me.BtnToWeb.UseVisualStyleBackColor = True
        '
        'BtnToImage
        '
        Me.BtnToImage.Location = New System.Drawing.Point(427, 54)
        Me.BtnToImage.Name = "BtnToImage"
        Me.BtnToImage.Size = New System.Drawing.Size(103, 73)
        Me.BtnToImage.TabIndex = 2
        Me.BtnToImage.Text = "Image"
        Me.BtnToImage.UseVisualStyleBackColor = True
        '
        'BtnToInternFile
        '
        Me.BtnToInternFile.Location = New System.Drawing.Point(590, 54)
        Me.BtnToInternFile.Name = "BtnToInternFile"
        Me.BtnToInternFile.Size = New System.Drawing.Size(103, 73)
        Me.BtnToInternFile.TabIndex = 3
        Me.BtnToInternFile.Text = "Intern File"
        Me.BtnToInternFile.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(48, 148)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(205, 183)
        Me.WebBrowser1.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(279, 133)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(498, 402)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 569)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.BtnToInternFile)
        Me.Controls.Add(Me.BtnToImage)
        Me.Controls.Add(Me.BtnToWeb)
        Me.Controls.Add(Me.BtnToCV)
        Me.Name = "FormPrincipal"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnToCV As Button
    Friend WithEvents BtnToWeb As Button
    Friend WithEvents BtnToImage As Button
    Friend WithEvents BtnToInternFile As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents PictureBox1 As PictureBox
End Class
