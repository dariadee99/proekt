using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УчебнаяПрактика1
{
    public partial class Добавление : Form
    {
        public Добавление()
        {
            InitializeComponent();
            foreach (Pol pol in Program.db.Pol)
            {
                comboBox2.Items.Add(pol.id_pol);
            }
            foreach (Dolzhnost dolzhnost in Program.db.Dolzhnost)
            {
                comboBox1.Items.Add(dolzhnost.id_dolzhnost);
            }
            foreach (Obrazovanie obrazovanie in Program.db.Obrazovanie)
            {
                comboBox3.Items.Add(obrazovanie.id_obrazovanie);
            }
            foreach (Semya semya in Program.db.Semya)
            {
                comboBox4.Items.Add(semya.id_semya);
            }
            foreach (Dok doc in Program.db.Dok)
            {
                comboBox5.Items.Add(doc.id_doc);
            }
        }
        

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sotrydnik s = new Sotrydnik();
            s.Surname = textBox1.Text;
            s.NameUser = textBox3.Text;
            s.Patronomyc = textBox2.Text;
            s.MestoRoz = textBox9.Text;
            s.Phone = textBox4.Text;
            s.Stazh = textBox5.Text;
            s.Login = textBox6.Text;
            s.Password = textBox7.Text;
            s.id_pol = Convert.ToInt32(comboBox2.SelectedItem);
            s.id_doc = Convert.ToInt32(comboBox5.SelectedItem);
            s.id_obrazovanie = Convert.ToInt32(comboBox3.SelectedItem);
            s.id_semya = Convert.ToInt32(comboBox4.SelectedItem);
            s.id_dolzhnost = Convert.ToInt32(comboBox1.SelectedItem);
            s.DateRoz = dateTimePicker1.Value;
            s.DateTrydDog = dateTimePicker2.Value;
            Program.db.Sotrydnik.Add(s);
            Program.db.SaveChanges();
            Сохранение spr = new Сохранение();
            spr.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void Добавление_Load(object sender, EventArgs e)
        {

        }
    }
}
