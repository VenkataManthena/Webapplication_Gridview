using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication14
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page Load Event executed" + "<br/>");
            if(!IsPostBack)
            {
                List<string> statesList = StudentDatabase.StatesList();
                state.DataSource = statesList;
                state.DataBind();
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                TextWriter textWriter = new StreamWriter("E:\\student.txt", true);
                textWriter.WriteLine(fname.Text);
                textWriter.WriteLine(lname.Text);
                textWriter.WriteLine(dob.Text);
                textWriter.WriteLine(university.Text);
                textWriter.WriteLine(gpa.Text);
                textWriter.WriteLine(major.Text);
                textWriter.Close();

                Response.Write("Submit_Click executed");

                List<string> statesList = StudentDatabase.StatesList();
                state.DataSource = statesList;
                state.DataBind();
            }

            confirm.Visible = true;

            Response.Redirect("~/Contact.aspx?FirstName=" + fname.Text + "&LastName=" + lname.Text)
                ;

            
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page_PreInit Event executed" + "<br/>");

        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page_Init Event executed" + "<br/>");
        }

        protected override void OnPreLoad(EventArgs e)
        {


            Response.Write("PreLoad Event executed" + "<br/>");
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("Load Complete event executed" + "<br/>");
        }

        protected override void OnSaveStateComplete(EventArgs e)
        {
            Response.Write("SaveStateComplete executed" + "<br/>");
        }

        protected void Page_UnLoad(object sender, EventArgs e)

        {

            //Response.Write("");


        }
        
        protected void SendDataTo_Form(object sender, EventArgs e)
        {

           

            Session["FirstName"] = fname.Text;
            Session["LastName"] = lname.Text;

            Response.Redirect("~/Default.aspx");
        }

        protected void state_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<string> statesList = StudentDatabase.StatesList();
            state.DataSource = statesList;
            state.DataBind();

            switch (state.Text)
            {

                case "Florida":
                    List<string> floridaCities = new List<string>();
                    floridaCities.Add("Tampa");
                    floridaCities.Add("Orlando");
                    floridaCities.Add("Gainsville");


                    if (!IsPostBack)
                    {
                        city.DataSource = floridaCities;
                        city.DataBind();
                    }


                    break;

            }
        }

        protected void city_SelectedIndexChanged(object sender, EventArgs e)
        {

           

        }
         }
        
}