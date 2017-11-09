using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blink_effect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        /*private async void Blink()
        {
            while (true)
            {
                await Task.Delay(950);
                label1.ForeColor = label1.ForeColor == Color.Black ? Color.Red : Color.Black;
            }
        }*/

        //bool Blink = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Blink_effect.Variabile.time--;
            if (Blink_effect.Variabile.time % 30 < 10)
                blinkingLabel1.Text = "0" + Blink_effect.Variabile.time.ToString();
            else
                blinkingLabel1.Text = Blink_effect.Variabile.time.ToString();
            if (Blink_effect.Variabile.time == 0)
                timer1.Stop();

            // label1.Visible = Blink;
            // Blink = !Blink;

            //if (time >= 1)
            //Blink();
        }
    }
}
