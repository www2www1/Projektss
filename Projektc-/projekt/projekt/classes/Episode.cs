using System.Windows.Forms;

namespace projekt.classes
{
   public  class Episode:Podcast
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Episode(string Description, string Name)
        {
            this.Name = Name;
            this.Description = Description;

        }
        public Episode() { }

        public override ListViewItem TolistViewItem()
        {
            var listView = new ListViewItem(new[] {
                Name,
                Description
                
            });
            return listView;
        }
    }
}
