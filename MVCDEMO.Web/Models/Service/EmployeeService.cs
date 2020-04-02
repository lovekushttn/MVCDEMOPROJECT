using MVCDEMO.Web.Models.Entity;
using MVCDEMO.Web.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDEMO.Web.Models.Service
{
    public class EmployeeService : IEmployeeService
    {
        readonly IEnumerable<Employee> employees;
        public EmployeeService()
        {
            employees = new List<Employee>
            {
                 new Employee{ Id = 1, FirstName = "Aman" , LastName = "Gupta"
                   },
                new Employee{ Id = 2, FirstName = "Syam" , LastName = "Gupta"
                   },
                new Employee{ Id = 3, FirstName = "Daman" , LastName = "Gupta"
                   },
                new Employee{ Id = 4, FirstName = "Lovekush" , LastName = "Gupta"
                   },
                new Employee{ Id = 5, FirstName = "Ashi" , LastName = "Gupta"
                    },
                new Employee{ Id = 6, FirstName = "Mohan" , LastName = "Gupta"
                    }
            };
        }

        public Employee GetEmployee(int id)
        {
            return employees.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return employees;
        }
        protected  virtual void Delete(int empId)
        {
            
        }
    }
}