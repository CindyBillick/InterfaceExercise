using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberofWheels { get; set; }
        public int NumberOfTires { get; set; }
        public string ExteriorPaintColor { get; set; }
        public string InteriorPaintColor { get; set; }
    }
}
