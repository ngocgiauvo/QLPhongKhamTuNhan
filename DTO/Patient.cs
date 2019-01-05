using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongKhamTuNhan.DTO
{
    public class Patient
    {
        public int id { get; set; }
        public string name { get; set; }
        public int sex { get; set; }
        public int yob { get; set; }
        public string address { get; set; }
        public DateTime date_exam { get; set; }
        public string is_delete { get; set; }
    }
}
