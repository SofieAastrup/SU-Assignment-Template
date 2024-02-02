using NUnit.Framework;
using DIKUCanteen;
using System; 

namespace DIKUCanteenTests;

public class Tests
{
    [SetUp]
    public void Setup(){
    }

    [TestCase(3, 2)]
    [TestCase(10, 10)]
    [TestCase(2, 5)]
    public void TestCanTakeCup(int cups, int students){
        // create canteen object
        Canteen canteen = new Canteen();
        // set the number of cups in the canteen
        canteen.Cups = cups;

        // loop
        for (int i = 0; i < students; i++){
            // create student object
            Student student = new Student();
            // take a cup from the canteen
            student.TakeCup(canteen);
            // return a cup to the canteen

        }

        Assert.AreEqual(canteen.Cups, Math.Max(0, cups - students));
    }
}