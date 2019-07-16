using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EBV
{
    public partial class Guest16Bit : System.Web.UI.Page
    {
        BLL.BLL obj = new BLL.BLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBit_Click(object sender, EventArgs e)
        {
            char[] a = new char[16];
            Random rnd = new Random();
            for (int i = 0; i < 16; i++)
            {
                int x, t = rnd.Next(0, 2);
                if (t == 0)
                {
                    x = rnd.Next(65, 91);
                    a[i] = Convert.ToChar(x);

                }
                else
                {
                    x = rnd.Next(48, 58);
                    a[i] = Convert.ToChar(x);
                }
            }
            string temp = new string(a);
            int id = int.Parse(Session["GuestGid"].ToString());
            if (obj.checkThirdParty(id))
            {
                if (obj.update16bit(temp, id))
                {
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Sucessfully Generated')", true);
                    txtBit.Text = temp;
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Error in Generating 16 bit')", true);
                }
            }
            else
            {
                if (obj.insertThird(id, temp))
                {
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Sucessfully Generated')", true);
                    txtBit.Text = temp;
                    lblGuest.Text = "Submit the above 16-bit Code to the registered Verification centre";
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Error')", true);
                }
            }
        }
    }
}