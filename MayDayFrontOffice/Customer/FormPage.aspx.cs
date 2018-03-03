using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnBackToAdminHomePage_Click(object sender, EventArgs e)
    {
        //This will take you back to Admin Home Page 
        Response.Redirect("AdminHomepage.aspx");
    }

    protected void btnBacktoCustomerHomePage_Click(object sender, EventArgs e)
    {
        // this will then take you back to the customer Home Page 
        Response.Redirect("CustomerHomepage.aspx");
    }

    protected void btnBacktoLoginPage_Click(object sender, EventArgs e)
    {
        //directs back to the home page 
        Response.Redirect("/Misc/Home.aspx");
    }

    protected void btnEnter_Click(object sender, EventArgs e)
    {
        //This will then enter the information you have enterted in the form
    }
}