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
        Me.grpBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblnone = New System.Windows.Forms.Label()
        Me.txtInput4 = New System.Windows.Forms.TextBox()
        Me.txtInput3 = New System.Windows.Forms.TextBox()
        Me.txtInput2 = New System.Windows.Forms.TextBox()
        Me.txtInput1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblGallons = New System.Windows.Forms.Label()
        Me.lblPaintCost = New System.Windows.Forms.Label()
        Me.lblLaborCost = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBox1
        '
        Me.grpBox1.BackColor = System.Drawing.Color.Khaki
        Me.grpBox1.Controls.Add(Me.Label3)
        Me.grpBox1.Controls.Add(Me.Label2)
        Me.grpBox1.Controls.Add(Me.Label1)
        Me.grpBox1.Controls.Add(Me.lblnone)
        Me.grpBox1.Controls.Add(Me.txtInput4)
        Me.grpBox1.Controls.Add(Me.txtInput3)
        Me.grpBox1.Controls.Add(Me.txtInput2)
        Me.grpBox1.Controls.Add(Me.txtInput1)
        Me.grpBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBox1.Location = New System.Drawing.Point(16, 20)
        Me.grpBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpBox1.Name = "grpBox1"
        Me.grpBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpBox1.Size = New System.Drawing.Size(660, 202)
        Me.grpBox1.TabIndex = 0
        Me.grpBox1.TabStop = False
        Me.grpBox1.Text = "Job Input"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(344, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hourly Wage"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cost Per Gal."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Wall Height"
        '
        'lblnone
        '
        Me.lblnone.AutoSize = True
        Me.lblnone.Location = New System.Drawing.Point(55, 54)
        Me.lblnone.Name = "lblnone"
        Me.lblnone.Size = New System.Drawing.Size(93, 20)
        Me.lblnone.TabIndex = 4
        Me.lblnone.Text = "Wall Length"
        '
        'txtInput4
        '
        Me.txtInput4.Location = New System.Drawing.Point(464, 121)
        Me.txtInput4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInput4.Name = "txtInput4"
        Me.txtInput4.Size = New System.Drawing.Size(154, 26)
        Me.txtInput4.TabIndex = 3
        '
        'txtInput3
        '
        Me.txtInput3.Location = New System.Drawing.Point(464, 50)
        Me.txtInput3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInput3.Name = "txtInput3"
        Me.txtInput3.Size = New System.Drawing.Size(154, 26)
        Me.txtInput3.TabIndex = 2
        '
        'txtInput2
        '
        Me.txtInput2.Location = New System.Drawing.Point(166, 121)
        Me.txtInput2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInput2.Name = "txtInput2"
        Me.txtInput2.Size = New System.Drawing.Size(154, 26)
        Me.txtInput2.TabIndex = 1
        '
        'txtInput1
        '
        Me.txtInput1.Location = New System.Drawing.Point(166, 50)
        Me.txtInput1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInput1.Name = "txtInput1"
        Me.txtInput1.Size = New System.Drawing.Size(154, 26)
        Me.txtInput1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(180, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Hours of Labor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(180, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Gallons of Paint"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(180, 379)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Paint Cost"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(180, 449)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Labor Cost"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(180, 519)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Total Cost"
        '
        'lblHours
        '
        Me.lblHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHours.Location = New System.Drawing.Point(321, 256)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(168, 27)
        Me.lblHours.TabIndex = 10
        Me.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGallons
        '
        Me.lblGallons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGallons.Location = New System.Drawing.Point(321, 314)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(168, 27)
        Me.lblGallons.TabIndex = 11
        Me.lblGallons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPaintCost
        '
        Me.lblPaintCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPaintCost.Location = New System.Drawing.Point(321, 376)
        Me.lblPaintCost.Name = "lblPaintCost"
        Me.lblPaintCost.Size = New System.Drawing.Size(168, 27)
        Me.lblPaintCost.TabIndex = 12
        Me.lblPaintCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLaborCost
        '
        Me.lblLaborCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLaborCost.Location = New System.Drawing.Point(321, 446)
        Me.lblLaborCost.Name = "lblLaborCost"
        Me.lblLaborCost.Size = New System.Drawing.Size(168, 27)
        Me.lblLaborCost.TabIndex = 13
        Me.lblLaborCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalCost
        '
        Me.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(321, 516)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(168, 27)
        Me.lblTotalCost.TabIndex = 14
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(259, 589)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(201, 47)
        Me.btncalc.TabIndex = 15
        Me.btncalc.Text = "Calculate"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(549, 593)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(107, 43)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(57, 593)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(107, 43)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 660)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblLaborCost)
        Me.Controls.Add(Me.lblPaintCost)
        Me.Controls.Add(Me.lblGallons)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grpBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Paint Calculator - Palisoul"
        Me.grpBox1.ResumeLayout(False)
        Me.grpBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblnone As Label
    Friend WithEvents txtInput4 As TextBox
    Friend WithEvents txtInput3 As TextBox
    Friend WithEvents txtInput2 As TextBox
    Friend WithEvents txtInput1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents lblGallons As Label
    Friend WithEvents lblPaintCost As Label
    Friend WithEvents lblLaborCost As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btncalc As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
End Class
