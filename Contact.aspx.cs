using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication14
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // Extracting the values from querystring and assigning it to the label fields in Contact Page //

            fname.Text = Request.QueryString["FirstName"];
       
            lname.Text = Request.QueryString["LastName"];
          
        }
    }
}