using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcmeAutoInsurance.Controllers
{
    public class QuoteController : Controller
    {
        // GET: Quote
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Apply(string firstName, string lastName, string emailAddress,
                                 string dateOfBirth, string carYear, string carMake, string carModel,
                                 string dui, string tickets, string coverage, string total)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) ||
                string.IsNullOrEmpty(dateOfBirth) || string.IsNullOrEmpty(carYear) || string.IsNullOrEmpty(carMake) ||
                string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(dui) || string.IsNullOrEmpty(tickets) || string.IsNullOrEmpty(coverage))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (AcmeAutoInsuranceEntities db = new AcmeAutoInsuranceEntities())
                {
                    var quote = new Applicant();
                    quote.FirstName = firstName;
                    quote.LastName = lastName;
                    quote.EmailAddress = emailAddress;
                    quote.BirthDate = dateOfBirth;
                    quote.CarYear = carYear;
                    quote.CarMake = carMake;
                    quote.CarModel = carModel;
                    quote.Dui = dui;
                    quote.Tickets = tickets;
                    quote.Coverage = coverage;
                    quote.Total = getTotal(dateOfBirth, carYear, carMake, carModel, dui, tickets, coverage);

                    db.Applicants.Add(quote);
                    db.SaveChanges();

                    ViewData["quote.Total"] = quote.Total;
                    return View("Index");
                }
            }
        }

        public string getTotal(string dateOfBirth, string carYear, string carMake, string carModel,
                                  string dui, string tickets, string coverage)
        {
            using (AcmeAutoInsuranceEntities data = new AcmeAutoInsuranceEntities())
            {
                decimal totalQuote = 50.00m;

                //calculating quote based on age
                totalQuote = (DateTime.Now.Year - (Convert.ToDateTime(dateOfBirth)).Year < 25) ? totalQuote + 25 : totalQuote;
                totalQuote = (DateTime.Now.Year - (Convert.ToDateTime(dateOfBirth)).Year < 18) ? totalQuote + 100 : totalQuote;
                totalQuote = (DateTime.Now.Year - (Convert.ToDateTime(dateOfBirth)).Year > 100) ? totalQuote + 25 : totalQuote;

                //calculating quote based on car specs
                totalQuote = (Convert.ToInt32(carYear) < 2000) ? totalQuote + 25 : totalQuote;
                totalQuote = (Convert.ToInt32(carYear) > 2015) ? totalQuote + 25 : totalQuote;
                totalQuote = (carMake.ToLower() == "porsche") ? totalQuote + 25 : totalQuote;
                totalQuote = (carModel.ToLower() == "911 carrera") ? totalQuote + 25 : totalQuote;

                //calculating tickets/duis
                totalQuote = totalQuote + (Convert.ToInt32(tickets) * 10);
                totalQuote = (dui.ToLower() == "yes") ? (totalQuote + (totalQuote / 4)) : totalQuote;

                //coverage
                totalQuote = (coverage.ToLower() == "full") ? (totalQuote + (totalQuote / 2)) : totalQuote;

                return Convert.ToString(totalQuote);
            }
        }
    }
}