using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test
{
    public partial class Cart : System.Web.UI.Page
    {
        private CartItemList cart;
        protected void Page_Load(object sender, EventArgs e)
        {
            cart = CartItemList.GetCart();
            if (!IsPostBack) DisplayCart();
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


        protected void btnContinue_Click(object sender, EventArgs e)
        {
            Response.Redirect("availablePackages.aspx");
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            if(cart.Count<1) // nothing in cart
                Response.Redirect("availablePackages.aspx");
            else
                Response.Redirect("Checkout.aspx");// Checkout.aspx
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            if ((cart != null) && (cart.Count > 0))
            {
                if (lstCart.SelectedIndex > -1)
                {
                    // remove selected item from cart
                    cart.RemoveAt(lstCart.SelectedIndex);
                    this.DisplayCart();
                }
                else
                {
                    // if no item selected, notify user
                    lblMessage.Text = "Please select the item to remove";
                }
            }
            else
                lblMessage.Text = "cart is empty";
        }

        protected void btnEmpty_Click(object sender, EventArgs e)
        {
            //Empty cart and lstCart list box
            if (cart.Count > 0)
            {
                cart.Clear();
                lstCart.Items.Clear();
            }
        }

    }
}