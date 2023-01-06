using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EBV
{
    public partial class AdminMail : System.Web.UI.Page
    {
        BLL.BLL obj = new BLL.BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCompanies();
        }

        private void LoadCompanies()
        {
            DataTable tab = obj.getRegister();
            if (tab.Rows.Count > 0)
            {
                gvRegister.DataSource = tab;
                gvRegister.DataBind();

            }
            else
            {
                gvRegister.Controls.Clear();
                lblMsg.Text = "No new request from companies";
            }
        }
        string temp;
        protected void lnkAdd_Click(object sender, EventArgs e)
        {
             GridViewRow gvr = (GridViewRow)((LinkButton)sender).Parent.Parent;
           Session["cName"]= gvr.Cells[0].Text;
           temp = gvr.Cells[0].Text;
           if (obj.deleteRegister(temp))
           Response.Redirect("AdminHome.aspx");
           
        }

    }
}