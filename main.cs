using System;

class MainClass {
  public static void Main (string[] args) {
    double valor, taxa, tempo, prestacao;
    
    Console.Write ("Digite o valor da prestação: ");
    valor = double.Parse(Console.ReadLine ());
    
    Console.Write ("Digite a taxa do juros da prestação: ");
    taxa = double.Parse (Console.ReadLine ());
    
    Console.Write ("Digite o quantidade de dias de atraso da fatura: ");
    tempo = double.Parse (Console.ReadLine ());
    
    prestacao = valor + (valor*(taxa/100)*tempo);
    
    Console.Write ("O valor de sua prestação em atraso é: "+ prestacao);
    
    Console.ReadKey ();
  }
}