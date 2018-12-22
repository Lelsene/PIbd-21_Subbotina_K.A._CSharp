﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    public class HeavyTank : LightTank, IComparable<HeavyTank>, IEquatable<HeavyTank>
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

        public HeavyTank(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                FirstMuzzle = Convert.ToBoolean(strs[4]);
                SecondMuzzle = Convert.ToBoolean(strs[5]);
            }
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

        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + FirstMuzzle + ";" +
            SecondMuzzle;
        }

        /// <summary>
        /// Метод интерфейса IComparable для класса SportCar
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(HeavyTank other)
        {
            var res = (this is LightTank).CompareTo(other is LightTank);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (FirstMuzzle != other.FirstMuzzle)
            {
                return FirstMuzzle.CompareTo(other.FirstMuzzle);
            }
            if (SecondMuzzle != other.SecondMuzzle)
            {
                return SecondMuzzle.CompareTo(other.SecondMuzzle);
            }
            return 0;
        }

        /// <summary>
        /// Метод интерфейса IEquatable для класса SportCar
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(HeavyTank other)
        {
            var res = (this as LightTank).Equals(other as LightTank);
            if (!res)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (FirstMuzzle != other.FirstMuzzle)
            {
                return false;
            }
            if (SecondMuzzle != other.SecondMuzzle)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            HeavyTank tankObj = obj as HeavyTank;
            if (tankObj == null)
            {
                return false;
            }
            else
            {
                return Equals(tankObj);
            }
        }

        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
