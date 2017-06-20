using System;
using System.Web.UI;
using WebApplication14;
using System.Linq;

namespace WebApplication14
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // Retrieving the Session variable from the default.aspx page and assigning it to labels in Default.aspx

            fname.Text = Session["FirstName"].ToString();

             lname.Text = Session["LastName"].ToString();
        }

        protected void viewDetails_Click(object sender, EventArgs e)
        {

            GridView1.DataSource = StudentDatabase.StudentList();
            GridView1.DataBind();
              
        }

        protected void GridView1_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {

            var studentList = StudentDatabase.StudentList();

            studentList.RemoveAll((x) => x.FirstName == GridView1.DataKeys[e.RowIndex].Values[0].ToString());

            GridView1.DataSource = studentList;

            GridView1.DataBind();

        }

        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {

            GridView1.DataSource = StudentDatabase.StudentList();


        }

     
    }
}