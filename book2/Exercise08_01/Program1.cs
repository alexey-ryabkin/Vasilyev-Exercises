//using System;
//using System.Drawing;
//using System.Windows.Forms;

namespace Exercise08_01
{
    internal class MyForm: System.Windows.Forms.Form
    {
        public MyForm() : base()
        {
            this.Text = "Окраска и увеличение";
            this.Size = new System.Drawing.Size(300, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            MouseEnter += ChangeColor;
            Click += delegate(object sender, System.EventArgs ev) 
            {
                this.Height = (int)(this.Height * 1.1);
                this.Width = (int)(this.Width * 0.9);
            };
        }
        private void ChangeColor(object sender, System.EventArgs e)
        {
            this.BackColor = System.Drawing.Color.AliceBlue;
        }
    }
    internal class Program1
    {
        [System.STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.Run(new MyForm());
        }
    }
}
