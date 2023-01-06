using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EBV
{

    public partial class Landing : System.Web.UI.MasterPage
    {
        BLL.BLL objbll = new BLL.BLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable ad = objbll.getAdmin();
            //if ("Admin" == ddlLogin.SelectedItem.Text) if (tbUserName.Text == ad.Rows[0][0]) if (tbPassword.Text == ad.Rows[0][1])
            //            Response.Redirect("sample.aspx");
        }
    }
}
