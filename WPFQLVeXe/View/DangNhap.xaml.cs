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
using WPFQLVeXe.Models;

namespace WPFQLVeXe.View
{
    /// <summary>
    /// Interaction logic for DangNhap.xaml
    /// </summary>
    public partial class DangNhap : Window
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        BanVeEntities db = new BanVeEntities();

        // check textbox null
        private bool isNull()
        {
            if (!String.IsNullOrEmpty(tbUser.Text)
                && !String.IsNullOrEmpty(passwordBox.Password))
                return false;
            return true;
        }

        // drag window
        private new void MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        // check đăng nhập
        private void Check()
        {
            if (isNull())
                MessageBox.Show("Vui lòng nhập đầy đủ!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                // lấy user
                var user = db.TaiKhoans.Where(i => i.TenDn == tbUser.Text).FirstOrDefault();
                var _acc = user as TaiKhoan;
                if (_acc == null)
                    MessageBox.Show("Sai tên đăng nhập", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                else
                {
                    // check password
                    if (_acc.MatKhau == passwordBox.Password)
                    {
                        this.Hide();
                        if (_acc.LoaiTk == "1")
                            (new QuanLi()).Show();
                        else
                            (new Customer()).Show();
                    }
                    else
                        MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
        private void btnLogin(object sender, RoutedEventArgs e)
        {
            Check();
        }

        //thoát
        private void btnClose(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //nhấn enter
        private void EnterKey(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                Check();
                e.Handled = true;
            }
        }

        // checked remember me
        private void checkRemember_Checked(object sender, RoutedEventArgs e)
        {
            //Properties.Settings.Default.UserName = tbUser.Text;
            //Properties.Settings.Default.Password = passwordBox.Password;
            //Properties.Settings.Default.Save();
        }

        // load user id & pass
        private void userLoaded(object sender, RoutedEventArgs e)
        {
            //if (Properties.Settings.Default.UserName != string.Empty)
            //{
            //    tbUser.Text = Properties.Settings.Default.UserName;
            //    passwordBox.Password = Properties.Settings.Default.Password;
            //}
        }
    }
}
