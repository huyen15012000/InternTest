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
        List<Drawing> drawings = new List<Drawing>();
        Text text;
        FreeForm freeForm;
        Font font;
        Type type;
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

        
        private void ShapeCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ShapeCbb.SelectedIndex)
            {
                case 0:
                    Line line = new Line();
                    type = line.GetType();
                    drawings.Add(line);
                    break;
                case 1:
                    Rectangle rectangle = new Rectangle();
                    type = rectangle.GetType();
                    drawings.Add(rectangle);
                    break;
                case 2:
                    Circle circle = new Circle();
                    type = circle.GetType();
                    drawings.Add(circle);
                    break;
                case 3:
                    Triangle triangle = new Triangle();
                    type = triangle.GetType();
                    drawings.Add(triangle);
                    break;
                case 4:
                    Diamond diamond = new Diamond();
                    type = type.GetType();
                    drawings.Add(diamond);
                    break;

            }    
        }

        private void TextButton_Click(object sender, EventArgs e)
        {
            text = new Text();
            drawings.Add(text);
            ShowList();
            try
            {
                if (fontDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    text.Font = font = fontDialog1.Font;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
               
            }
            
        }

        private void this_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawings[drawings.Count - 1].IsDrawn)
            {

                text = new Text();
                text.Font = font;
                drawings.Add(text);
                ShowList();
            }
            drawings[drawings.Count - 1].setup(e.X, e.Y);
        }


        private void FreeFormBtn_Click_1(object sender, EventArgs e)
        {
            freeForm = new FreeForm();
            drawings.Add(freeForm);
            ShowList();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            text.Str += e.KeyCode;
            text.graphics = this.CreateGraphics();
            text.Draw();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (freeForm!=null)
            {
                freeForm.down = true;
                freeForm.setup(e.X, e.Y);
            }            

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (freeForm != null)
            {
                freeForm.move = true;
                if (freeForm.down && freeForm.move)
                {
                    
                    freeForm.CreatePoint(e.X, e.Y);
                    freeForm.graphics = this.CreateGraphics();
                    freeForm.Draw();
                }
            }    
             
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (freeForm!=null)
                freeForm.down = false;
        }
        public void ShowList()
        {
            for (int i = 0; i < drawings.Count; i++)
              MessageBox.Show(drawings[i].GetType().ToString());
        }
    }
}
