<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalculadora
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtEntrada = New System.Windows.Forms.Label()
        Me.TxtFormula = New System.Windows.Forms.Label()
        Me.BtApagar = New System.Windows.Forms.Button()
        Me.BtLimpar = New System.Windows.Forms.Button()
        Me.BtNum7 = New System.Windows.Forms.Button()
        Me.BtNum8 = New System.Windows.Forms.Button()
        Me.BtNum9 = New System.Windows.Forms.Button()
        Me.BtNum6 = New System.Windows.Forms.Button()
        Me.BtNum5 = New System.Windows.Forms.Button()
        Me.BtNum4 = New System.Windows.Forms.Button()
        Me.BtNum3 = New System.Windows.Forms.Button()
        Me.BtNum2 = New System.Windows.Forms.Button()
        Me.BtNum1 = New System.Windows.Forms.Button()
        Me.BtNum0 = New System.Windows.Forms.Button()
        Me.BtNumVirgula = New System.Windows.Forms.Button()
        Me.BtOpAdicao = New System.Windows.Forms.Button()
        Me.BtOpSubtracao = New System.Windows.Forms.Button()
        Me.BtOpMultiplicacao = New System.Windows.Forms.Button()
        Me.BtOpDivisao = New System.Windows.Forms.Button()
        Me.BtExecuta = New System.Windows.Forms.Button()
        Me.BtOpPorcentagem = New System.Windows.Forms.Button()
        Me.TempoEfeitoBotao = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(289, 80)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TxtEntrada)
        Me.Panel2.Controls.Add(Me.TxtFormula)
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(285, 76)
        Me.Panel2.TabIndex = 1
        '
        'TxtEntrada
        '
        Me.TxtEntrada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TxtEntrada.Location = New System.Drawing.Point(6, 39)
        Me.TxtEntrada.Name = "TxtEntrada"
        Me.TxtEntrada.Size = New System.Drawing.Size(270, 23)
        Me.TxtEntrada.TabIndex = 2
        Me.TxtEntrada.Text = "0"
        Me.TxtEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtFormula
        '
        Me.TxtFormula.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TxtFormula.Location = New System.Drawing.Point(6, 9)
        Me.TxtFormula.Name = "TxtFormula"
        Me.TxtFormula.Size = New System.Drawing.Size(270, 23)
        Me.TxtFormula.TabIndex = 1
        Me.TxtFormula.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtApagar
        '
        Me.BtApagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtApagar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtApagar.Location = New System.Drawing.Point(12, 98)
        Me.BtApagar.Name = "BtApagar"
        Me.BtApagar.Size = New System.Drawing.Size(75, 48)
        Me.BtApagar.TabIndex = 1
        Me.BtApagar.TabStop = False
        Me.BtApagar.Text = "Apagar"
        Me.BtApagar.UseVisualStyleBackColor = True
        '
        'BtLimpar
        '
        Me.BtLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtLimpar.ForeColor = System.Drawing.Color.Red
        Me.BtLimpar.Location = New System.Drawing.Point(95, 98)
        Me.BtLimpar.Name = "BtLimpar"
        Me.BtLimpar.Size = New System.Drawing.Size(75, 48)
        Me.BtLimpar.TabIndex = 2
        Me.BtLimpar.TabStop = False
        Me.BtLimpar.Text = "Limpar"
        Me.BtLimpar.UseVisualStyleBackColor = True
        '
        'BtNum7
        '
        Me.BtNum7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNum7.Location = New System.Drawing.Point(14, 152)
        Me.BtNum7.Name = "BtNum7"
        Me.BtNum7.Size = New System.Drawing.Size(48, 39)
        Me.BtNum7.TabIndex = 3
        Me.BtNum7.TabStop = False
        Me.BtNum7.Text = "7"
        Me.BtNum7.UseVisualStyleBackColor = True
        '
        'BtNum8
        '
        Me.BtNum8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNum8.Location = New System.Drawing.Point(68, 152)
        Me.BtNum8.Name = "BtNum8"
        Me.BtNum8.Size = New System.Drawing.Size(48, 39)
        Me.BtNum8.TabIndex = 4
        Me.BtNum8.TabStop = False
        Me.BtNum8.Text = "8"
        Me.BtNum8.UseVisualStyleBackColor = True
        '
        'BtNum9
        '
        Me.BtNum9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNum9.Location = New System.Drawing.Point(122, 152)
        Me.BtNum9.Name = "BtNum9"
        Me.BtNum9.Size = New System.Drawing.Size(48, 39)
        Me.BtNum9.TabIndex = 5
        Me.BtNum9.TabStop = False
        Me.BtNum9.Text = "9"
        Me.BtNum9.UseVisualStyleBackColor = True
        '
        'BtNum6
        '
        Me.BtNum6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNum6.Location = New System.Drawing.Point(120, 197)
        Me.BtNum6.Name = "BtNum6"
        Me.BtNum6.Size = New System.Drawing.Size(48, 39)
        Me.BtNum6.TabIndex = 8
        Me.BtNum6.TabStop = False
        Me.BtNum6.Text = "6"
        Me.BtNum6.UseVisualStyleBackColor = True
        '
        'BtNum5
        '
        Me.BtNum5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNum5.Location = New System.Drawing.Point(66, 197)
        Me.BtNum5.Name = "BtNum5"
        Me.BtNum5.Size = New System.Drawing.Size(48, 39)
        Me.BtNum5.TabIndex = 7
        Me.BtNum5.TabStop = False
        Me.BtNum5.Text = "5"
        Me.BtNum5.UseVisualStyleBackColor = True
        '
        'BtNum4
        '
        Me.BtNum4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNum4.Location = New System.Drawing.Point(12, 197)
        Me.BtNum4.Name = "BtNum4"
        Me.BtNum4.Size = New System.Drawing.Size(48, 39)
        Me.BtNum4.TabIndex = 6
        Me.BtNum4.TabStop = False
        Me.BtNum4.Text = "4"
        Me.BtNum4.UseVisualStyleBackColor = True
        '
        'BtNum3
        '
        Me.BtNum3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNum3.Location = New System.Drawing.Point(120, 242)
        Me.BtNum3.Name = "BtNum3"
        Me.BtNum3.Size = New System.Drawing.Size(48, 39)
        Me.BtNum3.TabIndex = 11
        Me.BtNum3.TabStop = False
        Me.BtNum3.Text = "3"
        Me.BtNum3.UseVisualStyleBackColor = True
        '
        'BtNum2
        '
        Me.BtNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNum2.Location = New System.Drawing.Point(66, 242)
        Me.BtNum2.Name = "BtNum2"
        Me.BtNum2.Size = New System.Drawing.Size(48, 39)
        Me.BtNum2.TabIndex = 10
        Me.BtNum2.TabStop = False
        Me.BtNum2.Text = "2"
        Me.BtNum2.UseVisualStyleBackColor = True
        '
        'BtNum1
        '
        Me.BtNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNum1.Location = New System.Drawing.Point(12, 242)
        Me.BtNum1.Name = "BtNum1"
        Me.BtNum1.Size = New System.Drawing.Size(48, 39)
        Me.BtNum1.TabIndex = 9
        Me.BtNum1.TabStop = False
        Me.BtNum1.Text = "1"
        Me.BtNum1.UseVisualStyleBackColor = True
        '
        'BtNum0
        '
        Me.BtNum0.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNum0.Location = New System.Drawing.Point(12, 287)
        Me.BtNum0.Name = "BtNum0"
        Me.BtNum0.Size = New System.Drawing.Size(102, 39)
        Me.BtNum0.TabIndex = 12
        Me.BtNum0.TabStop = False
        Me.BtNum0.Text = "0"
        Me.BtNum0.UseVisualStyleBackColor = True
        '
        'BtNumVirgula
        '
        Me.BtNumVirgula.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNumVirgula.Location = New System.Drawing.Point(120, 287)
        Me.BtNumVirgula.Name = "BtNumVirgula"
        Me.BtNumVirgula.Size = New System.Drawing.Size(48, 39)
        Me.BtNumVirgula.TabIndex = 13
        Me.BtNumVirgula.TabStop = False
        Me.BtNumVirgula.Text = ","
        Me.BtNumVirgula.UseVisualStyleBackColor = True
        '
        'BtOpAdicao
        '
        Me.BtOpAdicao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtOpAdicao.Location = New System.Drawing.Point(176, 287)
        Me.BtOpAdicao.Name = "BtOpAdicao"
        Me.BtOpAdicao.Size = New System.Drawing.Size(48, 39)
        Me.BtOpAdicao.TabIndex = 14
        Me.BtOpAdicao.TabStop = False
        Me.BtOpAdicao.Text = "+"
        Me.BtOpAdicao.UseVisualStyleBackColor = True
        '
        'BtOpSubtracao
        '
        Me.BtOpSubtracao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtOpSubtracao.Location = New System.Drawing.Point(176, 242)
        Me.BtOpSubtracao.Name = "BtOpSubtracao"
        Me.BtOpSubtracao.Size = New System.Drawing.Size(48, 39)
        Me.BtOpSubtracao.TabIndex = 15
        Me.BtOpSubtracao.TabStop = False
        Me.BtOpSubtracao.Text = "-"
        Me.BtOpSubtracao.UseVisualStyleBackColor = True
        '
        'BtOpMultiplicacao
        '
        Me.BtOpMultiplicacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtOpMultiplicacao.Location = New System.Drawing.Point(176, 197)
        Me.BtOpMultiplicacao.Name = "BtOpMultiplicacao"
        Me.BtOpMultiplicacao.Size = New System.Drawing.Size(48, 39)
        Me.BtOpMultiplicacao.TabIndex = 16
        Me.BtOpMultiplicacao.TabStop = False
        Me.BtOpMultiplicacao.Text = "*"
        Me.BtOpMultiplicacao.UseVisualStyleBackColor = True
        '
        'BtOpDivisao
        '
        Me.BtOpDivisao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtOpDivisao.Location = New System.Drawing.Point(176, 152)
        Me.BtOpDivisao.Name = "BtOpDivisao"
        Me.BtOpDivisao.Size = New System.Drawing.Size(48, 39)
        Me.BtOpDivisao.TabIndex = 17
        Me.BtOpDivisao.TabStop = False
        Me.BtOpDivisao.Text = "/"
        Me.BtOpDivisao.UseVisualStyleBackColor = True
        '
        'BtExecuta
        '
        Me.BtExecuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtExecuta.Location = New System.Drawing.Point(230, 98)
        Me.BtExecuta.Name = "BtExecuta"
        Me.BtExecuta.Size = New System.Drawing.Size(71, 228)
        Me.BtExecuta.TabIndex = 18
        Me.BtExecuta.TabStop = False
        Me.BtExecuta.Text = "="
        Me.BtExecuta.UseVisualStyleBackColor = True
        '
        'BtOpPorcentagem
        '
        Me.BtOpPorcentagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtOpPorcentagem.Location = New System.Drawing.Point(176, 98)
        Me.BtOpPorcentagem.Name = "BtOpPorcentagem"
        Me.BtOpPorcentagem.Size = New System.Drawing.Size(48, 48)
        Me.BtOpPorcentagem.TabIndex = 19
        Me.BtOpPorcentagem.TabStop = False
        Me.BtOpPorcentagem.Text = "%"
        Me.BtOpPorcentagem.UseVisualStyleBackColor = True
        '
        'TempoEfeitoBotao
        '
        Me.TempoEfeitoBotao.Interval = 50
        '
        'FrmCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(313, 336)
        Me.Controls.Add(Me.BtOpPorcentagem)
        Me.Controls.Add(Me.BtExecuta)
        Me.Controls.Add(Me.BtOpDivisao)
        Me.Controls.Add(Me.BtOpMultiplicacao)
        Me.Controls.Add(Me.BtOpSubtracao)
        Me.Controls.Add(Me.BtOpAdicao)
        Me.Controls.Add(Me.BtNumVirgula)
        Me.Controls.Add(Me.BtNum0)
        Me.Controls.Add(Me.BtNum3)
        Me.Controls.Add(Me.BtNum2)
        Me.Controls.Add(Me.BtNum1)
        Me.Controls.Add(Me.BtNum6)
        Me.Controls.Add(Me.BtNum5)
        Me.Controls.Add(Me.BtNum4)
        Me.Controls.Add(Me.BtNum9)
        Me.Controls.Add(Me.BtNum8)
        Me.Controls.Add(Me.BtNum7)
        Me.Controls.Add(Me.BtLimpar)
        Me.Controls.Add(Me.BtApagar)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmCalculadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtApagar As Button
    Friend WithEvents BtLimpar As Button
    Friend WithEvents BtNum7 As Button
    Friend WithEvents BtNum8 As Button
    Friend WithEvents BtNum9 As Button
    Friend WithEvents BtNum6 As Button
    Friend WithEvents BtNum5 As Button
    Friend WithEvents BtNum4 As Button
    Friend WithEvents BtNum3 As Button
    Friend WithEvents BtNum2 As Button
    Friend WithEvents BtNum1 As Button
    Friend WithEvents BtNum0 As Button
    Friend WithEvents BtNumVirgula As Button
    Friend WithEvents BtOpAdicao As Button
    Friend WithEvents BtOpSubtracao As Button
    Friend WithEvents BtOpMultiplicacao As Button
    Friend WithEvents BtOpDivisao As Button
    Friend WithEvents BtExecuta As Button
    Friend WithEvents BtOpPorcentagem As Button
    Friend WithEvents TempoEfeitoBotao As Timer
    Friend WithEvents TxtFormula As Label
    Friend WithEvents TxtEntrada As Label
End Class
