using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace WPFQLVeXe.View
{
    /// <summary>
    /// Interaction logic for Customer.xaml
    /// </summary>
    public partial class Customer : Window
    {
        public Customer()
        {
            InitializeComponent();
        }
        private void btnDatVe(object sender, RoutedEventArgs e)
        {
            //txbContent.Text = "Đặt vé";
            //Switcher.Switch(new NVDatVe());
        }

        private void btnHangHoa(object sender, RoutedEventArgs e)
        {
            //txbContent.Text = "Chuyển hàng";
            //Switcher.Switch(new NVHangHoa());
        }

        private void btnThongTinDatVe(object sender, RoutedEventArgs e)
        {
            //txbContent.Text = "Thông tin vé";
            //Switcher.Switch(new NVThongTinDatVe());
        }

        private void btnThongTinHangHoa(object sender, RoutedEventArgs e)
        {
            //txbContent.Text = "Thông tin hàng hóa";
            //Switcher.Switch(new NVThongTinHangHoa());
        }

        private void btnInfo(object sender, RoutedEventArgs e)
        {

        }
        private void btnLogOut(object sender, RoutedEventArgs e)
        {
            this.Close();
            (new DangNhap()).Show();
        }

        private void btnClose(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private new void MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}
