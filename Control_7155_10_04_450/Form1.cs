using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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

        private const string OK_MESSAGE = "OK        ";
        private const string ERROR_MESSAGE = "ERROR";

        private byte[] bufRx = new byte[RX_SIZE + 8];
        private byte bytesCount = 0;

        private List<Signal> signals = new List<Signal>();
        private Dictionary<string, Label> map;

        private bool isCorrectRx = false;
        private bool isCheckChannelMode = false;

        public Form1()
        {
            
            InitializeComponent();

            string[] ports = SerialPort.GetPortNames();
            comboBoxPorts.Items.AddRange(ports);
            for (int i = 0; i < ports.Length; i++)
                Console.WriteLine(ports[i]);

            signals = downloadAllSignals();

            map = new Dictionary<string, Label>()
            {
                { "TV2S - TV3S", label1 },
                { "CS_MA - CS_ME", label2 },
                { "CS_MB - CS_MF" , label3 },
                { "CS_MC - CS_MN", label4 },
                { "CS_MD - CS_MG", label5 },
                { "INTDOP1 - INTDOP2", label6 },

                { "INTP0 - INTP1", label7 },
                { "INTP2 - INTP3", label9 },
                { "INTP4 - INTP5", label11 }
            }; 
            
        }

        private void showOkLabelText(Label label)
        {            
            label.BackColor = Color.GreenYellow;
            label.ForeColor = Color.Black;
            label.Text = OK_MESSAGE;
        }

        private void showErrorLabelText(Label label)
        {
            label.BackColor = Color.Red;
            label.ForeColor = Color.Black;
            label.Text = ERROR_MESSAGE;
        }
        private void checkBits(int bt, int nBt)
        {
            for (int i = 0; i < 6; i++)
            {
                if (((bt >> i) & 0x01) == 0x01)
                {
                    Signal signal = signals.Find(n => n.ByteNumber == nBt && n.BitNumber == i);
                    if(signal != null && signal.isChecked)
                    {
                        Label label = map[signal.Name];
                        showOkLabelText(label);

                        if(signal.Name.Equals("INTP0 - INTP1"))
                        {
                            if (((bt >> 4) & 0x01) == 0x01) showOkLabelText(label8);
                            else showErrorLabelText(label8);
                        }
                        else if (signal.Name.Equals("INTP2 - INTP3"))
                        {
                            if (((bt >> 4) & 0x01) == 0x01) showOkLabelText(label10);
                            else showErrorLabelText(label10);
                        }
                        else if (signal.Name.Equals("INTP4 - INTP5"))
                        {
                            if (((bt >> 4) & 0x01) == 0x01) showOkLabelText(label12);
                            else showErrorLabelText(label12);
                        }
                    }                        
                    
                }
                else
                {
                    Signal signal = signals.Find(n => n.ByteNumber == nBt && n.BitNumber == i);
                    if(signal != null && signal.isChecked)
                    {
                        Label label = map[signal.Name];
                        showErrorLabelText(label);

                        if (signal.Name.Equals("INTP0 - INTP1"))
                        {
                            if (((bt >> 4) & 0x01) == 0x01) showOkLabelText(label8);
                            else showErrorLabelText(label8);
                        }
                        else if (signal.Name.Equals("INTP2 - INTP3"))
                        {
                            if (((bt >> 4) & 0x01) == 0x01) showOkLabelText(label10);
                            else showErrorLabelText(label10);
                        }
                        else if (signal.Name.Equals("INTP4 - INTP5"))
                        {
                            if (((bt >> 4) & 0x01) == 0x01) showOkLabelText(label12);
                            else showErrorLabelText(label12);
                        }
                    }                       
                    
                }
            }
        }
        private void setSignalsResponses(byte[] pack)
        {
            if(isCheckChannelMode)
            {
                int bt = pack[13];
                if (((bt >> 0) & 0x01) == 0x01)
                {
                    buttonNot.BackColor = Color.GreenYellow;
                    buttonNot.Text = "OK";
                } 
                else
                {
                    buttonNot.BackColor = Color.Red;
                    buttonNot.Text = "ERR";
                }
            }
            else
            {
                checkBits(pack[2], 9);
                checkBits(pack[3], 10);
                if ((int)(pack[4] & 0x01) == 0x01)
                {
                    if (radioButtonDD2.Checked == true || radioButtonDD8.Checked == true || radioButtonDD9.Checked == true)
                    {
                        labelChip.BackColor = Color.GreenYellow;
                        labelChip.ForeColor = Color.Black;
                        labelChip.Text = OK_MESSAGE;
                    }
                    else
                    {
                        labelChip.BackColor = Color.Red;
                        labelChip.ForeColor = Color.Black;
                        labelChip.Text = ERROR_MESSAGE;
                    }
                }
            }
           
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            bytesCount = 0;
            isCorrectRx = false;
            Array.Clear(bufRx, 0, bufRx.Length);

            if (isCheckChannelMode)
            {
                while (serialPort.BytesToRead > 0)
                {
                    try
                    {
                        bufRx[bytesCount] = (byte)serialPort.ReadByte();
                        bytesCount++;

                        switch (bytesCount)
                        {
                            case 1: if (bufRx[0] != ZERO_BYTE_RX) bytesCount = 0; break;
                            case 2: if (bufRx[1] != FIRST_BYTE_RX) bytesCount = 0; break;
                            case RX_SIZE + 8:
                                bytesCount = 0;
                                if (calcSumXor(bufRx, RX_SIZE + 8) == 0)
                                {
                                    Console.WriteLine("RX: " + BitConverter.ToString(bufRx, 0, RX_SIZE + 8));
                                    isCorrectRx = true;
                                }
                                else
                                {
                                    Console.WriteLine("RX: Invalid XOR sum");
                                }

                                break;
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }

                    if (isCorrectRx)
                        break;
                }
            }
            else
            {
                while (serialPort.BytesToRead > 0)
                {
                    try
                    {
                        bufRx[bytesCount] = (byte)serialPort.ReadByte();
                        bytesCount++;

                        switch (bytesCount)
                        {
                            case 1: if (bufRx[0] != ZERO_BYTE_RX) bytesCount = 0; break;
                            case 2: if (bufRx[1] != FIRST_BYTE_RX) bytesCount = 0; break;
                            case RX_SIZE:
                                bytesCount = 0;
                                if (calcSumXor(bufRx, RX_SIZE) == 0)
                                {
                                    Console.WriteLine("RX: " + BitConverter.ToString(bufRx, 0, RX_SIZE));
                                    isCorrectRx = true;
                                }
                                else
                                {
                                    Console.WriteLine("RX: Invalid XOR sum");
                                }

                                break;
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }

                    if (isCorrectRx)
                        break;
                }
            }            

            if(isCorrectRx)
            {
                setSignalsResponses(bufRx);
            }
            
        }

        private byte calcSumXor(byte[] bytes, byte length)
        {
            byte sum = 0;
            for (int i = 0; i < length; i++)
                sum ^= bytes[i];
            return sum;
        }
        private byte[] createPacketToSend(List<Signal> signals)
        {
            byte[] packToSend = new byte[TX_SIZE];

            packToSend[0] = ZERO_BYTE_TX;
            packToSend[1] = FIRST_BYTE_TX;

            int bt;

            foreach(Signal signal in signals)
            {
                bt = packToSend[signal.ByteNumber];

                if (signal.isChecked)
                    bt |= (1<<signal.BitNumber);
                else
                    bt &= ~(1<<signal.BitNumber);
                packToSend[signal.ByteNumber] = (byte)bt;

            }

            if (packToSend[9] != 0) packToSend[9] |= (1 << 6);    //ADDED
            if (packToSend[10] != 0) packToSend[10] |= (1 << 6);    //ADDED           


            switch (trackBar1.Value)
            {
                case 1: packToSend[11] |= (1 << 3); break;
                case 2: packToSend[11] |= (1 << 4); break;
                case 3: packToSend[11] |= (1 << 5); break;
                case 4: packToSend[11] |= (1 << 6); break;
                case 5: packToSend[11] |= (1 << 7); break;
                case 6: packToSend[12] |= (1 << 0); break;
                case 7: packToSend[12] |= (1 << 1); break;
                case 8: packToSend[12] |= (1 << 2); break;
                case 9: packToSend[11] |= (1 << 2); break;
            }

            Console.WriteLine("trackBar1.Value: " + trackBar1.Value);

            bt = packToSend[12];

            if (((bt >> 5) & 0x01) == 0x01)
            {
                switch(comboBox1.SelectedText)
                {
                    case "bank 1": bt |= 0x00; break;
                    case "bank 2": bt |= 0x01; break;
                    case "bank 3": bt |= 0x02; break;
                    case "bank 4": bt |= 0x03; break;
                }

                packToSend[12] = (byte)bt;
            }

            

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
                Thread.Sleep(500);
                serialPort.Close();
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            resetLabels();
            String port = comboBoxPorts.Text;
            sendData(port, createPacketToSend(signals));
        }

        private void comboBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelInit.Visible = false;
            setElementsVisibility();
        }

        private void CheckedChangedEvent(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            Signal signal = signals.Find(n => n.Name.Equals(checkBox.Text));
            signal.isChecked = checkBox.Checked;            
            Console.WriteLine(signal + " -------> isChecked: " + signal.isChecked);
            if(signal.Name.Equals("INTP0 - INTP1"))
            {
                checkBoxINV0.Checked = checkBox.Checked;
            }
            else if (signal.Name.Equals("INTP2 - INTP3"))
            {
                checkBoxINV1.Checked = checkBox.Checked;
            }
            else if (signal.Name.Equals("INTP4 - INTP5"))
            {                
                checkBoxINV2.Checked = checkBox.Checked;
            }
        }

        private void radioButtonChangedEvent(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            Signal signal = signals.Find(n => n.Name.Equals(radioButton.Text));
            signal.isChecked = radioButton.Checked;
            Console.WriteLine(signal + " -------> isChecked: " + signal.isChecked);
            if (radioButton.Text.Equals("DD2"))
            {
                comboBox1.Enabled = true;
                comboBox1.SelectedIndex = 0;                
            }
            else if(radioButton.Text.Equals("DA9") || radioButton.Text.Equals("DA10"))
            {
                trackBar1.Enabled = true;
                setTrackBarLabels();
            }


        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            resetAllElements();
        }

        private void buttonCheckChannel_Click(object sender, EventArgs e)
        {
            buttonNot.BackColor = Color.SlateGray;
            isCheckChannelMode = true;
            serialPort.PortName = comboBoxPorts.Text;
            byte[] packToSend = new byte[TX_SIZE];

            packToSend[0] = ZERO_BYTE_TX;
            packToSend[1] = FIRST_BYTE_TX;
            packToSend[13] = 1;
            packToSend[TX_SIZE - 1] = calcSumXor(packToSend, TX_SIZE - 1);
            serialPort.Open();
            if (serialPort.IsOpen)
            {
                serialPort.Write(packToSend, 0, TX_SIZE);
                Console.WriteLine("485RXA/485TXA channel checking:");
                Console.WriteLine("TX: " + BitConverter.ToString(packToSend));
                Thread.Sleep(500);
                serialPort.Close();
            }
            isCheckChannelMode = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


