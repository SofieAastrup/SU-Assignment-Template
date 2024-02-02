using System;

namespace DIKUCanteen
{
    class Program
    {
        static void Main(string[] args){
            // create canteen object
            Canteen canteen = new Canteen();
            
            // set the number of cups in the canteen
            canteen.Cups = 7;
            
            // create student object
            Student student = new Student();
            // take a cup from the canteen
            student.TakeCup(canteen);
            // return a cup to the canteen
            student.ReturnCup(canteen);
            // print the number of cups in the canteen
            Console.WriteLine("Number of cups in the canteen: {0}", canteen.Cups);
        }
    }
}

