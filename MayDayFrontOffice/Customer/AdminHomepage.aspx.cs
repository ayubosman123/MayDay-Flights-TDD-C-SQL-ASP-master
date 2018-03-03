using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_customer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //redirect to the delete page, where the customer that has been chosen will be deleted
        // there is not page for delete customer as you can select from the list who to delete and that customer will then be deleted. 
        Response.Redirect("Delete.aspx");
    }

    protected void btnBacktoHomePage_Click(object sender, EventArgs e)
    {
        //directs back to the home page 
        Response.Redirect("/Misc/Home.aspx");
    }

    protected void btnAdd_Click1(object sender, EventArgs e)
    {
        //directs back to the form page where a customer can be added 
        Response.Redirect("FormPage.aspx");
    }

    protected void btnEdit_Click1(object sender, EventArgs e)
    {
        //redirect to the edit page, where a customers details can be edited
        Response.Redirect("FormPage.aspx");
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //apply will filter by surname and/or postcode 
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //will display all the customers on the table
    }

    protected void lstAddresses_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}