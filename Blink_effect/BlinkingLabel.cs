using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blink_effect
{
    public class BlinkingLabel
        : Label
    {
        Timer timer;
        public BlinkingLabel()
        {
            timer = new Timer();
            this.FirstColor = Color.Black;
            this.SecondColor = Color.Red;
            this.Interval = 1000;
            this.EnableBlinking = false;
            this.timer.Tick += new System.EventHandler(timer_Tick);

        }
        void timer_Tick(object sender, System.EventArgs e)
        {
            if(Blink_effect.Variabile.time <= 10 && Blink_effect.Variabile.time!=0)
             if (this.ForeColor == this.FirstColor)
                 this.ForeColor = this.SecondColor;
             else
                 this.ForeColor = this.FirstColor;
        }

        [Category("Blinking Settings")]
        public Color FirstColor { get; set; }
        [Category("Blinking Settings")]
        public Color SecondColor { get; set; }
        [Category("Blinking Settings")]
        public int Interval
        {
            get {return this.timer.Interval ; }
            set { this.timer.Interval = value; }
        }
        [Category("Blinking Settings")]
        public bool EnableBlinking
        {
            get { return this.timer.Enabled; }
            set { this.timer.Enabled = value; }
        }

    }
}
