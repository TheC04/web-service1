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
        async Task<Root> get()
        {
            Root product = null;
            string url = "https://vat.abstractapi.com/v1/validate/?api_key=19df3dac00a5401e9cd193d06047b70a&vat_number="+VATid.Text;
            HttpResponseMessage response = await client.GetAsync(url);
            MessageBox.Show(response.ToString());
            if (response.IsSuccessStatusCode)
            {
                product = await JsonSerializer.DeserializeAsync<Root>(await response.Content.ReadAsStreamAsync());
                MessageBox.Show(product.tostring());
                label2.Text = product.tostring();
            }
            return product;
        }
    }

    public class Root
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
            return "Nome compagnia: "+name + "\n" +"Indirizzo: "+address + "\n";
        }
    }

    public class Country
    {
        public string code { get; set; }
        public string name { get; set; }
        public string tostring()
        {
            return "Nazione: " + name + "(" + code + ")";
        }
    }


}


