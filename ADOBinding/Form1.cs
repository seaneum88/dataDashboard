using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADOBinding
{
    public partial class Form1 : Form
    {
        private string connectionString;
        private DataViewManager dsView;
        private DataSet ds;

        public Form1()
        {
            InitializeComponent();
            //set DB connection

            connectionString = @"data source = SEANLENOVO\SQLEXPRESS; initial catalog = Northwind; Integrated Security = true"; // PR-COMMONS-10\\SQLEXPRESS
            SqlConnection cn = new SqlConnection(connectionString);

            //create dataset
            ds = new DataSet("CustOrders");

            //fill the dataset with customers, map default Table "Table" to "Customers"
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * from Customers;", cn);
            da1.TableMappings.Add("Table", "Customers");
            da1.Fill(ds);

            //fill dataset with Orders, map default Table "table" to "Orders"
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * from Orders;", cn);
            da2.TableMappings.Add("Table", "Orders");
            da2.Fill(ds);

            //fill dataset with [Order Details], map default Table "Table" to "OrderDetails"
            SqlDataAdapter da3 = new SqlDataAdapter("SELECT * from [Order Details];", cn);
            da3.TableMappings.Add("Table", "OrderDetails");
            da3.Fill(ds);

            //show created Table names within the Dataset
            string myMessage = "Table Mappings: ";
            for (int i = 0; i < ds.Tables.Count; i++)
            {
                myMessage += i.ToString() + " " + ds.Tables[i].ToString() + "";
            }

            //establish the relationship  "RelCustOrd" between Customers ----- < Orders
            System.Data.DataRelation relCustOrd;
            System.Data.DataColumn colMaster1;
            System.Data.DataColumn colDetail1;


            colMaster1 = ds.Tables["Customers"].Columns["CustomerID"];
            colDetail1 = ds.Tables["Orders"].Columns["CustomerID"];
            relCustOrd = new System.Data.DataRelation("RelCustOrd", colMaster1, colDetail1);
            ds.Relations.Add(relCustOrd);

            //establish the relationship  "RelOrddet" between Orders ----- < [Order details]
            System.Data.DataRelation relOrdDet;
            System.Data.DataColumn colMaster2;
            System.Data.DataColumn colDetail2;

            colMaster2 = ds.Tables["Orders"].Columns["OrderID"];
            colDetail2 = ds.Tables["OrderDetails"].Columns["OrderID"];
            relOrdDet = new System.Data.DataRelation("RelOrdDet", colMaster2, colDetail2);
            ds.Relations.Add(relOrdDet);

            //show created relations within the dataset
            myMessage = "relation Mapping: ";
            for (int i = 0; i < ds.Relations.Count; i++)
            {
                myMessage += i.ToString() + " " + ds.Relations[i].ToString() + " ";
            }

            listMessages.Text = myMessage;
            //the dataGridView returned by the DefaultViewManager property allows you to create custom settings for each DataTable in the dataset
            dsView = ds.DefaultViewManager;

            //grid databinding
            GridOrder.DataSource = dsView;
            GridOrder.DataMember = "Customers.RelCustOrd";


            //grid databinding
            gridOrderDetails.DataSource = dsView;
            gridOrderDetails.DataMember = "Customers.RelCustOrd.RelOrdDet";

            //combobox databinding
            comboName.DataSource = dsView;
            comboName.DisplayMember = "Customers.CompanyName";
            comboName.ValueMember = "Customers.CustomerID";

            //text column's databinding
            txtContact.DataBindings.Add("Text", dsView, "Customers.ContactName");
            txtPhone.DataBindings.Add("Text", dsView, "Customers.Phone");
            txtFax.DataBindings.Add("Text", dsView, "Customers.Fax");
        }

        //position to previous record in Customer
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[dsView, "Customers"].Position > 0)
            {
                this.BindingContext[dsView, "Customers"].Position--;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)this.BindingContext[dsView, "Customers"];
            if (cm.Position < cm.Count - 1)
            {
                cm.Position++;
            }
        }

        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
