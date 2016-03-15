Public Class Form1

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If msg.WParam.ToInt32() = CInt(Keys.Enter) Then
            If mode = "inputxy" Then
                button_input.PerformClick()
                input_x.Focus()
                Return True
            End If
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Dim mode As String

    Sub updateall()
        Dim i As Integer

        If mode = "inputxy" Then
            list_xy.Items.Clear()
            list_x2.Items.Clear()
            list_y2.Items.Clear()
            total_x.Text = 0
            total_y.Text = 0
            total_xy.Text = 0
            total_x2.Text = 0
            total_y2.Text = 0
            mean_x.Text = 0
            mean_y.Text = 0
            n.Text = 0
            sxx.Text = ""
            syy.Text = ""
            sxy.Text = ""
            regression.Text = ""
            correlation.Text = ""

            If list_x.Items.Count() = list_y.Items.Count() And list_x.Items.Count <> 0 Then

                i = -1
                For Each x In list_x.Items
                    i += 1
                    list_xy.Items.Add(CDec(x) * CDec(list_y.Items(i)))
                    list_x2.Items.Add(CDec(x) * CDec(x))
                    list_y2.Items.Add(CDec(list_y.Items(i)) * CDec(list_y.Items(i)))

                    total_x.Text = CDec(total_x.Text) + CDec(x)
                    total_y.Text = CDec(total_y.Text) + CDec(list_y.Items(i))
                Next

                For Each nxy In list_xy.Items
                    total_xy.Text = CDec(total_xy.Text) + CDec(nxy)
                Next
                For Each nx2 In list_x2.Items
                    total_x2.Text = CDec(total_x2.Text) + CDec(nx2)
                Next
                For Each ny2 In list_y2.Items
                    total_y2.Text = CDec(total_y2.Text) + CDec(ny2)
                Next
            End If
            n.Text = list_x.Items.Count()
        End If

        Try
            mean_x.Text = CDec(total_x.Text) / CDec(n.Text)
            mean_y.Text = CDec(total_y.Text) / CDec(n.Text)

            sxy.Text = CDec(total_xy.Text) - ((CDec(total_x.Text) * CDec(total_y.Text)) / CDec(n.Text))
            sxx.Text = CDec(total_x2.Text) - ((CDec(total_x.Text) * CDec(total_x.Text)) / CDec(n.Text))
            syy.Text = CDec(total_y2.Text) - ((CDec(total_y.Text) * CDec(total_y.Text)) / CDec(n.Text))


            calc_correlation()
            calc_regression()
        Catch
        End Try
    End Sub

    Sub calc_regression()
        Dim b, a As Decimal

        b = Math.Round(CDec(sxy.Text) / CDec(sxx.Text), 4)
        a = Math.Round((CDec(mean_y.Text)) - (b * CDec(mean_x.Text)), 4)

        regression.Text = ("y = " & b & "x + " & a).Replace(" + -", " - ")

    End Sub

    Sub calc_correlation()
        correlation.Text = (CDec(sxy.Text)) / (Math.Sqrt(CDec(sxx.Text) * CDec(syy.Text)))
        If correlation.Text = "NaN" Then
            correlation.Text = ""
        End If
    End Sub

    Private Sub button_input_Click(sender As Object, e As EventArgs) Handles button_input.Click
        Dim v As Decimal
        Try
            v = CDec(input_x.Text)
            v = CDec(input_y.Text)
            If input_x.Text <> "" And input_y.Text <> "" Then
                list_x.Items.Add(input_x.Text)
                input_x.Text = ""
                list_y.Items.Add(input_y.Text)
                input_y.Text = ""
                updateall()
            End If
        Catch
            input_x.Clear()
            input_y.Clear()
            input_x.Focus()
        End Try
    End Sub

    Private Sub button_remove_Click(sender As Object, e As EventArgs) Handles button_remove.Click
        Dim xi, yi As Integer
        xi = list_x.SelectedIndex()
        yi = list_y.SelectedIndex()
        Try
            If xi = yi Then
                list_x.Items.RemoveAt(xi)
                list_y.Items.RemoveAt(yi)
                updateall()
            End If
        Catch ex As Exception
            input_x.Text = input_x.Text
        End Try
    End Sub

    Private Sub list_x_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_x.SelectedIndexChanged
        Try
            list_y.SelectedIndex() = list_x.SelectedIndex()
        Catch
            list_y = list_y
        End Try
    End Sub

    Private Sub list_y_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_y.SelectedIndexChanged
        Try
            list_x.SelectedIndex() = list_y.SelectedIndex()
        Catch
            list_x = list_x
        End Try
    End Sub

    Private Sub button_removeall_Click(sender As Object, e As EventArgs) Handles button_removeall.Click
        list_x.Items.Clear()
        list_y.Items.Clear()
        If mode = "inputsig" Then
            button_switch.PerformClick()
        End If
        updateall()
    End Sub

    Private Sub button_switch_Click(sender As Object, e As EventArgs) Handles button_switch.Click
        If mode = "inputxy" Then
            mode = "inputsig"
            input_x.ReadOnly = True
            input_y.ReadOnly = True
            button_input.Enabled = False
            total_x.ReadOnly = False
            total_y.ReadOnly = False
            total_xy.ReadOnly = False
            total_x2.ReadOnly = False
            total_y2.ReadOnly = False
            n.ReadOnly = False
        Else
            mode = "inputxy"
            input_x.ReadOnly = False
            input_y.ReadOnly = False
            button_input.Enabled = True
            total_x.ReadOnly = True
            total_y.ReadOnly = True
            total_xy.ReadOnly = True
            total_x2.ReadOnly = True
            total_y2.ReadOnly = True
            n.ReadOnly = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mode = "inputxy"
    End Sub

    Private Sub total_x_TextChanged(sender As Object, e As EventArgs) Handles total_x.TextChanged
        If mode = "inputsig" Then
            updateall()
        End If
    End Sub

    Private Sub total_y_TextChanged(sender As Object, e As EventArgs) Handles total_y.TextChanged
        If mode = "inputsig" Then
            updateall()
        End If
    End Sub

    Private Sub total_xy_TextChanged(sender As Object, e As EventArgs) Handles total_xy.TextChanged
        If mode = "inputsig" Then
            updateall()
        End If
    End Sub

    Private Sub total_x2_TextChanged(sender As Object, e As EventArgs) Handles total_x2.TextChanged
        If mode = "inputsig" Then
            updateall()
        End If
    End Sub

    Private Sub total_y2_TextChanged(sender As Object, e As EventArgs) Handles total_y2.TextChanged
        If mode = "inputsig" Then
            updateall()
        End If
    End Sub

    Private Sub n_TextChanged(sender As Object, e As EventArgs) Handles n.TextChanged
        If mode = "inputsig" Then
            updateall()
        End If
    End Sub
End Class
