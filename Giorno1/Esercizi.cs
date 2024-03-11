using System;

public class Prova{
    public static void Main(){
        //Esercizio 1
        //Chiedi nome e cognome e stampa, poi due numeri e stampa somma, poi mostra nome,eta,id e sal di un impiegato
        Console.WriteLine("Esercizio 1: Chiedi nome e cognome e stampa, poi due numeri e stampa somma, poi mostra nome,eta,id e sal di un impiegato\n");
        string nome,cognome,nm;
        int n1,n2,eta,id;
        double sal;
        Console.WriteLine("Inserisci il tuo nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Inserisci il tuo cognome: ");
        cognome = Console.ReadLine();
        Console.WriteLine($"Ciao {nome} {cognome}!");
        Console.WriteLine("Inserisci il primo numero: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci il secondo numero: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"La somma dei due numeri è: {n1+n2}");
        Console.WriteLine("Inserisci il nome dell'impiegato: ");
        nm = Console.ReadLine();
        Console.WriteLine("Inserisci l'età dell'impiegato: ");
        eta = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci l'id dell'impiegato: ");
        id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci il salario dell'impiegato: ");
        sal = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Nome: {nm}\nEtà: {eta}\nId: {id}\nSalario: {sal}");
        //Esercizio 2
        //Data la risoluzione di una foto, calcola i megapixel
        Console.WriteLine("Esercizio 2: Calcola i megapixel di una foto\n");
        int w,h;
        double mp;
        Console.WriteLine("Inserisci la larghezza della foto: ");
        w = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci l'altezza della foto: ");
        h = Convert.ToInt32(Console.ReadLine());
        mp = (w*h)/1000000.0;
        Console.WriteLine($"La foto ha una risoluzione di {w}x{h} e quindi {mp} megapixel");
    }
}
