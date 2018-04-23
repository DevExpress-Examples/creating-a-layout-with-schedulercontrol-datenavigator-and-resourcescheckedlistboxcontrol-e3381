Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.XtraScheduler

Namespace SchedulerGridSplitterWpf
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()

			GenerateResources()
		End Sub

		Private Sub GenerateResources()
			schedulerControl1.Storage.ResourceStorage.BeginUpdate()
			schedulerControl1.Storage.ResourceStorage.Add(New Resource(0, "First Resource"))
			schedulerControl1.Storage.ResourceStorage.Add(New Resource(1, "Second Resource"))
			schedulerControl1.Storage.ResourceStorage.Add(New Resource(2, "Third Resource"))
			schedulerControl1.Storage.ResourceStorage.EndUpdate()
		End Sub
	End Class
End Namespace
