using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Content_Management_System
{
    public partial class HTTP_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            PageDB db = new PageDB();
            HTTP_PageInfo(db);

        }
        protected void HTTP_PageInfo(PageDB db)
        {
            page_result.InnerHtml = "";
            string query2 = "Select * from HTTP_PAGE";
            string query = "select PAGE_ID, TITLE, BODY, concat(first_name,' ',last_name) as AUTHOR_NAME, CREATED_DATE from HTTP_PAGE join AUTHOR ON HTTP_PAGE.AUTHOR_ID = AUTHOR.AUTHOR_ID";
            string searchkey = search_box.Text;
            if(searchkey != "")
            {
                query += "where TITLE LIKE '%" + searchkey + "%'";
                
            }
            
            
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                page_result.InnerHtml += "<div class=\"listitem\">";


                string pageid = row["PAGE_ID"];
                string pageTitle = row["TITLE"];
                page_result.InnerHtml += "<div class=\"col5\"><a href=\"Details_of_page.aspx?pageid=" + pageid + "\">" + pageTitle + "</a></div>";

                string pageBody = row["BODY"];
                page_result.InnerHtml += "<div class=\"col5\">" + pageBody + "</div>";

                string authorName = row["AUTHOR_NAME"];
                page_result.InnerHtml += "<div class=\"col5\">" + authorName + "</div>";

                string Created_date = row["CREATED_DATE"];
                page_result.InnerHtml += "<div class=\"col5\">" + Created_date + "</div>";

                var Edit = "<a href=\"UpdatePage.aspx?pageid=" + pageid + "\">" + "Edit" + "</a>";
               
                page_result.InnerHtml += "<div class=\"col5last\">"+ Edit+"</div>";

                page_result.InnerHtml += "</div>";

            }
        }
    }
}