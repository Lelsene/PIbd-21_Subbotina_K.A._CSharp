using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    public class LightTank : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки танка
        /// </summary>
        protected const int carWidth = 100;

        /// <summary>
        /// Ширина отрисовки танка
        /// </summary>
        protected const int carHeight = 60;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес танка</param>
        /// <param name="mainColor">Основной цвет</param>
        public LightTank(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public override void MoveTank(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTank(Graphics g)
        {
            Brush brG = new SolidBrush(MainColor);
            Pen pen = new Pen(Color.Black);
            //нижняя основа
            g.FillRectangle(brG, _startPosX + 13, _startPosY + 40, 75, 15);
            //верхняя
            g.FillRectangle(brG, _startPosX + 30, _startPosY + 23, 40, 20);
            g.FillRectangle(brG, _startPosX + 40, _startPosY + 8, 20, 15);

            g.DrawLine(pen, _startPosX + 10, _startPosY + 40, _startPosX + 90, _startPosY + 40);
            g.DrawArc(pen, _startPosX + 10, _startPosY + 35, 80, 20, 0, 180);
            //колеса
            g.DrawEllipse(pen, _startPosX + 15, _startPosY + 40, 10, 10);
            g.DrawEllipse(pen, _startPosX + 25, _startPosY + 42, 10, 10);
            g.DrawEllipse(pen, _startPosX + 35, _startPosY + 43, 10, 10);
            g.DrawEllipse(pen, _startPosX + 45, _startPosY + 44, 10, 10);
            g.DrawEllipse(pen, _startPosX + 55, _startPosY + 44, 10, 10);
            g.DrawEllipse(pen, _startPosX + 65, _startPosY + 42, 10, 10);
            g.DrawEllipse(pen, _startPosX + 75, _startPosY + 40, 10, 10);

        }
    }
}
