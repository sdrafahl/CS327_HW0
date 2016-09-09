using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using FairOrderingSystem;

//http://stackoverflow.com/questions/878632/best-way-to-call-external-program-in-c-sharp-and-parse-output
//https://forum.teksyndicate.com/t/asp-net-mvc-text-box/106790/12
using System.Data;

namespace Fair.Controllers
{
	public class HomeController : Controller
	{

		public ActionResult Index ()
		{

			var mvcName = typeof(Controller).Assembly.GetName ();

			var isMono = Type.GetType ("Mono.Runtime") != null;

			ViewData ["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData ["Runtime"] = isMono ? "Mono" : ".NET";

			return View ();
		}

		public ActionResult NewUser(){
			return View ();
		}
		public ActionResult LoginS(){
			return View ();
		}

		[HttpPost]
		public ActionResult creatUser(FairOrderingSystem.Models.Company comp){
				if(ModelState.IsValid){
					string company = comp.companyName;
					string Cell = comp.cell;
					string Phone = comp.phone;
					string Password = comp.password;
					string Email = comp.email;

					string connectionString = 
						"Server=localhost;" +
						"Database=fair;" +
						"User ID=shane;" +
						"Password=Gaming12;" +
						"Pooling=false";
					string sqlCommand = "INSERT INTO COMPANIES VALUES ('" + company + "','" + Cell + "','" + Phone + "','" + Password + "',NULL,'" + Email + "');";
					MySqlConnection conn = new MySqlConnection (connectionString);
					conn.Open ();
					MySqlCommand comm = conn.CreateCommand ();
					comm.CommandText = sqlCommand;
					comm.BeginExecuteNonQuery ();
				return View ();
			}
			
			return View ("NewUser");
		}
		[HttpGet]
		public ActionResult creatUser(){
			FairOrderingSystem.Models.Company comp = new FairOrderingSystem.Models.Company ();
			return View (comp);
		}
	}
}
