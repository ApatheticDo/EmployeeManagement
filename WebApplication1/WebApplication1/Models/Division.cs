using System.ComponentModel.DataAnnotations;
using WebApplication1.Models;

namespace EmployeeManagement.Models
{
    public class Division
    {
        [Key]
        public int Divi_Id { get; set; }

        public String Divi_Name { get; set; }

        public String CreatedBy { get; set; }
        public String CreatedOn { get; set; }
        public String? UpdateBy { get; set; }
        public String? UpdateOn { get; set; }

        public ICollection<Department> Department { get; set; }

        public ICollection<Admin> Admin { get; set; }

        
    }
}
