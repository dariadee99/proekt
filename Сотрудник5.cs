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
    public partial class Сотрудник5 : Form
    {
        public Сотрудник5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            raspisanie spr = new raspisanie();
            spr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Авторизация spr = new Авторизация();
            spr.Show();
            this.Hide();
        }
    }
}
