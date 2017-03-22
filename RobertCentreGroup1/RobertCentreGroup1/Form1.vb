Public Class HomeUI
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler NavPanel.MouseDown, New MouseEventHandler(AddressOf ctl_MouseDown)
        AddHandler NavPanel.MouseMove, New MouseEventHandler(AddressOf ctl_MouseMove)
        AddHandler NavPanel.MouseUp, New MouseEventHandler(AddressOf ctl_MouseUp)
    End Sub
#Region "MOuse events on panel contorl"

    Private m_WindowState As FormWindowState = FormWindowState.Normal
    Private m_MousePressed As Boolean = False
    Private m_oldX As Integer, m_oldY As Integer


    Private Sub ctl_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim TS As Point = Me.PointToScreen(e.Location)
        m_oldX = TS.X
        m_oldY = TS.Y
        m_MousePressed = True

    End Sub

    Private Sub ctl_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        m_MousePressed = False
    End Sub


    Private Sub ctl_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)

        'if not maximize we can move our forms

        If m_MousePressed = True AndAlso m_WindowState <> FormWindowState.Maximized Then
            Dim TS As Point = Me.PointToScreen(e.Location)


            Me.Location = New Point(Me.Location.X + (TS.X - m_oldX), Me.Location.Y + (TS.Y - m_oldY))
            m_oldX = TS.X
            m_oldY = TS.Y
        End If

    End Sub



#End Region
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        AvatarUI.Show()
        Me.Hide()
    End Sub

    Private Sub NavPanel_Paint(sender As Object, e As PaintEventArgs) Handles NavPanel.Paint

    End Sub
End Class
