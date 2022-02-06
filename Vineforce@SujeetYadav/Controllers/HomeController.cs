using Business;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vineforce_SujeetYadav.Controllers
{
    public class HomeController : Controller
    {
        BusinessService businessService = new BusinessService();
        public ActionResult Index()
        {
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
        // Country Page
        public ActionResult Country()
        {
            ViewBag.Message = "Country";

            return View();
        }
        /// <summary>
        /// Save Country
        /// </summary>
        /// <param name="countryID"></param>
        /// <param name="country"></param>
        /// <returns></returns>
        public bool SaveCountry(Int32? countryID, string country)
        {
            
            bool IsSaved = businessService.SaveCountry(countryID, country);
            return IsSaved;
        }
        /// <summary>
        /// Get All countries
        /// </summary>
        /// <returns></returns>
        public JsonResult GetCountries()
        {
            List<CountryModel> data = businessService.GetCountries();
            return Json(data);
        }
        /// <summary>
        /// Delete Country
        /// </summary>
        /// <param name="countryID"></param>
        /// <returns></returns>
        public bool DeleteCounty(Int32? countryID)
        {

            bool IsDeleted = businessService.DeleteCounty(countryID);
            return IsDeleted;
        }
        /// <summary>
        /// State Page
        /// </summary>
        /// <returns></returns>
        public ActionResult State()
        {
            ViewBag.Message = "State";

            return View();
        }
        /// <summary>
        /// Save State
        /// </summary>
        /// <param name="countryID"></param>
        /// <param name="stateID"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public bool SaveState(Int32? countryID, Int32? stateID, string state)
        {

            bool IsSaved = businessService.SaveState(countryID, stateID, state);
            return IsSaved;
        }

        public JsonResult GetStates(Int32 countryID)
        {
            List<StateModel> data = businessService.GetStates(countryID);
            return Json(data);
        }
        public bool DeleteState(Int32? stateID)
        {

            bool IsDeleted = businessService.DeleteState(stateID);
            return IsDeleted;
        }

    }
}