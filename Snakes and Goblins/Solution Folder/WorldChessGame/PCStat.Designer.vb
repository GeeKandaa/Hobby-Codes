<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PCStat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PCStat))
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.CurrXP = New System.Windows.Forms.TextBox()
        Me.MaxHealth = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Marker = New System.Windows.Forms.PictureBox()
        Me.Skin = New System.Windows.Forms.PictureBox()
        Me.StrStat = New System.Windows.Forms.TextBox()
        Me.EndStat = New System.Windows.Forms.TextBox()
        Me.DexStat = New System.Windows.Forms.TextBox()
        Me.HpCurr = New System.Windows.Forms.TextBox()
        Me.HpText = New System.Windows.Forms.TextBox()
        Me.NextXP = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.IncStr = New System.Windows.Forms.Button()
        Me.IncDex = New System.Windows.Forms.Button()
        Me.IncEnd = New System.Windows.Forms.Button()
        Me.APPoints = New System.Windows.Forms.TextBox()
        Me.ApPoint_Text = New System.Windows.Forms.TextBox()
        CType(Me.Marker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Skin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox7.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox7.Location = New System.Drawing.Point(23, 389)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(99, 23)
        Me.TextBox7.TabIndex = 28
        Me.TextBox7.Text = "Dexterity :"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox6.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox6.Location = New System.Drawing.Point(12, 432)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(110, 23)
        Me.TextBox6.TabIndex = 27
        Me.TextBox6.Text = "Endurance :"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox5.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox5.Location = New System.Drawing.Point(28, 351)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(83, 23)
        Me.TextBox5.TabIndex = 26
        Me.TextBox5.Text = "Strength :"
        '
        'NameBox
        '
        Me.NameBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NameBox.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameBox.ForeColor = System.Drawing.SystemColors.Window
        Me.NameBox.Location = New System.Drawing.Point(12, 199)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.ReadOnly = True
        Me.NameBox.Size = New System.Drawing.Size(262, 21)
        Me.NameBox.TabIndex = 25
        '
        'CurrXP
        '
        Me.CurrXP.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CurrXP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CurrXP.Cursor = System.Windows.Forms.Cursors.Default
        Me.CurrXP.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrXP.ForeColor = System.Drawing.SystemColors.Window
        Me.CurrXP.Location = New System.Drawing.Point(73, 261)
        Me.CurrXP.Name = "CurrXP"
        Me.CurrXP.ReadOnly = True
        Me.CurrXP.Size = New System.Drawing.Size(82, 29)
        Me.CurrXP.TabIndex = 24
        Me.CurrXP.Text = "50000"
        Me.CurrXP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MaxHealth
        '
        Me.MaxHealth.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaxHealth.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaxHealth.Cursor = System.Windows.Forms.Cursors.Default
        Me.MaxHealth.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaxHealth.ForeColor = System.Drawing.SystemColors.Window
        Me.MaxHealth.Location = New System.Drawing.Point(161, 226)
        Me.MaxHealth.Name = "MaxHealth"
        Me.MaxHealth.ReadOnly = True
        Me.MaxHealth.Size = New System.Drawing.Size(76, 29)
        Me.MaxHealth.TabIndex = 23
        Me.MaxHealth.Text = "999"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox2.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox2.Location = New System.Drawing.Point(12, 258)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(47, 29)
        Me.TextBox2.TabIndex = 22
        Me.TextBox2.Text = "XP :"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(12, 226)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(39, 26)
        Me.TextBox1.TabIndex = 21
        Me.TextBox1.Text = "HP :"
        '
        'Marker
        '
        Me.Marker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Marker.Cursor = System.Windows.Forms.Cursors.Default
        Me.Marker.Image = CType(resources.GetObject("Marker.Image"), System.Drawing.Image)
        Me.Marker.Location = New System.Drawing.Point(165, 12)
        Me.Marker.Name = "Marker"
        Me.Marker.Size = New System.Drawing.Size(94, 93)
        Me.Marker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Marker.TabIndex = 20
        Me.Marker.TabStop = False
        '
        'Skin
        '
        Me.Skin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Skin.Cursor = System.Windows.Forms.Cursors.Default
        Me.Skin.Image = CType(resources.GetObject("Skin.Image"), System.Drawing.Image)
        Me.Skin.Location = New System.Drawing.Point(12, 12)
        Me.Skin.Name = "Skin"
        Me.Skin.Size = New System.Drawing.Size(147, 181)
        Me.Skin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Skin.TabIndex = 19
        Me.Skin.TabStop = False
        '
        'StrStat
        '
        Me.StrStat.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StrStat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StrStat.Cursor = System.Windows.Forms.Cursors.Default
        Me.StrStat.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StrStat.ForeColor = System.Drawing.SystemColors.Window
        Me.StrStat.Location = New System.Drawing.Point(136, 352)
        Me.StrStat.Name = "StrStat"
        Me.StrStat.ReadOnly = True
        Me.StrStat.Size = New System.Drawing.Size(42, 25)
        Me.StrStat.TabIndex = 37
        Me.StrStat.Text = "999"
        '
        'EndStat
        '
        Me.EndStat.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EndStat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EndStat.Cursor = System.Windows.Forms.Cursors.Default
        Me.EndStat.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndStat.ForeColor = System.Drawing.SystemColors.Window
        Me.EndStat.Location = New System.Drawing.Point(137, 432)
        Me.EndStat.Name = "EndStat"
        Me.EndStat.ReadOnly = True
        Me.EndStat.Size = New System.Drawing.Size(41, 25)
        Me.EndStat.TabIndex = 38
        Me.EndStat.Text = "999"
        '
        'DexStat
        '
        Me.DexStat.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DexStat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DexStat.Cursor = System.Windows.Forms.Cursors.Default
        Me.DexStat.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DexStat.ForeColor = System.Drawing.SystemColors.Window
        Me.DexStat.Location = New System.Drawing.Point(137, 393)
        Me.DexStat.Name = "DexStat"
        Me.DexStat.ReadOnly = True
        Me.DexStat.Size = New System.Drawing.Size(41, 25)
        Me.DexStat.TabIndex = 39
        Me.DexStat.Text = "999"
        '
        'HpCurr
        '
        Me.HpCurr.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HpCurr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HpCurr.Cursor = System.Windows.Forms.Cursors.Default
        Me.HpCurr.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HpCurr.ForeColor = System.Drawing.SystemColors.Window
        Me.HpCurr.Location = New System.Drawing.Point(65, 226)
        Me.HpCurr.Name = "HpCurr"
        Me.HpCurr.ReadOnly = True
        Me.HpCurr.Size = New System.Drawing.Size(70, 29)
        Me.HpCurr.TabIndex = 40
        Me.HpCurr.Text = "999"
        Me.HpCurr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'HpText
        '
        Me.HpText.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HpText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HpText.Cursor = System.Windows.Forms.Cursors.Default
        Me.HpText.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HpText.ForeColor = System.Drawing.SystemColors.Window
        Me.HpText.Location = New System.Drawing.Point(141, 226)
        Me.HpText.Name = "HpText"
        Me.HpText.ReadOnly = True
        Me.HpText.Size = New System.Drawing.Size(14, 29)
        Me.HpText.TabIndex = 41
        Me.HpText.Text = "/"
        '
        'NextXP
        '
        Me.NextXP.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NextXP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NextXP.Cursor = System.Windows.Forms.Cursors.Default
        Me.NextXP.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextXP.ForeColor = System.Drawing.SystemColors.Info
        Me.NextXP.Location = New System.Drawing.Point(175, 293)
        Me.NextXP.Name = "NextXP"
        Me.NextXP.ReadOnly = True
        Me.NextXP.Size = New System.Drawing.Size(62, 23)
        Me.NextXP.TabIndex = 42
        Me.NextXP.Text = "50000"
        Me.NextXP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox8.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox8.Location = New System.Drawing.Point(22, 293)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(156, 23)
        Me.TextBox8.TabIndex = 43
        Me.TextBox8.Text = "XP to next level :"
        '
        'IncStr
        '
        Me.IncStr.Enabled = False
        Me.IncStr.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncStr.Location = New System.Drawing.Point(184, 351)
        Me.IncStr.Name = "IncStr"
        Me.IncStr.Size = New System.Drawing.Size(17, 26)
        Me.IncStr.TabIndex = 44
        Me.IncStr.Text = "+"
        Me.IncStr.UseVisualStyleBackColor = True
        '
        'IncDex
        '
        Me.IncDex.Enabled = False
        Me.IncDex.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncDex.Location = New System.Drawing.Point(184, 389)
        Me.IncDex.Name = "IncDex"
        Me.IncDex.Size = New System.Drawing.Size(17, 26)
        Me.IncDex.TabIndex = 45
        Me.IncDex.Text = "+"
        Me.IncDex.UseVisualStyleBackColor = True
        '
        'IncEnd
        '
        Me.IncEnd.Enabled = False
        Me.IncEnd.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncEnd.Location = New System.Drawing.Point(184, 431)
        Me.IncEnd.Name = "IncEnd"
        Me.IncEnd.Size = New System.Drawing.Size(17, 26)
        Me.IncEnd.TabIndex = 46
        Me.IncEnd.Text = "+"
        Me.IncEnd.UseVisualStyleBackColor = True
        '
        'APPoints
        '
        Me.APPoints.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.APPoints.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.APPoints.Cursor = System.Windows.Forms.Cursors.Default
        Me.APPoints.Enabled = False
        Me.APPoints.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.APPoints.ForeColor = System.Drawing.SystemColors.Info
        Me.APPoints.Location = New System.Drawing.Point(23, 470)
        Me.APPoints.Name = "APPoints"
        Me.APPoints.Size = New System.Drawing.Size(28, 23)
        Me.APPoints.TabIndex = 47
        Me.APPoints.Text = "AP"
        Me.APPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ApPoint_Text
        '
        Me.ApPoint_Text.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ApPoint_Text.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ApPoint_Text.Cursor = System.Windows.Forms.Cursors.Default
        Me.ApPoint_Text.Enabled = False
        Me.ApPoint_Text.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApPoint_Text.ForeColor = System.Drawing.SystemColors.Info
        Me.ApPoint_Text.Location = New System.Drawing.Point(57, 470)
        Me.ApPoint_Text.Name = "ApPoint_Text"
        Me.ApPoint_Text.ReadOnly = True
        Me.ApPoint_Text.Size = New System.Drawing.Size(180, 21)
        Me.ApPoint_Text.TabIndex = 48
        Me.ApPoint_Text.Text = "Unassigned AP points!"
        '
        'PCStat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(270, 503)
        Me.Controls.Add(Me.ApPoint_Text)
        Me.Controls.Add(Me.APPoints)
        Me.Controls.Add(Me.IncEnd)
        Me.Controls.Add(Me.IncDex)
        Me.Controls.Add(Me.IncStr)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.NextXP)
        Me.Controls.Add(Me.HpText)
        Me.Controls.Add(Me.HpCurr)
        Me.Controls.Add(Me.DexStat)
        Me.Controls.Add(Me.EndStat)
        Me.Controls.Add(Me.StrStat)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.CurrXP)
        Me.Controls.Add(Me.MaxHealth)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Marker)
        Me.Controls.Add(Me.Skin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PCStat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Character"
        CType(Me.Marker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Skin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents CurrXP As TextBox
    Friend WithEvents MaxHealth As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Marker As PictureBox
    Friend WithEvents Skin As PictureBox
    Friend WithEvents StrStat As TextBox
    Friend WithEvents EndStat As TextBox
    Friend WithEvents DexStat As TextBox
    Friend WithEvents HpCurr As TextBox
    Friend WithEvents HpText As TextBox
    Friend WithEvents NextXP As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents IncStr As Button
    Friend WithEvents IncDex As Button
    Friend WithEvents IncEnd As Button
    Friend WithEvents APPoints As TextBox
    Friend WithEvents ApPoint_Text As TextBox
End Class
