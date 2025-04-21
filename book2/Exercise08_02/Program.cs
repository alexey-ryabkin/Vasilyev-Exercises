using System;
using System.Drawing;
using System.Windows.Forms;

namespace Exercise08_02
{
    internal class MyForm: System.Windows.Forms.Form
    {
        int counter = 0;
        Label label = new Label();
        public MyForm(): base()
        {
            this.Text = "Счётчик";
            this.Size = new Size(300,200);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            UpdateLabel();
            label.Location = new Point(0,0);
            label.Width = this.Width;
            label.Height = (int)(this.ClientSize.Height * 0.25);
            label.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(label);

            Button plus = new Button();
            plus.Text = "+1";
            plus.Width = this.Width;
            plus.Height = (int)(this.ClientSize.Height * 0.25);
            plus.Location = new Point(0,(int)(this.ClientSize.Height * 0.25));
            plus.Click += (a,b) => 
            { 
                counter++;
                UpdateLabel();
            };
            this.Controls.Add(plus);

            Button minus = new Button();
            minus.Text = "-1";
            minus.Width = this.Width;
            minus.Height = (int)(this.ClientSize.Height * 0.25);
            minus.Location = new Point(0,(int)(this.ClientSize.Height * 0.5));
            minus.Click += (a,b) => 
            { 
                counter--;
                UpdateLabel();
            };
            this.Controls.Add(minus);

            Button exit = new Button();
            exit.Text = "Выйти";
            exit.Width = this.Width;
            exit.Height = (int)(this.ClientSize.Height * 0.25);
            exit.Location = new Point(0,(int)(this.ClientSize.Height * 0.75));
            exit.Click += (a,b) => { Application.Exit(); };
            this.Controls.Add(exit);
        }
        private void UpdateLabel()
        {
            label.Text = counter.ToString();
        }
    }
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            System.Windows.Forms.Application.Run(new MyForm());
        }
    }
}
