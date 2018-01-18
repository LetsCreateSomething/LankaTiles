using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LankaTiles
{
    class GoodRecieveNote
    {
        DataTable dt;
        Database db;
        public string id { get; set; }
        public string date { get; set; }
        public string supID { get; set; }

        public string getMaxID()
        {
            db = new Database();
            string id = db.getValue("select max(GRNID) from GRN");
            return id;
        }
        public void addGRN()
        {
            db = new Database();
            db.inserUpdateDelete("insert into GRN values (" + id + ",'" + date + "','" + supID + "',0)");
            addGRNDetails();
        }
        public void addGRNDetails()
        {
            db = new Database();
            db.inserUpdateDelete("insert into GRNDetails select GRNID, itemID, qty, IsDelivered from GRNTemp ");
        }
        public void deleteTemp()
        {
            db = new Database();
            db.inserUpdateDelete("delete from GRNTemp");
        }
        public DataTable getGRN()
        {
            db = new Database();
            dt = new DataTable();
            dt = db.select("SELECT GRN.GRNID AS ID, GRN.[date] AS [Date], "+
                "Supplier.supName AS [Supplier Name], Supplier.location AS Location,"+
                " GRN.IsDelivered AS [Delivary Status] FROM GRN INNER JOIN Supplier ON GRN.supID = Supplier.supID");
            return dt;
        }
        public DataTable getGRN(int id)
        {
            db = new Database();
            dt = new DataTable();
            dt = db.select("SELECT GRNDetails.GRNID AS ID, item.itemName AS "+
                "[Item Name], GRNDetails.qty AS Quantity, "+
                "GRNDetails.itemID FROM GRNDetails INNER JOIN item ON "+
                "GRNDetails.itemID = item.itemID WHERE(GRNDetails.GRNID = " + id + ")");
            return dt;
        }
        public int updateGRN(int Id)
        {
            db = new Database();
            dt = db.select("select * from GRN where isDelivered = 1 and GRNID = " + Id + "");
            if (dt.Rows.Count == 0)
            {
                db.inserUpdateDelete("update GRN set IsDelivered = 1 where GRNID = " + Id + "");
                return 1;
            }
            else            
                return 0;            
        }
    }
}
