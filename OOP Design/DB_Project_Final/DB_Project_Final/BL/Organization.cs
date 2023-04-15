using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Project_Final.BL
{
    public class Organization
    {
        private int id { get; set; }
        private string organizationName { get; set; }
        private string email { get; set; }
        private string address { get; set; }
        private int regionId { get; set; }
        private int walletId { get; set; }
        private int credentailId { get; set; }
    }
}
