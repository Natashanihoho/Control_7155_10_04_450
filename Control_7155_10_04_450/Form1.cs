using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_7155_10_04_450
{
    public partial class Form1 : Form
    {
        private const byte ZERO_BYTE_RX = 165;
        private const byte FIRST_BYTE_RX = 2;

        private const byte ZERO_BYTE_TX = 170;
        private const byte FIRST_BYTE_TX = 1;

        private const byte RX_SIZE = 8;
        private const byte TX_SIZE = 16;

        private byte[] bufRx = new byte[RX_SIZE];
        private byte bytesCount = 0;
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Init");
            string[] ports = SerialPort.GetPortNames();
            comboBoxPorts.Items.AddRange(ports);
            for (int i = 0; i < ports.Length; i++)
                Console.WriteLine(ports[i]);
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Array.Clear(bufRx, 0, bufRx.Length);

            while(serialPort.BytesToRead > 0)
            {
                try
                {
                    bufRx[bytesCount] = (byte)serialPort.ReadByte();
                    bytesCount++;

                    switch(bytesCount)
                    {
                        case 1: if (bufRx[0] != ZERO_BYTE_RX) bytesCount = 0; break;
                        case 2: if (bufRx[1] != FIRST_BYTE_RX) bytesCount = 0; break;
                        case RX_SIZE: 
                            bytesCount = 0; 
                            if(calcSumXor(bufRx, RX_SIZE) == 0)                            
                                Console.WriteLine("RX: " + BitConverter.ToString(bufRx));                             
                            else                            
                                Console.WriteLine("RX: Invalid XOR sum");                            
                            break;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private byte calcSumXor(byte[] bytes, byte length)
        {
            byte sum = 0;
            for (int i = 0; i < length; i++)
                sum ^= bytes[i];
            return sum;
        }
        private byte[] createPacketToSend()
        {
            byte[] packToSend = new byte[TX_SIZE];

            packToSend[0] = ZERO_BYTE_TX;
            packToSend[1] = FIRST_BYTE_TX;

            packToSend[TX_SIZE-1] = calcSumXor(packToSend, TX_SIZE-1);

            return packToSend;
        }
        private void sendData(String port, byte[] pack)
        {
            serialPort.PortName = port;
            serialPort.Open();
            if(serialPort.IsOpen)
            {
                serialPort.Write(pack, 0, TX_SIZE);
                Console.WriteLine("TX: " + BitConverter.ToString(pack));
                Thread.Sleep(200);
                serialPort.Close();
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            String port = comboBoxPorts.Text;
            sendData(port, createPacketToSend());
        }

        private void comboBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
