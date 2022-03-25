using CP_CW_7417.BLL.Enums;
using CP_CW_7417.BLL.Helpers;
using System;
using System.Runtime.Serialization;

namespace CP_CW_7417.BLL.Models
{
    [DataContract]
    public class Terminal
    {
        [DataMember]
        public string IPAddress { get; set; }
        [DataMember]

        public SwipeStatus SwipeStatus { get; set; }

        public Terminal(Random random)
        {
            IPAddress = new IpGenerator(random).GetRandomIpAddress();
        }
    }
}