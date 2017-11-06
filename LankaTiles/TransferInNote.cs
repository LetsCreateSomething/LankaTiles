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
            dt = db.select("select * from TON");           
            return dt;
        }

        public void removeTIN() { }

        public DataTable searchTIN(int id)
        {
            Database db = new Database();
            dt = db.select("select * from TON" + id + " ");
            return dt;
        }

        public void verifyTIN() { }
        public void addTIN() { }




    }
}
