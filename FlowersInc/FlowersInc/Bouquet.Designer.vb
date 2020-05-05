<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bouquet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bouquet))
        Me.lblBouquet = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.grpAccents = New System.Windows.Forms.GroupBox()
        Me.chkLeather = New System.Windows.Forms.CheckBox()
        Me.chkBabys = New System.Windows.Forms.CheckBox()
        Me.chkMini = New System.Windows.Forms.CheckBox()
        Me.grpContainers = New System.Windows.Forms.GroupBox()
        Me.radBasket = New System.Windows.Forms.RadioButton()
        Me.radMason = New System.Windows.Forms.RadioButton()
        Me.radVase = New System.Windows.Forms.RadioButton()
        Me.txtFlower = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFlowers2 = New System.Windows.Forms.Label()
        Me.btnConfirm2 = New System.Windows.Forms.Button()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lstTotal2 = New System.Windows.Forms.ListBox()
        Me.btnClear2 = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblConfirm = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAccents.SuspendLayout()
        Me.grpContainers.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBouquet
        '
        Me.lblBouquet.AutoSize = True
        Me.lblBouquet.Font = New System.Drawing.Font("Lucida Handwriting", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBouquet.Location = New System.Drawing.Point(117, 9)
        Me.lblBouquet.Name = "lblBouquet"
        Me.lblBouquet.Size = New System.Drawing.Size(500, 45)
        Me.lblBouquet.TabIndex = 0
        Me.lblBouquet.Text = "Create You Own Buoquet"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(43, 133)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(564, 133)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(126, 112)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'grpAccents
        '
        Me.grpAccents.Controls.Add(Me.chkLeather)
        Me.grpAccents.Controls.Add(Me.chkBabys)
        Me.grpAccents.Controls.Add(Me.chkMini)
        Me.grpAccents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpAccents.Location = New System.Drawing.Point(472, 390)
        Me.grpAccents.Name = "grpAccents"
        Me.grpAccents.Size = New System.Drawing.Size(207, 156)
        Me.grpAccents.TabIndex = 3
        Me.grpAccents.TabStop = False
        Me.grpAccents.Text = "Accents"
        '
        'chkLeather
        '
        Me.chkLeather.AutoSize = True
        Me.chkLeather.Location = New System.Drawing.Point(7, 125)
        Me.chkLeather.Name = "chkLeather"
        Me.chkLeather.Size = New System.Drawing.Size(146, 17)
        Me.chkLeather.TabIndex = 2
        Me.chkLeather.Text = "Leather Leaf Fern - $1.25"
        Me.chkLeather.UseVisualStyleBackColor = True
        '
        'chkBabys
        '
        Me.chkBabys.AutoSize = True
        Me.chkBabys.Location = New System.Drawing.Point(7, 81)
        Me.chkBabys.Name = "chkBabys"
        Me.chkBabys.Size = New System.Drawing.Size(127, 17)
        Me.chkBabys.TabIndex = 1
        Me.chkBabys.Text = "Baby's Breath - $1.50"
        Me.chkBabys.UseVisualStyleBackColor = True
        '
        'chkMini
        '
        Me.chkMini.AutoSize = True
        Me.chkMini.Location = New System.Drawing.Point(6, 37)
        Me.chkMini.Name = "chkMini"
        Me.chkMini.Size = New System.Drawing.Size(144, 17)
        Me.chkMini.TabIndex = 0
        Me.chkMini.Text = "Mini Spray Roses - $2.65"
        Me.chkMini.UseVisualStyleBackColor = True
        '
        'grpContainers
        '
        Me.grpContainers.Controls.Add(Me.radBasket)
        Me.grpContainers.Controls.Add(Me.radMason)
        Me.grpContainers.Controls.Add(Me.radVase)
        Me.grpContainers.Location = New System.Drawing.Point(68, 390)
        Me.grpContainers.Name = "grpContainers"
        Me.grpContainers.Size = New System.Drawing.Size(200, 156)
        Me.grpContainers.TabIndex = 4
        Me.grpContainers.TabStop = False
        Me.grpContainers.Text = "Containers"
        '
        'radBasket
        '
        Me.radBasket.AutoSize = True
        Me.radBasket.Location = New System.Drawing.Point(7, 125)
        Me.radBasket.Name = "radBasket"
        Me.radBasket.Size = New System.Drawing.Size(94, 17)
        Me.radBasket.TabIndex = 2
        Me.radBasket.TabStop = True
        Me.radBasket.Text = "Basket - $8.00"
        Me.radBasket.UseVisualStyleBackColor = True
        '
        'radMason
        '
        Me.radMason.AutoSize = True
        Me.radMason.Location = New System.Drawing.Point(7, 81)
        Me.radMason.Name = "radMason"
        Me.radMason.Size = New System.Drawing.Size(110, 17)
        Me.radMason.TabIndex = 1
        Me.radMason.TabStop = True
        Me.radMason.Text = "Mason Jar - $4.00"
        Me.radMason.UseVisualStyleBackColor = True
        '
        'radVase
        '
        Me.radVase.AutoSize = True
        Me.radVase.Location = New System.Drawing.Point(7, 37)
        Me.radVase.Name = "radVase"
        Me.radVase.Size = New System.Drawing.Size(85, 17)
        Me.radVase.TabIndex = 0
        Me.radVase.TabStop = True
        Me.radVase.Text = "Vase - $6.00"
        Me.radVase.UseVisualStyleBackColor = True
        '
        'txtFlower
        '
        Me.txtFlower.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtFlower.Location = New System.Drawing.Point(260, 118)
        Me.txtFlower.Multiline = True
        Me.txtFlower.Name = "txtFlower"
        Me.txtFlower.Size = New System.Drawing.Size(207, 156)
        Me.txtFlower.TabIndex = 5
        Me.txtFlower.Text = "Flowers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Roses - $2.80/Flower" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Daisies - $2.00/Flower" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hydrangeas - $5.00/F" &
    "lower" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lillies - $3.00/Flower" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(343, 293)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(124, 20)
        Me.txtType.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 367)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select Your Desired Container:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(407, 367)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(325, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Select Your Desired Accents Below:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 9
        '
        'lblFlowers2
        '
        Me.lblFlowers2.AutoSize = True
        Me.lblFlowers2.Font = New System.Drawing.Font("Lucida Calligraphy", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlowers2.Location = New System.Drawing.Point(91, 65)
        Me.lblFlowers2.Name = "lblFlowers2"
        Me.lblFlowers2.Size = New System.Drawing.Size(526, 40)
        Me.lblFlowers2.TabIndex = 10
        Me.lblFlowers2.Text = "                         Select Your Desired Flowers " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "By Inputing It In the Box " &
    "Below As Well As The Quanity:"
        '
        'btnConfirm2
        '
        Me.btnConfirm2.BackColor = System.Drawing.Color.OrangeRed
        Me.btnConfirm2.Font = New System.Drawing.Font("Javanese Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm2.Location = New System.Drawing.Point(306, 572)
        Me.btnConfirm2.Name = "btnConfirm2"
        Me.btnConfirm2.Size = New System.Drawing.Size(124, 38)
        Me.btnConfirm2.TabIndex = 11
        Me.btnConfirm2.Text = "Confirm "
        Me.btnConfirm2.UseVisualStyleBackColor = False
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(257, 293)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(80, 13)
        Me.lblType.TabIndex = 12
        Me.lblType.Text = "Flower Type:"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(279, 332)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(58, 13)
        Me.lblQuantity.TabIndex = 13
        Me.lblQuantity.Text = "Quantity:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(343, 329)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(124, 20)
        Me.txtQuantity.TabIndex = 14
        '
        'lstTotal2
        '
        Me.lstTotal2.FormattingEnabled = True
        Me.lstTotal2.Location = New System.Drawing.Point(282, 616)
        Me.lstTotal2.Name = "lstTotal2"
        Me.lstTotal2.Size = New System.Drawing.Size(169, 121)
        Me.lstTotal2.TabIndex = 15
        '
        'btnClear2
        '
        Me.btnClear2.BackColor = System.Drawing.Color.White
        Me.btnClear2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear2.Location = New System.Drawing.Point(171, 688)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(97, 40)
        Me.btnClear2.TabIndex = 16
        Me.btnClear2.Text = "Clear"
        Me.btnClear2.UseVisualStyleBackColor = False
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.Navy
        Me.btnCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.ForeColor = System.Drawing.Color.Transparent
        Me.btnCheckout.Location = New System.Drawing.Point(594, 686)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(85, 44)
        Me.btnCheckout.TabIndex = 17
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.Gray
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(472, 686)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(115, 44)
        Me.btnReturn.TabIndex = 18
        Me.btnReturn.Text = "Return to Main Menu "
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirm.Location = New System.Drawing.Point(222, 549)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(298, 20)
        Me.lblConfirm.TabIndex = 19
        Me.lblConfirm.Text = "WHEN FINISHED CLICK CONFIRM:"
        '
        'Bouquet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(744, 749)
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.btnClear2)
        Me.Controls.Add(Me.lstTotal2)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.btnConfirm2)
        Me.Controls.Add(Me.lblFlowers2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtFlower)
        Me.Controls.Add(Me.grpContainers)
        Me.Controls.Add(Me.grpAccents)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblBouquet)
        Me.Name = "Bouquet"
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAccents.ResumeLayout(False)
        Me.grpAccents.PerformLayout()
        Me.grpContainers.ResumeLayout(False)
        Me.grpContainers.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBouquet As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents grpAccents As GroupBox
    Friend WithEvents grpContainers As GroupBox
    Friend WithEvents txtFlower As TextBox
    Friend WithEvents chkLeather As CheckBox
    Friend WithEvents chkBabys As CheckBox
    Friend WithEvents chkMini As CheckBox
    Friend WithEvents radBasket As RadioButton
    Friend WithEvents radMason As RadioButton
    Friend WithEvents radVase As RadioButton
    Friend WithEvents txtType As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblFlowers2 As Label
    Friend WithEvents btnConfirm2 As Button
    Friend WithEvents lblType As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lstTotal2 As ListBox
    Friend WithEvents btnClear2 As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblConfirm As Label
End Class
