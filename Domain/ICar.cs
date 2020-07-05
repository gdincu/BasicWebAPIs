using System;
using System.Collections.Generic;
using System.Text;

namespace BasicWebAPI
{
    interface ICar
    {

        int Id { get; set; }
        string Name { get; set; }
        int Year { get; set; }
        double Price { get; set; }
        int Acceleration { get; set; }
        int Braking {get; set;}
        void Accelerate();
        void Break();

    }
}