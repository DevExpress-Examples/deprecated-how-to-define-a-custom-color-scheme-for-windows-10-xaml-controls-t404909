Imports Microsoft.VisualBasic
Imports DevExpress.Core
Imports DevExpress.Mvvm
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class MainViewModel
	Inherits ViewModelBase

	Public Sub New()
		Me.ColorSchemeName = Me.ColorSchemeNames(0)
	End Sub

	Protected _ColorSchemeNames As List(Of String)
	Public ReadOnly Property ColorSchemeNames() As List(Of String)
		Get
			If Me._ColorSchemeNames Is Nothing Then
				Me._ColorSchemeNames = New List(Of String) (New String() {ThemeManager.GenericSchemeName, "Custom"})
			End If
			Return Me._ColorSchemeNames
		End Get
	End Property

    Protected _Themes As List(Of ElementTheme)

    Public ReadOnly Property Themes() As List(Of ElementTheme)
	    Get
		    If Me._Themes Is Nothing Then
			    Me._Themes = New List(Of ElementTheme)() From { _
				    ElementTheme.Light, _
				    ElementTheme.Dark _
			    }
		    End If
		    Return Me._Themes
	    End Get
    End Property

	Public Property ColorSchemeName() As String
		Get
			Return ThemeManager.CurrentColorSchemeName
		End Get
		Set(ByVal value As String)
			ThemeManager.CurrentColorSchemeName = value
            RaisePropertyChanged("ColorSchemeName")
		End Set
	End Property


End Class