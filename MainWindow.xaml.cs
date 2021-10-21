using System.Windows;
using System.Windows.Media;

namespace WpfLab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //       public static int price { get; set;}

        public int cena=0;
        public MainWindow()
        {
            InitializeComponent();
            label_cena.Content = this.cena;
        }

        private bool kolow1=false;
        private bool kolow2=false;

        private void koloczek()
        {
            if (kolow1 == true && kolow2 == true)
            {
                label_cena.Background = Brushes.Green;
            }

            else if (kolow1 == true || kolow2 == true)
            {
                label_cena.Background = Brushes.Yellow;
            }

            else
            {
                label_cena.Background = Brushes.Red;
            }
        }

        private void markabaton(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1(cena);
            w1.ShowDialog();
            cena = w1.cena + w1.poli_int;
            label_cena.Content = cena;

            if(cena != 0)
            {
                kolow1 = true;
            }
            koloczek();
        }

        private void silnikbaton(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2(cena);
            w2.ShowDialog();
            cena = w2.cena + w2.motz;
            label_cena.Content = cena;

            if (cena != 0)
            {
                kolow2 = true;
            }
            koloczek();
        }
    }
}
