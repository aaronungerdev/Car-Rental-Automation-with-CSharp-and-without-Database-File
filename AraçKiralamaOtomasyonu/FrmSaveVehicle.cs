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
    public partial class FrmSaveVehicle : Form
    {
        Araç_Kiralama araçkiralama=new Araç_Kiralama();
        public FrmSaveVehicle()
        {
            InitializeComponent();
        }

        

        private void ResimEklebtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            ResimBox.ImageLocation = openFileDialog1.FileName;
        }

       

        private void Markatxt_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                Seritxt.Items.Clear();
                if (Markatxt.SelectedIndex == 0)
                {
                    Seritxt.Items.Add("Astra");
                    Seritxt.Items.Add("Vectra");
                    Seritxt.Items.Add("Corsa");
                }
                else if(Markatxt.SelectedIndex == 1)
                {
                    Seritxt.Items.Add("Megane");
                    Seritxt.Items.Add("Cilo");
                    
                }
                else if (Markatxt.SelectedIndex == 2)
                {
                    Seritxt.Items.Add("Linea");
                    Seritxt.Items.Add("Egea");
                    
                }
                else if (Markatxt.SelectedIndex == 3)
                {
                    Seritxt.Items.Add("Fiesta");
                    Seritxt.Items.Add("Focus");
                    
                }


            }
            catch
            {

            }
            
        }

        private void Kayıtbtn_Click(object sender, EventArgs e)
        {
            string cümle = "insert into Vehicle(LP,Brand,Series,Model,Color,Km,Fuel,RentalPrice,Picture,State,Date) values(@LP,@Brand,@Series,@Model,@Color,@Km,@Fuel,@RentalPrice,@Picture,@State,@Date)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@LP",Plakatxt.Text);
            komut2.Parameters.AddWithValue("@Brand", Markatxt.Text);
            komut2.Parameters.AddWithValue("@Series", Seritxt.Text);
            komut2.Parameters.AddWithValue("@Model", Yiltxt.Text);
            komut2.Parameters.AddWithValue("@Color", Renktxt.Text);
            komut2.Parameters.AddWithValue("@Km", Kmtxt.Text);
            komut2.Parameters.AddWithValue("@Fuel", Yakıttxt.Text);
            komut2.Parameters.AddWithValue("@RentalPrice", Kiratxt.Text);
            komut2.Parameters.AddWithValue("@Picture", ResimBox.Text);
            komut2.Parameters.AddWithValue("@Date", DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@State", "available");
            araçkiralama.ekle_sil_güncelle(komut2, cümle);
            Seritxt.Items.Clear();
            MessageBox.Show("Saved Vehicle!");
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            ResimBox.ImageLocation = "";


        }

        private void FrmSaveVehicle_Load(object sender, EventArgs e)
        {

        }
    }
}
