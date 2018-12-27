using NewsletterAppMVC.ViewModels;
using NewsletterAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities1 db = new NewsletterEntities1()) //entity framework
            {
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList(); //filters only non-unsubscribed signups
                var signups = (from c in db.SignUps
                               where c.Removed == null
                               select c).ToList(); //another way to filter results, using SQL-like syntax.
                var signupVms = new List<SignupVm>();
                foreach (var signup in signups)
                {
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }
                return View(signupVms);
            }
        }
        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                var signup = db.SignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
    //ADO.NET
    //string queryString = @"SELECT Id, FirstName, LastName, EmailAddress FROM SignUps";
    //List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    SqlCommand command = new SqlCommand(queryString, connection);

//    connection.Open();

//    SqlDataReader reader = command.ExecuteReader();

//    while (reader.Read())
//    {
//        var signup = new NewsletterSignUp();
//        signup.Id = Convert.ToInt32(reader["Id"]);
//        signup.FirstName = reader["FirstName"].ToString();
//        signup.LastName = reader["LastName"].ToString();
//        signup.EmailAddress = reader["EmailAddress"].ToString();
//        signups.Add(signup);
//    }
//}