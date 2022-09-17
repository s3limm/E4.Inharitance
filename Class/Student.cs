using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.İnharitance.Class
{
    internal class Student : User // student class'ının içerise user class'ının özelliklerini aktardık ve böylece kod kalabalığını önleyerek birden fazla class'ın içerisinde aynı özellikleri kullanabildik.
    {
        public string studentNumber { get; set; }
        public string classRoom { get; set; }

    }
}
