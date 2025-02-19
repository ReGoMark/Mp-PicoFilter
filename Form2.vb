﻿Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentUser As String = Environment.UserName
        Label7.Text = "授权用户：" & currentUser
        TextBox1.SelectionStart = 0
        TextBox1.SelectionLength = 0 ' 确保未选中文本
        PlayNotificationSound()
    End Sub

    Private Sub Form2_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.Close()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim url As String = "https://github.com/ReGoMark/PicoFilter"
        Try
            ' 使用默认浏览器打开网页
            Process.Start(url)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub PlayNotificationSound()
        Try
            ' 从资源播放音效
            My.Computer.Audio.Play(My.Resources.INFO, AudioPlayMode.Background)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click
        PictureBox1.Visible = True
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Process1.StartInfo.UseShellExecute = True
        Process1.StartInfo.FileName = Application.StartupPath & "\tutorial.mp4"

        '' 显示文件路径以便调试
        'MessageBox.Show("尝试打开文件: " & Process1.StartInfo.FileName)

        Try
            Process1.Start()
        Catch ex As Exception
            MessageBox.Show("无法打开视频教程，请检查文件是否存在。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Me.CenterToScreen()
    End Sub
End Class