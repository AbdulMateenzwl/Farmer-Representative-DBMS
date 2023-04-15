using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Project_Final.BL
{
    public class TransactionDetails
    {
        private int id { get; set; }
        private int recevierId { get; set; }
        private int senderId { get; set; }
        private int amount { get; set; }
        private int transactionType { get; set; }
        private DateTime timeStamp { get; set; }
    }
}
