using DemoMVVM.Models;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace DemoConnectWebAPI.Views
{
    /// <summary>
    /// Interaction logic for SinhVien.xaml
    /// </summary>
    public partial class SinhVien : Window
    {
        public SinhVien()
        {
            InitializeComponent();

            ListSinhVien.ItemsSource = "api/sinhviens/all".GetListModel<DemoMVVM.Models.SinhVien>().Result;



         }
    }
}
