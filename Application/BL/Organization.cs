﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer_Representive_Final_Project_DB_.BL
{
    public class Organization
    {
        private int Id { get; set; }
        private string OrganizationName { get; set; }
        private string Email { get; set; }
        private string Address { get; set; }
        private int RegionId { get; set; }
        private int WalletId { get; set; }
        private int CredentailId { get; set; }
    }
}