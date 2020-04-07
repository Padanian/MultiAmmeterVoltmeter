<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MultiAmmVoltmeter1 = New MultiAmmVoltmeter.MultiAmmVoltmeter()
        Me.MultiAmmVoltmeter2 = New MultiAmmVoltmeter.MultiAmmVoltmeter()
        Me.MultiAmmVoltmeter3 = New MultiAmmVoltmeter.MultiAmmVoltmeter()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(534, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MultiAmmVoltmeter1
        '
        Me.MultiAmmVoltmeter1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiAmmVoltmeter1.Location = New System.Drawing.Point(12, 13)
        Me.MultiAmmVoltmeter1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MultiAmmVoltmeter1.maximum = 400.0!
        Me.MultiAmmVoltmeter1.minimum = 0!
        Me.MultiAmmVoltmeter1.Name = "MultiAmmVoltmeter1"
        Me.MultiAmmVoltmeter1.Size = New System.Drawing.Size(150, 150)
        Me.MultiAmmVoltmeter1.TabIndex = 1
        Me.MultiAmmVoltmeter1.units = "V"
        Me.MultiAmmVoltmeter1.value = 0!
        '
        'MultiAmmVoltmeter2
        '
        Me.MultiAmmVoltmeter2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiAmmVoltmeter2.Location = New System.Drawing.Point(168, 13)
        Me.MultiAmmVoltmeter2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MultiAmmVoltmeter2.maximum = 8.0!
        Me.MultiAmmVoltmeter2.minimum = 0!
        Me.MultiAmmVoltmeter2.Name = "MultiAmmVoltmeter2"
        Me.MultiAmmVoltmeter2.Size = New System.Drawing.Size(150, 150)
        Me.MultiAmmVoltmeter2.TabIndex = 0
        Me.MultiAmmVoltmeter2.units = "A"
        Me.MultiAmmVoltmeter2.value = 0!
        '
        'MultiAmmVoltmeter3
        '
        Me.MultiAmmVoltmeter3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiAmmVoltmeter3.Location = New System.Drawing.Point(324, 13)
        Me.MultiAmmVoltmeter3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MultiAmmVoltmeter3.maximum = 54.0!
        Me.MultiAmmVoltmeter3.minimum = 46.0!
        Me.MultiAmmVoltmeter3.Name = "MultiAmmVoltmeter3"
        Me.MultiAmmVoltmeter3.Size = New System.Drawing.Size(150, 150)
        Me.MultiAmmVoltmeter3.TabIndex = 3
        Me.MultiAmmVoltmeter3.units = "H"
        Me.MultiAmmVoltmeter3.value = 47.0!
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 224)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MultiAmmVoltmeter1)
        Me.Controls.Add(Me.MultiAmmVoltmeter2)
        Me.Controls.Add(Me.MultiAmmVoltmeter3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MultiAmmVoltmeter3 As MultiAmmVoltmeter.MultiAmmVoltmeter
    Friend WithEvents MultiAmmVoltmeter2 As MultiAmmVoltmeter.MultiAmmVoltmeter
    Friend WithEvents MultiAmmVoltmeter1 As MultiAmmVoltmeter.MultiAmmVoltmeter
    Friend WithEvents Button1 As Button
End Class
