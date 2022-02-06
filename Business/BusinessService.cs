using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BusinessService
    {
        public bool SaveCountry(Int32? countryID, string country)
        {
            bool response = false;
            try
            {
                DataService dataService = new DataService();
                response = dataService.SaveCountry(countryID, country);
            }
            catch (Exception)
            {
                response = false;
            }
            return response;
        }

        public List<CountryModel> GetCountries()
        {
            List<CountryModel> response = new List<CountryModel>();
            try
            {
                DataService dataService = new DataService();
                response = dataService.GetCountries();
            }
            catch (Exception)
            {
                response = new List<CountryModel>();
            }
            return response;
        }

        public bool DeleteCounty(int? countryID)
        {
            bool response = false;
            try
            {
                DataService dataService = new DataService();
                response = dataService.DeleteCounty(countryID);
            }
            catch (Exception)
            {
                response = false;
            }
            return response;
        }

        public bool SaveState(int? countryID, int? stateID, string state)
        {
            bool response = false;
            try
            {
                DataService dataService = new DataService();
                response = dataService.SaveState(countryID, stateID, state);
            }
            catch (Exception)
            {
                response = false;
            }
            return response;
        }

        public bool DeleteState(int? stateID)
        {
            bool response = false;
            try
            {
                DataService dataService = new DataService();
                response = dataService.DeleteState(stateID);
            }
            catch (Exception)
            {
                response = false;
            }
            return response;
        }

        public List<StateModel> GetStates(int countryID)
        {
            List<StateModel> response = new List<StateModel>();
            try
            {
                DataService dataService = new DataService();
                response = dataService.GetStates(countryID);
            }
            catch (Exception)
            {
                response = new List<StateModel>();
            }
            return response;
        }
    }
}
