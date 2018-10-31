using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace projekt.classes
{


    public class Podcast

    {
        public string Url { get; set; }
        public string CategoryOfPodcast { set; get; }
        public int TimeInterval { get; set; }
        public string NameOfPodCast { get; set; }
        public List<Episode> ListOFEpisode = new List<Episode>();
   

        public int AllaEpisode { get; set; }
        


        public Podcast(string Url, string CategoryOfPodcast, int TimeInterval, List<Episode> ListOFEpisode)
        {
            this.Url = Url;
            this.CategoryOfPodcast = CategoryOfPodcast;
            this.TimeInterval = TimeInterval;
            this.ListOFEpisode = ListOFEpisode;
            AllaEpisode = ListOFEpisode.Count();
        }

        public Podcast(string url) { }

        public Podcast()
        {
        }

        public virtual ListViewItem TolistViewItem()
        {
            var listView = new ListViewItem(new[] {
                AllaEpisode.ToString(),
                NameOfPodCast,
                TimeInterval.ToString(),
                CategoryOfPodcast

            });
            return listView;
        }

    }
}



