using System.Text.Json.Serialization;

namespace Shared.Models
{
    public class Department : BaseEntity
    {
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }
    }
}
