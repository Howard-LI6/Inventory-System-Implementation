using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace FGTransaction
{
    public partial class InventoryEntry : System.Web.UI.Page
    {
        
     // private SqlConnection dbConnection;
        private OleDbConnection dbConnection;
                

        private string exMsg;
          
        
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                exMsg = "Data Entry Completed!";

                //dbConnection = new SqlConnection((string)ConfigurationManager.AppSettings["ConnectionFGTransaction"]);
                dbConnection = new OleDbConnection((string)ConfigurationManager.AppSettings["ConnectionFGTransaction"]);

                string sqlquery = "INSERT INTO FGTransaction (Warehouse, ModelNo, SN, Quantity) VALUES ('"
                + this.txtWarehouse.Text.Trim() + "', '" + this.txtModelNo.Text.Trim() + 
                "', '" +  this.txtSn.Text.Trim() + "'," + this.txtQuantity.Text.Trim() + ")";

               // SqlCommand caisCm = new SqlCommand(sqlquery, dbConnection);
                OleDbCommand caisCm = new OleDbCommand(sqlquery, dbConnection);
                caisCm.CommandType = CommandType.Text;

                dbConnection.Open();
                caisCm.ExecuteNonQuery();

                dbConnection.Close();
                dbConnection.Dispose();
            }
            catch (Exception ex)
            {
                 exMsg = ex.Message;
            }
            finally
            {
                if (dbConnection != null) dbConnection.Close();
            }

            lblMsg.Text = exMsg;
        }
    }
}