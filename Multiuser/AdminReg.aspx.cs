using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Multiuser
{
    public partial class AdminReg : System.Web.UI.Page
    {
        connectioncls ob = new connectioncls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_ID) from Login_tab";
            string regid = ob.fn_scalar(sel);
            int reg_id;
            if (regid == "")
            { 
               reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                reg_id = newregid + 1;
            }
            string ins = "insert into admin values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "')";
            int i = ob.fn_nonquery(ins);
            if (i != 0)//i=1
            {
                string inslog = "insert into Login_tab values(" + reg_id + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','admin','active')";
                int j = ob.fn_nonquery(inslog);
            }
        }
    }
}