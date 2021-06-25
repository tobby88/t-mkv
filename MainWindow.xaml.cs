using Microsoft.Win32;
using System.Windows;

namespace t_mkv
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Matroska|*.mkv;*.mk3d;*.mka;*.mks";
            if (openFileDialog.ShowDialog() == true)
            {
                boxPath.Text = openFileDialog.FileName;
            }
        }
    }
}
