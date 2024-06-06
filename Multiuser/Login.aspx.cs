using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Multiuser
{
    public partial class Login : System.Web.UI.Page
    {
        connectioncls ob = new connectioncls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
           {
            string str = $"select count(Reg_ID) from Login_tab where username='{TextBox1.Text}' and password='{TextBox2.Text}'";
            string cid = ob.fn_scalar(str);
            //int cid1 = Convert.ToInt32(cid);
            if (cid == "1")
            {
                string str1= $"select Reg_ID from Login_tab where username='{TextBox1.Text}' and password='{TextBox2.Text}'";
                string regid = ob.fn_scalar(str1);
                Session["userid"] = regid;
                string str2=$"select Log_type from Login_tab where username='{TextBox1.Text}' and password='{TextBox2.Text}'";
                string usertype = ob.fn_scalar(str2);
                if(usertype== "admin")
                {
                    Response.Redirect("viewadminprofile.aspx");
                }
                else if(usertype== "user")
                {
                    Label3.Text = "user";
                }

            }
        }
    }
}