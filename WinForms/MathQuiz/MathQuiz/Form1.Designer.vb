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
        Dim Label2 As System.Windows.Forms.Label
        Dim plusLeftLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim plusRightLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim minusLeftLabel As System.Windows.Forms.Label
        Dim timesLeftLabel As System.Windows.Forms.Label
        Dim dividedLeftLabel As System.Windows.Forms.Label
        Dim minusRightLabel As System.Windows.Forms.Label
        Dim timesRightLabel As System.Windows.Forms.Label
        Dim dividedRightLabel As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sum = New System.Windows.Forms.NumericUpDown()
        Me.difference = New System.Windows.Forms.NumericUpDown()
        Me.product = New System.Windows.Forms.NumericUpDown()
        Me.quotient = New System.Windows.Forms.NumericUpDown()
        Me.startButton = New System.Windows.Forms.Button()
        Label2 = New System.Windows.Forms.Label()
        plusLeftLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        plusRightLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        minusLeftLabel = New System.Windows.Forms.Label()
        timesLeftLabel = New System.Windows.Forms.Label()
        dividedLeftLabel = New System.Windows.Forms.Label()
        minusRightLabel = New System.Windows.Forms.Label()
        timesRightLabel = New System.Windows.Forms.Label()
        dividedRightLabel = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        CType(Me.sum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.difference, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quotient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Label2.Location = New System.Drawing.Point(166, 9)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(100, 30)
        Label2.TabIndex = 1
        Label2.Text = "Time Left"
        '
        'plusLeftLabel
        '
        plusLeftLabel.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        plusLeftLabel.Location = New System.Drawing.Point(50, 75)
        plusLeftLabel.Name = "plusLeftLabel"
        plusLeftLabel.Size = New System.Drawing.Size(60, 50)
        plusLeftLabel.TabIndex = 2
        plusLeftLabel.Text = "?"
        plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Label3.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Label3.Location = New System.Drawing.Point(116, 75)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(60, 50)
        Label3.TabIndex = 3
        Label3.Text = "+"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        AddHandler Label3.Click, AddressOf Me.Label3_Click_1
        '
        'plusRightLabel
        '
        plusRightLabel.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        plusRightLabel.Location = New System.Drawing.Point(182, 75)
        plusRightLabel.Name = "plusRightLabel"
        plusRightLabel.Size = New System.Drawing.Size(60, 50)
        plusRightLabel.TabIndex = 4
        plusRightLabel.Text = "?"
        plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Label4.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Label4.Location = New System.Drawing.Point(247, 75)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(60, 50)
        Label4.TabIndex = 5
        Label4.Text = "="
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        AddHandler Label4.Click, AddressOf Me.Label4_Click
        '
        'minusLeftLabel
        '
        minusLeftLabel.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        minusLeftLabel.Location = New System.Drawing.Point(50, 125)
        minusLeftLabel.Name = "minusLeftLabel"
        minusLeftLabel.Size = New System.Drawing.Size(60, 50)
        minusLeftLabel.TabIndex = 7
        minusLeftLabel.Text = "?"
        minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timesLeftLabel
        '
        timesLeftLabel.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        timesLeftLabel.Location = New System.Drawing.Point(50, 175)
        timesLeftLabel.Name = "timesLeftLabel"
        timesLeftLabel.Size = New System.Drawing.Size(60, 50)
        timesLeftLabel.TabIndex = 8
        timesLeftLabel.Text = "?"
        timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dividedLeftLabel
        '
        dividedLeftLabel.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        dividedLeftLabel.Location = New System.Drawing.Point(50, 225)
        dividedLeftLabel.Name = "dividedLeftLabel"
        dividedLeftLabel.Size = New System.Drawing.Size(60, 50)
        dividedLeftLabel.TabIndex = 9
        dividedLeftLabel.Text = "?"
        dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minusRightLabel
        '
        minusRightLabel.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        minusRightLabel.Location = New System.Drawing.Point(182, 125)
        minusRightLabel.Name = "minusRightLabel"
        minusRightLabel.Size = New System.Drawing.Size(60, 50)
        minusRightLabel.TabIndex = 10
        minusRightLabel.Text = "?"
        minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timesRightLabel
        '
        timesRightLabel.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        timesRightLabel.Location = New System.Drawing.Point(182, 175)
        timesRightLabel.Name = "timesRightLabel"
        timesRightLabel.Size = New System.Drawing.Size(60, 50)
        timesRightLabel.TabIndex = 11
        timesRightLabel.Text = "?"
        timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        AddHandler timesRightLabel.Click, AddressOf Me.Label9_Click
        '
        'dividedRightLabel
        '
        dividedRightLabel.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        dividedRightLabel.Location = New System.Drawing.Point(182, 225)
        dividedRightLabel.Name = "dividedRightLabel"
        dividedRightLabel.Size = New System.Drawing.Size(60, 50)
        dividedRightLabel.TabIndex = 12
        dividedRightLabel.Text = "?"
        dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Label11.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Label11.Location = New System.Drawing.Point(116, 125)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(60, 50)
        Label11.TabIndex = 13
        Label11.Text = "-"
        Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Label12.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Label12.Location = New System.Drawing.Point(116, 175)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(60, 50)
        Label12.TabIndex = 14
        Label12.Text = "x"
        Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        AddHandler Label12.Click, AddressOf Me.Label12_Click
        '
        'Label13
        '
        Label13.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Label13.Location = New System.Drawing.Point(116, 225)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(60, 50)
        Label13.TabIndex = 15
        Label13.Text = "÷"
        Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Label14.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Label14.Location = New System.Drawing.Point(247, 125)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(60, 50)
        Label14.TabIndex = 16
        Label14.Text = "="
        Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Label15.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Label15.Location = New System.Drawing.Point(247, 175)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(60, 50)
        Label15.TabIndex = 17
        Label15.Text = "="
        Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Label16.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Label16.Location = New System.Drawing.Point(247, 225)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(60, 50)
        Label16.TabIndex = 18
        Label16.Text = "="
        Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(272, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 30)
        Me.Label1.TabIndex = 0
        '
        'sum
        '
        Me.sum.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.sum.Location = New System.Drawing.Point(316, 82)
        Me.sum.Name = "sum"
        Me.sum.Size = New System.Drawing.Size(100, 39)
        Me.sum.TabIndex = 1
        '
        'difference
        '
        Me.difference.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.difference.Location = New System.Drawing.Point(316, 132)
        Me.difference.Name = "difference"
        Me.difference.Size = New System.Drawing.Size(100, 39)
        Me.difference.TabIndex = 2
        '
        'product
        '
        Me.product.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.product.Location = New System.Drawing.Point(316, 186)
        Me.product.Name = "product"
        Me.product.Size = New System.Drawing.Size(100, 39)
        Me.product.TabIndex = 3
        '
        'quotient
        '
        Me.quotient.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.quotient.Location = New System.Drawing.Point(316, 236)
        Me.quotient.Name = "quotient"
        Me.quotient.Size = New System.Drawing.Size(100, 39)
        Me.quotient.TabIndex = 4
        '
        'startButton
        '
        Me.startButton.AutoSize = True
        Me.startButton.Font = New System.Drawing.Font("맑은 고딕", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.startButton.Location = New System.Drawing.Point(166, 314)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(141, 35)
        Me.startButton.TabIndex = 22
        Me.startButton.Text = "Start the quiz"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.quotient)
        Me.Controls.Add(Me.product)
        Me.Controls.Add(Me.difference)
        Me.Controls.Add(Label16)
        Me.Controls.Add(Label15)
        Me.Controls.Add(Label14)
        Me.Controls.Add(Label13)
        Me.Controls.Add(Label12)
        Me.Controls.Add(Label11)
        Me.Controls.Add(dividedRightLabel)
        Me.Controls.Add(timesRightLabel)
        Me.Controls.Add(minusRightLabel)
        Me.Controls.Add(dividedLeftLabel)
        Me.Controls.Add(timesLeftLabel)
        Me.Controls.Add(minusLeftLabel)
        Me.Controls.Add(Me.sum)
        Me.Controls.Add(Label4)
        Me.Controls.Add(plusRightLabel)
        Me.Controls.Add(Label3)
        Me.Controls.Add(plusLeftLabel)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Math Quiz"
        CType(Me.sum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.difference, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quotient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents sum As NumericUpDown
    Friend WithEvents difference As NumericUpDown
    Friend WithEvents product As NumericUpDown
    Friend WithEvents quotient As NumericUpDown
    Friend WithEvents startButton As Button
End Class
