using MVCDEMO.Web.Models.Entity;
using MVCDEMO.Web.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDEMO.Web.Models.Service
{
    public class DepartmentSevice: IDepartmentSevice
    {
        readonly IEnumerable<Department> Departments;
        public DepartmentSevice()
        {
            Departments = new List<Department>
            {
                 new Department{ Id = Guid.NewGuid(), Name = "IT", Type = Department_Type.HOD
                   },
                new Department{ Id = Guid.NewGuid(), Name = "Admin", Type = Department_Type.Faculty},
               new Department{ Id = Guid.NewGuid(), Name = "Admin2", Type = Department_Type.Student}
            };
        }

        public Department GetDepartment(Guid id)
        {
            return Departments.FirstOrDefault(x => x.Id == id);
        }

    

        public IEnumerable<Department> GetDepartments()
        {
            return Departments;
        }

        public void Save(Department department)
        {
            throw new NotImplementedException();
        }

        protected virtual void Delete(int empId)
        {

        }
    }
}