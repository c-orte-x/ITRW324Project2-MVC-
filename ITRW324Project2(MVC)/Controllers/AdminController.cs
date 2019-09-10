using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Final.Models;
using Final.Views;
using Final;
using Final.Data.Migrations;
using MySql.Data.MySqlClient;
using System.Data;

namespace Final.Controllers
{

    
    
    public class AdminController : Controller
    {
    private ITRW324Project2Context _context;
        public AdminController(ITRW324Project2Context context)
        {
            _context = context;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            
            var result = _context.Booking.ToList();
            return View(result);
        }
       
    }
}