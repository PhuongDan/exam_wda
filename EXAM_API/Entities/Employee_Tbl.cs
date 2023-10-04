using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EXAM_API.Entities
{
    public class Employee_Tbl
    {

        [Key]
        public string code_employee { get; set; }
        [Required]
        [StringLength(200)]
        public string name_employee { get; set; }
        [Required]
        public string rank { get; set; }

        public int code_department { get; set; }

        [ForeignKey("code_department")]
        public Department_Tbl department_Tbl { get; set; }

    }
}
