// create function to test canTakeCup

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// arguments number of cups in canteen and number of students in canteen
// set up canteen
// set up students
// loop through students
// take cup
// return true if number of cups in canteen is stil above 0
// return false if number of cups in canteen is 0

namespace DIKUCanteen
{
    class Test
    {
        public static bool canTakeCup(int cups, int students)
        {
            // create canteen object
            Canteen canteen = new Canteen();
            // set the number of cups in the canteen
            canteen.Cups = cups;

            // loop
            for (int i = 0; i < students; i++)
            {
                // create student object
                Student student = new Student();
                // take a cup from the canteen
                student.TakeCup(canteen);
                // return a cup to the canteen
                
            }

            if (canteen.Cups > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
    
        }
    }
}