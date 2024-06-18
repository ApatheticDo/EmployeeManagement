using System.ComponentModel.DataAnnotations;
namespace EmployeeManagement.ViewModel

{
    public class LoginViewModel
    {
        [Required]
        public string Admin_Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //[Display(Name = "Remember Me")]
        //public bool RememberMe { get; set; }
    }
}