using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EBV
{
    public partial class CompanyVacancy : System.Web.UI.Page
    {
        BLL.BLL obj = new BLL.BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadVacancy();
            if (!IsPostBack)
            {
                ddlCompanyVacancy.DataSource = obj.getCategory();
                ddlCompanyVacancy.DataTextField = "Category";
                ddlCompanyVacancy.DataValueField = "CatId";
                ddlCompanyVacancy.DataBind();
                ddlCompanyVacancy.Items.Insert(0, "SELECT");
            }
        }

        protected void ddlCompanyVacancy_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCV.Text = "Enter the vacancy";

        }

        protected void btnCV_Click(object sender, EventArgs e)
        {
            obj.updatecategoryvacancy(int.Parse(txtCV.Text), int.Parse(ddlCompanyVacancy.SelectedValue));
            txtCV.Text = "";
            LoadVacancy();

        }

        protected void LoadVacancy()
        {

            DataTable tab = obj.getCategory();
            if (tab.Rows.Count > 0)
            {
                gvVacancy.DataSource = tab;
                gvVacancy.DataBind();

            }
            else
            {
                gvVacancy.Controls.Clear();
                lblMsg1.Text = "No Vacancies";
            }
        }
    }
}