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
            File.ReadAllLines("orvosi_nobeldíjak.txt").ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
