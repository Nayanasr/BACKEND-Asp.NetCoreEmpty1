using Asp.NetCoreEmpty1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreEmpty1.Controllers
{
    public class HomeController : Controller
    {
        public IStudentRepository _studentRepository;

        public HomeController(IStudentRepository studentRepository) {
            _studentRepository = studentRepository;
        }

        public string Index() {
            return _studentRepository.GetStudent(2).email;
        }
        public IActionResult Student() {
            return View();


        }
    }
}