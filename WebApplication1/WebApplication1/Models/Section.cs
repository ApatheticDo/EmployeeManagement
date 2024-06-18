using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Models;

namespace EmployeeManagement.Models
{
    public class Section
    {
        [Key]
        public int Sec_id { get; set; }
        
        public String Sec_name { get; set; }

        [ForeignKey("Depa_id")]
        public Department Department { get; set; }
        public int Depa_id { get; set; }

        public String CreatedBy { get; set; }
        public String CreatedOn { get; set; }
        public String? UpdateBy { get; set; }
        public String? UpdateOn { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
