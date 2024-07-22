using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.ObjectModel;
using WPFQLVeXe.Models;

namespace WPFQLVeXe.View
{
    /// <summary>
    /// Interaction logic for NVThongTinHangHoa.xaml
    /// </summary>
    public partial class NVThongTinHangHoa : UserControl
    {
        public NVThongTinHangHoa()
        {
            InitializeComponent();
        }

        BanVeEntities db = new BanVeEntities();
        private ObservableCollection<HangHoa> getHangHoa()
        {
            return new ObservableCollection<HangHoa>(db.HangHoas.ToList());
        }

        private void Search()
        {
            var search = from b in db.HangHoas
                         where b.MaHh.Contains(tbSearch.Text)
                         select b;
            ObservableCollection<HangHoa> data = new ObservableCollection<HangHoa>(search.ToList());
            dtgHang.ItemsSource = data;
        }

        private void ClearAll()
        {
            foreach (UIElement c in stpSender.Children)
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    tb.Clear();
                }

            foreach (UIElement c in stpReceiver.Children)
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    tb.Clear();
                }
        }

        private void setEnable()
        {
            foreach (UIElement c in stpSender.Children)
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    tb.IsReadOnly = false;
                }

            foreach (UIElement c in stpReceiver.Children)
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    tb.IsReadOnly = false;
                }
        }

        private void setReadOnly()
        {
            foreach (UIElement c in stpSender.Children)
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    tb.IsReadOnly = true;
                }

            foreach (UIElement c in stpReceiver.Children)
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    tb.IsReadOnly = true;
                }
        }

        private void btnSearch(object sender, RoutedEventArgs e)
        {
            Search();
        }

        private void btnClear(object sender, RoutedEventArgs e)
        {
            tbSearch.Clear();
            dtgHang.ItemsSource = getHangHoa();
        }

        private void EnterKey(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                Search();
                e.Handled = true;
            }
        }

        private void btnUpdate(object sender, RoutedEventArgs e)
        {
            if (dtgHang.SelectedItem == null)
                MessageBox.Show("Có chọn gì đâu mà sửa", "Thông báo", MessageBoxButton.OK, MessageBoxImage.None);
            else
            {
                var question = MessageBox.Show("Bạn muốn thay đổi thông tin khách hàng?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (question == MessageBoxResult.Yes)
                {
                    setEnable();
                }
            }
        }

        private void btnSave(object sender, RoutedEventArgs e)
        {
            if (dtgHang.SelectedItem == null)
                MessageBox.Show("Có chọn gì đâu mà lưu", "Thông báo", MessageBoxButton.OK, MessageBoxImage.None);
            else
            {
                var selected = dtgHang.SelectedItem as HangHoa;

                var question = MessageBox.Show("Lưu thông tin khách hàng?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (question == MessageBoxResult.Yes)
                {
                    KhachHang _sender = db.KhachHangs.Find(selected.NguoiGui);
                    // thay doi nguoi gui
                    _sender.TenKh = tbGui.Text;
                    _sender.Cmnd = tbGuiCMND.Text;
                    _sender.DiaChi = tbGuiDiaChi.Text;
                    _sender.Sdt = tbGuiSDT.Text;

                    db.SaveChanges();

                    //thay doi nguoi nhan
                    KhachHang _receiver = db.KhachHangs.Find(selected.NguoiGui);
                    // thay doi nguoi gui
                    _receiver.TenKh = tbNhan.Text;
                    _receiver.Cmnd = tbNhanCMND.Text;
                    _receiver.DiaChi = tbNhanDiaChi.Text;
                    _receiver.Sdt = tbNhanSDT.Text;

                    db.SaveChanges();
                    ClearAll();
                    setReadOnly();
                }
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dtgHang.ItemsSource = getHangHoa();
        }

        private void dtgHang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dtgHang.SelectedItem != null)
            {
                // lấy người nhận người gửi từ database
                var selected = dtgHang.SelectedItem as HangHoa;
                KhachHang _sender = db.KhachHangs.Where(s => s.MaKh == selected.NguoiGui).SingleOrDefault();
                KhachHang _receiver = db.KhachHangs.Where(s => s.MaKh == selected.NguoiNhan).SingleOrDefault();

                //binding
                tbGui.Text = _sender.TenKh;
                tbGuiCMND.Text = _sender.Cmnd;
                tbGuiDiaChi.Text = _sender.DiaChi;
                tbGuiSDT.Text = _sender.Sdt;

                tbNhan.Text = _receiver.TenKh;
                tbNhanCMND.Text = _receiver.Cmnd;
                tbNhanDiaChi.Text = _receiver.DiaChi;
                tbNhanSDT.Text = _receiver.Sdt;
            }
        }
    }
}
