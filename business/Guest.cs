using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phumla_kamnandi_83
{
    public class Guest : Person
    {
        #region Data Fields
        private string kinName;
        private string kinPhone;
        private string card;
        #endregion

        #region Property Methods
        public string KinName
        {
            get { return kinName; }
            set { kinName = value; }
        }
        public string KinPhone
        {
            get { return kinPhone; }
            set { kinPhone = value; }
        }
        public string Card
        {
            get { return card; }
            set { card = value; }
        }
        #endregion
        #region Constructor
        public Guest(string id, string firstName, string address, string phoneNumber, string kinName, string kinPhone, string card)
        : base(id, firstName, address, phoneNumber)
        {
            KinName = kinName;
            KinPhone = kinPhone;
            Card = card;

        }

        public Guest() : base()      //default constr
        {
            kinName = "";
            kinPhone = "";
            card = string.Empty;
        }
        #endregion
    }
}

