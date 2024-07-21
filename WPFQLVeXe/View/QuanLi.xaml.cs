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
using System.Windows.Shapes;
using WPFQLVeXe.ViewModel;

namespace WPFQLVeXe.View
{
    /// <summary>
    /// Interaction logic for QuanLi.xaml
    /// </summary>
    public partial class QuanLi : Window
    {
        public QuanLi()
        {
            InitializeComponent();
        }
        private void btnNhanVien(object sender, RoutedEventArgs e)
        {
            //Switcher.Switch(new QLNhanVien());
        }

        private void btnPhanCong(object sender, RoutedEventArgs e)
        {
            //Switcher.Switch(new QLPhanCong());
        }

        private void btnThongKe(object sender, RoutedEventArgs e)
        {
            //Switcher.Switch(new QLThongKe());
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
