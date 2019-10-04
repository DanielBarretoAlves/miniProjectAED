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
      // _payDay;
      // _billsDay;
      // _days++;

      // Console.WriteLine("Dia" + _days);
      // PayDay
      if(_days == _payDay)
      {
        // TODO: Call Method Payday
        
        

        userList[selectedUser].Cash += userList[selectedUser].Salary;
        // Console.WriteLine("Cash " + userList[selectedUser].Cash);

      }

      if(_days == _billsDay)
      {
        // TODO: Call MethodBills Day
        userList[selectedUser].Cash -= userList[selectedUser].payBill();

        
      }

      //_months
      if(_days == 30)
      {
        _months ++;
        _days = 0;
        // storage = File.CreateText(path);
        // storage.WriteLine("test");
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

  //TODO: só pq é obrigatorio 3 MethodBills

  public void showTime()
  {
    Console.Clear();
    Console.WriteLine("meses " + _months + ", e " + _days + " dias e, " + _years + " Anos");
  }

  


  


}


// TODO: Pegar Gastos do User, Pegar Valor a que deseja salvar, pegar dispesas, calcular o tempo para alcançar o tempo até se alcançar o valor desejado.

// using System;
// using System.IO;

// class Test 
// {
//     public static void Main() 
//     {
//         string path = @"c:\temp\MyTest.txt";
//         // This text is added only once to the file.
//         if (!File.Exists(path)) 
//         {
//             // Create a file to write to.
//             using (StreamWriter sw = File.CreateText(path)) 
//             {
//                 sw.WriteLine("Hello");
//                 sw.WriteLine("And");
//                 sw.WriteLine("Welcome");
//             }	
//         }

//         // This text is always added, making the file longer over time
//         // if it is not deleted.
//         using (StreamWriter sw = File.AppendText(path)) 
//         {
//             sw.WriteLine("This");
//             sw.WriteLine("is Extra");
//             sw.WriteLine("Text");
//         }	

//         // Open the file to read from.
//         using (StreamReader sr = File.OpenText(path)) 
//         {
//             string s = "";
//             while ((s = sr.ReadLine()) != null) 
//             {
//                 Console.WriteLine(s);
//             }
//         }
//     }
// }