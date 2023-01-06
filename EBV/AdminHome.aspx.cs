using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EBV
{
    public partial class AdminHome : System.Web.UI.Page
    {
        BLL.BLL obj = new BLL.BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCompanies();
            LoadGuest();            
            if (Session["cName"] != null)
            {
                txtCompany.Text =Convert.ToString(Session["cName"]);
            }
            else if (Session["Guest"] != null)
            {
                txtCompany.Text = Convert.ToString(Session["Guest"]);
            }

        }

        private void LoadCompanies()
        {
            DataTable tab = obj.getCompany();
            if (tab.Rows.Count > 0)
            {
                gvCompany.DataSource = tab;
                gvCompany.DataBind();

            }
            else
            {
                gvCompany.Controls.Clear();
                lblMsg.Text = "Companies are not yet added";
            }
        }
        private void LoadGuest()
        {
            DataTable tab = obj.getGuestByBit(1);
            if (tab.Rows.Count > 0)
            {
                gvGuest1.DataSource = tab;
                gvGuest1.DataBind();

            }
            else
            {
                gvGuest1.Controls.Clear();
                lblMsg.Text = "Guests are not yet added";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Session["Guest"] == null)
            {
                if (btnSubmit.Text == "Add")
                {
                    if (obj.Insertcompany(txtCompany.Text, txtmail.Text, txtPass.Text))
                    {
                        lblMsg.Text = "";
                        LoadCompanies();
                        ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Company Added Sucessfully')", true);
                        btnSubmit.Text = "Add";
                        txtCompany.Text = "";
                        txtmail.Text = "";
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Operation Failed')", true);
                    }
                }
                else
                {
                    if (obj.updateCompany(txtCompany.Text, txtmail.Text, txtPass.Text, id))
                    { 
                        lblMsg.Text = "";
                        LoadCompanies();
                        ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Company Updated Sucessfully')", true);
                        btnSubmit.Text = "Add";
                        txtCompany.Text = "";
                        txtmail.Text = "";
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Updation Failed!!')", true);
                    }
                }
            }
            else
            {
                if (btnSubmit.Text == "Add")
                {
                    int bit= 1;
                    if (int.Parse(Session["gid"].ToString()) > 0)
                    
                        id=int.Parse(Session["gid"].ToString());
                    
                    if (obj.updateGuest(txtmail.Text,txtPass.Text,bit,id))
                    {
                        lblMsg.Text = "";
                        LoadCompanies();
                        LoadGuest();
                        ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Request Added Sucessfully')", true);
                        btnSubmit.Text = "Add";
                        txtCompany.Text = "";
                        txtmail.Text = "";
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Operation Failed')", true);
                    }
                }
                else
                {
                    int bit = 1;
                    if (obj.updateGuest(txtmail.Text, txtPass.Text, bit, id))
                    {
                        lblMsg.Text = "";
                        LoadCompanies();
                        LoadGuest();
                        ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Request Updated Sucessfully')", true);
                        btnSubmit.Text = "Add";
                        txtCompany.Text = "";
                        txtmail.Text = "";
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Updation Failed!!')", true);
                    }
                }
            }
        }
        static int id = 0;
        protected void lnkEdit_Click(object sender, EventArgs e)
        {
            GridViewRow gvr = (GridViewRow)((LinkButton)sender).Parent.Parent;
            id = int.Parse(((LinkButton)sender).CommandArgument);
            txtCompany.Text = gvr.Cells[0].Text;
            txtmail.Text = gvr.Cells[1].Text;
            txtPass.Text = gvr.Cells[2].Text;
            btnSubmit.Text = "UPDATE";
        }

        protected void lbkDelete_Click(object sender, EventArgs e)
        {
            GridViewRow gvr = (GridViewRow)((LinkButton)sender).Parent.Parent;
            id = int.Parse(((LinkButton)sender).CommandArgument);
            if (obj.deleteGuest(id))
            {
                LoadCompanies();
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Sucessfully Deleted')", true);

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Deletion Failed!!')", true);
            }
        }
       
    }
}