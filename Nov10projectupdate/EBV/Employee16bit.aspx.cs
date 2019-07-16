using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EBV
{
    public partial class Employee16bit : System.Web.UI.Page
    {
        BLL.BLL obj=new BLL.BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnBit_Click(object sender, EventArgs e)
        {
            char[] a=new char[16];
            Random rnd = new Random();
            for (int i = 0; i < 16; i++)
            {
                int x,t = rnd.Next(0,2);
                if (t == 0)
                {
                    x = rnd.Next(65, 91);
                    a[i] = Convert.ToChar(x);

                }
                else
                {
                    x = rnd.Next(48,58);
                    a[i] = Convert.ToChar(x);
                }
            }
            string temp = new string(a);
            string shri = Convert.ToString(Session["eid"]);
            int eid = int.Parse(shri);
            if (obj.checkEid(eid))
            {
                //if (obj.checkSet(temp,eid))
                //{
                //    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Sucessfully Generated')", true);
                //    txtBit.Text = temp;
                //}
                //else
                //{
                //    ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Error in Generating 16 bit')", true);
                //}
                obj.deleteBit(eid);
            }
            if (obj.setBit(eid, temp))
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Sucessfully Generated')", true);
                txtBit.Text = temp;
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "alert", "alert('Error in Generating 16 bit')", true);
            }
        }
    }
}