Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmTercerFormulario
    Dim conexion As SqlConnection
    Private Sub FrmTercerFormulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion = New SqlConnection("Data Source=PC57-L\METAS;Initial Catalog='INGENIERO';Integrated security=true;")
            conexion.Open()
            Dim comando As New SqlCommand("select * from Customers", conexion)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                DataGridView1.Rows.Add(lector(0), lector(1))
            End While
            lector.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error de conexion" & ex.ToString, MsgBoxStyle.Information)
        End Try
    End Sub


    Public Sub ejecutarTransaccion()
        Dim p As String
        Using connection As New SqlConnection("Data Source=PC57-L\METAS; Initial Catalog='INGENIERO'; Integrated security = true;")
            connection.Open()
            MsgBox("Conexion OK")
            Dim command As SqlCommand = connection.CreateCommand()
            Dim transaction As SqlTransaction
            transaction = connection.BeginTransaction("SampleTransaction")
            command.Connection = connection
            command.Transaction = transaction
            Try
                Try
                    p = "INSERT INTO Customers (NameCustomer) values('" & TextBox1.Text & "')"
                    command.CommandText = p
                    command.ExecuteNonQuery()
                    If MsgBox("Desea ejecutar la transaccion", MsgBoxStyle.YesNo, "EJECUTAR") = MsgBoxResult.Yes Then
                        transaction.Commit()
                        MsgBox("Transaccion completada")
                    Else
                        transaction.Rollback()
                        MsgBox("Transaccion cancelada")
                    End If
                Catch ex As Exception
                    MsgBox("Ocurrio un error al intentar hacer la transaccón", MsgBoxStyle.Exclamation)
                End Try
            Catch ex As Exception
                MsgBox("Commit Exception Type: {0} no se pudo insertar por error")
                Try
                    transaction.Rollback()
                Catch ex2 As Exception
                    MsgBox("Error Rollback")
                End Try
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ejecutarTransaccion()
    End Sub
End Class
