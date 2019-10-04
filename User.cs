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
}