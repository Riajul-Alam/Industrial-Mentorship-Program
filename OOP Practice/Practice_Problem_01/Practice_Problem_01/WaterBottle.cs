using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problem_01
{
    // Accessibility: public,internal,protected,private
    // by default class is internal
    // by default field and method/function private
    // if we use internal , same project one file can access another file
    // private feild and method only accessible from class itself
    //
    class WaterBottle // class name always noun 
    {
        private double waterAmount;// field
        private string color;
        private double capacity;
        //private bool isOpen;
        /*
                public WaterBottle() { }// constructor overloading

                public WaterBottle(string color)// constructor overloading
                {
                    this.color = color;
                }
        */

        public WaterBottle() : this("white", 400) // Constructor Chaining
        {

        }
        public WaterBottle(string color, double capacity) // Constructor
        {
            this.color = color;
            this.capacity = capacity;
        }
        ~WaterBottle() // Finalaizer or destructor
        {
            this.color=null;
            this.waterAmount=0;
        }
        /*
                public string GetColor()
                {
                    return color;
                }
        */

        // use properties
        public string Color
        {
            get { return color; }
        }
        public double WaterAmount
        {
            get { return waterAmount; }
            set
            {
                if (value>=0 && value<=capacity)
                {
                    waterAmount=value;
                }
            }
        }
        /*
                public bool IsOpen
                {
                    get { return isOpen; }
                    set { isOpen=value; }
                }
        */

        // auto property

        public bool IsOpen { get;/*private*/ set; }



        public void AddWater(double amount)
        {
            waterAmount += amount;
        }

        // method overloading 
        public void AddWater(int amount)
        {
            waterAmount+=amount;
        }
    }
}
