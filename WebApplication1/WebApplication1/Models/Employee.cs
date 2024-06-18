using EmployeeManagement.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Employee 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String FullName { get; set; }

        public int Sec_id { get; set; }
        [ForeignKey("Sec_id"), Required]
        public Section Section { get; set; }

        public int Edu_Id { get; set; }
        [ForeignKey("Edu_Id")]
        public Education Education { get; set; }


        public String Sex { get; set; }
        [Required]
        public String Dob { get; set; }

        public String CreatedBy { get; set; }
        public String CreatedOn { get; set; }
        public String? UpdateBy { get; set; }
        public String? UpdateOn { get; set; }

    }
}
