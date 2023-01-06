using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EBV
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {

        BLL.BLL obj = new BLL.BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadEmployeeDetails();
        }

        private void LoadEmployeeDetails()
        {
            id = Int32.Parse(Session["eid"].ToString());
            DataTable tab = obj.getEmployeeById(id);
            if (tab.Rows.Count > 0)
            {
                gvEmployeeDetails.DataSource = tab;
                gvEmployeeDetails.DataBind();

            }
            else
            {
                gvEmployeeDetails.Controls.Clear();
                lblMsg.Text = " Personal details are not yet added";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["eid"]);


            if (btnSubmit.Text == "Update")
            {

                if (obj.updateEmployeeDetails(txtEmpName.Text, txtEmail.Text, txtEPass.Text, txtaddress.Text, txtAdhaar.Text, id))
                {
                    lblMsg.Text = "";
                    LoadEmployeeDetails();
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Changes Updated Sucessfully')", true);
                    btnSubmit.Text = "Update";
                    txtEmpName.Text = "";
                    txtEmail.Text = "";
                    txtEPass.Text = "";
                    txtaddress.Text = "";

                    txtAdhaar.Text = "";

                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Updation Failed!!')", true);
                }
            }
        }
        static int id = 0;
        protected void lnkEdit_Click(object sender, EventArgs e)
        {
            GridViewRow gvr = (GridViewRow)((LinkButton)sender).Parent.Parent;
            id = int.Parse(((LinkButton)sender).CommandArgument);
            txtEmpName.Text = gvr.Cells[1].Text;
            txtEmail.Text = gvr.Cells[2].Text;
            txtEPass.Text = gvr.Cells[3].Text;
            txtaddress.Text = gvr.Cells[4].Text;

            txtAdhaar.Text = gvr.Cells[5].Text;
            btnSubmit.Text = "Update";
        }

        protected void lbkDelete_Click(object sender, EventArgs e)
        {
            GridViewRow gvr = (GridViewRow)((LinkButton)sender).Parent.Parent;
            id = int.Parse(((LinkButton)sender).CommandArgument);
            if (obj.deleteEmployeeDetails(id))
            {
                LoadEmployeeDetails();
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Sucessfully Deleted')", true);

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Deletion Failed!!')", true);
            }
        }

    }
}