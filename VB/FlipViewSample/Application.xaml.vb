﻿Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows
Imports DevExpress.Xpf.Core

Namespace FlipViewSample
	''' <summary>
	''' Interaction logic for App.xaml
	''' </summary>
	Partial Public Class App
		Inherits Application

		Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
			ThemeManager.ApplicationThemeName = Theme.Office2013Name
			MyBase.OnStartup(e)
		End Sub
	End Class
End Namespace
