Imports System.Drawing.Printing
Public Class Form1
    Inherits System.Windows.Forms.Form
    Private Sub chkBold_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBold.CheckedChanged, chkItalic.CheckedChanged
        If chkBold.Checked Then
            If chkItalic.Checked Then                   'Bold Italic
                txtDisplay.Font = New Font("Arial", 12, FontStyle.Bold Or FontStyle.Italic)
            Else                                        'Just Bold
                txtDisplay.Font = New Font("Arial", 12, FontStyle.Bold)
            End If
        ElseIf chkItalic.Checked Then               'Just Italic
            txtDisplay.Font = New Font("Arial", 12, FontStyle.Italic)
        Else                                        'Regular
            txtDisplay.Font = New Font("Arial", 12, FontStyle.Regular)
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
