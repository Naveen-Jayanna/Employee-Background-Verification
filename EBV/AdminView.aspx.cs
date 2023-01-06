using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EBV
{
    public partial class AdminView : System.Web.UI.Page
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
                gvView.DataSource = tab;
                gvView.DataBind();

            }
            else
            {
                gvView.Controls.Clear();
                lblMsg.Text = "Companies are not yet added";
            }
        }
    }
}