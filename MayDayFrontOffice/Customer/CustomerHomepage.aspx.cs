using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerHomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnBacktoHomePage_Click(object sender, EventArgs e)
    {
        //directs back to the home page 
        Response.Redirect("/Misc/Home.aspx");
    }

    protected void btnUpdateDetails_Click(object sender, EventArgs e)
    {
        // This button will take you update details page where the customer can update their details 
        Response.Redirect("FormPage.aspx");
    }

    protected void btnChangeLoginDetails_Click(object sender, EventArgs e)
    {
        // this will take you the change login details page where the customer can change their login details such as a password. 
        Response.Redirect("ChangeLoginDetails.aspx");
    }
}