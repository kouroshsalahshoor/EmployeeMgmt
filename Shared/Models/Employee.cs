namespace Shared.Models
{
    public class Employee : BaseEntity
    {
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
