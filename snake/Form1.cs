using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int direction = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    direction = 1;
                    Up();
                    break;
                case Keys.Down:
                    direction = 2;
                    Down();
                    break;
                case Keys.Left:
                    direction = 3;
                    Left();
                    break;
                case Keys.Right:
                    direction = 4;
                    Right();
                    break;
                default:
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (direction)
            {
                case 1:
                    Up();
                    break;
                case 2:
                    Down();
                    break;
                case 3:
                    Left();
                    break;
                case 4:
                    Right();
                    break;
                default:
                    break;
            }
        }
        public void Up()
        {
            snake.Top -= 5;
            if (border3.Top >= snake.Top)
            {
                timer1.Enabled = false;
                MessageBox.Show("You lose");
            }
        }

        public void Down()
        {
            snake.Top += 5;
            if (border1.Top <= snake.Top)
            {
                timer1.Enabled = false;
                MessageBox.Show("You lose");
            }
        }

        public new void Left()
        {
            snake.Left -= 5;
            if (border4.Left <= snake.Left)
            {
                timer1.Enabled = false;
                MessageBox.Show("You lose");
            }
        }

        public new void Right()
        {
            snake.Left += 5;
            if (border2.Left >= snake.Left)
            {
                timer1.Enabled = false;
                MessageBox.Show("You lose");
            }
        }
    }
}
