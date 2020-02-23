using System;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.Xml;

namespace RSSFeedReaderTest
{
    class Program
    {
        public static object SyndicationFeed { get; private set; }

        static void Main(string[] args)
        {
            string url = "https://news.google.com/rss?hl=en-US&tab=wn&gl=US&ceid=US:en";

            using (XmlReader reader = XmlReader.Create(url))
            {
            }
        }
    }
}
