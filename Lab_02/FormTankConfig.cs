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
    public partial class FormTankConfig : Form
    {
        /// <summary>
        /// Переменная-выбранная машина
        /// </summary>
        ITransport tank = null;

        /// <summary>
        /// Событие
        /// </summary>
        private event tankDelegate eventAddTank;


        public FormTankConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        /// <summary>
        /// Отрисовать танк
        /// </summary>
        private void DrawTank()
        {
            if (tank != null)
            {
                Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
                Graphics gr = Graphics.FromImage(bmp);
                tank.SetPosition(15, 15, pictureBox.Width, pictureBox.Height);
                tank.DrawTank(gr);
                pictureBox.Image = bmp;
            }
        }

        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(tankDelegate ev)
        {
            if (eventAddTank == null)
            {
                eventAddTank = new tankDelegate(ev);
            }
            else
            {
                eventAddTank += ev;
            }
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelLightTank_MouseDown(object sender, MouseEventArgs e)
        {
            labelLightTank.DoDragDrop(labelLightTank.Text, DragDropEffects.Move |
            DragDropEffects.Copy);
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelHeavyTank_MouseDown(object sender, MouseEventArgs e)
        {
            labelHeavyTank.DoDragDrop(labelHeavyTank.Text, DragDropEffects.Move |
            DragDropEffects.Copy);
        }

        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTank_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTank_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Бронированная машина":
                    tank = new LightTank(100, 500, Color.White);
                    break;
                case "Танк":
                    tank = new HeavyTank(100, 500, Color.White, Color.Black, true, true);
                    break;
            }
            DrawTank();
        }

        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
            DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (tank != null)
            {
                tank.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawTank();
            }
        }

        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (tank != null)
            {
                if (tank is HeavyTank)
                {
                    (tank as HeavyTank).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawTank();
                }
            }
        }

        /// <summary>
        /// Добавление танка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddTank?.Invoke(tank);
            Close();
        }
    }
}
