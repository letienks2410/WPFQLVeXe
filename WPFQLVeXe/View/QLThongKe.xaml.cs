using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;
using QuanLyVe.ViewModel;

namespace QuanLyVe.View
{
    /// <summary>
    /// Interaction logic for QLThongKe.xaml
    /// </summary>
    public partial class QLThongKe : UserControl
    {
        public QLThongKe()
        {
            InitializeComponent();
        }

        ViewModelBase vmbase = new ViewModelBase();
        ThongKeViewModel vm = new ThongKeViewModel();


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbYear.SelectedItem != null)
            {
                ComboBoxItem typeItem = (ComboBoxItem)cbYear.SelectedItem;
                string value = typeItem.Content.ToString();
                int t = Convert.ToInt32(value);

                dtgThongKe.ItemsSource = vm.getYear(t);
            }
        }

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            dtgThongKe.ItemsSource = vmbase.getEmployee();
        }
    }
}
