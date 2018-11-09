Imports System.IO

Public Class Form2

    Dim losningsOrd As String
    Dim bokstav As Char
    Dim letterpos As Integer = 0
    Dim feilTeller As Integer = 0



    Dim temp As New System.Text.StringBuilder
    Dim tavle As Media.SoundPlayer = New Media.SoundPlayer(My.Resources.tavle)
    Dim tap As Media.SoundPlayer = New Media.SoundPlayer(My.Resources.tap)
    Dim click1 As Media.SoundPlayer = New Media.SoundPlayer(My.Resources.click1)
    Dim clap As Media.SoundPlayer = New Media.SoundPlayer(My.Resources.clap)



    Private Declare Function HideCaret Lib "user32.dll" (ByVal hwnd As Int32) As Int32

    'Skjuler tekstmarkør i inputboks for bokstav når den får fokus
    Private Sub txtBokstav2_TextChanged(sender As Object, e As EventArgs) Handles txtBokstav.GotFocus
        Call HideCaret(txtBokstav.Handle)
    End Sub

    'Private Sub txtBokstav_TextChanged(sender As Object, e As EventArgs) Handles txtBokstav.TextChanged
    'Call HideCaret(txtBokstav.Handle)
    'End Sub

    'avslutter spillet
    Private Sub btnAvslutt_Click(sender As Object, e As EventArgs) Handles btnAvslutt2.Click
        Dim avslutt As Integer
        avslutt = MsgBox("Er du sikker på at du vil avslutte?", MsgBoxStyle.YesNo, "Avslutt")
        Select Case avslutt
            Case MsgBoxResult.Yes
                Close()
        End Select
    End Sub

    'tilbake til meny
    Private Sub btnTilmeny_Click(sender As Object, e As EventArgs) Handles btnTilmeny.Click
        click1.Play()
        Form1.Show()
        Me.Close()
    End Sub

    'Tillater kun bokstaver i feltet for inntasting av bokstaver
    Private Sub txtBokstav_KeyPress(sender As Object, e As KeyPressEventArgs) _
                              Handles txtBokstav.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzæøå"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'Tillater kun bokstaver i feltet for inntasting av løsningsord
    Private Sub txtLosningsord_KeyPress(sender As Object, e As KeyPressEventArgs) _
                              Handles txtLosningsOrd.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzæøå"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'lar brukeren trykke enter for å sende bokstav
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBokstav.KeyDown

        If e.KeyCode = Keys.Enter Then

            Call btnSjekkbokstav.PerformClick()

        End If

    End Sub
    'Sjekker inntastet bokstav mot bokstaver i løsningsord og skriver rett eller galt og fyller ut eventuelt rett bokstav i ordet, eller legger til på hangman

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSjekkbokstav.Click
        bokstav = txtBokstav.Text
        Dim lengdeOrd As Integer = losningsOrd.Length()

        'sjekker om bokstaven finnes i ordet, om ikke legges bokstaven til linjen for brukte bokstaver og lyd spilles av.
        'teller antall feil inntastinger. Samme bokstav flere ganger teller ikke som feil
        If txtBokstav.Text = "" Then
            MsgBox("Skriv inn en bokstav")
            txtBokstav.Select()
        Else

            If losningsOrd.Contains(bokstav) = False Then
                If lblGjettetbokstav.Text.Contains(bokstav) Then

                Else
                    lblGjettetbokstav.Text &= bokstav
                    feilTeller = feilTeller + 1
                    tavle.Play()
                End If

                'kjøres om bokstaven finnes i ordet. sjekker fra bokstav 1 og gjennom hele ordet.
                'Bytter ut "?" med bokstav i rett posisjon i labelen med skjult ord (lblSvar)
            Else
                letterpos = 0
                Do While InStr(letterpos + 1, losningsOrd, bokstav) > 0
                    letterpos = InStr(letterpos + 1, losningsOrd, bokstav)
                    Mid(lblSvar.Text, letterpos, 1) = bokstav
                Loop

            End If

            'Om antall feil er større enn 5 er spillet tapt. Om antall feil er under 5 sjekkes det om alle bokstaver er funnet, og i såfall er spillet vunnet.
            'Endrer bakgrunn etter hvor mange feil man har
            If lblSvar.Text.Contains("-") And feilTeller = 5 Then
                Me.PictureBox.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangman5
                tap.Play()
                MsgBox("Du tapte! Ordet var " & "" & losningsOrd)
                btnBekreftord.Show()
                Random.Show()
                txtLosningsOrd.Show()
                lblOverskriftinput.Show()
                lblOverskriftbokstav.Hide()
                txtBokstav.Hide()
                btnSjekkbokstav.Hide()
                lblBruktebokstaver.Hide()
                txtLosningsOrd.Text = Nothing
                txtBokstav.Text = Nothing
                losningsOrd = Nothing
                bokstav = Nothing
                lblSvar.Text = ""
                lblGjettetbokstav.Text = ""
                feilTeller = 0
                Me.PictureBox.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangman0

            ElseIf lblSvar.Text.Contains("-") Then
                If feilTeller = 1 Then
                    Me.PictureBox.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangman1
                ElseIf feilTeller = 2 Then
                    Me.PictureBox.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangman2
                ElseIf feilTeller = 3 Then
                    Me.PictureBox.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangman3
                ElseIf feilTeller = 4 Then
                    Me.PictureBox.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangman4
                End If

            Else clap.Play()
                MsgBox("Du vant!")
                btnBekreftord.Show()
                Random.Show()
                txtLosningsOrd.Show()
                lblOverskriftinput.Show()
                lblOverskriftbokstav.Hide()
                txtBokstav.Hide()
                btnSjekkbokstav.Hide()
                lblBruktebokstaver.Hide()
                txtLosningsOrd.Text = Nothing
                txtBokstav.Text = Nothing
                losningsOrd = Nothing
                bokstav = Nothing
                lblSvar.Text = ""
                lblGjettetbokstav.Text = ""
                feilTeller = 0
                Me.PictureBox.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangman0

            End If

            txtBokstav.Text = ""
            txtBokstav.Select()

        End If

    End Sub

    'gjemmer valget for manuell input av ord, og velger et tilfeldig et fra ordlisten. (textfil)
    'lagrer valgt ord som ....

    Private Sub Random_Click(sender As Object, e As EventArgs) Handles Random.Click
        click1.Play()

        Dim ord() As String = My.Resources.ordliste_random.Split(Environment.NewLine)
        'txt filer lagret i resources er lagret som byte arrays, og kan derfor ikke leses av direkte.
        'filen må .splittes for å få hver linje lesbar.

        Dim rnd As New Random()

        Dim selectedIndex = rnd.Next(1, ord.Length) 'Velger en tilfeldig index

        Dim selectedName = ord(selectedIndex)

        'usnylig tegn dukker opp foran ord fra listen. klarte ikke å finne dette ut , så den ble fjernet ved hjelp av linjen under
        selectedName = selectedName.Remove(0, 1)

        txtLosningsOrd.Text = selectedName
        losningsOrd = txtLosningsOrd.Text
        lblSvar.Text = ""
        txtLosningsOrd.Hide()
        btnBekreftord.Hide()
        lblOverskriftbokstav.Show()
        txtBokstav.Show()
        btnSjekkbokstav.Show()
        Random.Hide()
        lblOverskriftinput.Hide()
        lblBruktebokstaver.Show()

        Dim streker As String = ""
        For counter As Integer = 1 To losningsOrd.Length
            streker = streker + "-"
        Next

        lblSvar.Text = streker

        txtBokstav.Select()
    End Sub





    'Henter det inntastede ordet og lagrer det, og lager en string med antall "?" lik løsningsordet som skrives til label.
    'Om ordet er under tre bokstaver vil en varselboks vises
    'Setter fokus til boks for inntasting av bokstav
    Private Sub btnBekreftord_Click(sender As Object, e As EventArgs) Handles btnBekreftord.Click
        click1.Play()
        If txtLosningsOrd.Text.Length() < 3 Then
            MsgBox("Ordet må være på minst 3 bokstaver")
        Else
            losningsOrd = txtLosningsOrd.Text
            lblSvar.Text = ""
            txtLosningsOrd.Hide()
            Random.Hide()
            btnBekreftord.Hide()

            lblOverskriftinput.Hide()
            lblOverskriftbokstav.Show()
            txtBokstav.Show()
            btnSjekkbokstav.Show()

            Dim temp As New System.Text.StringBuilder
            For Each Character As Char In losningsOrd
                temp.Append("-")
            Next

            lblSvar.Text = temp.ToString
            txtBokstav.Select()
        End If

        lblBruktebokstaver.Show()


    End Sub

    'tømmer alle felt og setter løsningsord og bokstav til null og bakgrunnen til start
    'viser knapp for bekreft ord og tekstboks for inntasting av løsningsord og overskriften til denne
    'skjuler knapp for bekreft  bokstav og tekstboks for inntasting av bokstav og overskriften til denne
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnNullstill.Click
        click1.Play()
        btnBekreftord.Show()
        Random.Show()
        txtLosningsOrd.Show()
        lblOverskriftinput.Show()
        lblOverskriftbokstav.Hide()
        txtBokstav.Hide()
        btnSjekkbokstav.Hide()
        lblBruktebokstaver.Hide()
        txtLosningsOrd.Text = Nothing
        txtBokstav.Text = Nothing
        lblSvar.Text = ""
        losningsOrd = Nothing
        bokstav = Nothing
        lblGjettetbokstav.Text = ""
        feilTeller = 0
        Me.PictureBox.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangman0
    End Sub

    'slår av og på bakgrunnslyd
    Private Sub btnLyd_Click(sender As Object, e As EventArgs) Handles btnLyd.Click
        If btnLyd.Text() = "Lyd Av" Then
            btnLyd.Text() = "Lyd På"
            My.Computer.Audio.Stop() ' stopper melodien

        ElseIf btnLyd.Text() = "Lyd På" Then
            btnLyd.Text() = "Lyd Av"
            My.Computer.Audio.Play(My.Resources.intro, AudioPlayMode.BackgroundLoop) 'starter avspilling igjen.
        End If
    End Sub


End Class