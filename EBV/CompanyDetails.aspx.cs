using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EBV
{
    public partial class CompanyDetails : System.Web.UI.Page
    {
        BLL.BLL obj = new BLL.BLL();
        string temp;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["company"] != null)
            {
                temp = Convert.ToString(Session["company"]);
            }
            LoadCompanies();
            
        }
        private void LoadCompanies()
        {
            DataTable tab = obj.getCompanyDetails(temp);
            if (tab.Rows.Count > 0)
            {
                gvCompany.DataSource = tab;
                gvCompany.DataBind();

            }
            else
            {
                gvCompany.Controls.Clear();
                lblMsg.Text = "Company Details not yet added";
            }

        }
        static int id;
        protected void lnkEdit_Click(object sender, EventArgs e)
        {
            GridViewRow gvr = (GridViewRow)((LinkButton)sender).Parent.Parent;
            id = int.Parse(((LinkButton)sender).CommandArgument);
            txtNo.Text = gvr.Cells[1].Text;
            txtAddress.Text = gvr.Cells[2].Text;
            txtWebsite.Text = gvr.Cells[3].Text;
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (obj.updateCompanyDetails(id, Convert.ToInt32( txtNo.Text), txtAddress.Text, txtWebsite.Text))
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Sucessfully Updated')", true);
                txtNo.Text = "";
                txtAddress.Text = "";
                txtWebsite.Text = "";
                LoadCompanies();

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Updation Failed!!')", true);
            }
        }
    }
}