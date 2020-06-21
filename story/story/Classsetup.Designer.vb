<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Classetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Classetup))
        Me.Classsetuplabel = New System.Windows.Forms.Label()
        Me.Classsetupinstructions = New System.Windows.Forms.Label()
        Me.Listclasses1 = New System.Windows.Forms.Label()
        Me.classeslist2 = New System.Windows.Forms.Label()
        Me.classeslist3 = New System.Windows.Forms.Label()
        Me.Chooseclasslabel = New System.Windows.Forms.Label()
        Me.pClass = New System.Windows.Forms.TextBox()
        Me.ClassRandomizer = New System.Windows.Forms.Button()
        Me.Chooseclasspanel = New System.Windows.Forms.Panel()
        Me.Owta = New System.Windows.Forms.Button()
        Me.classwarn = New System.Windows.Forms.Label()
        Me.backbuttoncs = New System.Windows.Forms.Button()
        Me.Guldan = New System.Windows.Forms.PictureBox()
        Me.Classlistspanel = New System.Windows.Forms.Panel()
        Me.Classesoptions = New System.Windows.Forms.Label()
        Me.Chooseclasspanel.SuspendLayout()
        CType(Me.Guldan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Classlistspanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Classsetuplabel
        '
        Me.Classsetuplabel.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Classsetuplabel.ForeColor = System.Drawing.Color.Goldenrod
        Me.Classsetuplabel.Location = New System.Drawing.Point(250, 29)
        Me.Classsetuplabel.Name = "Classsetuplabel"
        Me.Classsetuplabel.Size = New System.Drawing.Size(451, 77)
        Me.Classsetuplabel.TabIndex = 0
        Me.Classsetuplabel.Text = "Class Setup"
        Me.Classsetuplabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Classsetupinstructions
        '
        Me.Classsetupinstructions.Font = New System.Drawing.Font("Poor Richard", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Classsetupinstructions.ForeColor = System.Drawing.Color.Goldenrod
        Me.Classsetupinstructions.Location = New System.Drawing.Point(96, 107)
        Me.Classsetupinstructions.Name = "Classsetupinstructions"
        Me.Classsetupinstructions.Size = New System.Drawing.Size(832, 118)
        Me.Classsetupinstructions.TabIndex = 2
        Me.Classsetupinstructions.Text = resources.GetString("Classsetupinstructions.Text")
        '
        'Listclasses1
        '
        Me.Listclasses1.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Listclasses1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Listclasses1.Location = New System.Drawing.Point(36, 0)
        Me.Listclasses1.Name = "Listclasses1"
        Me.Listclasses1.Size = New System.Drawing.Size(127, 109)
        Me.Listclasses1.TabIndex = 3
        Me.Listclasses1.Text = "- Mage " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Shaman" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Priest       "
        '
        'classeslist2
        '
        Me.classeslist2.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classeslist2.ForeColor = System.Drawing.Color.Goldenrod
        Me.classeslist2.Location = New System.Drawing.Point(146, 0)
        Me.classeslist2.Name = "classeslist2"
        Me.classeslist2.Size = New System.Drawing.Size(127, 109)
        Me.classeslist2.TabIndex = 4
        Me.classeslist2.Text = "- Warlock" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Rogue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Warrior "
        '
        'classeslist3
        '
        Me.classeslist3.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classeslist3.ForeColor = System.Drawing.Color.Goldenrod
        Me.classeslist3.Location = New System.Drawing.Point(279, 0)
        Me.classeslist3.Name = "classeslist3"
        Me.classeslist3.Size = New System.Drawing.Size(127, 109)
        Me.classeslist3.TabIndex = 5
        Me.classeslist3.Text = "- Hunter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Druid" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Paladin     "
        '
        'Chooseclasslabel
        '
        Me.Chooseclasslabel.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chooseclasslabel.ForeColor = System.Drawing.Color.Goldenrod
        Me.Chooseclasslabel.Location = New System.Drawing.Point(26, 35)
        Me.Chooseclasslabel.Name = "Chooseclasslabel"
        Me.Chooseclasslabel.Size = New System.Drawing.Size(214, 43)
        Me.Chooseclasslabel.TabIndex = 6
        Me.Chooseclasslabel.Text = "Choose a class: "
        '
        'pClass
        '
        Me.pClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pClass.Location = New System.Drawing.Point(246, 39)
        Me.pClass.Name = "pClass"
        Me.pClass.Size = New System.Drawing.Size(303, 26)
        Me.pClass.TabIndex = 7
        '
        'ClassRandomizer
        '
        Me.ClassRandomizer.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClassRandomizer.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassRandomizer.ForeColor = System.Drawing.Color.Goldenrod
        Me.ClassRandomizer.Location = New System.Drawing.Point(293, 71)
        Me.ClassRandomizer.Name = "ClassRandomizer"
        Me.ClassRandomizer.Size = New System.Drawing.Size(204, 50)
        Me.ClassRandomizer.TabIndex = 8
        Me.ClassRandomizer.Text = "Class Randomizer"
        Me.ClassRandomizer.UseVisualStyleBackColor = False
        '
        'Chooseclasspanel
        '
        Me.Chooseclasspanel.Controls.Add(Me.ClassRandomizer)
        Me.Chooseclasspanel.Controls.Add(Me.pClass)
        Me.Chooseclasspanel.Controls.Add(Me.Chooseclasslabel)
        Me.Chooseclasspanel.Location = New System.Drawing.Point(12, 378)
        Me.Chooseclasspanel.Name = "Chooseclasspanel"
        Me.Chooseclasspanel.Size = New System.Drawing.Size(604, 135)
        Me.Chooseclasspanel.TabIndex = 9
        '
        'Owta
        '
        Me.Owta.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Owta.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Owta.ForeColor = System.Drawing.Color.Goldenrod
        Me.Owta.Location = New System.Drawing.Point(678, 566)
        Me.Owta.Name = "Owta"
        Me.Owta.Size = New System.Drawing.Size(300, 100)
        Me.Owta.TabIndex = 10
        Me.Owta.Text = "On with the adventure!"
        Me.Owta.UseVisualStyleBackColor = False
        '
        'classwarn
        '
        Me.classwarn.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classwarn.ForeColor = System.Drawing.Color.Red
        Me.classwarn.Location = New System.Drawing.Point(220, 496)
        Me.classwarn.Name = "classwarn"
        Me.classwarn.Size = New System.Drawing.Size(652, 58)
        Me.classwarn.TabIndex = 11
        Me.classwarn.Text = "You need a class to continue"
        Me.classwarn.Visible = False
        '
        'backbuttoncs
        '
        Me.backbuttoncs.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.backbuttoncs.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backbuttoncs.ForeColor = System.Drawing.Color.Goldenrod
        Me.backbuttoncs.Location = New System.Drawing.Point(372, 566)
        Me.backbuttoncs.Name = "backbuttoncs"
        Me.backbuttoncs.Size = New System.Drawing.Size(300, 100)
        Me.backbuttoncs.TabIndex = 12
        Me.backbuttoncs.Text = "Go Back!"
        Me.backbuttoncs.UseVisualStyleBackColor = False
        '
        'Guldan
        '
        Me.Guldan.Image = CType(resources.GetObject("Guldan.Image"), System.Drawing.Image)
        Me.Guldan.Location = New System.Drawing.Point(622, 195)
        Me.Guldan.Name = "Guldan"
        Me.Guldan.Size = New System.Drawing.Size(355, 304)
        Me.Guldan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guldan.TabIndex = 13
        Me.Guldan.TabStop = False
        '
        'Classlistspanel
        '
        Me.Classlistspanel.Controls.Add(Me.classeslist2)
        Me.Classlistspanel.Controls.Add(Me.Listclasses1)
        Me.Classlistspanel.Controls.Add(Me.classeslist3)
        Me.Classlistspanel.Location = New System.Drawing.Point(125, 272)
        Me.Classlistspanel.Name = "Classlistspanel"
        Me.Classlistspanel.Size = New System.Drawing.Size(436, 100)
        Me.Classlistspanel.TabIndex = 14
        '
        'Classesoptions
        '
        Me.Classesoptions.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Classesoptions.ForeColor = System.Drawing.Color.Goldenrod
        Me.Classesoptions.Location = New System.Drawing.Point(205, 231)
        Me.Classesoptions.Name = "Classesoptions"
        Me.Classesoptions.Size = New System.Drawing.Size(279, 41)
        Me.Classesoptions.TabIndex = 15
        Me.Classesoptions.Text = "Classes:"
        Me.Classesoptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Classetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(990, 678)
        Me.Controls.Add(Me.Classesoptions)
        Me.Controls.Add(Me.Guldan)
        Me.Controls.Add(Me.backbuttoncs)
        Me.Controls.Add(Me.classwarn)
        Me.Controls.Add(Me.Owta)
        Me.Controls.Add(Me.Chooseclasspanel)
        Me.Controls.Add(Me.Classsetupinstructions)
        Me.Controls.Add(Me.Classsetuplabel)
        Me.Controls.Add(Me.Classlistspanel)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Classetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Class setup"
        Me.Chooseclasspanel.ResumeLayout(False)
        Me.Chooseclasspanel.PerformLayout()
        CType(Me.Guldan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Classlistspanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Classsetuplabel As Label
    Friend WithEvents Classsetupinstructions As Label
    Friend WithEvents Listclasses1 As Label
    Friend WithEvents classeslist2 As Label
    Friend WithEvents classeslist3 As Label
    Friend WithEvents Chooseclasslabel As Label
    Friend WithEvents pClass As TextBox
    Friend WithEvents ClassRandomizer As Button
    Friend WithEvents Chooseclasspanel As Panel
    Friend WithEvents Owta As Button
    Friend WithEvents classwarn As Label
    Friend WithEvents backbuttoncs As Button
    Friend WithEvents Guldan As PictureBox
    Friend WithEvents Classlistspanel As Panel
    Friend WithEvents Classesoptions As Label
End Class
