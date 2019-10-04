using System;

class MainClass {
  public static void Main (string[] args) {
    // var item = new User("Daniel", 1700.95, 700.5);
    //   Console.WriteLine("Name: " + item.Name);
    //   Console.WriteLine("Cash: $" + item.Cash);
    //   Console.WriteLine("Salary: $" + item.Salary);
    Controller soft = new Controller(1000.0, 5, 4);
    soft.createUser();
  }
}

/*TODO:
Classes - User + Contol
Gerar Historico de Dados Baseado nas Caracteristicas do Usuário
*/