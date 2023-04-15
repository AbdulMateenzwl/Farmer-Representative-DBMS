using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Project_Final.BL
{
    public class Order
    {
        private int id { get; set; }
        private int productId { get; set; }
        private int qunatity { get; set; }
        private int requestedPrice { get; set; }
        private int status { get; set; }
        private int organizationId { get; set; }
        private DateTime orderDate { get; set; }
        private int managerId { get; set; }
    }
}
