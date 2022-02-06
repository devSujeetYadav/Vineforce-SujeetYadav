using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataService
    {
        public bool SaveCountry(Int32? countryID, string country)
        {
            bool response = false;
            try
            {
                using (VineforceTestDemoEntities db = new VineforceTestDemoEntities())
                {
                    Country data = new Country();
                    if(countryID == null || countryID == 0)
                    {
                        Country countryDetail = db.Countries.Where(x => x.CountryName == country).FirstOrDefault();
                        if(countryDetail == null) {
                            data.CountryName = country;
                            db.Countries.Add(data);
                            db.SaveChanges();
                        }
                    }
                    else if (countryID != null && countryID != 0)
                    {
                        Country countryDetail = db.Countries.Where(x => x.CountryID == countryID).FirstOrDefault();
                        countryDetail.CountryName = country;
                        db.SaveChanges();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                response = false;
            }
            return response;
        }

        public bool DeleteCounty(int? countryID)
        {
            bool response = false;
            try
            {
                using (VineforceTestDemoEntities db = new VineforceTestDemoEntities())
                {
                    Country countryDetail = db.Countries.Where(x => x.CountryID == countryID).FirstOrDefault();
                    if (countryDetail != null)
                    {
                        db.Countries.Remove(countryDetail);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
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
                using (VineforceTestDemoEntities db = new VineforceTestDemoEntities())
                {
                    State staetDetail = db.States.Where(x => x.StateID == stateID).FirstOrDefault();
                    if (staetDetail != null)
                    {
                        db.States.Remove(staetDetail);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
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
                using (VineforceTestDemoEntities db = new VineforceTestDemoEntities())
                {
                    List<State> countries = db.States.Where(x => x.CountryID == countryID).ToList();
                    foreach (var item in countries)
                    {
                        response.Add(
                            new StateModel { stateID = item.StateID, state = item.StateName }
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                response = new List<StateModel>();
            }
            return response;
        }

        public bool SaveState(int? countryID, int? stateID, string state)
        {
            bool response = false;
            try
            {
                using (VineforceTestDemoEntities db = new VineforceTestDemoEntities())
                {
                    State data = new State();
                    if (stateID == null || stateID == 0)
                    {
                        State stateDetail = db.States.Where(x => x.StateName == state).FirstOrDefault();
                        if (stateDetail == null)
                        {
                            data.CountryID = (Int32)countryID;
                            data.StateName = state;
                            db.States.Add(data);
                            db.SaveChanges();
                        }
                    }
                    else if (stateID != null && stateID != 0)
                    {
                        State stateDetail = db.States.Where(x => x.StateID == stateID).FirstOrDefault();
                        stateDetail.CountryID = (Int32)countryID;
                        stateDetail.StateName = state;
                        db.SaveChanges();
                    }

                }
            }
            catch (Exception ex)
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
                using (VineforceTestDemoEntities db = new VineforceTestDemoEntities())
                {
                    List<Country> countries = db.Countries.ToList();
                    foreach (var item in countries)
                    {
                        response.Add(
                            new CountryModel { countryID = item.CountryID, country = item.CountryName }
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                response = new List<CountryModel>();
            }
            return response;
        }
    }
}
