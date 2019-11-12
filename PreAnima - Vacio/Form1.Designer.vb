<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTaller = New System.Windows.Forms.Label()
        Me.cbxTaller = New System.Windows.Forms.ComboBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.gbCalificacion = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lvAlumnos = New System.Windows.Forms.ListView()
        Me.Ci = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gbCalificacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTaller
        '
        Me.lblTaller.AutoSize = True
        Me.lblTaller.Location = New System.Drawing.Point(42, 28)
        Me.lblTaller.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTaller.Name = "lblTaller"
        Me.lblTaller.Size = New System.Drawing.Size(36, 13)
        Me.lblTaller.TabIndex = 1
        Me.lblTaller.Text = "Taller:"
        '
        'cbxTaller
        '
        Me.cbxTaller.FormattingEnabled = True
        Me.cbxTaller.Location = New System.Drawing.Point(68, 53)
        Me.cbxTaller.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxTaller.Name = "cbxTaller"
        Me.cbxTaller.Size = New System.Drawing.Size(182, 21)
        Me.cbxTaller.TabIndex = 2
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(280, 34)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 4
        Me.lblFecha.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(339, 50)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(214, 20)
        Me.dtpFecha.TabIndex = 5
        '
        'gbCalificacion
        '
        Me.gbCalificacion.Controls.Add(Me.RadioButton4)
        Me.gbCalificacion.Controls.Add(Me.RadioButton3)
        Me.gbCalificacion.Controls.Add(Me.RadioButton2)
        Me.gbCalificacion.Controls.Add(Me.RadioButton1)
        Me.gbCalificacion.Location = New System.Drawing.Point(299, 137)
        Me.gbCalificacion.Margin = New System.Windows.Forms.Padding(2)
        Me.gbCalificacion.Name = "gbCalificacion"
        Me.gbCalificacion.Padding = New System.Windows.Forms.Padding(2)
        Me.gbCalificacion.Size = New System.Drawing.Size(279, 41)
        Me.gbCalificacion.TabIndex = 6
        Me.gbCalificacion.TabStop = False
        Me.gbCalificacion.Text = "Organización y planificación"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(207, 17)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton4.TabIndex = 0
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(144, 17)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton3.TabIndex = 0
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(81, 17)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(24, 17)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(405, 255)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(96, 22)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(455, 223)
        Me.lblError.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(10, 13)
        Me.lblError.TabIndex = 10
        Me.lblError.Text = "-"
        '
        'lvAlumnos
        '
        Me.lvAlumnos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Ci, Me.Nombre})
        Me.lvAlumnos.HideSelection = False
        Me.lvAlumnos.Location = New System.Drawing.Point(35, 101)
        Me.lvAlumnos.Margin = New System.Windows.Forms.Padding(2)
        Me.lvAlumnos.MultiSelect = False
        Me.lvAlumnos.Name = "lvAlumnos"
        Me.lvAlumnos.Size = New System.Drawing.Size(248, 218)
        Me.lvAlumnos.TabIndex = 9
        Me.lvAlumnos.UseCompatibleStateImageBehavior = False
        Me.lvAlumnos.View = System.Windows.Forms.View.Details
        '
        'Ci
        '
        Me.Ci.Text = "Ci"
        Me.Ci.Width = 103
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        Me.Nombre.Width = 208
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 376)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lvAlumnos)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.gbCalificacion)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.cbxTaller)
        Me.Controls.Add(Me.lblTaller)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbCalificacion.ResumeLayout(False)
        Me.gbCalificacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTaller As Label
    Friend WithEvents cbxTaller As ComboBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents gbCalificacion As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblError As Label
    Friend WithEvents lvAlumnos As ListView
    Friend WithEvents Ci As ColumnHeader
    Friend WithEvents Nombre As ColumnHeader
End Class
