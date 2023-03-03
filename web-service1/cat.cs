using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web_service1
{
    public partial class cat : Form
    {

        static HttpClient client = new HttpClient();

        public cat()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await (get());
        }

        async Task<List<answer_cat>> get()
        {
            //non va, json non formattato bene
            string s = nation.SelectedItem.ToString().Substring(0, 2), a="";
            string url = "https://vat.abstractapi.com/v1/categories?api_key=19df3dac00a5401e9cd193d06047b70a&country_code=DE";
            List<answer_cat> resp = new List<answer_cat>();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                resp = JsonSerializer.Deserialize<List<answer_cat>>(await response.Content.ReadAsStreamAsync());
                MessageBox.Show(response.ToString());
                string str = ""; foreach (answer_cat ansa in resp)
                {
                    str += ansa.ToString();
                }
                MessageBox.Show(str);
                foreach (answer_cat answer in resp)
                {
                    a += answer.tostring();
                }
                textBox1.Text = a;
                //textBox1 = new Point((ClientSize.Width / 2) - (label2.Width / 2), (ClientSize.Height / 2) - (label2.Height / 2));
            }
            return resp;
        }
    }
    public class answer_cat
    {
        public rates[] Property1 { get; set; }

        public string tostring()
        {
            string s = "";
            foreach(rates rate in Property1)
            {
                s += rate.tostring();
            }
            return s;
        }
    }

    public class rates
    {
        public string country_code { get; set; }
        public float rate { get; set; }
        public string category { get; set; }
        public string description { get; set; }

        public string tostring()
        {
            return "Nazione: " + country_code + "\nPercentuale vat: " + (rate * 100).ToString() + "%\nCategoria: " + category + "\nDescrizione: " + description;
        }
    }

}
