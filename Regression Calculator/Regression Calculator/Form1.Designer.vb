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
        Me.button_removeall = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.button_remove = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.syy = New System.Windows.Forms.TextBox()
        Me.sxx = New System.Windows.Forms.TextBox()
        Me.sxy = New System.Windows.Forms.TextBox()
        Me.correlation = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.regression = New System.Windows.Forms.TextBox()
        Me.mean_x = New System.Windows.Forms.TextBox()
        Me.mean_y = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.total_y2 = New System.Windows.Forms.TextBox()
        Me.total_x2 = New System.Windows.Forms.TextBox()
        Me.total_xy = New System.Windows.Forms.TextBox()
        Me.total_y = New System.Windows.Forms.TextBox()
        Me.total_x = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.XY = New System.Windows.Forms.Label()
        Me.list_y2 = New System.Windows.Forms.ListBox()
        Me.list_x2 = New System.Windows.Forms.ListBox()
        Me.list_xy = New System.Windows.Forms.ListBox()
        Me.list_y = New System.Windows.Forms.ListBox()
        Me.list_x = New System.Windows.Forms.ListBox()
        Me.button_input = New System.Windows.Forms.Button()
        Me.input_y = New System.Windows.Forms.TextBox()
        Me.input_x = New System.Windows.Forms.TextBox()
        Me.button_switch = New System.Windows.Forms.Button()
        Me.n = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'button_removeall
        '
        Me.button_removeall.Location = New System.Drawing.Point(347, 9)
        Me.button_removeall.Name = "button_removeall"
        Me.button_removeall.Size = New System.Drawing.Size(100, 23)
        Me.button_removeall.TabIndex = 68
        Me.button_removeall.Text = "Remove all"
        Me.button_removeall.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(132, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 13)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Y"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 13)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "X"
        '
        'button_remove
        '
        Me.button_remove.Location = New System.Drawing.Point(241, 9)
        Me.button_remove.Name = "button_remove"
        Me.button_remove.Size = New System.Drawing.Size(100, 23)
        Me.button_remove.TabIndex = 65
        Me.button_remove.Text = "Remove selected"
        Me.button_remove.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(160, 336)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "syy"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(160, 309)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "sxx"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(160, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "sxy"
        '
        'syy
        '
        Me.syy.Location = New System.Drawing.Point(188, 333)
        Me.syy.Name = "syy"
        Me.syy.ReadOnly = True
        Me.syy.Size = New System.Drawing.Size(100, 20)
        Me.syy.TabIndex = 61
        '
        'sxx
        '
        Me.sxx.Location = New System.Drawing.Point(188, 307)
        Me.sxx.Name = "sxx"
        Me.sxx.ReadOnly = True
        Me.sxx.Size = New System.Drawing.Size(100, 20)
        Me.sxx.TabIndex = 60
        '
        'sxy
        '
        Me.sxy.Location = New System.Drawing.Point(188, 281)
        Me.sxy.Name = "sxy"
        Me.sxy.ReadOnly = True
        Me.sxy.Size = New System.Drawing.Size(100, 20)
        Me.sxy.TabIndex = 59
        '
        'correlation
        '
        Me.correlation.Location = New System.Drawing.Point(400, 307)
        Me.correlation.Name = "correlation"
        Me.correlation.ReadOnly = True
        Me.correlation.Size = New System.Drawing.Size(153, 20)
        Me.correlation.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(337, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Correlation"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(315, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Regression line"
        '
        'regression
        '
        Me.regression.Location = New System.Drawing.Point(400, 281)
        Me.regression.Name = "regression"
        Me.regression.ReadOnly = True
        Me.regression.Size = New System.Drawing.Size(153, 20)
        Me.regression.TabIndex = 55
        '
        'mean_x
        '
        Me.mean_x.Location = New System.Drawing.Point(29, 256)
        Me.mean_x.Name = "mean_x"
        Me.mean_x.ReadOnly = True
        Me.mean_x.Size = New System.Drawing.Size(100, 20)
        Me.mean_x.TabIndex = 54
        Me.mean_x.Text = "0"
        '
        'mean_y
        '
        Me.mean_y.Location = New System.Drawing.Point(135, 256)
        Me.mean_y.Name = "mean_y"
        Me.mean_y.ReadOnly = True
        Me.mean_y.Size = New System.Drawing.Size(100, 20)
        Me.mean_y.TabIndex = 53
        Me.mean_y.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "x̄ ȳ"
        '
        'total_y2
        '
        Me.total_y2.Location = New System.Drawing.Point(453, 230)
        Me.total_y2.Name = "total_y2"
        Me.total_y2.ReadOnly = True
        Me.total_y2.Size = New System.Drawing.Size(100, 20)
        Me.total_y2.TabIndex = 51
        Me.total_y2.Text = "0"
        '
        'total_x2
        '
        Me.total_x2.Location = New System.Drawing.Point(347, 230)
        Me.total_x2.Name = "total_x2"
        Me.total_x2.ReadOnly = True
        Me.total_x2.Size = New System.Drawing.Size(100, 20)
        Me.total_x2.TabIndex = 50
        Me.total_x2.Text = "0"
        '
        'total_xy
        '
        Me.total_xy.Location = New System.Drawing.Point(241, 230)
        Me.total_xy.Name = "total_xy"
        Me.total_xy.ReadOnly = True
        Me.total_xy.Size = New System.Drawing.Size(100, 20)
        Me.total_xy.TabIndex = 49
        Me.total_xy.Text = "0"
        '
        'total_y
        '
        Me.total_y.Location = New System.Drawing.Point(135, 230)
        Me.total_y.Name = "total_y"
        Me.total_y.ReadOnly = True
        Me.total_y.Size = New System.Drawing.Size(100, 20)
        Me.total_y.TabIndex = 48
        Me.total_y.Text = "0"
        '
        'total_x
        '
        Me.total_x.Location = New System.Drawing.Point(29, 230)
        Me.total_x.Name = "total_x"
        Me.total_x.ReadOnly = True
        Me.total_x.Size = New System.Drawing.Size(100, 20)
        Me.total_x.TabIndex = 47
        Me.total_x.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "∑"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(450, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Y^2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(344, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "X^2"
        '
        'XY
        '
        Me.XY.AutoSize = True
        Me.XY.Location = New System.Drawing.Point(238, 61)
        Me.XY.Name = "XY"
        Me.XY.Size = New System.Drawing.Size(21, 13)
        Me.XY.TabIndex = 43
        Me.XY.Text = "XY"
        '
        'list_y2
        '
        Me.list_y2.BackColor = System.Drawing.SystemColors.Control
        Me.list_y2.FormattingEnabled = True
        Me.list_y2.Location = New System.Drawing.Point(453, 77)
        Me.list_y2.Name = "list_y2"
        Me.list_y2.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.list_y2.Size = New System.Drawing.Size(100, 147)
        Me.list_y2.TabIndex = 42
        '
        'list_x2
        '
        Me.list_x2.BackColor = System.Drawing.SystemColors.Control
        Me.list_x2.FormattingEnabled = True
        Me.list_x2.Location = New System.Drawing.Point(347, 77)
        Me.list_x2.Name = "list_x2"
        Me.list_x2.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.list_x2.Size = New System.Drawing.Size(100, 147)
        Me.list_x2.TabIndex = 41
        '
        'list_xy
        '
        Me.list_xy.BackColor = System.Drawing.SystemColors.Control
        Me.list_xy.FormattingEnabled = True
        Me.list_xy.Location = New System.Drawing.Point(241, 77)
        Me.list_xy.Name = "list_xy"
        Me.list_xy.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.list_xy.Size = New System.Drawing.Size(100, 147)
        Me.list_xy.TabIndex = 40
        '
        'list_y
        '
        Me.list_y.BackColor = System.Drawing.SystemColors.Window
        Me.list_y.FormattingEnabled = True
        Me.list_y.Location = New System.Drawing.Point(135, 77)
        Me.list_y.Name = "list_y"
        Me.list_y.Size = New System.Drawing.Size(100, 147)
        Me.list_y.TabIndex = 39
        '
        'list_x
        '
        Me.list_x.BackColor = System.Drawing.SystemColors.Window
        Me.list_x.FormattingEnabled = True
        Me.list_x.Location = New System.Drawing.Point(29, 77)
        Me.list_x.Name = "list_x"
        Me.list_x.Size = New System.Drawing.Size(100, 147)
        Me.list_x.TabIndex = 38
        '
        'button_input
        '
        Me.button_input.Location = New System.Drawing.Point(29, 9)
        Me.button_input.Name = "button_input"
        Me.button_input.Size = New System.Drawing.Size(100, 23)
        Me.button_input.TabIndex = 37
        Me.button_input.Text = "Input X and Y"
        Me.button_input.UseVisualStyleBackColor = True
        '
        'input_y
        '
        Me.input_y.Location = New System.Drawing.Point(135, 51)
        Me.input_y.Name = "input_y"
        Me.input_y.Size = New System.Drawing.Size(100, 20)
        Me.input_y.TabIndex = 36
        '
        'input_x
        '
        Me.input_x.Location = New System.Drawing.Point(29, 51)
        Me.input_x.Name = "input_x"
        Me.input_x.Size = New System.Drawing.Size(100, 20)
        Me.input_x.TabIndex = 35
        '
        'button_switch
        '
        Me.button_switch.Location = New System.Drawing.Point(135, 9)
        Me.button_switch.Name = "button_switch"
        Me.button_switch.Size = New System.Drawing.Size(100, 23)
        Me.button_switch.TabIndex = 69
        Me.button_switch.Text = "Switch mode"
        Me.button_switch.UseVisualStyleBackColor = True
        '
        'n
        '
        Me.n.Location = New System.Drawing.Point(29, 282)
        Me.n.Name = "n"
        Me.n.ReadOnly = True
        Me.n.Size = New System.Drawing.Size(100, 20)
        Me.n.TabIndex = 70
        Me.n.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 284)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "n"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 366)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.n)
        Me.Controls.Add(Me.button_switch)
        Me.Controls.Add(Me.button_removeall)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.button_remove)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.syy)
        Me.Controls.Add(Me.sxx)
        Me.Controls.Add(Me.sxy)
        Me.Controls.Add(Me.correlation)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.regression)
        Me.Controls.Add(Me.mean_x)
        Me.Controls.Add(Me.mean_y)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.total_y2)
        Me.Controls.Add(Me.total_x2)
        Me.Controls.Add(Me.total_xy)
        Me.Controls.Add(Me.total_y)
        Me.Controls.Add(Me.total_x)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.XY)
        Me.Controls.Add(Me.list_y2)
        Me.Controls.Add(Me.list_x2)
        Me.Controls.Add(Me.list_xy)
        Me.Controls.Add(Me.list_y)
        Me.Controls.Add(Me.list_x)
        Me.Controls.Add(Me.button_input)
        Me.Controls.Add(Me.input_y)
        Me.Controls.Add(Me.input_x)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Regression Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents button_removeall As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents button_remove As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents syy As System.Windows.Forms.TextBox
    Friend WithEvents sxx As System.Windows.Forms.TextBox
    Friend WithEvents sxy As System.Windows.Forms.TextBox
    Friend WithEvents correlation As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents regression As System.Windows.Forms.TextBox
    Friend WithEvents mean_x As System.Windows.Forms.TextBox
    Friend WithEvents mean_y As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents total_y2 As System.Windows.Forms.TextBox
    Friend WithEvents total_x2 As System.Windows.Forms.TextBox
    Friend WithEvents total_xy As System.Windows.Forms.TextBox
    Friend WithEvents total_y As System.Windows.Forms.TextBox
    Friend WithEvents total_x As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents XY As System.Windows.Forms.Label
    Friend WithEvents list_y2 As System.Windows.Forms.ListBox
    Friend WithEvents list_x2 As System.Windows.Forms.ListBox
    Friend WithEvents list_xy As System.Windows.Forms.ListBox
    Friend WithEvents list_y As System.Windows.Forms.ListBox
    Friend WithEvents list_x As System.Windows.Forms.ListBox
    Friend WithEvents button_input As System.Windows.Forms.Button
    Friend WithEvents input_y As System.Windows.Forms.TextBox
    Friend WithEvents input_x As System.Windows.Forms.TextBox
    Friend WithEvents button_switch As System.Windows.Forms.Button
    Friend WithEvents n As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
