using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EBV
{
    public partial class RegisterCompany : System.Web.UI.Page
    {
        BLL.BLL objbll = new BLL.BLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            if (objbll.checkRegister(txtComapny.Text))
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Request Already Received.Wait For Confirmation Mail')", true);
            }
            else if (objbll.insertRegister(txtComapny.Text, txtMail.Text, txtPhone.Text))
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Admin Notified.Wait For Confirmation Mail')", true);               
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Company Name not yet added.Contact Admin')", true);                
            }
            txtPhone.Text = "";
            txtMail.Text = "";
            txtComapny.Text = "";
        }

        

    }
}