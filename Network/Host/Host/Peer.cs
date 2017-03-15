using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Net.NetworkInformation;

namespace Host
{
    class Peer
    {
        public string Name { get; set; }
        public EndPoint EP { get; set;}
        public DateTime ConnectionTimestamp { get; set; }

        public Peer(string name, EndPoint ep)
        {
            Name = name;
            EP = ep;
            ConnectionTimestamp = DateTime.Now;
        }
        public override string ToString()
        {
            if (Name != "")
            {
                return Name;
            }
            else
            {
                return EP.ToString();
            }
        }
    }
}
