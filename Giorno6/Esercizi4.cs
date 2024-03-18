using System;
using System.Text;

public class Giorno6_ES4{
    public static void Main(){
        Es4 e = new Es4();
        e.CreaStringa();
        Console.WriteLine("Ho finito, ecco la frase intera: " + e.sb.ToString());
    }
}

public class Es4{
    public StringBuilder sb{get; set;}
    private string[] parole = {"Oggi", "è", "una", "bella", "giornata"};
    public Es4(){
        sb = new StringBuilder();
    }
    public void CreaStringa(){
        foreach (var par in parole){
            Console.WriteLine($"Aggiungo la parola {par}");
            sb.Append(par+" ");
        }
    }
}