﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreDemo.ViewModels
{
    public class CartViewModel : BaseSearchDepartmentsViewModel
    {
        public List<ProductInCartViewModel> Products { get; set; }
    }
}