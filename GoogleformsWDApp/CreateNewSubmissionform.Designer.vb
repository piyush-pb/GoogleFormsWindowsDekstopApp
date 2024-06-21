Imports System.Diagnostics
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateNewSubmissionform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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

    'Stopwatch instance
    Private stopwatch As Stopwatch
    Private stopwatchTimer As Timer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        NameLabel = New Label()
        Email = New Label()
        Phone = New Label()
        Github = New Label()
        Namevalue = New TextBox()
        Emailvalue = New TextBox()
        Phonevalue = New TextBox()
        Githubvalue = New TextBox()
        StopwatchButton = New Button()
        Submit = New Button()
        StopwatchLabel = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(57, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(256, 15)
        Label1.TabIndex = 0
        Label1.Text = "Piyush Bisen, Slidely Task 2 - Create Submission"
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.Location = New Point(73, 71)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(39, 15)
        NameLabel.TabIndex = 1
        NameLabel.Text = "Name"
        ' 
        ' Email
        ' 
        Email.AutoSize = True
        Email.Location = New Point(73, 108)
        Email.Name = "Email"
        Email.Size = New Size(36, 15)
        Email.TabIndex = 2
        Email.Text = "Email"
        ' 
        ' Phone
        ' 
        Phone.AutoSize = True
        Phone.Location = New Point(57, 142)
        Phone.Name = "Phone"
        Phone.Size = New Size(71, 15)
        Phone.TabIndex = 3
        Phone.Text = "Phone Num"
        ' 
        ' Github
        ' 
        Github.AutoSize = True
        Github.Location = New Point(31, 178)
        Github.Name = "Github"
        Github.Size = New Size(122, 15)
        Github.TabIndex = 4
        Github.Text = "Github Link For Task 2"
        ' 
        ' Namevalue
        ' 
        Namevalue.Location = New Point(171, 71)
        Namevalue.Name = "Namevalue"
        Namevalue.Size = New Size(164, 23)
        Namevalue.TabIndex = 5
        ' 
        ' Emailvalue
        ' 
        Emailvalue.Location = New Point(171, 105)
        Emailvalue.Name = "Emailvalue"
        Emailvalue.Size = New Size(164, 23)
        Emailvalue.TabIndex = 6
        ' 
        ' Phonevalue
        ' 
        Phonevalue.Location = New Point(171, 139)
        Phonevalue.Name = "Phonevalue"
        Phonevalue.Size = New Size(164, 23)
        Phonevalue.TabIndex = 7
        ' 
        ' Githubvalue
        ' 
        Githubvalue.Location = New Point(171, 175)
        Githubvalue.Name = "Githubvalue"
        Githubvalue.Size = New Size(164, 23)
        Githubvalue.TabIndex = 8
        ' 
        ' StopwatchButton
        ' 
        StopwatchButton.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        StopwatchButton.Location = New Point(57, 222)
        StopwatchButton.Name = "StopwatchButton"
        StopwatchButton.Size = New Size(194, 23)
        StopwatchButton.TabIndex = 9
        StopwatchButton.Text = "TOGGLE STOPWATCH ( CTRL +T )"
        StopwatchButton.UseVisualStyleBackColor = False
        ' 
        ' Submit
        ' 
        Submit.BackColor = Color.Turquoise
        Submit.Location = New Point(73, 261)
        Submit.Name = "Submit"
        Submit.Size = New Size(262, 23)
        Submit.TabIndex = 10
        Submit.Text = "SUBMIT ( CTRL + S )"
        Submit.UseVisualStyleBackColor = False
        ' 
        ' StopwatchLabel
        ' 
        StopwatchLabel.AutoSize = True
        StopwatchLabel.Location = New Point(257, 226)
        StopwatchLabel.Name = "StopwatchLabel"
        StopwatchLabel.Size = New Size(70, 15)
        StopwatchLabel.TabIndex = 11
        StopwatchLabel.Text = "00:00:00.000"
        ' 
        ' CreateNewSubmissionform
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(369, 326)
        Controls.Add(StopwatchLabel)
        Controls.Add(Submit)
        Controls.Add(StopwatchButton)
        Controls.Add(Githubvalue)
        Controls.Add(Phonevalue)
        Controls.Add(Emailvalue)
        Controls.Add(Namevalue)
        Controls.Add(Github)
        Controls.Add(Phone)
        Controls.Add(Email)
        Controls.Add(NameLabel)
        Controls.Add(Label1)
        Name = "CreateNewSubmissionform"
        Text = "CreateNewSubmissionform"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents Label1 As Label
    Private WithEvents NameLabel As Label
    Private WithEvents Email As Label
    Private WithEvents Phone As Label
    Private WithEvents Github As Label
    Private WithEvents Namevalue As TextBox
    Private WithEvents Emailvalue As TextBox
    Private WithEvents Phonevalue As TextBox
    Private WithEvents Githubvalue As TextBox
    Private WithEvents StopwatchButton As Button
    Private WithEvents Submit As Button
    Private WithEvents StopwatchLabel As Label

    Private Sub CreateNewSubmissionform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stopwatch = New Stopwatch()
        stopwatchTimer = New Timer()
        stopwatchTimer.Interval = 100
        AddHandler stopwatchTimer.Tick, AddressOf UpdateStopwatchLabel
    End Sub

    Private Sub StopwatchButton_Click(sender As Object, e As EventArgs) Handles StopwatchButton.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            stopwatchTimer.Stop()
        Else
            stopwatch.Start()
            stopwatchTimer.Start()
        End If
    End Sub

    Private Sub UpdateStopwatchLabel(sender As Object, e As EventArgs)
        StopwatchLabel.Text = String.Format("{0:hh\:mm\:ss\.fff}", stopwatch.Elapsed)
    End Sub
End Class
