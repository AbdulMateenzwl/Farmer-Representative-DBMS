using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Project_Final.BL
{
    public class Delivery
    {
        private int id { get; set; }
        private int vehicleId { get; set; }
        private int deliveryType { get; set; }
        private int sourceId { get; set; }
        private int destinationId { get; set; }
        private int productId { get; set; }
        private int currentStatus { get; set; }
        private int managerId { get; set; }
    }
}
