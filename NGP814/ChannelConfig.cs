using DevExpress.CodeParser;
using DevExpress.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGP814
{
    public class ChannelConfig
    {
        public int Channel { get; set; }
        //public double Voltage { get; set; }
        //public double Current { get; set; }
        public bool VoltFlag { get; set; }   
        public bool CurrFlag { get; set; } = false;
        public bool VltLwFlag { get; set; } // C#에서 bool 기본값은 자동으로 False
        public bool VltHFlag { get; set; }
        public bool CrLwFlag { get; set; }
        public bool CrHFlag { get; set; }
        public double PowerBarN { get; set; }
    }
}
