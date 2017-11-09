namespace Blink_effect
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.blinkingLabel1 = new Blink_effect.BlinkingLabel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // blinkingLabel1
            // 
            this.blinkingLabel1.AutoSize = true;
            this.blinkingLabel1.BackColor = System.Drawing.Color.Transparent;
            this.blinkingLabel1.EnableBlinking = true;
            this.blinkingLabel1.FirstColor = System.Drawing.Color.Black;
            this.blinkingLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blinkingLabel1.ForeColor = System.Drawing.Color.Black;
            this.blinkingLabel1.Interval = 500;
            this.blinkingLabel1.Location = new System.Drawing.Point(87, 79);
            this.blinkingLabel1.Name = "blinkingLabel1";
            this.blinkingLabel1.SecondColor = System.Drawing.Color.Red;
            this.blinkingLabel1.Size = new System.Drawing.Size(153, 108);
            this.blinkingLabel1.TabIndex = 1;
            this.blinkingLabel1.Text = "20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 264);
            this.Controls.Add(this.blinkingLabel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private BlinkingLabel blinkingLabel1;
    }
}

