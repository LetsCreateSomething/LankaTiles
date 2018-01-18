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
        Database db;
        DataTable dt;
        public int updateInvoice(int invID, int itemID, int flag)
        {
            int mark = 1;
            if (flag == 1)
            {
                db = new Database();
                db.inserUpdateDelete("update invoiceDetails set IsIssued = 1 where invId =" + invID + " and itemID = " + itemID + "  ");
                dt = new DataTable();
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
                db = new Database();
                db.inserUpdateDelete("update invoiceDetails set IsIssued = 0 where invId =" + invID + " and itemID = " + itemID + "  ");
            }
            return mark;
        }

        public string getCustomerName(string id)
        {
            string name;
            db = new Database();
            name = db.getValue("select cusName from invoice where invID = " + id + "");
            return name;
        }
        public DataTable getInvoice()
        {
            db = new Database();
            dt = new DataTable();
            dt = db.select("SELECT invID AS ID, [date] AS [Date], cusName AS [Customer Name], IsIssued AS [Issue Status] FROM invoice");
            return dt;
        }
        public DataTable getInvoiceforGIN()
        {
            db = new Database();
            dt = new DataTable();
            dt = db.select("select * from invoice where IsIssued = 0");
            return dt;
        }
        public DataTable getInvoice(int id)
        {
            db = new Database();
            dt = new DataTable();
            dt = db.select("SELECT invoiceDetails.invID AS [Invoice ID], item.itemCode AS [Item Code], item.itemName AS [Item Name], invoiceDetails.qty AS Quantity, invoiceDetails.IsIssued AS [Issue Status],invoiceDetails.itemID  FROM invoiceDetails INNER JOIN item ON invoiceDetails.itemID = item.itemID WHERE(invoiceDetails.invID = " + id + ")");
            return dt;
        }
        public DataTable search(string search)
        {
            db = new Database();
            dt = new DataTable();
            dt = db.select("SELECT invID AS ID, [date] AS [Date], cusName AS [Customer Name], IsIssued AS [Issue Status] FROM invoice WHERE cusName LIKE '%" + search + "%'");
            return dt;
        }
    }
}

