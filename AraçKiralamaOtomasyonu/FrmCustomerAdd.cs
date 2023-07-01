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
    public partial class CustomerAddPage : Form
    {
        Araç_Kiralama arac=new Araç_Kiralama();
       
        public CustomerAddPage()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            
            string cümle = "insert into Customer(ID,Name,Surname,Phone,Adress,Email) values(@ID,@Name,@Surname,@Phone,@Adress,@Email)";
            SqlCommand komutadd = new SqlCommand();
            komutadd.Parameters.AddWithValue("@ID", Tctxt.Text);
            komutadd.Parameters.AddWithValue("@Name", Nametxt.Text);
            komutadd.Parameters.AddWithValue("@Surname", Surnametxt.Text);
            komutadd.Parameters.AddWithValue("@Phone", Phonetxt.Text);
            komutadd.Parameters.AddWithValue("@Adress", Addresstxt.Text);
            komutadd.Parameters.AddWithValue("@Email", Mailtxt.Text);
            arac.ekle_sil_güncelle(komutadd,cümle);
            foreach (Control control in Controls) if (control is TextBox) control.Text = "";
            MessageBox.Show("Added!");

        }

        private void NameSurnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerAddPage_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
