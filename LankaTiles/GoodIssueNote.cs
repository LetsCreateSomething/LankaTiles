using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LankaTiles
{
    class GoodIssueNote
    {
        DataTable dt;
        Database db;

        string GINID;
        public string ginID
        {
            get { return GINID; }
            set { GINID = value; }
        }

        private string customer;
        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }      

        private string date;
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public void addGIN()
        {
            
            db = new Database();            
            string query = "insert into GIN values (" + GINID + ",'" + date + "','" + customer + "')";
            db.inserUpdateDelete(query);
            addGINDetails();

            
        }
        public void addGINDetails()
        {
            db = new Database();
            dt = new DataTable();
            string query;
            dt = db.select("select itemID, qty from GINTemp");
            db.inserUpdateDelete("insert into GINDetails select GINID, itemID, qty, invID from GINTemp");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                query = "update item set qty = qty - " + dt.Rows[i]["qty"] + " where itemID = " + dt.Rows[i]["itemID"] + "";
                db.inserUpdateDelete(query);
            }             
        }

        public void addGINTemp(string GINID, int itemID, int qty, int invID)
        {
            db = new Database();
            dt = db.select("select * from GINTemp where itemId = " + itemID + "");
            if (dt.Rows.Count==0)            
                db.inserUpdateDelete("insert into GINTemp values (" + GINID + "," + itemID + "," + qty + "," + invID + ")");

        }

        public void updateGINTemp(int id)
        {
            db = new Database();
            db.inserUpdateDelete("delete from GINTemp where itemID = " + id + " ");
        }
        public DataTable getGINTemp()
        {
            db = new Database();
            dt = new DataTable();
            dt = db.select("SELECT GINTemp.GINID AS ID, item.itemName AS [Item Name],"+
                " GINTemp.qty AS Quantity, GINTemp.invID AS [Invoice ID], invoice.cusName AS "+
                "[Customer Name] FROM GINTemp INNER JOIN item ON GINTemp.itemID = item.itemID "+
                "INNER JOIN invoice ON GINTemp.invID = invoice.invID");
            return dt;
        }

        public void dropTemp()
        {
            Database db = new Database();
            db.inserUpdateDelete("delete from GINTemp");
        }
        public void removeGIN(int GINid)
        {
            string query = "delete from GIN where GINID = " + GINid + "";            
            db = new Database();  
            db.inserUpdateDelete(query);
            db.inserUpdateDelete("delete from GINDetails where GINID = "+GINid+"");
        }

       
        public DataTable searchGIN(string search)
        {
            string query = "select GINID AS ID, [date] AS [Date], cusName AS [Customer Name] from GIN where cusName LIKE '%" + search + "%'";
            db = new Database();
            dt = db.select(query);    
            return dt;            
        }

        public DataTable getGIN()
        {
            string query = "SELECT GINID AS ID, [date] AS [Date], cusName AS [Customer Name] FROM GIN";
            db = new Database();
            dt = db.select(query);
            return dt;
        }

        public DataTable viewReleventGin(int GINid)
        {
            string query = "SELECT GINDetails.GINID AS ID, item.itemName AS [Item Name], "+
                "GINDetails.qty AS Quantity, invoice.cusName AS [Customer Name] "+
                "FROM GINDetails INNER JOIN item ON GINDetails.itemID = item.itemID "+
                "INNER JOIN invoice ON GINDetails.invID = invoice.invID WHERE(GINDetails.GINID = " + GINid + ")";
            dt = new DataTable();
            db = new Database();
            dt = db.select(query);            
            return dt;
          
            
        }
        public string getMaxGINID()
        {
            string id;
            Database db = new Database();
            id = db.getValue("select max(GINID) from GIN");
            return id;
        }
    }
}
