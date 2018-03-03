using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Flights_DelteFlight : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("DefaultFlight.aspx");
    }

    protected void btnCancelFlight_Click(object sender, EventArgs e)
    {
        lblError.Text = "Flight Deleted";
    }
}