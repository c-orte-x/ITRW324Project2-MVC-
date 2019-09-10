using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Final.Models;


namespace Final.Controllers
{
    
    public class HomeController : Controller
    {
        private ITRW324Project2Context _context;

        public HomeController(ITRW324Project2Context context)
        {
            _context = context;
        }


        public IActionResult Privacy() //Retrun Privacy View
        {
            return View();
        }

        public IActionResult Booking() //Return Booking View
        {
            var result = _context.Booking.ToList();
            return View(result);
        }

        public IActionResult Rates() //Retrun Rates View
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

        public IActionResult Index() //Return Index View
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        public IActionResult ExecuteDataTableSqlDA(string fromDate, string toDate, string bookingBy, string userId, string courtNr) //Method for writing to database
        {
            MySqlConnection con;
            MySqlDataAdapter dbAdapter;
            string connectionString;
            connectionString = "Server=den1.mysql6.gear.host;Database=ITRW324Project2;Uid=itrw324project2;Pwd=Hr0T3_Bxx-rj;"; //Connection string
            con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("insert_new_booking", con); //insert_new_booking is a stored procedure in the database
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uBookingFrom", Convert.ToDateTime(fromDate));
            cmd.Parameters.AddWithValue("@uBookingUntil", Convert.ToDateTime(toDate));
            cmd.Parameters.AddWithValue("@uBookingMadeBy", bookingBy);
            cmd.Parameters.AddWithValue("@uUserId", Convert.ToInt32(userId));
            cmd.Parameters.AddWithValue("@uCourtNr", Convert.ToInt32(courtNr));
            dbAdapter = new MySqlDataAdapter();
            dbAdapter.SelectCommand = cmd;
            DataSet DS = new DataSet();
            dbAdapter.Fill(DS);
            con.Close();

            return View("Index"); //Returns the view to the main page
        }

        public int BtnClickedOn() //Method for writing to database
        {
            return 1;
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
