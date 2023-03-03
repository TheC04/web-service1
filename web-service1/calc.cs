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

namespace web_service1
{
    public partial class calc : Form
    {
        public calc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            get();
        }

         async Task<answer_calc> get()
         {
             answer_calc product = null;
             //https://vat.abstractapi.com/v1/calculate?api_key=YOUR_API_KEY&amount=535&country_code=DE&vat_category=books&is_vat_incl=true
             string url = "https://vat.abstractapi.com/v1/validate/?api_key=19df3dac00a5401e9cd193d06047b70a&vat_number=";
             /*HttpResponseMessage response = await client.GetAsync(url);
             if (response.IsSuccessStatusCode)
             {
                 product = await JsonSerializer.DeserializeAsync<answer_calc>(await response.Content.ReadAsStreamAsync());
                 if (product.valid)
                 {
                     label2.Text = product.tostring();
                 }
                 else
                 {
                     label2.Text = "VatID non valido";
                 }
                 label2.Location = new Point((ClientSize.Width / 2) - (label2.Width / 2), (ClientSize.Height / 2) - (label2.Height / 2));
             }*/
             return product;
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
            return "Imposto non tassato: "+amount_excluding_vat+"\nImporto tassato:"+amount_including_vat + "\nValore tassa:" + vat_amount+ "\nCategoria prodotto:" + vat_category+ "\nPercentuale Vat:" +(int.Parse(vat_rate)*100).ToString()+"%\n"+this.country.tostring();
        }
    }
}
