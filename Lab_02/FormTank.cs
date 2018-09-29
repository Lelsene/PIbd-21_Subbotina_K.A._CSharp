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
    public partial class FormTank : Form
    {
        private ITransport tank;

        public FormTank()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод отрисовки танка
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTank.Width, pictureBoxTank.Height);
            Graphics gr = Graphics.FromImage(bmp);
            tank.DrawTank(gr);
            pictureBoxTank.Image = bmp;
        }

        /// <summary>
        /// Обработка нажатия кнопки "Создать бронированную машину"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateLightTank_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            tank = new LightTank(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.LightGreen);
            tank.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTank.Width,
            pictureBoxTank.Height);
            Draw();
        }

        /// <summary>
        /// Обработка нажатия кнопки "Создать танк"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateHeavyTank_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            tank = new HeavyTank(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.LightGreen,
            Color.DarkOliveGreen, true, true);
            tank.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTank.Width,
            pictureBoxTank.Height);
            Draw();
        }

        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    tank.MoveTank(Direction.Up);
                    break;
                case "buttonDown":
                    tank.MoveTank(Direction.Down);
                    break;
                case "buttonLeft":
                    tank.MoveTank(Direction.Left);
                    break;
                case "buttonRight":
                    tank.MoveTank(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
