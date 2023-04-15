using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Project_Final.BL
{
    public class Person
    {
        private  int Id { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string phoneNo { get; set; }
        private int CNIC { get; set; }
        private string email { get; set; }
        private int regionId { get; set; }
        private DateTime registrationDate { get; set; }
        private int gender { get; set; }
        private int walletId { get; set; }
        private int credentialId { get; set; }

    }
}
