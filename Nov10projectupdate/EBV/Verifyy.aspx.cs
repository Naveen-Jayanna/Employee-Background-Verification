using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EBV
{
    public partial class Verifyy : System.Web.UI.Page
    {
        BLL.BLL objbll = new BLL.BLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVerifyy_Click(object sender, EventArgs e)
        {
            if (btnVerifyy.Text == "Verifyy")
            {
                string temp = txtBit.Text;
                if (objbll.checkEmployee16bit(temp))
                {
                    DataTable tab = objbll.getId(temp);
                    DataRow row = tab.Rows[0];
                    int empId = int.Parse(row["EmpId"].ToString());
                    Session["newemp"] = empId;
                    DataTable q = objbll.getName(empId);
                    DataRow w = q.Rows[0];
                    Session["name"] = w["EmpName"].ToString();
                    DataTable x = objbll.experienceVerify(empId);
                    tab = objbll.getVerify(empId);
                    if (tab.Rows.Count > 0)
                    {
                        lblMsg.Text = "MEDICAL TEST";
                        gvVerify.DataSource = tab;
                        gvVerify.DataBind();

                    }

                    else
                    {
                        gvVerify.Controls.Clear();
                        lblMsg.Text = "Invalid 16 bit number";
                    }
                    if (x.Rows.Count > 0)
                    {
                        lblExp.Text = "EXPERIENCE";
                        gvExp.DataSource = x;
                        gvExp.DataBind();
                        Addemployee();
                    }
                    else
                        lblExp.Text = "NO EXPERIENCE FOUND";
                }
                else
                {
                    DataTable tab = objbll.getThird(temp);
                    DataRow row = tab.Rows[0];
                    int guestId = int.Parse(row["GuestId"].ToString());
                    if (tab.Rows.Count > 0)
                    {
                        DataTable q = objbll.getGuestName(guestId);
                        DataRow w = q.Rows[0];
                        Session["name"] = w["GuestName"].ToString();
                        gvVerify.DataSource = tab;
                        gvVerify.DataBind();
                        lblExp.Text = "NO experience. Fresher.";
                        Addemployee();
                    }
                    else
                    {

                        gvVerify.Controls.Clear();
                        lblMsg.Text = "Invalid 16 bit number";
                    }
                }
            }
            else
            {
                Response.Redirect("CompanyAdd.aspx");
            }
        }
        private void Addemployee()
        {
            lblTop.Text = "Do you want to hire the employee?";
            btnVerifyy.Text = "Add";
        }
    }
}