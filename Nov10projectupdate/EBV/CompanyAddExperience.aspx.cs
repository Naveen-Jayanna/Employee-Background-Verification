using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace EBV
{
    public partial class CompanyAddExperience : System.Web.UI.Page
    {
        BLL.BLL obj = new BLL.BLL();
        static int id1 = 0;
        static int cid = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            cid = Convert.ToInt32(Session["cid"]);
            LoadEmployeeexp();
        }
        private void LoadEmployeeexp()
        {
            id1 = Convert.ToInt32(Session["cid"]);
            DataTable tab = obj.getExperienceByCid(id1);
            if (tab.Rows.Count > 0)
            {
                gvEmployee.DataSource = tab;
                gvEmployee.DataBind();

            }
            else
            {
                gvEmployee.Controls.Clear();
                lblMsg.Text = "Employees are not yet added";
            }
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
                    int cid = Convert.ToInt32(Session["cid"]);
            if (btnadd.Text == "Add")
            {

                
                //if (obj.InsertExperience(txtDom.Text, txtProj.Text, Convert.ToInt32(txtnoy.Text), txtdesc.Text, txtcproj.Text, cid))
                //{
                //    lblMsg.Text = "";
                //    LoadEmployeeexp();
                //    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Employee Added Sucessfully')", true);
                //    btnadd.Text = "Add";
                //    txtDom.Text = "";
                //    txtProj.Text = "";
                //    txtnoy.Text = "";
                //    txtdesc.Text = "";
                //    txtcproj.Text = "";
                  
                //}
                //else
                
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Please Select an employee to edit')", true);
                
            }
            else
            {
                if (obj.UpdateExperience(txtDom.Text, txtProj.Text, Convert.ToInt32(txtnoy.Text), txtdesc.Text, txtcproj.Text, id))
                {
                    lblMsg.Text = "";
                    LoadEmployeeexp();
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Employee Updated Sucessfully')", true);
                    btnadd.Text = "Add";
                    txtDom.Text = "";
                    txtProj.Text = "";
                    txtnoy.Text = "";
                    txtdesc.Text = "";
                    txtcproj.Text = "";
                    

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
            txtDom.Text = gvr.Cells[1].Text;
            txtProj.Text = gvr.Cells[2].Text;
            txtnoy.Text = gvr.Cells[3].Text;
            txtdesc.Text = gvr.Cells[4].Text;
            txtcproj.Text = gvr.Cells[5].Text;
           
            btnadd.Text = "UPDATE";
        }

       
    }
}