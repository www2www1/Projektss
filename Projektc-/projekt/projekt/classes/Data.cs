using System;
using System.Net;
using System.Text;
using System.Xml;

namespace projekt
{

    public class Data

    {
        Form1 ss = new Form1();
        public Data() { }

    
     
        
        //för att hämta xml rss o spara den i en xml lockalt///
        public string[,] Sercher(string url)
        {
           

            string Stringxml = "";
            using (var client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                Stringxml = client.DownloadString(url);

                XmlDocument xml = new XmlDocument();
                xml.LoadXml(Stringxml);
             


                System.Net.WebRequest myRequest = System.Net.WebRequest.Create(url);
                System.Net.WebResponse myResponse = myRequest.GetResponse();

                System.IO.Stream rssStream = myResponse.GetResponseStream();
                System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();

                rssDoc.Load(rssStream);
                System.Xml.XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");



                String[,] tempRssData = new String[rssItems.Count, 3];
                for (int i = 0; i < rssItems.Count; i++)
                {


                    System.Xml.XmlNode rssNode;
                    rssNode = rssItems.Item(i).SelectSingleNode("title");

                    if (rssNode != null)
                    {

                        tempRssData[i, 0] = rssNode.InnerText;

                    }
                    else
                    {
                        tempRssData[i, 0] = "";

                    }

                    rssNode = rssItems.Item(i).SelectSingleNode("description");
                    if (rssNode != null)
                    {
                        tempRssData[i, 1] = rssNode.InnerText;

                    }
                    else
                    {
                        tempRssData[i, 1] = "";
                    }

                    rssNode = rssItems.Item(i).SelectSingleNode("link");
                    if (rssNode != null)
                    {
                        tempRssData[i, 2] = rssNode.InnerText;
                    }
                    else
                    {
                        tempRssData[i, 2] = "";
                    }



                }
                return tempRssData;
            }

        }




    }
}










