
namespace Intern_Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.TextButton = new System.Windows.Forms.Button();
            this.ShapeCbb = new System.Windows.Forms.ComboBox();
            this.FreeFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.TextButton_Click);
            // 
            // TextButton
            // 
            this.TextButton.Location = new System.Drawing.Point(201, 12);
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(112, 34);
            this.TextButton.TabIndex = 5;
            this.TextButton.Text = "A";
            this.TextButton.UseVisualStyleBackColor = true;
            this.TextButton.Click += new System.EventHandler(this.TextButton_Click);
            // 
            // ShapeCbb
            // 
            this.ShapeCbb.FormattingEnabled = true;
            this.ShapeCbb.Location = new System.Drawing.Point(112, 13);
            this.ShapeCbb.Name = "ShapeCbb";
            this.ShapeCbb.Size = new System.Drawing.Size(90, 33);
            this.ShapeCbb.TabIndex = 4;
            this.ShapeCbb.Text = "Shape";
            // 
            // FreeFormBtn
            // 
            this.FreeFormBtn.Location = new System.Drawing.Point(1, 12);
            this.FreeFormBtn.Name = "FreeFormBtn";
            this.FreeFormBtn.Size = new System.Drawing.Size(112, 34);
            this.FreeFormBtn.TabIndex = 3;
            this.FreeFormBtn.Text = "Free form";
            this.FreeFormBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextButton);
            this.Controls.Add(this.ShapeCbb);
            this.Controls.Add(this.FreeFormBtn);
            this.Name = "Form1";
            this.Text = "Paint";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.this_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button TextButton;
        private System.Windows.Forms.ComboBox ShapeCbb;
        private System.Windows.Forms.Button FreeFormBtn;
    }
}

