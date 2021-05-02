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
        
        Text text;
        Rectangle rectangle;
        Font f;
        Shape s;
        public Form1()
        {
            InitializeComponent();
            ShapeCbb.Items.Add("Line");
            ShapeCbb.Items.Add("Rectangle");
            ShapeCbb.Items.Add("Circle");
            ShapeCbb.Items.Add("Triangle");
            ShapeCbb.Items.Add("Diamond");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FreeFormBtn_Click(object sender, EventArgs e)
        {
            //drawing = new FreeForm();
        }

        private void ShapeCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ShapeCbb.SelectedIndex)
            {
                case 0:
                    s = new Line();
                    break;
                case 1:
                    s = new Rectangle();
                    s.Draw();
                    s.graphics = CreateGraphics();
                    s.graphics.DrawRectangle(s.pen, 10, 10, 100, 100);
                    MessageBox.Show("NEW");
                    break;
                case 2:
                    s = new Circle();
                    break;
                case 3:
                    s = new Triangle();
                    break;
                case 4:
                    s = new Diamond();
                    break;

            }    
        }

        private void TextButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (fontDialog1.ShowDialog() != DialogResult.Cancel)
                    f = fontDialog1.Font;
                if (text != null)
                    text.tb.Font = f;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                f = fontDialog1.Font;
            }
            
        }

        private void this_MouseClick(object sender, MouseEventArgs e)
        {
            text = new Text();
            text.setup(e.X, e.Y);
            text.tb.Font = f;
            this.Controls.Add(text.tb);
            text.tb.TextChanged += Tb_TextChanged;
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            SizeF size = text.graphics.MeasureString(text.tb.Text, text.tb.Font);
            text.tb.Size = size.ToSize();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.graphics = this.CreateGraphics();
            rectangle.Draw();
        }
    }
}
