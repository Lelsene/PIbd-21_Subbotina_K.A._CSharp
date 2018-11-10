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
        /// Объект от класса многоуровневой парковки
        /// </summary>
        MultiLevelParking parking;

        /// <summary>
        /// Форма для добавления
        /// </summary>
        FormTankConfig form;

        /// <summary>
        /// Количество уровней-парковок
        /// </summary>
        private const int countLevel = 5;

        public FormParking()
        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width,
            pictureBoxParking.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }

        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxParking.Width,
                pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlace_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBoxPlace.Text != "")
                {
                    var tank = parking[listBoxLevels.SelectedIndex] -
                    Convert.ToInt32(maskedTextBoxPlace.Text);
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

        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        /// <summary>
        /// Обработка нажатия кнопки "Припарковать бронированную машину"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetTank_Click(object sender, EventArgs e)
        {
            form = new FormTankConfig();
            form.AddEvent(AddTank);
            form.Show();
        }


        /// <summary>
        /// Метод добавления танка
        /// </summary>
        /// <param name="tank"></param>
        private void AddTank(ITransport tank)
        {
            if (tank != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = parking[listBoxLevels.SelectedIndex] + tank;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Танк не удалось поставить");
                }
            }
        }

    }
}