<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tbcPrincipal = New System.Windows.Forms.TabControl()
        Me.tabInsertar = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.lblBarrio = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.lblIdentificacion = New System.Windows.Forms.Label()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtBarrio = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.TabActualizar = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnActulizar = New System.Windows.Forms.Button()
        Me.txtApellidos1 = New System.Windows.Forms.TextBox()
        Me.txtBarrio1 = New System.Windows.Forms.TextBox()
        Me.txtCorreo1 = New System.Windows.Forms.TextBox()
        Me.txtNombres1 = New System.Windows.Forms.TextBox()
        Me.txtIdentificacion1 = New System.Windows.Forms.TextBox()
        Me.tabEliminar = New System.Windows.Forms.TabPage()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbmEliminar = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtApellidos2 = New System.Windows.Forms.TextBox()
        Me.txtBarrio2 = New System.Windows.Forms.TextBox()
        Me.txtCorreo2 = New System.Windows.Forms.TextBox()
        Me.txtNombres2 = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtIdentificacion2 = New System.Windows.Forms.TextBox()
        Me.lblIdentificacion2 = New System.Windows.Forms.Label()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.tbcPrincipal.SuspendLayout()
        Me.tabInsertar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabActualizar.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEliminar.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcPrincipal
        '
        Me.tbcPrincipal.Controls.Add(Me.tabInsertar)
        Me.tbcPrincipal.Controls.Add(Me.TabActualizar)
        Me.tbcPrincipal.Controls.Add(Me.tabEliminar)
        Me.tbcPrincipal.Location = New System.Drawing.Point(12, 9)
        Me.tbcPrincipal.Name = "tbcPrincipal"
        Me.tbcPrincipal.SelectedIndex = 0
        Me.tbcPrincipal.Size = New System.Drawing.Size(555, 532)
        Me.tbcPrincipal.TabIndex = 0
        '
        'tabInsertar
        '
        Me.tabInsertar.Controls.Add(Me.Button1)
        Me.tabInsertar.Controls.Add(Me.PictureBox1)
        Me.tabInsertar.Controls.Add(Me.btnsalir)
        Me.tabInsertar.Controls.Add(Me.lblBarrio)
        Me.tabInsertar.Controls.Add(Me.lblCorreo)
        Me.tabInsertar.Controls.Add(Me.lblApellidos)
        Me.tabInsertar.Controls.Add(Me.lblNombres)
        Me.tabInsertar.Controls.Add(Me.lblIdentificacion)
        Me.tabInsertar.Controls.Add(Me.btnInsertar)
        Me.tabInsertar.Controls.Add(Me.txtApellidos)
        Me.tabInsertar.Controls.Add(Me.txtBarrio)
        Me.tabInsertar.Controls.Add(Me.txtCorreo)
        Me.tabInsertar.Controls.Add(Me.txtNombres)
        Me.tabInsertar.Controls.Add(Me.txtIdentificacion)
        Me.tabInsertar.Location = New System.Drawing.Point(4, 34)
        Me.tabInsertar.Name = "tabInsertar"
        Me.tabInsertar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabInsertar.Size = New System.Drawing.Size(547, 494)
        Me.tabInsertar.TabIndex = 0
        Me.tabInsertar.Text = "INSERTAR"
        Me.tabInsertar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(380, 443)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "LIMPIAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(349, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 103)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(231, 443)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(112, 34)
        Me.btnsalir.TabIndex = 12
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'lblBarrio
        '
        Me.lblBarrio.AutoSize = True
        Me.lblBarrio.Location = New System.Drawing.Point(6, 356)
        Me.lblBarrio.Name = "lblBarrio"
        Me.lblBarrio.Size = New System.Drawing.Size(58, 25)
        Me.lblBarrio.TabIndex = 10
        Me.lblBarrio.Text = "Barrio"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(7, 269)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(66, 25)
        Me.lblCorreo.TabIndex = 9
        Me.lblCorreo.Text = "Correo"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Location = New System.Drawing.Point(6, 180)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(86, 25)
        Me.lblApellidos.TabIndex = 8
        Me.lblApellidos.Text = "Apellidos"
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.Location = New System.Drawing.Point(6, 90)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(86, 25)
        Me.lblNombres.TabIndex = 7
        Me.lblNombres.Text = "Nombres"
        '
        'lblIdentificacion
        '
        Me.lblIdentificacion.AutoSize = True
        Me.lblIdentificacion.Location = New System.Drawing.Point(7, 15)
        Me.lblIdentificacion.Name = "lblIdentificacion"
        Me.lblIdentificacion.Size = New System.Drawing.Size(117, 25)
        Me.lblIdentificacion.TabIndex = 6
        Me.lblIdentificacion.Text = "Identificación"
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(83, 443)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(108, 34)
        Me.btnInsertar.TabIndex = 5
        Me.btnInsertar.Text = "INSERTAR"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(6, 208)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(486, 31)
        Me.txtApellidos.TabIndex = 4
        '
        'txtBarrio
        '
        Me.txtBarrio.Location = New System.Drawing.Point(6, 384)
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(485, 31)
        Me.txtBarrio.TabIndex = 3
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(6, 297)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(486, 31)
        Me.txtCorreo.TabIndex = 2
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(6, 118)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(486, 31)
        Me.txtNombres.TabIndex = 1
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(7, 43)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(150, 31)
        Me.txtIdentificacion.TabIndex = 0
        '
        'TabActualizar
        '
        Me.TabActualizar.Controls.Add(Me.PictureBox2)
        Me.TabActualizar.Controls.Add(Me.Label1)
        Me.TabActualizar.Controls.Add(Me.Label2)
        Me.TabActualizar.Controls.Add(Me.Label3)
        Me.TabActualizar.Controls.Add(Me.Label4)
        Me.TabActualizar.Controls.Add(Me.Label5)
        Me.TabActualizar.Controls.Add(Me.btnActulizar)
        Me.TabActualizar.Controls.Add(Me.txtApellidos1)
        Me.TabActualizar.Controls.Add(Me.txtBarrio1)
        Me.TabActualizar.Controls.Add(Me.txtCorreo1)
        Me.TabActualizar.Controls.Add(Me.txtNombres1)
        Me.TabActualizar.Controls.Add(Me.txtIdentificacion1)
        Me.TabActualizar.Location = New System.Drawing.Point(4, 34)
        Me.TabActualizar.Name = "TabActualizar"
        Me.TabActualizar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabActualizar.Size = New System.Drawing.Size(547, 494)
        Me.TabActualizar.TabIndex = 1
        Me.TabActualizar.Text = "ACTUALIZAR"
        Me.TabActualizar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(349, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(142, 103)
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 25)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Barrio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Correo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 25)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Apellidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 25)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Nombres"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Identificación"
        '
        'btnActulizar
        '
        Me.btnActulizar.Enabled = False
        Me.btnActulizar.Location = New System.Drawing.Point(199, 445)
        Me.btnActulizar.Name = "btnActulizar"
        Me.btnActulizar.Size = New System.Drawing.Size(123, 34)
        Me.btnActulizar.TabIndex = 16
        Me.btnActulizar.Text = "ACTUALIZAR"
        Me.btnActulizar.UseVisualStyleBackColor = True
        '
        'txtApellidos1
        '
        Me.txtApellidos1.Location = New System.Drawing.Point(6, 208)
        Me.txtApellidos1.Name = "txtApellidos1"
        Me.txtApellidos1.Size = New System.Drawing.Size(486, 31)
        Me.txtApellidos1.TabIndex = 15
        '
        'txtBarrio1
        '
        Me.txtBarrio1.Location = New System.Drawing.Point(6, 384)
        Me.txtBarrio1.Name = "txtBarrio1"
        Me.txtBarrio1.Size = New System.Drawing.Size(485, 31)
        Me.txtBarrio1.TabIndex = 14
        '
        'txtCorreo1
        '
        Me.txtCorreo1.Location = New System.Drawing.Point(6, 297)
        Me.txtCorreo1.Name = "txtCorreo1"
        Me.txtCorreo1.Size = New System.Drawing.Size(486, 31)
        Me.txtCorreo1.TabIndex = 13
        '
        'txtNombres1
        '
        Me.txtNombres1.Location = New System.Drawing.Point(6, 118)
        Me.txtNombres1.Name = "txtNombres1"
        Me.txtNombres1.Size = New System.Drawing.Size(486, 31)
        Me.txtNombres1.TabIndex = 12
        '
        'txtIdentificacion1
        '
        Me.txtIdentificacion1.Location = New System.Drawing.Point(7, 43)
        Me.txtIdentificacion1.Name = "txtIdentificacion1"
        Me.txtIdentificacion1.Size = New System.Drawing.Size(150, 31)
        Me.txtIdentificacion1.TabIndex = 11
        '
        'tabEliminar
        '
        Me.tabEliminar.Controls.Add(Me.PictureBox3)
        Me.tabEliminar.Controls.Add(Me.Label10)
        Me.tabEliminar.Controls.Add(Me.cbmEliminar)
        Me.tabEliminar.Controls.Add(Me.Label6)
        Me.tabEliminar.Controls.Add(Me.Label7)
        Me.tabEliminar.Controls.Add(Me.Label8)
        Me.tabEliminar.Controls.Add(Me.Label9)
        Me.tabEliminar.Controls.Add(Me.txtApellidos2)
        Me.tabEliminar.Controls.Add(Me.txtBarrio2)
        Me.tabEliminar.Controls.Add(Me.txtCorreo2)
        Me.tabEliminar.Controls.Add(Me.txtNombres2)
        Me.tabEliminar.Controls.Add(Me.btnEliminar)
        Me.tabEliminar.Controls.Add(Me.txtIdentificacion2)
        Me.tabEliminar.Controls.Add(Me.lblIdentificacion2)
        Me.tabEliminar.Location = New System.Drawing.Point(4, 34)
        Me.tabEliminar.Name = "tabEliminar"
        Me.tabEliminar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEliminar.Size = New System.Drawing.Size(547, 494)
        Me.tabEliminar.TabIndex = 2
        Me.tabEliminar.Text = "ELIMINAR"
        Me.tabEliminar.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(322, 443)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(45, 34)
        Me.PictureBox3.TabIndex = 32
        Me.PictureBox3.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(309, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 25)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Identificación"
        '
        'cbmEliminar
        '
        Me.cbmEliminar.FormattingEnabled = True
        Me.cbmEliminar.Location = New System.Drawing.Point(309, 40)
        Me.cbmEliminar.Name = "cbmEliminar"
        Me.cbmEliminar.Size = New System.Drawing.Size(182, 33)
        Me.cbmEliminar.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 25)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Barrio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 25)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Correo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 25)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Apellidos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 25)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Nombres"
        '
        'txtApellidos2
        '
        Me.txtApellidos2.Enabled = False
        Me.txtApellidos2.Location = New System.Drawing.Point(6, 211)
        Me.txtApellidos2.Name = "txtApellidos2"
        Me.txtApellidos2.Size = New System.Drawing.Size(486, 31)
        Me.txtApellidos2.TabIndex = 25
        '
        'txtBarrio2
        '
        Me.txtBarrio2.Enabled = False
        Me.txtBarrio2.Location = New System.Drawing.Point(6, 387)
        Me.txtBarrio2.Name = "txtBarrio2"
        Me.txtBarrio2.Size = New System.Drawing.Size(485, 31)
        Me.txtBarrio2.TabIndex = 24
        '
        'txtCorreo2
        '
        Me.txtCorreo2.Enabled = False
        Me.txtCorreo2.Location = New System.Drawing.Point(8, 306)
        Me.txtCorreo2.Name = "txtCorreo2"
        Me.txtCorreo2.Size = New System.Drawing.Size(486, 31)
        Me.txtCorreo2.TabIndex = 23
        '
        'txtNombres2
        '
        Me.txtNombres2.Enabled = False
        Me.txtNombres2.Location = New System.Drawing.Point(6, 121)
        Me.txtNombres2.Name = "txtNombres2"
        Me.txtNombres2.Size = New System.Drawing.Size(486, 31)
        Me.txtNombres2.TabIndex = 22
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(382, 443)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(112, 34)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtIdentificacion2
        '
        Me.txtIdentificacion2.Location = New System.Drawing.Point(8, 42)
        Me.txtIdentificacion2.Name = "txtIdentificacion2"
        Me.txtIdentificacion2.Size = New System.Drawing.Size(150, 31)
        Me.txtIdentificacion2.TabIndex = 1
        '
        'lblIdentificacion2
        '
        Me.lblIdentificacion2.AutoSize = True
        Me.lblIdentificacion2.Location = New System.Drawing.Point(7, 14)
        Me.lblIdentificacion2.Name = "lblIdentificacion2"
        Me.lblIdentificacion2.Size = New System.Drawing.Size(117, 25)
        Me.lblIdentificacion2.TabIndex = 0
        Me.lblIdentificacion2.Text = "Identificación"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 545)
        Me.Controls.Add(Me.tbcPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "  REGISTRO DE USUARIOS"
        Me.tbcPrincipal.ResumeLayout(False)
        Me.tabInsertar.ResumeLayout(False)
        Me.tabInsertar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabActualizar.ResumeLayout(False)
        Me.TabActualizar.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEliminar.ResumeLayout(False)
        Me.tabEliminar.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcPrincipal As TabControl
    Friend WithEvents tabInsertar As TabPage
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblNombres As Label
    Friend WithEvents lblIdentificacion As Label
    Friend WithEvents btnInsertar As Button
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtBarrio As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents lblBarrio As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents tabEliminar As TabPage
    Friend WithEvents btnEliminar As Button
    Friend WithEvents lblIdentificacion2 As Label
    Friend WithEvents txtIdentificacion2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtApellidos2 As TextBox
    Friend WithEvents txtBarrio2 As TextBox
    Friend WithEvents txtCorreo2 As TextBox
    Friend WithEvents txtNombres2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbmEliminar As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents TabActualizar As TabPage
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnActulizar As Button
    Friend WithEvents txtApellidos1 As TextBox
    Friend WithEvents txtBarrio1 As TextBox
    Friend WithEvents txtCorreo1 As TextBox
    Friend WithEvents txtNombres1 As TextBox
    Friend WithEvents txtIdentificacion1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox3 As PictureBox
End Class
