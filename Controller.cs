using System;
using System.Collections.Generic;
public class Controller{

public Controller(){
  
}




  //TODO: User Generator
  //  var item = new User("Daniel", 1700.95, 700.5);
  // List<int> numberList = new List<int>(); 
  public void createUser()
  {
    Console.WriteLine("UserName:");
    string name = Console.ReadLine();
    Console.WriteLine("Budget");
    double budget = double.Parse(Console.ReadLine());
    Console.WriteLine("Salary: ");
    double payment = double.Parse(Console.ReadLine());

    List<User> userList = new List<User>();
    userList.Add(new User(name, budget, payment));
    Console.WriteLine(userList[0].Name);
  }


}