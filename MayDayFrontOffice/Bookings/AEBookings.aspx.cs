using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class Bookings_AEBookings : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 BookRef;

    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the pk of the booking to be processed
        BookRef = Convert.ToInt32(Session["BookRef"]);
        if (IsPostBack == false)
        {

            //if this is not a new record
            if (BookRef != -1)
            {
                //change the title of the page
                lblTitle.Text = "Edit Booking";
                //display the current data for the record
                DisplayBookings();
                //display the PK of record to be edited
                txtRef.Text = BookRef.ToString();
            }
            else //this is a new record
            {
                //change the title of the page
                lblTitle.Text = "New Booking";
                //set todays date
                txtDateBooked.Text = DateTime.Today.Date.ToString("dd/MM/yyyy");
                //hide the reference label and box
                lblRef.Visible = false;
                txtRef.Visible = false;
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (BookRef == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
    }

    //function for adding new records
    void Add()
    {
        //create an instance of the booking list
        clsBookingsCollection BookingsList = new clsBookingsCollection();
        //validate the data on the web form
        String Error = BookingsList.ThisBookings.Valid(txtAmmount.Text, txtDateBooked.Text, txtPaymentType.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
 
            //get the data entered by the user
            BookingsList.ThisBookings.Ammount = Convert.ToDecimal(txtAmmount.Text);
            BookingsList.ThisBookings.DateBooked= Convert.ToDateTime(txtDateBooked.Text);
            BookingsList.ThisBookings.PaymentType = txtPaymentType.Text;
            //add the record
            BookingsList.Add();
            //all done so redirect back to the main page
            Response.Redirect("Default.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    //function for updating records
    void Update()
    {
        //create an instance of the booking list
        clsBookingsCollection BookingsList = new clsBookingsCollection();
        //validate the data on the web form
        String Error = BookingsList.ThisBookings.Valid(txtAmmount.Text, txtDateBooked.Text, txtPaymentType.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            BookingsList.ThisBookings.Find(BookRef);
            //get the data entered by the user
            BookingsList.ThisBookings.Ammount = Convert.ToDecimal(txtAmmount.Text);
            BookingsList.ThisBookings.DateBooked = Convert.ToDateTime(txtDateBooked.Text);
            BookingsList.ThisBookings.PaymentType = txtPaymentType.Text;
            //update the record
            BookingsList.Update();
            //all done so redirect back to the main page
            Response.Redirect("Default.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void DisplayBookings()
    {
        //create an instance of the booking list
        clsBookingsCollection BookingsList = new clsBookingsCollection();
        //find the record to update
        BookingsList.ThisBookings.Find(BookRef);
        //display the data for this record
        txtAmmount.Text = BookingsList.ThisBookings.Ammount.ToString();
        txtDateBooked.Text = BookingsList.ThisBookings.DateBooked.ToString();
        txtPaymentType.Text = BookingsList.ThisBookings.PaymentType;

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to default page
        Response.Redirect("Default.aspx");
    }
}