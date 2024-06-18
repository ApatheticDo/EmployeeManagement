using EmployeeManagement.Models;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Education
    {
        [Key]
        public int Edu_Id { get; set; }

        public String Name { get; set; }


        public ICollection<Employee> Employee { get; set; }
    }
}
