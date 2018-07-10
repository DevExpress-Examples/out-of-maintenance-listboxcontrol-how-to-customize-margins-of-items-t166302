Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsFormsApplication313
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class
    <ToolboxItem(True)> _
    Public Class CustomListBoxControl
        Inherits ListBoxControl

        Public Sub New()
            MyBase.New()

        End Sub
        Protected Overrides Function CreateViewInfo() As BaseStyleControlViewInfo
            Return New CustomListBoxViewInfo(Me)
        End Function
        Protected Overrides Function CreatePainter() As BaseControlPainter
            Return New CustomBaseListBoxPainter()
        End Function
    End Class

    Friend Class CustomListBoxViewInfo
        Inherits BaseListBoxViewInfo

        Public Sub New(ByVal owner As BaseListBoxControl)
            MyBase.New(owner)

        End Sub

        Protected Overrides Function CreateItemPainter() As BaseListBoxItemPainter
            Return New CustomBaseListBoxItemPainter()
        End Function
    End Class
    Public Class CustomBaseListBoxItemPainter
        Inherits ListBoxItemPainter

        Public Sub New()
            MyBase.New()

        End Sub
        Private indent As Integer = 20, customLeftIndent As Integer = 5
        Public Overrides Function GetHorzPadding(ByVal e As ListBoxItemObjectInfoArgs) As Integer
            'change width between items
            Dim result As Integer = MyBase.GetHorzPadding(e)

            Return result + indent
        End Function
        Public Overrides Sub DrawObject(ByVal e As DevExpress.Utils.Drawing.ObjectInfoArgs)
            MyBase.DrawObject(e)
        End Sub
        Protected Overrides Function CalcItemTextRectangle(ByVal e As ListBoxItemObjectInfoArgs) As Rectangle
            'change the left margin here

            Return Rectangle.Inflate(e.TextRect, -GetHorzTextIndent(e) - customLeftIndent, 0)
        End Function
        Public Overrides Function GetVertPadding(ByVal e As ListBoxItemObjectInfoArgs) As Integer
            Dim result As Integer = MyBase.GetVertPadding(e)
            Return result + indent
        End Function
    End Class
    Friend Class CustomBaseListBoxPainter
        Inherits BaseListBoxPainter

        Public Sub New()
            MyBase.New()

        End Sub
        'avoid painting the control's border
        Protected Overrides Sub DrawBorder(ByVal info As ControlGraphicsInfoArgs)
            ' base.DrawBorder(info);
        End Sub
    End Class
End Namespace
