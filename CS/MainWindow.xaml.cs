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
            schedulerControl1.Storage.ResourceStorage.Add(new Resource(0, "First Resource"));
            schedulerControl1.Storage.ResourceStorage.Add(new Resource(1, "Second Resource"));
            schedulerControl1.Storage.ResourceStorage.Add(new Resource(2, "Third Resource"));
            schedulerControl1.Storage.ResourceStorage.EndUpdate();
        }
    }
}
