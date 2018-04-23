Imports DevExpress.Utils.Text
Imports DevExpress.Utils.Text.Internal
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Namespace SimpleHtmlEditExample
	<UserRepositoryItem("RegisterSimpleHtmlEdit")>
	Public Class RepositoryItemSimpleHtmlEdit
		Inherits RepositoryItemTextEdit

		Public Sub New()
		End Sub
		Shared Sub New()
			RegisterSimpleHtmlEdit()
		End Sub

		Public Const CustomEditName As String = "SimpleHtmlEdit"
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return CustomEditName
			End Get
		End Property
        Public Shared Sub RegisterSimpleHtmlEdit()
            Dim img As EditImageIndexes = 0
            Dim eci As EditorClassInfo = New EditorClassInfo(CustomEditName, GetType(SimpleHtmlEdit), GetType(RepositoryItemSimpleHtmlEdit), GetType(SimpleHtmlEditViewInfo), New TextEditPainter(), True, img)
            EditorRegistrationInfo.Default.Editors.Add(eci)
        End Sub
    End Class

	<ToolboxItem(True)>
	Public Class SimpleHtmlEdit
		Inherits BaseEdit

		Protected Property PrevCursor() As Cursor
		Public Sub New()
		End Sub

		Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			TryUpdateCursorByHyperlink(e)
		End Sub

		Protected Overridable Sub TryUpdateCursorByHyperlink(ByVal e As MouseEventArgs)
			If ViewInfo.GetStringInfo() Is Nothing Then
				Return
			End If
			Dim linkFound As StringBlock = ViewInfo.GetStringInfo().GetLinkByPoint(e.Location)
			If linkFound IsNot Nothing Then
				If PrevCursor Is Nothing Then
					PrevCursor = Cursor
				End If
				Cursor = Cursors.Hand
			Else
				If PrevCursor IsNot Nothing Then
					Cursor = PrevCursor
				End If
				PrevCursor = Nothing
			End If
		End Sub

		Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
			Try
				Dim linkFound As StringBlock = ViewInfo.GetStringInfo().GetLinkByPoint(e.Location)
				If linkFound IsNot Nothing Then
					OpenUrlInDefaultBrowser(linkFound.Link)
				End If

			Catch exc As Exception
				MessageBox.Show("link is not valid")
			End Try
		End Sub

		Public Sub OpenUrlInDefaultBrowser(ByVal url As String)
			Process.Start(url)
		End Sub

		Shared Sub New()
			RepositoryItemSimpleHtmlEdit.RegisterSimpleHtmlEdit()
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemSimpleHtmlEdit.CustomEditName
			End Get
		End Property
		Protected Friend Shadows ReadOnly Property ViewInfo() As SimpleHtmlEditViewInfo
			Get
				Return TryCast(MyBase.ViewInfo, SimpleHtmlEditViewInfo)
			End Get
		End Property
	End Class

	Public Class SimpleHtmlEditViewInfo
		Inherits TextEditViewInfo

		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)
		End Sub

		Public Function GetStringInfo() As StringInfo
			Return StringInfo
		End Function

		Public Overrides Function GetMouseCursor(ByVal point As Point) As Cursor
			If StringInfo.GetLinkByPoint(point) IsNot Nothing Then
				Return Cursors.Hand
			End If

			Return MyBase.GetMouseCursor(point)
		End Function

		Public Overrides ReadOnly Property AllowHtmlString() As Boolean
			Get
				Return True
			End Get
		End Property
		Public Overrides ReadOnly Property IsRequiredUpdateOnMouseMove() As Boolean
			Get
				Return True
			End Get
		End Property
	End Class
End Namespace