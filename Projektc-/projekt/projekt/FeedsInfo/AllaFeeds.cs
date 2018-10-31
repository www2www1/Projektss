using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace projekt.classes
{
    public class AllaFeeds:RssFeed
    {
        List<RssFeed> ListOfFeeds = new List<RssFeed>();

        
       
public AllaFeeds() {

            ReadFreomXmlFile();
            getFeeds();
        }

        public void allaFeeds(RssFeed feed)
        {
            if (File.Exists(@"Feeds.xml"))

            {
                ReadFreomXmlFile();
                ListOfFeeds.Add(feed);
                SaveToXmlFile();
            }
            else
            {
                ListOfFeeds.Add(feed);
                SaveToXmlFile();
            }
        }

    
        public void DeleteFeed(string url)
        {
            foreach (RssFeed dd in ListOfFeeds)
            {
                if (dd.Url == url)
                {
                    ListOfFeeds.Remove(dd);
                    SaveToXmlFile();

                }
            }

        }
        public void SaveToXmlFile()
        {
            StreamWriter writer = new StreamWriter(@"Feeds.xml");
            XmlSerializer xs = new XmlSerializer(typeof(List<RssFeed>));
            xs.Serialize(writer, ListOfFeeds);
            writer.Close();
        }


        public  List<RssFeed> ReadFreomXmlFile()
        {
            StreamReader redaer = new StreamReader(@"Feeds.xml");
            XmlSerializer xs = new XmlSerializer(typeof(List<RssFeed>));
            ListOfFeeds = (List<RssFeed>)xs.Deserialize(redaer);
            redaer.Close();
            return ListOfFeeds;
        }

        public List<RssFeed> getFeeds() {
            return ListOfFeeds;
        }
    }


}
