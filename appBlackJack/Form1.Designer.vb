<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.picCard1 = New System.Windows.Forms.PictureBox()
        Me.picCard2 = New System.Windows.Forms.PictureBox()
        Me.picCard3 = New System.Windows.Forms.PictureBox()
        Me.picCard4 = New System.Windows.Forms.PictureBox()
        Me.picCard5 = New System.Windows.Forms.PictureBox()
        Me.btnHit = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnHit2 = New System.Windows.Forms.Button()
        Me.btnHit3 = New System.Windows.Forms.Button()
        Me.imglstCards = New System.Windows.Forms.ImageList(Me.components)
        Me.lblMyChips = New System.Windows.Forms.Label()
        Me.txtMyBet = New System.Windows.Forms.TextBox()
        Me.lblDealer = New System.Windows.Forms.Label()
        Me.lblPot = New System.Windows.Forms.Label()
        Me.btnBet = New System.Windows.Forms.Button()
        Me.btnGoAgain = New System.Windows.Forms.Button()
        CType(Me.picCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCard1
        '
        Me.picCard1.Location = New System.Drawing.Point(12, 12)
        Me.picCard1.Name = "picCard1"
        Me.picCard1.Size = New System.Drawing.Size(125, 170)
        Me.picCard1.TabIndex = 0
        Me.picCard1.TabStop = False
        '
        'picCard2
        '
        Me.picCard2.Location = New System.Drawing.Point(143, 12)
        Me.picCard2.Name = "picCard2"
        Me.picCard2.Size = New System.Drawing.Size(125, 170)
        Me.picCard2.TabIndex = 0
        Me.picCard2.TabStop = False
        '
        'picCard3
        '
        Me.picCard3.Location = New System.Drawing.Point(274, 12)
        Me.picCard3.Name = "picCard3"
        Me.picCard3.Size = New System.Drawing.Size(125, 170)
        Me.picCard3.TabIndex = 0
        Me.picCard3.TabStop = False
        '
        'picCard4
        '
        Me.picCard4.Location = New System.Drawing.Point(405, 12)
        Me.picCard4.Name = "picCard4"
        Me.picCard4.Size = New System.Drawing.Size(125, 170)
        Me.picCard4.TabIndex = 0
        Me.picCard4.TabStop = False
        '
        'picCard5
        '
        Me.picCard5.Location = New System.Drawing.Point(536, 12)
        Me.picCard5.Name = "picCard5"
        Me.picCard5.Size = New System.Drawing.Size(125, 170)
        Me.picCard5.TabIndex = 0
        Me.picCard5.TabStop = False
        '
        'btnHit
        '
        Me.btnHit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHit.Location = New System.Drawing.Point(274, 208)
        Me.btnHit.Name = "btnHit"
        Me.btnHit.Size = New System.Drawing.Size(125, 23)
        Me.btnHit.TabIndex = 1
        Me.btnHit.Text = "Hit Me"
        Me.btnHit.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(667, 42)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(183, 21)
        Me.lblScore.TabIndex = 2
        Me.lblScore.Text = "Players Score"
        '
        'btnStart
        '
        Me.btnStart.BackgroundImage = CType(resources.GetObject("btnStart.BackgroundImage"), System.Drawing.Image)
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(-4, -7)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(880, 269)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start Game"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(667, 70)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(183, 23)
        Me.btnShow.TabIndex = 4
        Me.btnShow.Text = "Show Cards"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnHit2
        '
        Me.btnHit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHit2.Location = New System.Drawing.Point(405, 208)
        Me.btnHit2.Name = "btnHit2"
        Me.btnHit2.Size = New System.Drawing.Size(125, 23)
        Me.btnHit2.TabIndex = 5
        Me.btnHit2.Text = "Hit Me"
        Me.btnHit2.UseVisualStyleBackColor = True
        '
        'btnHit3
        '
        Me.btnHit3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHit3.Location = New System.Drawing.Point(536, 208)
        Me.btnHit3.Name = "btnHit3"
        Me.btnHit3.Size = New System.Drawing.Size(125, 23)
        Me.btnHit3.TabIndex = 6
        Me.btnHit3.Text = "Hit Me"
        Me.btnHit3.UseVisualStyleBackColor = True
        '
        'imglstCards
        '
        Me.imglstCards.ImageStream = CType(resources.GetObject("imglstCards.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglstCards.TransparentColor = System.Drawing.Color.Transparent
        Me.imglstCards.Images.SetKeyName(0, "back of card.jpeg")
        Me.imglstCards.Images.SetKeyName(1, "1 of Hearts.jpg")
        Me.imglstCards.Images.SetKeyName(2, "2 of Hearts.jpg")
        Me.imglstCards.Images.SetKeyName(3, "3 of Hearts.jpg")
        Me.imglstCards.Images.SetKeyName(4, "4 of Hearts.jpg")
        Me.imglstCards.Images.SetKeyName(5, "5 of Hearts.jpg")
        Me.imglstCards.Images.SetKeyName(6, "6 of Hearts.png")
        Me.imglstCards.Images.SetKeyName(7, "7 of Hearts.png")
        Me.imglstCards.Images.SetKeyName(8, "8 of Hearts.jpg")
        Me.imglstCards.Images.SetKeyName(9, "9 of Hearts.jpg")
        Me.imglstCards.Images.SetKeyName(10, "10 of Hearts.jpg")
        Me.imglstCards.Images.SetKeyName(11, "Jack of Hearts.png")
        Me.imglstCards.Images.SetKeyName(12, "Queen of Hearts.jpg")
        Me.imglstCards.Images.SetKeyName(13, "King of Hearts.jpg")
        Me.imglstCards.Images.SetKeyName(14, "Ace of Diamonds.png")
        Me.imglstCards.Images.SetKeyName(15, "2 of Diamonds.png")
        Me.imglstCards.Images.SetKeyName(16, "3 of Diamonds.png")
        Me.imglstCards.Images.SetKeyName(17, "4 of Diamonds.png")
        Me.imglstCards.Images.SetKeyName(18, "5 of Diamonds.png")
        Me.imglstCards.Images.SetKeyName(19, "6 of Diamonds.png")
        Me.imglstCards.Images.SetKeyName(20, "7 of Diamonds.png")
        Me.imglstCards.Images.SetKeyName(21, "8 of Diamonds.png")
        Me.imglstCards.Images.SetKeyName(22, "9 of Diamonds.png")
        Me.imglstCards.Images.SetKeyName(23, "10 of Diamonds.png")
        Me.imglstCards.Images.SetKeyName(24, "jack of Diamonds.jpg")
        Me.imglstCards.Images.SetKeyName(25, "Queen of Diamonds.png")
        Me.imglstCards.Images.SetKeyName(26, "King of Diamonds.jpg")
        Me.imglstCards.Images.SetKeyName(27, "Ace of Spades.jpg")
        Me.imglstCards.Images.SetKeyName(28, "2 of Spades.png")
        Me.imglstCards.Images.SetKeyName(29, "3 of Spades.png")
        Me.imglstCards.Images.SetKeyName(30, "4 of Spades.png")
        Me.imglstCards.Images.SetKeyName(31, "5 of Spades.png")
        Me.imglstCards.Images.SetKeyName(32, "6 of Spades.png")
        Me.imglstCards.Images.SetKeyName(33, "7 of Spades.png")
        Me.imglstCards.Images.SetKeyName(34, "8 of Spades.png")
        Me.imglstCards.Images.SetKeyName(35, "9 of Spades.png")
        Me.imglstCards.Images.SetKeyName(36, "10 of Spades.png")
        Me.imglstCards.Images.SetKeyName(37, "Jack of Spades.jpg")
        Me.imglstCards.Images.SetKeyName(38, "Queen of Spades.jpg")
        Me.imglstCards.Images.SetKeyName(39, "King of Spades.jpg")
        Me.imglstCards.Images.SetKeyName(40, "Ace of Clubs.jpg")
        Me.imglstCards.Images.SetKeyName(41, "2 of Clubs.png")
        Me.imglstCards.Images.SetKeyName(42, "3 of Clubs.png")
        Me.imglstCards.Images.SetKeyName(43, "4 of Clubs.png")
        Me.imglstCards.Images.SetKeyName(44, "5 of Clubs.png")
        Me.imglstCards.Images.SetKeyName(45, "6 of Clubs.png")
        Me.imglstCards.Images.SetKeyName(46, "7 of Clubs.jpg")
        Me.imglstCards.Images.SetKeyName(47, "8 of Clubs.png")
        Me.imglstCards.Images.SetKeyName(48, "9 of Clubs.png")
        Me.imglstCards.Images.SetKeyName(49, "10 of Clubs.jpg")
        Me.imglstCards.Images.SetKeyName(50, "Jack of Clubs.jpg")
        Me.imglstCards.Images.SetKeyName(51, "Queen of Clubs.jpg")
        Me.imglstCards.Images.SetKeyName(52, "King of Clubs.png")
        '
        'lblMyChips
        '
        Me.lblMyChips.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyChips.Location = New System.Drawing.Point(667, 116)
        Me.lblMyChips.Name = "lblMyChips"
        Me.lblMyChips.Size = New System.Drawing.Size(183, 21)
        Me.lblMyChips.TabIndex = 8
        Me.lblMyChips.Text = "Players Chips"
        '
        'txtMyBet
        '
        Me.txtMyBet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMyBet.Location = New System.Drawing.Point(667, 156)
        Me.txtMyBet.Name = "txtMyBet"
        Me.txtMyBet.Size = New System.Drawing.Size(183, 22)
        Me.txtMyBet.TabIndex = 9
        Me.txtMyBet.Text = "Enter Bet"
        '
        'lblDealer
        '
        Me.lblDealer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDealer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDealer.Location = New System.Drawing.Point(667, 12)
        Me.lblDealer.Name = "lblDealer"
        Me.lblDealer.Size = New System.Drawing.Size(183, 21)
        Me.lblDealer.TabIndex = 10
        Me.lblDealer.Text = "Dealers score"
        '
        'lblPot
        '
        Me.lblPot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPot.Location = New System.Drawing.Point(667, 209)
        Me.lblPot.Name = "lblPot"
        Me.lblPot.Size = New System.Drawing.Size(183, 21)
        Me.lblPot.TabIndex = 11
        Me.lblPot.Text = "The Pot"
        '
        'btnBet
        '
        Me.btnBet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBet.Location = New System.Drawing.Point(667, 183)
        Me.btnBet.Name = "btnBet"
        Me.btnBet.Size = New System.Drawing.Size(183, 23)
        Me.btnBet.TabIndex = 12
        Me.btnBet.Text = "Bet Chips"
        Me.btnBet.UseVisualStyleBackColor = True
        '
        'btnGoAgain
        '
        Me.btnGoAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoAgain.Location = New System.Drawing.Point(30, 193)
        Me.btnGoAgain.Name = "btnGoAgain"
        Me.btnGoAgain.Size = New System.Drawing.Size(125, 37)
        Me.btnGoAgain.TabIndex = 13
        Me.btnGoAgain.Text = "Go Again"
        Me.btnGoAgain.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(869, 251)
        Me.Controls.Add(Me.btnGoAgain)
        Me.Controls.Add(Me.btnBet)
        Me.Controls.Add(Me.lblPot)
        Me.Controls.Add(Me.lblDealer)
        Me.Controls.Add(Me.txtMyBet)
        Me.Controls.Add(Me.lblMyChips)
        Me.Controls.Add(Me.btnHit3)
        Me.Controls.Add(Me.btnHit2)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnHit)
        Me.Controls.Add(Me.picCard5)
        Me.Controls.Add(Me.picCard4)
        Me.Controls.Add(Me.picCard3)
        Me.Controls.Add(Me.picCard2)
        Me.Controls.Add(Me.picCard1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Name = "frmMain"
        Me.Text = "Black Jack"
        CType(Me.picCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCard1 As System.Windows.Forms.PictureBox
    Friend WithEvents picCard2 As System.Windows.Forms.PictureBox
    Friend WithEvents picCard3 As System.Windows.Forms.PictureBox
    Friend WithEvents picCard4 As System.Windows.Forms.PictureBox
    Friend WithEvents picCard5 As System.Windows.Forms.PictureBox
    Friend WithEvents btnHit As System.Windows.Forms.Button
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnHit2 As System.Windows.Forms.Button
    Friend WithEvents btnHit3 As System.Windows.Forms.Button
    Friend WithEvents imglstCards As System.Windows.Forms.ImageList
    Friend WithEvents lblMyChips As System.Windows.Forms.Label
    Friend WithEvents txtMyBet As System.Windows.Forms.TextBox
    Friend WithEvents lblDealer As System.Windows.Forms.Label
    Friend WithEvents lblPot As System.Windows.Forms.Label
    Friend WithEvents btnBet As System.Windows.Forms.Button
    Friend WithEvents btnGoAgain As System.Windows.Forms.Button

End Class
