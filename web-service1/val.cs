using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

namespace web_service1
{

    public partial class val : Form
    {

        static HttpClient client = new HttpClient();

        public val()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await get();
        }
        async Task<answer_val> get()
        {
            answer_val product = null;
            //vatID per testing IE 6388047 V
            VATid.Text = VATid.Text.Replace(" ", "");
            string url = "https://vat.abstractapi.com/v1/validate/?api_key=19df3dac00a5401e9cd193d06047b70a&vat_number="+VATid.Text;
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                product = await JsonSerializer.DeserializeAsync<answer_val>(await response.Content.ReadAsStreamAsync());
                if(product.valid)
                {
                    label2.Text = product.tostring();
                }
                else
                {
                    label2.Text = "VatID non valido";
                }
                label2.Location = new Point((ClientSize.Width / 2) - (label2.Width / 2), (ClientSize.Height / 2) - (label2.Height / 2));
            }
            return product;
        }
    }

    public class answer_val
    {
        public string vat_number { get; set; }
        public bool valid { get; set; }
        public Company company { get; set; }
        public Country country { get; set; }
        public string tostring()
        {
            string s;
            if (valid)
            {
                s = "VATid valido";
            }
            else
            {
                s = "VATid non valido";
            }
            return "VATid: " + vat_number + "\n" + s + "\n" + company.tostring() + country.tostring();
        }
    }

    public class Company
    {
        public string name { get; set; }
        public string address { get; set; }
        public string tostring()
        {
            return "Nome compagnia: "+name + "\n" +"Indirizzo: "+ address.Replace(',', '\n') + "\n";
        }
    }
}


