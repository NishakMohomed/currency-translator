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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCurrency = New System.Windows.Forms.TextBox()
        Me.lblTranslate = New System.Windows.Forms.Button()
        Me.lblClear = New System.Windows.Forms.Button()
        Me.lblTranslation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(81, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Currency"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(81, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Translation"
        '
        'txtCurrency
        '
        Me.txtCurrency.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCurrency.Location = New System.Drawing.Point(340, 97)
        Me.txtCurrency.Name = "txtCurrency"
        Me.txtCurrency.Size = New System.Drawing.Size(354, 39)
        Me.txtCurrency.TabIndex = 2
        '
        'lblTranslate
        '
        Me.lblTranslate.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTranslate.Location = New System.Drawing.Point(538, 329)
        Me.lblTranslate.Name = "lblTranslate"
        Me.lblTranslate.Size = New System.Drawing.Size(156, 48)
        Me.lblTranslate.TabIndex = 4
        Me.lblTranslate.Text = "TRANSLATE"
        Me.lblTranslate.UseVisualStyleBackColor = True
        '
        'lblClear
        '
        Me.lblClear.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblClear.Location = New System.Drawing.Point(340, 329)
        Me.lblClear.Name = "lblClear"
        Me.lblClear.Size = New System.Drawing.Size(156, 48)
        Me.lblClear.TabIndex = 5
        Me.lblClear.Text = "CLEAR"
        Me.lblClear.UseVisualStyleBackColor = True
        '
        'lblTranslation
        '
        Me.lblTranslation.AutoSize = True
        Me.lblTranslation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTranslation.Location = New System.Drawing.Point(340, 192)
        Me.lblTranslation.Name = "lblTranslation"
        Me.lblTranslation.Size = New System.Drawing.Size(0, 21)
        Me.lblTranslation.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 439)
        Me.Controls.Add(Me.lblTranslation)
        Me.Controls.Add(Me.lblClear)
        Me.Controls.Add(Me.lblTranslate)
        Me.Controls.Add(Me.txtCurrency)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCurrency As TextBox
    Friend WithEvents lblTranslate As Button
    Friend WithEvents lblClear As Button
    Friend WithEvents lblTranslation As Label
End Class
