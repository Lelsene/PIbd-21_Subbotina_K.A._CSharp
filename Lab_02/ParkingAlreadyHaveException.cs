using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    /// <summary>
    /// Класс-ошибка "Если на парковке уже есть танк с такими же характеристиками"
    /// </summary>
    public class ParkingAlreadyHaveException : Exception
    {
        public ParkingAlreadyHaveException() : base("На парковке уже есть такой танк")
        { }
    }
}
