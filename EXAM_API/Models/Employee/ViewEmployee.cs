using System.ComponentModel.DataAnnotations;

namespace EXAM_API.Models.Employee
{
    public class ViewEmployee
    {
        [Required]
        [StringLength(200)]
        public string name_employee { get; set; }
        [Required]
        public string rank { get; set; }
        [Required]
        [Display(Name = "Department_Tbl")]
        public int code_department { get; set; }
    }
}
