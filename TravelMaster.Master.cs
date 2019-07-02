using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelExpertsFinal
{
    public partial class TravelMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["userEmail"] != null)
            {
                emailLabel.Text = Session["userEmail"].ToString();
            }
                
        }
    }
}