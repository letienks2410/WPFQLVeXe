using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using WPFQLVeXe.Models;

namespace WPFQLVeXe.ViewModel
{
    public class ThongKeViewModel
    {
        BanVeEntities db = new BanVeEntities();
        public ObservableCollection<VeXe> getYear(int year)
        {
            var query = from s in db.VeXes
                        where s.NgayDi.Value.Year == year
                        select s;
            return new ObservableCollection<VeXe>(query.ToList());
        }
    }
}
