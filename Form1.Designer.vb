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
        Me.lblInput = New System.Windows.Forms.Label()
        Me.tbxInput = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbxTotal15 = New System.Windows.Forms.TextBox()
        Me.tbxTip15 = New System.Windows.Forms.TextBox()
        Me.lblTip2 = New System.Windows.Forms.Label()
        Me.lblTipAmount = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.tbxTip5 = New System.Windows.Forms.TextBox()
        Me.tbxTotal5 = New System.Windows.Forms.TextBox()
        Me.lblOutput1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblInput.Location = New System.Drawing.Point(34, 29)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(94, 29)
        Me.lblInput.TabIndex = 0
        Me.lblInput.Text = "Amount"
        '
        'tbxInput
        '
        Me.tbxInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbxInput.Location = New System.Drawing.Point(12, 61)
        Me.tbxInput.Name = "tbxInput"
        Me.tbxInput.Size = New System.Drawing.Size(131, 30)
        Me.tbxInput.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalculate.Location = New System.Drawing.Point(486, 37)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(134, 54)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbxTotal15)
        Me.GroupBox1.Controls.Add(Me.tbxTip15)
        Me.GroupBox1.Controls.Add(Me.lblTip2)
        Me.GroupBox1.Controls.Add(Me.lblTipAmount)
        Me.GroupBox1.Controls.Add(Me.lblTotalAmount)
        Me.GroupBox1.Controls.Add(Me.tbxTip5)
        Me.GroupBox1.Controls.Add(Me.tbxTotal5)
        Me.GroupBox1.Controls.Add(Me.lblOutput1)
        Me.GroupBox1.Location = New System.Drawing.Point(321, 249)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 189)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'tbxTotal15
        '
        Me.tbxTotal15.Location = New System.Drawing.Point(283, 100)
        Me.tbxTotal15.Name = "tbxTotal15"
        Me.tbxTotal15.ReadOnly = True
        Me.tbxTotal15.Size = New System.Drawing.Size(100, 26)
        Me.tbxTotal15.TabIndex = 7
        '
        'tbxTip15
        '
        Me.tbxTip15.Location = New System.Drawing.Point(283, 68)
        Me.tbxTip15.Name = "tbxTip15"
        Me.tbxTip15.ReadOnly = True
        Me.tbxTip15.Size = New System.Drawing.Size(100, 26)
        Me.tbxTip15.TabIndex = 7
        '
        'lblTip2
        '
        Me.lblTip2.AutoSize = True
        Me.lblTip2.Location = New System.Drawing.Point(303, 45)
        Me.lblTip2.Name = "lblTip2"
        Me.lblTip2.Size = New System.Drawing.Size(66, 20)
        Me.lblTip2.TabIndex = 6
        Me.lblTip2.Text = "Tip 15%"
        '
        'lblTipAmount
        '
        Me.lblTipAmount.AutoSize = True
        Me.lblTipAmount.Location = New System.Drawing.Point(41, 68)
        Me.lblTipAmount.Name = "lblTipAmount"
        Me.lblTipAmount.Size = New System.Drawing.Size(90, 20)
        Me.lblTipAmount.TabIndex = 5
        Me.lblTipAmount.Text = "Tip Amount"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Location = New System.Drawing.Point(27, 100)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(104, 20)
        Me.lblTotalAmount.TabIndex = 4
        Me.lblTotalAmount.Text = "Total Amount"
        '
        'tbxTip5
        '
        Me.tbxTip5.Location = New System.Drawing.Point(152, 68)
        Me.tbxTip5.Name = "tbxTip5"
        Me.tbxTip5.ReadOnly = True
        Me.tbxTip5.Size = New System.Drawing.Size(100, 26)
        Me.tbxTip5.TabIndex = 3
        '
        'tbxTotal5
        '
        Me.tbxTotal5.Location = New System.Drawing.Point(152, 100)
        Me.tbxTotal5.Name = "tbxTotal5"
        Me.tbxTotal5.ReadOnly = True
        Me.tbxTotal5.Size = New System.Drawing.Size(100, 26)
        Me.tbxTotal5.TabIndex = 2
        '
        'lblOutput1
        '
        Me.lblOutput1.AutoSize = True
        Me.lblOutput1.Location = New System.Drawing.Point(165, 45)
        Me.lblOutput1.Name = "lblOutput1"
        Me.lblOutput1.Size = New System.Drawing.Size(57, 20)
        Me.lblOutput1.TabIndex = 1
        Me.lblOutput1.Text = "5% Tip"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.tbxInput)
        Me.Controls.Add(Me.lblInput)
        Me.Name = "Form1"
        Me.Text = "Tip Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInput As Label
    Friend WithEvents tbxInput As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbxTotal15 As TextBox
    Friend WithEvents tbxTip15 As TextBox
    Friend WithEvents lblTip2 As Label
    Friend WithEvents lblTipAmount As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents tbxTip5 As TextBox
    Friend WithEvents tbxTotal5 As TextBox
    Friend WithEvents lblOutput1 As Label
End Class
