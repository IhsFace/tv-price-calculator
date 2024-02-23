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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtNumUnits = New TextBox()
        cbxCategory = New ComboBox()
        btnCalculate = New Button()
        btnClear = New Button()
        lstDisplay = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F)
        Label1.Location = New Point(204, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(381, 59)
        Label1.TabIndex = 0
        Label1.Text = "TV Price Calculator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(139, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(257, 45)
        Label2.TabIndex = 1
        Label2.Text = "Number of Units"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(139, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(213, 45)
        Label3.TabIndex = 2
        Label3.Text = "Size Category"
        ' 
        ' txtNumUnits
        ' 
        txtNumUnits.Location = New Point(537, 106)
        txtNumUnits.Name = "txtNumUnits"
        txtNumUnits.Size = New Size(242, 39)
        txtNumUnits.TabIndex = 3
        ' 
        ' cbxCategory
        ' 
        cbxCategory.FormattingEnabled = True
        cbxCategory.Items.AddRange(New Object() {"Small", "Medium", "Large"})
        cbxCategory.Location = New Point(537, 168)
        cbxCategory.Name = "cbxCategory"
        cbxCategory.Size = New Size(242, 40)
        cbxCategory.TabIndex = 4
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(537, 252)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(242, 46)
        btnCalculate.TabIndex = 5
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(537, 328)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(242, 46)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lstDisplay
        ' 
        lstDisplay.FormattingEnabled = True
        lstDisplay.Location = New Point(12, 242)
        lstDisplay.Name = "lstDisplay"
        lstDisplay.Size = New Size(489, 196)
        lstDisplay.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstDisplay)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(cbxCategory)
        Controls.Add(txtNumUnits)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "TV Price Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumUnits As TextBox
    Friend WithEvents cbxCategory As ComboBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lstDisplay As ListBox

End Class
