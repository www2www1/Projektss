using projekt.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace projekt
{


    public partial class Form1 : Form
    {
        public static List<string> Category = new List<string>{"Konst","Komedi","Utbildning","Spel",
        "Hälsa","Musik","Politik","Samhälle","Sport","Teknologi","Skräck"};

        public Dictionary<string, int> source = new Dictionary<string, int>();
        public Data ss;
        public String[,] rssData = null;
        public Validering validator = new Validering();
        public AllaFeeds AllFeeds;
        public RssFeed Rss;
        public List<RssFeed> listofRss;
        public Form1()
        {
            InitializeComponent();
            // Gör så att hela raden markeras när man väljer den:
            source.Add("Hourly", 3600000);
            source.Add("Daily", 3600000 * 24);
            source.Add("Weekly", 3600000 * 96);
            lvPodcast.FullRowSelect = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var ListOfEpisodes = new List<Episode>();
            var podcast = new Podcast();
            var Allfeeds = new AllaFeeds();
            string url = "1";
            loadPodCast(url);


            CBKatigorier();
            UpdateInterval(tbUF);
        }


        public void loadPodCast(string url)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("Feeds.xml");

            System.Xml.XmlNodeList rssItems = doc.SelectNodes("ArrayOfRssFeed/RssFeed");
            foreach (XmlNode RssFeed in rssItems)
            {
                var UrlRss = RssFeed.SelectSingleNode("Url").InnerText;

                int.TryParse(RssFeed.SelectSingleNode("Updating").InnerText, out int UpdatingRss);
                var CateRss = RssFeed.SelectSingleNode("Category").InnerText;
                System.Net.WebRequest myRequest = System.Net.WebRequest.Create(UrlRss);
                System.Net.WebResponse myResponse = myRequest.GetResponse();
                System.IO.Stream rssStream = myResponse.GetResponseStream();
                System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();
                rssDoc.Load(rssStream);
                rssStream.Close();
                System.Xml.XmlNode rssName = rssDoc.SelectSingleNode("rss/channel");
                var podcastName = rssName.InnerText;
                System.Xml.XmlNodeList xx = rssDoc.SelectNodes("rss/channel/item");
                int antalEpisoder = xx.Count;

                string frekvens = source.FirstOrDefault(x => x.Value == UpdatingRss).Key;
                string[] RowPodCast = { antalEpisoder.ToString(), podcastName, frekvens, CateRss, UrlRss };
                var listItem = new ListViewItem(RowPodCast);

                lvPodcast.Items.Add(listItem);
            }


        }



        //en metod för att fylla combo boxen med olika alternativ ///
        public void CBKatigorier()
        {
            foreach (string cato in Category)
            {
                CBC.Items.Add(cato);
                comboBox3.Items.Add(cato);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            var datan = new Data();
            var Url = tbUrl.Text;
            if (Validering.urlValidation(Url))
            {
                lbEpisode.Items.Clear();
                rssData = getRssData(tbUrl.Text);
                for (int i = 0; i < rssData.GetLength(0); i++)
                {

                    if (rssData[i, 0] != null)
                    {
                        lbEpisode.Items.Add(rssData[i, 0]);
                    }
                }
            }
        }


        //spara feedden 
        private void btUrlSpara_Click(object sender, EventArgs e)
        {

            lvPodcast.Items.Clear();
            var Url = tbUrl.Text;
            loadPodCast(Url);

            var Validering = validator;

            int frekvens = 0;

            if (Validering.validateCategory(CBC) && Validering.intervalBoxNotEmpty(tbUF))
            {
                string category = CBC.SelectedItem.ToString();
                if (source.ContainsKey(tbUF.Text))
                {
                    frekvens = source[tbUF.Text];


                    if (Validering.urlValidation(Url))
                    {
                        var listOfFeeds = new AllaFeeds();
                        listOfFeeds.allaFeeds(new RssFeed(Url, frekvens, category));
                    }

                }
            }
        }
        public void listviwed(string[,] getRssData)
        {
            lbEpisode.Items.Clear();
            for (int i = 0; i < getRssData.GetLength(0); i++)
            {
                if (getRssData[i, 0] != null)
                {
                    lbEpisode.Items.Add(getRssData[i, 0]);
                    linkLabel.Text = rssData[i, 2];
                }
            }
        }

        private void btUrlTaBort_Click(object sender, EventArgs e)
        {
            string url = "";
            string sss = lvPodcast.SelectedItems[0].SubItems[4].Text;

            XmlDocument doc = new XmlDocument();
            doc.Load("Feeds.xml");
            System.Xml.XmlNodeList rssItems = doc.SelectNodes("ArrayOfRssFeed/RssFeed");

            foreach (XmlNode node in rssItems)
            {
                System.Xml.XmlNode rssNodeTitle = node.SelectSingleNode("Url");
                if (rssNodeTitle.InnerText == sss)
                {
                    XmlNode parent = node.ParentNode;
                    parent.RemoveChild(node);
                }
            }
            doc.Save("Feeds.xml");
            lvPodcast.Items.Clear();
            lbEpisode.Items.Clear();
            loadPodCast(url);
        }

        private String[,] getRssData(String channel)
        {
            System.Net.WebRequest myRequest = System.Net.WebRequest.Create(channel);
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

        private void lbEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbEpisode.SelectedIndex;
            richTextBox1.Text = rssData[index, 1];
            linkLabel.Text = rssData[index, 2];
        }


        private void btSpara_Click(object sender, EventArgs e)
        {

            var sss = tbUrl.Text;
            XmlDocument doc = new XmlDocument();
            doc.Load("Feeds.xml");
            System.Xml.XmlNodeList rssItems = doc.SelectNodes("ArrayOfRssFeed/RssFeed");

            foreach (XmlNode node in rssItems)
            {
                System.Xml.XmlNode rssNodeCate = node.SelectSingleNode("Category");
                if (rssNodeCate.InnerText == sss)
                {
                    XmlNode parent = node.ParentNode;
                }
            }
            doc.Save("Feeds.xml");

        }

        private void tbUF_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        public void UpdateInterval(ComboBox boxen)
        {

            foreach (var item in source)
            {
                boxen.Items.Add(item.Key);
            }
        }


        ///sortera Podcast efter vald category
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvPodcast.Items.Clear();
            string cate = comboBox3.SelectedItem.ToString();
            XmlDocument doc = new XmlDocument();
            doc.Load("Feeds.xml");
            System.Xml.XmlNodeList rssItems = doc.SelectNodes("ArrayOfRssFeed/RssFeed");

            foreach (XmlNode node in rssItems)
            {
                string rssNodeCate = node.SelectSingleNode("Category").InnerText;
                string rssUpdate = node.SelectSingleNode("Updating").InnerText;
                if (rssNodeCate == cate)
                {
                    string rssCate = node.SelectSingleNode("Url").InnerText;

                    showASpecPodcast(rssCate, rssNodeCate, rssUpdate);
                }

            }
        }
        public void showASpecPodcast(string rss, string xmlCate, string XmlUpdate)
        {

            System.Net.WebRequest myRequest = System.Net.WebRequest.Create(rss);
            System.Net.WebResponse myResponse = myRequest.GetResponse();

            System.IO.Stream rssStream = myResponse.GetResponseStream();
            System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();

            rssDoc.Load(rssStream);
            rssStream.Close();
            System.Xml.XmlNode rssName = rssDoc.SelectSingleNode("rss/channel");
            var podcastName = rssName.InnerText;
            System.Xml.XmlNodeList xx = rssDoc.SelectNodes("rss/channel/item");
            int antalEpisoder = xx.Count;
            int.TryParse(XmlUpdate, out int XmlUpdateint);
            string frekvens = source.FirstOrDefault(x => x.Value == XmlUpdateint).Key;
            string[] RowPodCast = { antalEpisoder.ToString(), podcastName, frekvens, xmlCate, rss };
            var listItem = new ListViewItem(RowPodCast);
            lbEpisode.Items.Clear();
            lvPodcast.Items.Add(listItem);
        }

        private void btNy_Click(object sender, EventArgs e)
        {
            if(Validering.intervalBoxNotEmpty(textBox1))
            if (comboBox3.Items.Contains(textBox1.Text))
            {
                MessageBox.Show("Vänligen ange en kategori som inte finns");
            }
            else
            {
                MessageBox.Show("Kategorin har lagts till");
                CBC.Items.Add(textBox1.Text);
                comboBox3.Items.Add(textBox1.Text);

            }
            UpdateInterval(tbUF);

        }

        private void lvPodcast_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            lbEpisode.Items.Clear();
            if (lvPodcast.SelectedItems.Count > 0)
            {
                string url = lvPodcast.SelectedItems[0].SubItems[4].Text;
                rssData = getRssData(url);
                listviwed(rssData);

            }
        }

        private void btTaBort_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The following category has been removed : " + comboBox3.Text);
            CBC.Items.Remove(comboBox3.Text);
            comboBox3.Items.Remove(comboBox3.Text);
        }
    }
}





