using System.Windows;

namespace WpfLab2
{
    /// <summary>
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void powrot(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
