using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL3009;

namespace webapp1
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            dob.Text = Calendar1.SelectedDate.ToLongDateString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            string text = fname.Text;
            c.first_name = text;
            c.last_name = lname.Text;
            c.dob = Calendar1.SelectedDate;
            c.city = city.Text;
            c.state = state.Text;
            HttpCookie cookie = new HttpCookie("CustData");
            cookie.Expires = DateTime.Now.AddMinutes(15);
            cookie.Values.Add("fName", c.first_name);
            cookie.Values.Add("lName", c.last_name);
           cookie.Values.Add("dob1", c.dob.ToLongDateString());
            cookie.Values.Add("city1", c.city);
            cookie.Values.Add("state1", c.state);
            Response.Cookies.Add(cookie);
            Response.Write("Welcome  " + c.firstName);
            Response.Redirect("~/WelcomeAssign.aspx");
            
                
        }
    }
}
