using System;
using System.Drawing;
using System.Windows.Forms;

namespace PodyglomAxis
{
    public partial class Form1 : Form
    {


        private double _ygol;
        private double _firstSpeed;
        private double _speedX;
        private double _speedY;
        private double _x;
        private double _y;
        private double _t;
        public Form1()
        {

            InitializeComponent();
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            _t += 0.05;
            _x = (float) _speedX * _t;
            _y = -(float) _speedY * _t - 9.81 * _t * _t / 20;
            if (_y <= 0)
            {
                timer1.Stop();
                _x = 0;
                _y = 0;
                _t = 0;
            }
            axis1.PixDraw((float) _x, (float) _y, Color.Blue, 0);
            axis1.StatToPic();
        }
        private void axis1_Load(object sender, EventArgs e)
        {
            axis1.Axis_Type = 3;
            axis1.x_Name = "Ox";
            axis1.y_Name = "Oy";
            axis1.x_Base = Width;
            axis1.y_Base = Height;
            axis1.Pix_Size = (float) 0.001;
            axis1.AxisDraw();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            var vse = _ygol * Math.PI / 180;
            double.TryParse(textBox1.Text, out _firstSpeed);
            double.TryParse(textBox2.Text, out _ygol);
            _speedX = (float)(_firstSpeed * Math.Cos(vse));
            _speedY = (float)(_firstSpeed * Math.Sin(-vse));
            timer1.Start();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            var vse = _ygol * Math.PI / 180;
            double.TryParse(textBox1.Text, out _firstSpeed);
            double.TryParse(textBox2.Text, out _ygol);
            _speedX = (float)(_firstSpeed * Math.Cos(vse));
            _speedY = (float)(_firstSpeed * Math.Sin(-vse));
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            _t += 0.1;
            _speedX -= 0.001 * _speedX * _speedX;
            _speedY += 9.81 * 0.01;
            _x += _speedX * 0.1;
            _y -= _speedY * 0.1;
            if (_y<=0)
            {
                timer2.Stop();
                _x = 0;
                _y = 0;
                _t = 0;
            }
            axis1.PixDraw((float)_x, (float)_y, Color.Red, 0);
            axis1.StatToPic();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }
    }
}
