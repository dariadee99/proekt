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
    public partial class dokym : Form
    {
        public dokym()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dok d = new Dok();
            d.NameDok = textBox8.Text;
            d.NumberDok = Convert.ToInt32(textBox12.Text);
            d.SeriaDok = Convert.ToInt32(textBox11.Text);
            d.PlaceVydacha = textBox10.Text;
            d.DateVydacha = dateTimePicker3.Value;
            Program.db.Dok.Add(d);
            Program.db.SaveChanges();

            Добавление spr = new Добавление();
            spr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Разработчик spr = new Разработчик();
            spr.Show();
            this.Hide();
        }

        private void dokym_Load(object sender, EventArgs e)
        {

        }
    }
}
