<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim VSubmissionbtn As Button
        Label1 = New Label()
        CNSubmissionbtn = New Button()
        VSubmissionbtn = New Button()
        SuspendLayout()
        ' 
        ' VSubmissionbtn
        ' 
        VSubmissionbtn.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        VSubmissionbtn.Location = New Point(36, 58)
        VSubmissionbtn.Margin = New Padding(0)
        VSubmissionbtn.Name = "VSubmissionbtn"
        VSubmissionbtn.Size = New Size(248, 23)
        VSubmissionbtn.TabIndex = 0
        VSubmissionbtn.Text = "VIEW SUBMISSIONS (CTRL + V)"
        VSubmissionbtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(36, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(248, 15)
        Label1.TabIndex = 1
        Label1.Text = "Piyush Bisen, Slidely Task 2 - Slidely Form App"
        ' 
        ' CNSubmissionbtn
        ' 
        CNSubmissionbtn.BackColor = Color.Turquoise
        CNSubmissionbtn.Location = New Point(36, 84)
        CNSubmissionbtn.Margin = New Padding(0)
        CNSubmissionbtn.Name = "CNSubmissionbtn"
        CNSubmissionbtn.Size = New Size(248, 23)
        CNSubmissionbtn.TabIndex = 2
        CNSubmissionbtn.Text = "CREATE NEW SUBMISSION (STRL + N)"
        CNSubmissionbtn.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(328, 134)
        Controls.Add(CNSubmissionbtn)
        Controls.Add(Label1)
        Controls.Add(VSubmissionbtn)
        Cursor = Cursors.No
        Name = "Form1"
        Text = "Main"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents VSubmissionbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CNSubmissionbtn As Button

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click

    End Sub

End Class
