using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;

namespace dvfuApp
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

        private void lb1_Click(object senders, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string token = tbToken.Text;
                var base64EncodedBytes = System.Convert.FromBase64String(token);
                string tokenJsonString = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
                var tokenJson = JObject.Parse(tokenJsonString);
                var now = DateTimeOffset.Now.ToUnixTimeSeconds();
                if (now < Convert.ToInt64(tokenJson.SelectToken("expiration").Value<string>()))
                {
                    lbSuccess.Visible = false;
                    var main = new Resources.main();
                    this.Visible = false;
                    main.Show();
                }
                else
                    lbSuccess.Text = "Expired token";
                    lbSuccess.Visible = true;
            }
            catch(Exception ex)
            {
                lbSuccess.Text = "Incorrect token";
                lbSuccess.Visible = true;
            }
        }
    }
}
