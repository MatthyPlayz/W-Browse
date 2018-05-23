<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.searchinput = New System.Windows.Forms.TextBox()
        Me.gsearch = New System.Windows.Forms.Button()
        Me.urlsearch = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.forward = New System.Windows.Forms.Button()
        Me.browser = New System.Windows.Forms.WebBrowser()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'searchinput
        '
        Me.searchinput.Location = New System.Drawing.Point(0, 3)
        Me.searchinput.Name = "searchinput"
        Me.searchinput.Size = New System.Drawing.Size(616, 20)
        Me.searchinput.TabIndex = 1
        '
        'gsearch
        '
        Me.gsearch.Location = New System.Drawing.Point(622, 3)
        Me.gsearch.Name = "gsearch"
        Me.gsearch.Size = New System.Drawing.Size(87, 23)
        Me.gsearch.TabIndex = 2
        Me.gsearch.Text = "Search Google"
        Me.gsearch.UseVisualStyleBackColor = True
        '
        'urlsearch
        '
        Me.urlsearch.Location = New System.Drawing.Point(715, 3)
        Me.urlsearch.Name = "urlsearch"
        Me.urlsearch.Size = New System.Drawing.Size(75, 23)
        Me.urlsearch.TabIndex = 3
        Me.urlsearch.Text = "Search URL"
        Me.urlsearch.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Image = Global.W__Browse.My.Resources.Resources.back1
        Me.back.Location = New System.Drawing.Point(0, 26)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(30, 23)
        Me.back.TabIndex = 5
        Me.back.UseVisualStyleBackColor = True
        '
        'forward
        '
        Me.forward.Image = Global.W__Browse.My.Resources.Resources.forward
        Me.forward.Location = New System.Drawing.Point(36, 26)
        Me.forward.Name = "forward"
        Me.forward.Size = New System.Drawing.Size(30, 23)
        Me.forward.TabIndex = 4
        Me.forward.UseVisualStyleBackColor = True
        '
        'browser
        '
        Me.browser.Location = New System.Drawing.Point(0, 48)
        Me.browser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.browser.Name = "browser"
        Me.browser.Size = New System.Drawing.Size(799, 400)
        Me.browser.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(72, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Windowed Fullscreen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(197, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Windowed"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.browser)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.forward)
        Me.Controls.Add(Me.urlsearch)
        Me.Controls.Add(Me.gsearch)
        Me.Controls.Add(Me.searchinput)
        Me.Name = "Form1"
        Me.Text = "W))Browse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents searchinput As TextBox
    Friend WithEvents gsearch As Button
    Friend WithEvents urlsearch As Button
    Friend WithEvents forward As Button
    Friend WithEvents back As Button
    Friend WithEvents browser As WebBrowser
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
