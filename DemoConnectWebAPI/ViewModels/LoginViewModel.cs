using DemoConnectWebAPI.Models;
using DemoMVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConnectWebAPI.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        QLDTvXTEntities db = new QLDTvXTEntities();

        private User user = new User();

        public event PropertyChangedEventHandler PropertyChanged;

        public User Users
        {
            get { return user; }
            set
            {
                user = value;
                OnPropertyChanged("Users");
            }
        }

        public void OnPropertyChanged(string parameter)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(parameter));
            }
        }


        public LoginViewModel()
        {
            HOCSINH hs = db.HOCSINH.Single(n => n.MaHS == "xx");
            hs.DIEMMH.DiemSo = 5;
            hs.DIEMMH1.DiemSo = 6;

        }



        public void btnLogin(User user)
        {
                //if (Users != null)
                //{
                //    WindowManager wm = new WindowManager();
                //    if (Users.Email.Equals("Phat") && Users.Pass.Equals("kakaka"))
                //    {
                //        //WindowService s = new WindowService();
                //        //s.ShowWindow(new SinhVienViewModel());
                //        wm.ShowWindow(new SinhVienViewModel());
                //        this.TryClose();
                //    }
                //    else
                //    {
                //        wm.ShowDialog(new DialogYesNoViewModel("Email hoặc mật khẩu không đúng!!!!", "Thông Báo"));

                //    }
                //}
        }

    }
}
