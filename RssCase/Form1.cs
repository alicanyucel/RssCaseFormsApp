using System.Xml;
namespace RssCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku = new XmlTextReader("http://www.milliyet.com.tr/rss/rssNew/ekonomiRss.xml");
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku2 = new XmlTextReader("http://www.hurriyet.com.tr/rss/anasayfa");
            while (xmloku2.Read())
            {
                if (xmloku2.Name == "title")
                {
                    listBox1.Items.Add(xmloku2.ReadString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku3 = new XmlTextReader("http://www.cumhuriyet.com.tr/rss/son_dakika.xml");
            while (xmloku3.Read())
            {
                if (xmloku3.Name == "title")
                {
                    listBox1.Items.Add(xmloku3.ReadString());
                }
            }
        }
    }
       
}
