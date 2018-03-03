using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{
    public class clsBookingsCollection
    {
        //prive data memeber for the list
        List<clsBookings> mBookingsList = new List<clsBookings>();
        //private member thisAddress
        clsBookings mThisBooking = new clsBookings();

        ////constructor for the class
        //public clsBookingsCollection()
        //{
        //    //create an instance of the data connection class
        //    clsBookings TestItems = new clsBookings();
        //    //set the properties
        //    TestItems.BookRef = 1;
        //    TestItems.Ammount = 50;
        //    TestItems.DateBooked = DateTime.Now.Date;
        //    TestItems.PaymentType = "Credit";
        //    //add the item to test lists
        //    mBookingsList.Add(TestItems);
        //    //re initalise the object for some new data
        //    TestItems = new clsBookings();
        //    //set properties
        //    TestItems.BookRef = 2;
        //    TestItems.Ammount = 100;
        //    TestItems.DateBooked = DateTime.Now.Date;
        //    TestItems.PaymentType = "DEbit";
        //    //add the item to test lists
        //    mBookingsList.Add(TestItems);


        //}

        //constructor for the class
        public clsBookingsCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblBookings_SelectAll");
            //populate the array list
            PopulateArray(DB);
           }
            ////var for the index
            //Int32 Index = 0;
            ////var to store the record count
            //Int32 RecordCount = 0;
            ////object for data connection
            //clsDataConnection DB = new clsDataConnection();
            ////execute the stored procodure
            //DB.Execute("sproc_tblBookings_SelectAll");
            ////get the count of records
            //RecordCount = DB.Count;
            ////while there are records to process
            //while (Index < RecordCount)
            //{
            //    //Create a blank booking
            //    clsBookings ABooking = new clsBookings();
            //    ABooking.BookRef = Convert.ToInt32(DB.DataTable.Rows[Index]["BookRef"]);
            //    ABooking.Ammount = Convert.ToDecimal(DB.DataTable.Rows[Index]["Ammount"]);
            //    ABooking.DateBooked = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateBooked"]);
            //    ABooking.PaymentType = Convert.ToString(DB.DataTable.Rows[Index]["PaymentType"]);
            //    //add the records into a private data member
            //    mBookingsList.Add(ABooking);
            //    //point to the next record
            //    Index++;
            //}
    



        

        //public property for the booking list
        public List<clsBookings> BookingsList
        {
            get
            {
                //return the private data
                return mBookingsList;
            }
            set
            {
                //set the private data
                mBookingsList = value;
            }
        }

        //public propery for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mBookingsList.Count;
            }
            set
            {
                //later
            }
        }

        public clsBookings ThisBookings
        {
            get
            {
                //return the private data
                return mThisBooking;
            }
            set
            {
                //set the private data
                mThisBooking = value;
            }
        }

        public int Add()
        {
            //adds a new record in to the database depending on the values of mThisBooking
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Ammount", mThisBooking.Ammount);
            DB.AddParameter("@DateBooked", mThisBooking.DateBooked);
            DB.AddParameter("@PaymentType", mThisBooking.PaymentType);
            //execute the query returning primary key of new record
            return DB.Execute("Sproc_tblBookings_Insert");
            
        }

        public void Delete()
        {
            //delete the record pointed to by thisBooking
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@BookRef", mThisBooking.BookRef);
            //execute the stored procdure
            DB.Execute("sproc_tblBookings_Delete");
        }

        public void Update()
        {
            //adds a new record in to the database depending on the values of mThisBooking
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@BookRef", mThisBooking.BookRef);
            DB.AddParameter("@Ammount", mThisBooking.Ammount);
            DB.AddParameter("@DateBooked", mThisBooking.DateBooked);
            DB.AddParameter("@PaymentType", mThisBooking.PaymentType);
            //execute the query returning primary key of new record
            DB.Execute("sproc_tblBookings_Update");

            
        }

      public void FilterbyBookRef(string BookRef)
        {
            //filters records based on the primary key 
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //send the bookref to the database
            DB.AddParameter("@BookRef", BookRef);
            //execute the stored procedure
            DB.Execute("sproc_tblBookings_FilterbyPK");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray (clsDataConnection DB)
        {
            //populates array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array lsit
            mBookingsList = new List<clsBookings>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //Create a blank booking
                clsBookings ABooking = new clsBookings();
                ABooking.BookRef = Convert.ToInt32(DB.DataTable.Rows[Index]["BookRef"]);
                ABooking.Ammount = Convert.ToDecimal(DB.DataTable.Rows[Index]["Ammount"]);
                ABooking.DateBooked = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateBooked"]);
                ABooking.PaymentType = Convert.ToString(DB.DataTable.Rows[Index]["PaymentType"]);
                //add the records into a private data member
                mBookingsList.Add(ABooking);
                //point to the next record
                Index++;
            }
        }

        public void FilterbyDateBooked(string StartDate, string EndDate)
        {
            //filters records based on the primary key 
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //send the bookref to the database
            DB.AddParameter("@StartDate", Convert.ToDateTime(StartDate));
            DB.AddParameter("@EndDate",Convert.ToDateTime(EndDate));
            //execute the stored procedure
            DB.Execute("sproc_tblBookings_FilterbyDate");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }


}