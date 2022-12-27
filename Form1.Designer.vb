<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.no1 = New System.Windows.Forms.Label()
        Me.no2 = New System.Windows.Forms.Label()
        Me.value1 = New System.Windows.Forms.TextBox()
        Me.value2 = New System.Windows.Forms.TextBox()
        Me.plus = New System.Windows.Forms.Button()
        Me.minus = New System.Windows.Forms.Button()
        Me.into = New System.Windows.Forms.Button()
        Me.division = New System.Windows.Forms.Button()
        Me.ShowData = New System.Windows.Forms.Button()
        Me.ans = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'no1
        '
        Me.no1.AutoSize = True
        Me.no1.Location = New System.Drawing.Point(65, 46)
        Me.no1.Name = "no1"
        Me.no1.Size = New System.Drawing.Size(55, 32)
        Me.no1.TabIndex = 0
        Me.no1.Text = "no1"
        '
        'no2
        '
        Me.no2.AutoSize = True
        Me.no2.Location = New System.Drawing.Point(65, 96)
        Me.no2.Name = "no2"
        Me.no2.Size = New System.Drawing.Size(55, 32)
        Me.no2.TabIndex = 1
        Me.no2.Text = "no2"
        '
        'value1
        '
        Me.value1.Location = New System.Drawing.Point(165, 43)
        Me.value1.Name = "value1"
        Me.value1.Size = New System.Drawing.Size(171, 39)
        Me.value1.TabIndex = 2
        '
        'value2
        '
        Me.value2.Location = New System.Drawing.Point(165, 93)
        Me.value2.Name = "value2"
        Me.value2.Size = New System.Drawing.Size(171, 39)
        Me.value2.TabIndex = 3
        '
        'plus
        '
        Me.plus.Location = New System.Drawing.Point(43, 224)
        Me.plus.Name = "plus"
        Me.plus.Size = New System.Drawing.Size(150, 46)
        Me.plus.TabIndex = 4
        Me.plus.Text = "+"
        Me.plus.UseVisualStyleBackColor = True
        '
        'minus
        '
        Me.minus.Location = New System.Drawing.Point(223, 224)
        Me.minus.Name = "minus"
        Me.minus.Size = New System.Drawing.Size(150, 46)
        Me.minus.TabIndex = 5
        Me.minus.Text = "-"
        Me.minus.UseVisualStyleBackColor = True
        '
        'into
        '
        Me.into.Location = New System.Drawing.Point(414, 224)
        Me.into.Name = "into"
        Me.into.Size = New System.Drawing.Size(150, 46)
        Me.into.TabIndex = 6
        Me.into.Text = "*"
        Me.into.UseVisualStyleBackColor = True
        '
        'division
        '
        Me.division.Location = New System.Drawing.Point(599, 224)
        Me.division.Name = "division"
        Me.division.Size = New System.Drawing.Size(150, 46)
        Me.division.TabIndex = 7
        Me.division.Text = "/"
        Me.division.UseVisualStyleBackColor = True
        '
        'ShowData
        '
        Me.ShowData.Location = New System.Drawing.Point(326, 335)
        Me.ShowData.Name = "ShowData"
        Me.ShowData.Size = New System.Drawing.Size(150, 46)
        Me.ShowData.TabIndex = 8
        Me.ShowData.UseVisualStyleBackColor = True
        '
        'ans
        '
        Me.ans.AutoSize = True
        Me.ans.Location = New System.Drawing.Point(210, 342)
        Me.ans.Name = "ans"
        Me.ans.Size = New System.Drawing.Size(110, 32)
        Me.ans.TabIndex = 9
        Me.ans.Text = "Answer : "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ans)
        Me.Controls.Add(Me.ShowData)
        Me.Controls.Add(Me.division)
        Me.Controls.Add(Me.into)
        Me.Controls.Add(Me.minus)
        Me.Controls.Add(Me.plus)
        Me.Controls.Add(Me.value2)
        Me.Controls.Add(Me.value1)
        Me.Controls.Add(Me.no2)
        Me.Controls.Add(Me.no1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents no1 As Label
    Friend WithEvents no2 As Label
    Friend WithEvents value1 As TextBox
    Friend WithEvents value2 As TextBox
    Friend WithEvents plus As Button
    Friend WithEvents minus As Button
    Friend WithEvents into As Button
    Friend WithEvents division As Button
    Friend WithEvents ShowData As Button
    Friend WithEvents ans As Label
End Class
