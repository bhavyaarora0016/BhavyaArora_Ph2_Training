using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webapp1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if(TextBox2.Text == TextBox1.Text+"@123")
            {
                Label2.Text = "Logged in successfully.";
            }
            else
            {
                Label2.Text = "Invalid user ID or password";
            }
        }
    }
}
