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
            Database db = new Database();
            DataTable dt = new DataTable();
            dt = db.select("select * from TON");
            return dt;
        }

        public DataTable getTON(int id)
        {
            Database db = new Database();
            DataTable dt = new DataTable();
            dt = db.select("select * from TONDetails where TONID = " + id + "");
            return dt;
        }

        public void addTON()
        {
            Database db = new Database();
            string queryTON = "insert into TON values ("+Id+",'"+DateTime.Now.ToString()+"', '"+fromLocation+"','"+destination+"','0')";
            db.inserUpdateDelete(queryTON);
            addTONDetail();
        }

        public void addTONDetail()
        {
            Database db = new Database();
            string query = "insert into TONDetails select TONID, itemID, qty from tonTemp";
            db.inserUpdateDelete(query);
        }
        public string getMaxId()
        {
            Database db = new Database();
            string id= db.getValue("select max(TONID) from TON");
            return id;
        }
        public void verifyTON() { }
        public void removeTON() { }
        public void searchTON() { }




    }
}
