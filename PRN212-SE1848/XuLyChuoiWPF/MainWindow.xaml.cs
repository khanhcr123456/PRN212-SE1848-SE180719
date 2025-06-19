using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XuLyChuoiWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            KhoaControll(true);
        }
        void KhoaCtroll(bool b)
        {
            btnDemSoKTHoa.IsEnabled = !b;
            btnDenSoTu.IsEnabled = !b;
            btnInChuHoa.IsEnabled = !b;
            btnInNguyenAmPhuAm.IsEnabled = !b;
            btnInSoTuTrenMoiDong.IsEnabled = !b;
            btnDemSoKTThuong.IsEnabled = !b;
        }

        private void btnNhap_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}