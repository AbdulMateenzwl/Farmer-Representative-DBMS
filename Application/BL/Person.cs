using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer_Representive_Final_Project_DB_.BL
{
    public class Person
    {
        private int Id { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string PhoneNo { get; set; }
        private int CNIC { get; set; }
        private string Email { get; set; }
        private int RegionId { get; set; }
        private DateTime RegistrationDate { get; set; }
        private int Gender { get; set; }
        private int WalletId { get; set; }
        private int CredentialId { get; set; }

    }
}

