using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Models;

namespace EmployeeManagement.Models
{
    public class Admin
    {
        [Key]
        public int Admin_Id { get; set; }
        public String Admin_Name { get; set; }
        public String Password { get; set; }

        [ForeignKey("Divi_Id")]
        public Division Division { get; set; }
        public int Divi_Id { get; set; }
        
        

        public String CreatedBy { get; set; }
        public String CreatedOn { get; set; }
        public String? UpdateBy { get; set; }
        public String? UpdateOn { get; set; }
    }
}
