using System.Windows;
using System.Windows.Controls;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WPFQLVeXe.Models;
using System;

namespace WPFQLVeXe.View
{
    /// <summary>
    /// Interaction logic for NVDatVe.xaml
    /// </summary>
    public partial class NVDatVe : UserControl
    {
        public NVDatVe()
        {
            InitializeComponent();
        }

        // load các table cho màn hình
        BanVeEntities db = new BanVeEntities();

        private ObservableCollection<TuyenXe> getTuyenXe()
        {
            return new ObservableCollection<TuyenXe>(db.TuyenXes.ToList());
        }

        private ObservableCollection<LichTrinh> getLichTrinh()
        {
            return new ObservableCollection<LichTrinh>(db.LichTrinhs.ToList());
        }

        private ObservableCollection<KhachHang> getKhachHang()
        {
            return new ObservableCollection<KhachHang>(db.KhachHangs.ToList());
        }

        // tự động tạo mã khách hàng
        private string NewCustomerID()
        {
            string nextID;
            string curID = db.KhachHangs.OrderByDescending(p => p.MaKh)
                                        .Select(r => r.MaKh)
                                        .First().ToString();
            curID = curID.Remove(0, 2);
            int intID = Convert.ToInt32(curID);
            intID += 1;
            nextID = "KH" + intID.ToString();
            return nextID;
        }

        // tự động tạo mã vé mới
        private string NewTicketID()
        {
            string nextID;
            string curID = db.VeXes.OrderByDescending(p => p.MaVe)
                                   .Select(r => r.MaVe)
                                   .First().ToString();
            curID = curID.Remove(0, 2);
            int intID = Convert.ToInt32(curID);
            intID += 1;
            nextID = "V0" + intID.ToString();
            return nextID;
        }

        // check textbox null
        private bool isNull()
        {
            if (!String.IsNullOrEmpty(tbTenKH.Text)
                && !String.IsNullOrEmpty(tbCMND.Text)
                && !String.IsNullOrEmpty(tbDiaChi.Text)
                && !String.IsNullOrEmpty(tbGiaVe.Text)
                && !String.IsNullOrEmpty(tbSDT.Text))
                return false;
            return true;
        }

        private void ClearAll()
        {
            cbTuyenDi.Text = "";
            cbNgayDi.Text = "";
            cbGhe.Text = "";
            tbGioDi.Clear();
            tbGioDen.Clear();
            tbGiaVe.Clear();
            tbDiemDen.Clear();
            tbDiaChi.Clear();
            tbCMND.Clear();
            tbMaTuyen.Clear();
            tbNgayDen.Clear();
            tbSDT.Clear();
            tbSoXe.Clear();
            tbTenKH.Clear();
        }

        // tạo khách hàng mới
        private void CreateCustomer(string id)
        {
            if (isNull())
            {
                MessageBox.Show("Không được để trống thông tin khách hàng!", "Thông báo!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                KhachHang _new = new KhachHang();
                _new.MaKh = id;
                _new.TenKh = tbTenKH.Text;
                _new.DiaChi = tbDiaChi.Text;
                _new.Cmnd = tbCMND.Text;
                _new.Sdt = tbSDT.Text;

                db.KhachHangs.Add(_new);
                db.SaveChanges();
            }
        }

        // load db tuyến đi
        private void LoadedDatVe(object sender, RoutedEventArgs e)
        {
            cbTuyenDi.ItemsSource = getTuyenXe();
            cbTuyenDi.DisplayMemberPath = "DiaDiemDi";
        }

        // combobox tuyến đi thay đổi
        private void cbTuyenDi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = cbTuyenDi.SelectedItem as TuyenXe;
            if (selected != null)
            {
                // chọn lịch trình của tuyến đi
                var query = from b in db.LichTrinhs
                            where b.MaTuyen == selected.MaTuyen
                            select b;

                // tạo danh sách để binding cho combobox ngày đi
                ObservableCollection<LichTrinh> data = new ObservableCollection<LichTrinh>(query.ToList());
                cbNgayDi.ItemsSource = data;
                cbNgayDi.DisplayMemberPath = "NgayDi";
            }
        }

        // Load danh sách vé chưa đăng kí
        private void btnLoad(object sender, RoutedEventArgs e)
        {
            // tạo ghế
            List<string> _ghe = new List<string>();
            for (int i = 0; i < 20; i++)
            {
                if (i < 9)
                    _ghe.Add("GH0" + (i + 1).ToString());
                else
                    _ghe.Add("GH" + (i + 1).ToString());
            }

            // chọn số xe 
            var query = from b in db.VeXes
                        where b.SoXe == tbSoXe.Text
                        select b;

            // xóa ghế đã có trong xe
            foreach (VeXe i in query)
                _ghe.Remove(i.MaGhe);

            // binding ghế lên combobox
            cbGhe.ItemsSource = _ghe.ToList();
        }

        // nút thanh toán
        private void btnThanhToan(object sender, RoutedEventArgs e)
        {
            if (isNull())
                MessageBox.Show("Không được để trống textbox nào!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                string _newCustomerID = NewCustomerID();

                VeXe _newTicket = new VeXe();
                TuyenXe _tuyenxe = cbTuyenDi.SelectedItem as TuyenXe;
                LichTrinh _lichtrinh = cbNgayDi.SelectedItem as LichTrinh;

                // show thông báo xác nhận
                var Confirm = MessageBox.Show("Thanh toán với số tiền là: " + tbGiaVe.Text, "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (Confirm == MessageBoxResult.Yes)
                {
                    CreateCustomer(_newCustomerID); // tạo khách hàng mới

                    var _newTickerID = NewTicketID();
                    // nếu id đã tồn tại thì tăng lên
                    while (db.VeXes.Find(_newTickerID) != null)
                    {
                        _newTickerID += 1;
                    }
                    _newTicket.MaVe = _newTickerID;
                    _newTicket.MaKh = _newCustomerID;
                    _newTicket.MaGhe = cbGhe.SelectedItem.ToString();
                    _newTicket.GioDi = _tuyenxe.GioDi;
                    _newTicket.GiaVe = Convert.ToInt32(tbGiaVe.Text);
                    _newTicket.SoXe = tbSoXe.Text;
                    _newTicket.NgayDi = _lichtrinh.NgayDi;
                    _newTicket.NhanVienBv = "NV001";

                    db.VeXes.Add(_newTicket); // tạo vé mới
                    db.SaveChanges();

                    MessageBox.Show("Đã thêm vé vào dữ liệu", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Đã hủy thanh toán", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ClearAll();
                }
            }
        }
    }
}
