
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextButton = new System.Windows.Forms.Button();
            this.ShapeCbb = new System.Windows.Forms.ComboBox();
            this.FreeFormBtn = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TextButton);
            this.panel1.Controls.Add(this.ShapeCbb);
            this.panel1.Controls.Add(this.FreeFormBtn);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 264);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TextButton
            // 
            this.TextButton.Location = new System.Drawing.Point(199, -1);
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(112, 34);
            this.TextButton.TabIndex = 2;
            this.TextButton.Text = "A";
            this.TextButton.UseVisualStyleBackColor = true;
            this.TextButton.Click += new System.EventHandler(this.TextButton_Click);
            // 
            // ShapeCbb
            // 
            this.ShapeCbb.FormattingEnabled = true;
            this.ShapeCbb.Location = new System.Drawing.Point(110, 0);
            this.ShapeCbb.Name = "ShapeCbb";
            this.ShapeCbb.Size = new System.Drawing.Size(90, 33);
            this.ShapeCbb.TabIndex = 1;
            this.ShapeCbb.Text = "Shape";
            this.ShapeCbb.SelectedIndexChanged += new System.EventHandler(this.ShapeCbb_SelectedIndexChanged);
            // 
            // FreeFormBtn
            // 
            this.FreeFormBtn.Location = new System.Drawing.Point(-1, -1);
            this.FreeFormBtn.Name = "FreeFormBtn";
            this.FreeFormBtn.Size = new System.Drawing.Size(112, 34);
            this.FreeFormBtn.TabIndex = 0;
            this.FreeFormBtn.Text = "Free form";
            this.FreeFormBtn.UseVisualStyleBackColor = true;
            this.FreeFormBtn.Click += new System.EventHandler(this.FreeFormBtn_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.TextButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Paint";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TextButton;
        private System.Windows.Forms.ComboBox ShapeCbb;
        private System.Windows.Forms.Button FreeFormBtn;
        public System.Windows.Forms.FontDialog fontDialog1;
    }
}

