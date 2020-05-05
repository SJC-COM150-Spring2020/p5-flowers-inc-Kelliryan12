<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.lblFlowersInc = New System.Windows.Forms.Label()
        Me.picFlower2 = New System.Windows.Forms.PictureBox()
        Me.picFlower1 = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblWelcome2 = New System.Windows.Forms.Label()
        Me.lblMission1 = New System.Windows.Forms.Label()
        Me.lblMission2 = New System.Windows.Forms.Label()
        Me.lblQuiz = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picFlower2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlower1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFlowersInc
        '
        Me.lblFlowersInc.AutoSize = True
        Me.lblFlowersInc.Font = New System.Drawing.Font("Modern No. 20", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlowersInc.Location = New System.Drawing.Point(296, 27)
        Me.lblFlowersInc.Name = "lblFlowersInc"
        Me.lblFlowersInc.Size = New System.Drawing.Size(361, 65)
        Me.lblFlowersInc.TabIndex = 0
        Me.lblFlowersInc.Text = "Flowers Inc."
        '
        'picFlower2
        '
        Me.picFlower2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFlower2.Image = CType(resources.GetObject("picFlower2.Image"), System.Drawing.Image)
        Me.picFlower2.Location = New System.Drawing.Point(736, 27)
        Me.picFlower2.Name = "picFlower2"
        Me.picFlower2.Size = New System.Drawing.Size(101, 65)
        Me.picFlower2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlower2.TabIndex = 1
        Me.picFlower2.TabStop = False
        '
        'picFlower1
        '
        Me.picFlower1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFlower1.Image = CType(resources.GetObject("picFlower1.Image"), System.Drawing.Image)
        Me.picFlower1.Location = New System.Drawing.Point(109, 27)
        Me.picFlower1.Name = "picFlower1"
        Me.picFlower1.Size = New System.Drawing.Size(102, 65)
        Me.picFlower1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlower1.TabIndex = 2
        Me.picFlower1.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(333, 128)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(264, 23)
        Me.lblWelcome.TabIndex = 4
        Me.lblWelcome.Text = "Welcome to Flowers Incorporated!"
        '
        'lblWelcome2
        '
        Me.lblWelcome2.AutoSize = True
        Me.lblWelcome2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome2.Location = New System.Drawing.Point(79, 151)
        Me.lblWelcome2.Name = "lblWelcome2"
        Me.lblWelcome2.Size = New System.Drawing.Size(800, 23)
        Me.lblWelcome2.TabIndex = 5
        Me.lblWelcome2.Text = "We Deliver the Best Flowers Services in the Country and Would Love to Help You Fi" &
    "nd the Perfect Flowers." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblMission1
        '
        Me.lblMission1.AutoSize = True
        Me.lblMission1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMission1.Location = New System.Drawing.Point(385, 193)
        Me.lblMission1.Name = "lblMission1"
        Me.lblMission1.Size = New System.Drawing.Size(160, 19)
        Me.lblMission1.TabIndex = 6
        Me.lblMission1.Text = "Our Mission Statement:"
        '
        'lblMission2
        '
        Me.lblMission2.AutoSize = True
        Me.lblMission2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMission2.Location = New System.Drawing.Point(80, 212)
        Me.lblMission2.Name = "lblMission2"
        Me.lblMission2.Size = New System.Drawing.Size(791, 48)
        Me.lblMission2.TabIndex = 7
        Me.lblMission2.Text = resources.GetString("lblMission2.Text")
        '
        'lblQuiz
        '
        Me.lblQuiz.AutoSize = True
        Me.lblQuiz.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuiz.Location = New System.Drawing.Point(34, 310)
        Me.lblQuiz.Name = "lblQuiz"
        Me.lblQuiz.Size = New System.Drawing.Size(845, 42)
        Me.lblQuiz.TabIndex = 8
        Me.lblQuiz.Text = "PLEASE CLICK THE BUTTON BELOW TO TAKE THE QUIZ AND FIND OUT WHAT YOUR FAVORITE FL" &
    "OWER " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                                  SAYS ABOUT YOU!"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(401, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 30)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Take the Quiz"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(401, 479)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 30)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Create My Bouquet"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 434)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(453, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "CLICK THE BUTTON BELOW TO CREATE YOUR BOUQUET!"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(923, 538)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblQuiz)
        Me.Controls.Add(Me.lblMission2)
        Me.Controls.Add(Me.lblMission1)
        Me.Controls.Add(Me.lblWelcome2)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.picFlower1)
        Me.Controls.Add(Me.picFlower2)
        Me.Controls.Add(Me.lblFlowersInc)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        CType(Me.picFlower2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlower1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFlowersInc As Label
    Friend WithEvents picFlower2 As PictureBox
    Friend WithEvents picFlower1 As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblWelcome2 As Label
    Friend WithEvents lblMission1 As Label
    Friend WithEvents lblMission2 As Label
    Friend WithEvents lblQuiz As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
End Class
