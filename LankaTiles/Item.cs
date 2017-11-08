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
        public void updateStock() { }
    }
}
