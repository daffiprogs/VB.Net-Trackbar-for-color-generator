<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TBRed = New System.Windows.Forms.TrackBar()
        Me.TBGre = New System.Windows.Forms.TrackBar()
        Me.TBBlu = New System.Windows.Forms.TrackBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.REDCLR = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GRNCLR = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.BLUCLR = New System.Windows.Forms.TextBox()
        Me.TMRGen = New System.Windows.Forms.Timer(Me.components)
        CType(Me.TBRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBGre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBBlu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBRed
        '
        Me.TBRed.BackColor = System.Drawing.Color.Red
        Me.TBRed.Location = New System.Drawing.Point(17, 36)
        Me.TBRed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBRed.Maximum = 255
        Me.TBRed.Name = "TBRed"
        Me.TBRed.Size = New System.Drawing.Size(812, 56)
        Me.TBRed.TabIndex = 0
        Me.TBRed.TickFrequency = 5
        Me.TBRed.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'TBGre
        '
        Me.TBGre.BackColor = System.Drawing.Color.Lime
        Me.TBGre.Location = New System.Drawing.Point(17, 127)
        Me.TBGre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBGre.Maximum = 255
        Me.TBGre.Name = "TBGre"
        Me.TBGre.Size = New System.Drawing.Size(812, 56)
        Me.TBGre.TabIndex = 1
        Me.TBGre.TickFrequency = 5
        Me.TBGre.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'TBBlu
        '
        Me.TBBlu.BackColor = System.Drawing.Color.Blue
        Me.TBBlu.Location = New System.Drawing.Point(16, 224)
        Me.TBBlu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBBlu.Maximum = 255
        Me.TBBlu.Name = "TBBlu"
        Me.TBBlu.Size = New System.Drawing.Size(812, 56)
        Me.TBBlu.TabIndex = 2
        Me.TBBlu.TickFrequency = 5
        Me.TBBlu.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Red
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(916, 34)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Red Value"
        '
        'REDCLR
        '
        Me.REDCLR.BackColor = System.Drawing.Color.Red
        Me.REDCLR.ForeColor = System.Drawing.Color.White
        Me.REDCLR.Location = New System.Drawing.Point(916, 66)
        Me.REDCLR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.REDCLR.Name = "REDCLR"
        Me.REDCLR.ReadOnly = True
        Me.REDCLR.Size = New System.Drawing.Size(132, 22)
        Me.REDCLR.TabIndex = 4
        Me.REDCLR.Text = "0"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Lime
        Me.TextBox3.Location = New System.Drawing.Point(916, 126)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(132, 22)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.Text = "Green Value"
        '
        'GRNCLR
        '
        Me.GRNCLR.BackColor = System.Drawing.Color.Lime
        Me.GRNCLR.Location = New System.Drawing.Point(916, 158)
        Me.GRNCLR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GRNCLR.Name = "GRNCLR"
        Me.GRNCLR.Size = New System.Drawing.Size(132, 22)
        Me.GRNCLR.TabIndex = 6
        Me.GRNCLR.Text = "0"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Blue
        Me.TextBox5.ForeColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(916, 224)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(132, 22)
        Me.TextBox5.TabIndex = 7
        Me.TextBox5.Text = "Blue Value"
        '
        'BLUCLR
        '
        Me.BLUCLR.BackColor = System.Drawing.Color.Blue
        Me.BLUCLR.ForeColor = System.Drawing.Color.White
        Me.BLUCLR.Location = New System.Drawing.Point(916, 255)
        Me.BLUCLR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BLUCLR.Name = "BLUCLR"
        Me.BLUCLR.Size = New System.Drawing.Size(132, 22)
        Me.BLUCLR.TabIndex = 8
        Me.BLUCLR.Text = "0"
        '
        'TMRGen
        '
        Me.TMRGen.Enabled = True
        Me.TMRGen.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1065, 321)
        Me.Controls.Add(Me.BLUCLR)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.GRNCLR)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.REDCLR)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TBBlu)
        Me.Controls.Add(Me.TBGre)
        Me.Controls.Add(Me.TBRed)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Color Generator"
        CType(Me.TBRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBGre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBBlu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBRed As TrackBar
    Friend WithEvents TBGre As TrackBar
    Friend WithEvents TBBlu As TrackBar
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents REDCLR As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GRNCLR As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents BLUCLR As TextBox
    Friend WithEvents TMRGen As Timer
End Class
