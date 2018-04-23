Namespace WindowsFormsApplication313
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
            Me.customListBoxControl1 = New WindowsFormsApplication313.CustomListBoxControl()
            DirectCast(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.customListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' listBoxControl1
            ' 
            Me.listBoxControl1.Location = New System.Drawing.Point(46, 34)
            Me.listBoxControl1.Name = "listBoxControl1"
            Me.listBoxControl1.Size = New System.Drawing.Size(120, 95)
            Me.listBoxControl1.TabIndex = 0
            ' 
            ' customListBoxControl1
            ' 
            Me.customListBoxControl1.Items.AddRange(New Object() { "dsfdsfdsfds", "dsfdsfdsfds", "dsfdsfdsfds", "dsfdsfdsfds", "dsfdsfdsfds", "dsfdsfdsfds", "dsfdsfdsfds", "dsfdsfdsfds", "dsfdsfdsfds", "dsfdsfdsfds", "dsfdsfdsfds", "dsfdsfdsfds", "dsfdsfdsfds", "dsfdsfdsfds", "dsfdsfdsfds", "dsfdsfdsfds"})
            Me.customListBoxControl1.Location = New System.Drawing.Point(102, 162)
            Me.customListBoxControl1.MultiColumn = True
            Me.customListBoxControl1.Name = "customListBoxControl1"
            Me.customListBoxControl1.Size = New System.Drawing.Size(260, 160)
            Me.customListBoxControl1.TabIndex = 1
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(641, 388)
            Me.Controls.Add(Me.customListBoxControl1)
            Me.Controls.Add(Me.listBoxControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.customListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
        Private customListBoxControl1 As CustomListBoxControl
    End Class
End Namespace

