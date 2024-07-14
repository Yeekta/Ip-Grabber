using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace IpLogger
{
    internal class Grabber
    {
        public static string GetIp()
        {
            string ip = new WebClient().DownloadString("https://api.ipify.org/");
            return ip;


        }

    }
}
