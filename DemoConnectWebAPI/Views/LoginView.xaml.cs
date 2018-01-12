using DemoConnectWebAPI.ViewModels;
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
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Email.Text.Equals("Phat") && Pass.Text.Equals("kakaka"))
            {
                //WindowService s = new WindowService();
                //s.ShowWindow(new SinhVienViewModel());
                SinhVien sv = new SinhVien();
                sv.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lỗi đăng nhập");
            }
        }
    }
}
