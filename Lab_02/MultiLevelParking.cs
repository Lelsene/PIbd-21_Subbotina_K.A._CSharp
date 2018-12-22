﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    /// <summary>
    /// Класс-хранилище парковок
    /// </summary>
    public class MultiLevelParking
    {
        /// <summary>
        /// Список с уровнями парковки
        /// </summary>
        List<Parking<ITransport>> parkingStages;

        /// <summary>
        /// Сколько мест на каждом уровне
        /// </summary>
        private const int countPlaces = 20;

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int pictureWidth;

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int pictureHeight;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="countStages">Количество уровенй парковки</param>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth,
pictureHeight));
            }
        }

        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }

        /// <summary>
        /// Сохранение информации по танкам на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    //Записываем количество уровней
                    WriteToFile("CountLeveles:" + parkingStages.Count + Environment.NewLine, fs);
                    foreach (var level in parkingStages)
                    {
                        //Начинаем уровень
                        WriteToFile("Level" + Environment.NewLine, fs);
                        foreach (var tank in level)
                        {
                            //Записываем тип мшаины
                            if (tank.GetType().Name == "LightTank")
                            {
                                WriteToFile(":LightTank:", fs);
                            }
                            if (tank.GetType().Name == "HeavyTank")
                            {
                                WriteToFile(":HeavyTank:", fs);
                            }
                            //Записываемые параметры
                            WriteToFile(tank + Environment.NewLine, fs);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Метод записи информации в файл
        /// </summary>
        /// <param name="text">Строка, которую следует записать</param>
        /// <param name="stream">Поток для записи</param>
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        /// <summary>
        /// Загрузка информации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    bufferTextFromFile += temp.GetString(b);
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("CountLeveles"))
            {
                //считываем количество уровней
                int count = Convert.ToInt32(strs[0].Split(':')[1]);
                if (parkingStages != null)
                {
                    parkingStages.Clear();
                }
                parkingStages = new List<Parking<ITransport>>(count);
            }
            else
            {
                //если нет такой записи, то это не те данные
                throw new Exception("Неверный формат файла");
            }
            int counter = -1;
            int counterTank = 0;
            ITransport tank = null;
            for (int i = 1; i < strs.Length; ++i)
            {
                //идем по считанным записям
                if (strs[i] == "Level")
                {
                    //начинаем новый уровень
                    counter++;
                    counterTank = 0;
                    parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(':')[1] == "LightTank")
                {
                    tank = new LightTank(strs[i].Split(':')[2]);
                }
                else if (strs[i].Split(':')[1] == "HeavyTank")
                {
                    tank = new HeavyTank(strs[i].Split(':')[2]);
                }
                parkingStages[counter][counterTank++] = tank;
            }
        }

        /// <summary>
        /// Сортировка уровней
        /// </summary>
        public void Sort()
        {
            parkingStages.Sort();
        }
    }
}
