﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using WPFQLVeXe.ViewModel;

namespace WPFQLVeXe.View
{
    /// <summary>
    /// Interaction logic for ViewSwitcher.xaml
    /// </summary>
    public partial class ViewSwitcher : UserControl
    {
        public ViewSwitcher()
        {
            InitializeComponent();
            Switcher.viewSwitcher = this;

            /// Startup View
            Switcher.Switch(new Blank());
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public void Navigate(UserControl nextPage, object state)
        {
            this.Content = nextPage;
            ISwitchable s = nextPage as ISwitchable;

            if (s != null)
                s.UtilizeState(state);
            else
                throw new ArgumentException("NextPage is not ISwitchable!"
                  + nextPage.Name.ToString());
        }
    }
}
