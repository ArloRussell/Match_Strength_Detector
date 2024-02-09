<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Match_Strength_Detector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Match_Strength_Detector))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPerson1 = New System.Windows.Forms.TextBox()
        Me.txtPerson2 = New System.Windows.Forms.TextBox()
        Me.btnDetermineStrength = New System.Windows.Forms.Button()
        Me.lblPeopleMath = New System.Windows.Forms.Label()
        Me.lblMatchStrength = New System.Windows.Forms.Label()
        Me.picimage = New System.Windows.Forms.PictureBox()
        CType(Me.picimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(72, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Person 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(441, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Person 2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palace Script MT", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(272, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 60)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Love Detector"
        '
        'txtPerson1
        '
        Me.txtPerson1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPerson1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPerson1.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerson1.Location = New System.Drawing.Point(178, 68)
        Me.txtPerson1.Name = "txtPerson1"
        Me.txtPerson1.Size = New System.Drawing.Size(158, 38)
        Me.txtPerson1.TabIndex = 4
        '
        'txtPerson2
        '
        Me.txtPerson2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPerson2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPerson2.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPerson2.Location = New System.Drawing.Point(547, 68)
        Me.txtPerson2.Name = "txtPerson2"
        Me.txtPerson2.Size = New System.Drawing.Size(158, 38)
        Me.txtPerson2.TabIndex = 5
        '
        'btnDetermineStrength
        '
        Me.btnDetermineStrength.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDetermineStrength.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetermineStrength.Location = New System.Drawing.Point(196, 146)
        Me.btnDetermineStrength.Name = "btnDetermineStrength"
        Me.btnDetermineStrength.Size = New System.Drawing.Size(373, 43)
        Me.btnDetermineStrength.TabIndex = 6
        Me.btnDetermineStrength.Text = "Determine Strength"
        Me.btnDetermineStrength.UseVisualStyleBackColor = False
        '
        'lblPeopleMath
        '
        Me.lblPeopleMath.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeopleMath.ForeColor = System.Drawing.Color.Maroon
        Me.lblPeopleMath.Location = New System.Drawing.Point(77, 208)
        Me.lblPeopleMath.Name = "lblPeopleMath"
        Me.lblPeopleMath.Size = New System.Drawing.Size(628, 42)
        Me.lblPeopleMath.TabIndex = 7
        Me.lblPeopleMath.Text = "Person1 + Person2"
        Me.lblPeopleMath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPeopleMath.Visible = False
        '
        'lblMatchStrength
        '
        Me.lblMatchStrength.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatchStrength.ForeColor = System.Drawing.Color.Maroon
        Me.lblMatchStrength.Location = New System.Drawing.Point(77, 392)
        Me.lblMatchStrength.Name = "lblMatchStrength"
        Me.lblMatchStrength.Size = New System.Drawing.Size(628, 42)
        Me.lblMatchStrength.TabIndex = 8
        Me.lblMatchStrength.Text = "Match Outcome"
        Me.lblMatchStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMatchStrength.Visible = False
        '
        'picimage
        '
        Me.picimage.Location = New System.Drawing.Point(244, 253)
        Me.picimage.Name = "picimage"
        Me.picimage.Size = New System.Drawing.Size(297, 136)
        Me.picimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picimage.TabIndex = 9
        Me.picimage.TabStop = False
        '
        'Match_Strength_Detector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(765, 443)
        Me.Controls.Add(Me.picimage)
        Me.Controls.Add(Me.lblMatchStrength)
        Me.Controls.Add(Me.lblPeopleMath)
        Me.Controls.Add(Me.btnDetermineStrength)
        Me.Controls.Add(Me.txtPerson2)
        Me.Controls.Add(Me.txtPerson1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Match_Strength_Detector"
        Me.Text = "Love Detector"
        CType(Me.picimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPerson1 As TextBox
    Friend WithEvents txtPerson2 As TextBox
    Friend WithEvents btnDetermineStrength As Button
    Friend WithEvents lblPeopleMath As Label
    Friend WithEvents lblMatchStrength As Label
    Friend WithEvents picimage As PictureBox
End Class
