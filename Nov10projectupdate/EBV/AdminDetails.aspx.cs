using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EBV
{
    public partial class AdminDetails : System.Web.UI.Page
    {
        BLL.BLL obj = new BLL.BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCompanies();
        }

        private void LoadCompanies()
        {
            DataTable tab = obj.getCompany();
            if (tab.Rows.Count > 0)
            {
                gvDetails.DataSource = tab;
                gvDetails.DataBind();

            }
            else
            {
                gvDetails.Controls.Clear();
                lblMsg.Text = "Companies are not yet added";
            }
            tab = obj.getCmpEmpCount();
            lbl.Text = "Present Working Details";
            if (tab.Rows.Count > 0)
            {
                
                gvEmp.DataSource = tab;
                gvEmp.DataBind();

            }
            else
            {
                gvEmp.Controls.Clear();
                lblMsg.Text = "Companies are not yet added";
            }
        }
    }
}