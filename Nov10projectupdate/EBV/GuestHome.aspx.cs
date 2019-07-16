using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EBV
{
    public partial class GuestHome : System.Web.UI.Page
    {
        BLL.BLL obj = new BLL.BLL();
        static int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlcompany.DataSource = obj.getCompany();
                ddlcompany.DataTextField = "CmpnyName";
                ddlcompany.DataValueField = "CmpnyId";
                ddlcompany.DataBind();
                ddlcompany.Items.Insert(0, "SELECT");

            }

        }

        protected void LoadEmployeeVacancy()
        {
            DataTable tab = obj.getCatById(id);
            if (tab.Rows.Count > 0)
            {
                lblcategory.Text = "Available Categories With Description";
                gvEVacancy.DataSource = tab;
                gvEVacancy.DataBind();

            }
            else
            {
                gvEVacancy.Controls.Clear();
                lblMsg1.Text = "No Vacancies";
            }
        }

        protected void lnkAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Guest16Bit.aspx");

        }

        protected void ddlcompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = int.Parse(ddlcompany.SelectedValue);
            LoadEmployeeVacancy();
        }
    }
}