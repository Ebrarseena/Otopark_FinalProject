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
    public partial class Form1 : Form
    {
        public static string SetValueForText1 = "";
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BusinessCodes bs = new BusinessCodes();
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = bs.AraclariGetir();    
            label10.Text = bs.OrtalamaSaatGetir().ToString();  
            label8.Text = (30- bs.AktifAracSayisiGetir()).ToString() + " Adet araç alınabilir..";  
            label13.Text = bs.UcretGetir().ToString();  
            label6.Text = bs.AktifAracSayisiGetir().ToString();     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusinessCodes bs = new BusinessCodes();
            AraclarModel arac = new AraclarModel
            {
                plaka = txtPlate.Text.ToString(),  
                marka = txtBrand.Text.ToString(),
                model = txtModel.Text.ToString(),
                girTar = dateTimePicker1.Value.Date,
                cikTar = dateTimePicker1.Value.Date,
            };
            bs.AracEkle(arac);
            dataGridView1.DataSource = bs.AraclariGetir();
            dataGridView1.Update();
            dataGridView1.Refresh();
            MessageBox.Show("Successfully added.");
            txtPlate.Clear();
            txtBrand.Clear();
            txtModel.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedData = dataGridView1.SelectedCells;
            SetValueForText1 = selectedData[0].Value.ToString();
            if(selectedData[0].Value !=null)
            {
                BusinessCodes bs = new BusinessCodes();
                AraclarModel sonuc = bs.IdBilgisineGoreGetir(Convert.ToInt32(SetValueForText1));
                EditForm form3 = new EditForm();
                form3.Show();
                this.Hide();
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var selectedData = dataGridView1.SelectedCells;
            SetValueForText1 = selectedData[0].Value.ToString();
            if (selectedData[0].Value != null)
            {
                BusinessCodes bs = new BusinessCodes();
                bool sonuc = bs.AracSil(Convert.ToInt32(SetValueForText1));
                if(sonuc)
                {
                    MessageBox.Show("Successfully deleted.");
                }
                else
                {
                    MessageBox.Show("Error occured while deleting!");
                }
                dataGridView1.DataSource = bs.AraclariGetir();
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToLongDateString();
        }

      
    }
}
