Public Class Form1

   
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = DateAndTime.Now
    End Sub

    'Private Sub AsdBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '   Me.Validate()
    '   Me.AsdBindingSource.EndEdit()
    '   Me.TableAdapterManager.UpdateAll(Me.DatabaseforthebellDataSet)
    'End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseforthebellDataSet.asd' table. You can move, or remove it, as needed.
        Me.AsdTableAdapter.Fill(Me.DatabaseforthebellDataSet.asd)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Validate()
        Me.AsdBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseforthebellDataSet)
        MsgBox("Save It..")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AsdBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AsdBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        AsdBindingSource.AddNew()
        MsgBox("Please Insert Details..")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        AsdBindingSource.RemoveCurrent()
        MsgBox("Delete It..")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label3.Text = HTextBox.Text
        Label4.Text = MTextBox.Text
        Label5.Text = STextBox.Text

        Label8.Text = H1TextBox.Text
        Label7.Text = M1TextBox.Text
        Label6.Text = S1TextBox.Text

        Label11.Text = H2TextBox.Text
        Label10.Text = M2TextBox.Text
        Label9.Text = S2TextBox.Text

        Label14.Text = H3TextBox.Text
        Label13.Text = M3TextBox.Text
        Label12.Text = S3TextBox.Text

        Label17.Text = H4TextBox.Text
        Label16.Text = _4TextBox.Text
        Label15.Text = S4TextBox.Text

        Label20.Text = H5TextBox.Text
        Label19.Text = M5TextBox.Text
        Label18.Text = S5TextBox.Text

        Label23.Text = H6TextBox.Text
        Label22.Text = M6TextBox.Text
        Label21.Text = S6TextBox.Text

        Label70.Visible = False
        Button1.Enabled = True
        MsgBox("Done..")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
        Timer5.Start()
        Timer6.Start()
        Timer7.Start()
        Timer8.Start()

        Label70.Visible = True
        Button1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If TimeOfDay.Hour = Label3.Text Then
            If TimeOfDay.Minute = Label4.Text Then
                If TimeOfDay.Second = Label5.Text Then
                    AxWindowsMediaPlayer1.URL = "C:\Windows\DSB\Mp3\St.mp3"
                End If
            End If
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If TimeOfDay.Hour = Label8.Text Then
            If TimeOfDay.Minute = Label7.Text Then
                If TimeOfDay.Second = Label6.Text Then
                    AxWindowsMediaPlayer1.URL = "C:\Windows\DSB\Mp3\On.mp3"
                End If
            End If
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If TimeOfDay.Hour = Label11.Text Then
            If TimeOfDay.Minute = Label10.Text Then
                If TimeOfDay.Second = Label9.Text Then
                    AxWindowsMediaPlayer1.URL = "C:\Windows\DSB\Mp3\Tw.mp3"
                End If
            End If
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        If TimeOfDay.Hour = Label14.Text Then
            If TimeOfDay.Minute = Label13.Text Then
                If TimeOfDay.Second = Label12.Text Then
                    AxWindowsMediaPlayer1.URL = "C:\Windows\DSB\Mp3\In.mp3"
                End If
            End If
        End If
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        If TimeOfDay.Hour = Label17.Text Then
            If TimeOfDay.Minute = Label16.Text Then
                If TimeOfDay.Second = Label15.Text Then
                    AxWindowsMediaPlayer1.URL = "C:\Windows\DSB\Mp3\Th.mp3"
                End If
            End If
        End If
    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        If TimeOfDay.Hour = Label20.Text Then
            If TimeOfDay.Minute = Label19.Text Then
                If TimeOfDay.Second = Label18.Text Then
                    AxWindowsMediaPlayer1.URL = "C:\Windows\DSB\Mp3\Fo.mp3"
                End If
            End If
        End If
    End Sub

    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick
        If TimeOfDay.Hour = Label23.Text Then
            If TimeOfDay.Minute = Label22.Text Then
                If TimeOfDay.Second = Label21.Text Then
                    AxWindowsMediaPlayer1.URL = "C:\Windows\DSB\Mp3\En.mp3"
                End If
            End If
        End If
    End Sub
End Class
