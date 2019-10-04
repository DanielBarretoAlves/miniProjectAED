using System;
using System.Collections.Generic;
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

    
    userList.Add(new User(name, budget, payment));
    // Console.WriteLine(userList[0].Name);
    userList[0].addBills();
    calcTime();
  }

  // TODO: Calc o Tempo Estimado
  public void calcTime()
  {
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

      double _saveVal;
      // _payDay;
      // _billsDay;
      // _days++;

      // PayDay
      if(_days == _payDay)
      {
        // TODO: Call Method Payday

      }

      if(_days == _billsDay)
      {
        // TODO: Call MethodBills Day
      }

      //_months
      if(_days == 30)
      {
        _months ++;
        _days = 0;
      }

    }

  }


  


}


// TODO: Pegar Gastos do User, Pegar Valor a que deseja salvar, pegar dispesas, calcular o tempo para alcançar o tempo até se alcançar o valor desejado