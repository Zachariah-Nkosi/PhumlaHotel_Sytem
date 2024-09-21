using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phumla_kamnandi_83
{
    public class Guest : Person
    {
        #region Constructor
        public Guest(string id, string firstName, string address, string phoneNumber)
        : base(id, firstName, address, phoneNumber)
        {
        }
        #endregion
    }
}

