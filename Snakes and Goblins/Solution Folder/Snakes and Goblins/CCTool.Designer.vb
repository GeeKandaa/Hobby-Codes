<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CCTool
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CCTool))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MaxHealth = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.CCTool_NameBox = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Str_ApModBox = New System.Windows.Forms.NumericUpDown()
        Me.End_ApModBox = New System.Windows.Forms.NumericUpDown()
        Me.Dex_ApModBox = New System.Windows.Forms.NumericUpDown()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Total_APDispBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Marker_Preview = New System.Windows.Forms.PictureBox()
        Me.Skin_Preview = New System.Windows.Forms.PictureBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.Str_ApModBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.End_ApModBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dex_ApModBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Marker_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Skin_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(157, 82)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(39, 18)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "HP :"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(157, 106)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(39, 18)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "XP :"
        '
        'MaxHealth
        '
        Me.MaxHealth.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaxHealth.Cursor = System.Windows.Forms.Cursors.Default
        Me.MaxHealth.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaxHealth.Location = New System.Drawing.Point(202, 82)
        Me.MaxHealth.Name = "MaxHealth"
        Me.MaxHealth.ReadOnly = True
        Me.MaxHealth.Size = New System.Drawing.Size(72, 19)
        Me.MaxHealth.TabIndex = 4
        Me.MaxHealth.Text = "20"
        Me.MaxHealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox4.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(202, 107)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(72, 19)
        Me.TextBox4.TabIndex = 5
        Me.TextBox4.Text = "0"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CCTool_NameBox
        '
        Me.CCTool_NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CCTool_NameBox.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCTool_NameBox.Location = New System.Drawing.Point(4, 195)
        Me.CCTool_NameBox.Name = "CCTool_NameBox"
        Me.CCTool_NameBox.ReadOnly = True
        Me.CCTool_NameBox.Size = New System.Drawing.Size(262, 21)
        Me.CCTool_NameBox.TabIndex = 6
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(12, 254)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(83, 18)
        Me.TextBox5.TabIndex = 7
        Me.TextBox5.Text = "Strength :"
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(12, 283)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(83, 18)
        Me.TextBox6.TabIndex = 8
        Me.TextBox6.Text = "Endurance :"
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(12, 312)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(83, 18)
        Me.TextBox7.TabIndex = 9
        Me.TextBox7.Text = "Dexterity :"
        '
        'Str_ApModBox
        '
        Me.Str_ApModBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.Str_ApModBox.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Str_ApModBox.Location = New System.Drawing.Point(101, 254)
        Me.Str_ApModBox.Name = "Str_ApModBox"
        Me.Str_ApModBox.Size = New System.Drawing.Size(34, 23)
        Me.Str_ApModBox.TabIndex = 10
        Me.Str_ApModBox.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'End_ApModBox
        '
        Me.End_ApModBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.End_ApModBox.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.End_ApModBox.Location = New System.Drawing.Point(101, 283)
        Me.End_ApModBox.Name = "End_ApModBox"
        Me.End_ApModBox.Size = New System.Drawing.Size(34, 23)
        Me.End_ApModBox.TabIndex = 11
        Me.End_ApModBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Dex_ApModBox
        '
        Me.Dex_ApModBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.Dex_ApModBox.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dex_ApModBox.Location = New System.Drawing.Point(101, 312)
        Me.Dex_ApModBox.Name = "Dex_ApModBox"
        Me.Dex_ApModBox.Size = New System.Drawing.Size(34, 23)
        Me.Dex_ApModBox.TabIndex = 12
        Me.Dex_ApModBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox8.Location = New System.Drawing.Point(191, 276)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(75, 39)
        Me.TextBox8.TabIndex = 14
        Me.TextBox8.Text = "AP Left to Spend"
        '
        'Total_APDispBox
        '
        Me.Total_APDispBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.Total_APDispBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_APDispBox.Location = New System.Drawing.Point(157, 276)
        Me.Total_APDispBox.Name = "Total_APDispBox"
        Me.Total_APDispBox.Size = New System.Drawing.Size(25, 29)
        Me.Total_APDispBox.TabIndex = 15
        Me.Total_APDispBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(144, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 44)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Accept Character"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(12, 425)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 44)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Back to Menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox9.Location = New System.Drawing.Point(13, 339)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(252, 67)
        Me.TextBox9.TabIndex = 18
        Me.TextBox9.Text = "Set your AP in your Abilities! Don't forget to click on the pictures to choose yo" &
    "ur own!"
        '
        'Marker_Preview
        '
        Me.Marker_Preview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Marker_Preview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Marker_Preview.Image = CType(resources.GetObject("Marker_Preview.Image"), System.Drawing.Image)
        Me.Marker_Preview.Location = New System.Drawing.Point(157, 8)
        Me.Marker_Preview.Name = "Marker_Preview"
        Me.Marker_Preview.Size = New System.Drawing.Size(59, 56)
        Me.Marker_Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Marker_Preview.TabIndex = 1
        Me.Marker_Preview.TabStop = False
        '
        'Skin_Preview
        '
        Me.Skin_Preview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Skin_Preview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Skin_Preview.Image = CType(resources.GetObject("Skin_Preview.Image"), System.Drawing.Image)
        Me.Skin_Preview.Location = New System.Drawing.Point(4, 8)
        Me.Skin_Preview.Name = "Skin_Preview"
        Me.Skin_Preview.Size = New System.Drawing.Size(147, 181)
        Me.Skin_Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Skin_Preview.TabIndex = 0
        Me.Skin_Preview.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox3.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(4, 228)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(81, 26)
        Me.TextBox3.TabIndex = 19
        Me.TextBox3.Text = "Abilities"
        '
        'CCTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 508)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Total_APDispBox)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Dex_ApModBox)
        Me.Controls.Add(Me.End_ApModBox)
        Me.Controls.Add(Me.Str_ApModBox)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.CCTool_NameBox)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.MaxHealth)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Marker_Preview)
        Me.Controls.Add(Me.Skin_Preview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CCTool"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Character Creation"
        CType(Me.Str_ApModBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.End_ApModBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dex_ApModBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Marker_Preview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Skin_Preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Skin_Preview As PictureBox
    Friend WithEvents Marker_Preview As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents MaxHealth As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents CCTool_NameBox As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Str_ApModBox As NumericUpDown
    Friend WithEvents End_ApModBox As NumericUpDown
    Friend WithEvents Dex_ApModBox As NumericUpDown
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Total_APDispBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
