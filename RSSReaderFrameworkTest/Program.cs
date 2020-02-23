using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RSSReaderFrameworkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://news.google.com/news/rss";


            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            foreach (SyndicationItem item in feed.Items)
            {
                Console.WriteLine($"Title: {item.Title.Text} \nSummary: {item.Summary.Text} \nLink{item.Links}");
            }


            Console.ReadKey();
        }
    }
}
