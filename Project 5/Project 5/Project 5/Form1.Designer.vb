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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtInput4 = New System.Windows.Forms.TextBox()
        Me.txtInput3 = New System.Windows.Forms.TextBox()
        Me.txtInput2 = New System.Windows.Forms.TextBox()
        Me.txtInput1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblLoanAmount = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblPrinciple = New System.Windows.Forms.Label()
        Me.lblInterest = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.radMonthly = New System.Windows.Forms.RadioButton()
        Me.radQuarterly = New System.Windows.Forms.RadioButton()
        Me.radYearly = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtInput4)
        Me.GroupBox1.Controls.Add(Me.txtInput3)
        Me.GroupBox1.Controls.Add(Me.txtInput2)
        Me.GroupBox1.Controls.Add(Me.txtInput1)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 256)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Loan Information"
        '
        'txtInput4
        '
        Me.txtInput4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput4.Location = New System.Drawing.Point(122, 196)
        Me.txtInput4.Name = "txtInput4"
        Me.txtInput4.Size = New System.Drawing.Size(160, 22)
        Me.txtInput4.TabIndex = 3
        '
        'txtInput3
        '
        Me.txtInput3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput3.Location = New System.Drawing.Point(122, 144)
        Me.txtInput3.Name = "txtInput3"
        Me.txtInput3.Size = New System.Drawing.Size(160, 22)
        Me.txtInput3.TabIndex = 2
        '
        'txtInput2
        '
        Me.txtInput2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput2.Location = New System.Drawing.Point(122, 94)
        Me.txtInput2.Name = "txtInput2"
        Me.txtInput2.Size = New System.Drawing.Size(160, 22)
        Me.txtInput2.TabIndex = 1
        Me.txtInput2.Text = "0"
        '
        'txtInput1
        '
        Me.txtInput1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput1.Location = New System.Drawing.Point(122, 44)
        Me.txtInput1.Name = "txtInput1"
        Me.txtInput1.Size = New System.Drawing.Size(160, 22)
        Me.txtInput1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblInterest)
        Me.GroupBox2.Controls.Add(Me.lblPrinciple)
        Me.GroupBox2.Controls.Add(Me.lblPayment)
        Me.GroupBox2.Controls.Add(Me.lblLoanAmount)
        Me.GroupBox2.Location = New System.Drawing.Point(471, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 256)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment Information"
        '
        'lblLoanAmount
        '
        Me.lblLoanAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLoanAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanAmount.Location = New System.Drawing.Point(127, 44)
        Me.lblLoanAmount.Name = "lblLoanAmount"
        Me.lblLoanAmount.Size = New System.Drawing.Size(160, 22)
        Me.lblLoanAmount.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radYearly)
        Me.GroupBox3.Controls.Add(Me.radMonthly)
        Me.GroupBox3.Controls.Add(Me.radQuarterly)
        Me.GroupBox3.Location = New System.Drawing.Point(67, 411)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(194, 146)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment Frequency"
        '
        'lblPayment
        '
        Me.lblPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.Location = New System.Drawing.Point(127, 94)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(160, 22)
        Me.lblPayment.TabIndex = 1
        '
        'lblPrinciple
        '
        Me.lblPrinciple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrinciple.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrinciple.Location = New System.Drawing.Point(127, 144)
        Me.lblPrinciple.Name = "lblPrinciple"
        Me.lblPrinciple.Size = New System.Drawing.Size(160, 22)
        Me.lblPrinciple.TabIndex = 2
        '
        'lblInterest
        '
        Me.lblInterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInterest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterest.Location = New System.Drawing.Point(127, 196)
        Me.lblInterest.Name = "lblInterest"
        Me.lblInterest.Size = New System.Drawing.Size(160, 22)
        Me.lblInterest.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "House Cost:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Down Payment:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Interest %:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Years:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Loan Amount:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Payment:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Principle:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Interest:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Aqua
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(279, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(289, 35)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "House Payment Calculator"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radMonthly
        '
        Me.radMonthly.AutoSize = True
        Me.radMonthly.Checked = True
        Me.radMonthly.Location = New System.Drawing.Point(38, 30)
        Me.radMonthly.Name = "radMonthly"
        Me.radMonthly.Size = New System.Drawing.Size(72, 20)
        Me.radMonthly.TabIndex = 0
        Me.radMonthly.TabStop = True
        Me.radMonthly.Text = "&Monthly"
        Me.radMonthly.UseVisualStyleBackColor = True
        '
        'radQuarterly
        '
        Me.radQuarterly.AutoSize = True
        Me.radQuarterly.Location = New System.Drawing.Point(38, 65)
        Me.radQuarterly.Name = "radQuarterly"
        Me.radQuarterly.Size = New System.Drawing.Size(80, 20)
        Me.radQuarterly.TabIndex = 1
        Me.radQuarterly.TabStop = True
        Me.radQuarterly.Text = "&Quarterly"
        Me.radQuarterly.UseVisualStyleBackColor = True
        '
        'radYearly
        '
        Me.radYearly.AutoSize = True
        Me.radYearly.Location = New System.Drawing.Point(38, 101)
        Me.radYearly.Name = "radYearly"
        Me.radYearly.Size = New System.Drawing.Size(65, 20)
        Me.radYearly.TabIndex = 2
        Me.radYearly.TabStop = True
        Me.radYearly.Text = "&Yearly"
        Me.radYearly.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(499, 477)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(130, 55)
        Me.btnCalculate.TabIndex = 13
        Me.btnCalculate.Text = "C&alculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(319, 477)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(130, 55)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(686, 477)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(130, 55)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 610)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "BACS 287 - Joseph Palisoul/Tyler Vier - House Payment Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtInput4 As TextBox
    Friend WithEvents txtInput3 As TextBox
    Friend WithEvents txtInput2 As TextBox
    Friend WithEvents txtInput1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblLoanAmount As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblInterest As Label
    Friend WithEvents lblPrinciple As Label
    Friend WithEvents lblPayment As Label
    Friend WithEvents radYearly As RadioButton
    Friend WithEvents radMonthly As RadioButton
    Friend WithEvents radQuarterly As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
End Class
