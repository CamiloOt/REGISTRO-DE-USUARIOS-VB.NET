Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarse()
        'llenaGrid()
        llenaCombo()
    End Sub

    Public Sub llenaCombo()
        Me.cbmEliminar.Items.Clear()
        sql = "SELECT ID FROM PERSONA"
        cmd.CommandType = CommandType.Text
        cmd.Connection = coon
        cmd.CommandText = sql

        dr = cmd.ExecuteReader

        If dr.HasRows = True Then
            While dr.Read()
                Me.cbmEliminar.Items.Add(dr.GetValue(0))
            End While
        End If
        dr.Close()

    End Sub
    'Private Sub llenaGrid()
    '    Dim ds As New DataSet
    '    Dim dt As New DataTable
    '    Dim strSql As String = "SELECT ID, NOMBRES, APELLIDOS, CORREO, DIRECCION FROM PERSONA"
    '    Dim adp As New OleDb.OleDbDataAdapter(strSql, coon)

    '    ds.Tables.Add("tabla")
    '    adp.Fill(ds.Tables("tabla"))

    '    Me.DataGridView1.DataSource = ds.Tables("tabla")

    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    Dim id As String
    '    id = TextBox1.Text
    '    consultar(id)

    'End Sub


    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click

        If (Me.txtIdentificacion.Text = "") Then
            MsgBox("El campo no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
            Me.txtIdentificacion.Select()

        Else
            Dim identificacion As Integer
            Dim nombres As String = ""
            Dim apellidos As String = ""
            Dim correo As String = ""
            Dim Barrio As String = ""

            identificacion = Me.txtIdentificacion.Text
            nombres = Me.txtNombres.Text
            apellidos = Me.txtApellidos.Text
            correo = Me.txtCorreo.Text
            Barrio = Me.txtBarrio.Text

            cmd.CommandType = CommandType.Text
            cmd.Connection = coon

            sql = "INSERT INTO PERSONA(ID, NOMBRES, APELLIDOS, CORREO, BARRIO) "
            sql += "VALUES(" & identificacion & ", '" & nombres & "', '" & apellidos & "', '" & correo & "', '" & Barrio & "')"

            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro insertado correctamente")


            Catch ex As Exception
                If ex.ToString.Contains("valores duplicados") Then
                    MsgBox("El registro ya existe en la base de datos")
                Else
                    MsgBox(ex.ToString)
                End If
            End Try

        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs)
        txtApellidos.Clear()
        txtBarrio.Clear()
        txtIdentificacion.Clear()
        txtNombres.Clear()
        txtCorreo.Clear()
    End Sub

    Private Sub btnActulizar_Click(sender As Object, e As EventArgs) Handles btnActulizar.Click
        If (Me.txtIdentificacion1.Text = "") Then
            MsgBox("El campo de identificacion no puede estar vacio", MsgBoxStyle.Critical, "Atención")
            Me.txtIdentificacion.Select()

        Else
            Dim identificacion As Integer
            Dim nombres As String
            Dim apellidos As String
            Dim correo As String
            Dim barrio As String

            identificacion = Me.txtIdentificacion1.Text
            nombres = Me.txtNombres1.Text
            apellidos = Me.txtApellidos1.Text
            correo = Me.txtCorreo1.Text
            barrio = Me.txtBarrio1.Text



            cmd.CommandType = CommandType.Text
            cmd.Connection = coon



            sql = "UPDATE PERSONA SET "
            sql += "BARRIO='" + barrio
            sql += "', NOMBRES='" + nombres
            sql += "', APELLIDOS='" + apellidos
            sql += "', CORREO='" + correo
            sql += "' WHERE ID=" & identificacion

            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()


                Me.txtIdentificacion1.Text = ""
                Me.txtNombres1.Text = ""
                Me.txtApellidos1.Text = ""
                Me.txtCorreo1.Text = ""
                Me.txtBarrio1.Text = ""

                MsgBox("Registro actualizado correctamente")

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim identificacion As Integer
        identificacion = Me.txtIdentificacion2.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = coon

        sql = "DELETE FROM PERSONA WHERE ID = " & identificacion

        cmd.CommandText = sql

        Try
            Me.txtIdentificacion2.Text = ""
            Me.txtNombres2.Text = ""
            Me.txtApellidos2.Text = ""
            Me.txtCorreo2.Text = ""
            Me.txtBarrio2.Text = ""

            cmd.ExecuteNonQuery()

            MsgBox("Registro eliminado correctamente")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub txtIdentificacion1_Leave(sender As Object, e As EventArgs) Handles txtIdentificacion1.Leave

        If txtIdentificacion1.Text <> "" Then
            consultarPersona(txtIdentificacion1.Text)

            If dr.Read Then
                Me.txtNombres1.Text = dr(0).ToString
                Me.txtApellidos1.Text = dr(1).ToString
                Me.txtCorreo1.Text = dr(2).ToString
                Me.txtBarrio1.Text = dr(3).ToString
                Me.btnActulizar.Enabled = True

            Else
                Me.txtIdentificacion1.Text = ""
                Me.txtNombres1.Text = ""
                Me.txtApellidos1.Text = ""
                Me.txtCorreo1.Text = ""
                Me.txtBarrio1.Text = ""
                MsgBox("No se encontro el registro en la base de datos")
                Me.btnActulizar.Enabled = False
            End If
        Else
            Me.btnActulizar.Enabled = False
        End If

        dr.Close()
    End Sub

    Private Sub txtIdentificacion2_Leave(sender As Object, e As EventArgs) Handles txtIdentificacion2.Leave
        If txtIdentificacion2.Text <> "" Then
            consultarPersona(txtIdentificacion2.Text)

            If dr.Read Then
                Me.txtNombres2.Text = dr(0).ToString
                Me.txtApellidos2.Text = dr(1).ToString
                Me.txtCorreo2.Text = dr(2).ToString
                Me.txtBarrio2.Text = dr(3).ToString
                Me.btnEliminar.Enabled = True

            Else
                Me.txtIdentificacion2.Text = ""
                Me.txtNombres2.Text = ""
                Me.txtApellidos2.Text = ""
                Me.txtCorreo2.Text = ""
                Me.txtBarrio2.Text = ""

                MsgBox("No se encontro el registro en la base de datos")
                Me.btnEliminar.Enabled = False
            End If
        Else
            Me.btnEliminar.Enabled = False
        End If

        dr.Close()
    End Sub

    Private Sub cbmEliminar_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbmEliminar.SelectedValueChanged
        Me.txtIdentificacion2.Text = Me.cbmEliminar.SelectedItem.ToString

        If Me.cbmEliminar.SelectedItem.ToString <> "" Then
            consultarPersona(Me.cbmEliminar.SelectedItem.ToString)

            If dr.Read Then
                Me.txtNombres2.Text = dr(0).ToString
                Me.txtApellidos2.Text = dr(1).ToString
                Me.txtCorreo2.Text = dr(2).ToString
                Me.txtBarrio2.Text = dr(3).ToString
                Me.btnEliminar.Enabled = True

            Else
                'Me.txtIdentificacion2.Text = ""
                Me.txtNombres2.Text = ""
                Me.txtApellidos2.Text = ""
                Me.txtCorreo2.Text = ""
                Me.txtBarrio2.Text = ""

                MsgBox("No se encontro el registro en la base de datos")
                Me.btnEliminar.Enabled = False
            End If
        Else
            Me.btnEliminar.Enabled = False
        End If

        dr.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtApellidos.Clear()
        txtCorreo.Clear()
        txtIdentificacion.Clear()
        txtNombres.Clear()
        txtBarrio.Clear()

    End Sub
End Class
