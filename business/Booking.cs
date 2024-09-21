using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phumla_kamnandi_83.business
{
    public class Booking
    {
        #region Data Fields
        private int bookingId_;
        private int roomId_;
        private string guestID_;
        private DateTime checkInDate_;
        private DateTime checkOutDate_;
        private decimal totalCost_;
        private string bookingStatus_;
        #endregion

        #region Constructor
        public Booking(int roomId, string guestId, DateTime checkInDate, DateTime checkOutDate, decimal totalCost, string bookingStatus)
        {
            roomId_ = roomId;
            guestID_ = guestId;
            this.checkInDate_ = checkInDate;
            this.checkOutDate_ = checkOutDate;
            this.totalCost_ = totalCost;
            this.bookingStatus_ = bookingStatus;
        }
        #endregion

        #region Property Methods
        public int getBookingId { get {  return bookingId_; } set { bookingId_ = value; } }
        public int getRoomId { get { return roomId_; } set { roomId_ = value; } }
        public string getGuestID { get { return guestID_; } set { guestID_ = value; } }
        public DateTime getCheckInDate { get { return checkInDate_; } set { checkInDate_ = value; } }
        public DateTime getCheckOutDate { get {return checkOutDate_; } set {checkOutDate_ = value; } }
        public decimal getTotalCost() { return totalCost_; }
        public string getBookingStatus { get { return bookingStatus_; } set { bookingStatus_ = value; } }
        #endregion

        #region Display Booking details
        public string DisplayBookingInfo()
        {
            return $"Booking ID: {bookingId_}, Guest: {guestID_}, Room: {roomId_}, Check-in: {checkInDate_}, Check-out: {checkOutDate_}, Total Cost: {totalCost_:C}, Status: {bookingStatus_}";
        }
        #endregion

    }
}
