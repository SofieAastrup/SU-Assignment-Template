namespace DIKUCanteen;

public class Student: Person{
  // Add properties and methods here
  bool hasCup = false;

    public Student(string name, string occupation, int age): base(name, occupation, age){
    }
    public void TakeCup(Canteen canteen){
        if (canteen.Cups > 0 && hasCup == false){
            canteen.Cups -= 1;
            hasCup = true;
        }

    }

    // blank method for returning cup
    public void ReturnCup(Canteen canteen){
        if (hasCup == true){
            canteen.Cups += 1;
            hasCup = false;
        }
    }


}
