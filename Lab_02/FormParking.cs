using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02
{
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        Parking<ITransport> parking;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITransport>(20, pictureBoxParking.Width,
pictureBoxParking.Height);
            Draw();
        }

        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать бронированную машину"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateLightTank_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var tank = new LightTank(100, 1000, dialog.Color);
                int place = parking + tank;
                Draw();
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать танк"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateHeavyTank_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var tank = new HeavyTank(100, 1000, dialog.Color, dialogDop.Color,
                    true, true);
                    int place = parking + tank;
                    Draw();
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlace_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                var tank = parking - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (tank != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxPlace.Width,
                    pictureBoxPlace.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    tank.SetPosition(5, 5, pictureBoxPlace.Width,
                    pictureBoxPlace.Height);
                    tank.DrawTank(gr);
                    pictureBoxPlace.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxPlace.Width,
                    pictureBoxPlace.Height);
                    pictureBoxPlace.Image = bmp;
                }
                Draw();
            }
        }
    }
}