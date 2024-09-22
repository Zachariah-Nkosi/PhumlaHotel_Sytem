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
        private string empID;
        private string roomNo;
        private string guestID_;
        private DateTime bookingDate;
        private DateTime checkInDate_;
        private DateTime checkOutDate_;
        private decimal totalCost_;
        private string bookingStatus_;
        private int noOfGuests;
        #endregion

        #region Constructor
        public Booking(string roomNum, string guestId, DateTime checkInDate, DateTime checkOutDate, decimal totalCost, string bookingStatus)
        {
            roomNo = roomNum;
            guestID_ = guestId;
            this.checkInDate_ = checkInDate;
            this.checkOutDate_ = checkOutDate;
            this.totalCost_ = totalCost;
            this.bookingStatus_ = bookingStatus;
        }

        public Booking() { }
        #endregion

        #region Property Methods
        public int getBookingId { get {  return bookingId_; } set { bookingId_ = value; } }
        public string getRoomNo { get { return roomNo; } set { roomNo = value; } }
        public string getGuestID { get { return guestID_; } set { guestID_ = value; } }
        public DateTime getCheckInDate { get { return checkInDate_; } set { checkInDate_ = value; } }
        public DateTime getCheckOutDate { get {return checkOutDate_; } set {checkOutDate_ = value; } }
        public DateTime getBookingDate { get { return bookingDate; } set { bookingDate = value; } }
        public decimal getTotalCost() { return totalCost_; }
        public string getBookingStatus { get { return bookingStatus_; } set { bookingStatus_ = value; } }

        public string getEmplID
        {
            get { return empID; }
            set { empID = value; }
        }

        public int getNoOfGuests { get { return noOfGuests; } set { noOfGuests = value; } }
        #endregion

        #region Display Booking details
        public string DisplayBookingInfo()
        {
            return $"Booking ID: {bookingId_}, Guest: {guestID_}, Room: {roomNo}, Booking Date: {bookingDate}, Check-in: {checkInDate_}, Check-out: {checkOutDate_}, Total Cost: {totalCost_:C}, Status: {bookingStatus_}";
        }
        #endregion

    }
}
