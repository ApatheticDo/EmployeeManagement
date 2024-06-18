
using EmployeeManagement.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Text.Json;
using WebApplication1.Models;
using System.Linq;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly EmployeeMngDbContext _context;

        public HomeController(EmployeeMngDbContext context)
        {
            _context = context;
        }

        

        public IActionResult Index()
        {

            // Lấy thông báo từ TempData nếu có
            string errorMessage = TempData["ErrorMessage"] as string;
            // Pass thông báo vào ViewData để hiển thị trên trang Index
            ViewData["ErrorMessage"] = errorMessage;

            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        public  IActionResult Manage(int? divisionId, int? departId, int? secId)
        {

            var admin = HttpContext.Session.GetString("user");

            if (admin != null)
            {
                if (divisionId == null && departId == null && secId == null)
                {
                    var divi = _context.Divisions.ToList();
                    ViewBag.Divisions = divi;
                    return View("Manage");
                }
                else
                {                  
                    ViewBag.message = "Dữ liệu đang có vấn đề";
                    return View("Manage");
                }
            }
            else
            {
                var error = new ErrorViewModel()
                {
                    RequestId = "Bạn không có quyền truy cập vào trang này"
                };
                return View("Error", error);
            }
        }

        public IActionResult LoadTable(int? divisionId, int? departId, int? secId, int? PageIndex, int? PageSize)
        {

            var admin = HttpContext.Session.GetString("user");
            List<Employee> emp = null;
            int pageIndex = PageIndex ?? 1;
            int pageSize = PageSize ?? 2;

            if (admin != null)
            {
                if (divisionId == null && departId == null && secId == null)
                {

                     emp = _context.Employees.Include(e => e.Education).Include(e => e.Section).OrderBy(e => e.Id).ToList();

                }
                else if (secId != null)
                {

                     emp = _context.Employees.Include(e => e.Education).Include(e => e.Section).Where(e => e.Sec_id == secId).ToList();

                }
                else if (secId == null && departId != null)
                {
                     emp = _context.Employees
                   .Include(e => e.Education)
                   .Include(e => e.Section)
                   .Where(e => e.Section.Depa_id == departId).ToList();
                    ViewBag.Employees = emp;

                    
                }
                else if (departId == null && divisionId != null)
                {
                     emp = _context.Employees
                  .Include(e => e.Education)
                    .Include(e => e.Section)
                    .ThenInclude(s => s.Department)
                    .Where(e => e.Section.Department.Divi_Id == divisionId).ToList();
                    ViewBag.Employees = emp;
                }
                else
                {
                    var error = new ErrorViewModel()
                    {
                        RequestId = "Dữ liệu sai lệch hãy thử lại"
                    };
                    return PartialView("Error", error);
                }
                var pageData = emp.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
 
                var model = new PaginatedViewModel
                {
                    Items = pageData,
                    PageIndex = pageIndex,
                    PageSize = pageSize,
                    TotalItems = emp.Count()

                };

                return PartialView("DataTable", model);
            }
            else
            {
                    var error = new ErrorViewModel()
                {
                    RequestId = "Bạn không có quyền truy cập vào trang này"
                };
                return PartialView("Error", error);
            }
        }


        public IActionResult GetDepartments(int divisionId)
        {
            var departments = _context.Departments
                .Where(d => d.Divi_Id == divisionId)
                .ToList();

            return Json(departments);
        }

        public IActionResult GetSections(int departmentId)
        {
            var sections = _context.Sections
                .Where(s => s.Depa_id == departmentId)
                .ToList();

            return Json(sections);
        }

        //public IActionResult GetEmployees(int? sectionId, int? departmentId, int? divisionId)
        //{
        //    List<Employee> emp = null;
           
        //    if (sectionId != null)
        //    {
        //         emp = _context.Employees.Where(e => e.Sec_id == sectionId).ToList();

        //    }
        //    else if (sectionId == null && departmentId != null)
        //    {
        //         emp = _context.Employees
        //        .Include(e => e.Section)
        //        .Where(e => e.Section.Depa_id == departmentId).ToList();
        //    }
        //    else if (departmentId == null && divisionId != null)
        //    {
        //         emp = _context.Employees
        //        .Include(e => e.Section)
        //        .ThenInclude(s => s.Department)
        //        .Where(e => e.Section.Department.Divi_Id == divisionId).ToList();
        //    }
        //    return Json(emp);           
        //}

        public IActionResult AddEmployee()
        {
           
            ViewBag.Sections = _context.Sections.ToList().Select(s => new SelectListItem()
            {
                Text = s.Sec_name,
                Value = s.Sec_id.ToString()
            });
            ViewBag.Educations = _context.Educations.ToList().Select(s => new SelectListItem()
            {
                Text = s.Name,
                Value = s.Edu_Id.ToString()
            });

            return View("AddEmployee");
        }

        public IActionResult EditEmployee(int id = 0)
        {
            var find = _context.Employees.Find(id);
            var empModel = new EmployeeViewModel();
            empModel.Id = find.Id;
            empModel.FullName = find.FullName;
            empModel.Dob = find.Dob;
            empModel.Sec_id = find.Sec_id;
            empModel.Edu_Id = find.Edu_Id;
            empModel.Sex = find.Sex; 

            ViewBag.Sections = _context.Sections.ToList().Select(s => new SelectListItem()
            {
                Text = s.Sec_name,
                Value = s.Sec_id.ToString(),
                Selected = s.Sec_id == empModel.Sec_id
            });
            ViewBag.Educations = _context.Educations.ToList().Select(s => new SelectListItem()
            {
                Text = s.Name,
                Value = s.Edu_Id.ToString(),
                Selected = s.Edu_Id == empModel.Edu_Id
            });
            var sexList = _context.Employees.Select(e => e.Sex).Distinct().ToList();
            ViewBag.Sex = new SelectList(sexList, empModel.Sex); 

            return View("UpdateEmp", empModel);
        }



        public IActionResult UpdateEmp(EmployeeViewModel employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var find = _context.Employees.Find(employee.Id);

                    if (find != null)
                    {
                        find.FullName = employee.FullName;
                        find.Sec_id = employee.Sec_id;
                        find.Edu_Id = employee.Edu_Id;
                        find.Sex = employee.Sex;
                        find.Dob = employee.Dob;
                        find.UpdateBy = employee.UpdateBy;
                        find.UpdateOn = DateTime.Now.ToString();
                        _context.Employees.Update(find);
                        _context.SaveChanges();
                        TempData["Message"] = "Update successful!";
                    }
                    else
                    {
                        TempData["Message"] = "Employee not found!";
                    }

                    return RedirectToAction("Manage", "Home");
                }
                else
                {
                    TempData["Message"] = "Unsuccessful! Invalid information.";
                    return RedirectToAction("EditEmployee", "Home", new { id = employee.Id });
                }
            }
            catch (Exception ex)
            {
                TempData["Message"] = "An error occurred while updating the employee: " + ex.Message;
                return RedirectToAction("EditEmployee", "Home", new { id = employee.Id });
            }
        }



        [HttpPost]
        public IActionResult NewEmployee(EmployeeViewModel employee)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    var newEmp = new Employee();
                    newEmp.FullName = employee.FullName;
                    newEmp.Sec_id = employee.Sec_id;
                    newEmp.Edu_Id = employee.Edu_Id;
                    newEmp.Sex = employee.Sex;
                    newEmp.Dob = employee.Dob;
                    newEmp.CreatedBy = employee.CreatedBy;
                    newEmp.CreatedOn = DateTime.Now.ToString();
                    newEmp.UpdateBy = employee.CreatedBy;
                    newEmp.UpdateOn = DateTime.Now.ToString();

                    _context.Employees.Add(newEmp);
                    _context.SaveChanges();
                    ViewBag.Message = "Add successfull ! ";

                    return RedirectToAction("Manage", "Home");
                }
                else
                {
                    ViewBag.ErrorMessage = "Unsuccessfull !! Invalid Information ";

                    return RedirectToAction("AddEmployee", "Home");
                }
            }
            catch (Exception ex)
            {

                ViewBag.ErrorMessage = "An error occurred while adding the employee: " + ex.Message;
                return View("AddEmployee", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction("Manage", "Home");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
