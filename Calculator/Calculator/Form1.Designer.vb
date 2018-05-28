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
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.num2 = New System.Windows.Forms.TextBox()
        Me.txtanswer = New System.Windows.Forms.TextBox()
        Me.add = New System.Windows.Forms.Button()
        Me.subtract = New System.Windows.Forms.Button()
        Me.mult = New System.Windows.Forms.Button()
        Me.divide = New System.Windows.Forms.Button()
        Me.power = New System.Windows.Forms.Button()
        Me.modulus = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(31, 25)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(156, 20)
        Me.num1.TabIndex = 0
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(31, 63)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(156, 20)
        Me.num2.TabIndex = 1
        '
        'txtanswer
        '
        Me.txtanswer.Location = New System.Drawing.Point(31, 101)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.ReadOnly = True
        Me.txtanswer.Size = New System.Drawing.Size(156, 20)
        Me.txtanswer.TabIndex = 2
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(31, 127)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(75, 23)
        Me.add.TabIndex = 3
        Me.add.Text = "Add"
        Me.add.UseVisualStyleBackColor = True
        '
        'subtract
        '
        Me.subtract.Location = New System.Drawing.Point(112, 127)
        Me.subtract.Name = "subtract"
        Me.subtract.Size = New System.Drawing.Size(75, 23)
        Me.subtract.TabIndex = 4
        Me.subtract.Text = "Subtract"
        Me.subtract.UseVisualStyleBackColor = True
        '
        'mult
        '
        Me.mult.Location = New System.Drawing.Point(31, 185)
        Me.mult.Name = "mult"
        Me.mult.Size = New System.Drawing.Size(75, 23)
        Me.mult.TabIndex = 5
        Me.mult.Text = "Multiply"
        Me.mult.UseVisualStyleBackColor = True
        '
        'divide
        '
        Me.divide.Location = New System.Drawing.Point(112, 156)
        Me.divide.Name = "divide"
        Me.divide.Size = New System.Drawing.Size(75, 23)
        Me.divide.TabIndex = 6
        Me.divide.Text = "Divide"
        Me.divide.UseVisualStyleBackColor = True
        '
        'power
        '
        Me.power.Location = New System.Drawing.Point(31, 156)
        Me.power.Name = "power"
        Me.power.Size = New System.Drawing.Size(75, 23)
        Me.power.TabIndex = 7
        Me.power.Text = "Power"
        Me.power.UseVisualStyleBackColor = True
        '
        'modulus
        '
        Me.modulus.Location = New System.Drawing.Point(112, 185)
        Me.modulus.Name = "modulus"
        Me.modulus.Size = New System.Drawing.Size(75, 23)
        Me.modulus.TabIndex = 8
        Me.modulus.Text = "Modulus"
        Me.modulus.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "first Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Second Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Answer"
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(31, 214)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(156, 23)
        Me.btnClr.TabIndex = 12
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 291)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.modulus)
        Me.Controls.Add(Me.power)
        Me.Controls.Add(Me.divide)
        Me.Controls.Add(Me.mult)
        Me.Controls.Add(Me.subtract)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.txtanswer)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.num1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents num1 As TextBox
    Friend WithEvents num2 As TextBox
    Friend WithEvents txtanswer As TextBox
    Friend WithEvents add As Button
    Friend WithEvents subtract As Button
    Friend WithEvents mult As Button
    Friend WithEvents divide As Button
    Friend WithEvents power As Button
    Friend WithEvents modulus As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClr As Button
End Class
