using System.Windows;

namespace WpfLab2
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public int cena=0;
        public int poli_int;

        public Window1(int cena)
        {
            InitializeComponent();
            this.cena = cena;
            label_cena.Content = cena + poli_int;
        }

        private void powrot(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void polis_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!int.TryParse(polis.Text, out poli_int))
            {
                poli_int = 0;
            }
            label_cena.Content = cena + poli_int;
        }

        private void fer_check(object sender, RoutedEventArgs e)
        {
            cena += 100000;
            label_cena.Content = cena + poli_int;
        }
        private void koe_check(object sender, RoutedEventArgs e)
        {
            cena += 500000;
            label_cena.Content = cena + poli_int;
        }
        private void toy_check(object sender, RoutedEventArgs e)
        {
            cena += 15000;
            label_cena.Content = cena + poli_int;
        }


        private void fer_uncheck(object sender, RoutedEventArgs e)
        {
            cena -= 100000;
            label_cena.Content = cena + poli_int;
        }
        private void koe_uncheck(object sender, RoutedEventArgs e)
        {
            cena -= 500000;
            label_cena.Content = cena + poli_int;
        }
        private void toy_uncheck(object sender, RoutedEventArgs e)
        {
            cena -= 15000;
            label_cena.Content = cena + poli_int;
        }


        private void rad_check(object sender, RoutedEventArgs e)
        {
            cena += 100;
            label_cena.Content = cena + poli_int;
        }
        private void ogr_check(object sender, RoutedEventArgs e)
        {
            cena += 500;
            label_cena.Content = cena + poli_int;
        }
        private void uch_check(object sender, RoutedEventArgs e)
        {
            cena += 20;
            label_cena.Content = cena + poli_int;
        }
        private void ply_check(object sender, RoutedEventArgs e)
        {
            cena += 2137;
            label_cena.Content = cena + poli_int;
        }
        private void nit_check(object sender, RoutedEventArgs e)
        {
            cena += 1700;
            label_cena.Content = cena + poli_int;
        }



        private void rad_uncheck(object sender, RoutedEventArgs e)
        {
            cena -= 100;
            label_cena.Content = cena + poli_int;
        }
        private void ogr_uncheck(object sender, RoutedEventArgs e)
        {
            cena -= 500;
            label_cena.Content = cena + poli_int;
        }
        private void uch_uncheck(object sender, RoutedEventArgs e)
        {
            cena -= 20;
            label_cena.Content = cena + poli_int;
        }
        private void ply_uncheck(object sender, RoutedEventArgs e)
        {
            cena -= 2137;
            label_cena.Content = cena + poli_int;
        }
        private void nit_uncheck(object sender, RoutedEventArgs e)
        {
            cena -= 1700;
            label_cena.Content = cena + poli_int;
        }

    }
}
