<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quiz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Quiz))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpFavflower = New System.Windows.Forms.GroupBox()
        Me.radLilies = New System.Windows.Forms.RadioButton()
        Me.radRoses = New System.Windows.Forms.RadioButton()
        Me.radSunflowers = New System.Windows.Forms.RadioButton()
        Me.radTulips = New System.Windows.Forms.RadioButton()
        Me.radDaffodils = New System.Windows.Forms.RadioButton()
        Me.radDaisies = New System.Windows.Forms.RadioButton()
        Me.lblFavorite = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.picRoses = New System.Windows.Forms.PictureBox()
        Me.picTulips = New System.Windows.Forms.PictureBox()
        Me.picDaisies = New System.Windows.Forms.PictureBox()
        Me.picDaffodils = New System.Windows.Forms.PictureBox()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.picSunflowers = New System.Windows.Forms.PictureBox()
        Me.picLillies = New System.Windows.Forms.PictureBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.grpFavflower.SuspendLayout()
        CType(Me.picRoses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTulips, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDaisies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDaffodils, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSunflowers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLillies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(25, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(648, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "What Does Your Favorite Flower Say About You?"
        '
        'grpFavflower
        '
        Me.grpFavflower.Controls.Add(Me.radLilies)
        Me.grpFavflower.Controls.Add(Me.radRoses)
        Me.grpFavflower.Controls.Add(Me.radSunflowers)
        Me.grpFavflower.Controls.Add(Me.radTulips)
        Me.grpFavflower.Controls.Add(Me.radDaffodils)
        Me.grpFavflower.Controls.Add(Me.radDaisies)
        Me.grpFavflower.Location = New System.Drawing.Point(15, 254)
        Me.grpFavflower.Name = "grpFavflower"
        Me.grpFavflower.Size = New System.Drawing.Size(232, 232)
        Me.grpFavflower.TabIndex = 1
        Me.grpFavflower.TabStop = False
        Me.grpFavflower.Text = "Flower Selection "
        '
        'radLilies
        '
        Me.radLilies.AutoSize = True
        Me.radLilies.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLilies.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.radLilies.Location = New System.Drawing.Point(6, 198)
        Me.radLilies.Name = "radLilies"
        Me.radLilies.Size = New System.Drawing.Size(54, 19)
        Me.radLilies.TabIndex = 9
        Me.radLilies.TabStop = True
        Me.radLilies.Text = "Lilies"
        Me.radLilies.UseVisualStyleBackColor = True
        '
        'radRoses
        '
        Me.radRoses.AutoSize = True
        Me.radRoses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRoses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.radRoses.Location = New System.Drawing.Point(6, 35)
        Me.radRoses.Name = "radRoses"
        Me.radRoses.Size = New System.Drawing.Size(60, 19)
        Me.radRoses.TabIndex = 5
        Me.radRoses.TabStop = True
        Me.radRoses.Text = "Roses"
        Me.radRoses.UseVisualStyleBackColor = True
        '
        'radSunflowers
        '
        Me.radSunflowers.AutoSize = True
        Me.radSunflowers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSunflowers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.radSunflowers.Location = New System.Drawing.Point(6, 166)
        Me.radSunflowers.Name = "radSunflowers"
        Me.radSunflowers.Size = New System.Drawing.Size(86, 19)
        Me.radSunflowers.TabIndex = 8
        Me.radSunflowers.TabStop = True
        Me.radSunflowers.Text = "Sunflowers"
        Me.radSunflowers.UseVisualStyleBackColor = True
        '
        'radTulips
        '
        Me.radTulips.AutoSize = True
        Me.radTulips.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTulips.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.radTulips.Location = New System.Drawing.Point(6, 67)
        Me.radTulips.Name = "radTulips"
        Me.radTulips.Size = New System.Drawing.Size(61, 19)
        Me.radTulips.TabIndex = 5
        Me.radTulips.TabStop = True
        Me.radTulips.Text = "Tulips "
        Me.radTulips.UseVisualStyleBackColor = True
        '
        'radDaffodils
        '
        Me.radDaffodils.AutoSize = True
        Me.radDaffodils.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDaffodils.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.radDaffodils.Location = New System.Drawing.Point(6, 132)
        Me.radDaffodils.Name = "radDaffodils"
        Me.radDaffodils.Size = New System.Drawing.Size(73, 19)
        Me.radDaffodils.TabIndex = 7
        Me.radDaffodils.TabStop = True
        Me.radDaffodils.Text = "Daffodils"
        Me.radDaffodils.UseVisualStyleBackColor = True
        '
        'radDaisies
        '
        Me.radDaisies.AutoSize = True
        Me.radDaisies.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDaisies.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.radDaisies.Location = New System.Drawing.Point(6, 100)
        Me.radDaisies.Name = "radDaisies"
        Me.radDaisies.Size = New System.Drawing.Size(66, 19)
        Me.radDaisies.TabIndex = 6
        Me.radDaisies.TabStop = True
        Me.radDaisies.Text = "Daisies"
        Me.radDaisies.UseVisualStyleBackColor = True
        '
        'lblFavorite
        '
        Me.lblFavorite.AutoSize = True
        Me.lblFavorite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFavorite.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFavorite.Location = New System.Drawing.Point(11, 212)
        Me.lblFavorite.Name = "lblFavorite"
        Me.lblFavorite.Size = New System.Drawing.Size(387, 20)
        Me.lblFavorite.TabIndex = 2
        Me.lblFavorite.Text = "Please Select Your Favorite Flower and Click Confirm:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblName.Location = New System.Drawing.Point(12, 99)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(235, 20)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Please Enter Your Name Below:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(16, 137)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(155, 20)
        Me.txtName.TabIndex = 4
        '
        'picRoses
        '
        Me.picRoses.Image = CType(resources.GetObject("picRoses.Image"), System.Drawing.Image)
        Me.picRoses.Location = New System.Drawing.Point(418, 93)
        Me.picRoses.Name = "picRoses"
        Me.picRoses.Size = New System.Drawing.Size(100, 86)
        Me.picRoses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRoses.TabIndex = 5
        Me.picRoses.TabStop = False
        Me.picRoses.Visible = False
        '
        'picTulips
        '
        Me.picTulips.Image = CType(resources.GetObject("picTulips.Image"), System.Drawing.Image)
        Me.picTulips.Location = New System.Drawing.Point(524, 93)
        Me.picTulips.Name = "picTulips"
        Me.picTulips.Size = New System.Drawing.Size(100, 86)
        Me.picTulips.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTulips.TabIndex = 6
        Me.picTulips.TabStop = False
        Me.picTulips.Visible = False
        '
        'picDaisies
        '
        Me.picDaisies.Image = CType(resources.GetObject("picDaisies.Image"), System.Drawing.Image)
        Me.picDaisies.Location = New System.Drawing.Point(418, 181)
        Me.picDaisies.Name = "picDaisies"
        Me.picDaisies.Size = New System.Drawing.Size(100, 86)
        Me.picDaisies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDaisies.TabIndex = 7
        Me.picDaisies.TabStop = False
        Me.picDaisies.Visible = False
        '
        'picDaffodils
        '
        Me.picDaffodils.Image = CType(resources.GetObject("picDaffodils.Image"), System.Drawing.Image)
        Me.picDaffodils.Location = New System.Drawing.Point(524, 181)
        Me.picDaffodils.Name = "picDaffodils"
        Me.picDaffodils.Size = New System.Drawing.Size(100, 86)
        Me.picDaffodils.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDaffodils.TabIndex = 8
        Me.picDaffodils.TabStop = False
        Me.picDaffodils.Visible = False
        '
        'lstOut
        '
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.Location = New System.Drawing.Point(277, 404)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(396, 82)
        Me.lstOut.TabIndex = 9
        '
        'picSunflowers
        '
        Me.picSunflowers.Image = CType(resources.GetObject("picSunflowers.Image"), System.Drawing.Image)
        Me.picSunflowers.Location = New System.Drawing.Point(418, 273)
        Me.picSunflowers.Name = "picSunflowers"
        Me.picSunflowers.Size = New System.Drawing.Size(100, 86)
        Me.picSunflowers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSunflowers.TabIndex = 10
        Me.picSunflowers.TabStop = False
        Me.picSunflowers.Visible = False
        '
        'picLillies
        '
        Me.picLillies.Image = CType(resources.GetObject("picLillies.Image"), System.Drawing.Image)
        Me.picLillies.Location = New System.Drawing.Point(524, 273)
        Me.picLillies.Name = "picLillies"
        Me.picLillies.Size = New System.Drawing.Size(100, 86)
        Me.picLillies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLillies.TabIndex = 11
        Me.picLillies.TabStop = False
        Me.picLillies.Visible = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.RosyBrown
        Me.btnConfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnConfirm.Location = New System.Drawing.Point(16, 533)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(111, 27)
        Me.btnConfirm.TabIndex = 12
        Me.btnConfirm.Text = "Confirm "
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(386, 533)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 27)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.IndianRed
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(492, 533)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 27)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Return to Main Menu"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Quiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(702, 572)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.picLillies)
        Me.Controls.Add(Me.picSunflowers)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.picDaffodils)
        Me.Controls.Add(Me.picDaisies)
        Me.Controls.Add(Me.picTulips)
        Me.Controls.Add(Me.picRoses)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblFavorite)
        Me.Controls.Add(Me.grpFavflower)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Name = "Quiz"
        Me.Text = "Form2"
        Me.grpFavflower.ResumeLayout(False)
        Me.grpFavflower.PerformLayout()
        CType(Me.picRoses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTulips, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDaisies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDaffodils, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSunflowers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLillies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grpFavflower As GroupBox
    Friend WithEvents lblFavorite As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents radLilies As RadioButton
    Friend WithEvents radRoses As RadioButton
    Friend WithEvents radSunflowers As RadioButton
    Friend WithEvents radTulips As RadioButton
    Friend WithEvents radDaffodils As RadioButton
    Friend WithEvents radDaisies As RadioButton
    Friend WithEvents picRoses As PictureBox
    Friend WithEvents picTulips As PictureBox
    Friend WithEvents picDaisies As PictureBox
    Friend WithEvents picDaffodils As PictureBox
    Friend WithEvents lstOut As ListBox
    Friend WithEvents picSunflowers As PictureBox
    Friend WithEvents picLillies As PictureBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
