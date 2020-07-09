using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            Truck myTruck = new Truck();
            myTruck.BedSize = 6;
            myTruck.ExteriorPaintColor = "red";
            myTruck.InteriorPaintColor = "black";
            myTruck.Logo = "Chevy";
            myTruck.NumberOfTires = 4;
            myTruck.NumberofWheels = 4;
            myTruck.PayLoadSize = 10;
            myTruck.Slogan = "Built Tough";

            Car myCar = new Car();
            myCar.InteriorPaintColor = "white";
            myCar.ExteriorPaintColor = "blue";
            myCar.NumberOfTires = 4;
            myCar.NumberofWheels = 4;
            myCar.Slogan = "Drive Comfortably";
            myCar.TrunkSize = "six";

            SUV mySUV = new SUV();
            mySUV.HasCargoHold = true;
            mySUV.ExteriorPaintColor = "silver";
            mySUV.HasTVScreen = true;
            mySUV.InteriorPaintColor = "taupe";
            mySUV.NumberOfTires = 4;
            mySUV.NumberofWheels = 4;
            mySUV.Slogan = "Come Drive Me";
            


            //Creatively display and organize their values
            Console.WriteLine($"{myTruck.BedSize},{myTruck.ExteriorPaintColor} ");


         
        }
    }
}
