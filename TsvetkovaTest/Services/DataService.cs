using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsvetkovaTest.Models;

namespace TsvetkovaTest.Services
{
    public class DataService:IEmployeeService
    {
        static readonly ConcurrentDictionary<string, Employee> Stuff = new ConcurrentDictionary<string, Employee>();
        [Produces("application/json")]

        ///<summary>
        ///Добавление данных в коллекцию
        ///</summary>
        public async Task StartData()
        {
            

            Employee[] employeeData =
            {
                new Employee { ID = 0,Name = "Dasha", Department = "", Position = "President" },
                new Employee { ID = 1, ParentID = 0, Name = "Ilya", Department = "Marketing", Position = "Vice President" },
                new Employee{ID = 2, ParentID = 0, Name = "Vitaliy", Department = "Operations", Position = "Vice President" },
                new Employee{ID = 3, ParentID = 1, Name = "Mihail", Department = "Marketing", Position = "Manager"},
                new Employee{ID = 4, ParentID = 2, Name = "Dmitriy", Department = "Operations", Position = "Manager"}
            };
            // Add some key/value pairs from multiple threads.
            await Task.WhenAll(
                Task.Run(() => TryAddEmployee(employeeData)),
                Task.Run(() => TryAddEmployee(employeeData)));

            static void TryAddEmployee(Employee[] employees)
            {
                for (var i = 0; i < employees.Length; ++i)
                {
                    var (stuff, threadId) = (employees[i], Thread.CurrentThread.ManagedThreadId);
                   
                }
            }
            
        }

    }
}
