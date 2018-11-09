Public Class Form1

    Dim bak1 As Image
    Dim bak2 As Image
    Dim teller As Integer = 1
    Dim bakgrunnsmusikk As New Media.SoundPlayer(My.Resources.intro)


    'avslutter spillet
    Private Sub btnAvslutt_Click(sender As Object, e As EventArgs) Handles btnAvslutt.Click
        Dim avslutt As Integer
        avslutt = MsgBox("Er du sikker på at du vil avslutte?", MsgBoxStyle.YesNo, "Avslutt")
        Select Case avslutt
            Case MsgBoxResult.Yes
                Close()
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'My.Computer.Audio.Play(My.Resources.intro, AudioPlayMode.BackgroundLoop) 'starter avspilling av intromelodi, i loop
        ' for at denne skulle spilles av måtte følgende gjøres: Toolbox, høyreklikke på Binding Source. Velge COM Component. Huk av Windows Media Player
        'Dim bakgrunnsmusikk As New Media.SoundPlayer(My.Resources.intro)
        bakgrunnsmusikk.PlayLooping()

        bak1 = My.Resources.bakgrunn
        bak2 = My.Resources.bakgrunn2

    End Sub

    'Skifter mellom to bakgrunner
    Private Sub btnBakgrunn_Click(sender As Object, e As EventArgs) Handles btnBakgrunn.Click

        If teller = 1 Then
            Me.BackgroundImage = bak1
            teller = teller + 1
        ElseIf teller = 2 Then
            Me.BackgroundImage = bak2
            teller = 1
        End If

        If Me.BackgroundImage Is bak1 Then
            Me.BackgroundImage = bak2
        ElseIf Me.BackgroundImage Is bak2 Then
            Me.BackgroundImage = bak1
        End If

    End Sub

    'Lukker menyskjema(form1) og åpner spillskjema(form2)
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        bakgrunnsmusikk.Stop()
        Form2.Show()
        Me.Close()
    End Sub

    'Slår av og på bakgrunnslyd
    Private Sub btnLyd_Click(sender As Object, e As EventArgs) Handles btnLyd.Click
        If btnLyd.Text() = "Musikk av" Then
            btnLyd.Text() = "Musikk på"
            bakgrunnsmusikk.Stop() ' stopper melodien

        ElseIf btnLyd.Text() = "Musikk på" Then
            btnLyd.Text() = "Musikk av"
            'My.Computer.Audio.Play(My.Resources.intro, AudioPlayMode.BackgroundLoop) 'starter avspilling igjen.
            bakgrunnsmusikk.PlayLooping()
        End If

    End Sub
End Class
