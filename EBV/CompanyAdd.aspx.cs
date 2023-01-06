using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EBV
{
    public partial class CompanyAdd : System.Web.UI.Page
    {
        BLL.BLL obj = new BLL.BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            if (Session["name"] != null)
            {
                txtEmp.Text = Convert.ToString(Session["name"]);
            }
        }

        private void LoadEmployees()
        {
            DataTable tab = obj.getEmpByCid(Convert.ToInt32(Session["cid"]));
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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(Session["cid"]);
            int empid=Convert.ToInt32(Session["newemp"]);
            if (btnSubmit.Text == "Add")
            {
                if (obj.checkEmpById(empid))
                {
                    if (obj.updateNewEmployee(cid, txtmail.Text, txtPass.Text,empid))
                    {
                        lblMsg.Text = "";
                       LoadEmployees();
                        ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Employee Added Sucessfully')", true);
                        btnSubmit.Text = "Add";
                        txtEmp.Text = "";
                        txtmail.Text = "";
                        txtPass.Text = "";
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Hiring Failed')", true);
                    }
                }
                else
                {
                    Random r = new Random();
                    int EmployeeId = r.Next(1000, 9999);
                    if (obj.InsertEmployee(txtEmp.Text, txtmail.Text, txtPass.Text,cid,EmployeeId))
                    {
                        string pass = "pass";
                        int empId = EmployeeId;
                        obj.insertEmpVerify(empId, pass, pass, pass, pass);
                        lblMsg.Text = "";
                        LoadEmployees();
                        btnSubmit.Text = "Add";
                        txtEmp.Text = "";
                        txtmail.Text = "";
                        txtPass.Text = "";
                        if(obj.deleteGuestByName(Convert.ToString(Session["name"])))
                        {
                             ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Employee Added Sucessfully')", true);
                        }

                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Operation Failed')", true);
                    }
                }
            }
            else
            {
           
                if (obj.updateEmployee(txtEmp.Text, txtmail.Text, txtPass.Text, id))
                {
                    lblMsg.Text = "";
                    LoadEmployees();
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Employee Updated Sucessfully')", true);
                    btnSubmit.Text = "Add";
                    txtEmp.Text = "";
                    txtmail.Text = "";
                    txtPass.Text = "";
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('operation Failed!!')", true);
                }
            }
        }
        static int id = 0;
        protected void lnkEdit_Click(object sender, EventArgs e)
        {
            GridViewRow gvr = (GridViewRow)((LinkButton)sender).Parent.Parent;
            id = int.Parse(((LinkButton)sender).CommandArgument);
            txtEmp.Text = gvr.Cells[0].Text;
            txtmail.Text = gvr.Cells[1].Text;
            txtPass.Text = gvr.Cells[2].Text;
            btnSubmit.Text = "UPDATE";
        }

        //protected void lbkDelete_Click(object sender, EventArgs e)
        //{
        //    GridViewRow gvr = (GridViewRow)((LinkButton)sender).Parent.Parent;
        //    id = int.Parse(((LinkButton)sender).CommandArgument);
        //    if (obj.deleteEmployee(id))
        //    {
        //        LoadEmployees();
        //        ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Sucessfully Deleted')", true);

        //    }
        //    else
        //    {
        //        ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Deletion Failed!!')", true);
        //    }
        //}

    }
}