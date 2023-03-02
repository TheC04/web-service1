using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }

    public class amswer_calc
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
