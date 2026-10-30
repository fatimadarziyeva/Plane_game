namespace WinFormsApp11
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            buttonGas = new Button();
            buttonBreak = new Button();
            buttonOnOff = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(353, 18);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(280, 69);
            button1.TabIndex = 7;
            button1.Text = "Eniş hazırlığı";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(353, 97);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(280, 69);
            button2.TabIndex = 6;
            button2.Text = "Turbulans";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
             
            button3.BackColor = Color.DarkOrange;
            button3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(353, 175);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(280, 69);
            button3.TabIndex = 5;
            button3.Text = "Kəmərlər";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            
            button4.BackColor = Color.DarkOrange;
            button4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(353, 254);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(280, 69);
            button4.TabIndex = 4;
            button4.Text = "Təşəkkürlər";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            
            button5.BackColor = Color.DarkOrange;
            button5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(353, 332);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(280, 69);
            button5.TabIndex = 3;
            button5.Text = "Beep";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            
            buttonGas.BackColor = Color.ForestGreen;
            buttonGas.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonGas.ForeColor = Color.White;
            buttonGas.Location = new Point(353, 423);
            buttonGas.Margin = new Padding(4, 5, 4, 5);
            buttonGas.Name = "buttonGas";
            buttonGas.Size = new Size(133, 69);
            buttonGas.TabIndex = 2;
            buttonGas.Text = "GAS";
            buttonGas.UseVisualStyleBackColor = false;
            buttonGas.Click += buttonGas_Click;
            
            buttonBreak.BackColor = Color.Firebrick;
            buttonBreak.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonBreak.ForeColor = Color.White;
            buttonBreak.Location = new Point(500, 423);
            buttonBreak.Margin = new Padding(4, 5, 4, 5);
            buttonBreak.Name = "buttonBreak";
            buttonBreak.Size = new Size(133, 69);
            buttonBreak.TabIndex = 1;
            buttonBreak.Text = "Break";
            buttonBreak.UseVisualStyleBackColor = false;
            buttonBreak.Click += buttonBreak_Click;
           
            buttonOnOff.BackColor = Color.DodgerBlue;
            buttonOnOff.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonOnOff.ForeColor = Color.White;
            buttonOnOff.Location = new Point(353, 508);
            buttonOnOff.Margin = new Padding(4, 5, 4, 5);
            buttonOnOff.Name = "buttonOnOff";
            buttonOnOff.Size = new Size(280, 69);
            buttonOnOff.TabIndex = 0;
            buttonOnOff.Text = "ON/OF";
            buttonOnOff.UseVisualStyleBackColor = false;
            buttonOnOff.Click += buttonOnOff_Click;
            
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 677);
            panel1.TabIndex = 8;
            
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 401);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
             
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 677);
            Controls.Add(panel1);
            Controls.Add(buttonOnOff);
            Controls.Add(buttonBreak);
            Controls.Add(buttonGas);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Plane";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonGas;
        private System.Windows.Forms.Button buttonBreak;
        private System.Windows.Forms.Button buttonOnOff;
        private Panel panel1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}