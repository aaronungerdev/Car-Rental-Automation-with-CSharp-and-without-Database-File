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
    public partial class FrmContract : Form
    {
        Araç_Kiralama aracKiralama = new Araç_Kiralama();

        public FrmContract()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmContract_Load(object sender, EventArgs e)
        {
            Boş_Araçlar();
            Yenile();
        }

        private void Boş_Araçlar()
        {
            string sorgu2 = "select *from Vehicle where State='available'";
            aracKiralama.bos_araclar(cbxVehicles, sorgu2);
        }

        private void Yenile()
        {
            string sorgu3 = "select *from Contracts";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = aracKiralama.listele(adtr2, sorgu3);
        }

        private void tbxId_TextChanged(object sender, EventArgs e)
        {
            if (tbxId.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "select *from Customer where ID like '" + tbxId.Text + "'";
            aracKiralama.tc_ara(tbxId, tbxName, tbxSurname, tbxPhone, sorgu2);
        }

        private void cbxVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from Vehicle where LP like '" + cbxVehicles.SelectedItem + "'";
            aracKiralama.CombodanGetir(tbxBrand, tbxSeries, tbxModel, tbxColor, sorgu2, cbxVehicles);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void cbxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from Vehicle where LP like '" + cbxVehicles.SelectedItem + "'";
            aracKiralama.Ücret_Hesapla(cbxRentalForm, tbxPrice, sorgu2);
        }

        private void tbxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(TimeReturn.Text) - DateTime.Parse(TimeRelease.Text);
            int gun2 = gun.Days;
            tbxDay.Text = gun2.ToString();
            tbxAmount.Text = (gun2 * int.Parse(tbxPrice.Text)).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            TimeRelease.Text = DateTime.Now.ToShortDateString();
            TimeReturn.Text = DateTime.Now.ToShortDateString();
            cbxRentalForm.Text = "";
            tbxPrice.Text = "";
            tbxDay.Text = "";
            tbxAmount.Text = "";

        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into Contracts(ID,Name,Surname,Phone,DLNo,DLDate,DLPlace,LP,Brand,Series,Model,Color,RentalForm,RentalPrice,Day,Amount,TimeRelease,TimeOfReturn)  values(@ID,@Name,@Surname,@Phone,@DLNo,@DLDate,@DLPlace,@LP,@Brand,@Series,@Model,@Color,@RentalForm,@RentalPrice,@Day,@Amount,@TimeRelease,@TimeOfReturn)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@ID", tbxId.Text);
            komut2.Parameters.AddWithValue("@Name", tbxName.Text);
            komut2.Parameters.AddWithValue("@Surname", tbxSurname.Text);
            komut2.Parameters.AddWithValue("@Phone", tbxPhone.Text);
            komut2.Parameters.AddWithValue("@DLNo", tbxDLNo.Text);
            komut2.Parameters.AddWithValue("@DLDate", tbxDLDate.Text);
            komut2.Parameters.AddWithValue("@DLPlace", tbxDLPlace.Text);
            komut2.Parameters.AddWithValue("@LP", cbxVehicles.Text);
            komut2.Parameters.AddWithValue("@Brand", tbxBrand.Text);
            komut2.Parameters.AddWithValue("@Series", tbxSeries.Text);
            komut2.Parameters.AddWithValue("@Model", tbxModel.Text);
            komut2.Parameters.AddWithValue("@Color", tbxColor.Text);
            komut2.Parameters.AddWithValue("@RentalPrice", int.Parse(tbxPrice.Text));
            komut2.Parameters.AddWithValue("@Day", int.Parse(tbxDay.Text));
            komut2.Parameters.AddWithValue("@RentalForm", cbxRentalForm.Text);
            komut2.Parameters.AddWithValue("@Amount", int.Parse(tbxAmount.Text));
            komut2.Parameters.AddWithValue("@TimeRelease", TimeReturn.Text);
            komut2.Parameters.AddWithValue("@TimeOfReturn", TimeRelease.Text);
            aracKiralama.ekle_sil_güncelle(komut2, sorgu2);

            string sorgu3 = "update Vehicle set State='busy' where LP='" + cbxVehicles.Text + "'";
            SqlCommand komut3 = new SqlCommand();
            aracKiralama.ekle_sil_güncelle(komut3, sorgu3);
            cbxVehicles.Items.Clear();
            Boş_Araçlar();
            Yenile();

            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
           
            Temizle();
            MessageBox.Show("Added Contract!");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tbxAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxSearchID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnUpdateContract_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update Contracts set ID=@ID,Name=@Name,Phone=@Phone,Surname=@Surname,DLNo=@DLNo,DLDate=@DLDate,DLPlace=@DLPlace,Brand=@Brand,Series=@Series,Model=@Model,Color=@Color,RentalForm=@RentalForm,RentalPrice=@RentalPrice,Day=@Day,Amount=@Amount,TimeRelease=@TimeRelease,TimeOfReturn=@TimeOfReturn";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@ID", tbxId.Text);
            komut2.Parameters.AddWithValue("@Name", tbxName.Text);
            komut2.Parameters.AddWithValue("@Surname", tbxSurname.Text);
            komut2.Parameters.AddWithValue("@Phone", tbxPhone.Text);
            komut2.Parameters.AddWithValue("@DLNo", tbxDLNo.Text);
            komut2.Parameters.AddWithValue("@DLDate", tbxDLDate.Text);
            komut2.Parameters.AddWithValue("@DLPlace", tbxDLPlace.Text);
            komut2.Parameters.AddWithValue("@LP", cbxVehicles.Text);
            komut2.Parameters.AddWithValue("@Brand", tbxBrand.Text);
            komut2.Parameters.AddWithValue("@Series", tbxSeries.Text);
            komut2.Parameters.AddWithValue("@Model", tbxModel.Text);
            komut2.Parameters.AddWithValue("@Color", tbxColor.Text);
            komut2.Parameters.AddWithValue("@RentalForm", cbxRentalForm.Text);
            komut2.Parameters.AddWithValue("@RentalPrice", int.Parse(tbxPrice.Text));
            komut2.Parameters.AddWithValue("@Day", int.Parse(tbxDay.Text));
            komut2.Parameters.AddWithValue("@Amount", int.Parse(tbxAmount.Text));
            komut2.Parameters.AddWithValue("@TimeRelease", TimeReturn.Text);
            komut2.Parameters.AddWithValue("@TimeOfReturn", TimeRelease.Text);
            aracKiralama.ekle_sil_güncelle(komut2, sorgu2);


            cbxVehicles.Items.Clear();
            Boş_Araçlar();
            Yenile();

            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            cbxVehicles.Text = "";
            Temizle();
            MessageBox.Show("Updated Contract!");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            tbxId.Text = satır.Cells[0].Value.ToString();
            tbxName.Text = satır.Cells[1].Value.ToString();
            tbxSurname.Text = satır.Cells[2].Value.ToString();
            tbxPhone.Text = satır.Cells[3].Value.ToString();
            tbxDLNo.Text = satır.Cells[4].Value.ToString();
            tbxDLDate.Text = satır.Cells[5].Value.ToString();
            tbxDLPlace.Text = satır.Cells[6].Value.ToString();
            cbxVehicles.Text = satır.Cells[7].Value.ToString();
            tbxBrand.Text = satır.Cells[8].Value.ToString();
            tbxSeries.Text = satır.Cells[9].Value.ToString();
            tbxModel.Text = satır.Cells[10].Value.ToString();
            tbxColor.Text = satır.Cells[11].Value.ToString();
            cbxRentalForm.Text = satır.Cells[12].Value.ToString();
            tbxPrice.Text = satır.Cells[13].Value.ToString();
            tbxDay.Text = satır.Cells[14].Value.ToString();
            tbxAmount.Text = satır.Cells[15].Value.ToString();
            TimeRelease.Text = satır.Cells[16].Value.ToString();
            TimeReturn.Text = satır.Cells[17].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            //Gün farkı hesaplama
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime dönüş = DateTime.Parse(satır.Cells["TimeOfReturn"].Value.ToString());
            int ücret = int.Parse(satır.Cells["RentalPrice"].Value.ToString());
            TimeSpan günfarkı = bugün - dönüş;
            int _günfarkı = günfarkı.Days;
            int ucretfarkı;
            //ücret farkı hesaplama
            ucretfarkı = _günfarkı * ücret;
            tbxReceivables.Text = ucretfarkı.ToString();
            //Toplam tutar hesaplama
        }

        private void btnDeliveryVehicle_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbxReceivables.Text)>=0 || int.Parse(tbxReceivables.Text) < 0)
            {
                DataGridViewRow satır = dataGridView1.CurrentRow;
                DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
                int ücret = int.Parse(satır.Cells["RentalPrice"].Value.ToString());
                int tutar = int.Parse(satır.Cells["Amount"].Value.ToString());
                DateTime çıkış = DateTime.Parse(satır.Cells["TimeRelease"].Value.ToString());
                TimeSpan gün = bugün - çıkış;
                int _gün = gün.Days;
                int toplamtutar = _gün * ücret;
                //Toplamtutar,gün ve ücret satış tablosuna aktarılacak

                string sorgu = "delete from Contracts where LP='" + satır.Cells["LP"].Value.ToString() + "'";
                SqlCommand komut = new SqlCommand();
                aracKiralama.ekle_sil_güncelle(komut, sorgu);

                string sorgu2 = "update Vehicle set State='available' where LP='" + satır.Cells["LP"].Value.ToString() + "'";
                SqlCommand komut2 = new SqlCommand();
                aracKiralama.ekle_sil_güncelle(komut2, sorgu2);

                string sorgu3 = "insert into Sales(ID,Name,Surname,LP,Brand,Series,Model,Color,Day,RentalPrice,Amount,TimeRelease,TimeOfReturn)  values(@ID,@Name,@Surname,@LP,@Brand,@Series,@Model,@Color,@Day,@RentalPrice,@Amount,@TimeRelease,@TimeOfReturn)";
                SqlCommand komut3 = new SqlCommand();
                komut3.Parameters.AddWithValue("@ID", satır.Cells["ID"].Value.ToString());
                komut3.Parameters.AddWithValue("@Name", satır.Cells["Name"].Value.ToString());
                komut3.Parameters.AddWithValue("@Surname", satır.Cells["Surname"].Value.ToString());
                komut3.Parameters.AddWithValue("@LP", satır.Cells["LP"].Value.ToString());
                komut3.Parameters.AddWithValue("@Brand", satır.Cells["Brand"].Value.ToString());
                komut3.Parameters.AddWithValue("@Series", satır.Cells["Series"].Value.ToString());
                komut3.Parameters.AddWithValue("@Model", satır.Cells["Model"].Value.ToString());
                komut3.Parameters.AddWithValue("@Color", satır.Cells["Color"].Value.ToString());
                komut3.Parameters.AddWithValue("@Day", _gün);
                komut3.Parameters.AddWithValue("@RentalPrice", ücret);
                komut3.Parameters.AddWithValue("@Amount", toplamtutar);
                komut3.Parameters.AddWithValue("@TimeRelease", satır.Cells["TimeRelease"].Value.ToString());
                komut3.Parameters.AddWithValue("@TimeOfReturn", DateTime.Now.ToShortDateString());
                aracKiralama.ekle_sil_güncelle(komut3, sorgu3);

                MessageBox.Show("The vehicle was delivered!");
                cbxVehicles.Text = "";
                cbxVehicles.Items.Clear();
                Boş_Araçlar();
                Yenile();

                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                cbxVehicles.Text = "";
                Temizle();

                tbxReceivables.Text = "";
            }
            else 
            {
                MessageBox.Show("PLease make selection!,Error");
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
