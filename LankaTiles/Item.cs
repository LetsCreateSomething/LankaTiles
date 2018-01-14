using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaTiles
{
    class Item
    {     
        private int itemID;
        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }

        private string itemCode;
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }

        private string itemName;
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        private int itemQty;
        public int ItemQty
        {
            get { return itemQty; }
            set { itemQty = value; }
        }

        private double unitPrice;
        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public DataTable getItemDetails()
        {
            Database db = new Database();
            DataTable dt = new DataTable();
            dt = db.select("select * from item");
            return dt;
        }

        public void addItem()
        {
            Database db = new Database();
            string query = "insert into item (itemCode, itemName, unitPrice, qty) values ('"+itemCode+"','"+itemName+"',"+unitPrice+", "+itemQty+")";
            db.inserUpdateDelete(query);
        }

        public void deleteItem(int id)
        {
            Database db = new Database();
            string query = "delete from item where itemID = "+id+"";
            db.inserUpdateDelete(query);
        }
        public void adjustMinimumStockBalance() { }
        public void viewStock() { }

        public void updateStock(string GRNID)
        {
            Database db = new Database();
            DataTable dt = new DataTable();
            dt = db.select("select itemID, qty from GRNDetails where GRNID = " + GRNID + "");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                db.inserUpdateDelete("update item set qty = qty+" + dt.Rows[i][1].ToString() + " where itemID = " + dt.Rows[i][0].ToString() + "");
            }
        }

        public string getItemRfid(int id)
        {
            Database db = new Database();
            string val;
            val = db.getValue("select RFID from item where itemID = " + id + "");
            return val;
        }
    }
}
