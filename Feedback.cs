using System;
using System.Collections.Generic;
using System.IO;
public class Feedback{
  // TODO: Lista com Mês 

  // Parametros
string _nome;
double _maisCaro;
double _maisBarato;
double _dinheiroInicial;
double _valorFinal;-

// Contrutores
public Feedback(string nome, double maisCaro, double maisBarato)
{
  _nome = nome;
  _maisCaro = maisCaro;
  _maisBarato = maisBarato;

}

public Feedback()
{

}
// TODO: Getters e Setters

// TODO: Um Metodo que cria uma arquivo com o path que recebe o nome de cada usuário do projeto

public void generateFeedback()
{
   StreamWriter lapis;
    string test = "y";
    string pathF = test + ".txt";
    
    lapis = File.AppendText(pathF);
    lapis.WriteLine("Nome");
    lapis.WriteLine("Dinheiro Inical");
    lapis.Close();
}


//hist mes
// gasto mais alto menor dispesa


}