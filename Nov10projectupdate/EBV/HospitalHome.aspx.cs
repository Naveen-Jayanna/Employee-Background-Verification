using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EBV
{
    public partial class HospitalHome : System.Web.UI.Page
    {
        BLL.BLL objbll = new BLL.BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            loadRequest();
        }

        private void loadRequest()
        {
            DataTable tab = objbll.get16bit();
            if (tab.Rows.Count > 0)
            {
                gvRequest.DataSource = tab;
                gvRequest.DataBind();

            }
            else
            {
                gvRequest.Controls.Clear();
                lblMsg.Text = "No Requests Yet";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            String temp = tb16bit.Text;
            String a = ddlDrugtest.Text;
            String b = ddlCriminalrecords.Text;
            String c = ddlHealth.Text;
            if (objbll.updateThirdParty(a, b, c, temp, 1))
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Medical Report Updated Sucessfully ')", true);
                tb16bit.Text = "";
                ddlDrugtest.Text = "Select One";
                ddlCriminalrecords.Text = "Select One";
                ddlHealth.Text = "Select One";
                loadRequest();
            }
            else
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Medical Report could not be updated ')", true);


        }

        protected void lbTest_Click(object sender, EventArgs e)
        {
            GridViewRow gvr = (GridViewRow)((LinkButton)sender).Parent.Parent;
            int s = int.Parse((((LinkButton)sender).CommandArgument).ToString());
            tb16bit.Text = gvr.Cells[0].Text;
            loadRequest();
        }
    }
}