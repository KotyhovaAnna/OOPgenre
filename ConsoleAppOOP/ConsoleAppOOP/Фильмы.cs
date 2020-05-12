using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOP
{
    abstract class Фильмы
    {
        string название;
        int Год_выпуска;
        public abstract void Продолжительность();

        public void getназвание()
        {
            Console.WriteLine(название);
        }
    }

}
