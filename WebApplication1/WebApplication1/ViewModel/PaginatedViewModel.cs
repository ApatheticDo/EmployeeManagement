using WebApplication1.Models;

namespace EmployeeManagement.ViewModel
{
    public class PaginatedViewModel
    {
        public List<Employee> Items { get; set; }
        public int PageIndex { get; set; }

        public int TotalItems { get; set; }

        public int PageSize { get; set; }

        public int totalPages => (int)Math.Ceiling((double)TotalItems / PageSize);

    }
}
