using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EBV
{
    public partial class RegisterNew : System.Web.UI.Page
    {
        BLL.BLL obj = new BLL.BLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            if (obj.checkGuest(txtMail.Text))
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Request Already Received.Wait For Confirmation Mail')", true);
            }
            else if(obj.insertGuestData(txtName.Text,txtMail.Text,txtPhone.Text))
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Admin Notified.Wait For Confirmation Mail')", true);

            txtPhone.Text = "";
            txtMail.Text = "";
            txtName.Text = "";
        }
    }
}