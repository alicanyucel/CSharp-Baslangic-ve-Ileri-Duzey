using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBoxInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sayacLabel = 0;
            int sayacText = 0;
            int sayacGroupBox = 0;

            foreach (Control item in this.Controls)
            {
                if (item is Label)
                    sayacLabel++;
                else if (item is TextBox)
                    sayacText++;
                else if (item is GroupBox)
                    sayacGroupBox++;
            }

            GroupBox GPBox = this.Controls["groupBox1"] as GroupBox;

            foreach (var item in GPBox.Controls)
            {
                item.GetType();
            }
        }
    }
}
