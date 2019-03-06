<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCities
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
        Me.picCities = New System.Windows.Forms.PictureBox()
        Me.rtbInformation = New System.Windows.Forms.RichTextBox()
        Me.lstCountries = New System.Windows.Forms.ListBox()
        Me.pnlCities = New System.Windows.Forms.Panel()
        Me.radCity4 = New System.Windows.Forms.RadioButton()
        Me.radCity3 = New System.Windows.Forms.RadioButton()
        Me.radCity2 = New System.Windows.Forms.RadioButton()
        Me.radCity1 = New System.Windows.Forms.RadioButton()
        Me.pnlFormatControl = New System.Windows.Forms.Panel()
        Me.btnItalic = New System.Windows.Forms.Button()
        Me.btnUnderline = New System.Windows.Forms.Button()
        Me.btnBold = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDesignedby = New System.Windows.Forms.Label()
        Me.btnRest = New System.Windows.Forms.Button()
        CType(Me.picCities, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCities.SuspendLayout()
        Me.pnlFormatControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'picCities
        '
        Me.picCities.Location = New System.Drawing.Point(13, 34)
        Me.picCities.Name = "picCities"
        Me.picCities.Size = New System.Drawing.Size(556, 217)
        Me.picCities.TabIndex = 0
        Me.picCities.TabStop = False
        '
        'rtbInformation
        '
        Me.rtbInformation.Location = New System.Drawing.Point(13, 257)
        Me.rtbInformation.Name = "rtbInformation"
        Me.rtbInformation.Size = New System.Drawing.Size(556, 266)
        Me.rtbInformation.TabIndex = 1
        Me.rtbInformation.Text = ""
        '
        'lstCountries
        '
        Me.lstCountries.FormattingEnabled = True
        Me.lstCountries.Items.AddRange(New Object() {"Philippines", "United Kingdom", "Russia", "United States"})
        Me.lstCountries.Location = New System.Drawing.Point(576, 34)
        Me.lstCountries.Name = "lstCountries"
        Me.lstCountries.Size = New System.Drawing.Size(196, 147)
        Me.lstCountries.TabIndex = 2
        '
        'pnlCities
        '
        Me.pnlCities.Controls.Add(Me.radCity4)
        Me.pnlCities.Controls.Add(Me.radCity3)
        Me.pnlCities.Controls.Add(Me.radCity2)
        Me.pnlCities.Controls.Add(Me.radCity1)
        Me.pnlCities.Location = New System.Drawing.Point(576, 187)
        Me.pnlCities.Name = "pnlCities"
        Me.pnlCities.Size = New System.Drawing.Size(200, 160)
        Me.pnlCities.TabIndex = 3
        '
        'radCity4
        '
        Me.radCity4.Location = New System.Drawing.Point(4, 94)
        Me.radCity4.Name = "radCity4"
        Me.radCity4.Size = New System.Drawing.Size(104, 24)
        Me.radCity4.TabIndex = 3
        Me.radCity4.TabStop = True
        Me.radCity4.Text = "City4"
        Me.radCity4.UseVisualStyleBackColor = True
        '
        'radCity3
        '
        Me.radCity3.Location = New System.Drawing.Point(4, 70)
        Me.radCity3.Name = "radCity3"
        Me.radCity3.Size = New System.Drawing.Size(104, 24)
        Me.radCity3.TabIndex = 2
        Me.radCity3.TabStop = True
        Me.radCity3.Text = "City3"
        Me.radCity3.UseVisualStyleBackColor = True
        '
        'radCity2
        '
        Me.radCity2.Location = New System.Drawing.Point(4, 46)
        Me.radCity2.Name = "radCity2"
        Me.radCity2.Size = New System.Drawing.Size(104, 24)
        Me.radCity2.TabIndex = 1
        Me.radCity2.TabStop = True
        Me.radCity2.Text = "City2"
        Me.radCity2.UseVisualStyleBackColor = True
        '
        'radCity1
        '
        Me.radCity1.Location = New System.Drawing.Point(4, 22)
        Me.radCity1.Name = "radCity1"
        Me.radCity1.Size = New System.Drawing.Size(104, 24)
        Me.radCity1.TabIndex = 0
        Me.radCity1.TabStop = True
        Me.radCity1.Text = "City1"
        Me.radCity1.UseVisualStyleBackColor = True
        '
        'pnlFormatControl
        '
        Me.pnlFormatControl.Controls.Add(Me.btnItalic)
        Me.pnlFormatControl.Controls.Add(Me.btnUnderline)
        Me.pnlFormatControl.Controls.Add(Me.btnBold)
        Me.pnlFormatControl.Location = New System.Drawing.Point(580, 354)
        Me.pnlFormatControl.Name = "pnlFormatControl"
        Me.pnlFormatControl.Size = New System.Drawing.Size(133, 140)
        Me.pnlFormatControl.TabIndex = 4
        '
        'btnItalic
        '
        Me.btnItalic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItalic.Location = New System.Drawing.Point(36, 94)
        Me.btnItalic.Name = "btnItalic"
        Me.btnItalic.Size = New System.Drawing.Size(75, 23)
        Me.btnItalic.TabIndex = 2
        Me.btnItalic.Text = "Italic"
        Me.btnItalic.UseVisualStyleBackColor = True
        '
        'btnUnderline
        '
        Me.btnUnderline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnderline.Location = New System.Drawing.Point(36, 65)
        Me.btnUnderline.Name = "btnUnderline"
        Me.btnUnderline.Size = New System.Drawing.Size(75, 23)
        Me.btnUnderline.TabIndex = 1
        Me.btnUnderline.Text = "Underline"
        Me.btnUnderline.UseVisualStyleBackColor = True
        '
        'btnBold
        '
        Me.btnBold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBold.Location = New System.Drawing.Point(36, 36)
        Me.btnBold.Name = "btnBold"
        Me.btnBold.Size = New System.Drawing.Size(75, 23)
        Me.btnBold.TabIndex = 0
        Me.btnBold.Text = "Bold"
        Me.btnBold.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(701, 526)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDesignedby
        '
        Me.lblDesignedby.AutoSize = True
        Me.lblDesignedby.Location = New System.Drawing.Point(10, 526)
        Me.lblDesignedby.Name = "lblDesignedby"
        Me.lblDesignedby.Size = New System.Drawing.Size(277, 13)
        Me.lblDesignedby.TabIndex = 6
        Me.lblDesignedby.Text = "Louie Escalera,Linda Lim,Elizabeth Robinson,Neil Wiborg"
        '
        'btnRest
        '
        Me.btnRest.Location = New System.Drawing.Point(701, 500)
        Me.btnRest.Name = "btnRest"
        Me.btnRest.Size = New System.Drawing.Size(75, 23)
        Me.btnRest.TabIndex = 7
        Me.btnRest.Text = "Reset"
        Me.btnRest.UseVisualStyleBackColor = True
        '
        'frmCities
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnRest)
        Me.Controls.Add(Me.lblDesignedby)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pnlFormatControl)
        Me.Controls.Add(Me.pnlCities)
        Me.Controls.Add(Me.lstCountries)
        Me.Controls.Add(Me.rtbInformation)
        Me.Controls.Add(Me.picCities)
        Me.Name = "frmCities"
        Me.Text = "World Cities"
        CType(Me.picCities, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCities.ResumeLayout(False)
        Me.pnlFormatControl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picCities As PictureBox
    Friend WithEvents rtbInformation As RichTextBox
    Friend WithEvents lstCountries As ListBox
    Friend WithEvents pnlCities As Panel
    Friend WithEvents pnlFormatControl As Panel
    Friend WithEvents btnItalic As Button
    Friend WithEvents btnUnderline As Button
    Friend WithEvents btnBold As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDesignedby As Label
    Friend WithEvents radCity4 As RadioButton
    Friend WithEvents radCity3 As RadioButton
    Friend WithEvents radCity2 As RadioButton
    Friend WithEvents radCity1 As RadioButton
    Friend WithEvents btnRest As Button
End Class
