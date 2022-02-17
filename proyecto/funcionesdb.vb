Imports System.Data.OleDb

Module funcionesdb
    Public coon As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=basedatos.accdb;Persist Security Info=False")
    Public cmd As New OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader
    Public sql As String = ""


    Public Sub conectarse()

        Try
            coon.Open()
            MsgBox("Conexion exitosa")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub consultar(ByRef identificacion As String)

        cmd.Connection = coon
        cmd.CommandType = CommandType.Text


        If identificacion <> "" Then
            cmd.CommandText = "SELECT NOMBRES, APELLIDOS, CORREO, BARRIO FROM PERSONA  WHERE ID=" + identificacion
        Else
            cmd.CommandText = "SELECT NOMBRES, APELLIDOS, CORREO, BARRIO FROM PERSONA"
        End If

        Try
            dr = cmd.ExecuteReader()


            If dr.HasRows Then
                While dr.Read()
                    MsgBox(dr(0).ToString + " " + dr(1).ToString + " " + dr(2).ToString + " " + dr(3).ToString)
                End While
            Else
                MsgBox("No existen registros para la consulta")

            End If

            dr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Public Sub consultarPersona(ByRef identificacion As String)

        cmd.Connection = coon
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT NOMBRES, APELLIDOS, CORREO, BARRIO FROM PERSONA  WHERE ID=" + identificacion

        Try
            dr = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Module
