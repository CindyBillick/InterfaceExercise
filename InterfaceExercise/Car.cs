using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car:IVehicle,ICompany
    {
        public string TrunkSize { get; set; }
        public bool Convertible { get; set; }
        public int NumberofWheels { get; set; }
        public int NumberOfTires { get; set; }
        public string ExteriorPaintColor { get; set; }
        public string InteriorPaintColor { get; set; }
        public string Logo { get; set; }
        public string Slogan { get; set; }


    }
}
