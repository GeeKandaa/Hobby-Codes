<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BattleScreen
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Enemy0Name = New System.Windows.Forms.TextBox()
        Me.Enemy0Status = New System.Windows.Forms.TextBox()
        Me.Enemy0Desc = New System.Windows.Forms.TextBox()
        Me.Enemy1Desc = New System.Windows.Forms.TextBox()
        Me.Enemy1Status = New System.Windows.Forms.TextBox()
        Me.Enemy1Name = New System.Windows.Forms.TextBox()
        Me.Enemy2Desc = New System.Windows.Forms.TextBox()
        Me.Enemy2Status = New System.Windows.Forms.TextBox()
        Me.Enemy2Name = New System.Windows.Forms.TextBox()
        Me.PlayerName = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.PlayerHP_Bar = New System.Windows.Forms.ProgressBar()
        Me.Enemy1 = New System.Windows.Forms.PictureBox()
        Me.Enemy2 = New System.Windows.Forms.PictureBox()
        Me.Enemy0 = New System.Windows.Forms.PictureBox()
        Me.PlayerSkin = New System.Windows.Forms.PictureBox()
        Me.PlayerHP = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.PlayerXP_Bar = New System.Windows.Forms.ProgressBar()
        Me.PlayerXP = New System.Windows.Forms.TextBox()
        Me.XP_Mod = New System.Windows.Forms.TextBox()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerSkin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(296, 240)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 49)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Flee"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(296, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 49)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Attack"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Enemy0Name
        '
        Me.Enemy0Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Enemy0Name.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enemy0Name.Location = New System.Drawing.Point(537, 24)
        Me.Enemy0Name.Name = "Enemy0Name"
        Me.Enemy0Name.ReadOnly = True
        Me.Enemy0Name.Size = New System.Drawing.Size(226, 16)
        Me.Enemy0Name.TabIndex = 7
        '
        'Enemy0Status
        '
        Me.Enemy0Status.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Enemy0Status.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enemy0Status.Location = New System.Drawing.Point(537, 48)
        Me.Enemy0Status.Name = "Enemy0Status"
        Me.Enemy0Status.ReadOnly = True
        Me.Enemy0Status.Size = New System.Drawing.Size(226, 16)
        Me.Enemy0Status.TabIndex = 8
        '
        'Enemy0Desc
        '
        Me.Enemy0Desc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Enemy0Desc.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enemy0Desc.Location = New System.Drawing.Point(537, 77)
        Me.Enemy0Desc.Multiline = True
        Me.Enemy0Desc.Name = "Enemy0Desc"
        Me.Enemy0Desc.ReadOnly = True
        Me.Enemy0Desc.Size = New System.Drawing.Size(226, 44)
        Me.Enemy0Desc.TabIndex = 9
        '
        'Enemy1Desc
        '
        Me.Enemy1Desc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Enemy1Desc.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enemy1Desc.Location = New System.Drawing.Point(537, 220)
        Me.Enemy1Desc.Multiline = True
        Me.Enemy1Desc.Name = "Enemy1Desc"
        Me.Enemy1Desc.ReadOnly = True
        Me.Enemy1Desc.Size = New System.Drawing.Size(226, 44)
        Me.Enemy1Desc.TabIndex = 12
        '
        'Enemy1Status
        '
        Me.Enemy1Status.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Enemy1Status.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enemy1Status.Location = New System.Drawing.Point(537, 191)
        Me.Enemy1Status.Name = "Enemy1Status"
        Me.Enemy1Status.ReadOnly = True
        Me.Enemy1Status.Size = New System.Drawing.Size(226, 16)
        Me.Enemy1Status.TabIndex = 11
        '
        'Enemy1Name
        '
        Me.Enemy1Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Enemy1Name.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enemy1Name.Location = New System.Drawing.Point(537, 167)
        Me.Enemy1Name.Name = "Enemy1Name"
        Me.Enemy1Name.ReadOnly = True
        Me.Enemy1Name.Size = New System.Drawing.Size(226, 16)
        Me.Enemy1Name.TabIndex = 10
        '
        'Enemy2Desc
        '
        Me.Enemy2Desc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Enemy2Desc.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enemy2Desc.Location = New System.Drawing.Point(537, 360)
        Me.Enemy2Desc.Multiline = True
        Me.Enemy2Desc.Name = "Enemy2Desc"
        Me.Enemy2Desc.ReadOnly = True
        Me.Enemy2Desc.Size = New System.Drawing.Size(226, 44)
        Me.Enemy2Desc.TabIndex = 15
        '
        'Enemy2Status
        '
        Me.Enemy2Status.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Enemy2Status.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enemy2Status.Location = New System.Drawing.Point(537, 331)
        Me.Enemy2Status.Name = "Enemy2Status"
        Me.Enemy2Status.ReadOnly = True
        Me.Enemy2Status.Size = New System.Drawing.Size(226, 16)
        Me.Enemy2Status.TabIndex = 14
        '
        'Enemy2Name
        '
        Me.Enemy2Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Enemy2Name.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enemy2Name.Location = New System.Drawing.Point(537, 307)
        Me.Enemy2Name.Name = "Enemy2Name"
        Me.Enemy2Name.ReadOnly = True
        Me.Enemy2Name.Size = New System.Drawing.Size(226, 16)
        Me.Enemy2Name.TabIndex = 13
        '
        'PlayerName
        '
        Me.PlayerName.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PlayerName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PlayerName.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerName.Location = New System.Drawing.Point(84, 240)
        Me.PlayerName.Name = "PlayerName"
        Me.PlayerName.ReadOnly = True
        Me.PlayerName.Size = New System.Drawing.Size(171, 16)
        Me.PlayerName.TabIndex = 16
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox11.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(84, 278)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(31, 16)
        Me.TextBox11.TabIndex = 17
        Me.TextBox11.Text = "HP :"
        '
        'PlayerHP_Bar
        '
        Me.PlayerHP_Bar.Location = New System.Drawing.Point(84, 307)
        Me.PlayerHP_Bar.Name = "PlayerHP_Bar"
        Me.PlayerHP_Bar.Size = New System.Drawing.Size(172, 18)
        Me.PlayerHP_Bar.TabIndex = 19
        '
        'Enemy1
        '
        Me.Enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy1.Location = New System.Drawing.Point(446, 167)
        Me.Enemy1.Name = "Enemy1"
        Me.Enemy1.Size = New System.Drawing.Size(85, 97)
        Me.Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemy1.TabIndex = 3
        Me.Enemy1.TabStop = False
        '
        'Enemy2
        '
        Me.Enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy2.Location = New System.Drawing.Point(446, 307)
        Me.Enemy2.Name = "Enemy2"
        Me.Enemy2.Size = New System.Drawing.Size(85, 97)
        Me.Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemy2.TabIndex = 2
        Me.Enemy2.TabStop = False
        '
        'Enemy0
        '
        Me.Enemy0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Enemy0.Location = New System.Drawing.Point(446, 24)
        Me.Enemy0.Name = "Enemy0"
        Me.Enemy0.Size = New System.Drawing.Size(85, 97)
        Me.Enemy0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemy0.TabIndex = 1
        Me.Enemy0.TabStop = False
        '
        'PlayerSkin
        '
        Me.PlayerSkin.Location = New System.Drawing.Point(84, 42)
        Me.PlayerSkin.Name = "PlayerSkin"
        Me.PlayerSkin.Size = New System.Drawing.Size(172, 186)
        Me.PlayerSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PlayerSkin.TabIndex = 0
        Me.PlayerSkin.TabStop = False
        '
        'PlayerHP
        '
        Me.PlayerHP.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PlayerHP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PlayerHP.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerHP.Location = New System.Drawing.Point(121, 278)
        Me.PlayerHP.Name = "PlayerHP"
        Me.PlayerHP.ReadOnly = True
        Me.PlayerHP.Size = New System.Drawing.Size(48, 16)
        Me.PlayerHP.TabIndex = 20
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(296, 179)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 110)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "You won!"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'TextBox
        '
        Me.TextBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox.Location = New System.Drawing.Point(84, 360)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.ReadOnly = True
        Me.TextBox.Size = New System.Drawing.Size(31, 16)
        Me.TextBox.TabIndex = 22
        Me.TextBox.Text = "XP :"
        '
        'PlayerXP_Bar
        '
        Me.PlayerXP_Bar.Location = New System.Drawing.Point(84, 386)
        Me.PlayerXP_Bar.Name = "PlayerXP_Bar"
        Me.PlayerXP_Bar.Size = New System.Drawing.Size(172, 18)
        Me.PlayerXP_Bar.TabIndex = 23
        '
        'PlayerXP
        '
        Me.PlayerXP.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PlayerXP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PlayerXP.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerXP.Location = New System.Drawing.Point(121, 360)
        Me.PlayerXP.Name = "PlayerXP"
        Me.PlayerXP.ReadOnly = True
        Me.PlayerXP.Size = New System.Drawing.Size(48, 16)
        Me.PlayerXP.TabIndex = 24
        '
        'XP_Mod
        '
        Me.XP_Mod.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.XP_Mod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.XP_Mod.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XP_Mod.Location = New System.Drawing.Point(166, 360)
        Me.XP_Mod.Name = "XP_Mod"
        Me.XP_Mod.ReadOnly = True
        Me.XP_Mod.Size = New System.Drawing.Size(48, 16)
        Me.XP_Mod.TabIndex = 25
        '
        'BattleScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 459)
        Me.Controls.Add(Me.XP_Mod)
        Me.Controls.Add(Me.PlayerXP)
        Me.Controls.Add(Me.PlayerXP_Bar)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PlayerHP)
        Me.Controls.Add(Me.PlayerHP_Bar)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.PlayerName)
        Me.Controls.Add(Me.Enemy2Desc)
        Me.Controls.Add(Me.Enemy2Status)
        Me.Controls.Add(Me.Enemy2Name)
        Me.Controls.Add(Me.Enemy1Desc)
        Me.Controls.Add(Me.Enemy1Status)
        Me.Controls.Add(Me.Enemy1Name)
        Me.Controls.Add(Me.Enemy0Desc)
        Me.Controls.Add(Me.Enemy0Status)
        Me.Controls.Add(Me.Enemy0Name)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Enemy1)
        Me.Controls.Add(Me.Enemy2)
        Me.Controls.Add(Me.Enemy0)
        Me.Controls.Add(Me.PlayerSkin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BattleScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "You've been attacked!"
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerSkin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PlayerSkin As PictureBox
    Friend WithEvents Enemy0 As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Enemy1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Enemy0Name As TextBox
    Friend WithEvents Enemy0Status As TextBox
    Friend WithEvents Enemy0Desc As TextBox
    Friend WithEvents Enemy1Desc As TextBox
    Friend WithEvents Enemy1Status As TextBox
    Friend WithEvents Enemy1Name As TextBox
    Friend WithEvents Enemy2Desc As TextBox
    Friend WithEvents Enemy2Status As TextBox
    Friend WithEvents Enemy2Name As TextBox
    Friend WithEvents PlayerName As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents PlayerHP_Bar As ProgressBar
    Friend WithEvents PlayerHP As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox As TextBox
    Friend WithEvents PlayerXP_Bar As ProgressBar
    Friend WithEvents PlayerXP As TextBox
    Friend WithEvents XP_Mod As TextBox
End Class
