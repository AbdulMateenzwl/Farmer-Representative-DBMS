using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Project_Final.BL
{
    public class Order
    {
        private int Id { get; set; }
        private int ProductId { get; set; }
        private int Qunatity { get; set; }
        private int RequestedPrice { get; set; }
        private int Status { get; set; }
        private int OrganizationId { get; set; }
        private DateTime OrderDate { get; set; }
        private int ManagerId { get; set; }
    }
}
