namespace colorPicker
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_RGBHex = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.R = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox_Alpha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.numericUpDown_R = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_G = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_B = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_B)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "按下取色";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(335, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 135);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_RGBHex
            // 
            this.textBox_RGBHex.Location = new System.Drawing.Point(222, 319);
            this.textBox_RGBHex.MaxLength = 10;
            this.textBox_RGBHex.Name = "textBox_RGBHex";
            this.textBox_RGBHex.Size = new System.Drawing.Size(94, 21);
            this.textBox_RGBHex.TabIndex = 1;
            this.textBox_RGBHex.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_RGBHex_KeyUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Location = new System.Drawing.Point(33, 301);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(11, 12);
            this.R.TabIndex = 3;
            this.R.Text = "R";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "G";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "B";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 271);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(228, 42);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 255;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // textBox_Alpha
            // 
            this.textBox_Alpha.Location = new System.Drawing.Point(281, 271);
            this.textBox_Alpha.Name = "textBox_Alpha";
            this.textBox_Alpha.Size = new System.Drawing.Size(36, 21);
            this.textBox_Alpha.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alpha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hex";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 243);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // numericUpDown_R
            // 
            this.numericUpDown_R.Location = new System.Drawing.Point(17, 319);
            this.numericUpDown_R.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_R.Name = "numericUpDown_R";
            this.numericUpDown_R.Size = new System.Drawing.Size(53, 21);
            this.numericUpDown_R.TabIndex = 6;
            // 
            // numericUpDown_G
            // 
            this.numericUpDown_G.Location = new System.Drawing.Point(76, 319);
            this.numericUpDown_G.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_G.Name = "numericUpDown_G";
            this.numericUpDown_G.Size = new System.Drawing.Size(53, 21);
            this.numericUpDown_G.TabIndex = 7;
            // 
            // numericUpDown_B
            // 
            this.numericUpDown_B.Location = new System.Drawing.Point(135, 319);
            this.numericUpDown_B.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_B.Name = "numericUpDown_B";
            this.numericUpDown_B.Size = new System.Drawing.Size(53, 21);
            this.numericUpDown_B.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 354);
            this.Controls.Add(this.numericUpDown_B);
            this.Controls.Add(this.numericUpDown_G);
            this.Controls.Add(this.numericUpDown_R);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.R);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_RGBHex);
            this.Controls.Add(this.textBox_Alpha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_B)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_RGBHex;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox_Alpha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown_R;
        private System.Windows.Forms.NumericUpDown numericUpDown_G;
        private System.Windows.Forms.NumericUpDown numericUpDown_B;
    }
}

