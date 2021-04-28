using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intern_Test
{
    public partial class Form1 : Form
    {
        Drawing drawing;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FreeFormBtn_Click(object sender, EventArgs e)
        {
            drawing = new FreeForm();
        }

        private void ShapeCbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextButton_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }
    }
}
