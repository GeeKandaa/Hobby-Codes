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
        Me.Marker_Preview = New System.Windows.Forms.PictureBox()
        Me.Skin_Preview = New System.Windows.Forms.PictureBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.Str_ApModBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.End_ApModBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dex_ApModBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Marker_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Skin_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CCTool_NameBox
        '
        Me.CCTool_NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CCTool_NameBox.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCTool_NameBox.Location = New System.Drawing.Point(108, 231)
        Me.CCTool_NameBox.Name = "CCTool_NameBox"
        Me.CCTool_NameBox.ReadOnly = True
        Me.CCTool_NameBox.Size = New System.Drawing.Size(262, 21)
        Me.CCTool_NameBox.TabIndex = 6
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox5.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox5.Location = New System.Drawing.Point(652, 36)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(116, 29)
        Me.TextBox5.TabIndex = 7
        Me.TextBox5.Text = "Strength :"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox6.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox6.Location = New System.Drawing.Point(652, 134)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(147, 29)
        Me.TextBox6.TabIndex = 8
        Me.TextBox6.Text = "Endurance :"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox7.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox7.Location = New System.Drawing.Point(652, 217)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(128, 29)
        Me.TextBox7.TabIndex = 9
        Me.TextBox7.Text = "Dexterity :"
        '
        'Str_ApModBox
        '
        Me.Str_ApModBox.BackColor = System.Drawing.Color.Olive
        Me.Str_ApModBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Str_ApModBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.Str_ApModBox.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Str_ApModBox.Location = New System.Drawing.Point(816, 44)
        Me.Str_ApModBox.Name = "Str_ApModBox"
        Me.Str_ApModBox.Size = New System.Drawing.Size(51, 35)
        Me.Str_ApModBox.TabIndex = 10
        Me.Str_ApModBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Str_ApModBox.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'End_ApModBox
        '
        Me.End_ApModBox.BackColor = System.Drawing.Color.Olive
        Me.End_ApModBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.End_ApModBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.End_ApModBox.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.End_ApModBox.Location = New System.Drawing.Point(830, 134)
        Me.End_ApModBox.Name = "End_ApModBox"
        Me.End_ApModBox.Size = New System.Drawing.Size(51, 35)
        Me.End_ApModBox.TabIndex = 11
        Me.End_ApModBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.End_ApModBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Dex_ApModBox
        '
        Me.Dex_ApModBox.BackColor = System.Drawing.Color.Olive
        Me.Dex_ApModBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dex_ApModBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.Dex_ApModBox.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dex_ApModBox.Location = New System.Drawing.Point(816, 224)
        Me.Dex_ApModBox.Name = "Dex_ApModBox"
        Me.Dex_ApModBox.Size = New System.Drawing.Size(51, 35)
        Me.Dex_ApModBox.TabIndex = 12
        Me.Dex_ApModBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Dex_ApModBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox8.Location = New System.Drawing.Point(657, 311)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(131, 39)
        Me.TextBox8.TabIndex = 14
        Me.TextBox8.Text = "AP Left to Spend :"
        '
        'Total_APDispBox
        '
        Me.Total_APDispBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Total_APDispBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.Total_APDispBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_APDispBox.ForeColor = System.Drawing.SystemColors.Window
        Me.Total_APDispBox.Location = New System.Drawing.Point(806, 306)
        Me.Total_APDispBox.Name = "Total_APDispBox"
        Me.Total_APDispBox.Size = New System.Drawing.Size(61, 44)
        Me.Total_APDispBox.TabIndex = 15
        Me.Total_APDispBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Perpetua Titling MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(711, 419)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(233, 77)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Accept Character"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SeaGreen
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Papyrus", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 56)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Marker_Preview
        '
        Me.Marker_Preview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Marker_Preview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Marker_Preview.Image = CType(resources.GetObject("Marker_Preview.Image"), System.Drawing.Image)
        Me.Marker_Preview.Location = New System.Drawing.Point(432, 12)
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
        Me.Skin_Preview.Location = New System.Drawing.Point(435, 102)
        Me.Skin_Preview.Name = "Skin_Preview"
        Me.Skin_Preview.Size = New System.Drawing.Size(147, 181)
        Me.Skin_Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Skin_Preview.TabIndex = 0
        Me.Skin_Preview.TabStop = False
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox10.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox10.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox10.Location = New System.Drawing.Point(319, 12)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(110, 26)
        Me.TextBox10.TabIndex = 20
        Me.TextBox10.Text = "Map Marker"
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox11.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox11.Font = New System.Drawing.Font("Segoe MDL2 Assets", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox11.Location = New System.Drawing.Point(389, 36)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(40, 20)
        Me.TextBox11.TabIndex = 21
        Me.TextBox11.Text = "(Click)"
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox12.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox12.Font = New System.Drawing.Font("Rockwell", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox12.Location = New System.Drawing.Point(288, 102)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(141, 26)
        Me.TextBox12.TabIndex = 22
        Me.TextBox12.Text = "Character Sprite"
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox13.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox13.Font = New System.Drawing.Font("Segoe MDL2 Assets", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox13.Location = New System.Drawing.Point(389, 123)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.Size = New System.Drawing.Size(40, 20)
        Me.TextBox13.TabIndex = 23
        Me.TextBox13.Text = "(Click)"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(652, 61)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 39)
        Me.TextBox1.TabIndex = 24
        Me.TextBox1.Text = "(How hard you hit)"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox2.Location = New System.Drawing.Point(652, 157)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(158, 39)
        Me.TextBox2.TabIndex = 25
        Me.TextBox2.Text = "(How tough your skin is)"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox3.Location = New System.Drawing.Point(652, 244)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(158, 39)
        Me.TextBox3.TabIndex = 26
        Me.TextBox3.Text = "(How fast you move)"
        '
        'CCTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(956, 508)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
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
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
