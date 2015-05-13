using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace comp2007_lesson2_wed
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if the form wans't subitted
            if(!IsPostBack)
            {
                lblMessage.Text = "";
            }
        }

        protected void btnCopyText_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtMessage.Text;
            btnCopyText.Enabled = false;
        }

        protected void btnShowSelection_Click(object sender, EventArgs e)
        {
            lblToppings.Text = "";
            //loop through the list of checkboxes
            foreach (ListItem topping in cblTopping.Items)
            {
                //check if the current topping is checked or not
                if (topping.Selected)
                {
                    lblToppings.Text += topping.Text + " ";

                }
            }

            lblSize.Text = ddlSize.SelectedItem.Text;
        }

        protected void addTopping()
        {
            foreach (ListItem topping in cblTopping.Items)
            {
                //check if the current topping is checked or not
                if (topping.Selected)
                {
                    lblToppings.Text += topping.Text + " ";

                }
            }
        }

    }
}