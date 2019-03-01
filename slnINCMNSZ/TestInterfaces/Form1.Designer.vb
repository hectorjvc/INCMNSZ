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
        Me.btnDirecto = New System.Windows.Forms.Button()
        Me.btnInterfaz = New System.Windows.Forms.Button()
        Me.lvPersons = New System.Windows.Forms.ListView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDirecto
        '
        Me.btnDirecto.Location = New System.Drawing.Point(88, 113)
        Me.btnDirecto.Name = "btnDirecto"
        Me.btnDirecto.Size = New System.Drawing.Size(75, 23)
        Me.btnDirecto.TabIndex = 0
        Me.btnDirecto.Text = "Directo"
        Me.btnDirecto.UseVisualStyleBackColor = True
        '
        'btnInterfaz
        '
        Me.btnInterfaz.Location = New System.Drawing.Point(88, 167)
        Me.btnInterfaz.Name = "btnInterfaz"
        Me.btnInterfaz.Size = New System.Drawing.Size(75, 23)
        Me.btnInterfaz.TabIndex = 1
        Me.btnInterfaz.Text = "Interfaz"
        Me.btnInterfaz.UseVisualStyleBackColor = True
        '
        'lvPersons
        '
        Me.lvPersons.Location = New System.Drawing.Point(230, 30)
        Me.lvPersons.Name = "lvPersons"
        Me.lvPersons.Size = New System.Drawing.Size(77, 253)
        Me.lvPersons.TabIndex = 2
        Me.lvPersons.UseCompatibleStateImageBehavior = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(429, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 318)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lvPersons)
        Me.Controls.Add(Me.btnInterfaz)
        Me.Controls.Add(Me.btnDirecto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDirecto As Button
    Friend WithEvents btnInterfaz As Button
    Friend WithEvents lvPersons As ListView
    Friend WithEvents DataGridView1 As DataGridView
End Class
