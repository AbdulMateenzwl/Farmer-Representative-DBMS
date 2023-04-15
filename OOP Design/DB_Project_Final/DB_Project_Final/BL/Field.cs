using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Project_Final.BL
{
    public class Field
    {
       private int id { get; set; }
       private int farmerId { get; set; }
       private int regionId { get; set; }
       private string location { get; set; }
       private int status { get; set; }
       private string managerId { get; set; }
    }
}
