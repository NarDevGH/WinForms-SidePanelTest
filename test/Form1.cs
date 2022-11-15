using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private int num = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button txtBox = new Button();
            txtBox.Name = "Panel:" + num++;
            txtBox.Location = new System.Drawing.Point(13,200);
            txtBox.Size = new System.Drawing.Size(10, 50);
            this.panel1.Controls.Add(txtBox);
            txtBox.Parent = this.panel1;
            txtBox.Dock = DockStyle.Top;
            txtBox.Text = txtBox.Name+", "+txtBox.Parent.Name;
        }
    }
}
