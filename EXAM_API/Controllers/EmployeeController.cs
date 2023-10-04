﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EXAM_API.Entities;
using EXAM_API.Models.Employee;

namespace EXAM_API.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly DataContext _context;

        public EmployeeController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Employee_Tbl> employees_Tbl = _context.Employees_Tbl


                .ToList();
            return View(employees_Tbl);
        }
        public IActionResult Create()
        {
            List<Department_Tbl> departments_Tbl = _context.Departments_Tbl.ToList();

            var selectDepartments_Tbl = new List<SelectListItem>();
            foreach (var d in departments_Tbl)
            {
                selectDepartments_Tbl.Add(new SelectListItem { Text = d.name_department, Value = d.code_department.ToString() });
            }
            ViewBag.categories = selectDepartments_Tbl;




            return View();
        }
    }





}
