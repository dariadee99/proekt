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
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
        }

        int id_dolzhnost = 1;
        int id_dolzhnost1 = 4;
        int id_dolzhnost2 = 5;

        private void button1_Click(object sender, EventArgs e)
        {

            Class1 rnd = new Class1();
            bool check = rnd.autoriz(textBox1.Text, textBox2.Text, id_dolzhnost);
            if (check)
            {
                MessageBox.Show("Успешно");
                Сотрудник5 spr = new Сотрудник5();
                spr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
       
        }

       

       
        
        private void Авторизация_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                id_dolzhnost = 1;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                id_dolzhnost = 4;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                id_dolzhnost = 5;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 rnd = new Class1();
            bool check = rnd.autoriz(textBox1.Text, textBox2.Text, id_dolzhnost1);
            if (check)
            {
                MessageBox.Show("Успешно");
                Директор spr = new Директор();
                spr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1 rnd = new Class1();
            bool check = rnd.autoriz(textBox1.Text, textBox2.Text, id_dolzhnost2);
            if (check)
            {
                MessageBox.Show("Успешно");
                Разработчик spr = new Разработчик();
                spr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ГлавнаяФорма spr = new ГлавнаяФорма();
            spr.Show();
            this.Hide();
        }
    }
}
