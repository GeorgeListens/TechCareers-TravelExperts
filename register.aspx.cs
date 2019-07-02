
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelExpertsFinal
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            
            Customers cust = new Customers();
            cust.CustFirstName = firstNametxt.Text;
            cust.CustLastName = lastNametxt.Text;
            cust.CustAddress = addresstxt.Text;
            cust.CustCity = citytxt.Text;
            cust.CustProv = DropDownList2.SelectedItem.Value;
            cust.CustPostal = postalCodetxt.Text;
            cust.CustCountry = CountryID.SelectedItem.Value;
            cust.CustHomePhone = phoneNumbertxt.Text;
            cust.CustBusPhone = mobNumbertxt.Text;
            cust.CustEmail = emailtxt.Text;
            cust.CustPassword = passwordtxt.Text;

            List<Customers> cl = CustomersDB.GetAll();
            List<string> emailList = new List<string>();

            foreach (var c in cl)
            {
                emailList.Add(c.CustEmail.Trim());
            }
            if (emailList.Contains(cust.CustEmail)){
                lblError.Text = "Duplicated Email!";
                emailtxt.Text = "";
                lastNametxt.Text = "";
                firstNametxt.Text = "";
                passwordtxt.Text = "";
                passwordRetxt.Text = "";
            }
            else
            {
                CustomersDB.Add(cust);
                Response.Redirect("login.aspx");
            }

            
        }
    }
}