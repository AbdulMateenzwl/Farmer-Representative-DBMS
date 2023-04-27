using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer_Representive_Final_Project_DB_.BL
{
    public class TransactionDetails
    {
        private int Id { get; set; }
        private int RecevierId { get; set; }
        private int SenderId { get; set; }
        private int Amount { get; set; }
        private int TransactionType { get; set; }
        private DateTime TimeStamp { get; set; }
    }
}
