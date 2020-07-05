using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BasicWebAPI
{
   public class Car: ICar
    {
        int id { get; set; } //field
        string name { get; set; }
        int year { get; set; }
        double price { get; set; }
        int acceleration { get; set; }
        int braking { get; set; }
        public string Secret { get; set; }

        public int Id { //property
            get { return this.id; } 
            set { id = value; } 
        }

        public int Year
        { //property
            get { return this.year; }
            set { year = value; }
        }

        public double Price
        { //property
            get { return this.price; }
            set { price = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Acceleration {
            get { return acceleration; }
            set { acceleration = value; }
        }

        public int Braking
        {
            get { return braking; }
            set { braking = value; }
        }

        public Car() { }

        public Car(int id,string name,int year,double price,int acceleration,int braking)
        {
            this.id = id;
            this.acceleration = acceleration;
            this.braking = braking;
            this.name = name;
            this.year = year;
            this.price = price;
        }

        public void Accelerate(int increase)
        {
            this.acceleration += increase;
        }

        public void Accelerate()
        {
            this.acceleration++;
        }

        public void Break()
        {
            this.braking--;
        }
        public void Break(int decrease)
        {
            this.braking -= decrease;
        }
    }
}
