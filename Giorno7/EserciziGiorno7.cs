/*
1)
Definire un'interfaccia IMezzoDiTrasporto che specifichi un insieme di metodi relativi al trasporto, come Avvia(), Ferma() e CalcolaDistanza(int km).
Creare tre mezzi di trasporto che implementano l'interfaccia.
Nel Main richiamare i metodi Avvia Ferma e CalcolaDistanza

2)
Creare una classe astratta Veicolo che contenga almeno un metodo astratto e una proprietà comune a tutti i veicoli.
Estendere la classe Veicolo crendo due classi specifiche, ad esempio Automobile e Motocicletta.
Implementare il metodo astratto in modi diversi per ciascuna classe.

3)
Crea un sistema per una catena di ristoranti, utilizzando una classe astratta "Ristorante" che fornisce implementazioni di base
per alcune funzionalità e interfacce come IPrenotabile e IValutabile per aggiungere funzionalità specifiche come prenotazioni e recensioni.

4) DELEGATI
Definisci un delegate Operazione che accetta due parametri int e restituisce int, implementa quattro metodi statici
Addizione, Sottrazione, Moltiplicazione e Divisione che corrispondono alla firma del delegate. Infine utilizzarlo nel main.

5) 
Sviluppare un programma console che permetta la gestione di StandardUser e SuperUser per un sistema di sicurezza.
StandardUser e Superuser sono sottoclassi di classe astratta User
StandardUser e Superuser necessitano di uno username, una descrizione del profilo e una password.
Implementare  un sistema che permetta la creazione di una password e la modifica della stessa.
Subito dopo la creazione di un nuovo profilo la password potrà essere impostata manualmente:
Le password per standardUser devono rispettare 10 caratteri di lunghezza
Le password per superUser devono rispettare 20 caratteri di lunghezza
Le password non potranno contenere caratteri vuoti
Se è gia stata impostata una password, per modificarla sarà necessario effettuare un controllo con la vecchia password.
Se una password è presente sarà possibile ( se richiesto)  generarla automaticamente: utilizzare il metodo generaPassword seguente:
Utilizza  Classe Random e genera una stringa casuale di una data lunghezza:

public static StringBuilder generaPassword(int l){
    StringBuilder builder = new StringBuilder();
    Random random = new Random();
    char ch;
    for (int i = 0; i <= l; i++){
        ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
        builder.Append(ch);
    }
    return builder;
}

Utilizzare un'interfaccia chiamata IGenerate per l'utilizzo del metodo generaPassword(int l)
Utilizzare un'interfaccia chiamata IControl per il metodo o i metodi di controllo
*/
using System;
using System.Linq;
using System.Text;

public class EsGiorno7{
    public static void Main(){
        Automobile a = new Automobile();
        Motocicletta m = new Motocicletta();
        BiciclettaElettrica b = new BiciclettaElettrica();
        //Avvio
        a.Avvia();
        m.Avvia();
        b.Avvia();
        //Fermo
        a.Ferma();
        m.Ferma();
        b.Ferma();
        //CalcolaDistanza
        Console.WriteLine("L'auto ha percorso: "+b.CalcolaDistanza(1)+" dal km 1");
        Console.WriteLine("La moto ha percorso: "+b.CalcolaDistanza(1)+" dal km 1");
        Console.WriteLine("La bici ha percorso: "+b.CalcolaDistanza(1)+" dal km 1");
        Console.WriteLine("\t\t[Esercizio2]");
        Auto auto = new Auto();
        Moto moto = new Moto();
        auto.GetInfo();
        moto.GetInfo();
        Console.WriteLine("\t\t[Esercizio3]");
        string tp,nm;
        int p;
        Console.WriteLine("Inserisci nome ristorante: ");
        nm = Console.ReadLine();
        Console.WriteLine("Inserisci tipo ristorante: ");
        tp = Console.ReadLine();
        Console.WriteLine("Inserisci posti del ristorante: ");
        p = Convert.ToInt32(Console.ReadLine());
        Rist r = new Rist(nm,p,tp);
        Console.WriteLine("Inserisci numero persone della prenotazione: ");
        int pers = Convert.ToInt32(Console.ReadLine());
        if(r.Prenotabile(pers))
            Console.WriteLine("Prenotazione possibile, effettuata");
        else
            Console.WriteLine("Prenotazione non possibile, troppi rispetto ai posti");
        r.Prt_Info();
        r.LasciaRecensione();
        r.Prt_Recensione();
        Console.WriteLine("\t\t[Esercizio4]");
        int x,y;
        Console.WriteLine("Inserisci il primo numero: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci il secondo numero: ");
        y = Convert.ToInt32(Console.ReadLine());
        ChiamaDelegato c = new ChiamaDelegato(myDelegate);
        c(x,y);
        Console.WriteLine("\t\t[Esercizio5]");
        Console.WriteLine("1.Standard User\n2.Super User");
        int choice = Convert.ToInt32(Console.ReadLine());
        if(choice==1){
            string uname;
            int len;
            Console.WriteLine("Inserisci il nome utente: ");
            uname = Console.ReadLine();
            Console.WriteLine("Inserisci una lunghezza per la password: ");
            len = Convert.ToInt32(Console.ReadLine());
            StandardUser s = new StandardUser(uname);
            s.CreatePW(len);
            bool res = false;
            Console.WriteLine("Effettuiamo il Login, immetti la tua password: ");
            res = s.Login(uname,Console.ReadLine());
            while(!res){
                Console.WriteLine("Utente non loggato, combinazione username/password errata, riprova");
                res = s.Login(uname,Console.ReadLine());
            }
            if(res){
                Console.WriteLine("Utente "+uname+" loggato, benvenuto!");
                Console.WriteLine("La tua password è poco sicura, cambiamola!");
                Console.WriteLine("Inserisci nuova password: ");
                string nuovapw = Console.ReadLine();
                s.ModifyPW(nuovapw);
            }
        }else if(choice==2){
            string s_uname,s_pw;
            int s_len;
            Console.WriteLine("Inserisci il nome utente: ");
            s_uname = Console.ReadLine();
            Console.WriteLine("Inserisci una lunghezza per la password: ");
            s_len = Convert.ToInt32(Console.ReadLine());
            SuperUser SU = new SuperUser(s_uname);
            SU.CreatePW(s_len);
            bool res = false;
            Console.WriteLine("Effettuiamo il Login, immetti la tua password: ");
            res = SU.Login(s_uname,Console.ReadLine());
            while(!res){
                Console.WriteLine("Utente non loggato, combinazione username/password errata, riprova");
                res = SU.Login(s_uname,Console.ReadLine());
            }
            if(res){
                Console.WriteLine("Utente "+s_uname+" loggato, benvenuto!");
                Console.WriteLine("La tua password è poco sicura, cambiamola!");
                Console.WriteLine("Inserisci nuova password: ");
                string s_nuovapw = Console.ReadLine();
                SU.ModifyPW(s_nuovapw);
            }
        }
    }
    //-----------------------|ESERCIZIO 4|-----------------------------
/*
4) DELEGATI
Definisci un delegate Operazione che accetta due parametri int e restituisce int,
    implementa quattro metodi statici Addizione, Sottrazione, Moltiplicazione e Divisione
    che corrispondono alla firma del delegate.
Infine utilizzarlo nel main.
*/

public static void myDelegate(int a,int b){
    Console.WriteLine("Addizione: " + (a+b));
    Console.WriteLine("Sottrazione: "+ (Math.Max(a,b)-Math.Min(a,b)));
    try{
        Console.WriteLine("Divisione: "+(a/b));
    }catch(DivideByZeroException){
        Console.WriteLine("Stai dividendo per 0");
    }
    Console.WriteLine("Moltiplicazione: "+(a*b));
}

public delegate void ChiamaDelegato(int a,int b);
}
//--------------------------|ESERCIZIO 1|---------------------------
public interface IMezzoDiTrasporto{
    public void Avvia();
    public void Ferma();
    public int CalcolaDistanza(int km);
}

public class Automobile : IMezzoDiTrasporto{
    public Random rnd = new Random();
    private int km{get;set;}
    public Automobile(){
        this.km=0;
        Console.WriteLine("Automobile creata");
    }
    public void Avvia(){
        Console.WriteLine("Auto avviata. brum brum");
    }
    public void Ferma(){
        this.km = rnd.Next(50,100);
        Console.WriteLine("S'è stutat a machin");
    }
    public int CalcolaDistanza(int kilometri){
        return this.km-kilometri;
    }
}

public class Motocicletta : IMezzoDiTrasporto{
    public Random rnd = new Random();
    private int km{get;set;}
    public Motocicletta(){
        this.km=0;
        Console.WriteLine("Motocicletta Creata");
    }
    public void Avvia(){
        Console.WriteLine("Moto avviata. brum brum");
    }
    public void Ferma(){
        this.km = rnd.Next(50,100);
        Console.WriteLine("S'è stutat a mot");
    }
    public int CalcolaDistanza(int kilometri){
        return this.km-kilometri;
    }
}

public class BiciclettaElettrica : IMezzoDiTrasporto{
    public Random rnd = new Random();
    private int km;
    public BiciclettaElettrica(){
        this.km=0;
        Console.WriteLine("Bici elettrica avviata.");
    }
    public void Avvia(){
        Console.WriteLine("Bici avviata. Ora pedala");
    }
    public void Ferma(){
        this.km = rnd.Next(10,30);
        Console.WriteLine("Cavalletto posato");
    }
    public int CalcolaDistanza(int kilometri){
        return this.km-kilometri;
    }
}

//--------------------------|ESERCIZIO 2|---------------------------
public abstract class Veicolo{
    public abstract void GetInfo();
}

public class Auto : Veicolo{
    public override void GetInfo(){
        Console.WriteLine("Sono un'auto");
    }
}

public class Moto : Veicolo{
    public override void GetInfo(){
        Console.WriteLine("Sono una moto");
    }
}
//--------------------------|ESERCIZIO 3|---------------------------
/*
3)
Crea un sistema per una catena di ristoranti, utilizzando una classe astratta "Ristorante" che fornisce implementazioni di base
per alcune funzionalità e interfacce come IPrenotabile e IValutabile per aggiungere funzionalità specifiche come prenotazioni e recensioni.
*/

public interface IPrenotabile{
    public bool Prenotabile(int num);
}
public interface IValutabile{
    public void LasciaRecensione();
    public void Prt_Recensione(string rcn);
}
public abstract class Ristorante : IPrenotabile,IValutabile{
    private string nome;
    public string recensione;
    private int posti;
    private string tipo;
    public abstract void Prt_Info();
    public void Prt_Recensione(string r){
        Console.WriteLine(r);
    }
    public void LasciaRecensione(){
        Console.WriteLine("Scrivi la tua recensione: ");
        this.recensione = Console.ReadLine();
        Prt_Recensione();
    }
    public void Prt_Recensione(){
        Console.WriteLine(this.recensione);
    }
    public bool Prenotabile(int n){
        if(n>this.posti){
            return true;
        }
        return false;
    }
}
public class Rist : Ristorante{
    public string nome,tipo;
    public int posti;
    public Rist(string nm,int p, string tp){
        this.nome = nm;
        this.posti = p;
        this.tipo = tp;
    }
    public override void Prt_Info(){
        Console.WriteLine($"Ristorante: \n{this.nome}, {this.tipo}\nNumero posti: {this.posti}");
    }
}
//-------------------------|ESERCIZIO 5|-----------------------
/*
5) 
Sviluppare un programma console che permetta la gestione di StandardUser e SuperUser per un sistema di sicurezza.
StandardUser e Superuser sono sottoclassi di classe astratta User
StandardUser e Superuser necessitano di uno username, una descrizione del profilo e una password.
Implementare  un sistema che permetta la creazione di una password e la modifica della stessa.
Subito dopo la creazione di un nuovo profilo la password potrà essere impostata manualmente:
Le password per standardUser devono rispettare 10 caratteri di lunghezza
Le password per superUser devono rispettare 20 caratteri di lunghezza
Le password non potranno contenere caratteri vuoti
Se è gia stata impostata una password, per modificarla sarà necessario effettuare un controllo con la vecchia password.
Se una password è presente sarà possibile ( se richiesto)  generarla automaticamente: utilizzare il metodo generaPassword seguente:
Utilizza  Classe Random e genera una stringa casuale di una data lunghezza:

public static StringBuilder generaPassword(int l){
    StringBuilder builder = new StringBuilder();
    Random random = new Random();
    char ch;
    for (int i = 0; i <= l; i++){
        ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
        builder.Append(ch);
    }
    return builder;
}
Utilizzare un'interfaccia chiamata IGenerate per l'utilizzo del metodo generaPassword(int l)
Utilizzare un'interfaccia chiamata IControl per il metodo o i metodi di controllo (Login e Modifica)
*/

public interface IGenerate{
    public void generaPassword(int l);
}
public interface IControl{
    public bool Login(string nome,string pw);
    public void Modifica(string newpw);
}

public abstract class User{
    private string username{get;set;}
    private string password{get;set;}
    public User(string user,string pass){
        this.username=user;
        this.password=pass;
    }
    public abstract void createPw(int l);
    public abstract bool log(string unm,string p);
    public abstract void mod(string npw);

}
public class StandardUser : User,IControl,IGenerate{
    private string std_uname{get;set;}
    private string std_pw{get;set;}
    public StandardUser(string nome,string pass){
        this.std_uname=nome;
        this.std_pw=pass;
    }
}
