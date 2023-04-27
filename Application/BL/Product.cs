using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer_Representive_Final_Project_DB_.BL
{
    public class Product
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private int Quality { get; set; }
        private int UnitPrice { get; set; }
        private int CategoryId { get; set; }
        private int Status { get; set; }
        private int RemainingUnits { get; set; }
        private int ManagerId { get; set; }

    }
}
