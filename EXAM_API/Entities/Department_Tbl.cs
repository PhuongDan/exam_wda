using System.ComponentModel.DataAnnotations;

namespace EXAM_API.Entities
{
    public class Department_Tbl
    {
        [Key]
        public int code_department { get; set; }
        [Required]
        [StringLength(200)]
        public string name_department { get; set; }
        [Required]
        public string location { get; set; }
        [Required]
        public int number_of_personals { get; set; }
        public ICollection<Employee_Tbl> employees_Tbl { get; set; }
    }
}
