Public Class ThemeFriendlyNameConverter
	Implements IValueConverter
	Public Function Convert(value As Object, targetType As Type, parameter As Object, language As String) As Object Implements IValueConverter.Convert
		Select Case DirectCast(value, ElementTheme)
			Case ElementTheme.Light
				Return "Light"
			Case ElementTheme.[Default], ElementTheme.Dark
				Return "Dark"
		End Select

		Return String.Empty
	End Function
	Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, language As String) As Object Implements IValueConverter.ConvertBack
		Throw New NotImplementedException()
	End Function
End Class