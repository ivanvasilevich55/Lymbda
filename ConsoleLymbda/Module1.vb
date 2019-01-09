Module Module1

	Sub Main()
		'Можно также объявить и вызвать лямбда-выражение, как показано в следующем примере.
		Console.WriteLine((Function(num As Integer) num + 1)(5))
		Console.ReadLine()
	End Sub

End Module
