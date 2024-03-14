/*
ES 1
Crea un programma che chiede all'utente di inserire un numero da 1 a 5 e stampa
il giorno lavorativo corrispondente,
 utilizzando un enum GiorniLavorativi (es. 1 per Lunedì, 2 per Martedì, ecc.).
 Se l'utente inserisce un numero fuori dall'intervallo, mostra un messaggio di errore. 

ES 2
Creare un'applicazione console in C# che gestisce una collezione di libri in una libreria.
Ogni libro avrà un titolo, un autore e un codice ISBN univoco.

ES 3
Scrivere una classe Domanda1 che contenga al suo interno un metodo main, 
nel quale si dichiari l'array di interi V=[6,3,1,2,9] e si calcoli la 
media dell'array, stampandola sullo schermo.  

ES 4
Definisci una classe Forma con due metodi statici: CalcolaAreaCerchio e CalcolaAreaQuadrato. 
Entrambi i metodi riceveranno i parametri necessari per il calcolo dell'area
(raggio per il cerchio, lato per il quadrato) e restituiranno l'area calcolata.
Nel tuo programma principale, chiedi all'utente di scegliere tra il calcolo dell'area di un cerchio o di un quadrato,
quindi esegui il calcolo appropriato e stampa il risultato.
*/
using System;

public class Giorno4{
    public static void Main(){
        //ESERCIZIO 1
        Console.WriteLine("Esercizio 1\n");
        Console.WriteLine("Inserire un numero da 1 a 5 per visualizzare il giorno lavorativo corrispondente");
        int giorno = Convert.ToInt32(Console.ReadLine());
        Giorni.GiornoLavorativo(giorno);
        //Console.WriteLine(giorno.ToString());
        //ESERCIZIO 2
        Console.WriteLine("Esercizio 2\n");
        Libreria lib = new Libreria();
        int cod_Compra = 0;
        lib.StampaLibri();
        Console.WriteLine("Inserisci il codice del libro che vuoi comprare: ");
        cod_Compra = Convert.ToInt32(Console.ReadLine());
        lib.LibroComprato(cod_Compra);
        //ESERCIZIO 3
        Console.WriteLine("Esercizio 3\n");
        Domanda1.main();
        //ESERCIZIO 4
        Console.WriteLine("Esercizio 4\n");
        Console.WriteLine("Inserisci (1) per calcolare l'area di un cerchio, e (2) per calcolare l'area di un quadrato\n");
        int choice = Convert.ToInt32(Console.ReadLine());
        if(choice == 1){
            Console.WriteLine("Inserisci il raggio: \n");
            int r = Convert.ToInt32(Console.ReadLine());
            CalcAree.CalcolaAreaCerchio(r);
        }else if(choice == 2){
            Console.WriteLine("Inserisci il lato: \n");
            int la = Convert.ToInt32(Console.ReadLine());
            CalcAree.CalcolaAreaQuadrato(la);
        }else{
            Console.WriteLine("Scelta errata");
        }

    }
}
//Esercizio 1
public class Giorni{
    public enum GiorniLavorativi{
        Lunedi=1,
        Martedi=2,
        Mercoledi=3,
        Giovedi=4,
        Venerdi=5
    }
    public static void GiornoLavorativo(int giorno){
        while(giorno<1 || giorno>5){
            Console.WriteLine("Errore, inserire un numero da 1 a 5");
            giorno = Convert.ToInt32(Console.ReadLine());
            if(giorno == -1){
                return;
            }
        }
        Console.WriteLine((GiorniLavorativi)giorno);
    }
}
//Esercizio 2
public class Libro{
    private string titolo,autore;
    private int ISBN;
    public Libro(string titolo,string autore,int ISBN){
        this.titolo = titolo;
        this.autore = autore;
        this.ISBN = ISBN;
    }
    public int GetISBN(){
        return ISBN;
    }
    public string GetTitolo(){
        return titolo;
    }
    public string GetAutore(){
        return autore;
    }
}
public class Libreria{
    private Libro[] libri={
        new Libro("Il signore degli anelli","J.R.R. Tolkien",123456),
        new Libro("Il vecchio e il mare","Ernest Hemingway",654321),
        new Libro("Il nome della rosa","Umberto Eco",987654)
    
    };
    public void StampaLibri(){
        for(int i=0;i<libri.Length;i++){
            Console.WriteLine("Libro "+(i+1)+": "+libri[i].GetTitolo()+" - "+libri[i].GetAutore()+" - "+libri[i].GetISBN());
        }
    }
    public void LibroComprato(int ISBN){
        bool found = false;
        for(int i=0;i<libri.Length;i++){
            if(libri[i].GetISBN() == ISBN){
                found = true;
                Console.WriteLine("Libro acquistato: "+libri[i].GetTitolo());
                libri[i] = null;
                return;
            }else{
                found = false;
            }
        }
        if(!found)
            Console.WriteLine("Libro non trovato");
    }
}
//Esercizio 3
public class Domanda1{
    public static void main(){
        int[] V = {6,3,1,2,9};
        int med = 0;
        for(int i=0;i<V.Length;i++){
            med+=V[i];
        }
        med = med/V.Length;
        Console.WriteLine("Media: "+med);
    }
}
//ESERCIZIO 4
public class CalcAree{
    public static void CalcolaAreaCerchio(int raggio){
        double area = Math.PI*raggio*raggio;
        Console.WriteLine("Area: "+area);
    }
    public static void CalcolaAreaQuadrato(int lato){
        double area = lato*lato;
        Console.WriteLine("Area: "+area);
    }

}
