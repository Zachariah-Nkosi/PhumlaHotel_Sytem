using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phumla_kamnandi_83
{
    public abstract class Person     // Base Class
    {
        #region data fields
        private string id_;
        private string name_;
        private string phone_;
        private string address_;
        #endregion

        #region Constructor
        public Person()
        {
            id_ = "";
            name_ = "";
            phone_ = "";
            address_ = "";
        }

        // Parameterized constructor
        public Person(string id, string name, string phone, string address)
        {
            id_ = id;
            name_ = name;
            phone_ = phone;
            address_ = address;
        }
        #endregion

        #region Property Methods
        public string ID { get { return id_; } set { id_ = value; } }
        public string Name { get { return name_; } set { name_ = value; } }
        public string Phone { get { return phone_; } set { phone_ = value; } }
        public string Address { get { return address_; } set { address_ = value; } }
        #endregion

        #region ToString
        // Overridable ToString method to display name and phone number
        public override string ToString()
        {
            return $"Name: {Name}, Phone: {Phone}";
        }
        #endregion
    }
}
