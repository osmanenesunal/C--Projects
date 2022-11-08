using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Personel_Kayit
{
    public partial class formGrafik : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=OSMAN\\SQLEXPRESS;Initial Catalog=Personel_İslem;Integrated Security=True");
        public formGrafik()
        {
            InitializeComponent();
        }

        private void formGrafik_Load(object sender, EventArgs e)
        {
            //grafik1
            baglanti.Open();
            SqlCommand komutgrf1 = new SqlCommand("select persehir ,count(*) from tbl_personell group by persehir ",baglanti);
            SqlDataReader rdgrf1 = komutgrf1.ExecuteReader();

            while (rdgrf1.Read())
            {

                chart1.Series["Sehirler"].Points.AddXY(rdgrf1[0],rdgrf1[1]) ;

            }


            baglanti.Close();



            //grafik 2


            baglanti.Open();

            SqlCommand komutgrf2 = new SqlCommand("Select permeslek , sum(permaas) from tbl_personell group by permeslek ",baglanti);
            SqlDataReader rdgrf2 = komutgrf2.ExecuteReader();

            while (rdgrf2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(rdgrf2[0],rdgrf2[1]);
            }



            baglanti.Close();


























        }
    }
}
