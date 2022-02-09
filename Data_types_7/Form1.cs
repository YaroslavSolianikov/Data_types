using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_types_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime s;
            s = dateTimePicker1.Value;
            DateTime now = DateTime.Now;
            var res = now.Year - s.Year;
            textBox1.Text = Convert.ToString(res);
        }
    }
}
