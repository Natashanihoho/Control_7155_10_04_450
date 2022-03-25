using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Control_7155_10_04_450
{
    partial class Form1
    {
        private const string sourceFile = "signals.xml";
        
        public static List<Signal> downloadAllSignals()
        { 
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Signal>));

            using (FileStream fs = new FileStream(sourceFile, FileMode.Open))
            {
                return (List<Signal>)xmlSerializer.Deserialize(fs);
            }
        }
    }
}
