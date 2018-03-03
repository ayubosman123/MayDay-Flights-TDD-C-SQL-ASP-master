using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class Bookings_Delete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
        Int32 BookRef;

        //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Booking to be deleted from the session object
        BookRef = Convert.ToInt32(Session["BookRef"]);
        //display the PK of record to be deleted
        txtBookRef.Text = BookRef.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteBooking();
        //redirect back to the main page
        Response.Redirect("Default.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("Default.aspx");
    }

    void DeleteBooking()
    {
        //function to delete the selected record

        //create a new instance of the bookings collection
        clsBookingsCollection Bookings = new clsBookingsCollection();
        //find the record to delete
        Bookings.ThisBookings.Find(BookRef);
        //delete the record
        Bookings.Delete();
    }
}