using System.Windows;
using System.Windows.Controls;
using System.Linq;
using System.Collections.ObjectModel;
using WPFQLVeXe.Models;
using System;
using System.Windows.Input;
using Microsoft.EntityFrameworkCore;

namespace QuanLyVe.View
{
    /// <summary>
    /// Interaction logic for QLNhanVien.xaml
    /// </summary>
    public partial class QLNhanVien : UserControl
    {
        public QLNhanVien()
        {
            InitializeComponent();
        }

        BanVeEntities db = new BanVeEntities();

        private ObservableCollection<NhanVien> getEmployee()
        {
            return new ObservableCollection<NhanVien>(
    db.NhanViens
      .Where(w => w.BiXoa == "0")
      .Include(lnv => lnv.LoaiNvNavigation)
      .ToList()
);
        }
        private ObservableCollection<LoaiNhanVien> getLoaiNV()
        {
            return new ObservableCollection<LoaiNhanVien>(db.LoaiNhanViens.ToList());
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dtgNhanVien.ItemsSource = getEmployee();

            cbLoaiNV.ItemsSource = getLoaiNV();
            cbLoaiNV.DisplayMemberPath = "TenLoai";
        }

        private void Search()
        {
            var search = from b in db.NhanViens
                         where b.TenNv.Contains(tbSearch.Text)
                         select b;
            ObservableCollection<NhanVien> data = new ObservableCollection<NhanVien>(search.ToList());
            dtgNhanVien.ItemsSource = data;
        }

        private void btnSearch(object sender, RoutedEventArgs e)
        {
            Search();
        }

        private void btnClear(object sender, RoutedEventArgs e)
        {
            tbSearch.Clear();
            dtgNhanVien.ItemsSource = getEmployee();
        }

        private void EnterKey(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                Search();
                e.Handled = true;
            }
        }

        private bool isNull()
        {
            foreach (UIElement c in stpNV.Children)
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    if (!String.IsNullOrEmpty(tb.Text))
                        return false;
                }
            return true;
        }

        private void setEnable()
        {
            foreach (UIElement c in stpNV.Children)
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    tb.IsReadOnly = false;
                }
        }

        private void setMutable()
        {
            foreach (UIElement c in stpNV.Children)
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    tb.IsReadOnly = true;
                }
        }

        private void clearAll()
        {
            foreach (UIElement c in stpNV.Children)
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    tb.Clear();
                }
        }

        private void btnAdd(object sender, RoutedEventArgs e)
        {
            dtgNhanVien.SelectedItem = null;
            clearAll();
            setEnable();
            dtgNhanVien.IsEnabled = false;
        }

        private void btnUpdate(object sender, RoutedEventArgs e)
        {
            if (dtgNhanVien.SelectedItem != null)
                setEnable();
            else
                MessageBox.Show("Chọn gì đâu mà sửa", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            tbMaNV.IsReadOnly = true;
        }

        private void btnSave(object sender, RoutedEventArgs e)
        {
            if (isNull())
                MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                if (dtgNhanVien.IsEnabled == false)
                {
                    if (db.NhanViens.Find(tbMaNV.Text) == null)
                    {
                        NhanVien _new = new NhanVien()
                        {
                            MaNv = tbMaNV.Text,
                            TenNv = tbTenNv.Text,
                            NgaySinh = dpNgaySinh.SelectedDate.Value.Date,
                            Cmnd = tbCMND.Text,
                            DiaChi = tbDiaChi.Text,
                            Sdt = tbSDT.Text,
                            LoaiNvNavigation = cbLoaiNV.SelectedValue as LoaiNhanVien,
                            BiXoa = "0"
                        };

                        db.NhanViens.Add(_new);
                        db.SaveChanges();

                        MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        dtgNhanVien.ItemsSource = getEmployee();
                        dtgNhanVien.IsEnabled = true;
                        clearAll();
                        setMutable();
                    }
                    else
                        MessageBox.Show("Không được nhập trùng mã nhân viên", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    if (dtgNhanVien.SelectedItem == null)
                        MessageBox.Show("Chọn gì đâu mà lưu", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    else
                    {
                        NhanVien _edit = db.NhanViens.Find(tbMaNV.Text);

                        _edit.TenNv = tbTenNv.Text;
                        _edit.NgaySinh = dpNgaySinh.SelectedDate.Value.Date;
                        _edit.Cmnd = tbCMND.Text;
                        _edit.DiaChi = tbDiaChi.Text;
                        _edit.Sdt = tbSDT.Text;
                        _edit.LoaiNvNavigation = cbLoaiNV.SelectedValue as LoaiNhanVien;

                        db.SaveChanges();
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }
        }


        private void deleteCustomer(object sender, RoutedEventArgs e)
        {
            Button seleted = (Button)sender;
            var item = seleted.DataContext as NhanVien;
            var DeleteRecord = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên " + item.TenNv + " không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (DeleteRecord == MessageBoxResult.Yes)
            {
                //db.NhanVien.Remove(item);
                item.BiXoa = "1";
                db.SaveChanges();
                dtgNhanVien.ItemsSource = getEmployee();
            }
        }
    }
}
