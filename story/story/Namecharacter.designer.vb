<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Nameform0
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nameform0))
        Me.Namelabel = New System.Windows.Forms.Label()
        Me.pname = New System.Windows.Forms.TextBox()
        Me.Randomname = New System.Windows.Forms.Button()
        Me.Nameinstructions = New System.Windows.Forms.Label()
        Me.Nextbuttonname = New System.Windows.Forms.Button()
        Me.Enterwarn = New System.Windows.Forms.Label()
        Me.Garroshimg1 = New System.Windows.Forms.PictureBox()
        Me.Namepanel = New System.Windows.Forms.Panel()
        Me.Namecharactertitle = New System.Windows.Forms.Label()
        CType(Me.Garroshimg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Namepanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Namelabel
        '
        Me.Namelabel.AutoSize = True
        Me.Namelabel.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Namelabel.ForeColor = System.Drawing.Color.Goldenrod
        Me.Namelabel.Location = New System.Drawing.Point(3, 34)
        Me.Namelabel.Name = "Namelabel"
        Me.Namelabel.Size = New System.Drawing.Size(207, 28)
        Me.Namelabel.TabIndex = 0
        Me.Namelabel.Text = "Please Pick a Name:"
        '
        'pname
        '
        Me.pname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pname.Location = New System.Drawing.Point(247, 34)
        Me.pname.Name = "pname"
        Me.pname.Size = New System.Drawing.Size(286, 26)
        Me.pname.TabIndex = 1
        '
        'Randomname
        '
        Me.Randomname.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Randomname.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Randomname.ForeColor = System.Drawing.Color.Goldenrod
        Me.Randomname.Location = New System.Drawing.Point(284, 66)
        Me.Randomname.Name = "Randomname"
        Me.Randomname.Size = New System.Drawing.Size(204, 50)
        Me.Randomname.TabIndex = 2
        Me.Randomname.Text = "Name Randomizer"
        Me.Randomname.UseVisualStyleBackColor = False
        '
        'Nameinstructions
        '
        Me.Nameinstructions.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nameinstructions.ForeColor = System.Drawing.Color.Goldenrod
        Me.Nameinstructions.Location = New System.Drawing.Point(12, 78)
        Me.Nameinstructions.Name = "Nameinstructions"
        Me.Nameinstructions.Size = New System.Drawing.Size(944, 181)
        Me.Nameinstructions.TabIndex = 3
        Me.Nameinstructions.Text = resources.GetString("Nameinstructions.Text")
        '
        'Nextbuttonname
        '
        Me.Nextbuttonname.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Nextbuttonname.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nextbuttonname.ForeColor = System.Drawing.Color.Goldenrod
        Me.Nextbuttonname.Location = New System.Drawing.Point(678, 557)
        Me.Nextbuttonname.Name = "Nextbuttonname"
        Me.Nextbuttonname.Size = New System.Drawing.Size(300, 100)
        Me.Nextbuttonname.TabIndex = 4
        Me.Nextbuttonname.Text = "Next!"
        Me.Nextbuttonname.UseVisualStyleBackColor = False
        '
        'Enterwarn
        '
        Me.Enterwarn.BackColor = System.Drawing.Color.Black
        Me.Enterwarn.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enterwarn.ForeColor = System.Drawing.Color.Red
        Me.Enterwarn.Location = New System.Drawing.Point(617, 370)
        Me.Enterwarn.Name = "Enterwarn"
        Me.Enterwarn.Size = New System.Drawing.Size(387, 136)
        Me.Enterwarn.TabIndex = 5
        Me.Enterwarn.Text = "You need a name man..."
        Me.Enterwarn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Enterwarn.Visible = False
        '
        'Garroshimg1
        '
        Me.Garroshimg1.Image = CType(resources.GetObject("Garroshimg1.Image"), System.Drawing.Image)
        Me.Garroshimg1.Location = New System.Drawing.Point(33, 386)
        Me.Garroshimg1.Name = "Garroshimg1"
        Me.Garroshimg1.Size = New System.Drawing.Size(568, 280)
        Me.Garroshimg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Garroshimg1.TabIndex = 7
        Me.Garroshimg1.TabStop = False
        '
        'Namepanel
        '
        Me.Namepanel.Controls.Add(Me.Randomname)
        Me.Namepanel.Controls.Add(Me.pname)
        Me.Namepanel.Controls.Add(Me.Namelabel)
        Me.Namepanel.Location = New System.Drawing.Point(208, 265)
        Me.Namepanel.Name = "Namepanel"
        Me.Namepanel.Size = New System.Drawing.Size(571, 118)
        Me.Namepanel.TabIndex = 8
        '
        'Namecharactertitle
        '
        Me.Namecharactertitle.AutoSize = True
        Me.Namecharactertitle.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Namecharactertitle.ForeColor = System.Drawing.Color.Goldenrod
        Me.Namecharactertitle.Location = New System.Drawing.Point(231, -2)
        Me.Namecharactertitle.Name = "Namecharactertitle"
        Me.Namecharactertitle.Size = New System.Drawing.Size(510, 65)
        Me.Namecharactertitle.TabIndex = 9
        Me.Namecharactertitle.Text = "Name Your Character!"
        Me.Namecharactertitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Nameform0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(990, 678)
        Me.Controls.Add(Me.Namecharactertitle)
        Me.Controls.Add(Me.Garroshimg1)
        Me.Controls.Add(Me.Namepanel)
        Me.Controls.Add(Me.Nextbuttonname)
        Me.Controls.Add(Me.Nameinstructions)
        Me.Controls.Add(Me.Enterwarn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Nameform0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "World of Warcraft story"
        CType(Me.Garroshimg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Namepanel.ResumeLayout(False)
        Me.Namepanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Namelabel As Label
    Friend WithEvents pname As TextBox
    Friend WithEvents Randomname As Button
    Friend WithEvents Nameinstructions As Label
    Friend WithEvents Nextbuttonname As Button
    Friend WithEvents Enterwarn As Label
    Friend WithEvents Garroshimg1 As PictureBox
    Friend WithEvents Namepanel As Panel
    Friend WithEvents Namecharactertitle As Label
End Class
