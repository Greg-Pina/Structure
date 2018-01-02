' *********************************************
' Ray Harmon
' <date>
' This program shows how to create a Structure 
' and pass it around instead of individual
' variables.
'
' *********************************************

Option Strict On

Public Class frmStructures

    Structure Numbers
        Dim intNumber1 As Integer
        Dim dblNumber2 As Double
        Dim sngNumber3 As Single
    End Structure

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' close the program
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear out all controls
        txtNumber1.Clear()
        txtNumber2.Clear()
        txtNumber3.Clear()

        lblResult.ResetText()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        ' local variables
        Dim Number As Numbers
        Dim dblAnswer As Double



        'If everything is validated then continue, else do not continue
        If Validation(Number) = True Then

            ' call function to add numbers together 
            dblAnswer = Calculate(Number)

            ' pass answer to be displayed. Pass it as a string
            Display(dblAnswer.ToString)


        End If

    End Sub

    Private Function Validation(ByRef Number As Numbers) As Boolean

        ' this will validate the input data for text box 1 using IsNumeric
        If IsNumeric(txtNumber1.Text) Then
            Number.intNumber1 = CInt(txtNumber1.Text)
        Else
            MessageBox.Show("Please enter numbers only for Number 1.")
            txtNumber1.Focus()
            txtNumber1.BackColor = Color.Yellow
            Return False ' reurn false as there is a problem
        End If

        ' this will validate the input data for text box 2 using IsNumeric
        If IsNumeric(txtNumber2.Text) Then
            Number.dblNumber2 = CDbl(txtNumber2.Text)
        Else
            MessageBox.Show("Please enter numbers only for Number 2.")
            txtNumber2.Focus()
            txtNumber2.BackColor = Color.Yellow
            Return False    ' reurn false as there is a problem
        End If

        ' this will validate the input data for text box 3 using TryParse
        If Not Single.TryParse(txtNumber3.Text, Number.sngNumber3) Then
            MessageBox.Show("Please enter numbers only for Number 3.")
            txtNumber3.Focus()
            txtNumber3.BackColor = Color.Yellow
            Return False    ' reurn false as there is a problem
        End If

        ' return True as we are good.
        Return True

    End Function

    Private Function Calculate(ByVal Nums As Numbers) As Double

        ' create local variable for answer
        Dim dblAnswer As Double

        'calculate
        dblAnswer = Nums.sngNumber3 + Nums.dblNumber2 + Nums.intNumber1

        ' return the answer as a double
        Return dblAnswer


    End Function

    Private Sub Display(ByVal Answer As String)

        ' display the output
        lblResult.Text = Answer

    End Sub

End Class
