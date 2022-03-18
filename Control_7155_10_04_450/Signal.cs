using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Control_7155_10_04_450
{
    [Serializable]
    public class Signal
    {
        [XmlElement("SIGNAL")]
        public string Name { get; set; }
        public byte ByteNumber { get; set; }
        public byte BitNumber { get; set; }
        public bool IsWaitingResponce { get; set; }

        public Signal(string name, byte nByte, byte nBit, bool isWaitingResponce)
        {
            Name = name;
            ByteNumber = nByte;
            BitNumber = nBit;
            IsWaitingResponce = isWaitingResponce;
        }

        public Signal()
        {
        }

        public override string ToString()
        {
            return Name + "---" + ByteNumber + "---" + BitNumber + "---" + IsWaitingResponce;
        }
    }
}
