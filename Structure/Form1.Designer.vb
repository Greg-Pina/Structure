<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStructures
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
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.txtNumber3 = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(165, 31)
        Me.txtNumber1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(132, 22)
        Me.txtNumber1.TabIndex = 1
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(165, 100)
        Me.txtNumber2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(132, 22)
        Me.txtNumber2.TabIndex = 2
        '
        'txtNumber3
        '
        Me.txtNumber3.Location = New System.Drawing.Point(165, 165)
        Me.txtNumber3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumber3.Name = "txtNumber3"
        Me.txtNumber3.Size = New System.Drawing.Size(132, 22)
        Me.txtNumber3.TabIndex = 3
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(39, 273)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(87, 28)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Second Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 174)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Third Number"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(49, 218)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(249, 28)
        Me.lblResult.TabIndex = 8
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(155, 277)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 24)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(282, 277)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmStructures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 327)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtNumber3)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtNumber1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmStructures"
        Me.Text = "Structures"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumber1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber3 As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
