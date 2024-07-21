using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using WPFQLVeXe.Models;
using WPFQLVeXe.ViewModel;

namespace WPFQLVeXe.View
{
    /// <summary>
    /// Interaction logic for QLPhanCong.xaml
    /// </summary>
    public partial class QLPhanCong : UserControl
    {
        public QLPhanCong()
        {
            InitializeComponent();
        }

        BanVeEntities db = new BanVeEntities();



        private ObservableCollection<NhanVien> getEmployee()
        {
            return new ObservableCollection<NhanVien>(db.NhanViens.Where(s => s.BiXoa == "0").ToList());
        }

        private ObservableCollection<TuyenXe> getTuyenXe()
        {
            return new ObservableCollection<TuyenXe>(db.TuyenXes.ToList());
        }

        private ObservableCollection<PhanCong> getPhanCong()
        {
            return new ObservableCollection<PhanCong>(db.PhanCongs.ToList());
        }

        private void dtgPX_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from s in db.NhanViens
                        where s.LoaiNv == "LNV004"
                        select s;
            ObservableCollection<NhanVien> phuxe = new ObservableCollection<NhanVien>(query.ToList());
            dtgPX.ItemsSource = phuxe;
        }

        private void dtgTuyenXePC_Loaded(object sender, RoutedEventArgs e)
        {
            dtgTuyenXePC.ItemsSource = getTuyenXe();
        }

        private void dtgTX_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from s in db.NhanViens
                        where s.LoaiNv == "LNV003"
                        select s;
            ObservableCollection<NhanVien> taixe = new ObservableCollection<NhanVien>(query.ToList());
            dtgTX.ItemsSource = taixe;
        }

        private void dtgPhanCong_Loaded(object sender, RoutedEventArgs e)
        {
            dtgPhanCong.ItemsSource = getPhanCong();
        }

        private void btnSave(object sender, RoutedEventArgs e)
        {
            if (dtgTX.SelectedItem == null
                || dtgPX.SelectedItem == null
                || dtgTuyenXePC.SelectedItem == null)
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                if (db.PhanCongs.Find(tbMaTXe.Text) == null)
                {
                    LichTrinh _ngay = db.LichTrinhs.Where(s => s.MaTuyen == tbMaTXe.Text).SingleOrDefault();
                    PhanCong _new = new PhanCong()
                    {
                        MaTuyen = tbMaTXe.Text,
                        MaNv = tbMaTX.Text,
                        MaPx = tbMaPX.Text,
                        NgayDi = _ngay.NgayDi,
                    };

                    db.PhanCongs.Add(_new);
                    db.SaveChanges();
                    MessageBox.Show("Phân công nhân viên thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    dtgPhanCong.ItemsSource = getPhanCong();
                }
                else
                    MessageBox.Show("Đã tồn tại phân công cho tuyến xe này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
        }

        private void btnDelete(object sender, RoutedEventArgs e)
        {
            dtgTX.SelectedItem = null;
            dtgPX.SelectedItem = null;
            dtgTuyenXePC.SelectedItem = null;
        }

        private void btnPX(object sender, RoutedEventArgs e)
        {
            dtgPX.SelectedItem = null;
        }

        private void btnTX(object sender, RoutedEventArgs e)
        {
            dtgTX.SelectedItem = null;
        }

        private void deletePhanCong(object sender, RoutedEventArgs e)
        {
            Button seleted = (Button)sender;
            var item = seleted.DataContext as PhanCong;
            var DeleteRecord = MessageBox.Show("Bạn có chắc chắn muốn xóa phân công của tuyến xe " + item.MaTuyen + " không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (DeleteRecord == MessageBoxResult.Yes)
            {
                db.PhanCongs.Remove(item);
                db.SaveChanges();
                dtgPhanCong.ItemsSource = getPhanCong();
            }
        }
    }
}
