using System;

/*
In C#, un delegato è un tipo che rappresenta riferimenti a metodi con un particolare elenco
    di parametri e tipo di ritorno.
Quando si crea un'istanza di un delegato, è possibile associare il suo istanza a
    qualsiasi metodo con una firma compatibile.
È possibile invocare (o chiamare) il metodo attraverso l'istanza del delegato.
I delegati sono utilizzati per passare metodi come parametri a altri metodi.
Le classi degli eventi sono un esempio fondamentale di delegati.
I delegati sono alla base di molte librerie .NET Framework e sono il meccanismo
    fondamentale per gli eventi.
*/

/*
Action<> è un delegato che rappresenta un metodo che accetta un certo numero (da 0 a 16) di argomenti e
    non restituisce un valore.
Ad esempio, Action<int> rappresenta un metodo che accetta un singolo parametro di tipo int e non restituisce nulla.
Func<> è un delegato che rappresenta un metodo che accetta un certo numero (da 0 a 16)
    di argomenti e restituisce un valore.
L'ultimo tipo nell'elenco di tipi Func<> è il tipo di ritorno del metodo.
Ad esempio, Func<int, int, int> rappresenta un metodo che accetta due parametri di tipo int e restituisce un int.

*/

public class Giorno7{
    public static void Main(){
        //Errore e = new Errore();
        MyDelegate del = new MyDelegate(MyMethod);//Creo il delegato
        del("Hello world"); //Richiamo la funzione del delegato
        //Delegato func per una funzione che accetta due input e un output
        Func<int,int,int> funcDelegate = sum;
        int a,b;
        Console.WriteLine("Inserisci a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Somma = "+funcDelegate(a,b));
        //Delegato Action per una funzione senza output (void)
        Action<string> display = prt;
        string msg;
        Console.WriteLine("Inserisci messaggio da stampare: ");
        msg = Console.ReadLine();
        prt(msg);
        //Funzione Lambda
        Action<string> greet = name => {string greeting = $"Benvenuto, {name}!";Console.WriteLine(greeting);};
        Console.WriteLine("Inserisci il tuo nome: ");
        string nm = Console.ReadLine();
        greet(nm);
    }
    public static void prt(string msg){
        Console.WriteLine("Stampo messaggio => " + msg);
    }
    public static int sum(int a,int b){
        return a+b;
    }
    // Definizione del delegato
    public delegate void MyDelegate(string msg);
    // Metodo che corrisponde alla firma del delegato
    public static void MyMethod(string message){
        Console.WriteLine(message);
    }
}

//Classi Sealed non possono essere usate come superclassi, non si possono <estendere>
sealed class Chiusa{
    Chiusa(){
        Console.WriteLine("Questa classe Sealed è chiusa");
    }
}
/*
class Errore : Chiusa{ //'Errore' non può derivare dal tipo sealed 'Chiusa'
    Errore(){
        Console.WriteLine("Errore");
    }
}*/
