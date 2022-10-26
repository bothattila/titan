﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titan.Utils
{
    public static class MathUtils
    {
        private static string[] vezetekNevArray =
            { "Feri", "Pista", "Janos", "Jozsef", "Imre", "Géza", "Gyula", "Botond",
            "Csirifiszkió", "Sebestyén", "Péter", "Attila", "Béla" };

        public static string randomVezeteknev()
        {
            int valasztottRandomSzam = StaticRandom.Instance.Next(vezetekNevArray.Length);
            return vezetekNevArray[valasztottRandomSzam];
        }
    }
}