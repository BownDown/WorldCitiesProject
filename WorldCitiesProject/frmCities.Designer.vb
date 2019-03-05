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
        Me.pnlFontStyle = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.chkBold = New System.Windows.Forms.CheckBox()
        Me.chkItalic = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblWrittenBy = New System.Windows.Forms.Label()
        Me.rtbInformation = New System.Windows.Forms.RichTextBox()
        Me.pnlCities = New System.Windows.Forms.Panel()
        Me.radYork = New System.Windows.Forms.RadioButton()
        Me.radCambridge = New System.Windows.Forms.RadioButton()
        Me.radLiverpoll = New System.Windows.Forms.RadioButton()
        Me.radBristol = New System.Windows.Forms.RadioButton()
        Me.radManchester = New System.Windows.Forms.RadioButton()
        Me.radQuezon = New System.Windows.Forms.RadioButton()
        Me.Manila = New System.Windows.Forms.RadioButton()
        Me.radIloilo = New System.Windows.Forms.RadioButton()
        Me.radBoracay = New System.Windows.Forms.RadioButton()
        Me.radBacolod = New System.Windows.Forms.RadioButton()
        Me.picCity = New System.Windows.Forms.PictureBox()
        Me.pnlFontStyle.SuspendLayout()
        Me.pnlCities.SuspendLayout()
        CType(Me.picCity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlFontStyle
        '
        Me.pnlFontStyle.Controls.Add(Me.btnReset)
        Me.pnlFontStyle.Controls.Add(Me.chkBold)
        Me.pnlFontStyle.Controls.Add(Me.chkItalic)
        Me.pnlFontStyle.Location = New System.Drawing.Point(612, 267)
        Me.pnlFontStyle.Name = "pnlFontStyle"
        Me.pnlFontStyle.Size = New System.Drawing.Size(88, 97)
        Me.pnlFontStyle.TabIndex = 0
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(0, 63)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'chkBold
        '
        Me.chkBold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBold.Location = New System.Drawing.Point(3, 3)
        Me.chkBold.Name = "chkBold"
        Me.chkBold.Size = New System.Drawing.Size(75, 24)
        Me.chkBold.TabIndex = 1
        Me.chkBold.Text = "Bold"
        Me.chkBold.UseVisualStyleBackColor = True
        '
        'chkItalic
        '
        Me.chkItalic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkItalic.Location = New System.Drawing.Point(3, 33)
        Me.chkItalic.Name = "chkItalic"
        Me.chkItalic.Size = New System.Drawing.Size(82, 24)
        Me.chkItalic.TabIndex = 2
        Me.chkItalic.Text = "Italic"
        Me.chkItalic.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(656, 526)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblWrittenBy
        '
        Me.lblWrittenBy.Location = New System.Drawing.Point(12, 468)
        Me.lblWrittenBy.Name = "lblWrittenBy"
        Me.lblWrittenBy.Size = New System.Drawing.Size(100, 23)
        Me.lblWrittenBy.TabIndex = 1
        Me.lblWrittenBy.Text = "WrittenBy"
        '
        'rtbInformation
        '
        Me.rtbInformation.Location = New System.Drawing.Point(158, 293)
        Me.rtbInformation.Name = "rtbInformation"
        Me.rtbInformation.Size = New System.Drawing.Size(448, 256)
        Me.rtbInformation.TabIndex = 2
        Me.rtbInformation.Text = ""
        '
        'pnlCities
        '
        Me.pnlCities.Controls.Add(Me.radYork)
        Me.pnlCities.Controls.Add(Me.radCambridge)
        Me.pnlCities.Controls.Add(Me.radLiverpoll)
        Me.pnlCities.Controls.Add(Me.radBristol)
        Me.pnlCities.Controls.Add(Me.radManchester)
        Me.pnlCities.Controls.Add(Me.radQuezon)
        Me.pnlCities.Controls.Add(Me.Manila)
        Me.pnlCities.Controls.Add(Me.radIloilo)
        Me.pnlCities.Controls.Add(Me.radBoracay)
        Me.pnlCities.Controls.Add(Me.radBacolod)
        Me.pnlCities.Location = New System.Drawing.Point(12, 12)
        Me.pnlCities.Name = "pnlCities"
        Me.pnlCities.Size = New System.Drawing.Size(140, 271)
        Me.pnlCities.TabIndex = 3
        '
        'radYork
        '
        Me.radYork.Location = New System.Drawing.Point(4, 218)
        Me.radYork.Name = "radYork"
        Me.radYork.Size = New System.Drawing.Size(104, 24)
        Me.radYork.TabIndex = 9
        Me.radYork.TabStop = True
        Me.radYork.Text = "York"
        Me.radYork.UseVisualStyleBackColor = True
        '
        'radCambridge
        '
        Me.radCambridge.Location = New System.Drawing.Point(4, 196)
        Me.radCambridge.Name = "radCambridge"
        Me.radCambridge.Size = New System.Drawing.Size(104, 24)
        Me.radCambridge.TabIndex = 8
        Me.radCambridge.TabStop = True
        Me.radCambridge.Text = "Cambridge"
        Me.radCambridge.UseVisualStyleBackColor = True
        '
        'radLiverpoll
        '
        Me.radLiverpoll.Location = New System.Drawing.Point(4, 173)
        Me.radLiverpoll.Name = "radLiverpoll"
        Me.radLiverpoll.Size = New System.Drawing.Size(104, 24)
        Me.radLiverpoll.TabIndex = 7
        Me.radLiverpoll.TabStop = True
        Me.radLiverpoll.Text = "Liverpool"
        Me.radLiverpoll.UseVisualStyleBackColor = True
        '
        'radBristol
        '
        Me.radBristol.Location = New System.Drawing.Point(4, 148)
        Me.radBristol.Name = "radBristol"
        Me.radBristol.Size = New System.Drawing.Size(104, 24)
        Me.radBristol.TabIndex = 6
        Me.radBristol.TabStop = True
        Me.radBristol.Text = "Bristol"
        Me.radBristol.UseVisualStyleBackColor = True
        '
        'radManchester
        '
        Me.radManchester.Location = New System.Drawing.Point(4, 124)
        Me.radManchester.Name = "radManchester"
        Me.radManchester.Size = New System.Drawing.Size(104, 24)
        Me.radManchester.TabIndex = 5
        Me.radManchester.TabStop = True
        Me.radManchester.Text = "Mancherster"
        Me.radManchester.UseVisualStyleBackColor = True
        '
        'radQuezon
        '
        Me.radQuezon.Location = New System.Drawing.Point(4, 100)
        Me.radQuezon.Name = "radQuezon"
        Me.radQuezon.Size = New System.Drawing.Size(104, 24)
        Me.radQuezon.TabIndex = 4
        Me.radQuezon.TabStop = True
        Me.radQuezon.Text = "Quezon City"
        Me.radQuezon.UseVisualStyleBackColor = True
        '
        'Manila
        '
        Me.Manila.Location = New System.Drawing.Point(4, 76)
        Me.Manila.Name = "Manila"
        Me.Manila.Size = New System.Drawing.Size(104, 24)
        Me.Manila.TabIndex = 3
        Me.Manila.TabStop = True
        Me.Manila.Text = "Manila"
        Me.Manila.UseVisualStyleBackColor = True
        '
        'radIloilo
        '
        Me.radIloilo.Location = New System.Drawing.Point(4, 52)
        Me.radIloilo.Name = "radIloilo"
        Me.radIloilo.Size = New System.Drawing.Size(104, 24)
        Me.radIloilo.TabIndex = 2
        Me.radIloilo.TabStop = True
        Me.radIloilo.Text = "Iloilo City"
        Me.radIloilo.UseVisualStyleBackColor = True
        '
        'radBoracay
        '
        Me.radBoracay.Location = New System.Drawing.Point(4, 28)
        Me.radBoracay.Name = "radBoracay"
        Me.radBoracay.Size = New System.Drawing.Size(104, 24)
        Me.radBoracay.TabIndex = 1
        Me.radBoracay.TabStop = True
        Me.radBoracay.Text = "Boracay"
        Me.radBoracay.UseVisualStyleBackColor = True
        '
        'radBacolod
        '
        Me.radBacolod.Location = New System.Drawing.Point(4, 4)
        Me.radBacolod.Name = "radBacolod"
        Me.radBacolod.Size = New System.Drawing.Size(104, 24)
        Me.radBacolod.TabIndex = 0
        Me.radBacolod.TabStop = True
        Me.radBacolod.Text = "Bacolod"
        Me.radBacolod.UseVisualStyleBackColor = True
        '
        'picCity
        '
        Me.picCity.Location = New System.Drawing.Point(158, 12)
        Me.picCity.Name = "picCity"
        Me.picCity.Size = New System.Drawing.Size(448, 271)
        Me.picCity.TabIndex = 4
        Me.picCity.TabStop = False
        '
        'frmCities
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.picCity)
        Me.Controls.Add(Me.pnlCities)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.rtbInformation)
        Me.Controls.Add(Me.lblWrittenBy)
        Me.Controls.Add(Me.pnlFontStyle)
        Me.Name = "frmCities"
        Me.Text = "World Cities: Philippines and United Kindgom"
        Me.pnlFontStyle.ResumeLayout(False)
        Me.pnlCities.ResumeLayout(False)
        CType(Me.picCity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFontStyle As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents chkBold As CheckBox
    Friend WithEvents chkItalic As CheckBox
    Friend WithEvents btnReset As Button
    Friend WithEvents lblWrittenBy As Label
    Friend WithEvents rtbInformation As RichTextBox
    Friend WithEvents pnlCities As Panel
    Friend WithEvents picCity As PictureBox
    Friend WithEvents radYork As RadioButton
    Friend WithEvents radCambridge As RadioButton
    Friend WithEvents radLiverpoll As RadioButton
    Friend WithEvents radBristol As RadioButton
    Friend WithEvents radManchester As RadioButton
    Friend WithEvents radQuezon As RadioButton
    Friend WithEvents Manila As RadioButton
    Friend WithEvents radIloilo As RadioButton
    Friend WithEvents radBoracay As RadioButton
    Friend WithEvents radBacolod As RadioButton
End Class
