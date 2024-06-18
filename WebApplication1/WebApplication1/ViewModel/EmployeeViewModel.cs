using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Models;

namespace EmployeeManagement.ViewModel
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        [Required]
        public String FullName { get; set; }

        [Required]
        public int Sec_id { get; set; }

        public int Edu_Id { get; set; }

        public String Sex { get; set; }
        public String Dob { get; set; }

        public String CreatedBy { get; set; }
        public String CreatedOn { get; set; }
        public String UpdateBy { get; set; }
        public String UpdateOn { get; set; }
    }
}
