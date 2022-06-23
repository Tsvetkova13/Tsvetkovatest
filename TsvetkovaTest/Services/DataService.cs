using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsvetkovaTest.Models;

namespace TsvetkovaTest.Services
{
    public class DataService
    {
        [Produces("application/json")]
        public DataInput DataInput()
        {
            DataInput Employee = new DataInput();


            Employee.dataInput = new List<Data>();
            Employee.dataInput.Add(new Data() { ID = 0, Name = "Dasha", Department = "", Position = "President" });
            Employee.dataInput.Add(new Data() { ID = 1, ParentID = 0, Name = "Ilya", Department = "Marketing", Position = "Vice President" });
            Employee.dataInput.Add(new Data() { ID = 2, ParentID = 0, Name = "Vitaliy", Department = "Operations", Position = "Vice President" });
            Employee.dataInput.Add(new Data() { ID = 3, ParentID = 1, Name = "Mihail", Department = "Marketing", Position = "Manager" });
            Employee.dataInput.Add(new Data() { ID = 4, ParentID = 2, Name = "Dmitriy", Department = "Operations", Position = "Manager" });

            return Employee;

        }
    }
}
