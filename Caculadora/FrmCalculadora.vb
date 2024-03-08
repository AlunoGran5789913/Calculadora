Imports System.Text.RegularExpressions

Public Class FrmCalculadora
    'Variaveis
    Private BotaoEmEfeito As Button = Nothing
    Private UltimoBotao As Button = Nothing
    Private OperadorAtual As String = ""
    Private SubOperacao As String = ""
    Private UltimoResultado As String = ""

    'Handlers
    Private Sub TempoEfeitoBotao_Tick(sender As Object, e As EventArgs) Handles TempoEfeitoBotao.Tick
        If BotaoEmEfeito IsNot Nothing AndAlso UltimoBotao Is Nothing Then
            UltimoBotao = BotaoEmEfeito
            BotaoEmEfeito = Nothing

            UltimoBotao.BackColor = Color.FromArgb(255, 224, 192)
        ElseIf UltimoBotao IsNot Nothing Then
            UltimoBotao.BackColor = Button.DefaultBackColor
            UltimoBotao.UseVisualStyleBackColor = True
            UltimoBotao = Nothing

            If BotaoEmEfeito Is Nothing Then sender.Stop()
        End If
    End Sub
    Private Sub ExecutarEfeitoBotao(botao As Button)
        If botao IsNot Nothing Then
            BotaoEmEfeito = botao
            TempoEfeitoBotao.Start()
        End If
    End Sub
    Private Sub ComandosDosBotoes_Click(sender As Object, e As EventArgs) Handles BtOpSubtracao.Click, BtOpPorcentagem.Click, BtOpMultiplicacao.Click, BtOpDivisao.Click, BtOpAdicao.Click, BtNum9.Click, BtNum8.Click, BtNum7.Click, BtNum6.Click, BtNum5.Click, BtNum4.Click, BtNum3.Click, BtNum2.Click, BtNum1.Click, BtNum0.Click, BtLimpar.Click, BtExecuta.Click, BtApagar.Click, BtNumVirgula.Click
        If sender IsNot Nothing Then
            ExecutarEfeitoBotao(sender)

            Dim botaoNome As String = sender.Name
            Dim botaoTexto As String = sender.Text.Trim()
            Dim btPrefixo As String = botaoNome.Substring(0, 4)
            Select Case btPrefixo
                Case "BtNu"
                    If Not String.IsNullOrWhiteSpace(UltimoResultado) AndAlso TxtEntrada.Text = UltimoResultado Then
                        TxtEntrada.Text = "0"
                    End If
                    If TxtEntrada.Text.Trim() = "0" Then
                        If botaoTexto = "," Then
                            If TxtEntrada.Text.IndexOf(",") = -1 Then
                                TxtEntrada.Text = "0" & botaoTexto
                            End If
                        Else
                            TxtEntrada.Text = botaoTexto
                        End If
                    Else
                        TxtEntrada.Text &= botaoTexto
                    End If
                Case "BtOp"
                    If botaoTexto = "%" AndAlso String.IsNullOrEmpty(TxtFormula.Text) Then
                        ComandosDosBotoes_Click(BtLimpar, Nothing)
                    ElseIf botaoTexto = "%" Then
                        SubOperacao = "%"
                        ComandosDosBotoes_Click(BtExecuta, Nothing)
                    Else
                        OperadorAtual = botaoTexto
                        TxtEntrada.Text &= " " & botaoTexto
                        TxtFormula.Text &= TxtEntrada.Text
                        TxtEntrada.Text = ""
                    End If
                Case "BtEx"
                    Dim aEntrada As String = If(Not String.IsNullOrWhiteSpace(TxtFormula.Text), TxtFormula.Text.Replace(OperadorAtual, "").Trim(), "")
                    Dim bEntrada As String = TxtEntrada.Text.Trim()
                    If NumeroValido(aEntrada, True) AndAlso NumeroValido(bEntrada, True) Then
                        Dim a As Decimal = CDec(TxtFormula.Text.Replace(OperadorAtual, "").Trim())
                        Dim b As Decimal = CDec(TxtEntrada.Text.Trim())
                        Dim r As Decimal

                        If SubOperacao = "%" AndAlso OperadorAtual <> "*" Then
                            r = a * b / 100
                        Else
                            Select Case OperadorAtual
                                Case "*"
                                    r = a * b
                                Case "-"
                                    r = a - b
                                Case "+"
                                    r = a + b
                                Case "/"
                                    r = a / b
                            End Select

                            If SubOperacao = "%" Then
                                If OperadorAtual = "*" Then
                                    r = r / 100
                                End If
                            End If
                        End If

                        Dim resultado = r.ToString
                        If resultado.IndexOf(",") <> -1 Then
                            Dim aResultado() As String = resultado.Split(",")
                            If String.IsNullOrWhiteSpace(aResultado(1)) OrElse CDec(aResultado(1)) <= CDec("0") Then
                                resultado = aResultado(0)
                            End If
                        End If

                        If SubOperacao = "%" Then
                            SubOperacao = ""
                            TxtFormula.Text = aEntrada & " " & OperadorAtual
                            TxtEntrada.Text = resultado.ToString
                        Else
                            TxtFormula.Text = ""
                            OperadorAtual = ""

                            TxtEntrada.Text = resultado.ToString
                            UltimoResultado = resultado.ToString
                        End If
                    End If
                Case "BtLi"
                    TxtFormula.Text = ""
                    OperadorAtual = ""
                    SubOperacao = ""
                    TxtEntrada.Text = "0"
                Case "BtAp"
                    If TxtEntrada.Text.Trim.Length > 0 AndAlso TxtEntrada.Text.Trim <> "0" Then
                        TxtEntrada.Text = TxtEntrada.Text.Substring(0, TxtEntrada.Text.Length - 1)
                    End If

                    If TxtEntrada.Text = "" Then TxtEntrada.Text = "0"
            End Select
        End If
        Panel1.Focus()
    End Sub
    Private Sub FrmCalculadora_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode >= Keys.NumPad0 AndAlso e.KeyCode <= Keys.NumPad9 Then
            Dim teclaTexto As String = e.KeyCode.ToString.Substring(6)
            ComandosDosBotoes_Click(CType(Controls("BtNum" & teclaTexto), Button), Nothing)
        ElseIf (e.KeyCode >= Keys.Multiply AndAlso e.KeyCode <= Keys.Divide) OrElse e.KeyCode = Keys.None Then
            Dim teclaTexto As String = e.KeyCode.ToString
            Select Case teclaTexto
                Case "Divide"
                    ComandosDosBotoes_Click(BtOpDivisao, Nothing)
                Case "Add"
                    ComandosDosBotoes_Click(BtOpAdicao, Nothing)
                Case "Multiply"
                    ComandosDosBotoes_Click(BtOpMultiplicacao, Nothing)
                Case "Subtract"
                    ComandosDosBotoes_Click(BtOpSubtracao, Nothing)
                Case "Decimal"
                    ComandosDosBotoes_Click(BtNumVirgula, Nothing)
                Case "None"
                    ComandosDosBotoes_Click(BtNumVirgula, Nothing)
            End Select
        ElseIf e.KeyCode = Keys.Enter Then
            ComandosDosBotoes_Click(BtExecuta, Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            ComandosDosBotoes_Click(BtLimpar, Nothing)
        ElseIf e.KeyCode = Keys.Back Then
            ComandosDosBotoes_Click(BtApagar, Nothing)
        Else
            e.Handled = True
        End If
    End Sub

    'Methods / Funcoes
    Public Function NumeroValido(Optional objNum As Object = Nothing, Optional bAllowPoint As Boolean = False) As Boolean
        If String.IsNullOrWhiteSpace(objNum) Then Return False
        Dim objResult As Boolean
        Dim objValue As String
        Try
            objValue = objNum.ToString
            If bAllowPoint AndAlso objValue.IndexOf(",") <> -1 Then objValue = objValue.Replace(",", "")
            Dim regex As New Regex("^[0-9]+$")
            objResult = regex.IsMatch(objValue)
        Catch
            objResult = False
        End Try
        Return objResult
    End Function
End Class
