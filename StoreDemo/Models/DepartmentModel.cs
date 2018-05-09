﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreDemo.Models
{
    public class DepartmentModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public virtual ICollection<CategoryModel> Categories { get; set; }
    }
}