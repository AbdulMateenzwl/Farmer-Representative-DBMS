using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Project_Final.BL
{
    public class Vehicle
    {
       private int Id { get; set; }
       private int DriverId { get; set; }
       private int RegistrationNo { get; set; }
       private DateTime RegistraionDate { get; set; }
       private int VehicleStatus { get; set; }
       private int ManagerId { get; set; }
    }
}
