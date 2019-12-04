using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Content_Management_System
{
    public partial class Layout_page : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //firstly get access of db
            PageDB db = new PageDB();
            //now a function name to find the listitem in our dropdownlist
            FillPage(db);

        }
        protected void FillPage(PageDB db)
        {
            //create a query to run our dropdown.
            string query = "select * from HTTP_PAGE";
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String,String> row in rs)
            {
                //create stirng to get the values from database;
                string pgeTitle = row["TITLE"];
                string pgeid = row["PAGE_ID"];
                //define thsoe string into our listitem;
                ListItem pageoption = new ListItem(pgeTitle, pgeid);
                //now add these items into our dropdown list with its id;
                //page_list.Items.Add(pageoption);

            }

        }
    }
}