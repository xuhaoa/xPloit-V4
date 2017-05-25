using System;
using System.Net;

namespace xPloit_V4
{
    class Client
    {
        WebClient wc = new WebClient();

        //URL Exists:
        public bool URLExists(string URL)
        {
            try
            {
                wc.DownloadString(URL);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Get URL Source:
        public string getURLSource(string URL)
        {
            string src = wc.DownloadString(URL);
            return src;
        }

        //Resolve IP:
        public string resolveIP(string hostname)
        {
            try
            {
                return Dns.GetHostAddresses(hostname)[0].ToString();
            }
            catch
            {
                return "";
            }
        }
    }
}