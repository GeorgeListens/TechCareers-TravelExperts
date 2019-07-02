using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelExpertsFinal
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (emailtxt.Text.ToString() != "" && passwordtxt.Text.ToString() != "")
            {
                Login();
                           
            }
            else if (emailtxt.Text.ToString() != "")
            {
            }
            else if (passwordtxt.Text.ToString() != "")
            {
            }
            else
            {
            }
        }

        protected void Login()
        {
            string userEmail = emailtxt.Text.ToString();
            string userPassword = passwordtxt.Text.ToString();
            Customers login = new Customers();
            login = CustomersDB.GetPassword(userEmail, userPassword);
            if (login != null) //find matched userid and password
            {
                Session["userEmail"] = login.CustEmail;
                Session["userPassword"] = login.CustPassword;
                Session["CustomerId"] = login.CustomerId;

                Response.Redirect("home.aspx");

            }
            else //userid and password not match
            {
                emailtxt.Text = "";
                passwordtxt.Text = "";
                errorLabel.Text = "Login Attempt Failed. Please Try Again.";
            }
            
        }

        //protected void ButtonLogout_Click(object sender, CommandEventArgs e)
        //{
        //    Session.Abandon();
        //    //if (HttpContext.Current.Session["userEmail"] != null)
        //    //{
        //    //    ((Label)Master.FindControl("emailLabel")).Text = "ddd";// emailtxt.Text.ToString();
        //    //}
        //    //else if (HttpContext.Current.Session["userEmail"] == null)
        //    //{
        //    //    ((Label)Master.FindControl("emailLabel")).Text = "fff";
                
        //    //}
        //}

    }
}