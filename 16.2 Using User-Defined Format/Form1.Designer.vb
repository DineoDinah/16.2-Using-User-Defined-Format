﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
		Label1 = New Label()
		Label2 = New Label()
		Label3 = New Label()
		Label4 = New Label()
		Label5 = New Label()
		Button1 = New Button()
		TextBox1 = New TextBox()
		TextBox2 = New TextBox()
		TextBox3 = New TextBox()
		TextBox4 = New TextBox()
		TextBox5 = New TextBox()
		SuspendLayout()
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(180, 56)
		Label1.Name = "Label1"
		Label1.Size = New Size(122, 25)
		Label1.TabIndex = 0
		Label1.Text = "Format (""0.0"")"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(180, 101)
		Label2.Name = "Label2"
		Label2.Size = New Size(132, 25)
		Label2.TabIndex = 0
		Label2.Text = "Format (""0.00"")"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(180, 151)
		Label3.Name = "Label3"
		Label3.Size = New Size(169, 25)
		Label3.TabIndex = 0
		Label3.Text = "Format (""#,##0.00"")"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Location = New Point(180, 195)
		Label4.Name = "Label4"
		Label4.Size = New Size(180, 25)
		Label4.TabIndex = 0
		Label4.Text = "Format (""R#,##0.00"")"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.Location = New Point(180, 238)
		Label5.Name = "Label5"
		Label5.Size = New Size(123, 25)
		Label5.TabIndex = 0
		Label5.Text = "Format (""0%"")"
		' 
		' Button1
		' 
		Button1.Location = New Point(378, 296)
		Button1.Name = "Button1"
		Button1.Size = New Size(112, 34)
		Button1.TabIndex = 1
		Button1.Text = "Format"
		Button1.UseVisualStyleBackColor = True
		' 
		' TextBox1
		' 
		TextBox1.Location = New Point(366, 50)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(150, 31)
		TextBox1.TabIndex = 2
		' 
		' TextBox2
		' 
		TextBox2.Location = New Point(366, 95)
		TextBox2.Name = "TextBox2"
		TextBox2.Size = New Size(150, 31)
		TextBox2.TabIndex = 2
		' 
		' TextBox3
		' 
		TextBox3.Location = New Point(366, 145)
		TextBox3.Name = "TextBox3"
		TextBox3.Size = New Size(150, 31)
		TextBox3.TabIndex = 2
		' 
		' TextBox4
		' 
		TextBox4.Location = New Point(366, 195)
		TextBox4.Name = "TextBox4"
		TextBox4.Size = New Size(150, 31)
		TextBox4.TabIndex = 2
		' 
		' TextBox5
		' 
		TextBox5.Location = New Point(366, 238)
		TextBox5.Name = "TextBox5"
		TextBox5.Size = New Size(150, 31)
		TextBox5.TabIndex = 2
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(TextBox5)
		Controls.Add(TextBox4)
		Controls.Add(TextBox3)
		Controls.Add(TextBox2)
		Controls.Add(TextBox1)
		Controls.Add(Button1)
		Controls.Add(Label5)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents TextBox5 As TextBox
End Class
