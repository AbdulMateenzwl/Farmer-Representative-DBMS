using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Project_Final.BL
{
    public class Product
    {
        private int id { get; set; }
        private string name { get; set; }
        private int quality { get; set; }
        private int unitPrice { get; set; }
        private int categoryId { get; set; }
        private int status { get; set; }
        private int remainingUnits { get; set; }
        private int managerId { get; set; }

    }
}
