using phumla_kamnandi_83.business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static phumla_kamnandi_83.business.Employee;
using System.Xml.Linq;

namespace phumla_kamnandi_83.database
{
    public class PhumlaKamnandiDB : DB
    {
        #region Data Fields
        private string table1 = "Guest";
        private string table2 = "Hotel";
        private string table3 = "Room";
        private string table4 = "Bookings";
        private string table5 = "Employee";

        private string sqlLocal1 = "SELECT * FROM Guest";
        private string sqlLocal2 = "SELECT * FROM Hotel";
        private string sqlLocal3 = "SELECT * FROM Room";
        private string sqlLocal4 = "SELECT * FROM Bookings";
        private string sqlLocal5 = "SELECT * FROM Employee";

        private Collection<Guest> guests;
        private Collection<Hotel> hotels;
        private Collection<Room> rooms;
        private Collection<Booking> bookings;
        private Collection<Employee> employees;
        #endregion

        #region Property Methods
        public Collection<Guest> AllGuests
        {
            get { return guests; }
            set { guests = value; }
        }

        public Collection<Hotel> AllHotels
        {
            get { return hotels; }
            set { hotels = value; }
        }

        public Collection<Room> AllRooms
        {
            get { return rooms; }
            set { rooms = value; }
        }

        public Collection<Booking> AllBookings
        {
            get { return bookings; }
            set { bookings = value; }
        }

        public Collection<Employee> AllEmployees
        {
            get { return employees; }
            set { employees = value; }
        }
        #endregion

        #region Constructor
        public PhumlaKamnandiDB () : base ()
        {
            guests = new Collection<Guest> ();
            hotels = new Collection<Hotel> ();
            rooms = new Collection<Room> ();
            bookings = new Collection<Booking> ();
            employees = new Collection<Employee> ();

            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);

            FillDataSet(sqlLocal2, table2);
            Add2Collection(table2);

            FillDataSet(sqlLocal3, table3);
            Add2Collection(table3);

            FillDataSet(sqlLocal4, table4);
            Add2Collection(table4);

            FillDataSet(sqlLocal5, table5);
            Add2Collection(table5);

        }
        #endregion

        #region  Utility Methods
        public DataSet GetDataSet ()
        {
            return dsMain;
        }

        public void Add2Collection (string table)
        {
            DataRow myRow = null;
            Guest aGuest;
            Hotel aHotel;
            Booking aBooking;
            Room aRoom;
            Employee anEmp;

            switch (table)
            {
                case "Guest":
                    foreach (DataRow myRow_loop_var in dsMain.Tables[table].Rows)
                    {
                        myRow = myRow_loop_var;
                        if (myRow.RowState != DataRowState.Deleted)
                        {
                            aGuest = new Guest();
                            aGuest.ID = Convert.ToString(myRow["ID"]).TrimEnd();
                            aGuest.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                            aGuest.Address = Convert.ToString(myRow["Address"]).TrimEnd();
                            aGuest.Phone = Convert.ToString(myRow["Phone"]).TrimEnd();
                            aGuest.KinName = Convert.ToString(myRow["KinName"]).TrimEnd();
                            aGuest.KinPhone = Convert.ToString(myRow["KinCell"]).TrimEnd();
                            aGuest.Card = Convert.ToString(myRow["CardNo"]).TrimEnd();
                            guests.Add(aGuest);
                        }
                    }
                break;

                case "Hotel":
                    foreach (DataRow myRow_loop_var in dsMain.Tables[table].Rows)
                    {
                        myRow = myRow_loop_var;
                        if (myRow.RowState != DataRowState.Deleted)
                        {
                            aHotel = new Hotel();
                            aHotel.HotelID = Convert.ToString(myRow["HotelID"]).TrimEnd();
                            aHotel.HotelName = Convert.ToString(myRow["HotelName"]).TrimEnd();
                            aHotel.Address = Convert.ToString(myRow["Address"]).TrimEnd();
                            aHotel.PhoneNumber = Convert.ToString(myRow["Phone"]).TrimEnd();
                            aHotel.NoOfRooms = Convert.ToInt32(myRow["NumOfRooms"]);
                            hotels.Add(aHotel);
                        }
                    }
                    break;

                case "Bookings":
                    foreach (DataRow myRow_loop_var in dsMain.Tables[table].Rows)
                    {
                        myRow = myRow_loop_var;
                        if (myRow.RowState != DataRowState.Deleted)
                        {
                            aBooking = new Booking();
                            aBooking.getBookingId = Convert.ToString(myRow["BookingID"]).TrimEnd();
                            aBooking.getEmployeeName = Convert.ToString(myRow["EmployeeName"]).TrimEnd();
                            aBooking.getGuestName = Convert.ToString(myRow["GuestName"]).TrimEnd();
                            aBooking.getNoOfGuests = Convert.ToInt32(myRow["NumberOfGuests"]);
                            aBooking.getRoomNo = Convert.ToString(myRow["RoomNo"]).TrimEnd();
                            aBooking.getBookingDate = Convert.ToDateTime(myRow["BookingDate"]);
                            aBooking.getCheckInDate = Convert.ToDateTime(myRow["CheckInDate"]);
                            aBooking.getCheckOutDate = Convert.ToDateTime(myRow["CheckOutDate"]);
                            aBooking.getTotalCost = Convert.ToDecimal(myRow["Price"]);
                            aBooking.getBookingStatus = Convert.ToString(myRow["Status"]).TrimEnd();
                            bookings.Add(aBooking);
                        }
                    }
                    break;

                case "Room":
                    foreach (DataRow myRow_loop_var in dsMain.Tables[table].Rows)
                    {
                        myRow = myRow_loop_var;
                        if (myRow.RowState != DataRowState.Deleted)
                        {
                            aRoom = new Room();
                            aRoom.ID = Convert.ToString(myRow["RoomNo"]).TrimEnd();
                            aRoom.HotelID = Convert.ToString(myRow["HotelID"]).TrimEnd();
                            aRoom.RoomType = Convert.ToString(myRow["RoomType"]).TrimEnd();
                            aRoom.PricePerNight = Convert.ToDecimal(myRow["Price"]);
                            rooms.Add(aRoom);
                        }
                    }
                    break;
                case "Employee":
                    foreach(DataRow myRow_loop_ in dsMain.Tables[table].Rows)
                    {
                        myRow = myRow_loop_;
                        if (myRow.RowState != DataRowState.Deleted)
                        {
                            anEmp = new Employee();
                            anEmp.ID = Convert.ToString(myRow["ID"]).TrimEnd();
                            anEmp.EmplID = Convert.ToString(myRow["ID"]).TrimEnd();
                            anEmp.Password = Convert.ToString(myRow["Password"]);
                            anEmp.Name = Convert.ToString(myRow["Name"]);
                            anEmp.Address = Convert.ToString(myRow["Address"]);
                            anEmp.Phone = Convert.ToString(myRow["Phone"]);
                            string role = Convert.ToString(myRow["Role"]).TrimEnd();
                            switch (role)
                            {
                                case "NoRole":
                                    anEmp.RoleVal = Employee.Role.NoRole;
                                    break;
                                case "Admin":
                                    anEmp.RoleVal = Employee.Role.Admin;
                                    break;
                                case "Receptionist":
                                    anEmp.RoleVal = Employee.Role.Receptionist;
                                    break;
                            }

                            employees.Add(anEmp);
                        }
                    }
                    break;
            }
        }

        public void FillRow(DataRow aRow, Employee anEmployee) {
            aRow["ID"] = anEmployee.ID;
            aRow["EmployeeID"] = anEmployee.EmplID;
            aRow["Name"] = anEmployee.Name;
            aRow["Address"] = anEmployee.Address;
            aRow["Phone"] = anEmployee.Phone;
            Employee.Role role = anEmployee.RoleVal;
            switch (role)
            {
                case Employee.Role.NoRole:
                    aRow["Role"] = "NoRole";
                    break;
                case Employee.Role.Receptionist:
                    aRow["Role"] = "Receptionist";
                    break;
                case Employee.Role.Admin:
                    aRow["Role"] = "Admin";
                    break;
            }
            //aRow["Role"] = 
        }

        public void FillRow(DataRow aRow, Guest aGuest)
        {
            aRow["ID"] = aGuest.ID;
            aRow["Name"] = aGuest.Name;
            aRow["Address"] = aGuest.Address;
            aRow["Phone"] = aGuest.Phone;
            aRow["KinName"] = aGuest.KinName;
            aRow["KinCell"] = aGuest.KinPhone;
            aRow["CardNo"] = aGuest.Card;
        }

        public void FillRow(DataRow aRow, Room aRoom)
        {
            aRow["RoomNo"] = aRoom.ID;
            aRow["HotelID"] = aRoom.HotelID;
            aRow["RoomType"] = aRoom.RoomType;
            aRow["Price"] = aRoom.PricePerNight;        
        }

        public void FillRow(DataRow aRow, Hotel aHotel)
        {
            aRow["HotelID"] = aHotel.HotelID;
            aRow["Location"] = aHotel.Location;
            aRow["Address"] = aHotel.Address;
            aRow["Phone"] = aHotel.PhoneNumber;
            aRow["NumOfRooms"] = aHotel.NoOfRooms;
        }

        public void FillRow(DataRow aRow, Booking aBooking)
        {
            aRow["BookingID"] = aBooking.getBookingId;
            aRow["EmployeeName"] = aBooking.getEmployeeName;
            aRow["GuestName"] = aBooking.getGuestName;
            aRow["NumberOfGuests"] = aBooking.getNoOfGuests;
            aRow["RoomNo"] = aBooking.getRoomNo;
            aRow["BookingDate"] = aBooking.getBookingDate;
            aRow["CheckInDate"] = aBooking.getCheckInDate;
            aRow["CheckOutDate"] = aBooking.getCheckOutDate;
            aRow["Status"] = aBooking.getBookingStatus;
        }

        #endregion

        #region Database Operations CRUD


        public void DataSetChange(Employee anEmp)
        {
            String dataTable = "Employee";
            DataRow aRow = dsMain.Tables[dataTable].NewRow();//creating a row
            FillRow(aRow, anEmp);
            dsMain.Tables[dataTable].Rows.Add(aRow);         //adding the row to the table
        }
        public void DataSetChange(Guest aGuest)
        {
            String dataTable = "Guest";
            DataRow aRow = dsMain.Tables[dataTable].NewRow();//creating a row
            FillRow(aRow, aGuest);
            dsMain.Tables[dataTable].Rows.Add(aRow);         //adding the row to the table
        }

        public void DataSetChange(Booking aBooking)
        {
            String dataTable = "Booking";
            DataRow aRow = dsMain.Tables[dataTable].NewRow();//creating a row
            FillRow(aRow, aBooking);
            dsMain.Tables[dataTable].Rows.Add(aRow);         //adding the row to the table
        }

        public void DataSetChange(Hotel aHotel)
        {
            String dataTable = "Hotel";
            DataRow aRow = dsMain.Tables[dataTable].NewRow();//creating a row
            FillRow(aRow, aHotel);
            dsMain.Tables[dataTable].Rows.Add(aRow);         //adding the row to the table
        }

        public void DataSetChange(Room aRoom)
        {
            String dataTable = "Employee";
            DataRow aRow = dsMain.Tables[dataTable].NewRow();//creating a row
            FillRow(aRow, aRoom);
            dsMain.Tables[dataTable].Rows.Add(aRow);         //adding the row to the table
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        #region Build_INSERT_Parameters
        public void Build_INSERT_Parameters_Book()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 10, "BookingID");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@EmployeeName", SqlDbType.NVarChar, 10, "EmployeeName");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestName", SqlDbType.NVarChar, 50, "GuestName");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@NumberOfGuests", SqlDbType.Int, 32, "NumberOfGuests");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomNo", SqlDbType.NVarChar, 10, "RoomNo");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@BookingDate", SqlDbType.Date, 30, "BookingDate");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckInDate", SqlDbType.Date, 30, "CheckInDate");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOutDate", SqlDbType.Date, 30, "CheckOutDate");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Price", SqlDbType.Money, 8, "Price");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Status", SqlDbType.NVarChar, 20, "Status");
            dataAdapter.InsertCommand.Parameters.Add(param);
        }

        public void Build_INSERT_Parameters_Emp()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@ID", SqlDbType.NVarChar, 10, "ID");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@EmployeeID", SqlDbType.NVarChar, 10, "EmployeeID");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Password", SqlDbType.NVarChar, 15, "Password");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 80, "Address");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Role", SqlDbType.NVarChar, 15, "Role");
            dataAdapter.InsertCommand.Parameters.Add(param);
        }

        public void Build_INSERT_Parameters_Guest()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@ID", SqlDbType.NVarChar, 10, "ID");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 80, "Address");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@KinName", SqlDbType.NVarChar, 50, "KinName");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@KinCell", SqlDbType.NVarChar, 15, "KinCell");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CardNo", SqlDbType.NVarChar, 16, "CardNo");
            dataAdapter.InsertCommand.Parameters.Add(param);
        }

        public void Build_INSERT_Parameters_Hotel()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@HotelID", SqlDbType.NVarChar, 10, "HotelID");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@HotelName", SqlDbType.NVarChar, 50, "HotelName");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 80, "Address");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@NumOfRooms", SqlDbType.Int, 32, "NumOfRooms");
            dataAdapter.InsertCommand.Parameters.Add(param);
        }

        public void Build_INSERT_Parameters_Room()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@RoomNo", SqlDbType.NVarChar, 5, "RoomNo");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@HotelID", SqlDbType.NVarChar, 10, "HotelID");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomType", SqlDbType.NVarChar, 10, "RoomType");
            dataAdapter.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Price", SqlDbType.Money, 8, "Price");
            dataAdapter.InsertCommand.Parameters.Add(param);
        }
        #endregion

        #region Create_INSERT_Command
        public void Create_INSERT_Command_Book()
        {
            dataAdapter.InsertCommand = new SqlCommand("INSERT into Bookings (BookingID, EmployeeName, GuestName, NumberOfGuests, RoomNo, BookingDate, CheckInDate, CheckOutDate, Price, Status)VALUES(@IBookingID, @EmployeeName, @GuestName, @NumberOfGuests, @RoomNo, @BookingDate, @CheckInDate, @CheckOutDate, @Price, @Status)", sqlConn);
            Build_INSERT_Parameters_Book();
        }
        public void Create_INSERT_Command_Emp()
        {
            dataAdapter.InsertCommand = new SqlCommand("INSERT into Employee (EmployeeID, Password, Name, Address, Phone, Role)VALUES(@EmployeeID, @Password, @Name, @Address, @Phone, @Role)", sqlConn);
            Build_INSERT_Parameters_Emp();
        }
        public void Create_INSERT_Command_Guest()
        {
            dataAdapter.InsertCommand = new SqlCommand("INSERT into Guest (ID, Name, Address, Phone, KinName, KinCell, CardNo)VALUES(@ID, @Name, @Address, @Phone, @KinName, @KinCell, @CardNo)", sqlConn);
            Build_INSERT_Parameters_Guest();
        }
        public void Create_INSERT_Command_Hotel()
        {
            dataAdapter.InsertCommand = new SqlCommand("INSERT into Hotel (HotelID, HotelName, Location, Address, Phone, NumOfRooms)VALUES(@HotelID, @HotelName, @Location, @Address, @Phone, @NumOfRooms)", sqlConn);
            Build_INSERT_Parameters_Hotel();
        }
        public void Create_INSERT_Command_Room()
        {
            dataAdapter.InsertCommand = new SqlCommand("INSERT into Hotel (RoomNo, HotelID, RoomType, Price)VALUES(@RoomNo, @HotelID, @RoomType, @Price)", sqlConn);
            Build_INSERT_Parameters_Room();
        }
        #endregion

        #region UpdateDataSource
        public bool UpdateDataSourceBook()
        {
            bool success = true;
            Create_INSERT_Command_Book();
            success = UpdateDataSource(sqlLocal4, table4);
            return success;
        }

        public bool UpdateDataSourceEmp()
        {
            bool success = true;
            Create_INSERT_Command_Emp();
            success = UpdateDataSource(sqlLocal5, table5);
            return success ;
        }

        public bool UpdateDataSourceRoom()
        {
            bool success = true;
            Create_INSERT_Command_Room();
            success = UpdateDataSource(sqlLocal3, table3);
            return success ;
        }

        public bool UpdateDataSourceGuest()
        {
            bool success = true;
            Create_INSERT_Command_Guest();
            success = UpdateDataSource(sqlLocal1, table1);
            return success ;
        }

        public bool UpdateDataSourceHotel()
        {
            bool success = true ;
            Create_INSERT_Command_Hotel();
            success = UpdateDataSource(sqlLocal2, table2);
            return success ;
        }
        #endregion

        #endregion


    }
}
