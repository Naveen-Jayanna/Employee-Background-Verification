using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace EBV
{
    public partial class CompanyCategory : System.Web.UI.Page
    {
        BLL.BLL obj = new BLL.BLL();
        static int id=0,cid=0;
        static string name;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Int32.Parse(Session["cid"].ToString());
            name = Session["company"].ToString();
            LoadCategories();
        }
        private void LoadCategories()
        {
            DataTable tab = obj.catNested(name);
            if (tab.Rows.Count > 0)
            {
                gvCategory.DataSource = tab;
                gvCategory.DataBind();

            }
            else
            {
                gvCategory.Controls.Clear();
                lblMsg.Text = "Categories are not yet added";
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text == "Add")
            {
                if (obj.insertCategory(txtCategory.Text,id))
                {
                    lblMsg.Text = "";
                    LoadCategories();
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Category Added Sucessfully')", true);
                    btnSubmit.Text = "Add";
                    txtCategory.Text = "";
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Operation Failed')", true);
                }
            }
            else
            {
                if (obj.updateCategory(txtCategory.Text,cid))
                {
                    lblMsg.Text = "";
                    LoadCategories();
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Category Updated Sucessfully')", true);
                    btnSubmit.Text = "Add";
                    txtCategory.Text = "";
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Updation Failed!!')", true);
                }
            }
        }

        protected void lnkEdit_Click(object sender, EventArgs e)
        {
            GridViewRow gvr = (GridViewRow)((LinkButton)sender).Parent.Parent;
            cid = int.Parse(((LinkButton)sender).CommandArgument);
            txtCategory.Text = gvr.Cells[0].Text;
            btnSubmit.Text = "UPDATE";
        }

        protected void lnkDelete_Click(object sender, EventArgs e)
        {
            GridViewRow gvr = (GridViewRow)((LinkButton)sender).Parent.Parent;
            cid = int.Parse(((LinkButton)sender).CommandArgument);
            if (obj.deleteCategory(cid))
            {
                LoadCategories();
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Sucessfully Deleted')", true);
                btnSubmit.Text = "Add";
                txtCategory.Text = "";

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Deletion Failed!!')", true);
            }
        }

    }
}