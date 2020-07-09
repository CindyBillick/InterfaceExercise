using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck:IVehicle,ICompany
    {
        public int BedSize { get; set; }
        public int PayLoadSize { get; set; }
        public int NumberofWheels { get; set; }
        public int NumberOfTires { get; set; }
        public string ExteriorPaintColor { get; set; }
        public string InteriorPaintColor { get; set; }
        public string Logo { get; set; }
        public string Slogan { get; set; }


    }
}
