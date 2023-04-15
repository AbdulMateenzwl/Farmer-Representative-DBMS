using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Project_Final.BL
{
    public class Delivery
    {
        private int Id { get; set; }
        private int VehicleId { get; set; }
        private int DeliveryType { get; set; }
        private int SourceId { get; set; }
        private int DestinationId { get; set; }
        private int ProductId { get; set; }
        private int CurrentStatus { get; set; }
        private int ManagerId { get; set; }
    }
}
