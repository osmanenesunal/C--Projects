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
namespace Hospital_Project
{
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastKayit frm = new FrmHastKayit();
            frm.Show();




        }

        private void btngiris_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select * from Tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskdtcno.Text);
            komut.Parameters.AddWithValue("@p2",txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                FrmHastaDetay frm = new FrmHastaDetay();
                frm.tc = mskdtcno.Text;
                frm.Show();
                this.Hide();



            }

            else
            {
                MessageBox.Show("TC & Sifre Hatalıdır", "Hata",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning );
            }

            bgl.baglanti().Close();

        }
        
        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {
            
        }
    }
}
