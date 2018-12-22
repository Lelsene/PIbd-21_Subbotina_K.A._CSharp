﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    public class LightTank : Vehicle, IComparable<LightTank>, IEquatable<LightTank>
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

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public LightTank(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
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

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }

        /// <summary>
        /// Метод интерфейса IComparable для класса LightTank
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(LightTank other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }

        /// <summary>
        /// Метод интерфейса IEquatable для класса LightTank
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(LightTank other)
        {
            if (other == null)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
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
            LightTank tankObj = obj as LightTank;
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
