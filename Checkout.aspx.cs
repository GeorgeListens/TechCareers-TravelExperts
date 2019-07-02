using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using mySQL.Bookings;

namespace Test
{
    public partial class Checkout : System.Web.UI.Page
    {
        private CartItemList cart;
        const decimal TAX = 0.05m;
        protected void Page_Load(object sender, EventArgs e)
        {
            // load cart details and calculate totals          
            
            cart = CartItemList.GetCart();
            if (!IsPostBack) DisplayCart();

            CalculateTotals();
        }

        private void DisplayCart()
        {
            lstCart.Items.Clear();
            CartItem item;
            for (int i = 0; i < cart.Count; i++)
            {
                item = cart[i];
                lstCart.Items.Add(item.Display());
            }
        }

        protected void btnPurchase_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            if (!ValidateCCNum())
                lblMessage.Text = "Please enter a valid credit card number";
            else if(!ValidateExpDate())
                lblMessage.Text = "Please enter a valid expiration date";
            else
                lblMessage.Text = "Congratulations, successful travel package purchase";

            for (int i = 0; i < cart.Count; i++)
            {
                Bookings booking = new Bookings();

                booking.BookingDate = DateTime.Now;
                booking.BookingNo = Session["CustomerId"] + DateTime.Now.ToString("MMMMdd");
                booking.TravelerCount = 1;
                booking.CustomerId = Convert.ToInt32(Session["CustomerId"]);
                booking.PackageId = cart[i].Package.PackageId;
                BookingsDB.Add(booking);
            }

        }
        private bool ValidateCCNum()
        {
            bool isValid = false;
            // Check credit card number
            string CCRegex = @"\d{4}-?\d{4}-?\d{4}-?\d{4}";            
            string CCInput = txtCreditCard.Text.Trim();            
            CCInput = CCInput.Replace(" ", "");
            // load trimmed and white space removed string 
            txtCreditCard.Text = CCInput;

            if (!string.IsNullOrEmpty(CCInput))
            { 
                if (CCInput.Substring(0, 1)=="4") // Visa always starts with 4 in Canada     
                    isValid = Regex.IsMatch(CCInput, CCRegex);
                else if(CCInput.Substring(0, 1) == "5") // MC always starts with 5 in Canada
                    isValid = Regex.IsMatch(CCInput, CCRegex);
            }
 
            return isValid;
        }
        private bool ValidateExpDate()
        {
            bool dateValid = false;
            string expDateRegex = @"(0[1-9]|10|11|12)/20[0-9]{2}$";           
            string expDateInput = txtExpDate.Text.Trim();
            expDateInput = expDateInput.Replace(" ", "");
            // load trimmed and white space removed string 
            txtExpDate.Text = expDateInput;

            if (!string.IsNullOrEmpty(expDateInput))
                dateValid = Regex.IsMatch(expDateInput, expDateRegex);

            return dateValid;
        }
        private void CalculateTotals()
        {
            decimal total = 0;
            for (int i = 0; i < cart.Count; i++)
                total += cart[i].Package.PkgBasePrice;

            lblSubtotal.Text = total.ToString("c");
            lblTax.Text = (total * TAX).ToString("c");
            lblGrandTotal.Text = (total * (1.0m+TAX)).ToString("c");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("availablePackages.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");
        }
    }
}