Public Class frmMain
    'Values are used the most are put here
    'these also affect all subs
    'or used in more the on place
    Dim rndCard As New Random
    Dim rndDealerCard As New Random
    Dim intCardScore As Integer
    Dim intCardValue As Integer
    Dim intCardNumber As Integer
    Dim intPlayerValue As Integer
    Dim intDealersValue As Integer
    Dim dblChips As Double
    Dim dblBet As Double
    Dim dblPot As Double
    Dim intdealerChips As Integer

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'When the progam is open all of these will not visible
        'Only the stat button
        btnHit.Visible = False
        btnHit2.Visible = False
        btnHit3.Visible = False
        btnShow.Visible = False
        lblScore.Visible = False
        lblMyChips.Visible = False
        txtMyBet.Visible = False
        dblChips = Val(500)
        lblMyChips.Text = " You have €" & dblChips & " Chips"
        lblDealer.Visible = False
        btnBet.Visible = False
        lblPot.Visible = False
        btnGoAgain.Visible = False
        picCard3.Image = imglstCards.Images(0)
        picCard4.Image = imglstCards.Images(0)
        picCard5.Image = imglstCards.Images(0)
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        'values of the second random number
        ' these are needed as twocard are draw at once
        'the first random number is loaded befor main
        Dim intCardValue2 As Integer
        Dim intCardNumber2 As Integer

        'this is to change the display on the form
        btnHit.Visible = True
        btnShow.Visible = True
        lblScore.Visible = True
        btnBet.Visible = True
        lblPot.Visible = True

        My.Computer.Audio.Play("Card shuffle.wav")

        'this is for the display on the form
        btnStart.Visible = False
        btnHit.Visible = True

        ' Select a random card 
        intCardNumber = rndCard.Next(1, 53)
        intCardNumber2 = rndCard.Next(1, 53)

        'Display the first card and value 
        picCard1.Image = imglstCards.Images(intCardNumber)
        intCardValue = FindCardValue(intCardNumber).ToString

        'Display the second card  and its values
        picCard2.Image = imglstCards.Images(intCardNumber2)
        intCardValue2 = FindCardValue(intCardNumber2).ToString

        intCardScore = intCardValue + intCardValue2
        lblScore.Text = "Your Score is " & intCardScore

        'this is for the next card so that the scores can ve added up
        intPlayerValue = intCardScore

        'this is to set up the last card upside down
        picCard3.Image = imglstCards.Images(0)

        ' enter money into your game
        lblMyChips.Visible = True
        txtMyBet.Visible = True

        ' this covers if ace and an image card appear
        If intCardScore = 21 Then
            MsgBox("Black Jack")
        End If

        'this is if the player form going over 21
        If intCardScore > 21 Then
            btnHit.Visible = False
            btnHit2.Visible = False
            btnHit3.Visible = False
            MsgBox("Sorry player you have gone over the 21 Bust")
            btnGoAgain.Visible = True
            btnBet.Enabled = False
            btnShow.Enabled = False
        End If

    End Sub

    Private Sub btnHit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHit.Click

        ' Select a random card 
        intCardNumber = rndCard.Next(1, 53)

        'Display the starting cards
        picCard3.Image = imglstCards.Images(intCardNumber)
        intCardValue = FindCardValue(intCardNumber).ToString

        intCardScore = intPlayerValue + intCardValue
        lblScore.Text = "Your Score is " & intCardScore
        intPlayerValue = intCardScore

        'Set up the next card
        picCard4.Image = imglstCards.Images(0)


        'this will to stop the player form going over 21
        If intCardScore > 21 Then
            btnHit.Visible = False
            btnHit2.Visible = False
            btnHit3.Visible = False
            My.Computer.Audio.Play("Explosion.wav")
            MsgBox("Sorry player you have gone over the 21 Bust")
            btnGoAgain.Visible = True
            btnBet.Enabled = False
            btnShow.Enabled = False
        Else
            btnHit.Visible = False
            btnHit2.Visible = True
        End If

        If intCardScore = 21 Then
            btnHit.Visible = False
            btnHit2.Visible = False
            btnHit3.Visible = False
            MsgBox("Sorry player you have gone over the 21 Bust")
            btnGoAgain.Visible = True
            btnBet.Enabled = False
            btnShow.Enabled = False

            Try
                dblPot = txtMyBet.Text
            Catch ex As Exception
                txtMyBet.Text = Val(dblBet)
            End Try


            'dealer chips
            intdealerChips = Val(30)
            dblChips = dblChips + lblPot.Text + intdealerChips
            lblMyChips.Text = " You have €" & dblChips & " Chips"
            lblPot.Text = "the pot is yours"

        End If


    End Sub

    Private Sub btnHit2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHit2.Click

        ' Select a random card 
        intCardNumber = rndCard.Next(1, 53)

        'Display the starting cards
        picCard4.Image = imglstCards.Images(intCardNumber)
        intCardValue = FindCardValue(intCardNumber).ToString

        picCard5.Image = imglstCards.Images(0)

        intCardScore = intPlayerValue + intCardValue
        lblScore.Text = "Your Score is " & intCardScore
        intPlayerValue = intCardScore

        'this is to stop the player form going over 21
        If intCardScore > 21 Then
            btnHit.Visible = False
            btnHit2.Visible = False
            btnHit3.Visible = False
            My.Computer.Audio.Play("Explosion.wav")
            MsgBox("Sorry player you have gone over the 21 Bust")
            btnGoAgain.Visible = True
            btnBet.Enabled = False
            btnShow.Enabled = False
        Else
            btnHit2.Visible = False
            btnHit3.Visible = True
        End If

        If intCardScore = 21 Then
            btnHit.Visible = False
            btnHit2.Visible = False
            btnHit3.Visible = False
            MsgBox("Sorry player you have gone over the 21 Bust")
            btnGoAgain.Visible = True
            btnBet.Enabled = False
            btnShow.Enabled = False

            Try
                dblPot = txtMyBet.Text
            Catch ex As Exception
                txtMyBet.Text = Val(dblBet)
            End Try


            'dealer chips
            intdealerChips = Val(30)
            dblChips = dblChips + lblPot.Text + intdealerChips
            lblMyChips.Text = " You have €" & dblChips & " Chips"
            lblPot.Text = "the pot is yours"

        End If

    End Sub

    Private Sub btnHit3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHit3.Click
        ' Select a random card 
        intCardNumber = rndCard.Next(1, 53)

        'Display the starting cards
        picCard5.Image = imglstCards.Images(intCardNumber)

        intCardScore = intPlayerValue + intCardValue
        lblScore.Text = "Your Score is " & intCardScore
        intPlayerValue = intCardScore
        btnGoAgain.Visible = True

        'this is to stop the player form going over 21
        If intCardScore > 21 Then
            btnHit.Visible = False
            btnHit2.Visible = False
            btnHit3.Visible = False
            My.Computer.Audio.Play("Explosion.wav")
            MsgBox("Sorry player you have gone over the 21 Bust")
            btnGoAgain.Visible = True
            btnBet.Enabled = False
            btnShow.Enabled = False
        Else
            btnHit3.Visible = False
        End If

        If intCardScore = 21 Then
            btnHit.Visible = False
            btnHit2.Visible = False
            btnHit3.Visible = False
            MsgBox("Sorry player you have gone over the 21 Bust")
            btnGoAgain.Visible = True
            btnBet.Enabled = False
            btnShow.Enabled = False

            Try
                dblPot = txtMyBet.Text
            Catch ex As Exception
                txtMyBet.Text = Val(dblBet)
            End Try


            'dealer chips
            intdealerChips = Val(30)
            dblChips = dblChips + lblPot.Text + intdealerChips
            lblMyChips.Text = " You have €" & dblChips & " Chips"
            lblPot.Text = "the pot is yours"

        End If


    End Sub
    Private Function FindCardValue(ByVal intCardNumber As Integer) As Integer

        'This is the scoring value for the Cards
        'Example Ace's are 1,14,27,40 and has a value 1

        Select Case intCardNumber
            Case 1, 14, 27, 40
                intCardScore = 11

            Case 2, 15, 28, 41
                intCardScore = 2

            Case 3, 16, 29, 42
                intCardScore = 3

            Case 4, 17, 30, 43
                intCardScore = 4

            Case 5, 18, 31, 44
                intCardScore = 5

            Case 6, 19, 32, 45
                intCardScore = 6

            Case 7, 20, 33, 46
                intCardScore = 7

            Case 8, 21, 34, 47
                intCardScore = 8

            Case 9, 22, 35, 48
                intCardScore = 9

            Case 10, 11, 12, 13, 23, 24, 25, 26, 36, 37, 38, 39, 49, 50, 51, 52
                intCardScore = 10
        End Select

        Return intCardScore

        If intCardScore = 0 Then
            btnGoAgain.Visible = True
        End If


    End Function

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        ' These are new intergers and ramdom generator for the dealer
        Dim intDealerScore As Integer
        Dim rndDeal As New Random

        'to stop player adding to hand if they lost
        btnBet.Enabled = False
        btnHit.Visible = False
        btnHit2.Visible = False
        btnHit3.Visible = False
        lblDealer.Visible = True
        btnHit.Visible = False
        lblDealer.Visible = True

        'this is to get a value to compare to the players score

        intDealerScore = rndDeal.Next(17, 26)
        btnGoAgain.Visible = True
        btnShow.Enabled = False

        'this is to sidplay the dealers value
        lblDealer.Text = "The dealers Score is:" & "" & intDealerScore

        ' displays if you lose or win
        If intDealerScore >= intPlayerValue Then
            My.Computer.Audio.Play("Explosion.wav")
            MsgBox("Sorry Dealers Win")
            lblPot.Text = "the dealer got the pot"
        End If

        If intCardScore = 21 Then
            btnHit.Visible = False
            btnHit2.Visible = False
            btnHit3.Visible = False
            MsgBox("Sorry player you have gone over the 21 Bust")
            btnGoAgain.Visible = True
            btnBet.Enabled = False
            btnShow.Enabled = False

            Try
                dblPot = txtMyBet.Text
            Catch ex As Exception
                txtMyBet.Text = Val(dblBet)
            End Try


            'dealer chips
            intdealerChips = Val(30)
            dblChips = dblChips + lblPot.Text + intdealerChips
            lblMyChips.Text = " You have €" & dblChips & " Chips"
            lblPot.Text = "the pot is yours"

        End If


        If intDealerScore < intPlayerValue Then
            My.Computer.Audio.Play("applause.wav")
            MsgBox("Great you have Win")
            lblPot.Text = Val(dblPot)

            Try
                dblPot = txtMyBet.Text
            Catch ex As Exception
                txtMyBet.Text = Val(dblBet)
            End Try


            'dealer chips
            intdealerChips = Val(30)
            dblChips = dblChips + lblPot.Text + intdealerChips
            lblMyChips.Text = " You have €" & dblChips & " Chips"
            lblPot.Text = "the pot is yours"

        End If
    End Sub
    Private Function rndDeal(ByVal intDealerScore As Integer) As Integer


        Select Case intDealerScore
            Case 15
                intDealerScore = 15

            Case 16
                intDealerScore = 16

            Case 17
                intDealerScore = 17

            Case 18
                intDealerScore = 18

            Case 19
                intDealerScore = 19

            Case 20
                intDealerScore = 20

            Case 21
                intDealerScore = 21

            Case 22
                intDealerScore = 22

            Case 23
                intDealerScore = 23

            Case 24
                intDealerScore = 24

            Case 25
                intDealerScore = 25
        End Select

        Return intDealerScore

        lblDealer.Text = intDealerScore

        If intDealerScore = 0 Then
            btnGoAgain.Visible = True
        End If


    End Function

    Private Sub btnBet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBet.Click
        'run the subroutine BuyProduct
        dblPot = txtMyBet.Text
        lblPot.Text = Val(dblPot)

        dblChips = dblChips - txtMyBet.Text
        lblMyChips.Text = " You have €" & dblChips & " Chips"
    End Sub

    Private Sub btnGoAgain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoAgain.Click
        Call GoOn()
    End Sub
    Private Sub GoOn()
        btnBet.Enabled = True
        btnShow.Enabled = True
        'this is to keep goin until out of chips
        Dim intCardNumber2 As Integer
        Dim intCardValue2 As Integer
        btnHit.Visible = False
        btnHit2.Visible = False
        btnHit3.Visible = False
        lblDealer.Visible = False
        btnGoAgain.Visible = False

        My.Computer.Audio.Play("Card shuffle.wav")

        'this is for the display on the form
        btnStart.Visible = False
        btnHit.Visible = True

        ' Select a random card 
        intCardNumber = rndCard.Next(1, 53)
        intCardNumber2 = rndCard.Next(1, 53)

        'Display the first card and value 
        picCard1.Image = imglstCards.Images(intCardNumber)
        intCardValue = FindCardValue(intCardNumber).ToString

        If dblChips <= 0 Then
            btnShow.Visible = False
            btnBet.Visible = False
        Else
            btnShow.Visible = True
            btnBet.Visible = True
        End If

        'Display the second card  and its values
        picCard2.Image = imglstCards.Images(intCardNumber2)
        intCardValue2 = FindCardValue(intCardNumber2).ToString

        intCardScore = intCardValue + intCardValue2
        lblScore.Text = "Your Score is " & intCardScore

        'this is for the next card so that the scores can ve added up
        intPlayerValue = intCardScore

        'Reset cards
        picCard3.Image = imglstCards.Images(0)
        picCard4.Image = imglstCards.Images(0)
        picCard5.Image = imglstCards.Images(0)
    End Sub
End Class

