using System;
using  System.Collections.Generic;
public class User{
  //TODO: Atributes
  string _name;
  double _cash;
  double _salary;
  //TODO: Check List How2Work
  List<double> _expenses = new List<double>(); 


   //TODO: Constructor
   public User(string name, double cash, double salary)
   {
      _name = name;
      _cash = cash;
      _salary = salary;

   }

   public string Name 
   {
      get => _name;
      set => _name = value;
   }

   public double Cash
   {
      get => _cash;
      set => _cash = value; 
   }
   public double Salary{
     get => _salary;
     set => _salary = value;
   }


   // TODO: Add Dispesas

  public void addBills(){
    bool key = true;
    while(key != false)
    {
      Console.WriteLine("Digite 1 (UM) para Adicionar uma dispesa ou 0 (ZERO) para parar");
      int action = int.Parse(Console.ReadLine());
      if(action == 1)
      {
        Console.WriteLine("Informe o Valor da dispesa");
        double val = double.Parse(Console.ReadLine());
        _expenses.Add(val);
      }else{
        key = false;
      }
    }
  }
  // TODO: Metodo que retorna o valor a ser Pago
  public double payBill(){
    
    double seeYou = 0;
    foreach(double value in _expenses)
    {
      seeYou += value;
    }
    return seeYou;
  }





}

// foreach (double value in _expenses )       
//         {       
//         Console.WriteLine(value);       
//         }