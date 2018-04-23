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
            For i As Integer = 0 To 2
                Dim resource As Resource = schedulerControl1.Storage.CreateResource(i)
                resource.Caption = "Resource" & i
                schedulerControl1.Storage.ResourceStorage.Add(resource)
            Next i
            schedulerControl1.Storage.ResourceStorage.EndUpdate()
        End Sub
    End Class
End Namespace
