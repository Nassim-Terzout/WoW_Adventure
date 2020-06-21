<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcomeform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcomeform))
        Me.Northshiremap = New System.Windows.Forms.PictureBox()
        Me.textforchp1 = New System.Windows.Forms.Label()
        Me.BurningSteppes = New System.Windows.Forms.RadioButton()
        Me.Goldshire = New System.Windows.Forms.RadioButton()
        Me.Letsgo = New System.Windows.Forms.Button()
        Me.northshireexit = New System.Windows.Forms.Button()
        Me.Northshirerestart = New System.Windows.Forms.Button()
        Me.Northshirehelp = New System.Windows.Forms.Button()
        Me.Helplabelnorthshire = New System.Windows.Forms.Label()
        CType(Me.Northshiremap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Northshiremap
        '
        Me.Northshiremap.Image = CType(resources.GetObject("Northshiremap.Image"), System.Drawing.Image)
        Me.Northshiremap.Location = New System.Drawing.Point(12, 12)
        Me.Northshiremap.Name = "Northshiremap"
        Me.Northshiremap.Size = New System.Drawing.Size(704, 468)
        Me.Northshiremap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Northshiremap.TabIndex = 0
        Me.Northshiremap.TabStop = False
        '
        'textforchp1
        '
        Me.textforchp1.Font = New System.Drawing.Font("Poor Richard", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textforchp1.ForeColor = System.Drawing.Color.Goldenrod
        Me.textforchp1.Location = New System.Drawing.Point(8, 483)
        Me.textforchp1.Name = "textforchp1"
        Me.textforchp1.Size = New System.Drawing.Size(708, 112)
        Me.textforchp1.TabIndex = 1
        '
        'BurningSteppes
        '
        Me.BurningSteppes.AutoSize = True
        Me.BurningSteppes.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BurningSteppes.ForeColor = System.Drawing.Color.Goldenrod
        Me.BurningSteppes.Location = New System.Drawing.Point(12, 596)
        Me.BurningSteppes.Name = "BurningSteppes"
        Me.BurningSteppes.Size = New System.Drawing.Size(153, 26)
        Me.BurningSteppes.TabIndex = 2
        Me.BurningSteppes.TabStop = True
        Me.BurningSteppes.Text = "Burning Steppes"
        Me.BurningSteppes.UseVisualStyleBackColor = True
        '
        'Goldshire
        '
        Me.Goldshire.AutoSize = True
        Me.Goldshire.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Goldshire.ForeColor = System.Drawing.Color.Goldenrod
        Me.Goldshire.Location = New System.Drawing.Point(12, 619)
        Me.Goldshire.Name = "Goldshire"
        Me.Goldshire.Size = New System.Drawing.Size(102, 26)
        Me.Goldshire.TabIndex = 3
        Me.Goldshire.TabStop = True
        Me.Goldshire.Text = "Goldshire"
        Me.Goldshire.UseVisualStyleBackColor = True
        '
        'Letsgo
        '
        Me.Letsgo.BackColor = System.Drawing.SystemColors.ControlText
        Me.Letsgo.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Letsgo.ForeColor = System.Drawing.Color.Goldenrod
        Me.Letsgo.Location = New System.Drawing.Point(678, 566)
        Me.Letsgo.Name = "Letsgo"
        Me.Letsgo.Size = New System.Drawing.Size(300, 100)
        Me.Letsgo.TabIndex = 4
        Me.Letsgo.Text = "Let's Go!"
        Me.Letsgo.UseVisualStyleBackColor = False
        '
        'northshireexit
        '
        Me.northshireexit.BackColor = System.Drawing.SystemColors.ControlText
        Me.northshireexit.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.northshireexit.ForeColor = System.Drawing.Color.Goldenrod
        Me.northshireexit.Location = New System.Drawing.Point(722, 12)
        Me.northshireexit.Name = "northshireexit"
        Me.northshireexit.Size = New System.Drawing.Size(256, 86)
        Me.northshireexit.TabIndex = 12
        Me.northshireexit.Text = "Exit"
        Me.northshireexit.UseVisualStyleBackColor = False
        '
        'Northshirerestart
        '
        Me.Northshirerestart.BackColor = System.Drawing.SystemColors.ControlText
        Me.Northshirerestart.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Northshirerestart.ForeColor = System.Drawing.Color.Goldenrod
        Me.Northshirerestart.Location = New System.Drawing.Point(722, 104)
        Me.Northshirerestart.Name = "Northshirerestart"
        Me.Northshirerestart.Size = New System.Drawing.Size(256, 86)
        Me.Northshirerestart.TabIndex = 13
        Me.Northshirerestart.Text = "Restart"
        Me.Northshirerestart.UseVisualStyleBackColor = False
        '
        'Northshirehelp
        '
        Me.Northshirehelp.BackColor = System.Drawing.SystemColors.ControlText
        Me.Northshirehelp.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Northshirehelp.ForeColor = System.Drawing.Color.Goldenrod
        Me.Northshirehelp.Location = New System.Drawing.Point(722, 196)
        Me.Northshirehelp.Name = "Northshirehelp"
        Me.Northshirehelp.Size = New System.Drawing.Size(256, 86)
        Me.Northshirehelp.TabIndex = 14
        Me.Northshirehelp.Text = "Help"
        Me.Northshirehelp.UseVisualStyleBackColor = False
        '
        'Helplabelnorthshire
        '
        Me.Helplabelnorthshire.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Helplabelnorthshire.ForeColor = System.Drawing.Color.Goldenrod
        Me.Helplabelnorthshire.Location = New System.Drawing.Point(722, 293)
        Me.Helplabelnorthshire.Name = "Helplabelnorthshire"
        Me.Helplabelnorthshire.Size = New System.Drawing.Size(256, 187)
        Me.Helplabelnorthshire.TabIndex = 15
        Me.Helplabelnorthshire.Text = "Analyze the map and read the text below it. Based on what you've read choose an o" &
    "ption and hit the ""Let's Go!"" button."
        Me.Helplabelnorthshire.Visible = False
        '
        'Welcomeform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(990, 678)
        Me.Controls.Add(Me.Helplabelnorthshire)
        Me.Controls.Add(Me.Northshirehelp)
        Me.Controls.Add(Me.Northshirerestart)
        Me.Controls.Add(Me.northshireexit)
        Me.Controls.Add(Me.Letsgo)
        Me.Controls.Add(Me.Goldshire)
        Me.Controls.Add(Me.BurningSteppes)
        Me.Controls.Add(Me.textforchp1)
        Me.Controls.Add(Me.Northshiremap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Welcomeform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to Northshire!"
        CType(Me.Northshiremap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Northshiremap As PictureBox
    Friend WithEvents textforchp1 As Label
    Friend WithEvents BurningSteppes As RadioButton
    Friend WithEvents Goldshire As RadioButton
    Friend WithEvents Letsgo As Button
    Friend WithEvents northshireexit As Button
    Friend WithEvents Northshirerestart As Button
    Friend WithEvents Northshirehelp As Button
    Friend WithEvents Helplabelnorthshire As Label
End Class
