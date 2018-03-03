using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DefaultFlight : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddFlight.aspx");
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        Response.Redirect("Update.aspx");
    }

    

    protected void btnDelete_Click1(object sender, EventArgs e)
    {
        Response.Redirect("DeleteFlight.aspx");
    }
}

    