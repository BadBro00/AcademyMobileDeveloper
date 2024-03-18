using System;
using System.Text;

public class Giorno6_ES7{
    public static void Main(){
        Es7 es7 = new Es7();
        es7.Esercizio7();
    }
}

public class Es7{
    private StringBuilder sb{get;set;}
    public void Esercizio7(){
        sb = new StringBuilder();
        sb.Append("Il C# fa divertire");
        Console.WriteLine("Frase Iniziale: " + sb.ToString());
        sb.Insert(9, "molto ");
        Console.WriteLine("Inserimento: " + sb.ToString());
        sb.Remove(6, 2);
        Console.WriteLine("Rimozione: " + sb.ToString());
    }
}