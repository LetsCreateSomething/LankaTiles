using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaTiles
{
    class Invoice
    {
        private int invoiceID;
        private int date;
        private string itemType;
        private int qty;

        public int updateInvoice(int invID, int itemID, int flag)
        {
            int mark = 1;
            if (flag == 1)
            {
                Database db = new Database();
                db.inserUpdateDelete("update invoiceDetails set IsIssued = 1 where invId =" + invID + " and itemID = " + itemID + "  ");
                DataTable dt = new DataTable();
                dt = db.select("select IsIssued from invoiceDetails where invID = " + invID + " ");
               
                foreach (DataRow row in dt.Rows)
                {
                    if (row["isIssued"].ToString() == "False")
                    {
                        mark = 0;
                        break;
                    }
                }
                if (mark==1)
                {
                    db.inserUpdateDelete("update invoice set IsIssued = 1 where invId =" + invID + " ");                   
                }
            }
            else
            {
                Database db = new Database();
                db.inserUpdateDelete("update invoiceDetails set IsIssued = 0 where invId =" + invID + " and itemID = " + itemID + "  ");
            }
            return mark;
        }

        public string getCustomerName(string id)
        {
            string name;
            Database db = new Database();
            name = db.getValue("select cusName from invoice where invID = " + id + "");
            return name;
        }
        public DataTable getInvoice()
        {
            Database db = new Database();
            DataTable dt = new DataTable();
            dt = db.select("select * from invoice");
            return dt;
        }
        public DataTable getInvoiceforGIN()
        {
            Database db = new Database();
            DataTable dt = new DataTable();
            dt = db.select("select * from invoice where IsIssued = 0");
            return dt;
        }
        public DataTable getInvoice(int id)
        {
            Database db = new Database();
            DataTable dt = new DataTable();
            dt = db.select("select * from invoiceDetails where invID = " + id + "");
            return dt;
        }
    }
}
