using System;
using System.Collections.Generic;
using System.Text;

namespace SG.DEPOT.Parametre
{
    public class SGConfiguration
    {
        public static string ConnectingString { get; set; }
        public static string ConnectingStringKey { get { return "DefaultConnection"; } }
    }
}
