using System.Windows;

namespace MediaCurator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Tab_Click(object sender, RoutedEventArgs e)
        {
            string mode = TabPhoto.IsChecked == true ? "PHOTO" : "VIDEO";
            CounterText.Text = mode + " 0 / 0";
        }

        private void BtnSource_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Folder selection arrives in Phase 2.", "Media Curator");
        }
    }
}
