using System;
using System.Collections.Generic;

//TODO: 
/*
1. Sistemare prestiti (collegare utente al presito)
2. Aggiustare scaffali (collegare scaffali a Documento)
3. Migliorare Interfaccia Utente e stampa dei risultati
*/

public class Esercizio3{
    public static void Main(){
        Biblioteca b = new Biblioteca();
        Console.WriteLine("Inserisci le tue credenziali.\nMail: ");
        string mail = Console.ReadLine();
        Console.WriteLine("Inserisci la password: ");
        string pw = Console.ReadLine();
        Console.WriteLine("Inserisci il tuo telefono: ");
        string fono = Console.ReadLine();
        Utente u = new Utente(mail,pw,fono);
        b.Menu();
    }
}

public class Utente{
    public string nome{get;set;}
    public string cognome {get;set;}
    public string email {get;set;}
    public string pw {get;set;}
    public string num_tel {get;set;}
    public Utente(string em,string pass,string tel){
        Console.WriteLine("Inserisci il tuo nome: ");
        this.nome = Console.ReadLine();
        Console.WriteLine("Inserisci il tuo cognome: ");
        this.cognome = Console.ReadLine();
        this.email=em;
        this.pw=pass;
        this.num_tel=tel;
    }
}

public abstract class Documento{
    private static int glob_cod = 1;
    public int codice {get;set;}
    public string titolo {get;set;}
    public List<string> autori {get;set;}
    public string data_emiss {get;set;}
    public bool prestato {get;set;}
    public int scaffale {get;set;}
    private int i = 0;
    private Random rnd = new Random();
    public abstract void getInfo();
    private string CreaData(){
        Random rand = new Random();
        int anno = rand.Next(2000, 2023);
        int mese = rand.Next(1, 13);
        int giorno;
        if(mese == 2){
            giorno = rand.Next(1,28);
        }else{
            giorno = rand.Next(1,31);
        }
        DateTime dataCasuale = new DateTime(anno, mese, giorno);
        return dataCasuale.ToString("dd/MM/yyyy");
    }
    public Documento(){
        this.codice=glob_cod;
        glob_cod++;
        this.data_emiss = CreaData();
        this.prestato = false;
    }
}

public class Libro : Documento{
    public static bool stato = false;
    private Random rnd = new Random();
    private int i=0;
    public int n_pag {get;set;}
    public List<string> autori{get;set;}
    public Libro(){
        autori = new List<string>();
        this.n_pag=rnd.Next(10,50);
    }
    public override void getInfo(){
        Console.WriteLine("Libro: \nTitolo: "+titolo+"\nAutore: ");
        foreach(var a in autori){
            Console.Write(a +", ");
        }
        Console.WriteLine("\nNumero Pagine: "+n_pag+"\nCodice: "+this.codice+"\nSTATO: "+this.prestato);
    }
}

public class CD : Documento{
    public int durata {get;set;}
    private Random rnd = new Random();
    public CD(string tt){
        this.durata = rnd.Next(1,60);
        base.titolo=tt;
    }
    public override void getInfo(){
        Console.WriteLine("Libro: \nTitolo: "+titolo+"\nAutore: "+"Durata: "+durata+"\nCodice: "+this.codice+"\nSTATO: "+this.prestato);
    }
}
public class Autor{
    public List<string> aut {get;set;}
    public Autor(){
        aut = new List<string>();
    }
}
public class Biblioteca{
    public Autor autore {get;set;}
    public List<Biblioteca> sedi {get;set;}
    private int ultimoscaff = 0;
    List<Utente> utenti = new List<Utente>();
    List<Libro> LibriDisp = new List<Libro>();
    List<CD> CDDisp = new List<CD>();
    List<Libro> LibriPrest = new List<Libro>();
    List<CD> CDPrest = new List<CD>();
    Dictionary<int,bool> scaffali = new Dictionary<int, bool>();
    public Biblioteca(){
        autore = new Autor();
        sedi = new List<Biblioteca>();
    }
    public Documento cerca(int cod){
        foreach(var l in LibriDisp){
            if(l.codice==cod){
                return (Libro)l;
            }
        }
        foreach(var c in CDDisp){
            if(c.codice==cod){
                return (CD)c;
            }
        }
        return null;
    }
    public void StampaDisp(){
        Console.WriteLine("Libri Disponibili: ");
        foreach(var l in LibriDisp){
            l.getInfo();
        }
        Console.WriteLine("CD Disponibili: ");
        foreach(var c in CDDisp){
            c.getInfo();
        }
    }
    public void stampaPrest(){
        Console.WriteLine("Libri in prestito: ");
        foreach(var lib in LibriPrest){
            lib.getInfo();
        }
        Console.WriteLine("CD in prestito: ");
        foreach(var c in LibriPrest){
            c.getInfo();
        }
    }
    public void StampaScaff(){
        foreach(var c in scaffali){
            Console.WriteLine("Scaffale: "+c.Key+"=> "+c.Value);
        }
    }
    public void CreaAutore(string aut){
        this.autore.aut.Add(aut);
    }
    public void AggiungiScaffale(){
        scaffali.Add(ultimoscaff++,false);
    }
    public int cercaVuoto(){
        if(scaffali.Count > 1){
            for(int i=0;i<scaffali.Count;i++){
                if(scaffali[i]==false)
                    return i+1;
            }
        }
        return 1;
    }
    public void CreaLibro(string tit){
        Libro l = new Libro();
        l.titolo=tit;
        LibriDisp.Add(l);
    }
    public void AggiungiAutor(string aut,Libro l){
        l.autori.Add(aut);
    }
    public void CreaBiblioteca(){
        Biblioteca tmp = new Biblioteca();
        sedi.Add(tmp);
    }
    public Documento cercatit(string tt){
        foreach(var l in LibriDisp){
            if(l.titolo==tt){
                return (Libro)l;
            }
        }
        foreach(var c in CDDisp){
            if(c.titolo==tt){
                return c;
            }
        }
        return null;
    }
    public Libro CercaLibro(string tit){
        foreach(var l in LibriDisp){
            if(l.titolo==tit){
                return l;
            }
        }
        Console.WriteLine("Non trovato..");
        return null;
    }
    public Documento cercaPrestN(int n){
        foreach(var l in LibriPrest){
            if(l.codice==n){
                return (Libro)l;
            }
        }
        foreach(var c in CDPrest){
            if(c.codice==n){
                return (CD)c;
            }
        }
        return null;
    }
    public void CreaCD(string tt){
        CD tmp = new CD(tt);
        scaffali.Add(ultimoscaff,true);
        ultimoscaff++;
    }
    public Documento cercaPrestT(string t){
        foreach(var l in LibriPrest){
            if(l.titolo==t){
                return (Libro)l;
            }
        }
        foreach(var c in CDPrest){
            if(c.titolo==t){
                return (CD)c;
            }
        }
        return null;
    }
    public void Menu(){
        while(true){
            Console.WriteLine("Scegliere cosa si vuol fare: ");
            Console.WriteLine("1)Inserire un autore\n2)Creare Libri\n3)Creare CD ed aggiungere a scaffale\n4Creare Scaffali\n5)Creare Biblioteca\n6)Aggiungere autore/i ad un libro\n7)Stampa disponibilità\n8)Stampa scaffali\n9)Ricerca tramite codice\n10)Ricerca tramite titolo\n11)Ricerca prestiti per numero\n12)Ricerca prestiti per titolo\n13)Modifica stato da codice\n0)Uscire\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1:
                    Console.WriteLine("Inserisci nome autore: ");
                    string aut = Console.ReadLine();
                    this.CreaAutore(aut); //Creo l'autore aggiungendolo alla lista di autori
                    break;
                case 2: 
                    Console.WriteLine("Inserisci nome libro: ");
                    string tit = Console.ReadLine();
                    CreaLibro(tit);
                    break;
                case 3:
                    Console.WriteLine("Inserisci nome CD: ");
                    string titCD = Console.ReadLine();
                    CreaCD(titCD);
                    break;
                case 4: 
                    Console.WriteLine("Creo Scaffale...");
                    this.AggiungiScaffale(); //Creo uno scaffale impostandolo a false (non occupato)
                    break;
                case 5:
                    Console.WriteLine("Creo biblioteca...");
                    this.CreaBiblioteca();
                    break;
                case 6:
                    Console.WriteLine("Dimmi il nome del libro cui aggiungere l'autore: ");
                    string titol = Console.ReadLine();
                    Console.WriteLine("Dimmi il nome dell'autore: ");
                    string au = Console.ReadLine();
                    Libro tmp; //libro temporaneo per controllare se esiste
                    try{
                        tmp = CercaLibro(titol);
                        tmp.autori.Add(au);
                    }catch(NullReferenceException){ //gestisco l'eccezione
                        Console.WriteLine("Il libro cercato non esiste!");
                        break; //se il libro non esiste, esco dal case
                    }
                    Console.WriteLine("Fatto");
                    break;
                case 7: 
                    this.StampaDisp();
                    break;
                case 8:
                    this.StampaScaff();
                    break;
                case 9:
                    Console.WriteLine("Inserisci codice da ricercare: ");
                    int tmp_cod = Convert.ToInt32(Console.ReadLine());
                    Documento tmpDoc;
                    try{
                        tmpDoc = cerca(tmp_cod);
                        tmpDoc.getInfo();
                    }catch(NullReferenceException){
                        Console.WriteLine("Il codice non è presente!");
                    }
                    break;
                case 10:
                    Console.WriteLine("Inserisci titolo da cercare: ");
                    string tmptit=Console.ReadLine();
                    Documento tmpDoc2;
                    try{
                        tmpDoc2=cercatit(tmptit);
                        tmpDoc2.getInfo();
                    }catch(NullReferenceException){
                        Console.WriteLine("Nessun documento con quel titolo!");
                    }
                    break;
                case 11:
                    Console.WriteLine("Inserisci numero da ricercare nei prestiti: ");
                    int prestnum = Convert.ToInt32(Console.ReadLine());
                    Documento prested;
                    try{
                        prested=cercaPrestN(prestnum);
                        prested.getInfo();
                    }catch(NullReferenceException){
                        Console.WriteLine("Questo numero non c'è");
                    }
                    break;
                case 12:
                    Console.WriteLine("Inserisci titolo da ricercare nei prestiti: ");
                    string prestTit = Console.ReadLine();
                    Documento prestedT;
                    try{
                        prestedT=cercaPrestT(prestTit);
                        prestedT.getInfo();
                    }catch(NullReferenceException){
                        Console.WriteLine("Questo titolo non c'è");
                    }
                    break;
                case 13:
                    Console.WriteLine("Dimmi il codice del Documento cui modificare lo stato: ");
                    int switchCod = Convert.ToInt32(Console.ReadLine());
                    Documento d;
                    try{
                        d = cerca(switchCod);
                        if(d.prestato){
                            d.prestato = false;
                        }else{
                            d.prestato = true;
                        }
                    }catch(NullReferenceException){
                        Console.WriteLine("Il documento cercato non esiste!");
                    }
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Opzione non valida"); //Gestisco qualunque altra opzione
                    break;
                
            }
        }
    }
}
