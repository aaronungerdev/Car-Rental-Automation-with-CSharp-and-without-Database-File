using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraçKiralamaOtomasyonu
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmListCustomer frmListCustomer = new FrmListCustomer();
            frmListCustomer.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerAddPage ekle=new CustomerAddPage();
            ekle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSaveVehicle kayıt=new FrmSaveVehicle();
            kayıt.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmListVehicle Listele=new FrmListVehicle();
            Listele.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmContract contract = new FrmContract();
            contract.ShowDialog();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmSales sales = new FrmSales();
            sales.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
