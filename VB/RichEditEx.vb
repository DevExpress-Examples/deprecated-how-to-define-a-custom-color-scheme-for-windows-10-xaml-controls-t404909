Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Windows.Storage
Imports Windows.UI.Xaml.Controls


Public Class RichEditEx
	Inherits RichEditBox

    Public Sub New()
	    DefaultStyleKey = GetType(RichEditEx)
    End Sub

	Protected _Source As Uri

	Public Property Source() As Uri
		Get
			Return Me._Source
		End Get
		Set(ByVal value As Uri)
			Me._Source = value
			Me.OnSourceChanged()
		End Set
	End Property

	Private async Sub OnSourceChanged()
		If Source Is Nothing Then
			Document.SetText(Windows.UI.Text.TextSetOptions.None, Nothing)
		Else
			Dim file = await StorageFile.GetFileFromApplicationUriAsync(Source)
			Dim stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read)
			Document.LoadFromStream(Windows.UI.Text.TextSetOptions.FormatRtf, stream)
		End If
	End Sub
End Class
