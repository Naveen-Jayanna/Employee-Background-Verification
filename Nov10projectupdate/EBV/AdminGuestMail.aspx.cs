using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EBV
{
    public partial class AdminGuestMail : System.Web.UI.Page
    {
        BLL.BLL obj = new BLL.BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGuest();
        }

        private void LoadGuest()
        {
            DataTable tab = obj.getGuestByBit(0);
            if (tab.Rows.Count > 0)
            {
                gvGuest.DataSource = tab;
                gvGuest.DataBind();

            }
            else
            {
                gvGuest.Controls.Clear();
                lblMsg.Text = "No new request from guest";
            }
        }
        string temp;
        protected void lnkAdd_Click(object sender, EventArgs e)
        {
            
            GridViewRow gvr = (GridViewRow)((LinkButton)sender).Parent.Parent;
            Session["gid"] = gvr.Cells[0].Text;
            Session["Guest"] = gvr.Cells[1].Text;
                Response.Redirect("AdminHome.aspx");

        }
    }
}