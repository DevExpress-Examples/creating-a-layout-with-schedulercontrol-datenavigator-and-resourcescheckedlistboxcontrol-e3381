using System.Windows;
using DevExpress.XtraScheduler;

namespace SchedulerGridSplitterWpf {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            GenerateResources();
        }

        private void GenerateResources() {
            schedulerControl1.Storage.ResourceStorage.BeginUpdate();
            for (int i = 0; i < 3; i++)
            {
                Resource resource = schedulerControl1.Storage.CreateResource(i);
                resource.Caption = "Resource" + i;
                schedulerControl1.Storage.ResourceStorage.Add(resource);
            }
            schedulerControl1.Storage.ResourceStorage.EndUpdate();
        }
    }
}
