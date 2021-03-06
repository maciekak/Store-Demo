﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreDemo.ViewModels
{
    public class ClientContactViewModel : BaseSearchDepartmentsViewModel
    {
        public int QuantityOfProducts { get; set; }
        public decimal PriceForAllProducts { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string AdditionalInformation { get; set; }
    }
}