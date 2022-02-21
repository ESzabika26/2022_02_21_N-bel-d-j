using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2022_02_21_Nóbel_díj
{
    public partial class OrvosiNobeldjasokGUI : Form
    {
        public OrvosiNobeldjasokGUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1 || textBox2.Text.Length < 1 || textBox3.Text.Length < 1 || textBox4.Text.Length < 1)
            {
                MessageBox.Show("Töltsön ki minden mezőt!", "Mentés", MessageBoxButtons.OK);
                return;
            }
            if (int.Parse(textBox1.Text) < 1989)
            {
                MessageBox.Show("Hiba! Az évszám nem megfelelő!", "Mentés", MessageBoxButtons.OK);
                return;
            }
    }
}
