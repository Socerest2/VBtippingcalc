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
        Me.fiftip = New System.Windows.Forms.Button()
        Me.twetip = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cusam = New System.Windows.Forms.TextBox()
        Me.custpi = New System.Windows.Forms.Button()
        Me.subtext = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tipam = New System.Windows.Forms.Label()
        Me.tc = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ex = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'fiftip
        '
        Me.fiftip.Location = New System.Drawing.Point(94, 245)
        Me.fiftip.Name = "fiftip"
        Me.fiftip.Size = New System.Drawing.Size(75, 23)
        Me.fiftip.TabIndex = 0
        Me.fiftip.Text = "15% Tip"
        Me.fiftip.UseVisualStyleBackColor = True
        '
        'twetip
        '
        Me.twetip.Location = New System.Drawing.Point(218, 245)
        Me.twetip.Name = "twetip"
        Me.twetip.Size = New System.Drawing.Size(75, 23)
        Me.twetip.TabIndex = 1
        Me.twetip.Text = "20% Tip"
        Me.twetip.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Calculate Your Tip"
        '
        'cusam
        '
        Me.cusam.Location = New System.Drawing.Point(425, 246)
        Me.cusam.Name = "cusam"
        Me.cusam.Size = New System.Drawing.Size(100, 20)
        Me.cusam.TabIndex = 3
        '
        'custpi
        '
        Me.custpi.Location = New System.Drawing.Point(316, 246)
        Me.custpi.Name = "custpi"
        Me.custpi.Size = New System.Drawing.Size(87, 24)
        Me.custpi.TabIndex = 5
        Me.custpi.Text = "Custom Tip"
        Me.custpi.UseVisualStyleBackColor = True
        '
        'subtext
        '
        Me.subtext.Location = New System.Drawing.Point(359, 74)
        Me.subtext.Name = "subtext"
        Me.subtext.Size = New System.Drawing.Size(100, 20)
        Me.subtext.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cost Of Meal (Subtotal):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(268, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cost Post Tip:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(268, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tip Amount"
        '
        'tipam
        '
        Me.tipam.AutoSize = True
        Me.tipam.Location = New System.Drawing.Point(335, 114)
        Me.tipam.Name = "tipam"
        Me.tipam.Size = New System.Drawing.Size(0, 13)
        Me.tipam.TabIndex = 10
        '
        'tc
        '
        Me.tc.AutoSize = True
        Me.tc.Location = New System.Drawing.Point(347, 145)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(0, 13)
        Me.tc.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(215, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(295, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Please put custom tip in decimal formation. (e.x  0.15 for 15%)"
        '
        'ex
        '
        Me.ex.Location = New System.Drawing.Point(316, 367)
        Me.ex.Name = "ex"
        Me.ex.Size = New System.Drawing.Size(75, 23)
        Me.ex.TabIndex = 13
        Me.ex.Text = "Exit"
        Me.ex.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(743, 428)
        Me.Controls.Add(Me.ex)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.tipam)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.subtext)
        Me.Controls.Add(Me.custpi)
        Me.Controls.Add(Me.cusam)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.twetip)
        Me.Controls.Add(Me.fiftip)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fiftip As Button
    Friend WithEvents twetip As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cusam As TextBox
    Friend WithEvents custpi As Button
    Friend WithEvents subtext As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tipam As Label
    Friend WithEvents tc As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ex As Button
End Class
