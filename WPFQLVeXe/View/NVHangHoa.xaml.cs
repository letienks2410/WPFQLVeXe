using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WPFQLVeXe.Models;

namespace WPFQLVeXe.View
{
    /// <summary>
    /// Interaction logic for NVHangHoa.xaml
    /// </summary>
    public partial class NVHangHoa : UserControl
    {
        public NVHangHoa()
        {
            InitializeComponent();
            chuyenHangLoaded();
        }
        BanVeEntities db = new BanVeEntities();

        private ObservableCollection<TuyenXe> getTuyenXe()
        {
            return new ObservableCollection<TuyenXe>(db.TuyenXes.ToList());
        }

        // check null
        private bool isNull()
        {
            foreach (UIElement c in grbReceiver.Children)
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    if (!String.IsNullOrEmpty(tb.Text))
                        return false;
                }

            foreach (UIElement c in grbSender.Children)
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    if (!String.IsNullOrEmpty(tb.Text))
                        return false;
                }

            foreach (UIElement c in grbHang.Children)
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    if (!String.IsNullOrEmpty(tb.Text))
                        return false;
                }

            return true;
        }

        // clear textbox
        private void tbClear()
        {
            foreach (UIElement c in grbReceiver.Children)
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    tb.Clear();
                }

            foreach (UIElement c in grbSender.Children)
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    tb.Clear();
                }

            foreach (UIElement c in grbHang.Children)
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    tb.Clear();
                }
            cbTuyenDi.Text = "";
        }

        // auto-generate customer
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

        // tạo khách hàng
        private void CreateCustomer(string id, string ten, string cmnd, string diachi, string sdt)
        {
            KhachHang _new = new KhachHang()
            {
                MaKh = id,
                TenKh = ten,
                Cmnd = cmnd,
                DiaChi = diachi,
                Sdt = sdt
            };

            db.KhachHangs.Add(_new);
            db.SaveChanges();
        }
        // tự động tạo id hàng hóa
        private string NewHangHoaID()
        {
            string nextID;
            string curID = db.HangHoas.OrderByDescending(p => p.MaHh)
                                       .Select(r => r.MaHh)
                                       .First().ToString();
            curID = curID.Remove(0, 2);
            int intID = Convert.ToInt32(curID);
            intID += 1;
            nextID = "HH" + intID.ToString();
            while (db.HangHoas.Find(nextID) != null)
            {
                intID += 1;
                nextID = "HH" + intID.ToString();
            }
            return nextID;
        }


        private void btnThanhToan(object sender, RoutedEventArgs e)
        {
            if (isNull())
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                var _newSenderID = NewCustomerID(); // lấy id mới
                CreateCustomer(_newSenderID, tbGui.Text, tbGuiCMND.Text, tbGuiDiaChi.Text, tbGuiSDT.Text);

                var _newReceiverID = NewCustomerID(); // lấy id mới
                CreateCustomer(_newReceiverID, tbNhan.Text, tbNhanCMND.Text, tbNhanDiaChi.Text, tbNhanSDT.Text);

                HangHoa _new = new HangHoa()
                {
                    MaHh = NewHangHoaID(),
                    LoaiHh = tbLoaiHang.Text,
                    KhoiLuong = Convert.ToSingle(tbKg.Text),
                    Phi = Convert.ToSingle(tbTong.Text),
                    NguoiGui = _newSenderID,
                    NguoiNhan = _newReceiverID,
                };

                var DeleteRecord = MessageBox.Show("Bạn có chắc chắn lập đơn chuyển hàng mới không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (DeleteRecord == MessageBoxResult.Yes)
                {
                    db.HangHoas.Add(_new);
                    db.SaveChanges();
                    tbClear();
                }

            }
        }

        private void btnRefresh(object sender, RoutedEventArgs e)
        {
            tbClear();
        }

        private void chuyenHangLoaded()
        {
            cbTuyenDi.ItemsSource = getTuyenXe();
            cbTuyenDi.DisplayMemberPath = "DiaDiemDi";
        }
    }
}
