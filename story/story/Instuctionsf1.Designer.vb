<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instructionsf1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Instructionsf1))
        Me.instructionslabelf1 = New System.Windows.Forms.Label()
        Me.instructionsf1img = New System.Windows.Forms.PictureBox()
        Me.Instructionsf1title = New System.Windows.Forms.Label()
        Me.Backinstructionsf1 = New System.Windows.Forms.Button()
        CType(Me.instructionsf1img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'instructionslabelf1
        '
        Me.instructionslabelf1.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.instructionslabelf1.ForeColor = System.Drawing.Color.Goldenrod
        Me.instructionslabelf1.Location = New System.Drawing.Point(95, 74)
        Me.instructionslabelf1.Name = "instructionslabelf1"
        Me.instructionslabelf1.Size = New System.Drawing.Size(872, 287)
        Me.instructionslabelf1.TabIndex = 0
        Me.instructionslabelf1.Text = resources.GetString("instructionslabelf1.Text")
        '
        'instructionsf1img
        '
        Me.instructionsf1img.Image = CType(resources.GetObject("instructionsf1img.Image"), System.Drawing.Image)
        Me.instructionsf1img.Location = New System.Drawing.Point(48, 299)
        Me.instructionsf1img.Name = "instructionsf1img"
        Me.instructionsf1img.Size = New System.Drawing.Size(529, 367)
        Me.instructionsf1img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.instructionsf1img.TabIndex = 1
        Me.instructionsf1img.TabStop = False
        '
        'Instructionsf1title
        '
        Me.Instructionsf1title.AutoSize = True
        Me.Instructionsf1title.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Instructionsf1title.ForeColor = System.Drawing.Color.Goldenrod
        Me.Instructionsf1title.Location = New System.Drawing.Point(369, 9)
        Me.Instructionsf1title.Name = "Instructionsf1title"
        Me.Instructionsf1title.Size = New System.Drawing.Size(291, 65)
        Me.Instructionsf1title.TabIndex = 2
        Me.Instructionsf1title.Text = "Instructions"
        Me.Instructionsf1title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Backinstructionsf1
        '
        Me.Backinstructionsf1.BackColor = System.Drawing.Color.Black
        Me.Backinstructionsf1.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Backinstructionsf1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Backinstructionsf1.Location = New System.Drawing.Point(678, 566)
        Me.Backinstructionsf1.Name = "Backinstructionsf1"
        Me.Backinstructionsf1.Size = New System.Drawing.Size(300, 100)
        Me.Backinstructionsf1.TabIndex = 3
        Me.Backinstructionsf1.Text = "Back"
        Me.Backinstructionsf1.UseVisualStyleBackColor = False
        '
        'Instructionsf1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(990, 678)
        Me.Controls.Add(Me.Backinstructionsf1)
        Me.Controls.Add(Me.Instructionsf1title)
        Me.Controls.Add(Me.instructionsf1img)
        Me.Controls.Add(Me.instructionslabelf1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Instructionsf1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instructions"
        CType(Me.instructionsf1img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents instructionslabelf1 As Label
    Friend WithEvents instructionsf1img As PictureBox
    Friend WithEvents Instructionsf1title As Label
    Friend WithEvents Backinstructionsf1 As Button
End Class
