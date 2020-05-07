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
        private double _time;
        private const double Dtime = 0.1;
        private const double K = 0.1;
        private const double G = 9.81;
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            _time += Dtime;
            _x = _speedX * _time;
            _y = -_speedY * _time - G * _time * _time / 4;
            if (checkBox1.Checked)
            {
                _speedX -= Dtime * Dtime * K * _speedX * _speedX;
                _speedY += G * Dtime * Dtime;
            }
            if (_y <= 0)
            {
                timer1.Stop();
                _x = 0;
                _y = 0;
                _time = 0;
            }
            axis1.PixDraw((float)_x, (float)_y, Color.Blue, 0);
            axis1.StatToPic();
        }
        private void axis1_Load(object sender, EventArgs e)
        {
            axis1.Axis_Type = 3;
            axis1.x_Base = 200;
            axis1.y_Base = 200;
            axis1.Pix_Size = (float)0.001;
            axis1.AxisDraw();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            var vse = _ygol * Math.PI / 180;
            double.TryParse(textBox1.Text, out _firstSpeed);
            double.TryParse(textBox2.Text, out _ygol);
            _speedX = (_firstSpeed * Math.Cos(vse));
            _speedY = (_firstSpeed * Math.Sin(-vse));
            timer1.Start();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }
    }
}