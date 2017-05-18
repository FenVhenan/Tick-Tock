<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBomb
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrDeath = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCountDown = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tmrDeath
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TIME BEFORE BOMB GOES OFF"
        '
        'txtCountDown
        '
        Me.txtCountDown.Location = New System.Drawing.Point(96, 56)
        Me.txtCountDown.Name = "txtCountDown"
        Me.txtCountDown.ReadOnly = True
        Me.txtCountDown.Size = New System.Drawing.Size(100, 20)
        Me.txtCountDown.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CODE TO DIFUSE BOMB"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(66, 137)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(166, 20)
        Me.txtPassword.TabIndex = 3
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(96, 176)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(100, 23)
        Me.btnCheck.TabIndex = 4
        Me.btnCheck.Text = "Please Be Right"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'frmBomb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 211)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCountDown)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBomb"
        Me.Text = "BOMB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrDeath As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCountDown As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnCheck As Button
End Class
