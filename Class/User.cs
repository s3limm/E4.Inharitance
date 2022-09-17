using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.İnharitance.Class
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public  string userName { get; set; }
        public string passWord { get; set; }
        public string  phoneNumber { get; set; }

        public void GetFullName()
        {
            System.Windows.Forms.MessageBox.Show($"{Name} {Surname}");
        }
    }
}
