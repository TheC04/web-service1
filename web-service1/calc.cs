using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace web_service1
{
    public partial class calc : Form
    {
        static HttpClient client = new HttpClient();

        public calc()
        {
            InitializeComponent();
            categories.Hide();
        }

        private void nation_SelectedIndexChanged(object sender, EventArgs e)
        {
            loading.Text = "Loading...";
            loading.Show();
            getC();
        }
        async Task<IEnumerable<answer_cat>> getC()
        {
            string s = nation.SelectedItem.ToString().Substring(0, 2);
            string url = "https://vat.abstractapi.com/v1/categories?api_key=19df3dac00a5401e9cd193d06047b70a&country_code=" + s;
            IEnumerable<answer_cat> resp = new List<answer_cat>();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                resp = JsonSerializer.Deserialize<List<answer_cat>>(await response.Content.ReadAsStreamAsync());
                foreach (answer_cat answer in resp)
                {
                    categories.Items.Add(answer.category);
                }
                loading.Hide();
                categories.Show();
            }
            return resp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            get();
        }

        async Task<answer_calc> get()
        {
            answer_calc product = null;
            string url = "https://vat.abstractapi.com/v1/calculate?api_key=19df3dac00a5401e9cd193d06047b70a&amount=" + amount.Value + "&country_code=" + nation.SelectedItem.ToString().Split('(')[0];
            if (categories.SelectedIndex > 0)
            {
                url += "&vat_category=" + categories.SelectedItem;
            }
            if (included.Checked)
            {
                url += "&is_vat_incl=true";
            }
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                product = await JsonSerializer.DeserializeAsync<answer_calc>(await response.Content.ReadAsStreamAsync());
                ans.Text = product.tostring();
            }
            loading.Text = "";
            loading.Show();
            categories.Hide();
            amount.Value = 0;
            included.Checked=false;
            return product;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }

    public class answer_calc
    {
        public string amount_excluding_vat { get; set; }
        public string amount_including_vat { get; set; }
        public string vat_amount { get; set; }
        public string vat_category { get; set; }
        public string vat_rate { get; set; }
        public Country country { get; set; }

        public string tostring()
        {
            return "Amount: " + this.amount_excluding_vat + "\nAmount with VAT: " + this.amount_including_vat + "\nVAT amount: " + this.vat_amount + "\nCategory: " + this.vat_category + "\nVAT percentage: " + (double.Parse(vat_rate) * 0.1).ToString() +"%\n" + this.country.tostring();
        }
    }
}