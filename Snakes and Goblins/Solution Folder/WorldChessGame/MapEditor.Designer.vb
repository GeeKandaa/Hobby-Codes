﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MapEditor
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
        Me.Panel_MapDisplay = New System.Windows.Forms.Panel()
<<<<<<< HEAD
=======
        Me.StartPointCheck = New System.Windows.Forms.CheckBox()
>>>>>>> Edit
        Me.Option_Room = New System.Windows.Forms.RadioButton()
        Me.Option_Town = New System.Windows.Forms.RadioButton()
        Me.Option_Overworld = New System.Windows.Forms.RadioButton()
        Me.InitialiseMap = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
<<<<<<< HEAD
        Me.Options_Borders = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TilePanel = New System.Windows.Forms.Panel()
        Me.Buttom_SaveMap = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.StartPointCheck = New System.Windows.Forms.CheckBox()
=======
        Me.Button_SaveMap = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
>>>>>>> Edit
        Me.WallCheck = New System.Windows.Forms.CheckBox()
        Me.LockedDoorCheck = New System.Windows.Forms.CheckBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.StartPointDisp = New System.Windows.Forms.TextBox()
        Me.WallsListDisp = New System.Windows.Forms.TextBox()
<<<<<<< HEAD
        Me.DoorsListDisp = New System.Windows.Forms.TextBox()
        Me.Button_LoadMap = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
=======
        Me.LockedDoorsListDisp = New System.Windows.Forms.TextBox()
        Me.Button_LoadMap = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.UnlockedDoorCheck = New System.Windows.Forms.CheckBox()
        Me.SpawnPointCheck = New System.Windows.Forms.CheckBox()
        Me.UnlockedDoorsListDisp = New System.Windows.Forms.TextBox()
        Me.SpawnListDisp = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
>>>>>>> Edit
        Me.SuspendLayout()
        '
        'Panel_MapDisplay
        '
        Me.Panel_MapDisplay.BackColor = System.Drawing.Color.Black
<<<<<<< HEAD
        Me.Panel_MapDisplay.Location = New System.Drawing.Point(231, 12)
=======
        Me.Panel_MapDisplay.Location = New System.Drawing.Point(11, 12)
>>>>>>> Edit
        Me.Panel_MapDisplay.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_MapDisplay.Name = "Panel_MapDisplay"
        Me.Panel_MapDisplay.Size = New System.Drawing.Size(790, 629)
        Me.Panel_MapDisplay.TabIndex = 0
        '
<<<<<<< HEAD
=======
        'StartPointCheck
        '
        Me.StartPointCheck.AutoSize = True
        Me.StartPointCheck.Checked = True
        Me.StartPointCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StartPointCheck.Location = New System.Drawing.Point(816, 255)
        Me.StartPointCheck.Name = "StartPointCheck"
        Me.StartPointCheck.Size = New System.Drawing.Size(75, 17)
        Me.StartPointCheck.TabIndex = 13
        Me.StartPointCheck.Text = "Start Point"
        Me.StartPointCheck.UseVisualStyleBackColor = True
        '
>>>>>>> Edit
        'Option_Room
        '
        Me.Option_Room.Appearance = System.Windows.Forms.Appearance.Button
        Me.Option_Room.AutoSize = True
        Me.Option_Room.Checked = True
<<<<<<< HEAD
        Me.Option_Room.Location = New System.Drawing.Point(76, 12)
=======
        Me.Option_Room.Location = New System.Drawing.Point(856, 501)
>>>>>>> Edit
        Me.Option_Room.Name = "Option_Room"
        Me.Option_Room.Size = New System.Drawing.Size(112, 23)
        Me.Option_Room.TabIndex = 1
        Me.Option_Room.TabStop = True
        Me.Option_Room.Text = "Room Size - 32 x 32"
        Me.Option_Room.UseVisualStyleBackColor = True
        '
        'Option_Town
        '
        Me.Option_Town.Appearance = System.Windows.Forms.Appearance.Button
        Me.Option_Town.AutoSize = True
<<<<<<< HEAD
        Me.Option_Town.Location = New System.Drawing.Point(76, 35)
=======
        Me.Option_Town.Location = New System.Drawing.Point(845, 530)
>>>>>>> Edit
        Me.Option_Town.Name = "Option_Town"
        Me.Option_Town.Size = New System.Drawing.Size(123, 23)
        Me.Option_Town.TabIndex = 2
        Me.Option_Town.Text = "Town Size - 128 x 128"
        Me.Option_Town.UseVisualStyleBackColor = True
        '
        'Option_Overworld
        '
        Me.Option_Overworld.Appearance = System.Windows.Forms.Appearance.Button
        Me.Option_Overworld.AutoSize = True
<<<<<<< HEAD
        Me.Option_Overworld.Location = New System.Drawing.Point(76, 58)
=======
        Me.Option_Overworld.Location = New System.Drawing.Point(824, 559)
>>>>>>> Edit
        Me.Option_Overworld.Name = "Option_Overworld"
        Me.Option_Overworld.Size = New System.Drawing.Size(144, 23)
        Me.Option_Overworld.TabIndex = 3
        Me.Option_Overworld.Text = "Overworld Size - 512 x 512"
        Me.Option_Overworld.UseVisualStyleBackColor = True
        '
        'InitialiseMap
        '
        Me.InitialiseMap.BackColor = System.Drawing.Color.DimGray
        Me.InitialiseMap.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.InitialiseMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.InitialiseMap.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InitialiseMap.ForeColor = System.Drawing.SystemColors.ControlText
<<<<<<< HEAD
        Me.InitialiseMap.Location = New System.Drawing.Point(12, 153)
        Me.InitialiseMap.Name = "InitialiseMap"
        Me.InitialiseMap.Size = New System.Drawing.Size(208, 36)
=======
        Me.InitialiseMap.Location = New System.Drawing.Point(816, 605)
        Me.InitialiseMap.Name = "InitialiseMap"
        Me.InitialiseMap.Size = New System.Drawing.Size(152, 36)
>>>>>>> Edit
        Me.InitialiseMap.TabIndex = 4
        Me.InitialiseMap.Text = "Initialise Map"
        Me.InitialiseMap.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.TextBox1.Location = New System.Drawing.Point(1, 11)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(69, 47)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "Map  Size :"
        '
        'Options_Borders
        '
        Me.Options_Borders.Appearance = System.Windows.Forms.Appearance.Button
        Me.Options_Borders.AutoSize = True
        Me.Options_Borders.Location = New System.Drawing.Point(76, 91)
        Me.Options_Borders.Name = "Options_Borders"
        Me.Options_Borders.Size = New System.Drawing.Size(59, 23)
        Me.Options_Borders.TabIndex = 6
        Me.Options_Borders.Text = "Borders?"
        Me.Options_Borders.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 27)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Set Custom Tile"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(1, 91)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(69, 23)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.Text = "Options :"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Overworld", "Underground", "Foreground"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 195)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(198, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'TilePanel
        '
        Me.TilePanel.AutoScroll = True
        Me.TilePanel.Location = New System.Drawing.Point(10, 222)
        Me.TilePanel.Name = "TilePanel"
        Me.TilePanel.Size = New System.Drawing.Size(209, 377)
        Me.TilePanel.TabIndex = 11
        '
        'Buttom_SaveMap
        '
        Me.Buttom_SaveMap.BackColor = System.Drawing.Color.DimGray
        Me.Buttom_SaveMap.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.Buttom_SaveMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Buttom_SaveMap.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttom_SaveMap.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Buttom_SaveMap.Location = New System.Drawing.Point(111, 605)
        Me.Buttom_SaveMap.Name = "Buttom_SaveMap"
        Me.Buttom_SaveMap.Size = New System.Drawing.Size(109, 36)
        Me.Buttom_SaveMap.TabIndex = 12
        Me.Buttom_SaveMap.Text = "Save Map"
        Me.Buttom_SaveMap.UseVisualStyleBackColor = False
=======
        Me.TextBox1.Location = New System.Drawing.Point(804, 477)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 18)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "Map  Size :"
        '
        'Button_SaveMap
        '
        Me.Button_SaveMap.BackColor = System.Drawing.Color.DimGray
        Me.Button_SaveMap.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.Button_SaveMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_SaveMap.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SaveMap.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_SaveMap.Location = New System.Drawing.Point(816, 411)
        Me.Button_SaveMap.Name = "Button_SaveMap"
        Me.Button_SaveMap.Size = New System.Drawing.Size(75, 36)
        Me.Button_SaveMap.TabIndex = 12
        Me.Button_SaveMap.Text = "Save Map"
        Me.Button_SaveMap.UseVisualStyleBackColor = False
>>>>>>> Edit
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Text files|*.txt"
        Me.SaveFileDialog1.Title = "Save Map As.."
        '
<<<<<<< HEAD
        'StartPointCheck
        '
        Me.StartPointCheck.AutoSize = True
        Me.StartPointCheck.Checked = True
        Me.StartPointCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StartPointCheck.Location = New System.Drawing.Point(141, 87)
        Me.StartPointCheck.Name = "StartPointCheck"
        Me.StartPointCheck.Size = New System.Drawing.Size(75, 17)
        Me.StartPointCheck.TabIndex = 13
        Me.StartPointCheck.Text = "Start Point"
        Me.StartPointCheck.UseVisualStyleBackColor = True
        '
        'WallCheck
        '
        Me.WallCheck.AutoSize = True
        Me.WallCheck.Location = New System.Drawing.Point(141, 110)
=======
        'WallCheck
        '
        Me.WallCheck.AutoSize = True
        Me.WallCheck.Location = New System.Drawing.Point(816, 278)
>>>>>>> Edit
        Me.WallCheck.Name = "WallCheck"
        Me.WallCheck.Size = New System.Drawing.Size(47, 17)
        Me.WallCheck.TabIndex = 14
        Me.WallCheck.Text = "Wall"
        Me.WallCheck.UseVisualStyleBackColor = True
        '
        'LockedDoorCheck
        '
        Me.LockedDoorCheck.AutoSize = True
<<<<<<< HEAD
        Me.LockedDoorCheck.Location = New System.Drawing.Point(141, 133)
=======
        Me.LockedDoorCheck.Location = New System.Drawing.Point(816, 301)
>>>>>>> Edit
        Me.LockedDoorCheck.Name = "LockedDoorCheck"
        Me.LockedDoorCheck.Size = New System.Drawing.Size(88, 17)
        Me.LockedDoorCheck.TabIndex = 15
        Me.LockedDoorCheck.Text = "Locked Door"
        Me.LockedDoorCheck.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
<<<<<<< HEAD
        Me.TextBox3.Location = New System.Drawing.Point(1024, 14)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(147, 20)
=======
        Me.TextBox3.Location = New System.Drawing.Point(804, 14)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(87, 20)
>>>>>>> Edit
        Me.TextBox3.TabIndex = 16
        Me.TextBox3.Text = "StartPoint Set at:"
        '
        'StartPointDisp
        '
<<<<<<< HEAD
        Me.StartPointDisp.Location = New System.Drawing.Point(1024, 37)
        Me.StartPointDisp.Name = "StartPointDisp"
        Me.StartPointDisp.Size = New System.Drawing.Size(147, 20)
=======
        Me.StartPointDisp.Location = New System.Drawing.Point(897, 14)
        Me.StartPointDisp.Name = "StartPointDisp"
        Me.StartPointDisp.Size = New System.Drawing.Size(124, 20)
>>>>>>> Edit
        Me.StartPointDisp.TabIndex = 17
        '
        'WallsListDisp
        '
<<<<<<< HEAD
        Me.WallsListDisp.Location = New System.Drawing.Point(1024, 63)
        Me.WallsListDisp.Multiline = True
        Me.WallsListDisp.Name = "WallsListDisp"
        Me.WallsListDisp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.WallsListDisp.Size = New System.Drawing.Size(147, 294)
        Me.WallsListDisp.TabIndex = 19
        Me.WallsListDisp.Text = "Walls Set at:"
        '
        'DoorsListDisp
        '
        Me.DoorsListDisp.Location = New System.Drawing.Point(1024, 363)
        Me.DoorsListDisp.Multiline = True
        Me.DoorsListDisp.Name = "DoorsListDisp"
        Me.DoorsListDisp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DoorsListDisp.Size = New System.Drawing.Size(147, 278)
        Me.DoorsListDisp.TabIndex = 21
        Me.DoorsListDisp.Text = "Doors Set at:"
=======
        Me.WallsListDisp.Location = New System.Drawing.Point(804, 40)
        Me.WallsListDisp.Multiline = True
        Me.WallsListDisp.Name = "WallsListDisp"
        Me.WallsListDisp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.WallsListDisp.Size = New System.Drawing.Size(100, 96)
        Me.WallsListDisp.TabIndex = 19
        Me.WallsListDisp.Text = "Walls Set at:"
        '
        'LockedDoorsListDisp
        '
        Me.LockedDoorsListDisp.Location = New System.Drawing.Point(908, 40)
        Me.LockedDoorsListDisp.Multiline = True
        Me.LockedDoorsListDisp.Name = "LockedDoorsListDisp"
        Me.LockedDoorsListDisp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LockedDoorsListDisp.Size = New System.Drawing.Size(98, 96)
        Me.LockedDoorsListDisp.TabIndex = 21
        Me.LockedDoorsListDisp.Text = "Locked Doors Set at:"
>>>>>>> Edit
        '
        'Button_LoadMap
        '
        Me.Button_LoadMap.BackColor = System.Drawing.Color.DimGray
        Me.Button_LoadMap.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine
        Me.Button_LoadMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_LoadMap.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_LoadMap.ForeColor = System.Drawing.SystemColors.ControlText
<<<<<<< HEAD
        Me.Button_LoadMap.Location = New System.Drawing.Point(10, 605)
        Me.Button_LoadMap.Name = "Button_LoadMap"
        Me.Button_LoadMap.Size = New System.Drawing.Size(95, 36)
=======
        Me.Button_LoadMap.Location = New System.Drawing.Point(921, 411)
        Me.Button_LoadMap.Name = "Button_LoadMap"
        Me.Button_LoadMap.Size = New System.Drawing.Size(75, 36)
>>>>>>> Edit
        Me.Button_LoadMap.TabIndex = 22
        Me.Button_LoadMap.Text = "Load Map"
        Me.Button_LoadMap.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
<<<<<<< HEAD
=======
        'UnlockedDoorCheck
        '
        Me.UnlockedDoorCheck.AutoSize = True
        Me.UnlockedDoorCheck.Location = New System.Drawing.Point(816, 324)
        Me.UnlockedDoorCheck.Name = "UnlockedDoorCheck"
        Me.UnlockedDoorCheck.Size = New System.Drawing.Size(98, 17)
        Me.UnlockedDoorCheck.TabIndex = 23
        Me.UnlockedDoorCheck.Text = "Unlocked Door"
        Me.UnlockedDoorCheck.UseVisualStyleBackColor = True
        '
        'SpawnPointCheck
        '
        Me.SpawnPointCheck.AutoSize = True
        Me.SpawnPointCheck.Location = New System.Drawing.Point(816, 346)
        Me.SpawnPointCheck.Name = "SpawnPointCheck"
        Me.SpawnPointCheck.Size = New System.Drawing.Size(86, 17)
        Me.SpawnPointCheck.TabIndex = 24
        Me.SpawnPointCheck.Text = "Spawn Point"
        Me.SpawnPointCheck.UseVisualStyleBackColor = True
        '
        'UnlockedDoorsListDisp
        '
        Me.UnlockedDoorsListDisp.Location = New System.Drawing.Point(910, 142)
        Me.UnlockedDoorsListDisp.Multiline = True
        Me.UnlockedDoorsListDisp.Name = "UnlockedDoorsListDisp"
        Me.UnlockedDoorsListDisp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.UnlockedDoorsListDisp.Size = New System.Drawing.Size(98, 96)
        Me.UnlockedDoorsListDisp.TabIndex = 26
        Me.UnlockedDoorsListDisp.Text = "Unlocked Doors Set at:"
        '
        'SpawnListDisp
        '
        Me.SpawnListDisp.Location = New System.Drawing.Point(806, 142)
        Me.SpawnListDisp.Multiline = True
        Me.SpawnListDisp.Name = "SpawnListDisp"
        Me.SpawnListDisp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SpawnListDisp.Size = New System.Drawing.Size(100, 96)
        Me.SpawnListDisp.TabIndex = 25
        Me.SpawnListDisp.Text = "Spawners Set at:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(816, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Show Properties"
        Me.Button1.UseVisualStyleBackColor = True
        '
>>>>>>> Edit
        'MapEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(1200, 653)
        Me.Controls.Add(Me.Button_LoadMap)
        Me.Controls.Add(Me.DoorsListDisp)
        Me.Controls.Add(Me.WallsListDisp)
        Me.Controls.Add(Me.StartPointDisp)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.LockedDoorCheck)
        Me.Controls.Add(Me.WallCheck)
        Me.Controls.Add(Me.StartPointCheck)
        Me.Controls.Add(Me.Buttom_SaveMap)
        Me.Controls.Add(Me.TilePanel)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Options_Borders)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.InitialiseMap)
        Me.Controls.Add(Me.Option_Overworld)
        Me.Controls.Add(Me.Option_Town)
        Me.Controls.Add(Me.Option_Room)
=======
        Me.ClientSize = New System.Drawing.Size(1018, 653)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UnlockedDoorsListDisp)
        Me.Controls.Add(Me.SpawnListDisp)
        Me.Controls.Add(Me.SpawnPointCheck)
        Me.Controls.Add(Me.UnlockedDoorCheck)
        Me.Controls.Add(Me.Button_LoadMap)
        Me.Controls.Add(Me.Button_SaveMap)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Option_Room)
        Me.Controls.Add(Me.LockedDoorCheck)
        Me.Controls.Add(Me.Option_Town)
        Me.Controls.Add(Me.StartPointCheck)
        Me.Controls.Add(Me.Option_Overworld)
        Me.Controls.Add(Me.LockedDoorsListDisp)
        Me.Controls.Add(Me.WallsListDisp)
        Me.Controls.Add(Me.StartPointDisp)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.WallCheck)
        Me.Controls.Add(Me.InitialiseMap)
>>>>>>> Edit
        Me.Controls.Add(Me.Panel_MapDisplay)
        Me.Name = "MapEditor"
        Me.Text = "MapEditor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_MapDisplay As Panel
    Friend WithEvents Option_Room As RadioButton
    Friend WithEvents Option_Town As RadioButton
    Friend WithEvents Option_Overworld As RadioButton
    Friend WithEvents InitialiseMap As Button
    Friend WithEvents TextBox1 As TextBox
<<<<<<< HEAD
    Friend WithEvents Options_Borders As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TilePanel As Panel
    Friend WithEvents Buttom_SaveMap As Button
=======
    Friend WithEvents Button_SaveMap As Button
>>>>>>> Edit
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents StartPointCheck As CheckBox
    Friend WithEvents WallCheck As CheckBox
    Friend WithEvents LockedDoorCheck As CheckBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents StartPointDisp As TextBox
    Friend WithEvents WallsListDisp As TextBox
<<<<<<< HEAD
    Friend WithEvents DoorsListDisp As TextBox
    Friend WithEvents Button_LoadMap As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
=======
    Friend WithEvents LockedDoorsListDisp As TextBox
    Friend WithEvents Button_LoadMap As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents UnlockedDoorCheck As CheckBox
    Friend WithEvents SpawnPointCheck As CheckBox
    Friend WithEvents UnlockedDoorsListDisp As TextBox
    Friend WithEvents SpawnListDisp As TextBox
    Friend WithEvents Button1 As Button
>>>>>>> Edit
End Class
