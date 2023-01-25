using bil203_Otopark_FinalProject.BusinessLayer;
using bil203_Otopark_FinalProject.Data;
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

namespace bil203_Otopark_FinalProject
{
    public partial class EditForm : Form
    {
        public AraclarModel aracmodeli { get; set; }
        public EditForm()
        {
           
            InitializeComponent();
            timer1.Start();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            BusinessCodes bs = new BusinessCodes();
            AraclarModel sonuc = bs.IdBilgisineGoreGetir(Convert.ToInt32(Form1.SetValueForText1.ToString()));
            aracmodeli = sonuc;
            txtnumberPlate.Text = sonuc.plaka; 
            txtBrandd.Text = sonuc.marka; 
            txtModell.Text = sonuc.model; 
            txtStatuss.Text = sonuc.icerdemi == 1 ? "aktif" : "pasif";  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtStatuss.Text == "aktif")
            {
                aracmodeli.icerdemi = 1;
            }
            else
            {
                aracmodeli.icerdemi = 0;
                aracmodeli.cikTar = DateTime.Now;
            }
            aracmodeli.plaka =  txtnumberPlate.Text;
            aracmodeli.marka = txtBrandd.Text;
            aracmodeli.model = txtModell.Text;
            BusinessCodes bs = new BusinessCodes();
            bool sonucx = bs.AracGuncelle(aracmodeli);
            if(sonucx==true)
            {
                MessageBox.Show("Successfully added");
                Form1 form1 = new Form1();
                form1.Show();  
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error received!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToLongTimeString();

        }

    }
}
