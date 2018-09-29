using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    public class HeavyTank : LightTank
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }

        /// <summary>
        /// Признак наличия первого дула
        /// </summary>
        public bool FirstMuzzle { private set; get; }

        /// <summary>
        /// Признак наличия второго дула
        /// </summary>
        public bool SecondMuzzle { private set; get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес танка</param>
        /// <param name="mainColor">Основной цвет</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        public HeavyTank(int maxSpeed, float weight, Color mainColor, Color dopColor, bool firstMuzzle, bool secondMuzzle) : base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            FirstMuzzle = firstMuzzle;
            SecondMuzzle = secondMuzzle;
        }
        public override void DrawTank(Graphics g)
        {
            Pen pen = new Pen(DopColor);
            Brush brB = new SolidBrush(DopColor);
            base.DrawTank(g);
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
            //дуло
            if (FirstMuzzle)
            {
                g.FillRectangle(brB, _startPosX + 10, _startPosY + 12, 40, 3);
            }
            if (SecondMuzzle)
            {
                g.FillRectangle(brB, _startPosX + 8, _startPosY + 17, 40, 3);
            }
        }
    }
}
