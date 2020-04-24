using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace mydbaspapp.Controllers
{
    public class HomeController : Controller
    {
        static string sqlconn = ConfigurationManager.AppSettings["SQlconnection2"];
        public ActionResult Index()
        {
            SqlConnection sconn = new SqlConnection(sqlconn);
            SqlCommand sc = new SqlCommand("select * from userauth");
            DataTable dataTable = new DataTable();
            sc.Connection = sconn;
            SqlDataAdapter da = new SqlDataAdapter(sc);
            da.Fill(dataTable);

            ViewData["read"] = dataTable.Rows.Count.ToString();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}