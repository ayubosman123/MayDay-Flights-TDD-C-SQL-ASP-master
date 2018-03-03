using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChangeLoginDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnbacktoCustomerhomepage_Click(object sender, EventArgs e)
    {
        // this will take you back to the customer home page 
        Response.Redirect("CustomerHomepage.aspx");
    }

    protected void btnBacktologinpage_Click(object sender, EventArgs e)
    {
        //directs back to the home page 
        Response.Redirect("/Misc/Home.aspx");
    }
}