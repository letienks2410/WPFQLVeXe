using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WPFQLVeXe.View;

namespace WPFQLVeXe.ViewModel
{
    public static class Switcher
    {
        public static ViewSwitcher viewSwitcher;

        public static void Switch(UserControl newPage)
        {
            viewSwitcher.Navigate(newPage);
        }
    }
}
