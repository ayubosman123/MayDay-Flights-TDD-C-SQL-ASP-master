using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLibrary;

namespace MaydayBackend
{
    public partial class FrmAEBookings : Form
    {
        public FrmAEBookings()
        {
            InitializeComponent();
            txtDateBo.Text = DateTime.Today.Date.ToString("dd/MM/yyyy");

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Add();
        }

        //function for adding new records
        void Add()
        {
            //create an instance of the booking list
            clsBookingsCollection BookingsList = new clsBookingsCollection();
            //validate the data on the web form
            String Error = BookingsList.ThisBookings.Valid(txtAmount.Text, txtDateBo.Text, txtPayType.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {

                //get the data entered by the user
                BookingsList.ThisBookings.Ammount = Convert.ToDecimal(txtAmount.Text);
                BookingsList.ThisBookings.DateBooked = Convert.ToDateTime(txtDateBo.Text);
                BookingsList.ThisBookings.PaymentType = txtPayType.Text;
                //add the record
                BookingsList.Add();
                //all done so redirect back to the main page
                lblError.Text = "Sucessfully Booked";
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }
    }
}
