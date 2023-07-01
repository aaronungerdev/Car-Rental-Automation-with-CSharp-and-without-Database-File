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
    public partial class FrmListCustomer : Form
    {
      Araç_Kiralama araçkiralama=new Araç_Kiralama();
        
        public FrmListCustomer()
        {
            InitializeComponent();
        }

        public void FrmListCustomer_Load(object sender, EventArgs e)
        {
            YenileListele();

        }

        public void YenileListele()
        {
            string cümle = "select *from Customer";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            
            dataGridView1.DataSource = araçkiralama.listele(adtr2, cümle);
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "NAME";
            dataGridView1.Columns[2].HeaderText = "SURNAME";
            dataGridView1.Columns[3].HeaderText = "PHONE";
            dataGridView1.Columns[4].HeaderText = "ADRESS";
            dataGridView1.Columns[5].HeaderText = "EMAIL";
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string cümle = "update Customer set Name=@Name,Surname=@Surname,Phone=@Phone,Adress=@Adress,Email=@Email where ID=@ID";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@ID", Tctxt.Text);
            komut2.Parameters.AddWithValue("@Name", Nametxt.Text);
            komut2.Parameters.AddWithValue("@Surname", Surnametxt.Text);
            komut2.Parameters.AddWithValue("@Phone", Phonetxt.Text);
            komut2.Parameters.AddWithValue("@Adress", Addresstxt.Text);
            komut2.Parameters.AddWithValue("@Email", Mailtxt.Text);
            araçkiralama.ekle_sil_güncelle(komut2, cümle);
            foreach (Control control in Controls) if (control is TextBox) control.Text = "";
            MessageBox.Show("Updated!");
            araçkiralama.ekle_sil_güncelle(komut2, cümle);
            YenileListele();

        }

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select *from Customer where ID like'%"+Searchtxt.Text+"%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
           
            dataGridView1.DataSource = araçkiralama.listele(adtr2, cümle);
        }

        private void İptalbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;

            Tctxt.Text = satır.Cells[0].Value.ToString();
            Nametxt.Text = satır.Cells[1].Value.ToString();
            Surnametxt.Text = satır.Cells[2].Value.ToString();
            Phonetxt.Text = satır.Cells[3].Value.ToString();
            Addresstxt.Text = satır.Cells[4].Value.ToString();
            Mailtxt.Text = satır.Cells[5].Value.ToString();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır= dataGridView1.CurrentRow;
            string cümle = "delete from Customer where ID='" + satır.Cells["ID"].Value.ToString() + "'";
            SqlCommand komut3 = new SqlCommand();
            araçkiralama.ekle_sil_güncelle(komut3, cümle);
            foreach (Control control in Controls) if (control is TextBox) control.Text = "";
            MessageBox.Show("Deleted!");
            araçkiralama.ekle_sil_güncelle(komut3, cümle);
            YenileListele();


        }
    }
}
