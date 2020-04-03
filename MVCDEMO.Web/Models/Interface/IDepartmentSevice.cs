using MVCDEMO.Web.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDEMO.Web.Models.Interface
{
    public interface IDepartmentSevice
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartment(Guid id);
        void Save(Department department);
    }
}