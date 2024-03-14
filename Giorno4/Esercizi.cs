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
}*/

//------------------------|ESERCIZI|-----------------------------
/*
ES 1:
In qualità di nuovo stagista, hai il compito di attrezzare le nuove sale di formazione
    con tutti gli elementi necessari per condurre corsi di formazione tecnica di qualità.
Ti verrà assegnato un budget e un elenco di articoli da acquistare. 
      
    INPUT:
    • Sulla prima riga, si richiederà il  budget, un valore in virgola mobile      
    • Sulla seconda riga, richiederà il numero di articoli da acquistare
    • Nelle  3 righe successive, si richiedono i dati dell'articolo come tali:
        1. Il nome dell'elemento -
        2. Il prezzo dell'articolo -
        3. lA Quantità degli elementi
    :
    OUTPUT
    Ogni volta che un articolo viene aggiunto al carrello, stampa "Aggiunta di {quantità} {oggetto} al carrello" sulla console. 
    Dopo che tutti gli articoli sono stati aggiunti al carrello, è necessario calcolare il totale parziale degli 
        articoli e verificare se il budget sarà sufficiente.
    • Se è sufficiente, stampa "Denaro disponibile: $ {denaroDisponibile}"
    • Altrimenti, stampa "Non abbastanza. Abbiamo bisogno di $ {denaro} in più."


ES 2: ECCEZIONI
Scrivere un programma che gestisca l’eccezione generata dal codice:
int[] T = null;
T[0] = 7;
NullReferenceException e


ES 3:
Scrivere un programma che gestisca l’eccezione generata dal codice:
string s = null;
int l = s.Length;


ES 4: 
Creare una classe 
Quadrato, con lato di valore 15. Quindi stampare il
perimetro e l’area dell’oggetto appena creato.

ES 5:
 * Scrivere un programma SommaPariDispari che prevede un array di 10 numeri interi contenente valori a 
 * piacere (senza bisogno di chiederli all’utente) e stampa Pari e dispari uguali se la somma dei numeri 
 * in posizioni pari dell’array e' uguale alla somma dei numeri in posizioni dispari, altrimenti il 
 * programma stampa Pari e dispari diversi. 
*/
using System;
//using System.Exception;
public class Giorno4{
    public static void Main(){
        Console.WriteLine("Esercizio1\n");
        Esercizio1();
        Console.WriteLine("Esercizio2\n");
        Esercizio2();
        Console.WriteLine("Esercizio3\n");
        Esercizio3();
        Console.WriteLine("Esercizio4\n");
        Console.WriteLine("Creo Quadrato con l = 15\n");
        Quadrato q = new Quadrato(15);
        Console.WriteLine("Perimetro del quadrato: "+q.CalcolaPerim(q.getLato())+", Area del quadrato: "+q.CalcolArea(q.getLato()));
        Console.WriteLine("Esercizio 5\n");
        Esercizio5();
    }
    public static void Esercizio1(){
        Console.WriteLine("Inserisci il budget: ");
        double budget = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Inserisci il numero di articoli da acquistare: ");
        int n_articoli = Convert.ToInt32(Console.ReadLine());
        int tot_articoli = 0;
        while(budget>0 && tot_articoli<n_articoli){
            Console.WriteLine("Inserisci il nome dell'articolo: ");
            string nm_art = Console.ReadLine();
            Console.WriteLine("Inserisci il prezzo dell'articolo: ");
            double pr_art = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserisci la quantità dell'articolo: ");
            int q_art = Convert.ToInt32(Console.ReadLine());
            if(budget >= q_art*pr_art){
                budget -= q_art*pr_art;
                for(int i=0;i<q_art;i++)
                    tot_articoli++;
                Console.WriteLine("Aggiunta di "+q_art+" "+nm_art+" al carrello\n\t|Budget Rimanente : "+ budget+"|");
            }else{
                Console.WriteLine("Non abbastanza. Abbiamo bisogno di: "+(budget-q_art*pr_art-budget)+" in più.");
            }
        }
    }
    public static void Esercizio2(){
        int[] T = null;
        try{
            T[0] = 7;
        }catch (NullReferenceException){
            Console.WriteLine("Null Reference Exception\n|Conversione di una variabile NULL in un tipo che non ammette NULL|\n");
        }
    }
    public static void Esercizio3(){
        try{
            string s = null;
            int l = s.Length;
        }catch(NullReferenceException){
            Console.WriteLine("Dereferenziazione di un valore NULL\n|Stai prendendo la lunghezza di una variabile NULL|");
        }
    }
    public static void Esercizio5(){
        Random rnd = new Random();
        int dim = 10;
        int[] array = new int[dim];
        for(int i=0;i<dim;i++)
            array[i] = rnd.Next(1,100);
        int sommapari = 0,sommadisp = 0;
        foreach (var num in array){
            if(num%2==0)
                sommapari+=num;
            else
                sommadisp+=num;
        }   
        if(sommapari == sommadisp)
            Console.WriteLine("Pari e dispari uguali");
        else
            Console.WriteLine("Pari e dispari diversi");
    }
}
//ESERCIZIO 4
public class Quadrato{
    private int lato;
    public Quadrato(int l){
        this.lato = l;
    }
    public int getLato(){
        return this.lato;
    }
    public int CalcolaPerim(int l){
        return l*4;
    }
    public int CalcolArea(int l){
        return l*l;
    }
}
