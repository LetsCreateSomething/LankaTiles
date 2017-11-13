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
        public DataTable dt;
        public Database db;

        private string GINID;
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
            db.inserUpdateDelete("insert into GINDetails select GINID, itemID, qty, invID from GINTemp");
        }

        public void addGINTemp(string GINID, int itemID, int qty, int invID)
        {
            db = new Database();
            db.inserUpdateDelete("insert into GINTemp values (" + GINID + "," + itemID + "," + qty + "," + invID + ")");
        }

        public DataTable getGINTemp()
        {
            Database db = new Database();
            DataTable dt = new DataTable();
            dt = db.select("select * from GINTemp");
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
            string query = "select * from GIN where cusName LIKE '%" + search + "%'";
            db = new Database();
            dt = db.select(query);    
            return dt;            
        }

        public DataTable getGIN()
        {
            string query = "select * from GIN";
            db = new Database();
            dt = db.select(query);
            return dt;
        }

        public DataTable viewReleventGin(int GINid)
        {
            string query = "select * from GINDetails where GINID = "+GINid+"";
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
