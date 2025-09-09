

namespace HR_Management.Core.Entities
{
    public class Company
    {
         public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Industry { get; set; } = string.Empty;

    
    public List<Department> Departments { get; set; } = new List<Department>();
}










    
}
