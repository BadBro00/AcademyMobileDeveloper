/*
1. Liste
Crea una lista di stringhe e popolala con i nomi di 5 città. Stampa la lista.
Aggiungi una città alla lista e rimuovi la seconda città. Stampa la lista modificata.
Ordina la lista in ordine alfabetico e stampa il risultato.

2. Dizionari
Crea un dizionario dove le chiavi sono nomi di studenti e i valori sono i loro voti. Popola il dizionario con 5 elementi.
Aggiungi un nuovo studente al dizionario e modifica il voto di uno studente esistente.
Stampa tutti i nomi degli studenti e i loro voti in ordine di nome.

3. SortedDictionary
Crea un SortedDictionary utilizzando come chiave la data di nascita (stringa) e come valore il nome di una persona. Aggiungi 5 elementi.
Stampa il contenuto del SortedDictionary mostrando come le voci siano ordinate per data di nascita.

4. Dizionari Multidimensionali
Crea un dizionario dove la chiave è una categoria (es: "Frutta") e il valore è un altro dizionario che contiene coppie nome-quantità (es: "Mela" - 10).
Aggiungi una nuova categoria con alcuni elementi e modifica la quantità di un elemento esistente in una categoria.

5. Dizionari Annidati
Simile all'esercizio 4, ma con un livello di annidamento in più. Ad esempio, categorie di prodotti, dove ogni categoria contiene prodotti,
e ogni prodotto ha un dizionario di proprietà (prezzo, quantità).

6. Set
Crea un set di numeri interi e popolalo con alcuni valori. Mostra come i valori duplicati non vengano aggiunti.
Dato un altro set di numeri, esegui e stampa l'unione, l'intersezione e la differenza tra i due set.

7. Sistema di Gestione di Biblioteca
Sviluppare un sistema semplificato per gestire una biblioteca, che includa funzionalità per aggiungere libri, utenti e gestire i prestiti dei libri. L'esercizio deve utilizzare:
Una lista per memorizzare i libri disponibili nella biblioteca.
Un dizionario per tenere traccia degli utenti e del numero di libri che hanno attualmente in prestito.
Un set per registrare i libri attualmente prestati.

Funzionalità:
Implementa una lista chiamata libriDisponibili per memorizzare i nomi dei libri. Includi funzionalità per aggiungere e rimuovere libri dalla lista.
Gestione degli Utenti
Usa un dizionario chiamato utentiPrestiti per tenere traccia degli utenti e del numero di libri che hanno in prestito. La chiave è l'ID dell'utente (es: una stringa o un numero) e il valore è il numero di libri presi in prestito.
Gestione dei Prestiti
Crea un set chiamato libriInPrestito per tenere traccia dei libri che sono stati prestati e non sono attualmente disponibili nella biblioteca. Quando un libro viene prestato, dovrebbe essere rimosso da libriDisponibili e aggiunto a libriInPrestito.

Funzionalità
Aggiungi una funzione PrestaLibro che permette di prestare un libro a un utente, aggiornando tutte le collezioni pertinenti. Assicurati di gestire il caso in cui un libro non è disponibile o l'utente ha già raggiunto il limite massimo di prestiti.
Aggiungi una funzione RestituisciLibro che permette a un utente di restituire un libro, aggiornando di conseguenza le collezioni.
Interfaccia Utente
Implementa un semplice menu in console che permetta agli utenti di aggiungere libri, registrare nuovi utenti, prestare e restituire libri.
*/

using System;
using System.Collections.Generic;

public class Giorno8{
    public static void Main(){
        int scelta;
        Console.WriteLine("\t[ES 1]\nPremi 1 per saltare al 2°: ");
        scelta = Convert.ToInt32(Console.ReadLine());
        if(scelta == 1)
            goto eser2;
        Esercizio1 es1 = new Esercizio1();
        eser2:
        Console.WriteLine("\t[ES 2]\nPremi 1 per saltare al 3°: ");
        scelta = Convert.ToInt32(Console.ReadLine());
        if(scelta == 1)
            goto eser3;
        Esercizio2 es2 = new Esercizio2();
        eser3:
        Console.WriteLine("\t[ES 3]\nPremi 1 per saltare al 4°: ");
        scelta = Convert.ToInt32(Console.ReadLine());
        if(scelta == 1)
            goto eser4;
        Esercizio3 es3 = new Esercizio3();
        eser4:
        Console.WriteLine("\t[ES 4]\nPremi 1 per saltare al 5°: ");
        scelta = Convert.ToInt32(Console.ReadLine());
        if(scelta == 1)
            goto eser5;
        Esercizio4 es4 = new Esercizio4();
        eser5:
        Console.WriteLine("\t[ES 5]\nPremi 1 per saltare al 6°: ");
        scelta = Convert.ToInt32(Console.ReadLine());
        if(scelta == 1)
            goto eser6;
        Esercizio5 es5 = new Esercizio5();
        eser6:
        Console.WriteLine("\t[ES 6]\nPremi 1 per saltare al 7°: ");
        scelta = Convert.ToInt32(Console.ReadLine());
        if(scelta == 1)
            goto eser7;
        Esercizio6 es6 = new Esercizio6();
        eser7:
        Console.WriteLine("\t[ES 7]\nPremi 1 per terminare, 0 per eseguirlo");
        scelta = Convert.ToInt32(Console.ReadLine());
        if(scelta == 1)
            return;
        else{
            Esercizio7 es7 = new Esercizio7();
        }
    }
}

//----------------------------|ESERCIZIO 1|---------------------
/*
Crea una lista di stringhe e popolala con i nomi di 5 città. Stampa la lista.
Aggiungi una città alla lista e rimuovi la seconda città. Stampa la lista modificata.
Ordina la lista in ordine alfabetico e stampa il risultato.*/
public class Esercizio1{
    private List<string> lista = new List<string>(){"Napoli","Roma","Milano","Lecce","Canicatti"};
    public Esercizio1(){
        Console.WriteLine("\t\t[Lista]");
        foreach (var citta in lista){
            Console.WriteLine(citta + " ");
        }
        Console.WriteLine("Inserisci la città da rimuovere: ");
        string città = Console.ReadLine();
        if(!lista.Contains(città)){
            Console.WriteLine("Città non presente");
            return;
        }
        lista.Remove(città);
        Console.WriteLine("Rimosso elemento "+città);
        Console.WriteLine("\t\t[Lista Aggiornata]");
        foreach (var citta in lista){
            Console.WriteLine(citta + " ");
        }
        lista.Sort();
        Console.WriteLine("\t\t[Lista Ordinata]");
        foreach (var citta in lista){
            Console.WriteLine(citta + " ");
        }
    }
}
//---------------------------|ESERCIZIO 2|----------------------
/*Crea un dizionario dove le chiavi sono nomi di studenti e i valori sono i loro voti. Popola il dizionario con 5 elementi.
Aggiungi un nuovo studente al dizionario e modifica il voto di uno studente esistente.
Stampa tutti i nomi degli studenti e i loro voti in ordine di nome.*/
public class Esercizio2{
    public Dictionary<string,List<int>> registro = new Dictionary<string, List<int>>();
    public Esercizio2(){
        registro["eugenio"] = [10,10,10,10];
        registro["daniele"] = [7,8,5,9];
        registro["riccardo"] = [1,2,3,4];
        registro["nicola"] = [7,7,7,7];
        registro["francesca"] = [10,9,4,7];
        Console.WriteLine("\t\t[Registro Iniziale]");
        foreach(var stud in registro){
            Console.Write($"[{stud.Key}] : {{");
            foreach(var voto in stud.Value)
                Console.Write(voto+" ");
            Console.Write("}\n");
        }
        Console.WriteLine("Inserisci il nome del nuovo studente:");
        string nome = Console.ReadLine();
        List<int> voti = new List<int>();
        for(int i=0;i<4;i++){
            Console.WriteLine($"Inserisci il voto #{i+1}: ");
            voti.Add(Convert.ToInt32(Console.ReadLine()));
        }
        registro.Add(nome,voti);
        Console.WriteLine("\t\t[Registro]");
        foreach(var stud in registro){
            Console.Write($"[{stud.Key}] : {{");
            foreach(var voto in stud.Value)
                Console.Write(voto+" ");
            Console.Write("}\n");
        }
        Console.WriteLine("Inserisci il nome di uno studente nel registro: ");
        string modifNome = Console.ReadLine();
        if(registro.ContainsKey(modifNome)){
            Console.WriteLine("Inserisci l'indice del voto da modificare (1-4): ");
            int modifIdx = Convert.ToInt32(Console.ReadLine());
            if(modifIdx<1||modifIdx>4){
                Console.WriteLine("Indice non valido");
                return;
            }
            Console.WriteLine("Inserisci il nuovo voto: ");
            int newVoto = Convert.ToInt32(Console.ReadLine());
            foreach(var stud in registro){
                if(stud.Key == modifNome){
                    for(int i=0;i<4;i++){
                        if(i==modifIdx-1)
                            stud.Value[i] = newVoto;
                    }
                }
            }
        }else{
            Console.WriteLine("Nome non presente nel registro");
        }
        Console.WriteLine("\t\t[Registro Aggiornato]");
        foreach(var stud in registro){
            Console.Write($"[{stud.Key}] : {{");
            foreach(var voto in stud.Value)
                Console.Write(voto+" ");
            Console.Write("}\n");
        }
    }
}
//--------------------------|ESERCIZIO 3|------------------------
/*Crea un SortedDictionary utilizzando come chiave la data di nascita (stringa) e come valore il nome di una persona.
Aggiungi 5 elementi. Stampa il contenuto del SortedDictionary mostrando come le voci siano ordinate per data di nascita.*/
public class Esercizio3{
    public SortedDictionary<string,string> SD = new SortedDictionary<string,string>();
    public Esercizio3(){
        for(int i=0;i<5;i++){
            Console.WriteLine("Inserisci nome persona "+(i+1)+": ");
            string tmp_nome = Console.ReadLine();
            Console.WriteLine("Inserisci data di nascita persona "+(i+1));
            string tmp_ddn = Console.ReadLine();
            SD.Add(tmp_ddn,tmp_nome);
        }
        foreach(var persona in SD){
            Console.WriteLine("[DDN]: "+persona.Key+" - [Nome]: "+persona.Value);
        }
    }
}
//-------------------------------|ESERCIZIO 4|--------------------------------
/*Crea un dizionario dove la chiave è una categoria (es: "Frutta") e il valore è un altro
    dizionario che contiene coppie nome-quantità (es: "Mela" - 10).
Aggiungi una nuova categoria con alcuni elementi e modifica la quantità di un elemento esistente in una categoria.*/
public class Esercizio4{
    public Dictionary<string,Dictionary<string,int>> Mercato = new Dictionary<string, Dictionary<string, int>>();
    public Esercizio4(){
        Mercato.Add("Frutta",new Dictionary<string,int>{{"mele",10},{"banane",5},{"kiwi",2}});
        Mercato.Add("ProdottiCasa",new Dictionary<string,int>{{"Detersivo",1},{"CartaIgienica",3},{"Led",4}});
        Mercato.Add("Bagno",new Dictionary<string,int>{{"Spazzolini",16},{"Shampoo",7},{"cottonfioc",9}});
        Console.WriteLine("\t\t[Mercato Iniziale]");
        foreach (var cat in Mercato.OrderBy(c => c.Key)){
            Console.WriteLine($"Categoria: {cat.Key}");
            foreach (var elem in cat.Value.OrderBy(e => e.Key)){
                Console.WriteLine($"\tElemento: {elem.Key}, Quantità: {elem.Value}");
            }
        }
        Console.WriteLine("Inserisci il nome della nuova categoria:");
        string newcat = Console.ReadLine();
        Dictionary<string,int> nuovo = new Dictionary<string, int>();
        for(int i=0;i<3;i++){
            Console.WriteLine("Inserisci elemento: ");
            string elem = Console.ReadLine();
            Console.WriteLine("Inserisci quantità: ");
            int qt = Convert.ToInt32(Console.ReadLine());
            nuovo.Add(elem,qt);
        }
        Mercato.Add(newcat,nuovo);
        Console.WriteLine("\t\t[Mercato Aggiornato]");
        foreach (var cat in Mercato.OrderBy(c => c.Key)){
            Console.WriteLine($"Categoria: {cat.Key}");
            foreach (var elem in cat.Value.OrderBy(e => e.Key)){
                Console.WriteLine($"\tElemento: {elem.Key}, Quantità: {elem.Value}");
            }
        }
    }
}
//--------------------------|ESERCIZIO 5|-----------------------------
/*Simile all'esercizio 4, ma con un livello di annidamento in più. Ad esempio, categorie di prodotti,
dove ogni categoria contiene prodotti,e ogni prodotto ha un dizionario di proprietà (prezzo, quantità).
Aggiungi una nuova categoria con alcuni elementi e modifica la quantità di un elemento esistente in una categoria.*/
public class Esercizio5{
    //Dichiarazione del layer esterno
    public Dictionary<string,Dictionary<string,Dictionary<string,int>>> Mercatone = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>();
    //Dichiarazione del layer intermedio
    public Dictionary<string,Dictionary<string,int>> categoriaVest = new Dictionary<string, Dictionary<string,int>>();
    public Dictionary<string,Dictionary<string,int>> categoriaFru = new Dictionary<string, Dictionary<string,int>>();
    public Dictionary<string,Dictionary<string,int>> categoriaBag = new Dictionary<string, Dictionary<string,int>>();
    //Dichiarazione dei layer più interni
    public Dictionary<string,int> prodotti = new Dictionary<string, int>(); //1. Vestiario
    public Dictionary<string,int> prodotti2 = new Dictionary<string, int>(); //2. Frutta
    public Dictionary<string,int> prodotti3 = new Dictionary<string, int>(); //3. Bagno
    public Esercizio5(){
        //Inizializzo i layer più interni (<string,int>), per ogni categoria
        //1. Vestiario
        {
        prodotti.Add("Scarpe",2);
        prodotti.Add("Calzini",5);
        prodotti.Add("Mutande",3);
        prodotti.Add("Sciarpe",4);
        prodotti.Add("Scaldacollo",11);
        prodotti.Add("Fazzoletto da Taschino",20);
        }
        //2. Frutta
        prodotti2.Add("mele",32);
        prodotti2.Add("pere",15);
        prodotti2.Add("banane",25);
        prodotti2.Add("kiwi",14);
        //3. Bagno
        prodotti3.Add("Bagnoschiuma",2);
        prodotti3.Add("Shampoo",5);
        prodotti3.Add("Spazzolini",3);
        prodotti3.Add("Dentifricio",4);
        prodotti3.Add("Carta Igienica",11);
        //Aggiunta del 2° layer (string,Dictionary<string,Dictionary<...>>) 
        categoriaVest.Add("Vestiario",prodotti);
        categoriaFru.Add("Frutta",prodotti2);
        categoriaBag.Add("Bagno",prodotti3);
        //Aggiunta del primo layer (<string,Dictionary<<...>>)
        Mercatone.Add("NegozioVestiti",categoriaVest);
        Mercatone.Add("NegozioFrutta",categoriaFru);
        Mercatone.Add("NegozioBagno",categoriaBag);
        //Stampa di tutti gli elementi, per categoria
        Console.WriteLine("\t\t[Mercatone]");
        foreach(var negozio in Mercatone.OrderBy(c=>c.Key)){
            foreach(var cat in negozio.Value){
                Console.WriteLine("\t[Categoria: "+cat.Key+"]");
                foreach(var prod in cat.Value)
                    Console.WriteLine(prod.Key+", "+prod.Value);
            }
        }
        Console.WriteLine("Inserisci nuova categoria: ");
        string nuovacat = Console.ReadLine();
        Dictionary<string,Dictionary<string,int>> newcat = new Dictionary<string, Dictionary<string, int>>();
        Console.WriteLine("Inserisci numero elementi della categoria: ");
        int dim = Convert.ToInt32(Console.ReadLine());
        Dictionary<string,int> nuovielem = new Dictionary<string, int>();
        for(int i=0;i<dim;i++){
            Console.WriteLine("Inserisci nome elemento: "+(i+1));
            string nome_elem = Console.ReadLine();
            Console.WriteLine("Inserisci quantità dell'elemento: "+nome_elem);
            int qt = Convert.ToInt32(Console.ReadLine());
            nuovielem.Add(nome_elem,qt);
        }
        newcat.Add(nuovacat,nuovielem);
        Mercatone.Add("Negozio "+nuovacat,newcat);
        Console.WriteLine("\t\t[Mercatone Aggiunta categoria]");
        foreach(var negozio in Mercatone.OrderBy(c=>c.Key)){
            foreach(var cat in negozio.Value){
                Console.WriteLine("\t[Categoria: "+cat.Key+"]");
                foreach(var prod in cat.Value)
                    Console.WriteLine(prod.Key+", "+prod.Value);
            }
        }
    }
}
//-------------------------------|ESERCIZIO 6|-----------------------------
/*Crea un set di numeri interi e popolalo con alcuni valori. Mostra come i valori duplicati non vengano aggiunti.
Dato un altro set di numeri, esegui e stampa l'unione, l'intersezione e la differenza tra i due set.*/
public class Esercizio6{
    public HashSet<int> hs = new HashSet<int>();
    public Esercizio6(){
        int[] valori = new int[]{1,1,3,2,7,1,2,7,4,5,6};
        int[] valori2 = new int[]{1,3,2,9,1,9,10,8};
        Console.WriteLine("Inserisco "+valori.Length+" valori");
        for(int i=0;i<valori.Length;i++){
            Console.WriteLine("Aggiungo il numero: "+valori[i]+"...");
            hs.Add(valori[i]);
        }
        Console.WriteLine("\t\t[HashSet 1]");
        foreach(var num in hs){
            Console.WriteLine(num + " ");
        }
        HashSet<int> hs2 = new HashSet<int>();
        foreach(var num in valori2)
            hs2.Add(num);
        Console.WriteLine("\t\t[HashSet 2]");
        foreach(var num in hs2)
            Console.WriteLine(num+" ");
        Console.WriteLine("\t[Eseguo l'Unione]");
        HashSet<int> unione = new HashSet<int>(hs);
        unione.UnionWith(hs2);
        foreach(var num in unione)
            Console.WriteLine(num+" ");
        Console.WriteLine("\t[Eseguo l'Intersezione]");
        HashSet<int> intersez = new HashSet<int>(hs);
        intersez.IntersectWith(hs2);
        foreach(var num in intersez)
            Console.WriteLine(num+" ");
        Console.WriteLine("\t[Eseguo la Differenza]");
        HashSet<int> diff = new HashSet<int>(hs);
        diff.ExceptWith(hs2);
        foreach(var num in diff)
            Console.WriteLine(num+" ");
    }
}
//----------------------------|ESERCIZIO 7|----------------------
/*Sviluppare un sistema semplificato per gestire una biblioteca, che includa funzionalità per aggiungere libri,
    utenti e gestire i prestiti dei libri.
L'esercizio deve utilizzare:
    Una lista per memorizzare i libri disponibili nella biblioteca.
    Un dizionario per tenere traccia degli utenti e del numero di libri che hanno attualmente in prestito.
    Un set per registrare i libri attualmente prestati.

Funzionalità:
    Implementa una lista chiamata libriDisponibili per memorizzare i nomi dei libri.
    Includi funzionalità per aggiungere e rimuovere libri dalla lista.
    Gestione degli Utenti
        Usa un dizionario chiamato utentiPrestiti per tenere traccia degli utenti e
            del numero di libri che hanno in prestito.
        La chiave è l'ID dell'utente (es: una stringa o un numero) e il valore è il numero di libri presi in prestito.
Gestione dei Prestiti
    Crea un set chiamato libriInPrestito per tenere traccia dei libri che sono stati prestati e non sono attualmente disponibili nella biblioteca. Quando un libro viene prestato, dovrebbe essere rimosso da libriDisponibili e aggiunto a libriInPrestito.

Funzionalità
    Aggiungi una funzione PrestaLibro che permette di prestare un libro a un utente,
        aggiornando tutte le collezioni pertinenti. Assicurati di gestire il caso in cui
            un libro non è disponibile o l'utente ha già raggiunto il limite massimo di prestiti.
    Aggiungi una funzione RestituisciLibro che permette a un utente di restituire un libro,
        aggiornando di conseguenza le collezioni.
Interfaccia Utente
    Implementa un semplice menu in console che permetta agli utenti di aggiungere libri,
    registrare nuovi utenti, prestare e restituire libri.*/
public class Utente{
    public string nome{get;set;}
    public int ID{get;set;}
    public int libriprest{get;set;}
    private int glob_ID = 1;
    public Utente(string nm){
        this.nome=nm;
        this.ID=glob_ID++;
        this.libriprest=0;
    }
}
public class Libro{
        public string nome{get;set;}
        public int IDUtente{get;set;}
        public Libro(string nm,int id=-1){
            this.nome = nm;
        }
    }
public class Esercizio7{
    public List<Libro> LibriDisp = new List<Libro>();
    public Dictionary<int,int> LibriInPrestito = new Dictionary<int, int>();
    public HashSet<Libro> LibriPrestati = new HashSet<Libro>();
    public Esercizio7(){
        Console.WriteLine("Inserisci il tuo nome: ");
        string nm = Console.ReadLine();
        Utente user = new Utente(nm);
        Console.WriteLine("Benvenuto utente: "+nm+"\nIl tuo ID è: "+user.ID);
        LibriDisp.Add(new Libro("Divina Commedia"));
        LibriDisp.Add(new Libro("Hacking Etico"));
        LibriDisp.Add(new Libro("Ricette di Cucina"));
        StampaDisp();
        Console.WriteLine("Scegli il libro che vuoi dare in prestito: ");
        string libname = Console.ReadLine();
        PrestaLibro(libname,user.ID,user.libriprest);
    }
    public void RestituisciLibro(string nomelibro,int ID){
        LibriDisp.Add(new Libro(nomelibro,ID));
        LibriInPrestito[ID]--;
        Libro rimuovi = LibriPrestati[CercaLibro(nomelibro)];
        LibriPrestati.Remove(rimuovi);
    }
    public int CercaLibro(string nm){
        for(int i=0;i<LibriDisp.Count;i++){
            if(LibriDisp[i].nome==nm)
                return i;
        }
        return -1;
    }
    public void PrestaLibro(string nome,int ID,int prest){
        int idx = CercaLibro(nome);
        if(idx == -1){
            Console.WriteLine("Libro non Disponibile");
            return;
        }
        Libro tmp = LibriDisp[idx];
        LibriDisp.RemoveAt(idx);
        LibriInPrestito.Add(ID,1);
        LibriPrestati.Add(tmp);
    }
    public void StampaDisp(){
        Console.WriteLine("\t[Libri Disponibili]");
        foreach(var lib in LibriDisp){
            Console.WriteLine("Titolo ["+lib.nome+"]");
        }
    }
    public void StampaPrestati(){
        Console.WriteLine(" ");
        foreach(var l in LibriPrestati)
            Console.WriteLine("[Titolo] : {{"+l.nome+" }");
    }
}
