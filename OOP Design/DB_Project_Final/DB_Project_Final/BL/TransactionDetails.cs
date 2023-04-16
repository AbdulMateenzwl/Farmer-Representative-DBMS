using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Project_Final.BL
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
