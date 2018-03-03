using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Page_UnLoad(object sender, EventArgs e)
    {
        
    }


    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // if the username and password are true then
        if (txtUser.Text == "Admin" && txtPassword.Text == "Admin")
        {
            //This line of code redirects to the Admin default page
            
           
            Response.Redirect("/Employees/EmployeeMenu.aspx");
        }
        // if the username and password are true then
        else if (txtPassword.Text == "Admin1" && txtPassword.Text == "Admin")
        {
            ///This line of code redirects to the Admin default page

           
            Response.Redirect("/Bookings/AEBookings.aspx");
        }

        //else
        //{
        //    if the statement fails display the message
        //    lblError.Text = "User OR Password not found";
        //}
    }

    void Login(Boolean State)
    {

        btnRegister.Visible = State;
    }
}