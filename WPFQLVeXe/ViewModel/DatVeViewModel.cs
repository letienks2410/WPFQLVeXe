using System;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using WPFQLVeXe.Models;

namespace QuanLyVe.ViewModel
{
    public class DatVeViewModel
    {
        BanVeEntities db = new BanVeEntities();

        // tự động tạo mã khách hàng
        public string NewCustomerID()
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
        public string NewTicketID()
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
        public bool isNull(StackPanel stp)
        {
            foreach (UIElement c in stp.Children)
                if (c is TextBox)
                {
                    TextBox tb = c as TextBox;
                    if (!String.IsNullOrEmpty(tb.Text))
                        return false;
                }
            return true;
        }

        public void CreateCustomer(string id, string ten, string diachi, string cmnd, string sdt)
        {
            KhachHang _new = new KhachHang();
            _new.MaKh = id;
            _new.TenKh = ten;
            _new.DiaChi = diachi;
            _new.Cmnd = cmnd;
            _new.Sdt = sdt;

            db.KhachHangs.Add(_new);
            db.SaveChanges();
        }

        public void CreateTicket(string makh, string ghe, TimeOnly giodi, float giave, string soxe, DateOnly ngaydi)
        {
            string _newCustomerID = NewCustomerID();

            var _newTickerID = NewTicketID();
            // nếu id đã tồn tại thì tăng lên
            while (db.VeXes.Find(_newTickerID) != null)
            {
                _newTickerID += 1;
            }
            VeXe _newTicket = new VeXe();

            _newTicket.MaVe = _newTickerID;
            _newTicket.MaKh = makh;
            _newTicket.MaGhe = ghe;
            _newTicket.GioDi = giodi;
            _newTicket.GiaVe = giave;
            _newTicket.SoXe = soxe;
            _newTicket.NgayDi = ngaydi;
            _newTicket.NhanVienBv = "NV001";

            db.VeXes.Add(_newTicket); // tạo vé mới
            db.SaveChanges();
        }

        public ObservableCollection<LichTrinh> getLich(string ma)
        {
            // chọn lịch trình của tuyến đi
            var query = from b in db.LichTrinhs
                        where b.MaTuyen == ma
                        select b;
            return new ObservableCollection<LichTrinh>(query.ToList());
        }

        public List<string> getGhe(string soxe)
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
                        where b.SoXe == soxe
                        select b;

            // xóa ghế đã có trong xe
            foreach (VeXe i in query)
                _ghe.Remove(i.MaGhe);
            return new List<string>(_ghe.ToList());
        }
    }
}
