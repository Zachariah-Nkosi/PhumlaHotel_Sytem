﻿using phumla_kamnandi_83.database;
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
            try
            {
                kamnandiDB.DataSetChange(guest);
                guests.Add(guest);
                MessageBox.Show("Guest data processed successfully.");
                foreach (var item in guests)
                {
                    MessageBox.Show("Test Add2Collection: "+item.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in DataMaintenance (Guest): " + ex.Message);
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
            bool result = kamnandiDB.UpdateDataSourceGuest();
            MessageBox.Show("FinalizeChangesGuest executed. Success: " + result);
            return result;
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
