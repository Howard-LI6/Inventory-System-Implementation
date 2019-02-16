using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace MailDistributionLog
{
    public partial class InventoryReport : System.Web.UI.Page
    {
        private SqlConnection dbConnection;

        private string exMsg;


        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

     
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection = new SqlConnection((string)ConfigurationManager.AppSettings["ConnectionZvmcaisdb03"]);
                string sqlquery = "";
                
                if (this.ddlWarehouse.SelectedValue == "W1")
                {
                    sqlquery = "Select Warehouse, ModelNo as 'Model No',   SUM(Quantity) as 'On Hand' from FGTransaction where Warehouse ='" +
                        this.ddlWarehouse.SelectedValue + "' Group By Warehouse, ModelNo";

                }

                else if (this.ddlWarehouse.SelectedValue == "W2")
                {
                    sqlquery = "Select Warehouse, ModelNo as 'SP No',   SUM(Quantity) as 'On Hand' from FGTransaction where Warehouse ='" +
                        this.ddlWarehouse.SelectedValue + "' Group By Warehouse, ModelNo";

                }
                else
                {
                    sqlquery = "select 'ALL' as 'Warehouse', ModelNo as 'SP No',   SUM(Quantity) as 'On Hand' from FGTransaction   group by  ModelNo";
                }

                SqlCommand caisCm = new SqlCommand(sqlquery, dbConnection);
                caisCm.CommandType = CommandType.Text;

                SqlDataAdapter dgSqlDataAdapter = new SqlDataAdapter();
                DataSet countryDataSet = new DataSet();
                DataTable dt = new DataTable();

                dbConnection.Open();
                dgSqlDataAdapter.SelectCommand = caisCm;
                dgSqlDataAdapter.Fill(countryDataSet);
                dt = countryDataSet.Tables[0];
                dbConnection.Close();


                gwInventory.DataSource = dt;
                gwInventory.DataBind();

            }
            catch (Exception ex)
            {
                exMsg = ex.Message;
            }
            finally
            {
                if (dbConnection != null) dbConnection.Close();
            }
        }
    }
}