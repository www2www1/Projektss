namespace projekt.classes
{
    public class RssFeed
    {
        public string Url { set; get; }
        public int Updating { set; get; }
        public string Category { set; get; }
        

        public RssFeed(string url, int Updating, string Category)
        {
            this.Url = url;
            this.Updating = Updating;
            this.Category = Category;
      

        }
        public RssFeed() { }
     
    }
}
