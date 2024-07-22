using System.Collections.ObjectModel;
using System.Linq;
using WPFQLVeXe.Models;

namespace QuanLyVe.ViewModel
{
    public class ViewModelBase
    {
        BanVeEntities db = new BanVeEntities();

        public ObservableCollection<NhanVien> getEmployee()
        {
            //return new ObservableCollection<NhanVien>(db.NhanVien.ToList());
            return new ObservableCollection<NhanVien>(db.NhanViens.Where(w => w.BiXoa == "0").ToList());
        }

        public ObservableCollection<VeXe> getTickets()
        {
            return new ObservableCollection<VeXe>(db.VeXes.ToList());
        }

        public ObservableCollection<KhachHang> getCustomers()
        {
            return new ObservableCollection<KhachHang>(db.KhachHangs.ToList());
        }

        public ObservableCollection<HangHoa> getWare()
        {
            return new ObservableCollection<HangHoa>(db.HangHoas.ToList());
        }

        public ObservableCollection<TuyenXe> getTuyenXe()
        {
            return new ObservableCollection<TuyenXe>(db.TuyenXes.ToList());
        }

        public ObservableCollection<LichTrinh> getLichTrinh()
        {
            return new ObservableCollection<LichTrinh>(db.LichTrinhs.ToList());
        }

        public ObservableCollection<PhanCong> getPhanCong()
        {
            return new ObservableCollection<PhanCong>(db.PhanCongs.ToList());
        }

    }
}
