using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CountryModel
    {
        public CountryModel()
        {
            countryID = 0;
            country = string.Empty;
        }
        public Int32? countryID { get; set; }
        public string country { get; set; }
    }
}
