using colorPicker;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace colorPicker
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 显示设备上下文环境的句柄。
        /// </summary>
        private IntPtr _hdc = IntPtr.Zero;

        /// <summary>
        /// 指向窗口的句柄。
        /// </summary>
        private readonly IntPtr _hWnd = IntPtr.Zero;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Drawing.Point p = MousePosition;

            //tsslCursorPos.Text = string.Format("X:{0},Y:{1}", p.X, p.Y);

            uint color = Win32Helper.GetPixel(_hdc, p.X, p.Y);            

            RGB8 rgb = Win32Helper.GetRGBValue(color);

            byte r = rgb.R;
            byte g = rgb.G;
            byte b = rgb.B;

            numericUpDown_R.Value = rgb.R;
            numericUpDown_G.Value = rgb.G;
            numericUpDown_B.Value = rgb.B;

            pictureBox1.BackColor = Color.FromArgb(rgb.R, rgb.G, rgb.B);
            byte alpha = Convert.ToByte( trackBar1.Value);
            textBox_RGBHex.Text = "0X" + alpha.ToString("X").PadLeft(2, '0') + rgb.R.ToString("X").PadLeft(2, '0') + rgb.G.ToString("X").PadLeft(2, '0') + rgb.B.ToString("X").PadLeft(2, '0');
        }       

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            _hdc = Win32Helper.GetDC(_hWnd);
            Cursor = Cursors.Cross;
            timer1.Enabled = true;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            Win32Helper.ReleaseDC(_hWnd, _hdc);
            Cursor = Cursors.Default;
            timer1.Enabled = false;
            Text = "取色器";
        }

        private void updateColor()
        {
            byte r = Convert.ToByte(numericUpDown_R.Value);
            byte g = Convert.ToByte(numericUpDown_G.Value);
            byte b = Convert.ToByte(numericUpDown_B.Value);
            byte a = Convert.ToByte(trackBar1.Value);
            pictureBox1.BackColor = Color.FromArgb(a,r,g,b);
            textBox_RGBHex.Text = "0X" + a.ToString("X").PadLeft(2, '0') + r.ToString("X").PadLeft(2, '0') + g.ToString("X").PadLeft(2, '0') + b.ToString("X").PadLeft(2, '0');
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            textBox_Alpha.Text = trackBar1.Value.ToString();
            updateColor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_Alpha.Text = trackBar1.Value.ToString();
        }

        private bool isColorValueFormat(string s)
        {
            Regex regex = new  Regex( @"^#|0X[0-9a-fA-F]{6,8}$");
            Match match = regex.Match(s);
            if (match.Length > 0)
                return true;
            else
                return false;

        }
        private void textBox_RGBHex_KeyUp(object sender, KeyEventArgs e)
        {
            string s = textBox_RGBHex.Text.Trim().ToUpper();
            if (e.KeyData== Keys.Enter && s.Length>=6 )
            {
                if (isColorValueFormat(s) == false)
                    return;


                byte r, g, b, alpha;

                if (s.Substring(0, 2) == "0X")
                {
                    s = s.Substring(2, s.Length-2);
                }
                else if (s[0] == '#')
                {
                    s = s.Substring(1, s.Length - 1);
                 }

                if (s.Length >= 8)
                {
                    s = s.Substring(s.Length - 8, 8);                   
                    
                }
                
                b = Convert.ToByte(s.Substring(s.Length - 2, 2),16);
                g = Convert.ToByte(s.Substring(s.Length - 4, 2),16);
                r = Convert.ToByte(s.Substring(s.Length - 6, 2),16);
                if (s.Length >= 8)
                {
                    alpha = Convert.ToByte(s.Substring(s.Length - 8, 2),16);
                }
                else
                    alpha = 255;

                pictureBox1.BackColor = Color.FromArgb(alpha, r, g, b);

                numericUpDown_R.Value = r;
                numericUpDown_G.Value = g;
                numericUpDown_B.Value = b;
                trackBar1.Value = alpha;
            }
        }
    }
}