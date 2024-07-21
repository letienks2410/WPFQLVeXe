using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using WPFQLVeXe.Models;
using System.Windows.Input;

namespace WPFQLVeXe.View
{
    /// <summary>
    /// Interaction logic for NVThongTinDatVe.xaml
    /// </summary>
    public partial class NVThongTinDatVe : UserControl
    {
        public NVThongTinDatVe()
        {
            InitializeComponent();
        }
        // Data Context
        BanVeEntities db = new BanVeEntities();
        
        private ObservableCollection<VeXe> getTickets()
        {
            return new ObservableCollection<VeXe>(db.VeXes.ToList());
        }

        // set tb khách hàng enable
        private void setEnable()
        {
            tbTen.IsReadOnly = false;
            tbCMND.IsReadOnly = false;
            tbDiaChi.IsReadOnly = false;
            tbSDT.IsReadOnly = false;
        }

        private void setMutable()
        {
            tbTen.IsReadOnly = true;
            tbCMND.IsReadOnly = true;
            tbDiaChi.IsReadOnly = true;
            tbSDT.IsReadOnly = true;
        }

        private void Search()
        {
            var search = from b in db.VeXes
                        where b.MaVe.Contains(tbSearch.Text)
                        select b;
            ObservableCollection<VeXe> data = new ObservableCollection<VeXe>(search.ToList());
            dtgVe.ItemsSource = data;
        }

        // nút search
        private void btnSearch(object sender, RoutedEventArgs e)
        {
            Search();
        }

        private void EnterKey(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                Search();
                e.Handled = true;
            }
        }

        // load data vé
        private void dtgVeLoaded(object sender, RoutedEventArgs e)
        {
            dtgVe.ItemsSource = getTickets();
        }

        // chọn vé
        private void dtgVe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dtgVe.SelectedItem != null)
            {
                // khởi tạo các biến
                VeXe _ticket = dtgVe.SelectedItem as VeXe;
                KhachHang _customer = db.KhachHangs.Find(_ticket.MaKh);
                LichTrinh _lichtrinh = db.LichTrinhs.Where(s => s.SoXe == _ticket.SoXe).SingleOrDefault();
                TuyenXe _tuyenxe = db.TuyenXes.Where(s => s.MaTuyen == _lichtrinh.MaTuyen).SingleOrDefault();

                // binding các textbox khách hàng
                tbTen.Text = _customer.TenKh;
                tbCMND.Text = _customer.Cmnd;
                tbDiaChi.Text = _customer.DiaChi;
                tbSDT.Text = _customer.Sdt;

                // binding các textbox thông tin
                tbGhe.Text = _ticket.MaGhe;
                tbGioDen.Text = _tuyenxe.GioDen.ToString();
                tbGioDi.Text = _tuyenxe.GioDi.ToString();
                tbMaTuyen.Text = _tuyenxe.MaTuyen;
                tbNgayDen.Text = _lichtrinh.NgayDen.ToShortDateString();
                tbNgayDi.Text = _lichtrinh.NgayDi.ToShortDateString();
                tbTuyenDen.Text = _tuyenxe.DiaDiemDen;
                tbTuyenDi.Text = _tuyenxe.DiaDiemDi;
            }
        }

        private void btnUpdate(object sender, RoutedEventArgs e)
        {
            if (dtgVe.SelectedItem == null)
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
            if (dtgVe.SelectedItem == null)
                MessageBox.Show("Có chọn gì đâu mà lưu", "Thông báo", MessageBoxButton.OK, MessageBoxImage.None);
            else
            {
                setMutable();
                var selected = dtgVe.SelectedItem as VeXe;

                var question = MessageBox.Show("Lưu thông tin khách hàng?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (question == MessageBoxResult.Yes)
                {
                    KhachHang _customer = db.KhachHangs.Find(selected.MaKh);

                    _customer.TenKh = tbTen.Text;
                    _customer.Cmnd = tbCMND.Text;
                    _customer.DiaChi = tbDiaChi.Text;
                    _customer.Sdt = tbSDT.Text;

                    db.SaveChanges();
                }
            }
        }

        private void btnClear(object sender, RoutedEventArgs e)
        {
            tbSearch.Clear();
            dtgVe.ItemsSource = getTickets();
        }
    }
}
