using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonBeaty.Models
{
    class Genders
    {
    
            public int id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string patronymic { get; set; }
            public DateTime birthday { get; set; }
            public DateTime registrationDate { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public string genderCode { get; set; }
            public object photoPath { get; set; }

        

    }
}
