using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace leaphajp_InClass20240409
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (!IsPostBack)
            {
                // this should only run once when the page is initially loaded in the browser
                lbFruits.Items.Add("Strawberry");
            }
        }
        // I need an event that will run when the user,
        // in their browser selects a fruit from the list box
        // "event-driven" programming.
        // Our event is the user selected an item from the list box
        protected void lbFruits_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this code runs when the user selects a new iten from the lbFruits List Box
            // copy the currently selected item from the list box into our label
            lblChosenFruit.Text = lbFruits.SelectedValue;
        }
    }
}