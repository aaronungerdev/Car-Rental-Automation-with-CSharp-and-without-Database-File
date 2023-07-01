using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraçKiralamaOtomasyonu
{
    public class Araç_Kiralama
    {
        SqlConnection baglanti = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=RentACar;integrated security=true");

        DataTable tablo;
        public void ekle_sil_güncelle(SqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

        public void bos_araclar(ComboBox combo, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["LP"].ToString());
            }
            baglanti.Close();
        }

        public void tc_ara(TextBox ID, TextBox Name, TextBox Surname, TextBox Phone, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ID.Text = read["ID"].ToString();
                Name.Text = read["Name"].ToString();
                Surname.Text = read["Surname"].ToString();
                Phone.Text = read["Phone"].ToString();
            }
            baglanti.Close();
        }

        public void CombodanGetir(TextBox Marka, TextBox Seri, TextBox Yil, TextBox Renk, string sorgu, ComboBox araclar)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                Marka.Text = read["Brand"].ToString();
                Seri.Text = read["Series"].ToString();
                Yil.Text = read["Model"].ToString();
                Renk.Text = read["Color"].ToString();
            }
            baglanti.Close();
        }

        public void Ücret_Hesapla(ComboBox combokiraşekli, TextBox ucret, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (combokiraşekli.SelectedIndex == 0) ucret.Text = (int.Parse(read["RentalPrice"].ToString()) * 1).ToString();
                if (combokiraşekli.SelectedIndex == 1) ucret.Text = (int.Parse(read["RentalPrice"].ToString()) * 0.80).ToString();
                if (combokiraşekli.SelectedIndex == 2) ucret.Text = (int.Parse(read["RentalPrice"].ToString()) * 0.70).ToString();
            }
            baglanti.Close();
        }

        public void SatışHesapla(Label lbl)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Amount) from Sales",baglanti);
            lbl.Text = "Total Amount=" + komut.ExecuteScalar() + "USD";
            baglanti.Close();
        }
    }
}
