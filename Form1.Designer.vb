﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmShapeSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmShapeSelect))
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BtnTriangle = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnCircle = New System.Windows.Forms.Button()
        Me.BtnSquare = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(242, 358)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(360, 81)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'BtnTriangle
        '
        Me.BtnTriangle.BackColor = System.Drawing.Color.Gold
        Me.BtnTriangle.BackgroundImage = CType(resources.GetObject("BtnTriangle.BackgroundImage"), System.Drawing.Image)
        Me.BtnTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTriangle.FlatAppearance.BorderSize = 0
        Me.BtnTriangle.Location = New System.Drawing.Point(339, 167)
        Me.BtnTriangle.Name = "BtnTriangle"
        Me.BtnTriangle.Size = New System.Drawing.Size(150, 150)
        Me.BtnTriangle.TabIndex = 5
        Me.BtnTriangle.Tag = "triangle"
        Me.BtnTriangle.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Gold
        Me.BtnExit.BackgroundImage = CType(resources.GetObject("BtnExit.BackgroundImage"), System.Drawing.Image)
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExit.Location = New System.Drawing.Point(767, 12)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(50, 49)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnCircle
        '
        Me.BtnCircle.BackColor = System.Drawing.Color.Gold
        Me.BtnCircle.BackgroundImage = CType(resources.GetObject("BtnCircle.BackgroundImage"), System.Drawing.Image)
        Me.BtnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCircle.Location = New System.Drawing.Point(578, 167)
        Me.BtnCircle.Name = "BtnCircle"
        Me.BtnCircle.Size = New System.Drawing.Size(150, 150)
        Me.BtnCircle.TabIndex = 2
        Me.BtnCircle.Tag = "circle"
        Me.BtnCircle.UseVisualStyleBackColor = False
        '
        'BtnSquare
        '
        Me.BtnSquare.BackColor = System.Drawing.Color.Gold
        Me.BtnSquare.BackgroundImage = CType(resources.GetObject("BtnSquare.BackgroundImage"), System.Drawing.Image)
        Me.BtnSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSquare.FlatAppearance.BorderSize = 0
        Me.BtnSquare.Location = New System.Drawing.Point(91, 167)
        Me.BtnSquare.Name = "BtnSquare"
        Me.BtnSquare.Size = New System.Drawing.Size(150, 150)
        Me.BtnSquare.TabIndex = 0
        Me.BtnSquare.Tag = "square"
        Me.BtnSquare.UseVisualStyleBackColor = False
        '
        'FrmShapeSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(829, 580)
        Me.Controls.Add(Me.BtnTriangle)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.BtnCircle)
        Me.Controls.Add(Me.BtnSquare)
        Me.Name = "FrmShapeSelect"
        Me.Text = "Select your Shape"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSquare As Button
    Friend WithEvents BtnCircle As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnTriangle As Button
End Class
