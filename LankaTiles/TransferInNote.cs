using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaTiles
{
    class TransferInNote
    {
        public DataTable dt;
        private string TINID;
        private string fromLocation;
        private string itemType;
        private string date;
        private int qty;

        public string TINid
        {
            get
            {
                return this.TINID;
            }
            set
            {
                this.TINID = value;
            }
        }  

        public DataTable viewTIN()
        {
            Database db = new Database();           
            dt = db.select("select * from TIN");           
            return dt;
        }       

        public DataTable searchTIN(int id)
        {
            Database db = new Database();
            dt = db.select("select * from TINDetails where TINID = " + id + " ");
            return dt;
        }

        public DataTable getPendingTIN()
        {
            DataTable dt = new DataTable();
            Database db = new Database();
            dt = db.select("select * from TON where IsRecieved = 0");
            return dt;
        }
        public DataTable getPendingTIN(int id)
        {
            DataTable dt = new DataTable();
            Database db = new Database();
            dt = db.select("select * from TONDetails where TONID = " + id + " ");
            return dt;
        }

        public void verifyTIN() { }

        public void addTIN(int id)
        {
            Database db = new Database();
            db.inserUpdateDelete("insert into TIN (TINID, date, fromLocation, destination) select TONID, date, fromLocation, destination from TON where TONID = " + id + "");
            db.inserUpdateDelete("update TON set IsRecieved = 1 where TONID = " + id + "");
            db.inserUpdateDelete("insert into TINDetails (TINID, itemID, qty) select TONID, itemID, qty from TONDetails where TONID = " + id + "");
        }




    }
}
