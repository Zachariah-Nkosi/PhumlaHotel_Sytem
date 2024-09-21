using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phumla_kamnandi_83.business
{
    public class Hotel
    {
        #region Data Fields
        private string hotelID_;
        private string name_;
        private string address;
        private string phone_;
        private int noOfRooms;
        private List<Room> rooms_;
        #endregion

        #region Property Methods
        public string HotelID { get { return hotelID_; } set { hotelID_ = value; } }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int NoOfRooms
        {
            get { return noOfRooms; }
            set { noOfRooms = value; }
        }
        public List<Room> Rooms { get; set; }
        #endregion

        #region Constructor
        public Hotel(string hotelId, string hotelName, string address, string phoneNumber)
        {
            HotelID = hotelId;
            HotelName = hotelName;
            this.address= address;
            PhoneNumber = phoneNumber;
            Rooms = new List<Room>();
        }
        public Hotel() { }
        #endregion

        #region Methods
        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        public Room GetAvailableRoom(string roomType, DateTime checkIn, DateTime checkOut)
        {
            foreach (var room in Rooms)
            {
                //if (room.RoomType.Equals(roomType, StringComparison.OrdinalIgnoreCase) && room.IsAvailable(checkIn, checkOut))
                if (room.RoomType.Equals(roomType) && room.IsAvailable(checkIn, checkOut))
                {
                    return room;
                }
            }
            return null; // No available room found
        }
        #endregion
    }
}
