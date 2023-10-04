using EXAM_API.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using EXAM_API.Entities;
using EXAM_API.Models.Department;

namespace EXAM_API.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DataContext _context;

        public DepartmentController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Departments_Tbl = _context.Departments_Tbl.ToList();
          
            return View(Departments_Tbl);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ViewDepartment model)
        {
            if (ModelState.IsValid) //validate
            {
                _context.Departments_Tbl.Add(new Department_Tbl { name_department = model.name_department, location = model.location,number_of_personals = model.number_of_personals });
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task<IActionResult> Edit(int id)
        {
            Department_Tbl department_Tbl = await _context.Departments_Tbl.FindAsync(id);
            if (department_Tbl == null)
            {
                return NotFound();
            }
            return View(new EditDepartment { code_department = department_Tbl.code_department, name_department = department_Tbl.name_department,location = department_Tbl.location,number_of_personals = department_Tbl.number_of_personals });
        }
        [HttpPost]
        public IActionResult Edit(EditDepartment model)
        {
            if (ModelState.IsValid)
            {
                _context.Departments_Tbl.Update(new Department_Tbl { name_department = model.name_department, location = model.location, number_of_personals = model.number_of_personals });
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            Department_Tbl department_Tbl = _context.Departments_Tbl.Find(id);
            if (department_Tbl == null)
            {
                return NotFound();
            }
            _context.Departments_Tbl.Remove(department_Tbl);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

