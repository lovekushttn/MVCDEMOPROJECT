using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVCDEMO.Web.Models.Entity
{
    public class Department
    {
        public Guid Id { get; set;}
        [Required]
        public string DName { get; set; }
        [Required]
        [Display(Name="Department Name")]
        public string Name { get; set; }
        [Required]
        public Department_Type Type { get; set; }
        
        public bool Status { get; set; }
    }
}