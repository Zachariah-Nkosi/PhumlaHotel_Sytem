using phumla_kamnandi_83.database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phumla_kamnandi_83.business
{
    public class PhumlaController
    {
        #region Data Fields
        PhumlaKamnandiDB kamnandiDB;
        Collection<Booking> bookings;
        Collection<Employee> employees;
        Collection<Guest> guests;
        Collection<Hotel> hotels;
        Collection<Room> rooms;
        #endregion

        #region Constructor
        public PhumlaController()
        {
            kamnandiDB = new PhumlaKamnandiDB();

            bookings = kamnandiDB.AllBookings;
            employees = kamnandiDB.AllEmployees;
            guests = kamnandiDB.AllGuests;
            hotels = kamnandiDB.AllHotels;
            rooms = kamnandiDB.AllRooms;
        }
        #endregion

        #region Database Communication
        #region DataMaintenance
        public void DataMaintenance(Booking booking)
        {
            kamnandiDB.DataSetChange(booking);
            bookings.Add(booking);
        }

        public void DataMaintenance(Employee employee)
        {
            kamnandiDB.DataSetChange(employee);
            employees.Add(employee);
        }

        public void DataMaintenance(Guest guest)
        {
            kamnandiDB.DataSetChange(guest);
            guests.Add(guest);
            foreach (var gue in guests)
            {
                MessageBox.Show(" Guest: " + gue);
            }
        }

        public void DataMaintenance(Hotel hotel)
        {
            kamnandiDB.DataSetChange(hotel);
            hotels.Add(hotel);
        }

        public void DataMaintenance(Room room)
        {
            kamnandiDB.DataSetChange(room);
            rooms.Add(room);
        }
        #endregion

        #region FinalizeChanges
        public bool FinalizeChangesBook()
        {
            return kamnandiDB.UpdateDataSourceBook();
        }
        public bool FinalizeChangesEmp()
        {
            return kamnandiDB.UpdateDataSourceEmp();
        }
        public bool FinalizeChangesGuest()
        {
            return kamnandiDB.UpdateDataSourceGuest();
        }
        public bool FinalizeChangesHotel()
        {
            return kamnandiDB.UpdateDataSourceHotel();
        }
        public bool FinalizeChangesRoom()
        {
            return kamnandiDB.UpdateDataSourceRoom();
        }
        #endregion
        #endregion
    }
}
