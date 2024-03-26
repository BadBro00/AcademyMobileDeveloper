using System;
using System.Threading;
using System.Globalization;
using System.Text;
/*1) Crea un'applicazione che avvia due thread.
Un thread dovrebbe stampare i numeri pari da 1 a 10,
    mentre l'altro dovrebbe stampare i numeri dispari da 1 a 10.

2) Fai un modo tale che possiamo camparare di due oggetti
    Animale basandoci tramite l'età

3) Definisci un metodo chiamato BuildString che accetta una lista di
    stringhe come argomento e restituisce un oggetto StringBuilder.
All'interno del metodo, unisci tutte le stringhe della lista
    in un unico StringBuilder separando ciascuna stringa con uno spazio.
Restituisci l'oggetto StringBuilder.*/

public class Giorno10{
    public static void Main(){
        Es1 e1 = new Es1();
        Es2 e2 = new Es2();
        Es3 e3 = new Es3();
        List<string> lista = new List<string>();
        StringBuilder s = new StringBuilder();
        int choice;
        while(true){
            Console.WriteLine("1)Inserisci stringa\n2)Termina");
            choice = Convert.ToInt32(Console.ReadLine());
            if(choice == 1){
                Console.WriteLine("Inserisci la stringa: ");
                string tmp = Console.ReadLine();
                lista.Add(tmp);
            }else if(choice == 2){
                s = e3.BuildString(lista);
                break;
            }else{
                Console.WriteLine("Scelta non valida, riprova.");
            }
        }
        Console.WriteLine("StringBuilder ritornato completo: ");
        Console.WriteLine(s);
    }
}
//-----------------|Esercizio1|------------------
/*1) Crea un'applicazione che avvia due thread.
Un thread dovrebbe stampare i numeri pari da 1 a 10,
    mentre l'altro dovrebbe stampare i numeri dispari da 1 a 10.*/
public class Es1{
    public Thread pari = new Thread(StampaPari);
    public Thread disp = new Thread(StampaDispari);
    public Es1(){
        pari.Start();
        Console.WriteLine("Thread pari creato, di TID: "+pari.ManagedThreadId);
        disp.Start();
        Console.WriteLine("Thread pari creato, di TID: "+disp.ManagedThreadId);
        Console.WriteLine("\nAspetto termino i thread...\n\n");
        Console.WriteLine("Terminati\n");
    }
    public static void StampaPari(){
        Console.WriteLine("Numeri dispari 1-10:");
        for(int i=1;i<=10;i++)
            if(i%2==0)
                Console.WriteLine(i+" ");
    }
    public static void StampaDispari(){
        Console.WriteLine("Numeri dispari 1-10:");
        for(int i=1;i<=10;i++)
            if(i%2!=0)
                Console.WriteLine(i+" ");
    }
}
//-----------------|Esercizio2|------------------
/*2) Fai un modo tale che possiamo comparare di due oggetti
    Animale basandoci tramite l'età*/
public class Es2{
    public class Animale{
        public string nome;
        public DateTime dt;
        public Animale(string nm,string ddn){
            this.nome = nm;
            this.dt=DateTime.ParseExact(ddn,"dd/mm/yy",CultureInfo.InvariantCulture);
        }
        public static void comparaAnimali(Animale A,Animale B){
            if(A.dt>B.dt)
                Console.WriteLine($"{A.nome} è più giovane di {B.nome}");
            else if(B.dt>A.dt)
                Console.WriteLine($"{B.nome} è più giovane di {A.nome}");
            else
                Console.WriteLine($"{A.nome} e {B.nome} sono ugualmente vecchi");
        }
    }
    public Es2(){
        Console.WriteLine("Inserisci il primo animale: ");
        string nm1 = Console.ReadLine();
        Console.WriteLine("Inserisci la ddn del primo animale (dd/mm/yy): ");
        string ddn1 = Console.ReadLine();
        Animale A = new Animale(nm1,ddn1);
        Console.WriteLine("Inserisci il secondo animale: ");
        string nm2 = Console.ReadLine();
        Console.WriteLine("Inserisci la ddn del secondo animale (dd/mm/yy): ");
        string ddn2 = Console.ReadLine();
        Animale B = new Animale(nm2,ddn2);
        Animale.comparaAnimali(A,B);
    }
}
//-----------------|Esercizio3|------------------
/*3) Definisci un metodo chiamato BuildString che accetta una lista di
    stringhe come argomento e restituisce un oggetto StringBuilder.
All'interno del metodo, unisci tutte le stringhe della lista
    in un unico StringBuilder separando ciascuna stringa con uno spazio.
Restituisci l'oggetto StringBuilder.*/
public class Es3{
    public StringBuilder sb = new StringBuilder();
    public StringBuilder BuildString(List<string> l){
        foreach(var s in l){
            sb.Append(s+" ");
        }
        return sb;
    }
}
