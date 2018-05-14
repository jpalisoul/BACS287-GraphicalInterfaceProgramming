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
        Me.components = New System.ComponentModel.Container()
        Me.grpRadChk = New System.Windows.Forms.GroupBox()
        Me.btnResetTextbox = New System.Windows.Forms.Button()
        Me.chkUnderline = New System.Windows.Forms.CheckBox()
        Me.chkItalic = New System.Windows.Forms.CheckBox()
        Me.chkBold = New System.Windows.Forms.CheckBox()
        Me.radMsg3 = New System.Windows.Forms.RadioButton()
        Me.radMsg2 = New System.Windows.Forms.RadioButton()
        Me.radMsg1 = New System.Windows.Forms.RadioButton()
        Me.txtStyleExample = New System.Windows.Forms.TextBox()
        Me.grpColor = New System.Windows.Forms.GroupBox()
        Me.btnSetColor = New System.Windows.Forms.Button()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.txtGreen = New System.Windows.Forms.TextBox()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.txtRed = New System.Windows.Forms.TextBox()
        Me.scrGreen = New System.Windows.Forms.HScrollBar()
        Me.scrBlue = New System.Windows.Forms.HScrollBar()
        Me.scrRed = New System.Windows.Forms.HScrollBar()
        Me.lblUnboundList = New System.Windows.Forms.Label()
        Me.lstUnboundList = New System.Windows.Forms.ListBox()
        Me.lblCkListBox = New System.Windows.Forms.Label()
        Me.lblDropDownCombo = New System.Windows.Forms.Label()
        Me.lstDropDownCombo = New System.Windows.Forms.ComboBox()
        Me.clbCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.grpMouseWork = New System.Windows.Forms.GroupBox()
        Me.btnMouseClear = New System.Windows.Forms.Button()
        Me.btnMouseOver = New System.Windows.Forms.Button()
        Me.txtMouseWork = New System.Windows.Forms.TextBox()
        Me.grpWebWork = New System.Windows.Forms.GroupBox()
        Me.radMicrosoft = New System.Windows.Forms.RadioButton()
        Me.rad287 = New System.Windows.Forms.RadioButton()
        Me.radMCB = New System.Windows.Forms.RadioButton()
        Me.radURSA = New System.Windows.Forms.RadioButton()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.grpFileWork = New System.Windows.Forms.GroupBox()
        Me.lblFileWork = New System.Windows.Forms.Label()
        Me.filFileWork = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox()
        Me.dirFileWork = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox()
        Me.drvFileWork = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox()
        Me.picImageDisplay = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpRadChk.SuspendLayout()
        Me.grpColor.SuspendLayout()
        Me.grpMouseWork.SuspendLayout()
        Me.grpWebWork.SuspendLayout()
        Me.grpFileWork.SuspendLayout()
        CType(Me.picImageDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpRadChk
        '
        Me.grpRadChk.Controls.Add(Me.btnResetTextbox)
        Me.grpRadChk.Controls.Add(Me.chkUnderline)
        Me.grpRadChk.Controls.Add(Me.chkItalic)
        Me.grpRadChk.Controls.Add(Me.chkBold)
        Me.grpRadChk.Controls.Add(Me.radMsg3)
        Me.grpRadChk.Controls.Add(Me.radMsg2)
        Me.grpRadChk.Controls.Add(Me.radMsg1)
        Me.grpRadChk.Controls.Add(Me.txtStyleExample)
        Me.grpRadChk.Location = New System.Drawing.Point(23, 508)
        Me.grpRadChk.Name = "grpRadChk"
        Me.grpRadChk.Size = New System.Drawing.Size(250, 309)
        Me.grpRadChk.TabIndex = 0
        Me.grpRadChk.TabStop = False
        Me.grpRadChk.Text = "Radio  Check Box Area"
        '
        'btnResetTextbox
        '
        Me.btnResetTextbox.Location = New System.Drawing.Point(46, 260)
        Me.btnResetTextbox.Name = "btnResetTextbox"
        Me.btnResetTextbox.Size = New System.Drawing.Size(142, 36)
        Me.btnResetTextbox.TabIndex = 7
        Me.btnResetTextbox.Text = "R&eset Textbox"
        Me.btnResetTextbox.UseVisualStyleBackColor = True
        '
        'chkUnderline
        '
        Me.chkUnderline.AutoSize = True
        Me.chkUnderline.Location = New System.Drawing.Point(143, 220)
        Me.chkUnderline.Name = "chkUnderline"
        Me.chkUnderline.Size = New System.Drawing.Size(85, 20)
        Me.chkUnderline.TabIndex = 6
        Me.chkUnderline.Text = "Underline"
        Me.chkUnderline.UseVisualStyleBackColor = True
        '
        'chkItalic
        '
        Me.chkItalic.AutoSize = True
        Me.chkItalic.Location = New System.Drawing.Point(145, 157)
        Me.chkItalic.Name = "chkItalic"
        Me.chkItalic.Size = New System.Drawing.Size(83, 20)
        Me.chkItalic.TabIndex = 5
        Me.chkItalic.Text = "Italic Text"
        Me.chkItalic.UseVisualStyleBackColor = True
        '
        'chkBold
        '
        Me.chkBold.AutoSize = True
        Me.chkBold.Location = New System.Drawing.Point(144, 91)
        Me.chkBold.Name = "chkBold"
        Me.chkBold.Size = New System.Drawing.Size(84, 20)
        Me.chkBold.TabIndex = 4
        Me.chkBold.Text = "Bold Text"
        Me.chkBold.UseVisualStyleBackColor = True
        '
        'radMsg3
        '
        Me.radMsg3.AutoSize = True
        Me.radMsg3.Location = New System.Drawing.Point(18, 219)
        Me.radMsg3.Name = "radMsg3"
        Me.radMsg3.Size = New System.Drawing.Size(93, 20)
        Me.radMsg3.TabIndex = 3
        Me.radMsg3.TabStop = True
        Me.radMsg3.Text = "Message 3"
        Me.radMsg3.UseVisualStyleBackColor = True
        '
        'radMsg2
        '
        Me.radMsg2.AutoSize = True
        Me.radMsg2.Location = New System.Drawing.Point(18, 157)
        Me.radMsg2.Name = "radMsg2"
        Me.radMsg2.Size = New System.Drawing.Size(93, 20)
        Me.radMsg2.TabIndex = 2
        Me.radMsg2.TabStop = True
        Me.radMsg2.Text = "Message 2"
        Me.radMsg2.UseVisualStyleBackColor = True
        '
        'radMsg1
        '
        Me.radMsg1.AutoSize = True
        Me.radMsg1.Location = New System.Drawing.Point(18, 90)
        Me.radMsg1.Name = "radMsg1"
        Me.radMsg1.Size = New System.Drawing.Size(93, 20)
        Me.radMsg1.TabIndex = 1
        Me.radMsg1.TabStop = True
        Me.radMsg1.Text = "Message 1"
        Me.radMsg1.UseVisualStyleBackColor = True
        '
        'txtStyleExample
        '
        Me.txtStyleExample.Location = New System.Drawing.Point(18, 34)
        Me.txtStyleExample.Name = "txtStyleExample"
        Me.txtStyleExample.Size = New System.Drawing.Size(210, 22)
        Me.txtStyleExample.TabIndex = 0
        '
        'grpColor
        '
        Me.grpColor.Controls.Add(Me.btnSetColor)
        Me.grpColor.Controls.Add(Me.lblBlue)
        Me.grpColor.Controls.Add(Me.lblGreen)
        Me.grpColor.Controls.Add(Me.txtGreen)
        Me.grpColor.Controls.Add(Me.lblRed)
        Me.grpColor.Controls.Add(Me.txtBlue)
        Me.grpColor.Controls.Add(Me.txtRed)
        Me.grpColor.Controls.Add(Me.scrGreen)
        Me.grpColor.Controls.Add(Me.scrBlue)
        Me.grpColor.Controls.Add(Me.scrRed)
        Me.grpColor.Location = New System.Drawing.Point(23, 41)
        Me.grpColor.Name = "grpColor"
        Me.grpColor.Size = New System.Drawing.Size(250, 418)
        Me.grpColor.TabIndex = 1
        Me.grpColor.TabStop = False
        Me.grpColor.Text = "Set Form Color"
        '
        'btnSetColor
        '
        Me.btnSetColor.Location = New System.Drawing.Point(51, 357)
        Me.btnSetColor.Name = "btnSetColor"
        Me.btnSetColor.Size = New System.Drawing.Size(142, 36)
        Me.btnSetColor.TabIndex = 9
        Me.btnSetColor.Text = "&Set Color"
        Me.btnSetColor.UseVisualStyleBackColor = True
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Location = New System.Drawing.Point(35, 205)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(73, 16)
        Me.lblBlue.TabIndex = 8
        Me.lblBlue.Text = "Blue Value"
        '
        'lblGreen
        '
        Me.lblGreen.AutoSize = True
        Me.lblGreen.Location = New System.Drawing.Point(35, 314)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(83, 16)
        Me.lblGreen.TabIndex = 7
        Me.lblGreen.Text = "Green Value"
        '
        'txtGreen
        '
        Me.txtGreen.Location = New System.Drawing.Point(176, 311)
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.Size = New System.Drawing.Size(57, 22)
        Me.txtGreen.TabIndex = 4
        Me.txtGreen.Text = "0"
        '
        'lblRed
        '
        Me.lblRed.AutoSize = True
        Me.lblRed.Location = New System.Drawing.Point(35, 88)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(72, 16)
        Me.lblRed.TabIndex = 6
        Me.lblRed.Text = "Red Value"
        '
        'txtBlue
        '
        Me.txtBlue.Location = New System.Drawing.Point(176, 202)
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(57, 22)
        Me.txtBlue.TabIndex = 5
        Me.txtBlue.Text = "0"
        '
        'txtRed
        '
        Me.txtRed.Location = New System.Drawing.Point(176, 88)
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(57, 22)
        Me.txtRed.TabIndex = 3
        Me.txtRed.Text = "0"
        '
        'scrGreen
        '
        Me.scrGreen.Location = New System.Drawing.Point(23, 256)
        Me.scrGreen.Maximum = 255
        Me.scrGreen.Name = "scrGreen"
        Me.scrGreen.Size = New System.Drawing.Size(210, 30)
        Me.scrGreen.TabIndex = 1
        '
        'scrBlue
        '
        Me.scrBlue.Location = New System.Drawing.Point(23, 144)
        Me.scrBlue.Maximum = 255
        Me.scrBlue.Name = "scrBlue"
        Me.scrBlue.Size = New System.Drawing.Size(210, 30)
        Me.scrBlue.TabIndex = 2
        '
        'scrRed
        '
        Me.scrRed.Location = New System.Drawing.Point(23, 39)
        Me.scrRed.Maximum = 255
        Me.scrRed.Name = "scrRed"
        Me.scrRed.Size = New System.Drawing.Size(210, 30)
        Me.scrRed.TabIndex = 0
        '
        'lblUnboundList
        '
        Me.lblUnboundList.AutoSize = True
        Me.lblUnboundList.Location = New System.Drawing.Point(383, 55)
        Me.lblUnboundList.Name = "lblUnboundList"
        Me.lblUnboundList.Size = New System.Drawing.Size(112, 16)
        Me.lblUnboundList.TabIndex = 2
        Me.lblUnboundList.Text = "Unbound List Box"
        '
        'lstUnboundList
        '
        Me.lstUnboundList.FormattingEnabled = True
        Me.lstUnboundList.ItemHeight = 16
        Me.lstUnboundList.Items.AddRange(New Object() {"C. Collum", "T. Harrah", "J. Lightfoot", "A. McConnell", "D. Rush", "R. Reed", "T. Sedbrook", "K. Turner", "C. Vegter"})
        Me.lstUnboundList.Location = New System.Drawing.Point(357, 83)
        Me.lstUnboundList.Name = "lstUnboundList"
        Me.lstUnboundList.Size = New System.Drawing.Size(166, 132)
        Me.lstUnboundList.TabIndex = 3
        '
        'lblCkListBox
        '
        Me.lblCkListBox.AutoSize = True
        Me.lblCkListBox.Location = New System.Drawing.Point(383, 329)
        Me.lblCkListBox.Name = "lblCkListBox"
        Me.lblCkListBox.Size = New System.Drawing.Size(111, 16)
        Me.lblCkListBox.TabIndex = 4
        Me.lblCkListBox.Text = "Checked List Box"
        '
        'lblDropDownCombo
        '
        Me.lblDropDownCombo.AutoSize = True
        Me.lblDropDownCombo.Location = New System.Drawing.Point(367, 243)
        Me.lblDropDownCombo.Name = "lblDropDownCombo"
        Me.lblDropDownCombo.Size = New System.Drawing.Size(143, 16)
        Me.lblDropDownCombo.TabIndex = 5
        Me.lblDropDownCombo.Text = "Dropdown Combo Box"
        '
        'lstDropDownCombo
        '
        Me.lstDropDownCombo.FormattingEnabled = True
        Me.lstDropDownCombo.Items.AddRange(New Object() {"BACS 101", "BACS 200", "BACS 287", "BACS 300", "BACS 387", "BACS 371", "BACS 380", "BACS 381", "BACS 485", "BACS 486", "BACS 487", "BACS 488", "BACS 305"})
        Me.lstDropDownCombo.Location = New System.Drawing.Point(357, 272)
        Me.lstDropDownCombo.Name = "lstDropDownCombo"
        Me.lstDropDownCombo.Size = New System.Drawing.Size(166, 24)
        Me.lstDropDownCombo.TabIndex = 6
        '
        'clbCheckedList
        '
        Me.clbCheckedList.FormattingEnabled = True
        Me.clbCheckedList.Items.AddRange(New Object() {"BACS 101", "BACS 200", "BACS 287", "BACS 300", "BACS 380", "BACS 385", "BACS 387", "BACS 485", "BACS 487"})
        Me.clbCheckedList.Location = New System.Drawing.Point(357, 355)
        Me.clbCheckedList.Name = "clbCheckedList"
        Me.clbCheckedList.Size = New System.Drawing.Size(166, 123)
        Me.clbCheckedList.TabIndex = 7
        '
        'grpMouseWork
        '
        Me.grpMouseWork.Controls.Add(Me.btnMouseClear)
        Me.grpMouseWork.Controls.Add(Me.btnMouseOver)
        Me.grpMouseWork.Controls.Add(Me.txtMouseWork)
        Me.grpMouseWork.Location = New System.Drawing.Point(332, 560)
        Me.grpMouseWork.Name = "grpMouseWork"
        Me.grpMouseWork.Size = New System.Drawing.Size(218, 230)
        Me.grpMouseWork.TabIndex = 8
        Me.grpMouseWork.TabStop = False
        Me.grpMouseWork.Text = "Mouse Work Area"
        '
        'btnMouseClear
        '
        Me.btnMouseClear.Location = New System.Drawing.Point(38, 167)
        Me.btnMouseClear.Name = "btnMouseClear"
        Me.btnMouseClear.Size = New System.Drawing.Size(140, 45)
        Me.btnMouseClear.TabIndex = 3
        Me.btnMouseClear.Text = "Clear"
        Me.btnMouseClear.UseVisualStyleBackColor = True
        '
        'btnMouseOver
        '
        Me.btnMouseOver.Location = New System.Drawing.Point(38, 102)
        Me.btnMouseOver.Name = "btnMouseOver"
        Me.btnMouseOver.Size = New System.Drawing.Size(140, 45)
        Me.btnMouseOver.TabIndex = 2
        Me.btnMouseOver.Text = "Mouse Over Event"
        Me.btnMouseOver.UseVisualStyleBackColor = True
        '
        'txtMouseWork
        '
        Me.txtMouseWork.Location = New System.Drawing.Point(19, 33)
        Me.txtMouseWork.Multiline = True
        Me.txtMouseWork.Name = "txtMouseWork"
        Me.txtMouseWork.Size = New System.Drawing.Size(183, 46)
        Me.txtMouseWork.TabIndex = 0
        '
        'grpWebWork
        '
        Me.grpWebWork.Controls.Add(Me.radMicrosoft)
        Me.grpWebWork.Controls.Add(Me.rad287)
        Me.grpWebWork.Controls.Add(Me.radMCB)
        Me.grpWebWork.Controls.Add(Me.radURSA)
        Me.grpWebWork.Controls.Add(Me.btnGo)
        Me.grpWebWork.Controls.Add(Me.txtURL)
        Me.grpWebWork.Controls.Add(Me.WebBrowser1)
        Me.grpWebWork.Location = New System.Drawing.Point(580, 55)
        Me.grpWebWork.Name = "grpWebWork"
        Me.grpWebWork.Size = New System.Drawing.Size(657, 422)
        Me.grpWebWork.TabIndex = 9
        Me.grpWebWork.TabStop = False
        Me.grpWebWork.Text = "Internet Browser Area"
        '
        'radMicrosoft
        '
        Me.radMicrosoft.AutoSize = True
        Me.radMicrosoft.Location = New System.Drawing.Point(381, 384)
        Me.radMicrosoft.Name = "radMicrosoft"
        Me.radMicrosoft.Size = New System.Drawing.Size(140, 20)
        Me.radMicrosoft.TabIndex = 6
        Me.radMicrosoft.TabStop = True
        Me.radMicrosoft.Text = "&Visual Basic Home"
        Me.radMicrosoft.UseVisualStyleBackColor = True
        '
        'rad287
        '
        Me.rad287.AutoSize = True
        Me.rad287.Location = New System.Drawing.Point(267, 384)
        Me.rad287.Name = "rad287"
        Me.rad287.Size = New System.Drawing.Size(86, 20)
        Me.rad287.TabIndex = 5
        Me.rad287.TabStop = True
        Me.rad287.Text = "BACS 287"
        Me.rad287.UseVisualStyleBackColor = True
        '
        'radMCB
        '
        Me.radMCB.AutoSize = True
        Me.radMCB.Location = New System.Drawing.Point(174, 384)
        Me.radMCB.Name = "radMCB"
        Me.radMCB.Size = New System.Drawing.Size(55, 20)
        Me.radMCB.TabIndex = 4
        Me.radMCB.TabStop = True
        Me.radMCB.Text = "&MCB"
        Me.radMCB.UseVisualStyleBackColor = True
        '
        'radURSA
        '
        Me.radURSA.AutoSize = True
        Me.radURSA.Location = New System.Drawing.Point(73, 384)
        Me.radURSA.Name = "radURSA"
        Me.radURSA.Size = New System.Drawing.Size(64, 20)
        Me.radURSA.TabIndex = 3
        Me.radURSA.TabStop = True
        Me.radURSA.Text = "&URSA"
        Me.radURSA.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(435, 46)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(42, 23)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "GO"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(73, 46)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(356, 22)
        Me.txtURL.TabIndex = 1
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(73, 74)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(500, 256)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("http://mcb.unco.edu", System.UriKind.Absolute)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'grpFileWork
        '
        Me.grpFileWork.Controls.Add(Me.lblFileWork)
        Me.grpFileWork.Controls.Add(Me.filFileWork)
        Me.grpFileWork.Controls.Add(Me.dirFileWork)
        Me.grpFileWork.Controls.Add(Me.drvFileWork)
        Me.grpFileWork.Controls.Add(Me.picImageDisplay)
        Me.grpFileWork.Location = New System.Drawing.Point(599, 508)
        Me.grpFileWork.Name = "grpFileWork"
        Me.grpFileWork.Size = New System.Drawing.Size(574, 316)
        Me.grpFileWork.TabIndex = 11
        Me.grpFileWork.TabStop = False
        Me.grpFileWork.Text = "File Work Area"
        '
        'lblFileWork
        '
        Me.lblFileWork.AutoSize = True
        Me.lblFileWork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFileWork.Location = New System.Drawing.Point(26, 277)
        Me.lblFileWork.Name = "lblFileWork"
        Me.lblFileWork.Size = New System.Drawing.Size(2, 18)
        Me.lblFileWork.TabIndex = 4
        '
        'filFileWork
        '
        Me.filFileWork.FormattingEnabled = True
        Me.filFileWork.Location = New System.Drawing.Point(27, 198)
        Me.filFileWork.Name = "filFileWork"
        Me.filFileWork.Pattern = "*.BMP;*.WMF;*.ICO"
        Me.filFileWork.Size = New System.Drawing.Size(324, 68)
        Me.filFileWork.TabIndex = 3
        '
        'dirFileWork
        '
        Me.dirFileWork.FormattingEnabled = True
        Me.dirFileWork.IntegralHeight = False
        Me.dirFileWork.Location = New System.Drawing.Point(375, 66)
        Me.dirFileWork.Name = "dirFileWork"
        Me.dirFileWork.Size = New System.Drawing.Size(171, 204)
        Me.dirFileWork.TabIndex = 2
        '
        'drvFileWork
        '
        Me.drvFileWork.FormattingEnabled = True
        Me.drvFileWork.Location = New System.Drawing.Point(378, 37)
        Me.drvFileWork.Name = "drvFileWork"
        Me.drvFileWork.Size = New System.Drawing.Size(169, 23)
        Me.drvFileWork.TabIndex = 1
        '
        'picImageDisplay
        '
        Me.picImageDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImageDisplay.Location = New System.Drawing.Point(26, 37)
        Me.picImageDisplay.Name = "picImageDisplay"
        Me.picImageDisplay.Size = New System.Drawing.Size(326, 146)
        Me.picImageDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImageDisplay.TabIndex = 0
        Me.picImageDisplay.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1156, 839)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(81, 45)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 898)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grpFileWork)
        Me.Controls.Add(Me.grpWebWork)
        Me.Controls.Add(Me.grpMouseWork)
        Me.Controls.Add(Me.clbCheckedList)
        Me.Controls.Add(Me.lstDropDownCombo)
        Me.Controls.Add(Me.lblDropDownCombo)
        Me.Controls.Add(Me.lblCkListBox)
        Me.Controls.Add(Me.lstUnboundList)
        Me.Controls.Add(Me.lblUnboundList)
        Me.Controls.Add(Me.grpColor)
        Me.Controls.Add(Me.grpRadChk)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "J. Palisoul BACS 287 Project #1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpRadChk.ResumeLayout(False)
        Me.grpRadChk.PerformLayout()
        Me.grpColor.ResumeLayout(False)
        Me.grpColor.PerformLayout()
        Me.grpMouseWork.ResumeLayout(False)
        Me.grpMouseWork.PerformLayout()
        Me.grpWebWork.ResumeLayout(False)
        Me.grpWebWork.PerformLayout()
        Me.grpFileWork.ResumeLayout(False)
        Me.grpFileWork.PerformLayout()
        CType(Me.picImageDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpRadChk As GroupBox
    Friend WithEvents chkUnderline As CheckBox
    Friend WithEvents chkItalic As CheckBox
    Friend WithEvents chkBold As CheckBox
    Friend WithEvents radMsg3 As RadioButton
    Friend WithEvents radMsg2 As RadioButton
    Friend WithEvents radMsg1 As RadioButton
    Friend WithEvents txtStyleExample As TextBox
    Friend WithEvents btnResetTextbox As Button
    Friend WithEvents grpColor As GroupBox
    Friend WithEvents txtBlue As TextBox
    Friend WithEvents txtGreen As TextBox
    Friend WithEvents txtRed As TextBox
    Friend WithEvents scrBlue As HScrollBar
    Friend WithEvents scrGreen As HScrollBar
    Friend WithEvents scrRed As HScrollBar
    Friend WithEvents btnSetColor As Button
    Friend WithEvents lblBlue As Label
    Friend WithEvents lblGreen As Label
    Friend WithEvents lblRed As Label
    Friend WithEvents lblUnboundList As Label
    Friend WithEvents lstUnboundList As ListBox
    Friend WithEvents lblCkListBox As Label
    Friend WithEvents lblDropDownCombo As Label
    Friend WithEvents lstDropDownCombo As ComboBox
    Friend WithEvents clbCheckedList As CheckedListBox
    Friend WithEvents grpMouseWork As GroupBox
    Friend WithEvents btnMouseClear As Button
    Friend WithEvents btnMouseOver As Button
    Friend WithEvents txtMouseWork As TextBox
    Friend WithEvents grpWebWork As GroupBox
    Friend WithEvents radMicrosoft As RadioButton
    Friend WithEvents rad287 As RadioButton
    Friend WithEvents radMCB As RadioButton
    Friend WithEvents radURSA As RadioButton
    Friend WithEvents btnGo As Button
    Friend WithEvents txtURL As TextBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents grpFileWork As GroupBox
    Friend WithEvents picImageDisplay As PictureBox
    Friend WithEvents lblFileWork As Label
    Friend WithEvents filFileWork As Compatibility.VB6.FileListBox
    Friend WithEvents dirFileWork As Compatibility.VB6.DirListBox
    Friend WithEvents drvFileWork As Compatibility.VB6.DriveListBox
    Friend WithEvents btnClose As Button
End Class
