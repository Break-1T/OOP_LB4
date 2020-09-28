using System;
using System.Collections.Generic;
using System.Text;

namespace _4th_task._4th
{
    class ApplicationLicense
    {
        public void AllowTrial()
        {
            Console.WriteLine("Триальній режим");
        }
        public void AllowCommon()
        {
            Console.WriteLine("Бесплатная версия");

        }
        public void AllowPro()
        {
            Console.WriteLine("Платная версия");

        }
    }
}
