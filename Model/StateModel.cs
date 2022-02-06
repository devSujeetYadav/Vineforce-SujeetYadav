using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StateModel
    {
        public StateModel()
        {
            countryID = 0;
            stateID = 0;
            state = string.Empty;
        }
        public Int32? countryID { get; set; }
        public Int32? stateID { get; set; }
        public string state { get; set; }
    }
}
