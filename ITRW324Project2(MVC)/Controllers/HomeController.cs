using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using ITRW324Project2_MVC_.Models;

namespace ITRW324Project2_MVC_.Controllers
{
    public class HomeController : Controller
    {
        private ITRW324Project2Context _context;

        public HomeController(ITRW324Project2Context context)
        {
            _context = context;
        }
        public IActionResult DBExampleView() //Return User Table in DB to DBExampleView
        {
            var result = _context.User.ToList();
            return View(result);
        }

        public List<MultipleTablesJoinData> GetDataByRunningStoredProcedureOrDirectSqlQuery()
        {
            _context.Database.SetCommandTimeout(280);
            var result = _context.User.ToList();
            return _context.MultipleTablesJoinData.FromSql("Complex Query").ToList();

        }

        public IActionResult Privacy() //Retrun Privacy View
        {
            return View();
        }

        public IActionResult Rates() //Retrun Rates View
        {
            return View();
        }

        public IActionResult Booking() //Return Booking View
        {
            return View();
        }

        public IActionResult Index() //Return Index View
        {
            return View();
        }

        public IActionResult AboutUs() //Return About Us View
        {
            return View();
        }

        public IActionResult ContactUs() //Return Contact Us View
        {
            return View();
        }

        public IActionResult Rules() //Return Rules View
        {
            return View();
        }

        public IActionResult LogIn() //Return TEMP LogIn View
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    public static class StringExtensions
    {
        public static string TrimLastSepratorString(this string s, char seprator)
        {
            if (s == null)
                return null;

            string newString = string.Empty;

            string[] arrOrigionalString = s.Split(seprator);

            for (int i = 0; i < arrOrigionalString.Length - 1; i++)
            {
                if (string.IsNullOrEmpty(newString))
                    newString = arrOrigionalString[i];
                else
                    newString = string.Concat(newString, "_", arrOrigionalString[i]);

            }
            return newString;
        }
    }
}
