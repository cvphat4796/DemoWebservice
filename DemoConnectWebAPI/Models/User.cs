using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.Models
{
    public class User
    {
        private string email;
        private string pass;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
    }
}
