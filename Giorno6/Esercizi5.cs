using System;
using System.Text;

public class Giorno6_ES5{
    public static void Main(){
        Es5 es5 = new Es5();
        es5.Esercizio5();
    }
}

public class Es5{
    private StringBuilder sb{get;set;}
    public void Esercizio5(){
        sb = new StringBuilder();
        sb.Append("Il C# è divertente!");
        Console.WriteLine("Frase Iniziale: " + sb.ToString());
        sb.Replace("divertente", "fantastico");
        Console.WriteLine("Sostituzione: " + sb.ToString());
        sb.Remove(0, 3);
        Console.WriteLine("Rimozione: " + sb.ToString());
    }
}