<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrimero
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
        Me.txtParametro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonParameter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtParametro
        '
        Me.txtParametro.Location = New System.Drawing.Point(102, 50)
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(125, 20)
        Me.txtParametro.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Parameter:"
        '
        'ButtonParameter
        '
        Me.ButtonParameter.Location = New System.Drawing.Point(143, 76)
        Me.ButtonParameter.Name = "ButtonParameter"
        Me.ButtonParameter.Size = New System.Drawing.Size(84, 30)
        Me.ButtonParameter.TabIndex = 2
        Me.ButtonParameter.Text = "Send"
        Me.ButtonParameter.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 150)
        Me.Controls.Add(Me.ButtonParameter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtParametro)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtParametro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonParameter As Button
End Class
