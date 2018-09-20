using System.Drawing;

namespace WindowsFormsCars
{
    /// <summary>
    /// Класс отрисовки танка
    /// </summary>
    class Tank
    {
        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        /// <summary>
        /// Левая координата отрисовки танка
        /// </summary>
        private float _startPosX;

        /// <summary>
        /// Правая кооридната отрисовки танка
        /// </summary>
        private float _startPosY;

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;

        /// <summary>
        /// Ширина отрисовки танка
        /// </summary>
        private const int carWidth = 100;

        /// <summary>
        /// Высота отрисовки танка
        /// </summary>
        private const int carHeight = 60;

        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }

        /// <summary>
        /// Вес автомобиля
        /// </summary>
        public float Weight { private set; get; }

        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { private set; get; }

        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес танка</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>

        public Tank(int maxSpeed, float weight, Color mainColor, Color dopColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
        }

        /// <summary>
        /// Установка позиции танка
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
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

        /// <summary>
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        public void DrawTank(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brY = new SolidBrush(Color.LightYellow);
            Brush brG = new SolidBrush(Color.LightGreen);
            Brush brB = new SolidBrush(Color.Black);

            //нижняя основа
            g.FillRectangle(brG, _startPosX + 13, _startPosY + 40, 75, 15);
            //дуло
            g.FillRectangle(brB, _startPosX + 10, _startPosY + 12, 40, 3);

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
