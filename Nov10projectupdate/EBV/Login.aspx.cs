using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EBV
{
    public partial class Login : System.Web.UI.Page
    {
        BLL.BLL objbll = new BLL.BLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string User = Request.Form["email"];
            string Pass = Request.Form["password"];
            if (objbll.Adminlogin(User, Pass))
            {
                if (User.Split('@')[0] == "Admin")
                    Response.Redirect("AdminMail.aspx");
                else
                    Response.Redirect("HospitalHome.aspx");
            }
            else if (objbll.companyLogin(User, Pass))
            {
                Session["company"] = User.Split('@')[0];
                string cname = Convert.ToString(Session["company"]);
                DataTable c = objbll.getCname(cname);
                DataRow row = c.Rows[0];
                Session["cid"] = Int32.Parse(row["CmpnyId"].ToString());
                Response.Redirect("CompanyDetails.aspx");
            }
            else if (objbll.employeeLogin(User, Pass))
            {
                Session["employee"] = User.Split('@')[0];
                string ename = Convert.ToString(Session["employee"]);
                DataTable c = objbll.getEidByName(ename);
                DataRow row = c.Rows[0];
                Session["eid"] = Int32.Parse(row["EmpID"].ToString());
                Response.Redirect("EmployeeDetails.aspx");
            }
            else if (objbll.guestLogin(User, Pass))
            {
                Session["GuestName"] = User;
                string guest = Convert.ToString(Session["GuestName"]);
                DataTable c = objbll.getGuestByMail(User);
                DataRow row = c.Rows[0];
                Session["GuestGid"] = Int32.Parse(row["GuestId"].ToString());
                Response.Redirect("GuestHome.aspx");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Invalid User')", true);
            }
        }
    }
}


