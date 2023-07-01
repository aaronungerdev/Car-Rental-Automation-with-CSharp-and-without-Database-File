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
    public partial class FrmListVehicle : Form
    {
        Araç_Kiralama araçkiralama=new Araç_Kiralama();
        public FrmListVehicle()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            Plakatxt.Text = satır.Cells["LP"].Value.ToString();
            Markatxt.Text = satır.Cells["Brand"].Value.ToString();
            Seritxt.Text = satır.Cells["Series"].Value.ToString();
            Yiltxt.Text = satır.Cells["Model"].Value.ToString();
            Renktxt.Text = satır.Cells["Color"].Value.ToString();
            Kmtxt.Text = satır.Cells["Km"].Value.ToString();
            Yakıttxt.Text = satır.Cells["Fuel"].Value.ToString();
            Kiratxt.Text = satır.Cells["RentalPrice"].Value.ToString();
            ResimBox.Text = satır.Cells["Picture"].Value.ToString();
            
            


        }

        private void FrmListVehicle_Load(object sender, EventArgs e)
        {
            YenileAraçlarListesi();

        }

        private void YenileAraçlarListesi()
        {
            string cümle = "select *from Vehicle";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource=araçkiralama.listele(adtr2, cümle);
        }

        private void ResimEklebtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            ResimBox.ImageLocation = openFileDialog1.FileName;

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string cümle = "update Vehicle set Brand=@Brand,Series=@Series,Model=@Model,Color=@Color,Km=@Km,Fuel=@Fuel,RentalPrice=@RentalPrice,Picture=@Picture,Date=@Date where LP=@LP";
            SqlCommand komut2=new SqlCommand();
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
            araçkiralama.ekle_sil_güncelle(komut2,cümle);
            Seritxt.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            YenileAraçlarListesi();
            ResimBox.ImageLocation = "";
            MessageBox.Show("Updated!");

        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from Vehicle where LP='" + satır.Cells["LP"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            araçkiralama.ekle_sil_güncelle(komut2, cümle);
            YenileAraçlarListesi();
            ResimBox.ImageLocation = "";
            Seritxt.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            MessageBox.Show("Deleted!");
        }

        private void Cancel2btn_Click(object sender, EventArgs e)
        {
            this.Close();
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
                else if (Markatxt.SelectedIndex == 1)
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

        private void AraçListCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(AraçListCombo.SelectedIndex == 0)
                {
                    YenileAraçlarListesi();
                }
                if (AraçListCombo.SelectedIndex == 1)
                {
                    string cümle = "select *from Vehicle where State='available'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = araçkiralama.listele(adtr2, cümle);
                }
                if(AraçListCombo.SelectedIndex == 2)
                {
                    string cümle = "select *from Vehicle where State='busy' ";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = araçkiralama.listele(adtr2, cümle);
                }
            }
            catch 
            {

                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
