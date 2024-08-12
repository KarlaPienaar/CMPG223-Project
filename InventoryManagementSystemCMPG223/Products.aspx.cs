﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagementSystemCMPG223
{
    public partial class Products : System.Web.UI.Page
    {
        

        //DEPENDENCIES

        string ConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\InventoryManagementSystemDB.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataSet ds;


        protected void Page_Load(object sender, EventArgs e)
        {
            //IF NOT POSTBACK
            if (!IsPostBack)
            {
                GetProducts("select * from producttable");

            }
        }

        //CreateProduct cp = new CreateProduct();
        //cp.GetProducts(query);




        //RETRIEVALS
        //generic search
        public void GetProducts(string query)
        {
            try
            {
                conn = new SqlConnection(ConnString);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                conn.Open();

                cmd = new SqlCommand(query, conn);



                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                ProductsGridView.DataSource = ds;

                ProductsGridView.DataBind();

            }
            catch (SqlException ex)
            {
                ex.ToString();
            }
            catch (Exception e)
            {
                e.ToString();
            }
            finally
            {
                conn.Close();
            }
        }

        //query specify get by id,*, or other args
        public void GetProducts(string query, string searchKey)
            {
                try
                {
                    conn = new SqlConnection(ConnString);
                    adapter = new SqlDataAdapter();
                    ds = new DataSet();
                    conn.Open();

                    cmd = new SqlCommand(query, conn);
                
                    cmd.Parameters.AddWithValue("searchKey",searchKey);
                    
                    
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds);

                    ProductsGridView.DataSource = ds;

                    ProductsGridView.DataBind();

                }
                catch (SqlException ex)
                {
                    ex.ToString();
                }
                catch (Exception e)
                {
                    e.ToString();
                }
                finally
                {
                    conn.Close();
                }
            }

        protected void SearchItem_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchKey = SearchItem.Text;
            string query ="select * from producttable where name like @searchKey or description like @searchKey or price like @searchKey or size like @searchKey";

            if (!string.IsNullOrEmpty(searchKey))
            {
                GetProducts(query, searchKey);

            }
            else
            {
                FeedbackLbl.Text = "search box empty";
                GetProducts("select * from producttable");
            }
            
        }
    }
}