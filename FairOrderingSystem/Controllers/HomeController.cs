using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Diagnostics;
//http://stackoverflow.com/questions/878632/best-way-to-call-external-program-in-c-sharp-and-parse-output
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
		public void creatUser(){

			//string company = Request.Form ["company"];
			string company = "Iowa State";
			string cell = "6414";
			string phone = "641521";
			string password = "test";
			string email = "iowa@isu.edu";
			Process p = new Process ();
			p.StartInfo.FileName = "/home/shanedrafahl/project/Iowa_State_Fair_OrderingSystem/CppMiddleMan/cppsql";
			p.StartInfo.Arguments = "0 " + phone + " 0 " + company + " " + cell + " " + password + " " + email;
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.RedirectStandardOutput = true;
			p.Start();
			p.WaitForExit ();
		}
	}
}
