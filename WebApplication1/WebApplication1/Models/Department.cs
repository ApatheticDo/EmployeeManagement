using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Models;

namespace EmployeeManagement.Models
{
    public class Department
    {
        [Key]
        
        public int Depa_id { get; set; }
        
        public String Depa_name { get; set; }


        [ForeignKey("Divi_Id")]
        public Division Division { get; set; }
        public int Divi_Id { get; set; }

        public String CreatedBy { get; set; }
        public String CreatedOn { get; set; }
        public String? UpdateBy { get; set; }
        public String? UpdateOn { get; set; }
        public ICollection<Section> Section { get; set; }

        
    }
}
