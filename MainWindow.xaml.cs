using System.Windows;

namespace Smile
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Smile w = new Smile();
            w.Show();
        }
    }
}
