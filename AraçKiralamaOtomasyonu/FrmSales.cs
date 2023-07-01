using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraçKiralamaOtomasyonu
{
    public partial class FrmSales : Form
    {
        Araç_Kiralama aracKiralama = new Araç_Kiralama();

        public FrmSales()
        {
            InitializeComponent();
        }

        private void FrmSales_Load(object sender, EventArgs e)
        {
            string sorgu2 = "select *from Sales";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = aracKiralama.listele(adtr2,sorgu2);
            aracKiralama.SatışHesapla(label1);
        }
    }
}
