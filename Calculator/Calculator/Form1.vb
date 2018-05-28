Public Class Form1

    Private isAdding As Boolean = False
    Private isSubtracting As Boolean = False
    Private isMultiplying As Boolean = False
    Private isDividing As Boolean = False
    Private isExponential As Boolean = False
    Private isModulus As Boolean = False


    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add.Click
        If num1.Text.Length <> 0 And num2.Text.Length <> 0 And isAdding = False Then
            Dim answer As Double = addition(CType(num1.Text, Double), CType(num2.Text, Double))
            txtanswer.Text = answer
            num2.ReadOnly = True
            isAdding = True
        ElseIf isAdding Then
            Dim ans As Double = addition(CType(num1.Text, Double), CType(num2.Text, Double))
            txtanswer.Text = ans.ToString()
        Else
            MessageBox.Show("Please fill all fields", "Fields Empty - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub subtract_Click(sender As Object, e As EventArgs) Handles subtract.Click
        If num1.Text.Length <> 0 And num2.Text.Length <> 0 And isSubtracting = False Then
            Dim answer As Double = subtraction(CType(num1.Text, Double), CType(num2.Text, Double))
            txtanswer.Text = answer
            num2.ReadOnly = True
            isSubtracting = True
        ElseIf isSubtracting Then
            Dim ans As Double = subtraction(CType(num1.Text, Double), CType(num2.Text, Double))
            txtanswer.Text = ans.ToString()
        Else
            MessageBox.Show("Please fill all fields", "Fields Empty - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub mult_Click(sender As Object, e As EventArgs) Handles mult.Click
        If num1.Text.Length <> 0 And num2.Text.Length <> 0 And isMultiplying = False Then
            Dim answer As Double = multiply(CType(num1.Text, Double), CType(num2.Text, Double))
            txtanswer.Text = answer
            num2.ReadOnly = True
            isMultiplying = True
        ElseIf isMultiplying Then
            Dim ans As Double = multiply(CType(num1.Text, Double), CType(num2.Text, Double))
            txtanswer.Text = ans.ToString()
        Else
            MessageBox.Show("Please fill all fields", "Fields Empty - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub power_Click(sender As Object, e As EventArgs) Handles power.Click
        If num1.Text.Length <> 0 And num2.Text.Length <> 0 And isExponential = False Then
            Dim answer As Double = exponent(CType(num1.Text, Double), CType(num2.Text, Double))
            txtanswer.Text = answer
            num2.ReadOnly = True
            isExponential = True
        ElseIf isExponential Then
            Dim ans As Double = exponent(CType(num1.Text, Double), CType(num2.Text, Double))
            txtanswer.Text = ans.ToString()
        Else
            MessageBox.Show("Please fill all fields", "Fields Empty - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub divide_Click(sender As Object, e As EventArgs) Handles divide.Click
        If num1.Text.Length <> 0 And num2.Text.Length <> 0 And isDividing = False Then
            Dim answer As Double = division(CType(num1.Text, Double), CType(num2.Text, Double))
            txtanswer.Text = answer
            num2.ReadOnly = True
            isDividing = True
        ElseIf isDividing Then
            Dim ans As Double = division(CType(num1.Text, Double), CType(num2.Text, Double))
            txtanswer.Text = ans.ToString()
        Else
            MessageBox.Show("Please fill all fields", "Fields Empty - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub modulus_Click(sender As Object, e As EventArgs) Handles modulus.Click
        Dim answer As Integer = modu(CType(num1.Text, Integer), CType(num2.Text, Integer))
        txtanswer.Text = answer
    End Sub

    Private Function addition(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 + num2
    End Function

    Private Function subtraction(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 - num2
    End Function

    Private Function multiply(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 * num2
    End Function

    Private Function division(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 / num2
    End Function

    Private Function exponent(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 ^ num2
    End Function

    Private Function modu(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Return num1 Mod num2
    End Function

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        revertBoolean()
        num1.Clear()
        num2.Clear()
        txtanswer.Clear()
    End Sub

    Private Sub revertBoolean()
        num2.ReadOnly = False

        isAdding = False
        isSubtracting = False
        isMultiplying = False
        isDividing = False
        isExponential = False
        isModulus = False
    End Sub
End Class
