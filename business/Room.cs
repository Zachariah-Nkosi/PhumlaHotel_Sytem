using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phumla_kamnandi_83.business
{
    public class Room
    {
        #region Data Fields
        private string id_;
        private string hotelID;
        private string type_;
        private decimal price_per_night_;
        private List<Booking> bookings;
        #endregion

        #region Constructor
        public Room ()
        {
            id_ = string.Empty;
            type_ = string.Empty;
            price_per_night_ = 0;
        }
        public Room(string roomId, string roomType, decimal pricePerNight) 
        {
            id_ = roomId;
            type_ = roomType;
            price_per_night_ = pricePerNight;
        }
        #endregion

        #region Property Methods
        public string ID { get { return id_; } set { id_ = value; } }
        public string HotelID { get { return hotelID; } set { hotelID = value; } }
        public string RoomType { get { return type_; } set { type_ = value; } }
        public decimal PricePerNight { get { return price_per_night_; } set { price_per_night_ = value; } }
        #endregion

        #region Methods
        public bool IsAvailable(DateTime checkIn, DateTime checkOut)
        {
            bool isAvailable = true;

            foreach (var booking in bookings)
            {
                if (booking.getCheckInDate < checkOut && checkIn < booking.getCheckOutDate)
                {
                    isAvailable = false;
                }
            }

            return isAvailable;
        }
        #endregion
    }
}
