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
        Me.Inventory = New System.Windows.Forms.TextBox()
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        CType(Me.Marker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Skin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Inventory
        '
        Me.Inventory.Cursor = System.Windows.Forms.Cursors.Default
        Me.Inventory.Location = New System.Drawing.Point(21, 378)
        Me.Inventory.Multiline = True
        Me.Inventory.Name = "Inventory"
        Me.Inventory.ReadOnly = True
        Me.Inventory.Size = New System.Drawing.Size(252, 113)
        Me.Inventory.TabIndex = 36
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(20, 300)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(83, 18)
        Me.TextBox7.TabIndex = 28
        Me.TextBox7.Text = "Dexterity :"
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(20, 271)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(83, 18)
        Me.TextBox6.TabIndex = 27
        Me.TextBox6.Text = "Endurance :"
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(20, 242)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(83, 18)
        Me.TextBox5.TabIndex = 26
        Me.TextBox5.Text = "Strength :"
        '
        'NameBox
        '
        Me.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NameBox.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameBox.Location = New System.Drawing.Point(12, 199)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.ReadOnly = True
        Me.NameBox.Size = New System.Drawing.Size(262, 21)
        Me.NameBox.TabIndex = 25
        '
        'CurrXP
        '
        Me.CurrXP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CurrXP.Cursor = System.Windows.Forms.Cursors.Default
        Me.CurrXP.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrXP.Location = New System.Drawing.Point(210, 110)
        Me.CurrXP.Name = "CurrXP"
        Me.CurrXP.ReadOnly = True
        Me.CurrXP.Size = New System.Drawing.Size(37, 19)
        Me.CurrXP.TabIndex = 24
        Me.CurrXP.Text = "0"
        Me.CurrXP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MaxHealth
        '
        Me.MaxHealth.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaxHealth.Cursor = System.Windows.Forms.Cursors.Default
        Me.MaxHealth.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaxHealth.Location = New System.Drawing.Point(210, 86)
        Me.MaxHealth.Name = "MaxHealth"
        Me.MaxHealth.ReadOnly = True
        Me.MaxHealth.Size = New System.Drawing.Size(37, 19)
        Me.MaxHealth.TabIndex = 23
        Me.MaxHealth.Text = "20"
        Me.MaxHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(165, 110)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(39, 18)
        Me.TextBox2.TabIndex = 22
        Me.TextBox2.Text = "XP :"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(165, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(39, 18)
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
        Me.Marker.Size = New System.Drawing.Size(59, 56)
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
        Me.StrStat.BackColor = System.Drawing.Color.WhiteSmoke
        Me.StrStat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StrStat.Cursor = System.Windows.Forms.Cursors.Default
        Me.StrStat.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StrStat.Location = New System.Drawing.Point(109, 239)
        Me.StrStat.Name = "StrStat"
        Me.StrStat.ReadOnly = True
        Me.StrStat.Size = New System.Drawing.Size(31, 19)
        Me.StrStat.TabIndex = 37
        '
        'EndStat
        '
        Me.EndStat.BackColor = System.Drawing.Color.WhiteSmoke
        Me.EndStat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EndStat.Cursor = System.Windows.Forms.Cursors.Default
        Me.EndStat.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndStat.Location = New System.Drawing.Point(109, 268)
        Me.EndStat.Name = "EndStat"
        Me.EndStat.ReadOnly = True
        Me.EndStat.Size = New System.Drawing.Size(31, 19)
        Me.EndStat.TabIndex = 38
        '
        'DexStat
        '
        Me.DexStat.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DexStat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DexStat.Cursor = System.Windows.Forms.Cursors.Default
        Me.DexStat.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DexStat.Location = New System.Drawing.Point(109, 297)
        Me.DexStat.Name = "DexStat"
        Me.DexStat.ReadOnly = True
        Me.DexStat.Size = New System.Drawing.Size(31, 19)
        Me.DexStat.TabIndex = 39
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox3.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(20, 343)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(253, 26)
        Me.TextBox3.TabIndex = 40
        Me.TextBox3.Text = "Inventory :"
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(253, 86)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(43, 18)
        Me.TextBox4.TabIndex = 41
        Me.TextBox4.Text = "(max)"
        '
        'PCStat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 503)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.DexStat)
        Me.Controls.Add(Me.EndStat)
        Me.Controls.Add(Me.StrStat)
        Me.Controls.Add(Me.Inventory)
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

    Friend WithEvents Inventory As TextBox
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
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
