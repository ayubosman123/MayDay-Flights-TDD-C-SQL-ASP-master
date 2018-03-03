using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class Bookings_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayBookings();
        }
    }

    protected void btnNew_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["BookRef"] = -1;
        //redirect to the data entry page
        Response.Redirect("AEBookings.aspx");
    }

    void DisplayBookings()
    {
        //create an instance of the booking collection
        clsBookingsCollection Bookings = new clsBookingsCollection();
        //set the data source to the list of bookings in the collection
        lstBookings.DataSource = Bookings.BookingsList;
        //set the name of the primary key
        lstBookings.DataValueField = "BookRef";
        //set the data field to display
        lstBookings.DataTextField = "BookRef";
        //bind the data to the list
        lstBookings.DataBind();
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 BookRef;
        //if a record has been selected from the list
        if (lstBookings.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            BookRef = Convert.ToInt32(lstBookings.SelectedValue);
            //store the data in the session object
            Session["BookRef"] = BookRef;
            //redirect to the edit page
            Response.Redirect("AEBookings.aspx");
        }
        else//if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 BookRef;
        //if a record has been selected from the list
        if (lstBookings.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            BookRef = Convert.ToInt32(lstBookings.SelectedValue);
            //store the data in the session object
            Session["BookRef"] = BookRef;
            //redirect to the delete page
            Response.Redirect("Delete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
    
        FilterBookingsRef(txtFilter.Text);
    }

    void FilterBookingsRef(string BookRef)
    {
        //create an instance of the booking collection
        clsBookingsCollection Bookings = new clsBookingsCollection();
        Bookings.FilterbyBookRef(BookRef);
        //set the data source to the list of bookings in the collection
        lstBookings.DataSource = Bookings.BookingsList;
        //set the name of the primary key
        lstBookings.DataValueField = "BookRef";
        //set the data field to display
        lstBookings.DataTextField = "BookRef";
        //bind the data to the list
        lstBookings.DataBind();
    }

    protected void btnFDate_Click(object sender, EventArgs e)
    {
        FilterBookingsDateRange(txtDate1.Text, txtDate2.Text);
       
    }

    void FilterBookingsDateRange(string Date1, string Date2)
    {
        //create an instance of the booking collection
        clsBookingsCollection Bookings = new clsBookingsCollection();
        Bookings.FilterbyDateBooked(Date1,Date2);
        //set the data source to the list of bookings in the collection
        lstBookings.DataSource = Bookings.BookingsList;
        //set the name of the primary key
        lstBookings.DataValueField = "BookRef";
        //set the data field to display
        lstBookings.DataTextField = "DateBooked";
        //bind the data to the list
        lstBookings.DataBind();
    }

}