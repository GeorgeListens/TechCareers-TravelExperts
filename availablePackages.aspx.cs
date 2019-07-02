using mySQL.Packages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelExpertsFinal
{
    public partial class availablePackages : System.Web.UI.Page
    {
        private Packages selectedPackage;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = GridView1.SelectedRow.Cells[1].Text;

            selectedPackage = PackagesDB.GetPackage(Convert.ToInt16(id));

            Page.Validate();
            // Next add them to the cart which is a session variable and thus global to
            // all the web forms
            if (Page.IsValid)
            {
                CartItemList cart = CartItemList.GetCart();
                CartItem cartItem = cart[selectedPackage.PackageId];

                //if item isn’t in cart, add it; otherwise, increase its quantity
                if (cartItem == null)
                {
                    cart.AddItem(selectedPackage, 1);
                }
                else
                {
                    cartItem.AddQuantity(1);
                }

            }


        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Cart.aspx");
        }
    }
}