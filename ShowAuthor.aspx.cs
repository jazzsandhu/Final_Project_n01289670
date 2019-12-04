using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Content_Management_System
{
    public partial class ShowAuthor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "select * from AUTHOR";
            var db = new PageDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                author_result.InnerHtml += "<div class=\"listitem\">";

                string authorId = row["AUTHOR_ID"];

                string Fname = row["FIRST_NAME"];
                author_result.InnerHtml += "<div class=\"col5\">" + Fname + "</div>";

                string Lname = row["LAST_NAME"];
                author_result.InnerHtml += "<div class=\"col5\">" + Lname + "</div>";

                string Anumber = row["AUTHOR_NUMBER"];
                author_result.InnerHtml += "<div class=\"col5\">"+ Anumber + "</div>";

                string Email = row["EMAIL"];
                author_result.InnerHtml += "<div class=\"col5\">" + Email + "</div>";

                author_result.InnerHtml += "</div>";


            }
        }
    }
}