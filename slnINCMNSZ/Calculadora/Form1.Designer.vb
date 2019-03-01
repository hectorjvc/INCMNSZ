<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblNumero1 = New System.Windows.Forms.Label()
        Me.lblNumero2 = New System.Windows.Forms.Label()
        Me.txtNumero1 = New System.Windows.Forms.TextBox()
        Me.txtNumero2 = New System.Windows.Forms.TextBox()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnMultiplica = New System.Windows.Forms.Button()
        Me.btnMayusculas = New System.Windows.Forms.Button()
        Me.txtMayusculas = New System.Windows.Forms.TextBox()
        Me.btnGeneraArchivo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumero1
        '
        Me.lblNumero1.AutoSize = True
        Me.lblNumero1.Location = New System.Drawing.Point(46, 27)
        Me.lblNumero1.Name = "lblNumero1"
        Me.lblNumero1.Size = New System.Drawing.Size(53, 13)
        Me.lblNumero1.TabIndex = 0
        Me.lblNumero1.Text = "Numero 1"
        '
        'lblNumero2
        '
        Me.lblNumero2.AutoSize = True
        Me.lblNumero2.Location = New System.Drawing.Point(46, 54)
        Me.lblNumero2.Name = "lblNumero2"
        Me.lblNumero2.Size = New System.Drawing.Size(53, 13)
        Me.lblNumero2.TabIndex = 1
        Me.lblNumero2.Text = "Numero 2"
        '
        'txtNumero1
        '
        Me.txtNumero1.Location = New System.Drawing.Point(112, 19)
        Me.txtNumero1.Name = "txtNumero1"
        Me.txtNumero1.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero1.TabIndex = 2
        '
        'txtNumero2
        '
        Me.txtNumero2.Location = New System.Drawing.Point(112, 47)
        Me.txtNumero2.Name = "txtNumero2"
        Me.txtNumero2.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero2.TabIndex = 3
        '
        'btnSuma
        '
        Me.btnSuma.Location = New System.Drawing.Point(24, 84)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(75, 23)
        Me.btnSuma.TabIndex = 4
        Me.btnSuma.Text = "Suma"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnMultiplica
        '
        Me.btnMultiplica.Location = New System.Drawing.Point(112, 84)
        Me.btnMultiplica.Name = "btnMultiplica"
        Me.btnMultiplica.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiplica.TabIndex = 5
        Me.btnMultiplica.Text = "Multiplica"
        Me.btnMultiplica.UseVisualStyleBackColor = True
        '
        'btnMayusculas
        '
        Me.btnMayusculas.Location = New System.Drawing.Point(24, 165)
        Me.btnMayusculas.Name = "btnMayusculas"
        Me.btnMayusculas.Size = New System.Drawing.Size(75, 23)
        Me.btnMayusculas.TabIndex = 6
        Me.btnMayusculas.Text = "Mayusculas"
        Me.btnMayusculas.UseVisualStyleBackColor = True
        '
        'txtMayusculas
        '
        Me.txtMayusculas.Location = New System.Drawing.Point(112, 165)
        Me.txtMayusculas.Name = "txtMayusculas"
        Me.txtMayusculas.Size = New System.Drawing.Size(100, 20)
        Me.txtMayusculas.TabIndex = 7
        '
        'btnGeneraArchivo
        '
        Me.btnGeneraArchivo.Location = New System.Drawing.Point(24, 206)
        Me.btnGeneraArchivo.Name = "btnGeneraArchivo"
        Me.btnGeneraArchivo.Size = New System.Drawing.Size(188, 23)
        Me.btnGeneraArchivo.TabIndex = 8
        Me.btnGeneraArchivo.Text = "Generar Archivo"
        Me.btnGeneraArchivo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(250, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 276)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGeneraArchivo)
        Me.Controls.Add(Me.txtMayusculas)
        Me.Controls.Add(Me.btnMayusculas)
        Me.Controls.Add(Me.btnMultiplica)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.txtNumero2)
        Me.Controls.Add(Me.txtNumero1)
        Me.Controls.Add(Me.lblNumero2)
        Me.Controls.Add(Me.lblNumero1)
        Me.Name = "Form1"
        Me.Opacity = 0.8R
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumero1 As Label
    Friend WithEvents lblNumero2 As Label
    Friend WithEvents txtNumero1 As TextBox
    Friend WithEvents txtNumero2 As TextBox
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnMultiplica As Button
    Friend WithEvents btnMayusculas As Button
    Friend WithEvents txtMayusculas As TextBox
    Friend WithEvents btnGeneraArchivo As Button
    Friend WithEvents Button1 As Button
End Class
