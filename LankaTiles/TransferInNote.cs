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
        DataTable dt;
        Database db;
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
            db = new Database();           
            dt = db.select("select TINID as ID, date as Date, fromLocation as [From], destination as [To] from TIN");           
            return dt;
        }       

        public DataTable searchTIN(int id)
        {
            db = new Database();
            dt = db.select("SELECT TINDetails.TINID AS ID,item.itemName AS [Item Name], "+
                "TINDetails.qty AS Quantity, " +
                "TINDetails.RFIDID AS RFID FROM item "+
                "INNER JOIN TINDetails ON item.itemID = TINDetails.itemID "+
                "WHERE(TINDetails.TINID = " + id + ")");
            return dt;
        }

        public DataTable getPendingTIN()
        {
            dt = new DataTable();
            db = new Database();
            dt = db.select("SELECT TONID AS ID, [date] AS [Date], fromLocation AS [From],"+
                " destination AS [To] FROM TON WHERE(IsRecieved = 0)");
            return dt;
        }
        public DataTable getPendingTIN(int id)
        {
            dt = new DataTable();
            db = new Database();
            dt = db.select("SELECT TONDetails.TONID AS ID, item.itemName AS [Item Name],"+
                " TONDetails.qty AS Quantity FROM TONDetails INNER JOIN item ON "+
                "TONDetails.itemID = item.itemID WHERE(TONDetails.TONID = " + id + ")");
            return dt;
        }

        public void verifyTIN() { }

        public void addTIN(int id)
        {
            db = new Database();
            db.inserUpdateDelete("insert into TIN (TINID, date, fromLocation, destination) select TONID, date, fromLocation, destination from TON where TONID = " + id + "");
            db.inserUpdateDelete("update TON set IsRecieved = 1 where TONID = " + id + "");
            db.inserUpdateDelete("insert into TINDetails (TINID, itemID, qty) select TONID, itemID, qty from TONDetails where TONID = " + id + "");
        }




    }
}
