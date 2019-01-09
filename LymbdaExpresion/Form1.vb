Public Class Form1
	'сигнатура
	Delegate Function delegateType() As String

	Private s As String
	Private Sub start() Handles Me.Load
		'безимянная функция
		Dim a As delegateType = Function()
									Return "Hello"
								End Function
		Me.Text = a()
		Dim increment = Sub(x As Integer) Me.Text = x.ToString
		increment(4)
		Dim increment2 = Function(x As Integer) x + 1
		Me.Text = increment2(7).ToString
	End Sub

End Class
