Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmPrimero
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim InstrumentId As Integer = 127
        Dim CustomerId As Double
        Dim CompanyName As String
        InstrumentId *= CDbl(15.732222)
        CustomerId += Val(InstrumentId)
        'CompanyName = "Metas nacio en" & Str(CustomerId)
        'MsgBox(InstrumentId)
        'MsgBox(CustomerId)
        'MsgBox(CompanyName)
        txtParametro.Text = Val(CustomerId)
    End Sub

    Private Sub ButtonParameter_Click(sender As Object, e As EventArgs) Handles ButtonParameter.Click
        Dim output As New FrmSegundo
        output.txtparameter.Text = txtParametro.Text
        output.Show()
    End Sub
End Class
