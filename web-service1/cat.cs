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

        async Task<IEnumerable<answer_cat>> get()
        {
            string s = nation.SelectedItem.ToString().Substring(0, 2), a="";
            string url = "https://vat.abstractapi.com/v1/categories?api_key=19df3dac00a5401e9cd193d06047b70a&country_code=" + s;
            IEnumerable<answer_cat> resp = new List<answer_cat>();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                resp = JsonSerializer.Deserialize<List<answer_cat>>(await response.Content.ReadAsStreamAsync());
                string str = ""; foreach (answer_cat ansa in resp)
                {
                    str += ansa.ToString();
                }
                foreach (answer_cat answer in resp)
                {
                    a += answer.tostring() + Environment.NewLine + Environment.NewLine;
                }
                textBox1.Text = a;
            }
            return resp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }

    class answer_cat
    {
        public string country_code { get; set; }
        public string rate { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public string tostring()
        {
            return "Category: " + this.category + Environment.NewLine + "VAT percentage: " + (double.Parse(this.rate) * 0.1).ToString() + "%";
        }
    }
}
