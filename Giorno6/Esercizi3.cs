using System;

public class Giorno6_ES3{
    public static void Main(){
        string str;
        Console.WriteLine("Inserisci un numero: ");
        str = Console.ReadLine();
        Converter c = new Converter(str);
        c.Converti();
    }
}

public class Converter{
    private int dividendo,divisore;
    private string input;
    public Converter(string input){
        this.input = input;
    }
    public void Converti(){
        Console.WriteLine("Inserisci il divisore: ");
        this.divisore = Convert.ToInt32(Console.ReadLine());
        int n=0;
        try{
            n = Convert.ToInt32(input)/divisore;
            Console.WriteLine($"Il risultato è {n}");
        }catch(DivideByZeroException){
            Console.WriteLine("Non puoi dividere per zero");
        }catch(FormatException){
            Console.WriteLine("Inserisci un numero valido");
        }
    }
}