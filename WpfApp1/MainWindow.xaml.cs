using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
namespace WpfApp1
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
    }
    private int osszekotoszam= 0;
    public interface OsszekotoSzam
    {
        get
   private void Window_Loaded(object sender,RoutedEventArgs)
    {
        DispatcherTime Idozito = new DispatcherTime();
            Idozito.Interval = TimeSpan.FromSeconds(1);
            Idozito.Tick += IdoLepes;
            Idozito.Start();
    }
        private int ido = 0;
        private void IdoLepes(object sender,EventArgs e)
        {
            ido++;
            IdoText.Text = 
        }
}
