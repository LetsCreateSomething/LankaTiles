using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LankaTiles
{
    class RFID
    {

        SerialPort mySerialPort;
        static string value;
        string result;
        public string getRFID()
        {
            try
            {
                mySerialPort = new SerialPort("COM5");
                mySerialPort.BaudRate = 9600;
                mySerialPort.Parity = Parity.None;
                mySerialPort.StopBits = StopBits.One;
                mySerialPort.DataBits = 8;
                mySerialPort.Handshake = Handshake.None;
                mySerialPort.RtsEnable = true;
                mySerialPort.Open();
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Please connect a board and check for the com port is correct!");
            }
            return value; 
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            result = sp.ReadExisting().ToString();

           // DialogResult dr = MessageBox.Show("Do you want to add this RFID ?      " + result + " ", "Confirm!", MessageBoxButtons.YesNo);
           // if (dr == DialogResult.Yes)
          //  {
                value = result;
           // }                       
        }
        delegate void SetTextCallback(string text);   
          
        public bool verify(string id)
        {
            string rfid;
            bool mark = false;
            rfid = getRFID();
            if (rfid == id)
            {
                MessageBox.Show("Item Verified!");
                mark = true;
            }
            else
            {
                MessageBox.Show("Wrong Item!");
                mark = false;
            }
            return mark;
        }


     }
}
