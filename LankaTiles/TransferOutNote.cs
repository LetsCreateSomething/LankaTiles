using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaTiles
{
    class TransferOutNote
    {        
        public Database db;
        public DataTable dt;
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int date;
        private string itemType;

        private int qty;
        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        private string fromLocation;
        public string FromLocation
        {
            get { return fromLocation; }
            set { fromLocation = value; }
        }

        private string destination;
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }


        public DataTable getTON()
        {
            db = new Database();
           dt = new DataTable();
            dt = db.select("select * from TON");
            return dt;
        }

        public DataTable getTON(int id)
        {
            db = new Database();
            dt = new DataTable();
            dt = db.select("select * from TONDetails where TONID = " + id + "");
            return dt;
        }

        public void addTON()
        {
            db = new Database();
            string queryTON = "insert into TON values ("+Id+",'"+DateTime.Now.ToString()+"', '"+fromLocation+"','"+destination+"','0')";
            db.inserUpdateDelete(queryTON);
            addTONDetail();
        }

        public void addTONDetail()
        {
            db = new Database();
            string query = "insert into TONDetails select TONID, itemID, qty from tonTemp";
            db.inserUpdateDelete(query);
        }
        public string getMaxId()
        {
            db = new Database();
            string id= db.getValue("select max(TONID) from TON");
            return id;
        }
        public void verifyTON() { }

        public void removeTON(int id)
        {
            string query = "delete from TON where TONID = " + id + "";
            db = new Database();           
            db.inserUpdateDelete("delete from TONDetails where TONID = " + id + "");
            db.inserUpdateDelete(query);
        }

        public DataTable searchTON(string search)
        {
            string query = "select * from TON where TONID LIKE '%" + search + "%'";
            db = new Database();
            dt = db.select(query);
            return dt;
        }




    }
}
