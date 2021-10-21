using System.Windows;

namespace WpfLab2
{
    /// <summary>
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public int cena=0;
        public int motz;

        public Window2(int cena)
        {
            InitializeComponent();
            this.cena = cena;
            label_cena.Content = cena + motz;
        }

        private void powrot(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


            private void diesel_checked(object sender, RoutedEventArgs e)
            {
                cena += 5000;
            label_cena.Content = cena + motz;
        }

            private void benzyna_checked(object sender, RoutedEventArgs e)
            {
                cena += 5000;
            label_cena.Content = cena + motz;
        }

            private void gaz_checked(object sender, RoutedEventArgs e)
            {
                cena += 4000;
            label_cena.Content = cena + motz;
        }

            private void hybryda_checked(object sender, RoutedEventArgs e)
{
                cena += 8000;
            label_cena.Content = cena + motz;
        }


        private void diesel_unchecked(object sender, RoutedEventArgs e)
        {
            cena -= 5000;
            label_cena.Content = cena + motz;
        }

        private void benzyna_unchecked(object sender, RoutedEventArgs e)
        {
            cena -= 5000;
            label_cena.Content = cena + motz;
        }

        private void gaz_unchecked(object sender, RoutedEventArgs e)
        {
            cena -= 4000;
            label_cena.Content = cena + motz;
        }

        private void hybryda_unchecked(object sender, RoutedEventArgs e)
        {
            cena -= 8000;
            label_cena.Content = cena + motz;
        }

        private void moc_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            motz = (moc.SelectedIndex+1)*1000;
            label_cena.Content = cena + motz;
        }
    }
}
