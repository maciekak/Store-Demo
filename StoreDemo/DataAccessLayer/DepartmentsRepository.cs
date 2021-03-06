﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StoreDemo.BussinessLogic;
using StoreDemo.ViewModels;

namespace StoreDemo.DataAccessLayer
{
    public class DepartmentsRepository
    {
        private readonly StoreDbContext _storeDb = new StoreDbContext();

        public BaseSearchDepartmentsViewModel GetDepartmentsViewModel()
        {
            return new BaseSearchDepartmentsViewModel
            {
                DepartmentsNames = _storeDb.Departments.Select(d => d.Name).ToList()
            };
        }

        public string GetDepartmentNameById(int departmentId)
        {
            return _storeDb
                .Departments
                .First(d => d.Id == departmentId)
                .Name;
        }

        public List<string> GetDepartmentsNames()
        {
            return _storeDb
                .Departments
                .Select(d => d.Name)
                .ToList();
        }

        public List<NameWithId> GetDepartmentsNamesIds()
        {
            return _storeDb
                .Departments
                .Select(d => new NameWithId
                {
                    Id = d.Id,
                    Name = d.Name
                }).ToList();
        }
    }
}