using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Content_Management_System
{
    public class PageDB
    {
        private static string User { get { return "root"; } }
        private static string Password { get { return "root"; } }
        private static string Database { get { return "cms"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }

        //this is our connection stirng 
        private static string ConnectionString { 
            get
            {
                return "server =" + Server
                    + ";user =" + User
                    + ";database =" + Database
                    + ";port=" + Port 
                    + ";password=" + Password;

            } 
        }
        //create a public stirng to execute query where list is for all columns and inside it dictionary is
        // for row inside coloumns.
        //list query is for query 
        public List<Dictionary<String,String>> List_Query(string query)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);

            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();
            

            //here try is for start connection
            try
            {
                Debug.WriteLine("Connection Initialized...");
                Debug.WriteLine("Attempting to execute query " + query);

                //open the database connection.
                Connect.Open();

                //query for a connection
                MySqlCommand cmd = new MySqlCommand(query, Connect);

                // take the resultset
                MySqlDataReader resultset = cmd.ExecuteReader();

                //this is for every row in the resultset
                while(resultset.Read())
                {
                    Dictionary<String, String> Row = new Dictionary<String, String>();

                    //now for every column in the row
                    for (int i=0; i< resultset.FieldCount; i++)
                    {
                        Row.Add(resultset.GetName(i), resultset.GetString(i));

                    }
                    ResultSet.Add(Row);

                }//end of while
                resultset.Close();


            }//end of try
            //if  try is not working then catch is working
            catch(Exception ex)
            {
                Debug.WriteLine("Something went wrong in the  List_Query Method!!");
                Debug.WriteLine(ex.ToString());

            }

            Connect.Close();
            Debug.WriteLine("Database terminated...........");

            return ResultSet;

        }

        public void AddPage(Page_Class new_http_page)
        {
            string query = "insert into HTTP_PAGE(TITLE,BODY,AUTHOR_ID,CREATED_DATE) VALUES ('{0}','{1}','{2}','{3}')";
            //UPPER STRING FOR QUERY AND VALUES IN CURLY BRACES TO REFER THESE VALUES;
            query = String.Format(query, new_http_page.GetTitle(), new_http_page.GetBody(),new_http_page.GetAuthorNumber(), new_http_page.GetCreatedDate().ToString("yyyy/mm/dd"));

            //now for sql connection
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);

            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();
                //here excute non query for creating updating and delete 
                //other then this we are using excute reder for read the things

            }
            catch(Exception ex)
            {
                Debug.WriteLine("something is wrong here");
                Debug.WriteLine(ex.ToString());
            }
            Connect.Close();
        }

        //here because we define the class thats why we mention here
        //otherwise we have to use dictionary method.
        public Page_Class FindPage(int pageid)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);

            Page_Class page_result = new Page_Class();

            try
            {
                string query = "select PAGE_ID,TITLE, BODY, concat(first_name, ' ', last_name) as AUTHOR_NAME, CREATED_DATE from HTTP_PAGE join AUTHOR ON HTTP_PAGE.AUTHOR_ID = AUTHOR.AUTHOR_ID where PAGE_ID =" + pageid;
                Debug.WriteLine("connection initialized!!! i am trying to find a page with id "+ pageid);

                Connect.Open();

                MySqlCommand cmd = new MySqlCommand(query, Connect);

                MySqlDataReader resultset = cmd.ExecuteReader();

                List<Page_Class> HTTP_Page = new List<Page_Class>();

                while (resultset.Read())
                {
                    //info we stored for single vlaue
                    Page_Class currenthttp_page = new Page_Class();

                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        string name = resultset.GetName(i);
                        string value = resultset.GetString(i);

                        Debug.WriteLine("Attempting to transfer " + name + "data of" + value);

                        switch (name)
                        {
                            case "TITLE":
                                currenthttp_page.SetTitle(value);
                                break;
                            case "BODY":
                                currenthttp_page.SetBody(value);
                                break;
                            case "AUTHOR_NAME":
                                currenthttp_page.SetAuthorNumber(value);
                                break;
                            case "CREATED_DATE":
                                currenthttp_page.SetCreatedDate(DateTime.Parse(value));
                                break;
                        }

                    }
                    HTTP_Page.Add(currenthttp_page);



                }
                page_result = HTTP_Page[0];

            }
            catch (Exception ex)
            {
                Debug.WriteLine("something went wrong for this  page");
                Debug.WriteLine(ex.ToString());

            }
            Connect.Close();
            Debug.WriteLine("Database terminated!!!");

            return page_result;

        }
        public void UpdatePage(int pageid, Page_Class new_page)
        {
            string query = "update HTTP_PAGE set TITLE='{0}', BODY='{1}',AUTHOR_ID='{2}' WHERE PAGE_ID='{3}' ";
            query = String.Format(query, new_page.GetTitle(), new_page.GetBody(),new_page.GetAuthorNumber(), pageid);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);

            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();
                Debug.WriteLine("Excueted query " +query);

            }
            catch(Exception ex)
            {
                Debug.WriteLine("something went wrong in update method");
                Debug.WriteLine(ex.ToString());

            }
            Connect.Close();
        }
        public void DeletePage(int pageid)
        {
            string removepage = "delete from HTTP_PAGE where pageid ='{0}'";
            removepage = String.Format(removepage, pageid);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd_removepage = new MySqlCommand(removepage, Connect);

            try
            {
                Connect.Open();
                cmd_removepage.ExecuteNonQuery();
                Debug.WriteLine("Excute query" + cmd_removepage);

            }
            catch(Exception ex)
            {
                Debug.WriteLine("Something went wrong while deleting this page!");
                Debug.WriteLine(ex.ToString());
            }
            Connect.Close();

        }
    }

   

    
}