using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Quanto deseja Juntar");
    double junt = double.Parse(Console.ReadLine());
    Console.WriteLine("Dia do Pagamento");
    int pag = int.Parse(Console.ReadLine());
    Console.WriteLine("Dia de Pagar as Contas");
    int pc = int.Parse(Console.ReadLine());
    Controller soft = new Controller(junt, pag, pc);
    soft.createUser();
  }
}

