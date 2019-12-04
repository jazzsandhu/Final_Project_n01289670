using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Content_Management_System
{
    public partial class NavClass : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            page_list1.InnerHtml = "";
            PageDB db = new PageDB();
            List_Current_Pages(db);

        }
        protected void List_Current_Pages(PageDB db)
        {
            string query = "select PAGE_ID,AUTHOR_NUMBER, TITLE, BODY, concat(first_name,' ',last_name) as AUTHOR_NAME, CREATED_DATE from HTTP_PAGE join AUTHOR ON HTTP_PAGE.AUTHOR_ID = AUTHOR.AUTHOR_ID";
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String,String> row in rs)
            {
                string pageid = row["PAGE_ID"];
                string title = row["TITLE"];
                page_list1.InnerHtml += "<a href=\"Details_of_page.aspx?pageid=" + pageid + "\">" + title + "............" + "</a>";
                
            }
        }
    }
}