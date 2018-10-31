using System;
using System.Text;
using System.Windows.Forms;

namespace projekt
{
    public class Validering
    {

        
        public static bool urlValidation(string url)
        {
            try
            {
                //Here we are trying to download the file, if it doesn't work, the url is not a valid url.
                var xmlFile = "";
                using (var client = new System.Net.WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    xmlFile = client.DownloadString(url);
                    return true;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid url.");
                return false;
            }


        }
        public static bool validateCategory(ComboBox category)
        {
            if (category.Text == "")
            {
                MessageBox.Show("Url, Update-frequenzy and cathegory needs to be filled");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool intervalBoxNotEmpty(ComboBox inter) {
            if (inter.Text == "") {
                MessageBox.Show("Please choose an interval.");
                return false;
            } else {
                return true;
            }
        }
        public static bool intervalBoxNotEmpty(TextBox inter) {
            if (inter.Text == "") {
                MessageBox.Show("The new category-field can't be empty");
                return false;
            } else {
                return true;
            }
        }
    }
}



