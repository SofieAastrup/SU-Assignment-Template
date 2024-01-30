public class Student{
  // Add properties and methods here
  // blank method for taking cup
  bool hasCup = false;
    public void TakeCup(Canteen canteen){
        if (canteen.Cups > 0 ){
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
