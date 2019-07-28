<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CombatPicker
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Enemy2Choose = New System.Windows.Forms.PictureBox()
        Me.Enemy1Choose = New System.Windows.Forms.PictureBox()
        Me.Enemy0Choose = New System.Windows.Forms.PictureBox()
        CType(Me.Enemy2Choose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy1Choose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy0Choose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(69, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(496, 19)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Which opponent would you like to attack?"
        '
        'Enemy2Choose
        '
        Me.Enemy2Choose.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Enemy2Choose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy2Choose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Enemy2Choose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Enemy2Choose.Location = New System.Drawing.Point(471, 88)
        Me.Enemy2Choose.Name = "Enemy2Choose"
        Me.Enemy2Choose.Size = New System.Drawing.Size(130, 142)
        Me.Enemy2Choose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemy2Choose.TabIndex = 3
        Me.Enemy2Choose.TabStop = False
        '
        'Enemy1Choose
        '
        Me.Enemy1Choose.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Enemy1Choose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy1Choose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Enemy1Choose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Enemy1Choose.Location = New System.Drawing.Point(309, 88)
        Me.Enemy1Choose.Name = "Enemy1Choose"
        Me.Enemy1Choose.Size = New System.Drawing.Size(130, 142)
        Me.Enemy1Choose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemy1Choose.TabIndex = 2
        Me.Enemy1Choose.TabStop = False
        '
        'Enemy0Choose
        '
        Me.Enemy0Choose.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Enemy0Choose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy0Choose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Enemy0Choose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Enemy0Choose.Location = New System.Drawing.Point(145, 88)
        Me.Enemy0Choose.Name = "Enemy0Choose"
        Me.Enemy0Choose.Size = New System.Drawing.Size(130, 142)
        Me.Enemy0Choose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemy0Choose.TabIndex = 1
        Me.Enemy0Choose.TabStop = False
        '
        'CombatPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 271)
        Me.Controls.Add(Me.Enemy2Choose)
        Me.Controls.Add(Me.Enemy1Choose)
        Me.Controls.Add(Me.Enemy0Choose)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CombatPicker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Target"
        CType(Me.Enemy2Choose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy1Choose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy0Choose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Enemy0Choose As PictureBox
    Friend WithEvents Enemy1Choose As PictureBox
    Friend WithEvents Enemy2Choose As PictureBox
End Class
