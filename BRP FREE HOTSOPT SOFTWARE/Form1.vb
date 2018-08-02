Public Class Form1

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
         Try
            If hotspot.Text = "" Then
                MsgBox("Wifi Hotspot Name can't be empty", MsgBoxStyle.Critical, "Error...")
            End If
            If pass.TextLength < 8 Then
                MsgBox("Password should be greater or equal to 8 characters", MsgBoxStyle.Critical, "Error...")
                If pass.Text = "" Then
                    MsgBox("Password can't be empty", MsgBoxStyle.Critical, "Error...")
                End If
            Else
                Dim oProcess As New Process()
                Dim oStartInfo As New ProcessStartInfo("cmd.exe", String.Format("/c {0} & {1} & {2}", "netsh wlan set hostednetwork mode=allow ssid=" & hotspot.Text & " key=" & pass.Text, "netsh wlan start hostednetwork", "exit"))
                oStartInfo.UseShellExecute = False
                oStartInfo.RedirectStandardOutput = True
                oProcess.StartInfo = oStartInfo
                oProcess.Start()
                Dim sOutput As String
                Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
                    sOutput = oStreamReader.ReadToEnd()
                    RichTextBox1.Text = sOutput.ToString
                End Using
                If RichTextBox1.Text.Contains("The hosted network couldn't be started.") Then
                    MsgBox("Failed to establish a hotspot , Either you don't have a Wi-Fi adapter or your Wi-Fi adapter doesn't support starting a Wi-Fi hotspot", MsgBoxStyle.Critical, "Error...")
                Else
                    MsgBox("Hotspot started successfully", MsgBoxStyle.Information, "Wi-Fi Hotspot")
                    hotspot.ReadOnly = True
                    pass.ReadOnly = True
                    start.Enabled = False
                    stophotspot.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox("Failed to establish a hotspot" & ex.Message, MsgBoxStyle.Information, "Wi-Fi Hotspot")
        End Try
    End Sub

    Private Sub stophotspot_Click(sender As Object, e As EventArgs) Handles stophotspot.Click
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("cmd.exe", "/C netsh wlan stop hostednetwork")
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()
        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
            RichTextBox1.Text = sOutput.ToString
        End Using
        MsgBox("Hotspot stopped successfully", MsgBoxStyle.Information, "Wi-Fi Hotspot")
        hotspot.ReadOnly = False
        pass.ReadOnly = False
        stophotspot.Enabled = False
        start.Enabled = True
    End Sub

    Private Sub showchkbox_CheckedChanged(sender As Object, e As EventArgs) Handles showchkbox.CheckedChanged
        If showchkbox.CheckState = CheckState.Checked Then
            pass.UseSystemPasswordChar = False
        End If
        If showchkbox.CheckState = CheckState.Unchecked Then
            pass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Form1_FormClosingForWIFIHOTSPOT(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If start.Enabled = False Then
            MsgBox("Stop Wi-Fi Hotspot before closing the program.", MsgBoxStyle.Critical, "Error...")
            e.Cancel = True
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Process.Start("https://www.facebook.com/iambrp.tech")
    End Sub
End Class
