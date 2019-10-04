using System;
using System.Collections.Generic;
using System.IO;
public class Controller{
// TODO: Pelo Menos 3 Atributos
double _saveVal;
int _payDay;
int _billsDay;
int _days = 0;
int _years = 0;
int _months = 0;
List<User> userList = new List<User>();


// TODO: Dois Construtores
public Controller(){
  
}
public Controller(double saveVal, int payDay, int billsDay)
{
  _saveVal = saveVal;
  _payDay = payDay;
  _billsDay = billsDay;
}




  //TODO: User Generator 
  public void createUser()
  {
    Console.WriteLine("UserName:");
    string name = Console.ReadLine();
    Console.WriteLine("Budget");
    double budget = double.Parse(Console.ReadLine());
    Console.WriteLine("Salary: ");
    double payment = double.Parse(Console.ReadLine());

    
    userList.Add(new User(name, budget, payment));
    // Console.WriteLine(userList[0].Name);
    userList[0].addBills();
    calcTime();
  }
  // TODO: Calc o Tempo Estimado
  public void calcTime()
  {

    StreamWriter storage;
    string path = "storage.txt";
    
    int selectedUser;
    Console.WriteLine("Selecione um Usuario");
    for(int i =0; i < userList.Count; i++)
    {
      Console.WriteLine(i + " - " + userList[i].Name);
    }
    selectedUser = int.Parse(Console.ReadLine());
    // Cash
    while(userList[selectedUser].Cash < _saveVal)
    {

      _days++;

      if(_days == _payDay)
      {
        userList[selectedUser].Cash += userList[selectedUser].Salary;
      }

      if(_days == _billsDay)
      {
        userList[selectedUser].Cash -= userList[selectedUser].payBill();

        
      }

      //_months
      if(_days == 30)
      {
        _months ++;
        _days = 0;
       
      }

      if(_months == 12)
      {
        _months = 0;
         _years++;
         Console.WriteLine("informe a Sua Promoção");
         double promo = double.Parse(Console.ReadLine());
         userList[selectedUser].getPromotion(promo);
      }
      showTime();

    }
    

  }


  public void showTime()
  {
    Console.Clear();
    Console.WriteLine("meses " + _months + ", e " + _days + " dias e, " + _years + " Anos");
  }

}