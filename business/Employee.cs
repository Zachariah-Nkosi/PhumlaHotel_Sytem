using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phumla_kamnandi_83.business
{
    public class Employee : Person
    {
        #region data members
        private string emplID;
        private string password_;
        private Role roleVal; 
        #endregion
        public enum Role
        {
            Receptionist = 0,
            Admin = 1
        }

        #region Constructor
        public Employee(string id, string employeeID, string password, string name, string phone, string address, Role roleType)
            : base(id, name, phone, address)
        {
            emplID = employeeID;
            password_ = password;
            this.roleVal = roleType;
        }
        #endregion

        #region Property method
        //// Role: either "Admin" or "General"
        //public string Role { get { return role_; } set { role_ = value; } }
        #endregion

        #region methods
        // Method to check if the receptionist has access to the database
        public bool HasDatabaseAccess()
        {
            bool hasAccess = false;
            if (roleVal == Role.Admin)
            {
                hasAccess = true;
            }
            return hasAccess;
        }

        // Overriding ToString method to include role
        public override string ToString()
        {
            return $"{base.ToString()}, Role: {roleVal}";
        }
        #endregion
    }

}
