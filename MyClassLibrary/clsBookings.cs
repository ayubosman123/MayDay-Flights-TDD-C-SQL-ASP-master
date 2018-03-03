using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary
{
    public class clsBookings
    {
        //private data memeber for the BookRef property
        private Int32 mBookRef;
        
        //public property for BookRef
        public int BookRef
        {
            get
            {
                //return private data
                return mBookRef;
            }
            set
            {
                //set the value of the private data member
                mBookRef = value;
            }
        }        


       //private data memeber for the ammount property
        private decimal mAmmount;
        //public property for ammount
        public decimal Ammount
        {
            get
            {
                //return private data
                return mAmmount;
            }
            set
            {
                //set the value of the private data member
                mAmmount = value;
            }
        }
        
        //private data memeber for the date booked property
        private DateTime mDateBooked;
        //public property for DateBooked
        public DateTime DateBooked
        {
            get
            {
                //return private data
                return mDateBooked;
            }
            set
            {
                //set the value of the private data member
                mDateBooked = value;
            }
        }        
        
        //private data memeber for the payment type property
        private string mPaymentType;
        //public property for payment type
        public string PaymentType
        {
            get
            {
                //return private data
                return mPaymentType;
            }
            set
            {
                //set the the value of the private memeber
                mPaymentType = value;
            }
        }


        public string Valid(string ammount,string dateBooked, string paymentType )
        {
            //temp variable to store date
            DateTime DateTemp;
            //string variable to store any error messages found
            string Error = "";


            try //try to see if the ammount entered is valid
            {
                //var to store ammount
                decimal Price;
                //assign the ammount a tempory variable
                Price = Convert.ToDecimal(ammount);
                //if the price is greater then 0 but less then 30,0000
                if (Price < 0 | Price > 30000 )
                {
                    //set the error message
                    Error = Error + "Ammount must be between £0 and £30,000 : ";
                }
            }
            catch // if an error has failed to be caught
            {
                //flag an error
                Error = Error + "Incorrect currency format entered : ";
            }

            //If Payment type is blank
            if (paymentType.Length == 0)
            {
                //Flag an error
                Error = Error + "Payment Blank: Charecter limit 10 : ";
            }

            //If Payment type greater then 10 charecters
            if (paymentType.Length > 10)
            {
                //Flag an error
                Error = Error + "Payment too big: Charecter limit 10 : ";
            }

            try //try to see if the date entered is valid
            {
                //tempory variable to store the date
                DateTemp = Convert.ToDateTime(dateBooked);
                //if the datetemp is greater then todays date
                if (DateTemp < DateTime.Now.Date)
                {
                    //flag an error
                    Error = Error + "Date in past. Please enter todays date : ";
                }

                //if the datetemp is less then todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //flag an error
                    Error = Error + "Date in past. Please enter todays date : ";
                }

            }
            catch // if an error has failed to be caught
            {
                //flag an error
                Error = Error + "Incorrect Date Format entered : ";
            }

            //return any errors found
            return Error;
        }

        public bool Find(int bookRef)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the book ref to search for
            DB.AddParameter("@BookRef", bookRef);
            //execute stored procedure
            DB.Execute("sproc_tblBookings_FilterbyBookingRef");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mBookRef = Convert.ToInt32(DB.DataTable.Rows[0]["BookRef"]);
                mAmmount = Convert.ToDecimal(DB.DataTable.Rows[0]["Ammount"]);
                mDateBooked = Convert.ToDateTime(DB.DataTable.Rows[0]["DateBooked"]);
                mPaymentType = Convert.ToString(DB.DataTable.Rows[0]["PaymentType"]);
                //return an record has been found
                return true;
            }
            //if no record is found
            else
            {
                //record no record has been found
                return false;
            }
        }
           

            }
            
        }
    
