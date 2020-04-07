Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For i = 0 To Math.PI Step 0.02


            For Each mav In Me.Controls

                If TypeOf mav Is MultiAmmVoltmeter.MultiAmmVoltmeter Then

                    mav.value = (mav.maximum - mav.minimum) * Math.Abs(Math.Sin(i)) + mav.minimum
                End If

            Next


        Next

    End Sub


End Class
