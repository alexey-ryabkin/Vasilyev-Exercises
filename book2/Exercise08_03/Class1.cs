using System;
using System.Windows.Forms;
using System.Drawing;

namespace Exercise08_03
{
    internal class ColorPresenter: Form
    {
        private string[] _colorNames = { "Красный", "Оранжевый", "Жёлтый", "Зелёный", "Голубой", "Синий", "Фиолетовый" };
        private Color[] _colors = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.LightSkyBlue, Color.Indigo, Color.Violet };
        Label colorView = new Label();
        ComboBox colorPicker = new ComboBox();
        public ColorPresenter(): base() 
        {
            Text = "Выбор цвета";
            Size = new Size(300,300);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;

            colorView.Size = new Size(40,40);
            colorView.Location = new Point(130, 80);
            Controls.Add(colorView);

            colorPicker.Size = new Size(250,80);
            colorPicker.Location = new Point(25, 10);
            colorPicker.Items.AddRange(_colorNames);
            colorPicker.SelectedIndex = 0;
            colorPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            colorPicker.SelectedIndexChanged += _updateColorView;
            Controls.Add(colorPicker);

            _updateColorView(new object(), new object());
        } 
        private void _updateColorView(object a, object b)
        {
            colorView.BackColor = _colors[colorPicker.SelectedIndex];
        }
    }
    internal class Class1
    {
        internal static void Main()
        {
            Application.Run(new ColorPresenter());
        }
    }
}
