using System;
using System.Text;

public class Giorno6_ES6{
    public static void Main(){
        Es6 es6 = new Es6();
        es6.Esercizio6();
    }
}

public class Es6{
    private StringBuilder sb{get;set;}
    public void Esercizio6(){
        sb = new StringBuilder();
        sb.Append("Il C# è fantastico!");
        Console.WriteLine("Frase Iniziale: " + sb.ToString());
        sb[3] = 'c'; //sb[3]=Char.ToLower(sb[3])
        Console.WriteLine("Sostituzione: " + sb.ToString());
    }
}