' <auto-generated> This file has been auto generated by xunit.v3.core. </auto-generated>

<Global.System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage>
Public Class AutoGeneratedEntryPoint
	Public Shared Function Main(args As String()) As Integer
		If Global.System.Linq.Enumerable.Any(args, Function(arg) arg = "-automated" OrElse arg = "@@") Then
			Return Global.Xunit.Runner.InProc.SystemConsole.ConsoleRunner.Run(args).GetAwaiter().GetResult()
		Else
			Return Global.Xunit.Runner.InProc.SystemConsole.TestingPlatform.TestPlatformTestFramework.RunAsync(args, AddressOf SelfRegisteredExtensions.AddSelfRegisteredExtensions).GetAwaiter().GetResult()
		End If
	End Function
End Class
