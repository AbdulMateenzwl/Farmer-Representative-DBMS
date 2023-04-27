using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer_Representive_Final_Project_DB_.BL
{
    public class Farmer
    {
        private int Id { get; set; }
        private int Status { get; set; }
        private string Address { get; set; }
        private int ManagerId { get; set; }
        private int AccountType { get; set; }
    }
}
