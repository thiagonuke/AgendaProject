<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastrarCompromisso
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.titTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.desctxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtInitxt = New System.Windows.Forms.DateTimePicker()
        Me.dtfinaltxt = New System.Windows.Forms.DateTimePicker()
        Me.localtxt = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Titulo:"
        '
        'titTxt
        '
        Me.titTxt.Location = New System.Drawing.Point(195, 136)
        Me.titTxt.Name = "titTxt"
        Me.titTxt.Size = New System.Drawing.Size(293, 20)
        Me.titTxt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Descricao:"
        '
        'desctxt
        '
        Me.desctxt.Location = New System.Drawing.Point(195, 192)
        Me.desctxt.Name = "desctxt"
        Me.desctxt.Size = New System.Drawing.Size(293, 20)
        Me.desctxt.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Data de Inicio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Data fim:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 356)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Localizacao:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(39, 449)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 33)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Salvar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtInitxt
        '
        Me.dtInitxt.Location = New System.Drawing.Point(195, 249)
        Me.dtInitxt.Name = "dtInitxt"
        Me.dtInitxt.Size = New System.Drawing.Size(293, 20)
        Me.dtInitxt.TabIndex = 14
        '
        'dtfinaltxt
        '
        Me.dtfinaltxt.Location = New System.Drawing.Point(195, 306)
        Me.dtfinaltxt.Name = "dtfinaltxt"
        Me.dtfinaltxt.Size = New System.Drawing.Size(293, 20)
        Me.dtfinaltxt.TabIndex = 15
        '
        'localtxt
        '
        Me.localtxt.Location = New System.Drawing.Point(195, 356)
        Me.localtxt.Name = "localtxt"
        Me.localtxt.Size = New System.Drawing.Size(293, 60)
        Me.localtxt.TabIndex = 16
        Me.localtxt.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(368, 46)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Salvar Compromisso"
        '
        'CadastrarCompromisso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(631, 515)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.localtxt)
        Me.Controls.Add(Me.dtfinaltxt)
        Me.Controls.Add(Me.dtInitxt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.desctxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.titTxt)
        Me.Name = "CadastrarCompromisso"
        Me.Text = "CadastrarCompromiso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents titTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents desctxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents dtInitxt As DateTimePicker
    Friend WithEvents dtfinaltxt As DateTimePicker
    Friend WithEvents localtxt As RichTextBox
    Friend WithEvents Label6 As Label
End Class
